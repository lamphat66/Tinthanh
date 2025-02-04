
using Dapper;
using DevExpress.XtraGrid.Views.Base;
using System.Data;
using Tinthanh.App.General;
using Tinthanh.Data.EF;
using Tinthanh.Data.Entities;


namespace Tinthanh.App.Danhmuc
{
    public partial class frmKhachhang : DevExpress.XtraEditors.XtraForm
    {
        private readonly TinthanhDBContext dbContext;
        bool IsNew = false;
        public frmKhachhang()
        {
            dbContext = GetdbContext.dbContext();
            InitializeComponent();
            btnClose.ItemClick += delegate { this.Close(); };
            gridControl2.ProcessGridKey += GridControl2_ProcessGridKey;
            gridView2.RowUpdated += GridView2_RowUpdated;
          
            btnClose.ItemClick += delegate { this.Close(); };
            btnAdd.ItemClick += delegate
            {
                Add();
            };
            btnDelete.ItemClick += BtnDelete_ItemClick;
            btnSave.ItemClick += delegate { Save(); };
            btnRefresh.ItemClick += delegate { LoadDanhsach(0, txtFind.Text); };
            this.FormClosing += FrmKhachhang_FormClosing;
            LoadLookup();
        }

        private void GridControl2_ProcessGridKey(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && e.Modifiers == Keys.Control)
            {
                // Khi nhấn Ctrl+Delete, xóa dòng hiện tại
                gridView2.DeleteSelectedRows();
               // Save();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Insert && e.Modifiers == Keys.Control)
            {
                // Khi nhấn Ctrl+Ins, thêm dòng mới
                gridView2.AddNewRow();
                gridView2.ShowEditForm();
                e.Handled = true;
            }
        }

        private void LoadLookup()
        {
            var Nhomdt = dbContext.Nhomdoituongs
                .Where(p => p.Madt == "KH")
                .ToList();
            lkNhom.Properties.DataSource = Nhomdt;
            lkNhom.Properties.DisplayMember = "Ten";
            lkNhom.Properties.ValueMember = "Ma";
            lkNhom.Properties.BestFit();

            var khuvuc = dbContext.Khuvucs

                .ToList();
            lkKhuvuc.Properties.DataSource = khuvuc;
            lkKhuvuc.Properties.DisplayMember = "Ten";
            lkKhuvuc.Properties.ValueMember = "Ma";
            lkKhuvuc.Properties.BestFit();

            var Phanloai = dbContext.DanhmucCTs
                .Where(p => p.DanhmucId == 200)
                .ToList();
            cboPhanloai.DataSource = Phanloai;
            cboPhanloai.DisplayMember = "Ten";
            cboPhanloai.ValueMember = "Ma";
            cboPhanloai.BestFit();
        }
        private void FrmKhachhang_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (dbContext!.ChangeTracker.HasChanges()|| IsNew)
            {
                var result = MessageBox.Show("Bạn có muốn lưu thay đổi?", "Xác nhận", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        dbContext.SaveChanges();
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

        private void BtnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Xóa khách hàng hiện hành ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var m = bdSource.Current as Khachhang;
               

                var r = dbContext.Khachhangs.Find(m.Ma);
                if (r != null)
                {
                   gridView1.DeleteSelectedRows();
                    dbContext.Khachhangs.Remove(r);
                    dbContext.SaveChanges();
                }

                 
            }
        }

        private void Save()
        {
            bdSource.EndEdit();
            if (IsNew ) dbContext.Khachhangs.Add(bdSource.Current as Khachhang);
            dbContext.SaveChanges();
            IsNew = false;
        }

        private void GridView2_RowUpdated(object sender, RowObjectEventArgs e)
        {
            //Save();
        }

        private void LoadDanhsach(int Loai, string filter = "")
        {
            var data = GetDataDanhsach(Loai, filter);
            
            gridControl1.DataSource = data;
            if (gridView1.DataRowCount > 0)
            {

                gridView1.FocusedRowHandle = 0; // Đặt dòng đầu tiên làm dòng được chọn
                gridView1_FocusedRowChanged(null, null);
            }
        }
        private void frmKhachhang_Load(object sender, EventArgs e)
        {
            LoadDanhsach(1, txtFind.Text);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            LoadDanhsach(2, txtFind.Text);
        }
              

        public DataTable GetDataDanhsach(int Loai, string filter)
        {
            string Ten = "pr_Timdanhsach";

            DynamicParameters para = new DynamicParameters();
            para.Add("@Tenbang", "Khachhang", DbType.String, ParameterDirection.Input);
            para.Add("@Somautin", Loai, DbType.Int32, ParameterDirection.Input);
            para.Add("@Ten", filter, DbType.String, ParameterDirection.Input);
            return SQLHelper.ExecProcedureDataAsDataTable(Ten, para);
    
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (dbContext!.ChangeTracker.HasChanges()||IsNew) Save();
                if (gridView1.RowCount>0)
            {
                int  Id =(Int32) gridView1.GetFocusedRowCellValue("Id");

                Khachhang? kh = dbContext.Khachhangs.Find(Id);
                bdSource.DataSource = kh;
                Loadlienlac();
                LoadBangia(Id);
                LoadKhuon(Id);

            }

        }

        private void txtFind_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnFind.PerformClick();
        }
        private void Loadlienlac()
        {
            var data = bdSource.Current as Khachhang;

            if (data != null)
            {
                this.dbContext.Entry(data).Collection(e => e.LienlacKHs).Load();
                bdLienlac.DataSource = data.LienlacKHs;
                gridControl2.DataSource = bdLienlac;


            }

         
        }

        private void Add()
        {
            if (dbContext!.ChangeTracker.HasChanges() || IsNew) Save();

            IsNew = true;
            bdSource.EndEdit();
            bdSource.AddNew();
            txtMa.Focus();
            txtMa.EditValue =  Dungchung.Sinhmadoituong("KH", 4);
            txtTen.Focus();
            Loadlienlac();

        }

        public DataTable BanggiaKH(int Ma)
        {
            string Ten = "[pr_BanggiaKH]";

            DynamicParameters para = new DynamicParameters();
            para.Add("@KhachhangId", Ma, DbType.Int32, ParameterDirection.Input);
            return SQLHelper.ExecProcedureDataAsDataTable(Ten, para);
        }
        void LoadBangia(int ma)
        {

            gridControl3.DataSource = BanggiaKH(ma);
            gridView3.BestFitColumns();

        }

        public DataTable Khuonsohuu(int Ma)
        {
            string Ten = "[pr_Khuonsohuu]";

            DynamicParameters para = new DynamicParameters();
            para.Add("@KhachhangId", Ma, DbType.Int32, ParameterDirection.Input);
            return SQLHelper.ExecProcedureDataAsDataTable(Ten, para);
        }
        void LoadKhuon(int ma)
        {

            gridControl4.DataSource = Khuonsohuu(ma);
            gridView4.BestFitColumns();

        }
    }
}