


using DevExpress.Mvvm;
using DevExpress.Utils.MVVM;
using DevExpress.XtraGrid.Views.Base;
using System.ComponentModel;
using Tinthanh.Data.Entities;
using Tinthanh.ViewModel;

namespace Tinthanh.App.Danhmuc;

public partial class frmKhohang : DevExpress.XtraEditors.XtraForm
{


    public frmKhohang()
    {
        InitializeComponent();
        InitBinding();
    }

    private void InitBinding()
    {
        MVVMContext mvvmContext = new MVVMContext();
        mvvmContext.ContainerControl = this;
        mvvmContext.ViewModelType = typeof(KhoViewModel);
        MVVMContext.RegisterMessageBoxService();

        var fluent = mvvmContext.OfType<KhoViewModel>();

        Messenger.Default.Register<string>(this, "Close", x => Close());
        Messenger.Default.Register<string>(this, "Focus", x => txtTen.Focus());


        // Bind dữ liệu lên GridControl
        fluent.SetBinding(gridControl1, g => g.DataSource, x => x.lstKho);
        //fluent.SetBinding(bdSource, g => g.DataSource, x => x.SelectedItem);
        bdSource.DataSource = typeof(Kho);
        fluent.SetObjectDataSourceBinding(bdSource, x => x.SelectedItem);

       
        lkNhom.Properties.DataSource = fluent.ViewModel.Nhomkho();
        lkNhom.Properties.DisplayMember = "Ten";
        lkNhom.Properties.ValueMember = "Ma";

        fluent.BindCommand(btnDelete, x => x.Delete);
        fluent.BindCommand(btnSave, x => x.Save);
        fluent.BindCommand(btnCancel, x => x.Cancel());

        fluent.BindCommand(btnAdd, x => x.Add);

        fluent.BindCommand(btnClose, x => x.CloseForm);
       
        fluent.WithEvent<FocusedRowObjectChangedEventArgs>(gridView1, "FocusedRowObjectChanged")
            .EventToCommand(x => x.Loaddata);

        fluent.WithEvent<ListChangedEventArgs>(bdSource, "ListChanged")
            .EventToCommand(x => x.TestChanged);


    }


}