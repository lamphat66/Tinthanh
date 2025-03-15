


namespace Tinthanh.App.General
{
    public partial class frmThemdoituong : DevExpress.XtraEditors.XtraForm
    {
        private string Tenbang;
        public int Id;
        public string Ma;
        public string Ten;
        public string Diachi;
        public string Dienthoai;
        public string Lienhe;
        public frmThemdoituong(string Tieude, string Ten)
        {
            InitializeComponent();

            this.Text = Tieude;
            Tenbang = Ten;
            if (Ten == "Quanly")
            {
                txtDiachi.Enabled = false;
                txtDienthoai.Enabled = false;
                txtLienhe.Enabled = false;

            }

        }

        private void Add()
        {
            string MaKH = "";
            int Id = 0;
            if (Tenbang == "Quanly")
            {
                Id = Convert.ToInt32(SQLHelper.ExecQuerySacalar("Select Isnull(max(Id),0)+1 from Quanly"));
                string SQL = "Insert into Quanly(Id,Ten,Ngungsd,CreateBy,CreateDate,loai) Values (@Id,@Ten,@ngungsd,@CreateBy,@CreateDate,@loai)";
                SQLHelper.ExecQueryNonData(SQL, new { @Id = Id, @Ten = txtTen.Text, @ngungsd = false, @CreateBy = Dungchung.un, @CreateDate = DateTime.Now.Date, @Loai = "PTN" });
            }

            if (Tenbang == "KhachhangTN")
            {

                MaKH = Dungchung.Sinhmadoituong("TN", 4);

                string SQL = "Insert into KhachhangTN(Ma,Ten,Diachi,Dienthoai,Lienhe,Ngungsd,Users,CreateDate,EditDate) Values " +
                    "(@Ma,@Ten,@Diachi,@Dienthoai,@Lienhe,@ngungsd,@CreateBy,@CreateDate,@EditDate)";
                SQLHelper.ExecQueryNonData(SQL, new
                {
                    @Ma = MaKH,
                    @Ten = txtTen.Text,
                    @Diachi = txtDiachi.Text,
                    @dienthoai = txtDienthoai.Text,
                    @Lienhe = txtLienhe.Text,
                    @ngungsd = false,
                    @CreateBy = Dungchung.un,
                    @CreateDate = DateTime.Today,
                    @EditDate = DateTime.Today
                });
            }
            this.Id = Id;
            this.Ten = txtTen.Text;
            this.Diachi = txtDiachi.Text;
            this.Dienthoai = txtDienthoai.Text;
            this.Lienhe = txtLienhe.Text;
            this.Ma = MaKH;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtTen.Text))

                Add();

            else MessageBox.Show("Yêu cầu nhập tên !", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}