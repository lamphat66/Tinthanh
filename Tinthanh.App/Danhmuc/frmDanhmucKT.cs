using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Microsoft.EntityFrameworkCore;
using Tinthanh.App.General;
using Tinthanh.Data.EF;
 



namespace Tinthanh.App.Danhmuc
{
    public partial class frmDanhmucKT : XtraForm
    {
        private readonly TinthanhDBContext dbContext;
        int Newid = 0;
        public frmDanhmucKT()
        {
            InitializeComponent();
            
            dbContext = GetdbContext.dbContext();
            this.Load += FrmDonvi_Load;
            this.FormClosing += FrmDonvi_FormClosing;
            gridView1.RowUpdated += GridView1_RowUpdated;
            gridView1.FocusedRowChanged += GridView1_FocusedRowChanged;
        }

        

        private void GridView1_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {

            if (gridView1.IsNewItemRow(e.FocusedRowHandle))
            {
                Newid++;
                gridView1.AddNewRow();
                gridView1.SetRowCellValue(e.FocusedRowHandle, "Ma", Newid);
            }
        }

        

        void Loaddata()
        {
            this.dbContext?.DanhmucKTs.Load();

            this.bdSource.DataSource = dbContext?.DanhmucKTs.Local.ToBindingList();
            Newid = dbContext.DanhmucKTs.Max(x => x.Ma);
        }
        private void FrmDonvi_Load(object? sender, EventArgs e)
        {
            Loaddata();
            gridView1.BestFitColumns();
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


        private void GridView1_RowUpdated(object sender, RowObjectEventArgs e)
        {
            //Save();
        }


        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdSource.AddNew();
           

        }



        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Xóa 1 danh mục kiểm tra ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                bdSource.RemoveCurrent();
                Save();

            }
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Loaddata();
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
    }
}