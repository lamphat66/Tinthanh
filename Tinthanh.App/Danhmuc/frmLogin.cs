
using Tinthanh.App.General;
 
using Tinthanh.Data.EF;

namespace Tinthanh.App.Danhmuc
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        private readonly TinthanhDBContext dbContext;
        public frmLogin()
        {
            dbContext = GetdbContext.dbContext();
            InitializeComponent();
            lblVersion.Text = "Version :" + Dungchung.Getversion();
        }


        
        private void cmdOK_Click(object sender, EventArgs e)
        {

            var m = SQLHelper.ExecQuerySacalar(@"select count(*) from [user] where ma=@Ma and Password =@Pass", new { @Ma = txtUser.Text, 
                @Pass = Dungchung.GenerateMD5(txtPass.Text) });
            if ((int)m == 1)
            {
                this.Hide();

                Form frm = new frmMain(txtUser.Text);
                Dungchung.un = txtUser.Text;
                frm.Show();

            }
            else
            {
                MessageBox.Show("Người dùng or mật khẩu không đúng!", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPass.Focus();

            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}