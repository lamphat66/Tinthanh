

using Tinthanh.Data.Entities;
namespace Tinthanh.App.General
{


    public partial class frmThemDanhdiem : DevExpress.XtraEditors.XtraForm
    {

       
        public string Ma = "";
        public string Ten = "";
        public string Donvi = "";
        public frmThemDanhdiem()
        {
            InitializeComponent();

            lkDonvi.Properties.DataSource = Thuvien.GetDonvi();
            lkDonvi.Properties.ValueMember = "Ma";
            lkDonvi.Properties.DisplayMember = "Ten";
            lkDonvi.Properties.BestFit();

            lkDonvi.EditValue = "CAI";
            rdLoai.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtTen.Text))

                Add();

            else MessageBox.Show("Yêu cầu nhập tên !", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Add()
        {
            string Mamoi = "";
            string SQL = "";
            string Loai = "";

            if (Convert.ToInt32(rdLoai.EditValue) == 0) Loai = "BG"; else Loai = "KBG";

            Mamoi = Dungchung.Sinhmadanhdiem(Loai, 4);
          
            if(Loai== "BG")
            SQL = "Insert into ThanhphamBG(Ma,Ten,Donvi,Ngungsd) Values (@Ma,@Ten,@Donvi,@ngungsd)";
            
            else if (Loai=="KBG")
                SQL = "Insert into KhuonBG(Ma,Ten,Ngungsd) Values (@Ma,@Ten,@ngungsd)";
            SQLHelper.ExecQueryNonData(SQL, new
            {
                Ma = Mamoi,
                Ten = txtTen.Text,
                Donvi = lkDonvi.EditValue?.ToString() ?? string.Empty,
                Ngungsd = false,
                
            });

            this.Ten = txtTen.Text;
            this.Donvi = lkDonvi.EditValue?.ToString() ?? string.Empty;
            this.Ma = Mamoi;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}