

using Dapper;
using DevExpress.XtraGrid.Views.Grid;

using System.Data;
using Tinthanh.App.General;
using Tinthanh.Data.EF;
using Tinthanh.Data.Entities;


namespace Tinthanh.App.Tiepnhan
{
    public partial class frmPhieuyeucau : DevExpress.XtraEditors.XtraForm
    {
        private TinthanhDBContext? dbContext;
        int CurrentId = 0;
        bool IsNew = false;
        private Phieuyeucau current;
        public frmPhieuyeucau(int Id)
        {

            dbContext = GetdbContext.dbContext();
            InitializeComponent();
            Initialize();
            InitLookup();

            IsNew = (Id == 0);
            CurrentId = Id;

        }


        public Dictionary<int, string> Trangthai()
        {
            Dictionary<int, string> dc = new Dictionary<int, string>();
            dc.Add(1, "Nhận yêu cầu");
            dc.Add(2, "Chờ xử lý");
            dc.Add(3, "Có kết quả xử lý");
            dc.Add(4, "Đã lập báo giá");
            dc.Add(5, "Hủy");
            return dc;

        }
        public Dictionary<int, string> Loaimau()
        {
            Dictionary<int, string> dc = new Dictionary<int, string>();
            dc.Add(1, "Mốp");
            dc.Add(2, "Sản phẩm");
            dc.Add(3, "Bản vẽ");
            dc.Add(4, "Khuôn");
            return dc;

        }

        public Dictionary<int, string> Xuly()
        {
            Dictionary<int, string> dc = new Dictionary<int, string>();

            dc.Add(1, "Nội bộ");
            dc.Add(2, "Bên ngoài");


            return dc;

        }

        public Dictionary<int, string> Yeucau()
        {
            Dictionary<int, string> dc = new Dictionary<int, string>();

            dc.Add(1, "Báo giá khuôn+sản phẩm");
            dc.Add(2, "Thử mẫu,kiểm tra ,SC khuôn");

            return dc;

        }

        public Dictionary<int, string> Tuychon()
        {
            Dictionary<int, string> dc = new Dictionary<int, string>();
            dc.Add(1, "Lần");
            dc.Add(2, "Tháng");
            dc.Add(3, "Năm");
            dc.Add(4, "Theo PO");

            return dc;

        }
        private void Initialize()
        {
            btnClose.ItemClick += delegate { Close(); };
            btnAdd.ItemClick += delegate { AddNew(); };
            btnSave.ItemClick += delegate { Save(); };
            btnRefresh.ItemClick += delegate { Loaddata(CurrentId); };
            txtMakh.Properties.ButtonClick += Properties_ButtonClick;
            btnChonSP.ButtonClick += BtnChonSP_ButtonClick;
            btnTaophieu.ItemClick += BtnTaophieu_ItemClick;
            btnHuyphieu.ItemClick += BtnHuyphieu_ItemClick;
             
            gridControl2.ProcessGridKey += GridControl2_ProcessGridKey;
            FormClosing += FrmPhieuyeucau_FormClosing;
            Load += FrmPhieuyeucau_Load;
            KeyPreview = true;
        }


        private void FrmPhieuyeucau_Load(object? sender, EventArgs e)
        {
            if (CurrentId > 0) Loaddata(CurrentId);
            else AddNew();
        }

