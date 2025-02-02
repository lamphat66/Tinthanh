

using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Base.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;
using Microsoft.EntityFrameworkCore;
using Tinthanh.App.General;
using Tinthanh.Data.EF;
using Tinthanh.Data.Entities;


namespace Tinthanh.App.Danhmuc
{
    public partial class frmTieuchiKT : DevExpress.XtraEditors.XtraForm
    {
        private TinthanhDBContext? dbContext;

        public frmTieuchiKT()
        {
            InitializeComponent();
            dbContext = GetdbContext.dbContext();
            gridView1.FocusedRowChanged += GridView1_FocusedRowChanged;
            gridControl2.ProcessGridKey += GridControl2_ProcessGridKey;
            gridView1.RowUpdated += GridView1_RowUpdated;
            this.Load += FrmDanhmuc_Load;
            this.FormClosing += FrmDanhmuc_FormClosing;

        }

        private void FrmDanhmuc_FormClosing(object? sender, FormClosingEventArgs e)
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

        private void FrmDanhmuc_Load(object? sender, EventArgs e)
        {
            Loadata();
        }

        private void GridControl2_ProcessGridKey(object? sender, KeyEventArgs e)
        {



            if (e.KeyCode == Keys.Delete && e.Modifiers == Keys.Control)
            {
                // Khi nhấn Ctrl+Delete, xóa dòng hiện tại
                gridView2.DeleteSelectedRows();
                Save();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Insert && e.Modifiers == Keys.Control)
            {
                // Khi nhấn Ctrl+Ins, thêm dòng mới
                bdSourceCT.AddNew();
                gridView2.ShowEditForm();
                e.Handled = true;
            }

        }

        private void Loadata()
        {

            this.dbContext?.TieuchiKTs.Load();
            this.bdSource.DataSource = dbContext?.TieuchiKTs.Local.ToBindingList();

        }

        private void GridView1_RowUpdated(object sender, RowObjectEventArgs e)
        {
            Save();
        }

        private void GridView1_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (gridView1.IsNewItemRow(e.FocusedRowHandle))
            {
                int Newid = dbContext.TieuchiKTs.Max(x => x.Ma) + 1;
                gridView1.AddNewRow();
                gridView1.SetRowCellValue(e.FocusedRowHandle, "Ma", Newid);
            }

            var data = e.FocusedRowHandle >= 0 ? this.gridView1.GetFocusedRow() as TieuchiKT : null;

            if (data != null)
            {
                this.dbContext.Entry(data).Collection(e => e.TieuchiCTs).Load();
                gridControl2.DataSource = data.TieuchiCTs;


            }

        }

        private void Save()
        {
            try
            {
                this.dbContext!.SaveChanges();
                this.gridView1.RefreshData();
                this.gridView2.RefreshData();

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



        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btChonKT_Click(object sender, EventArgs e)
        {
            using (frmTim frm = new frmTim("Danhmuc_KT", 0))

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    GridView view = gridView2;
                    if (view.IsNewItemRow(view.FocusedRowHandle)) view.AddNewRow();

                    view.SetRowCellValue(view.FocusedRowHandle, "MaKT", frm.Ma);
                    view.SetRowCellValue(view.FocusedRowHandle,"Ten", frm.Ten);
                    

                }
        }
    }
}