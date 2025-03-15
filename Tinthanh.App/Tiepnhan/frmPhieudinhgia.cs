

using Dapper;

using System.Data;
using Tinthanh.App.General;
using Tinthanh.Data.EF;
using Tinthanh.Data.Entities;

namespace Tinthanh.App.Tiepnhan
{

    public partial class frmPhieudinhgia : DevExpress.XtraEditors.XtraForm
    {
        private TinthanhDBContext? dbContext;
        int CurrentId = 0;
        bool IsNew = false;
        private string TenDN = "";
        private Single GiaDN = 0;
        private int Chon = 0;
        public frmPhieudinhgia(int Id)
        {
            InitializeComponent();

            dbContext = GetdbContext.dbContext();
        
            Initialize();
            InitLookup();

            IsNew = (Id == 0);
            CurrentId = Id;


        }

        private void Initialize()
        {
            Load += FrmPhieudinhgia_Load;

            btnAdd.ItemClick += delegate { AddNew(); };

            btnSave.ItemClick += delegate { Save(); };

            btnClose.ItemClick += delegate { Close(); };
            btnRefresh.ItemClick += delegate { Loaddata(CurrentId); };
            FormClosing += FrmPhieudinhgia_FormClosing;
            btnKhachhang.Properties.ButtonClick += Properties_ButtonClick;
            btnChonSP.Properties.ButtonClick += Properties_ButtonClick1;
            btnKhuon.Properties.ButtonClick += Properties_ButtonClick2;
            btnGiachon.Properties.ButtonClick += Properties_ButtonClick3;
            btnChongia.Click += BtnChongia_Click;
            btnKiemtra.Click += BtnKiemtra_Click;
            btnHoanthanh.Click += BtnHoanthanh_Click;
        }

      

        private void Properties_ButtonClick2(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                using (frmTim frm = new frmTim("KhuonBG", 1))

                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        btnKhuon.EditValue = frm.Ma;
                        txtTenkhuon.EditValue = frm.Ten;
                        

                    }
            }