        private void InitLookup()
        {

            lkKhomay.DataSource = Thuvien.GetKhomay();
            lkKhomay.DisplayMember = "Ten";
            lkKhomay.ValueMember = "Ma";
            lkKhomay.BestFit();
            //Loai mau
            lkLoaiSP.DataSource = new BindingSource(Loaimau(), null);
            lkLoaiSP.DisplayMember = "Value";
            lkLoaiSP.ValueMember = "Key";
            lkLoaiSP.BestFit();
            //Xu ly
            lkXuly.DataSource = new BindingSource(Xuly(), null);
            lkXuly.DisplayMember = "Value";
            lkXuly.ValueMember = "Key";
            lkXuly.BestFit();

            //yeucau
            lkYeucau.DataSource = new BindingSource(Yeucau(), null);
            lkYeucau.DisplayMember = "Value";
            lkYeucau.ValueMember = "Key";
            lkYeucau.BestFit();

            //Tuychon
            lkLanthang.DataSource = new BindingSource(Tuychon(), null);
            lkLanthang.DisplayMember = "Value";
            lkLanthang.ValueMember = "Key";
            lkLanthang.BestFit();
            //Trang thai
            lkTrangthai.Properties.DataSource = new BindingSource(Trangthai(), null);
            lkTrangthai.Properties.DisplayMember = "Value";
            lkTrangthai.Properties.ValueMember = "Key";
            lkTrangthai.Properties.BestFit();

            lkDonvi.DataSource = Thuvien.GetDonvi();
            lkDonvi.DisplayMember = "Ten";
            lkDonvi.ValueMember = "Ma";
            lkDonvi.BestFit();


        }
        public void Loaddata(int Id)
        {
            if (dbContext != null)
            {
                if (Id > 0) current = dbContext.Phieuyeucaus.Find(Id) ;

                if (current != null)
                {
                    bdSource.DataSource = current;
                    LoadCT();

                }

            }

        }



        private void AddNew()
        {
            if (dbContext!.ChangeTracker.HasChanges() || IsNew) Save();
            bdSource.AddNew();
            current = bdSource.Current as Phieuyeucau;
            txtMaphieu.EditValue = Dungchung.Getmachungtu(DateTime.Today, "PTN");
            txtMakh.Focus();
            LoadCT();
            IsNew = true;
        }
        private void LoadCT()
        {
           
            if (current != null && dbContext != null)
            {
                dbContext.Entry(current).Collection(e => e.PhieuyeucauCTs).Load();

                gridControl2.DataSource = current.PhieuyeucauCTs;
                gridView2.BestFitColumns();
            }
        }
        private void Save()
        {
            bdSource.EndEdit();
         

            if (current != null && current.Trangthai > 1)
            {
                MessageBox.Show("Không thể hiệu chỉnh phiếu này !!! ");
                return;
            }


            if (IsNew && current != null)
            {
                dbContext?.Phieuyeucaus.Add(current);
            }
            dbContext?.SaveChanges();
            IsNew = false;
        }

        private void BtnHuyphieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Huyphieu();
        }

        public void Huyphieu()
        {
            if (MessageBox.Show("Hủy phiếu yêu cầu này ? ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                SQLHelper.ExecQueryNonData("Update phieuyeucau set Trangthai=5 where Id=@id", new { @id = CurrentId });
                Loaddata(CurrentId);
                MessageBox.Show("Phiếu yêu cầu đã được hủy !!");
            }
        }
        private void FrmPhieuyeucau_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (dbContext!.ChangeTracker.HasChanges() || IsNew)

            {
                var result = MessageBox.Show("Bạn có muốn lưu thay đổi?", "Xác nhận", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        Save();
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
                    e.Cancel = true; // Hủy bỏ đóng form
                }
            }
        }

