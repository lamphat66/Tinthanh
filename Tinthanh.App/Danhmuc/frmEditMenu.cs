
 
using Tinthanh.App.General;
using Tinthanh.Data.Entities;

namespace Tinthanh.App.Danhmuc
{
    public partial class frmEditMenu : DevExpress.XtraEditors.XtraForm
    {
        
        public bool AddNew = false;
        public bool Child = false;
        int Thuoc;
        bool IsNew;
        public frmEditMenu(int Ma,bool AddNew,bool Child)
        {
            InitializeComponent();
            
            Load += delegate { LoadByMa(Ma,AddNew,Child); };
            btnSave.Click += delegate { Save(); };
            btnCancel.Click += delegate { this.Close(); };
        }

        private void LoadByMa(int Ma, bool AddNew, bool Child)
        {
            IsNew = AddNew;
            bdSource.DataSource = SQLHelper.ExecQueryData<Chucnang>("Select * from Chucnang where ma=@Ma", new { @Ma = Ma });

            if (AddNew)
            {
                bdSource.AddNew();
                if (Child == true) Thuoc = Ma;
                else Thuoc = (int)SQLHelper.ExecQuerySacalar("Select thuoc from Chucnang where Ma=@Ma", new { @Ma = Ma });
                var m = bdSource.Current as Chucnang;
                if (Child) m.Ma = SinhMaChild(Ma);
                else m.Ma = SinhMa(Thuoc);

                m.Thuoc = Thuoc;
                bdSource.ResetBindings(false);
            }
        }

        private int SinhMa(int thuoc)
        {
            var Max = SQLHelper.ExecQuerySacalar("select isnull(Max(Ma),0)+1 from Chucnang where thuoc=@thuoc", new { @thuoc = thuoc });
            return Convert.ToInt32(Max);
        }

        private int SinhMaChild(int ma)
        {
            var Max = SQLHelper.ExecQuerySacalar("select isnull(Max(Ma),0)+1 from Chucnang where thuoc=@Ma", new { @Ma = ma });
            return Convert.ToInt32(Max);
        }


        public void Save()
        {

            var n = bdSource.Current as Chucnang;

            if (IsNew)
            {
                n.Thuoc = Thuoc;
                SQLHelper.Insert(n);
            }
            else SQLHelper.Update(n);

        }

    }
}