            if (e.Button.Index == 0)
            {
                if (MessageBox.Show("Thêm khuôn báo giá mới", "Hệ thống", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                    using (frmThemDanhdiem frm = new frmThemDanhdiem())

                        if (frm.ShowDialog() == DialogResult.OK)
                        {

                            btnKhuon.EditValue = frm.Ma;
                            txtTenkhuon.EditValue = frm.Ten;
                        }
            }
        }

        private void Properties_ButtonClick1(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 0)
            {

                using (frmTimdanhdiem frm = new frmTimdanhdiem("ThanhphamGD", 1))
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        btnChonSP.EditValue = frm.Ma;
                        txtTensp.EditValue = frm.Ten;

                    }
            }

        }

        private void Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                using (frmTim frm = new frmTim("KhachhangGD", 1))

                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        btnKhachhang.EditValue = frm.Ma;
                        txtTenkh.EditValue = frm.Ten;


                    }
            }
        }

        private void FrmPhieudinhgia_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (dbContext!.ChangeTracker.HasChanges() || IsNew)

            {
                var result = MessageBox.Show("Bạn có muốn lưu thay đổi?", "Xác nhận", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        dbContext.SaveChanges();
                        this.DialogResult = DialogResult.OK;
                    }
                    catch (Exception ex)
                    {
                        // Xử lý lỗi
                        MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message);
                        e.Cancel = true; // Ngăn không cho form đóng
                    }
                }
                else if (result == DialogResult.Cancel)
                {
                    this.DialogResult = DialogResult.Cancel;
                    e.Cancel = true; // Hủy bỏ đóng form
                }
            }
        }

        private void FrmPhieudinhgia_Load(object? sender, EventArgs e)
        {
            if (CurrentId > 0) Loaddata(CurrentId);
            else AddNew();
        }

        private void AddNew()
        {
            if (dbContext!.ChangeTracker.HasChanges() || IsNew) Save();


            bdSource.AddNew();

            txtMaphieu.EditValue = Dungchung.Getmachungtu(DateTime.Today, "PDG");
            btnKhachhang.Focus();
            //LoadCT();
            IsNew = true;
        }

        private void Save()
        {
            bdSource.EndEdit();

            var currentPhieudinhgia = bdSource.Current as Phieudinhgia;

            if (IsNew && currentPhieudinhgia != null)
            {
                dbContext?.Phieudinhgias.Add(currentPhieudinhgia);
            }
            dbContext?.SaveChanges();
            IsNew = false;
        }

        private void Loaddata(int Id)
        {
            if (dbContext != null)
            {

                var data = dbContext.Phieudinhgias.Find(Id);

                if (data != null)
                {
                    bdSource.DataSource = data;
                    //LoadCT();
                }

            }
        }

        public Dictionary<int, string> Trangthai()
        {
            Dictionary<int, string> dc = new Dictionary<int, string>();
            dc.Add(1, "Đang hiệu chỉnh");
            dc.Add(2, "Đã lập báo giá");
            dc.Add(3, "Hoàn thành");
            dc.Add(4, "Hủy");


            return dc;

        }
        private void InitLookup()
        {
            //kho may
            lkKhomay.Properties.DataSource = Thuvien.GetKhomay();
            lkKhomay.Properties.DisplayMember = "Ten";
            lkKhomay.Properties.ValueMember = "Ma";
            lkKhomay.Properties.BestFit();
            //Loai mau

            //Trang thai
            lkTrangthai.Properties.DataSource = new BindingSource(Trangthai(), null);
            lkTrangthai.Properties.DisplayMember = "Value";
            lkTrangthai.Properties.ValueMember = "Key";
            lkTrangthai.Properties.BestFit();


        }

        private void BtnChongia_Click(object? sender, EventArgs e)
        {
            gridControl1.DataSource = Chongiathamkhao();
            gridView1.BestFitColumns();
            bdSource.ResetBindings(false);
        }
        private DataTable Chongiathamkhao()
        {
            DataTable? dt = null;
            try
            {
                bdSource.EndEdit();
                Phieudinhgia? current = bdSource.Current as Phieudinhgia;

                if (current != null)
                {
                    string Ten = "pr_Thamkhaogia";
                    DynamicParameters para = new DynamicParameters();
                    para.Add("@Makh", current.Makh, DbType.String, ParameterDirection.Input);
                    para.Add("@Titrong", current.Titrong, DbType.Double, ParameterDirection.Input);
                    para.Add("@Trongluong", current.Khoiluong, DbType.Double, ParameterDirection.Input);
                    para.Add("@SaisoTT", current.SaisoTT, DbType.Double, ParameterDirection.Input);
                    para.Add("@SaisoTL", current.SaisoKL, DbType.Double, ParameterDirection.Input);
                    para.Add("@Masp", current.Masp, DbType.String, ParameterDirection.Input);
                    para.Add("@TenTC", current.TenTC, DbType.String, ParameterDirection.Input);
                    para.Add("@Cokhuon", current.Khomay, DbType.String, ParameterDirection.Input);
                    para.Add("@Xetcokhuon", current.Choncokhuon, DbType.Boolean, ParameterDirection.Input);
                    para.Add("@GiaTC", null, dbType: DbType.Single, direction: ParameterDirection.Output, 0);
                    para.Add("@Tengia", null, dbType: DbType.String, direction: ParameterDirection.Output, 100);

                    dt = SQLHelper.ExecProcedureDataAsDataTable(Ten, para);
                    GiaDN = para.Get<Single>("@GiaTC");
                    TenDN = para.Get<string>("@Tengia");

                    current.Gia5 = GiaDN + 2 * current.Buocgia;
                    current.Gia4 = GiaDN + current.Buocgia;
                    current.Gia3 = GiaDN;
                    current.Gia2 = GiaDN - current.Buocgia;
                    current.Gia1 = GiaDN - 2 * current.Buocgia;
                    current.Giachon = GiaDN;
                    current.Ghichu = TenDN + "-Đơn giá KG : " + GiaDN.ToString();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }

        private void BtnKiemtra_Click(object? sender, EventArgs e)
        {
            Kiemtra();
            bdSource.ResetBindings(false);
        }


        public void Kiemtra()
        {

            try
            {
                bdSource.EndEdit();
                Phieudinhgia? current = bdSource.Current as Phieudinhgia;
                if (current != null)
                {
                    string Ten = "pr_LoinhuanCK";
                    DynamicParameters para = new DynamicParameters();
                    para.Add("@Id", current.Id, DbType.Int32, ParameterDirection.Input);
                    para.Add("@Gia1", null, dbType: DbType.Single, direction: ParameterDirection.Output, 0);
                    para.Add("@Gia2", null, dbType: DbType.Single, direction: ParameterDirection.Output, 0);
                    para.Add("@Gia3", null, dbType: DbType.Single, direction: ParameterDirection.Output, 0);
                    para.Add("@Gia4", null, dbType: DbType.Single, direction: ParameterDirection.Output, 0);
                    para.Add("@Gia5", null, dbType: DbType.Single, direction: ParameterDirection.Output, 0);
                    para.Add("@Loai", null, dbType: DbType.Int32, direction: ParameterDirection.Output, 0);

                    SQLHelper.ExecProcedureNonData(Ten, para);

                    Chon = para.Get<Int32>("@Loai");
                    switch (Chon)
                    {
                        case 0:
                            current.Giachon = para.Get<Single>("@Gia5");
                            break;

                        case 1:
                            current.Giachon = para.Get<Single>("@Gia1");
                            break;
                        case 2:
                            current.Giachon = para.Get<Single>("@Gia3");
                            break;
                    }
                    if (Chon == 2)


                        current.Ghichu = TenDN + "-Đơn giá KG : " + current.Giachon.ToString();
                    else
                        current.Ghichu = "Đơn giá KG : " + current.Giachon.ToString();

                    Save();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }


        private void Taophieudinhgia()
        {
            //int i = vm.Taophieudinhgia();

            //if (i > 0)
            //    MessageBox.Show("Đã tạo phiếu định giá số " + i.ToString());
            //else MessageBox.Show("Lệnh bị hủy ");
        }

        private void Taophieubaogia()
        {
            //int i = vm.Taophieubaogia();

            //if (i > 0)
            //    MessageBox.Show("Đã tạo báo giá số " + i.ToString());
            //else MessageBox.Show("Lệnh bị hủy ");
        }

        private void btnTaophieuDinhgia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Taophieudinhgia();
        }

        private void btnHuyphieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //  vm.Huyphieu();
        }

      

        private void BtnHoanthanh_Click(object? sender, System.EventArgs e)
        {
            HoanthanhDinhgia();
            bdSource.ResetBindings(false);
        }



        public void HoanthanhDinhgia()
        {

            try
            {
                bdSource.EndEdit();
                var current = bdSource.Current as Phieudinhgia;
                if (current != null)
                {
                    string Ten = "pr_Hoanthanhdinhgia";
                    DynamicParameters para = new DynamicParameters();
                    para.Add("@Id", current.Id, DbType.Int32, ParameterDirection.Input);
                    para.Add("@Loai", Chon, DbType.Int32, ParameterDirection.Input);
                    SQLHelper.ExecProcedureNonData(Ten, para);
                    Save();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
        private void btnTaophieubaogia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Taophieubaogia();
        }

        public void Ghigia()
        {
            bdSource.EndEdit();
            var current = bdSource.Current as Phieudinhgia;
            if (current != null)
            {
                current.Gia5 = current.Giachon + 2 * current.Buocgia;
                current.Gia4 = current.Giachon + current.Buocgia;
                current.Gia3 = current.Giachon;
                current.Gia2 = current.Giachon - current.Buocgia;
                current.Gia1 = current.Giachon - 2 * current.Buocgia;
            }
        }
        private void Properties_ButtonClick3(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 0)
            {
                Ghigia();
                bdSource.ResetBindings(false);
            }
        }


         
    }
}