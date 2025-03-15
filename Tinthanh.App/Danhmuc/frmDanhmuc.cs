

using DevExpress.Mvvm;
using DevExpress.Utils.MVVM;
using DevExpress.XtraGrid.Views.Base;
using Tinthanh.Data.EF;
using Tinthanh.ViewModel;
using DevExpress.XtraGrid.Views.Grid;

namespace Tinthanh.App.Danhmuc
{
    public partial class frmDanhmuc : DevExpress.XtraEditors.XtraForm
    {
        private TinthanhDBContext? dbContext;
        int ID;
        public frmDanhmuc()
        {
            InitializeComponent();
            InitBinding();

        }


        public void InitBinding()
        {
            MVVMContext mvvmContext = new MVVMContext();
            mvvmContext.ContainerControl = this;
            mvvmContext.ViewModelType = typeof(DanhmucViewModel);
            MVVMContext.RegisterMessageBoxService();

            var fluent = mvvmContext.OfType<DanhmucViewModel>();

            Messenger.Default.Register<string>(this, "Close", x => Close());
            Messenger.Default.Register<string>(this, "New", x => gridView1.AddNewRow());
       

            fluent.SetBinding(gridControl1, g => g.DataSource, x => x.Danhmucs);
            fluent.SetBinding(gridView1, g => g.FocusedRowObject, x => x.SelectedDanhmuc);

            fluent.SetBinding(gridControl2, g => g.DataSource, x => x.lstDanhmucCT);
            fluent.SetBinding(gridView2, g => g.FocusedRowObject, x => x.SelectedDanhmucCT);

            fluent.BindCommand(btnDelete, x => x.Delete);
            fluent.BindCommand(btnAdd, x => x.Addnew);
            fluent.BindCommand(btnClose, x => x.CloseForm);
            fluent.BindCommand(mnuDelete, x => x.DeleteCT);

            fluent.WithEvent<RowObjectEventArgs>(gridView1, "RowUpdated")
                    .EventToCommand(x => x.Save);
            fluent.WithEvent<FocusedRowObjectChangedEventArgs>(gridView1, "FocusedRowObjectChanged")
                .EventToCommand(x => x.LoadCT);

            fluent.WithEvent<RowObjectEventArgs>(gridView2, "RowUpdated")
                    .EventToCommand(x => x.Save);

            barManager1.SetPopupContextMenu(gridControl2, popupMenu1);
            gridView2.MouseUp += gridView2_MouseUp;
        }

        private void gridView2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                GridView view = sender as GridView;
                if (view != null)
                {
                    // Lấy vị trí dòng được click
                    var hitInfo = view.CalcHitInfo(e.Location);
                    if (hitInfo.InRow)
                    {
                        view.FocusedRowHandle = hitInfo.RowHandle; // Chọn dòng
                        popupMenu1.ShowPopup(MousePosition); // Hiển thị menu
                    }
                }
            }
        }

    }
}