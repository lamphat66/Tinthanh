


 
using DevExpress.Mvvm;
using DevExpress.Utils.MVVM;

using DevExpress.XtraGrid.Views.Base;
using System.ComponentModel;
using Tinthanh.Data.Entities;
using Tinthanh.ViewModel;
using static Tinthanh.ViewModel.NganhangViewModel;

namespace Tinthanh.App.Danhmuc;

public partial class frmNganhang : DevExpress.XtraEditors.XtraForm
{
    public frmNganhang()
    {
        InitializeComponent();
        InitBinding();
    }
    private void InitBinding()
    {
        MVVMContext mvvmContext = new MVVMContext();
        mvvmContext.ContainerControl = this;
        mvvmContext.ViewModelType = typeof(NganhangViewModel);
        MVVMContext.RegisterMessageBoxService();
      
        var fluent = mvvmContext.OfType<NganhangViewModel>();
        
        Messenger.Default.Register<string>(this,"Close", x => Close());
        Messenger.Default.Register<string>(this, "Focus", x => txtTen.Focus());


        // Bind dữ liệu lên GridControl
        fluent.SetBinding(gridControl1, g => g.DataSource, x => x.lstNganhang);
        //fluent.SetBinding(bdSource, g => g.DataSource, x => x.SelectedItem);
        bdSource.DataSource = typeof(Nganhang);
        fluent.SetObjectDataSourceBinding(bdSource, x => x.SelectedItem);
        
        txtMa.DataBindings.Add("EditValue", bdSource, "Ma", true, DataSourceUpdateMode.OnPropertyChanged);
        txtTen.DataBindings.Add("EditValue", bdSource, "Ten", true, DataSourceUpdateMode.OnPropertyChanged);
        txtTentat.DataBindings.Add("EditValue", bdSource, "Tentat", true, DataSourceUpdateMode.OnPropertyChanged);
        lkNhom.DataBindings.Add("EditValue", bdSource, "Manhom", true, DataSourceUpdateMode.OnPropertyChanged);
        txtDiachi.DataBindings.Add("EditValue", bdSource, "Diachi", true, DataSourceUpdateMode.OnPropertyChanged);
        chkNgungsd.DataBindings.Add("EditValue", bdSource, "Ngungsd", true, DataSourceUpdateMode.OnPropertyChanged);

        lkNhom.Properties.DataSource = fluent.ViewModel.NhomNganhang();
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