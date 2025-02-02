

using Microsoft.EntityFrameworkCore;
using Tinthanh.App.General;
using Tinthanh.Data.EF;

namespace Tinthanh.App.Danhmuc;

public partial class frmKhuonBG : DevExpress.XtraEditors.XtraForm
{
    private readonly TinthanhDBContext dbContext;
    public frmKhuonBG()
    {
        dbContext = GetdbContext.dbContext();
        InitializeComponent();
       
        this.Load += FrmKhohang_Load;

        

        this.FormClosing += FrmKhohang_FormClosing;
        btnAdd.ItemClick += BtnAdd_ItemClick;
       
        btnCancel.ItemClick += delegate { Loaddata(); };
        btnDelete.ItemClick += BtnDelete_ItemClick;
    }

    private void FrmKhohang_FormClosing(object? sender, FormClosingEventArgs e)
    {
        bdSource.EndEdit();
        if (dbContext.ChangeTracker.HasChanges())
        {
            var result = MessageBox.Show("Bạn có muốn lưu thay đổi?", "Xác nhận", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                try
                {
                    dbContext.SaveChanges();
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi
                    MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message);
                    e.Cancel = true; // Ngăn không cho form đóng
                }
            }
            else if (result == DialogResult.Cancel)
            {
                e.Cancel = true; // Hủy bỏ đóng form
            }
        }
    }

    private void BtnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
        if (MessageBox.Show("Xóa 1 khuôn ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {

            bdSource.RemoveCurrent();
            Save();

        }
    }

    private void BtnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
        if (dbContext.ChangeTracker.HasChanges()) Save();
        bdSource.AddNew();
        txtMa.EditValue = Dungchung.Sinhmadoituong("KBG", 4);
        txtTen.Focus();

    }
    private void FrmKhohang_Load(object? sender, EventArgs e)
    {
        Loaddata();
    }

    void Loaddata()
    {
        this.dbContext?.KhuonBGs.Load();
        this.bdSource.DataSource = this.dbContext?.KhuonBGs.Local.ToBindingList();
    }

    private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
        Close();
    }
    private void Save()
    {
        try
        {
            this.dbContext!.SaveChanges();

        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
        bdSource.EndEdit();
        Save();
    }
}