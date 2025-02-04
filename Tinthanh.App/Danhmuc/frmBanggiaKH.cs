using Dapper;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using System.Data;
using Tinthanh.App.General;
using Tinthanh.Data.EF;
using Tinthanh.Data.Entities;


namespace Tinthanh.App.Danhmuc
{
    public partial class frmBanggiaKH : XtraForm
    {
        private readonly TinthanhDBContext dbContext;
        bool IsNew = false;
        int khachhangId=0;
        public frmBanggiaKH()
        {
            InitializeComponent();

            dbContext = GetdbContext.dbContext();
            this.Load += FrmDonvi_Load;
            this.FormClosing += FrmDonvi_FormClosing;
            gridView2.FocusedRowChanged += GridView2_FocusedRowChanged;
            txtFind.KeyDown += TxtFind_KeyDown;
            btnFind.Click += BtnFind_Click;
            gridView1.RowUpdated += GridView1_RowUpdated;
        }

        private void GridView1_RowUpdated(object sender, RowObjectEventArgs e)
        {
            if (e.RowHandle == GridControl.NewItemRowHandle)
            {

                var d = bdSource.Current as BanggiaKH;
                if (d != null)
                {
                    d.KhachhangId = khachhangId;
                    dbContext.BanggiaKHs.Add(d);
                }

            }
            Save();
            IsNew = false;
        }

        private void BtnFind_Click(object? sender, EventArgs e)
        {
            LoadDanhsach(2, txtFind.Text);
        }

        private void TxtFind_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnFind.PerformClick();
        }

        private void GridView2_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (dbContext!.ChangeTracker.HasChanges() || IsNew) Save();
            if (gridView2.RowCount > 0)
            {
              khachhangId =(Int32) gridView2.GetFocusedRowCellValue("Id");

                Khachhang? kh = dbContext.Khachhangs.Find(khachhangId);
                bdSource.DataSource = kh;
                Loaddata(khachhangId);

            }
        }

        private void LoadDanhsach(int Loai, string filter = "")
        {
            var data = GetDataDanhsach(Loai, filter);

            gridControl2.DataSource = data;
            if (gridView2.DataRowCount == 1)
            {
                gridView2.FocusedRowHandle = 0; // Đặt dòng đầu tiên làm dòng được chọn
                GridView2_FocusedRowChanged(null, null);
            }
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


        private void Loaddata(int kh)
        {
           
            var data = this.dbContext?.BanggiaKHs.Where(x => x.KhachhangId == kh).ToList();

            this.bdSource.DataSource = data;
            gridView1.BestFitColumns();

        }
       
        private void FrmDonvi_Load(object? sender, EventArgs e)
        {
            LoadDanhsach(1, txtFind.Text);
           
            
        }

        private void FrmDonvi_FormClosing(object? sender, FormClosingEventArgs e)
        {
            bdSource.EndEdit();
            if (dbContext.ChangeTracker.HasChanges())
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

        private void Save()
        {
            try
            {
                bdSource.EndEdit();
                this.dbContext!.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        


        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.AddNewRow();
            
        }



        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Xóa 1 mẫu tin ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dbContext.BanggiaKHs.Remove(bdSource.Current as BanggiaKH);
                bdSource.RemoveCurrent();
               
                Save();

            }
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
    }
}