        private void GridControl2_ProcessGridKey(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && e.Modifiers == Keys.Control)
            {
                if (MessageBox.Show("Xóa dòng hiện hành ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    gridView2.DeleteSelectedRows();
                // Save();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Insert && e.Modifiers == Keys.Control)
            {
                // Khi nhấn Ctrl+Ins, thêm dòng mới
                gridView2.AddNewRow();

                e.Handled = true;
            }
        }

        private void BtnChonSP_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {


                using (frmTimdanhdiem frm = new frmTimdanhdiem("ThanhphamGD", 1))

                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        GridView view = gridView2;
                        if (view.IsNewItemRow(view.FocusedRowHandle))
                        {
                            view.AddNewRow();

                        }

                        view.SetRowCellValue(view.FocusedRowHandle, "Tensp", frm.Ten);
                        view.SetRowCellValue(view.FocusedRowHandle, "Masp", frm.Ma);
                        view.SetRowCellValue(view.FocusedRowHandle, "Donvi", frm.Donvi);
                        view.FocusedColumn = view.Columns["SoluongDH"];
                        view.ShowEditor();
                    }

            }

            if (e.Button.Index == 0)
            {
                if (MessageBox.Show("Thêm sản phẩm báo giá", "Hệ thống", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                    using (frmThemDanhdiem frm = new frmThemDanhdiem())

                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            GridView view = gridView2;
                            if (view.IsNewItemRow(view.FocusedRowHandle))
                            {
                                view.AddNewRow();

                            }
                            view.SetRowCellValue(view.FocusedRowHandle, "Tensp", frm.Ten);
                            view.SetRowCellValue(view.FocusedRowHandle, "Masp", frm.Ma);
                            view.SetRowCellValue(view.FocusedRowHandle, "Donvi", frm.Donvi);
                            view.FocusedColumn = view.Columns["Soluong"];
                            view.ShowEditor();
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
                        txtMakh.EditValue = frm.Ma;
                        txtTenKH.EditValue = frm.Ten;
                        GetLienhe(frm.Id);

                    }
            }

            if (e.Button.Index == 0)
            {
                if (MessageBox.Show("Thêm khách hàng tiềm năng", "Hệ thống", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                    using (frmThemdoituong frm = new frmThemdoituong("Thêm khách hàng tiềm năng", "KhachhangTN"))

                        if (frm.ShowDialog() == DialogResult.OK)
                        {

                            txtMakh.EditValue = frm.Ma;
                            txtTenKH.EditValue = frm.Ten;
                            txtDiachi.EditValue = frm.Diachi;
                            txtDienthoai.EditValue = frm.Dienthoai;
                            txtLienhe.EditValue = frm.Lienhe;

                        }
            }
        }


        public void GetLienhe(int KhachhangId)
        {

            DataTable dt = SQLHelper.ExecQueryDataAsDataTable("Select top 1 Hoten ,dienthoai from lienlackh where KhachhangId=@Makh and PhanloaiId=1", new { @Makh = KhachhangId });
            if (dt.Rows.Count > 0)
            {
                txtLienhe.EditValue = dt.Rows[0]["Hoten"].ToString();
                txtDienthoai.EditValue = dt.Rows[0]["Dienthoai"].ToString();
            }

            DataTable dt1 = SQLHelper.ExecQueryDataAsDataTable("Select  Diachi  from Khachhang where Id=@Makh ", new { @Makh = KhachhangId });
            if (dt1.Rows.Count > 0)
            {
                txtDiachi.EditValue = dt1.Rows[0]["Diachi"].ToString();
            }

        }

        private void BtnTaophieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            
            if (dbContext!.ChangeTracker.HasChanges() || IsNew) Save();

            int Maphieu = Taophieuxuly();
            if (Maphieu > 0)
            {
                using (frmPhieuxuly frm = new frmPhieuxuly(Convert.ToInt32(Maphieu)))
                    frm.ShowDialog();
            }
            else MessageBox.Show("Không thể tạo phiếu xử lý !!!");
        }

        public int Taophieuxuly()
        {
            if (MessageBox.Show("Tạo phiếu xử lý từ phiếu yêu cầu này ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    bdSource.EndEdit();

                    string Ten = "pr_ChuyenYC_YCXL";
                    DynamicParameters para = new DynamicParameters();
                    para.Add("@Id", CurrentId, DbType.Int32, ParameterDirection.Input);
                    para.Add("@Users", Dungchung.un, DbType.String, ParameterDirection.Input);
                    para.Add("@Machungtu", null, dbType: DbType.Int32, direction: ParameterDirection.Output, 0);

                    SQLHelper.ExecProcedureNonData(Ten, para);

                    return para.Get<int>("@Machungtu");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
            return 0;
        }

    }
}