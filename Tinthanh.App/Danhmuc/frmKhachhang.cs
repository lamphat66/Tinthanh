
using DevExpress.Mvvm;
using DevExpress.Utils.MVVM;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Diagnostics;
using System.IO;
using Tinthanh.Data.Entities;
using Tinthanh.ViewModel;

namespace Tinthanh.App.Danhmuc;
public partial class frmKhachhang : DevExpress.XtraEditors.XtraForm
{

    public frmKhachhang()
    {
        InitializeComponent();
        InitBinding();
    }

    private void InitBinding()
    {


        MVVMContext mvvmContext = new MVVMContext();
        mvvmContext.ContainerControl = this;
        mvvmContext.ViewModelType = typeof(KhachhangViewModel);
        MVVMContext.RegisterMessageBoxService();

        var fluent = mvvmContext.OfType<KhachhangViewModel>();

        Messenger.Default.Register<string>(this, "Close", x => Close());
        Messenger.Default.Register<string>(this, "Focus", x => txtTen.Focus());


        // Bind dữ liệu lên GridControl
        fluent.SetBinding(gridControl1, g => g.DataSource, x => x.lstKhachhang);
        fluent.SetBinding(gridControl2, g => g.DataSource, x => x.lstLienlac);
        fluent.SetBinding(gridView2, g => g.FocusedRowObject, x => x.SelectedLienlac);
        fluent.SetBinding(gridControl5, g => g.DataSource, x => x.lstTailieu);
        fluent.SetBinding(gridView5, g => g.FocusedRowObject, x => x.SelectedTailieu);

        bdSource.DataSource = typeof(Khachhang);
        fluent.SetObjectDataSourceBinding(bdSource, x => x.SelectedItem);


        lkNhom.Properties.DataSource = fluent.ViewModel.Nhomkhachhang();
        lkNhom.Properties.DisplayMember = "Ten";
        lkNhom.Properties.ValueMember = "Ma";

        lkKhuvuc.Properties.DataSource = fluent.ViewModel.Khuvuc();
        lkKhuvuc.Properties.DisplayMember = "Ten";
        lkKhuvuc.Properties.ValueMember = "Ma";

        cboPhanloai.DataSource = fluent.ViewModel.Phanloai();
        cboPhanloai.DisplayMember = "Ten";
        cboPhanloai.ValueMember = "Ma";
        cboPhanloai.BestFit();

        fluent.BindCommand(btnDelete, x => x.Delete);
        fluent.BindCommand(btnSave, x => x.Save);
        fluent.BindCommand(btnCancel, x => x.Cancel());
        fluent.BindCommand(btnAdd, x => x.Add);
        fluent.BindCommand(btnClose, x => x.CloseForm);


        fluent.BindCommand(btnFind, x => x.LoadDanhsachByFilter, x =>txtFind.Text );

        fluent.WithEvent<FocusedRowObjectChangedEventArgs>(gridView1, "FocusedRowObjectChanged")
                .EventToCommand(x => x.Loaddata);

    
        fluent.WithEvent<ColumnView, FocusedRowObjectChangedEventArgs>(gridView2, "FocusedRowObjectChanged")
                .SetBinding(x => x.SelectedLienlac,
                    args => args.Row as LienlacKH,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));

        fluent.WithEvent<ColumnView, FocusedRowObjectChangedEventArgs>(gridView5, "FocusedRowObjectChanged")
              .SetBinding(x => x.SelectedTailieu,
                  args => args.Row as Khachhang_Tailieu,
                  (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));

           btnFileName.ButtonClick += btnFileName_ButtonClick;
    }


    private void btnFileName_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
    {
        if (e.Button.Index == 0) //upload File
        {
            using (var dlg = new OpenFileDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    string fileSource = dlg.FileName;
                    string FileUpload = Path.GetFileName(fileSource);
                    FTP f = new FTP("/Khachhang");
                    try
                    {

                        f.UploadFile(fileSource, FileUpload);
                        MessageBox.Show("Upload Xong!!");
                        f.Dispose();

                        GridView view = gridView5;

                        if (view.IsNewItemRow(view.FocusedRowHandle))
                        {
                            view.AddNewRow();

                        }
                        gridView5.SetRowCellValue(view.FocusedRowHandle, "Tenfile", Path.GetFileName(fileSource));

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }

                }
            }
        }

        if (e.Button.Index == 1) //DownLoad File
        {
            using (var dlg = new SaveFileDialog())
            {
                dlg.FileName = gridView5.GetFocusedRowCellValue("Tenfile").ToString();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    string fileDownload = dlg.FileName;
                    string FileSource = Path.GetFileName(dlg.FileName);
                    FTP f = new FTP("/Khachhang");
                    try
                    {

                        f.DownLoad(fileDownload, FileSource);
                        MessageBox.Show("Download Xong!!");

                        ProcessStartInfo psi = new ProcessStartInfo();
                        psi.FileName = fileDownload;
                        psi.UseShellExecute = true;
                        psi.WindowStyle = ProcessWindowStyle.Normal;
                        Process.Start(psi);

                        f.Dispose();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }

                }
            }
        }
    }


}