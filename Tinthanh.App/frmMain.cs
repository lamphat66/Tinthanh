using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraSplashScreen;
using Tinthanh.App.Danhmuc;
using Tinthanh.App.General;

namespace Tinthanh.App
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private string _uname;
        public frmMain(string uName)
        {
            try
            {
                var fl = new FluentSplashScreenOptions();
                fl.Title = "HỆ THỐNG QUẢN LÝ THÔNG TIN TÍN THÀNH";
                fl.Subtitle = "PHÂN HỆ BẢO TRÌ XE MÁY-MÁY MÓC THIẾT BỊ ";
                fl.RightFooter = "Bắt đầu ....";
                fl.LeftFooter = $"Copyright @ 2023 {Environment.NewLine} All rights Reserved";
                fl.LoadingIndicatorType = FluentLoadingIndicatorType.Dots;
                fl.OpacityColor = System.Drawing.Color.FromArgb(16, 110, 190);
                fl.Opacity = 90;
                fl.AppearanceLeftFooter.TextOptions.WordWrap = WordWrap.Wrap;
                SplashScreenManager.ShowFluentSplashScreen(fl, parentForm: this, useFadeIn: true, useFadeOut: true);
                _uname = uName;

                InitializeComponent();

                ribbon.Minimized = true;
                this.Load += FrmMain_Load;
                this.KeyDown += FrmMain_KeyDown;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                SplashScreenManager.CloseForm(false, 1000, this);
            }


        }

        private void FrmMain_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.CapsLock) stCap.Enabled = !stCap.Enabled;
            if (e.KeyCode == Keys.NumLock) stNum.Enabled = !stNum.Enabled;
            if (e.KeyCode == Keys.Insert) stIns.Enabled = !stIns.Enabled;
        }

        private void FrmMain_Load(object? sender, EventArgs e)
        {

            stNgay.Caption = DateTime.Now.ToString("g");
            stUser.Caption = _uname;
            stCap.Enabled = Console.CapsLock;
            stNum.Enabled = Console.NumberLock;
            stIns.Enabled = false;
            Text += "-Version " + Dungchung.Getversion();

        }

        private void mnuThoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }


        void OpenForm(Type typeForm, object Loai)
        {
            if (Convert.ToInt32(Loai) == 0)
            {
                MessageBox.Show("Bạn không có quyền thực hiện chức năng này !!!");
                return;
            }
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.GetType() == typeForm)
                {
                    frm.Activate();
                    return;
                }

            }
            Form f = (Form)Activator.CreateInstance(typeForm, Loai);

            f.MdiParent = this;
            f.Show();
        }
      
        void OpenForm(Type typeForm)
        {
            Cursor.Current = Cursors.WaitCursor;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.GetType() == typeForm)
                {
                    frm.Activate();
                    return;
                }

            }
            Form? f = (Form?)Activator.CreateInstance(typeForm);
            if (f == null)
            {
                throw new InvalidOperationException($"Unable to create instance of {typeForm.FullName}.");
            }

            f.MdiParent = this;
            f.Show();
            Cursor.Current = Cursors.Default;

        }

        private void mnuDonvi_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmDonvi));
        }

        private void mnuDanhdiem_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(typeof(frmLoaidanhdiem));

        }

        private void mnuDoituong_ItemClick(object sender, ItemClickEventArgs e)
        {

            OpenForm(typeof(frmLoaidoituong));

        }
 
        private void btnKho_ItemClick(object sender, ItemClickEventArgs e)
        {
           
           OpenForm(typeof(frmKhohang));

           
        }

        private void btnNganhang_ItemClick(object sender, ItemClickEventArgs e)
        {
           

            OpenForm(typeof(frmNganhang));

            
        }

        private void btnKhachhang_ItemClick(object sender, ItemClickEventArgs e)
        {
            

            OpenForm(typeof(frmKhachhang));

           
        }

        private void mnuKhuvuc_ItemClick(object sender, ItemClickEventArgs e)
        {
            

            OpenForm(typeof(frmKhuvuc));

             
        }

        private void mnuDanhmuc_ItemClick(object sender, ItemClickEventArgs e)
        {
             
            OpenForm(typeof(frmDanhmuc));

           
        }

        private void mnuKhachhangTN_ItemClick(object sender, ItemClickEventArgs e)
        {
            

            OpenForm(typeof(frmKhachhangTN));

            
        }

        private void mnuNhaCC_ItemClick(object sender, ItemClickEventArgs e)
        {
           

            OpenForm(typeof(frmNhacungcap));

            
        }

        private void mnuThanhpham_ItemClick(object sender, ItemClickEventArgs e)
        {
          
            OpenForm(typeof(frmThanhpham));

           
        }

        private void mnuVattu_ItemClick(object sender, ItemClickEventArgs e)
        {
          

            OpenForm(typeof(frmVattu));

           
        }

        private void mnuKhuon_ItemClick(object sender, ItemClickEventArgs e)
        {
            

            OpenForm(typeof(frmKhuon));

            
        }

        private void mnuThanhphamBG_ItemClick(object sender, ItemClickEventArgs e)
        {
           

            OpenForm(typeof(frmThanhphamBG));

            
        }

        private void mnuKhuonBG_ItemClick(object sender, ItemClickEventArgs e)
        {
           

            OpenForm(typeof(frmKhuonBG));

             
        }

        private void mnuDanhmucKT_ItemClick(object sender, ItemClickEventArgs e)
        {
             
            OpenForm(typeof(frmDanhmucKT));

           
        }

        private void mnuTieuchiKT_ItemClick(object sender, ItemClickEventArgs e)
        {
             

            OpenForm(typeof(frmTieuchiKT));
 
        }

        private void mnuBanggiaKH_ItemClick(object sender, ItemClickEventArgs e)
        {
           
            OpenForm(typeof(frmBanggiaKH));

            
        }

        private void mnuBanggiaNCC_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            OpenForm(typeof(frmBanggiaNCC));

            
        }

        private void mnuKhomay_ItemClick(object sender, ItemClickEventArgs e)
        {
            

            OpenForm(typeof(frmKhomay));
 
        }
 
    }
}