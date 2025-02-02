
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Microsoft.EntityFrameworkCore;
using Tinthanh.App.General;
using Tinthanh.Data.EF;
using Tinthanh.Data.Entities;
 
namespace Tinthanh.App.Danhmuc
{
    public partial class frmLoaidanhdiem : DevExpress.XtraEditors.XtraForm
    {
        private TinthanhDBContext? dbContext;

        public frmLoaidanhdiem()
        {
            InitializeComponent();
            dbContext = GetdbContext.dbContext();
            gridView1.FocusedRowChanged += GridView1_FocusedRowChanged;
            gridControl2.ProcessGridKey += GridControl2_ProcessGridKey;
            gridView1.RowUpdated += GridView1_RowUpdated;
            this.Load += FrmLoaidanhdiem_Load;
            this.FormClosing += FrmLoaidanhdiem_FormClosing;

        }

       
        private void GridControl2_ProcessGridKey(object? sender, KeyEventArgs e)
        {
        
          

            if (e.KeyCode == Keys.Delete && e.Modifiers == Keys.Control)
            {
                // Khi nhấn Ctrl+Delete, xóa dòng hiện tại
                bdSourceCT.RemoveCurrent();
                Save();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Insert && e.Modifiers == Keys.Control)
            {
                // Khi nhấn Ctrl+Ins, thêm dòng mới
                bdSourceCT.AddNew();
                 
                e.Handled = true;
            }
     
        }
       

        private void FrmLoaidanhdiem_Load(object? sender, EventArgs e)
        {
            Loadata();
        }

        private void Loadata()
        {

            this.dbContext?.Loaidanhdiems.Load();
            this.bdSource.DataSource = dbContext?.Loaidanhdiems.Local.ToBindingList();
        }
        private void FrmLoaidanhdiem_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (dbContext!.ChangeTracker.HasChanges())
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


        private void GridView1_RowUpdated(object sender, RowObjectEventArgs e)
        {
            Save();
        }

        private void GridView1_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (this.dbContext != null)
            {

                var Loaidd = e.FocusedRowHandle >= 0 ? this.gridView1.GetFocusedRow() as Loaidanhdiem : null;

                if (Loaidd != null)
                {
                    this.dbContext.Entry(Loaidd).Collection(e => e.Nhomdanhdiems).Load();
                    bdSourceCT.DataSource = Loaidd.Nhomdanhdiems;

                }
            }
        }

        private void Save()
        {
            try
            {
                this.dbContext!.SaveChanges();
                this.gridView1.RefreshData();
                bdSourceCT.ResetBindings(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdSource.AddNew();
            
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Xóa dòng hiện hành ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                bdSource.RemoveCurrent();
                Save();
            }
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Loadata();
        }

        
        private void btnDelete1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
    }
}