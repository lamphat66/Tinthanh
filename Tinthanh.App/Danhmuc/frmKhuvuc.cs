﻿using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using Microsoft.EntityFrameworkCore;
using Tinthanh.App.General;
using Tinthanh.Data.EF;
 



namespace Tinthanh.App.Danhmuc
{
    public partial class frmKhuvuc : XtraForm
    {
        private readonly TinthanhDBContext dbContext;

        public frmKhuvuc()
        {
            InitializeComponent();

            dbContext = GetdbContext.dbContext();
            this.Load += FrmDonvi_Load;
            this.FormClosing += FrmDonvi_FormClosing;
            gridView1.RowUpdated += GridView1_RowUpdated;
            btnSave.ItemClick += BtnSave_ItemClick;
            gridView1.InitNewRow += GridView1_InitNewRow;
        }

        private void GridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gridView1.SetFocusedRowCellValue("Ma", Dungchung.Sinhmadoituong("KV", 4));
        }

        private void BtnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Save();
        }

        void Loaddata()
        {
            this.dbContext?.Khuvucs.Load();

            this.bdSource.DataSource = dbContext?.Khuvucs.Local.ToBindingList();
        }
        private void FrmDonvi_Load(object? sender, EventArgs e)
        {
            Loaddata();
        }

        private void FrmDonvi_FormClosing(object? sender, FormClosingEventArgs e)
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

        private void Save()
        {
            try
            {
                bdSource.EndEdit();
                this.dbContext!.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void GridView1_RowUpdated(object sender, RowObjectEventArgs e)
        {
            Save();
        }


        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.AddNewRow();
            gridView1.SetFocusedRowCellValue("Ma", Dungchung.Sinhmadoituong("KV", 4));

        }



        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Xóa 1 khu vực ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                bdSource.RemoveCurrent();
                Save();

            }
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Loaddata();
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
    }
}