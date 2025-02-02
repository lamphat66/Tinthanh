


namespace Tinthanh.App.Danhmuc
{
    public partial class frmTaikhoan : DevExpress.XtraEditors.XtraForm
    {
      
        private bool _changed;

        public bool Changed
        {
            get { return _changed; }
            set
            {
                _changed = value;
                OnChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public event EventHandler OnChanged;
        public frmTaikhoan()
        {
            InitializeComponent();
            Initialize();
            Load += delegate { Loaddata(); };



        }
        private void Initialize()
        {
            bdSource.ListChanged += BdSource_ListChanged;
            btnAdd.ItemClick += delegate { Add(); };
            btnSave.ItemClick += delegate { Save(); ; };
            btnCancel.ItemClick += delegate { Cancel(); };
            btnClose.ItemClick += delegate { Close(); };
            btnDelete.ItemClick += delegate { Delete(); };

            OnChanged += delegate
            {
                btnAdd.Enabled = !Changed;
                btnSave.Enabled = Changed;
                btnCancel.Enabled = Changed;
                btnDelete.Enabled = !Changed;
                btnClose.Enabled = !Changed;
            };
        }

        private void BdSource_ListChanged(object sender, System.ComponentModel.ListChangedEventArgs e)
        {
            //if (e.ListChangedType == ListChangedType.ItemAdded && Trangthai == EntityState.UnChanged)
            //{
            //    Trangthai = EntityState.Added;
            //    Changed = true;

            //}
            //if (e.ListChangedType == ListChangedType.ItemChanged && Trangthai == EntityState.UnChanged)
            //{
            //    Trangthai = EntityState.Edited;
            //    Changed = true;
            //}
        }

        private void Delete()
        {
            //if (MessageBox.Show("Xóa mẫu tin hiện hành ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    var m = bdSource.Current as Users;
            //    SQLHelper.Delete(m);
            //    Loaddata();

            //}
        }

        private void Cancel()
        {
            //int vt = bdSource.CurrencyManager.Position;
            //Loaddata();
            //bdSource.CurrencyManager.Position = vt;
            //Trangthai = EntityState.UnChanged;
            //Changed = false;
        }

        private void Save()
        {
            try
            {

                //bdSource.EndEdit();
                //var m = bdSource.Current as Users;
                //if (Trangthai == EntityState.Added)
                //{
                //    m.Password = Dungchung.GenerateMD5("123");
                //    SQLHelper.Insert(m);
                //}
                //else if (Trangthai == EntityState.Edited)
                //    SQLHelper.Update(m);

                //Trangthai = EntityState.UnChanged;
                //Changed = false;
            }
            catch (System.Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Add()
        {
            bdSource.AddNew();
        }

        private void Loaddata()
        {
        //    bdSource.ResetBindings(false);
        //    bdSource.DataSource = SQLHelper.ExecQueryData<Users>("Select * from Users");
        //    Changed = false;
        //    Trangthai = EntityState.UnChanged;
        }
    }
}