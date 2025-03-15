

using Dapper;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using System.Data;
using Tinthanh.App.General;
using Tinthanh.Data.EF;
using Tinthanh.Data.Entities;




namespace Tinthanh.App.Tiepnhan
{
    public partial class frmPhieuxuly : DevExpress.XtraEditors.XtraForm
    {
        private TinthanhDBContext? dbContext;
        int CurrentId = 0;
        bool IsNew = false;
        private Phieuxuly current=null;
        public frmPhieuxuly(int Id)
        {
            dbContext = GetdbContext.dbContext();
            InitializeComponent();
            Initialize();
            InitLookup();
            IsNew = (Id == 0);
            CurrentId = Id;

        }

        private void Initialize()
        {
            btnClose.ItemClick += delegate { Close(); };
            btnAdd.ItemClick += delegate { AddNew(); };
            btnSave.ItemClick += delegate { Save(); };
            btnRefresh.ItemClick += delegate { Loaddata(CurrentId); };
            txtMaKH.Properties.ButtonClick += Properties_ButtonClick;
            btnChonSP.ButtonClick += BtnChonSP_ButtonClick;
            gridControl2.ProcessGridKey += GridControl2_ProcessGridKey;
            FormClosing += FrmPhieuxuly_FormClosing;
            Load += FrmPhieuxuly_Load;
            btnHuyphieu.ItemClick += BtnHuyphieu_ItemClick;
            btnTaophieu.ItemClick += BtnTaophieu_ItemClick;
            btnTaoKHSP.ItemClick += BtnTaoKHSP_ItemClick;
            KeyPreview = true;
        }

       

        public Dictionary<int, string> Trangthai()
        {
            Dictionary<int, string> dc = new Dictionary<int, string>();
            dc.Add(1, "Hiệu chỉnh");
            dc.Add(2, "Tạo phiếu định giá");
            dc.Add(3, "Tạo thông tin KHSP");
            dc.Add(4, "Hoàn thành");
            dc.Add(5, "Hủy");

            return dc;

        }

        public Dictionary<int, string> Kiemtra()
        {
            Dictionary<int, string> dc = new Dictionary<int, string>();
            dc.Add(1, "Có");
            dc.Add(2, "Không");
            dc.Add(3, "Theo yêu cầu");
            return dc;
        }

        private void InitLookup()
        {
            btnKhomay.Properties.DataSource = Thuvien.GetKhomay();
            btnKhomay.Properties.DisplayMember = "Ten";
            btnKhomay.Properties.ValueMember = "Ma";
            btnKhomay.Properties.BestFit();

            lkTrangthai.Properties.DataSource = new BindingSource(Trangthai(), null);
            lkTrangthai.Properties.DisplayMember = "Value";
            lkTrangthai.Properties.ValueMember = "Key";
            lkTrangthai.Properties.BestFit();

            lkKiemtra.Properties.DataSource = new BindingSource(Kiemtra(), null);
            lkKiemtra.Properties.DisplayMember = "Value";
            lkKiemtra.Properties.ValueMember = "Key";
            lkKiemtra.Properties.BestFit();
        }
        private void BtnHuyphieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Huyphieu();
        }

