using Dapper;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Data;
using System.Diagnostics;
using System.IO;
using Tinthanh.App.General;
using Tinthanh.Data.EF;
using Tinthanh.Data.Entities;

namespace Tinthanh.App.Danhmuc
{
    public partial class frmThanhpham : DevExpress.XtraEditors.XtraForm
    {
        private readonly TinthanhDBContext dbContext;
        bool IsNew = false;
        int Masp = 0;


        public frmThanhpham()
        {
            dbContext = GetdbContext.dbContext();
            InitializeComponent();

            LoadLookup();

            Load += FrmNhacungcap_Load;
            gridView1.FocusedRowChanged += gridView1_FocusedRowChanged;
            btnClose.ItemClick += delegate { this.Close(); };
            gridControl2.ProcessGridKey += GridControl2_ProcessGridKey;
            gridControl4.ProcessGridKey += GridControl4_ProcessGridKey;
            gridView2.RowUpdated += GridView2_RowUpdated;

            btnClose.ItemClick += delegate { this.Close(); };
            btnAdd.ItemClick += delegate
            {
                Add();
            };
            btnFind.Click += btnFind_Click!;
            txtFind.KeyDown += txtFind_KeyDown!;
            btnDelete.ItemClick += BtnDelete_ItemClick;
            btnSave.ItemClick += delegate { Save(); };
            btnRefresh.ItemClick += delegate { LoadDanhsach(0, txtFind.Text); };
            FormClosing += FrmKhachhang_FormClosing;

        }

        private void GridControl4_ProcessGridKey(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && e.Modifiers == Keys.Control)
            {
                if (MessageBox.Show("Xóa 1 tài liệu ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    FTP f = new FTP("/Sanpham");
                    var tenfile = gridView6.GetFocusedRowCellValue("Tenfile")?.ToString();
                    if (!string.IsNullOrEmpty(tenfile))
                    {
                        f.Delete(tenfile);
                        gridView6.DeleteSelectedRows();
                    }
                    f.Dispose();
                }
                e.Handled = true;
            }
        }

        private void gridView1_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (dbContext!.ChangeTracker.HasChanges() || IsNew) Save();
            if (gridView1.RowCount > 0)
            {
                Masp = (Int32)gridView1.GetFocusedRowCellValue("Id");

                Thanhpham? data = dbContext.Thanhphams.Find(Masp);
                bdSource.DataSource = data;
                LoadDonvisanpham();
                LoadBangia(Masp);
                LoadKhuon(Masp);
                LoadTailieu();


            }
        }

        private void LoadTailieu()
        {
            var data = bdSource.Current as Thanhpham;

            if (data != null)
            {
                this.dbContext.Entry(data).Collection(e => e.Thanhpham_Tailieus).Load();

                gridControl4.DataSource = data.Thanhpham_Tailieus;


            }
        }

        void LoadBangia(int sp)
        {

            gridControl3.DataSource = BanggiaKH(sp);
            gridView3.BestFitColumns();

        }

        void LoadKhuon(int sp)
        {

            gridControl5.DataSource = KhuonSanxuat(sp);
            gridView5.BestFitColumns();
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
            
        }


        private void LoadLookup()
        {
            var Nhomdd = dbContext.Nhomdanhdiems
                .Where(p => p.Madd == "TP" && p.Ngungsd == false)
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
            if (MessageBox.Show("Xóa thành phẩm đang chọn ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var m = bdSource.Current as Thanhpham;


                var r = dbContext.Thanhphams.Find(m.Id);
                if (r != null)
                {
                    gridView1.DeleteSelectedRows();
                    dbContext.Thanhphams.Remove(r);
                    dbContext.SaveChanges();
                }

            }
        }

        private void Save()
        {
            var m = bdSource.Current as Thanhpham;


            if (IsNew) dbContext.Thanhphams.Add(m);
            m.EditDate = DateTime.Today;
            m.Users = Dungchung.un;
            bdSource.EndEdit();
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


        private void btnFind_Click(object sender, EventArgs e)
        {

            LoadDanhsach(2, txtFind.Text);
        }


        public DataTable GetDataDanhsach(int Loai, string filter)
        {
            string Ten = "pr_Timdanhsach";

            DynamicParameters para = new DynamicParameters();
            para.Add("@Tenbang", "Thanhpham", DbType.String, ParameterDirection.Input);
            para.Add("@Somautin", Loai, DbType.Int32, ParameterDirection.Input);
            para.Add("@Ten", filter, DbType.String, ParameterDirection.Input);
            return SQLHelper.ExecProcedureDataAsDataTable(Ten, para);

        }



        private void txtFind_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnFind.PerformClick();
        }
        private void LoadDonvisanpham()
        {
            var data = bdSource.Current as Thanhpham;

            if (data != null)
            {
                this.dbContext.Entry(data).Collection(e => e.Donvisanphams).Load();
                bdLienlac.DataSource = data.Donvisanphams;
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
            LoadDonvisanpham();

        }

        public DataTable BanggiaKH(int Ma)
        {
            string Ten = "[pr_DanhsachKH]";

            DynamicParameters para = new DynamicParameters();
            para.Add("@SanphamId", Ma, DbType.Int32, ParameterDirection.Input);
            return SQLHelper.ExecProcedureDataAsDataTable(Ten, para);
        }

        public DataTable KhuonSanxuat(int Ma)
        {
            string Ten = "[pr_Khuonsanpham]";
            DynamicParameters para = new DynamicParameters();
            para.Add("@Sanphamid", Ma, DbType.Int32, ParameterDirection.Input);
            return SQLHelper.ExecProcedureDataAsDataTable(Ten, para);
        }

        private void btnFileName_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 0) //upload File
            {
                using (var dlg = new OpenFileDialog())
                {
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        string fileSource = dlg.FileName;
                        string FileUpload = Path.GetFileName(fileSource);
                        FTP f = new FTP("/Sanpham");
                        try
                        {

                            f.UploadFile(fileSource, FileUpload);
                            MessageBox.Show("Upload Xong!!");
                            f.Dispose();
                            
                            GridView view = gridView6;
                            
                            if (view.IsNewItemRow(view.FocusedRowHandle))
                            {
                                view.AddNewRow();

                            }
                            gridView6.SetRowCellValue(view.FocusedRowHandle, "Tenfile", Path.GetFileName(fileSource));

                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }

                    }
                }
            }

            if (e.Button.Index == 1) //DownLoad File
            {
                using (var dlg = new SaveFileDialog())
                {
                    dlg.FileName = gridView6.GetFocusedRowCellValue("Tenfile").ToString();
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        string fileDownload = dlg.FileName;
                        string FileSource = Path.GetFileName(dlg.FileName);
                        FTP f = new FTP("/Sanpham");
                        try
                        {
                           
                            f.DownLoad(fileDownload, FileSource);
                            MessageBox.Show("Download Xong!!");

                            ProcessStartInfo psi = new ProcessStartInfo();
                            psi.FileName = fileDownload;
                            psi.UseShellExecute = true;
                            psi.WindowStyle = ProcessWindowStyle.Normal;
                            Process.Start(psi);

                            f.Dispose();
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }

                    }
                }
            }
        }
    }
}