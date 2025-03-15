using DevExpress.Mvvm;
using DevExpress.Utils.MVVM;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using Tinthanh.Data.Entities;
using Tinthanh.ViewModel;

namespace Tinthanh.App.Danhmuc
{
    public partial class frmDonvi : XtraForm
    {
        public frmDonvi()
        {
            InitializeComponent();
            MVVMContext mvvmContext = new MVVMContext();
            mvvmContext.ContainerControl = this;
            mvvmContext.ViewModelType = typeof(DonviViewModel);
            MVVMContext.RegisterMessageBoxService();

            var fluent = mvvmContext.OfType<DonviViewModel>();

            Messenger.Default.Register<string>(this, "Close", x => Close());
            Messenger.Default.Register<string>(this, "New", x => gridView1.AddNewRow());

            fluent.SetBinding(gridControl1, g => g.DataSource, x => x.Donvis);
            fluent.SetBinding(gridView1, g => g.FocusedRowObject, x => x.SelectedDonvi);

            fluent.BindCommand(btnDelete, x => x.Delete);

            fluent.BindCommand(btnAdd, x => x.Addnew);

            fluent.BindCommand(btnClose, x => x.CloseForm);

            fluent.WithEvent<RowObjectEventArgs>(gridView1, "RowUpdated")
                    .EventToCommand(x => x.Save);

            //fluent.WithEvent<ColumnView, FocusedRowObjectChangedEventArgs>(gridView1, "FocusedRowObjectChanged")
            //    .SetBinding(x => x.SelectedDonvi,
            //        args => args.Row as Donvi,
            //        (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));

        }

        private void gridView1_RowUpdated(object sender, RowObjectEventArgs e)
        {

        }
    }
}