using Dapper;
using DevExpress.XtraGrid.Views.Base;
using System.Data;
using Tinthanh.App.General;
using Tinthanh.Data.EF;
using Tinthanh.Data.Entities;

namespace Tinthanh.App.Danhmuc
{
    public partial class frmVattu : DevExpress.XtraEditors.XtraForm
    {
        private readonly TinthanhDBContext dbContext;
        bool IsNew = false;



        public frmVattu()
        {
            dbContext = GetdbContext.dbContext();
            InitializeComponent();
            Load += FrmNhacungcap_Load;
            gridView1.FocusedRowChanged += gridView1_FocusedRowChanged;
            btnClose.ItemClick += delegate { this.Close(); };


            gridControl2.ProcessGridKey += GridControl2_ProcessGridKey;
            gridView2.RowUpdated += GridView2_RowUpdated;

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
            this.FormClosing += FrmKhachhang_FormClosing;
            LoadLookup();
        }

        private void gridView1_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (dbContext!.ChangeTracker.HasChanges() || IsNew) Save();
            if (gridView1.RowCount > 0)
            {
                string? ma = gridView1.GetFocusedRowCellValue("Ma").ToString();

                Vattu? data = dbContext.Vattus.Find(ma);
                bdSource.DataSource = data;
                LoadDonviVattu();

            }
        }

        private void FrmNhacungcap_Load(object? sender, EventArgs e)
        {
            LoadDanhsach(1, txtFind.Text);
        }

        private void GridControl2_ProcessGridKey(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && e.Modifiers == Keys.Control)
            {
                if (MessageBox.Show("Xóa 1 đơn vị ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
            var Nhomdd = dbContext.Nhomdanhdiems
                .Where(p => p.Madd == "VT" && p.Ngungsd == false)
                .ToList();
            lkNhom.Properties.DataSource = Nhomdd;
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

            lkDonvi.Properties.DataSource = dv;
            lkDonvi.Properties.DisplayMember = "Ten";
            lkDonvi.Properties.ValueMember = "Ma";
            lkDonvi.Properties.BestFit();
        }
        private void FrmKhachhang_FormClosing(object? sender, FormClosingEventArgs e)
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
            if (MessageBox.Show("Xóa vật tư đang chọn ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var m = bdSource.Current as Vattu;


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
            if (IsNew) dbContext.Vattus.Add(bdSource.Current as Vattu);
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
            para.Add("@Tenbang", "Vattu", DbType.String, ParameterDirection.Input);
            para.Add("@Somautin", Loai, DbType.Int32, ParameterDirection.Input);
            para.Add("@Ten", filter, DbType.String, ParameterDirection.Input);
            return SQLHelper.ExecProcedureDataAsDataTable(Ten, para);

        }



        private void txtFind_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnFind.PerformClick();
        }
        private void LoadDonviVattu()
        {
            var data = bdSource.Current as Vattu;

            if (data != null)
            {
                this.dbContext.Entry(data).Collection(e => e.DonviVattus).Load();
                bdDonvi.DataSource = data.DonviVattus;
                gridControl2.DataSource = bdDonvi;


            }


        }

        private void Add()
        {
            if (dbContext!.ChangeTracker.HasChanges() || IsNew) Save();

            IsNew = true;
            bdSource.EndEdit();
            bdSource.AddNew();
            txtMa.Focus();
            LoadDonviVattu();

        }
    }
}