        private void GridControl2_ProcessGridKey(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && e.Modifiers == Keys.Control)
            {
                if (MessageBox.Show("Xóa dòng hiện hành ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    gridView1.DeleteSelectedRows();
                // Save();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Insert && e.Modifiers == Keys.Control)
            {
                // Khi nhấn Ctrl+Ins, thêm dòng mới
                gridView1.AddNewRow();

                e.Handled = true;
            }
        }

        private void Properties_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 0)
            {
                using (frmTim frm = new frmTim("KhachhangGD", 1))

                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        txtMaKH.EditValue = frm.Ma;
                        txtTenKH.EditValue = frm.Ten;

                    }
            }


        }

        private void BtnChonSP_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 0)
            {


                using (frmTimdanhdiem frm = new frmTimdanhdiem("ThanhphamGD", 1))

                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        GridView view = gridView1;
                        if (view.IsNewItemRow(view.FocusedRowHandle))
                        {
                            view.AddNewRow();

                        }

                        view.SetRowCellValue(view.FocusedRowHandle, "Tensp", frm.Ten);
                        view.SetRowCellValue(view.FocusedRowHandle, "Masp", frm.Ma);
                        view.SetRowCellValue(view.FocusedRowHandle, "Donvi", frm.Donvi);
                        view.FocusedColumn = view.Columns["Thetich"];
                        view.ShowEditor();
                    }

            }

        }
        private void FrmPhieuxuly_Load(object? sender, EventArgs e)
        {
            if (CurrentId > 0) Loaddata(CurrentId);
            else AddNew();
        }

        private void Loaddata(int Id)
        {
            if (dbContext != null)
            {

                current= dbContext.Phieuxulys.Find(Id);

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
            current = bdSource.Current as Phieuxuly;
            txtMaphieu.EditValue = Dungchung.Getmachungtu(DateTime.Today, "PXL");
            txtMaKH.Focus();
            LoadCT();
            IsNew = true;
        }

        private void LoadCT()
        {
            
            if (current != null && dbContext != null)
            {
                dbContext.Entry(current).Collection(e => e.PhieuxulyCTs).Load();
                  
                gridControl2.DataSource = current.PhieuxulyCTs;  
                gridView1.BestFitColumns();
            }
        }

        private void Save()
        {
            bdSource.EndEdit();

            if (IsNew && current != null)
            {
                dbContext?.Phieuxulys.Add(current);
            }
            dbContext?.SaveChanges();
            IsNew = false;
        }

        private void FrmPhieuxuly_FormClosing(object? sender, FormClosingEventArgs e)
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
                    e.Cancel = true; // Hủy bỏ đóng form
                };
            }
        }

        private void BtnTaophieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
            if (dbContext!.ChangeTracker.HasChanges() || IsNew) Save();

            int Maphieu = Taophieudinhgia();
            if (Maphieu > 0)
            {
                using (frmPhieudinhgia frm = new frmPhieudinhgia(Convert.ToInt32(Maphieu)))
                    frm.ShowDialog();
            }
            else MessageBox.Show("Không thể tạo phiếu xử lý !!!");
        }


        
       
        public int Taophieudinhgia()
        {
            if (MessageBox.Show("Tạo phiếu định giá ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    bdSource.EndEdit();

                    string Ten = "Proc_ChuyenYCXL_Dinhgia";
                    DynamicParameters para = new DynamicParameters();
                    para.Add("@Id", current.Id, DbType.Int32, ParameterDirection.Input);
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

        private void BtnTaoKHSP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (current.Trangthai > 2)
            {
                MessageBox.Show("Phiếu này đã bị khóa !! ");
                return;
            }
            if (dbContext!.ChangeTracker.HasChanges() || IsNew) Save();

            int Maphieu = TaophieuTTKHSP();
            if (Maphieu > 0)
            {
                using (frmPhieudinhgia frm = new frmPhieudinhgia(Convert.ToInt32(Maphieu)))
                    frm.ShowDialog();
            }
            else MessageBox.Show("Không thể tạo phiếu  !!!");
        }
      
        public int TaophieuTTKHSP()
        {
            if (MessageBox.Show("Tạo phiếu thông tin KHSP ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    bdSource.EndEdit();

                    string Ten = "Proc_ChuyenYCXL_TTKHSP";
                    DynamicParameters para = new DynamicParameters();
                    para.Add("@Id", current.Id, DbType.Int32, ParameterDirection.Input);
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
        
        public void Huyphieu()
        {
            if (MessageBox.Show("Hủy phiếu xử lý này ? ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                SQLHelper.ExecQueryNonData("Update Phieuxuly set Trangthai=5 where Id=@id", new { @id = CurrentId });
                Loaddata(CurrentId);
                MessageBox.Show("Phiếuxử lý đã được hủy !!");
            }
        }
        
        


        
    }
}