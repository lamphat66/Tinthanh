using Dapper;
using DevExpress.Mvvm.Native;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Data;
using System.Linq;
using Tinthanh.App.General;
using Tinthanh.Data.EF;
using Tinthanh.Data.Entities;


namespace Tinthanh.App.Danhmuc
{
    public partial class frmKhuon : DevExpress.XtraEditors.XtraForm
    {
        private readonly TinthanhDBContext dbContext;
        bool IsNew = false;



        public frmKhuon()
        {
            dbContext = GetdbContext.dbContext();
            InitializeComponent();
            Load += FrmKhuon_Load;
            gridView1.FocusedRowChanged += gridView1_FocusedRowChanged;
            btnClose.ItemClick += delegate { this.Close(); };


            gridControl2.ProcessGridKey += GridControl2_ProcessGridKey;

            gridControl3.ProcessGridKey += GridControl3_ProcessGridKey;
            btnClose.ItemClick += delegate { this.Close(); };
            btnAdd.ItemClick += delegate
            {
                Add();
            };
            btnFind.Click += btnFind_Click;
            txtFind.KeyDown += txtFind_KeyDown;
            btnDelete.ItemClick += BtnDelete_ItemClick;
            btnSave.ItemClick += delegate { Save(); };
            btnRefresh.ItemClick += delegate { LoadDanhsach(0, txtFind.Text); };
            this.FormClosing += FrmKhuon_FormClosing;
            LoadLookup();
        }

        private void GridControl3_ProcessGridKey(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && e.Modifiers == Keys.Control)
            {
                // Khi nhấn Ctrl+Delete, xóa dòng hiện tại
                gridView3.DeleteSelectedRows();
                // Save();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Insert && e.Modifiers == Keys.Control)
            {
                // Khi nhấn Ctrl+Ins, thêm dòng mới
                gridView3.AddNewRow();
                gridView3.ShowEditForm();
                e.Handled = true;
            }
        }

        private void gridView1_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (dbContext!.ChangeTracker.HasChanges() || IsNew) Save();
            if (gridView1.RowCount > 0)
            {
                string? Ma = gridView1.GetFocusedRowCellValue("Ma").ToString();

                Khuon? data = dbContext.Khuons.Find(Ma);

                bdSource.DataSource = data;
                LoadKhuonCT();
               

            }
        }

        private void FrmKhuon_Load(object? sender, EventArgs e)
        {
            LoadDanhsach(1, txtFind.Text);
        }

        private void GridControl2_ProcessGridKey(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && e.Modifiers == Keys.Control)
            {
                if (MessageBox.Show("Xóa 1 sản phẩm ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    // Khi nhấn Ctrl+Delete, xóa dòng hiện tại
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

        private void LoadLookup()
        {
            var Nhomts = dbContext.Nhomtaisans
                .Where(p => p.Mats == "2115" && p.Ngungsd == false)
                .ToList();
            lkNhom.Properties.DataSource = Nhomts;
            lkNhom.Properties.DisplayMember = "Ten";
            lkNhom.Properties.ValueMember = "Ma";
            lkNhom.Properties.BestFit();

            var dv = dbContext.Donvis.ToList()
                .Where(p => p.Ngungsd == false)
                .ToList();
            cboDonvi.DataSource = dv;

            cboDonvi.DisplayMember = "Ten";
            cboDonvi.ValueMember = "Ma";
            cboDonvi.BestFit();

            cboDonvi1.DisplayMember = "Ten";
            cboDonvi1.ValueMember = "Ma";
            cboDonvi1.BestFit();

        }
        private void FrmKhuon_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (dbContext!.ChangeTracker.HasChanges() || IsNew)
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
            if (MessageBox.Show("Xóa khuôn đang chọn ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var m = bdSource.Current as Khuon;


                var r = dbContext.Vattus.Find(m.Ma);
                if (r != null)
                {
                    gridView1.DeleteSelectedRows();
                    dbContext.Vattus.Remove(r);
                    dbContext.SaveChanges();
                }

            }
        }

        private void Save()
        {
            bdSource.EndEdit();
            if (IsNew) dbContext.Khuons.Add(bdSource.Current as Khuon);
            dbContext.SaveChanges();
            IsNew = false;
        }


        private void LoadDanhsach(int Loai, string filter = "")
        {
            var data = GetDataDanhsach(Loai, filter);

            gridControl1.DataSource = data;
            if (gridView1.DataRowCount == 1)
            {
                gridView1.FocusedRowHandle = 0; // Đặt dòng đầu tiên làm dòng được chọn
                gridView1_FocusedRowChanged(null, null);
            }
        }


        private void btnFind_Click(object sender, EventArgs e)
        {
            LoadDanhsach(2, txtFind.Text);
        }


        public DataTable GetDataDanhsach(int Loai, string filter)
        {
            string Ten = "pr_Timdanhsach";

            DynamicParameters para = new DynamicParameters();
            para.Add("@Tenbang", "Khuon", DbType.String, ParameterDirection.Input);
            para.Add("@Somautin", Loai, DbType.Int32, ParameterDirection.Input);
            para.Add("@Ten", filter, DbType.String, ParameterDirection.Input);
            return SQLHelper.ExecProcedureDataAsDataTable(Ten, para);

        }

        public void ChonKH()
        {

            using (frmTim frm = new frmTim("Khachhang", 1))

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    txtMakh.EditValue = frm.Ma;
                    btnKhachhang.Focus();
                    btnKhachhang.EditValue = frm.Ten;
                }

        }

        public void ChonSP()
        {

            using (frmTimdanhdiem frm = new frmTimdanhdiem("Thanhpham", 1))

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    GridView view = gridView2;
                    if (view.IsNewItemRow(view.FocusedRowHandle)) view.AddNewRow();

                    view.SetRowCellValue(view.FocusedRowHandle, colMasp, frm.Ma);
                    view.SetRowCellValue(view.FocusedRowHandle, colTenSP, frm.Ten);
                    view.SetRowCellValue(view.FocusedRowHandle, colDonvi, frm.Donvi);

                }

        }





        private void txtFind_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnFind.PerformClick();
        }
        private void LoadKhuonCT()
        {
            var data = bdSource.Current as Khuon;

            if (data != null)
            {
                this.dbContext.Entry(data).Collection(e => e.KhuonCTs).Load();

                gridControl2.DataSource = data.KhuonCTs.OrderBy(k => k.Nhom);


            }

        }



        private void Add()
        {
            if (dbContext!.ChangeTracker.HasChanges() || IsNew) Save();

            IsNew = true;
            bdSource.EndEdit();
            bdSource.AddNew();
            txtMa.Focus();
            LoadKhuonCT();


        }

        private void btnKhachhang_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 0) ChonKH();
        }

        private void btnSanpham_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 0) ChonSP();
        }

        private void btnVattu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            gridControl2.MainView = gridView2;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            gridControl2.MainView = grdSanpham;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            gridControl2.MainView = grdKhuon;
        }
    }
}