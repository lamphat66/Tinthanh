
using System.Data;

using System.Windows.Forms;
using Tinthanh.App.General;

namespace Tinthanh.App.Danhmuc
{
    public partial class frmChangePass : DevExpress.XtraEditors.XtraForm
    {
        public frmChangePass()
        {
            InitializeComponent();
            btnOK.Click += BtnOK_Click;
            btnCancel.Click += BtnCancel_Click;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if ((txtConfirm.EditValue != txtConfirm.EditValue) && txtNewPass.EditValue == null)
            {
                MessageBox.Show("Mật khẩu không hợp lệ !");
                return;
            }

            DataTable dt = SQLHelper.ExecQueryDataAsDataTable(@"select Ma,Password from Users where Ma=@un ", new { @un = Dungchung.un });
            if (dt.Rows.Count == 0) MessageBox.Show("User không tồn tại !");
            else
            {
                string p=Dungchung.GenerateMD5(txtNewPass.EditValue.ToString());
                SQLHelper.ExecQueryNonData("Update users set Password=@Pass where Ma=@user", new { @Pass = p,@user=Dungchung.un });
                MessageBox.Show("Đổi mật khẩu thành công !!");
                Close();
            }

        }

        private void sidePanel1_Click(object sender, EventArgs e)
        {

        }

        private void frmChangePass_Load(object sender, EventArgs e)
        {

        }
    }
}