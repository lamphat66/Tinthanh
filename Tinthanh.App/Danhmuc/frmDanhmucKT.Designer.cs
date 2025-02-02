namespace Tinthanh.App.Danhmuc
{
    partial class frmDanhmucKT
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDanhmucKT));
            bdSource = new BindingSource(components);
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            barManager1 = new DevExpress.XtraBars.BarManager(components);
            bar1 = new DevExpress.XtraBars.Bar();
            btnAdd = new DevExpress.XtraBars.BarButtonItem();
            btnDelete = new DevExpress.XtraBars.BarButtonItem();
            btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            btnClose = new DevExpress.XtraBars.BarButtonItem();
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            bar2 = new DevExpress.XtraBars.Bar();
            colMa = new DevExpress.XtraGrid.Columns.GridColumn();
            colTen = new DevExpress.XtraGrid.Columns.GridColumn();
            colPhuongphap = new DevExpress.XtraGrid.Columns.GridColumn();
            colTansuat = new DevExpress.XtraGrid.Columns.GridColumn();
            colChuanmuc = new DevExpress.XtraGrid.Columns.GridColumn();
            colThuchien = new DevExpress.XtraGrid.Columns.GridColumn();
            colNgungsd = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)bdSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)barManager1).BeginInit();
            SuspendLayout();
            // 
            // bdSource
            // 
            bdSource.DataSource = typeof(Data.Entities.DanhmucKT);
            // 
            // gridControl1
            // 
            gridControl1.DataSource = bdSource;
            gridControl1.Dock = DockStyle.Fill;
            gridControl1.Location = new Point(0, 31);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(575, 425);
            gridControl1.TabIndex = 2;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colMa, colTen, colPhuongphap, colTansuat, colChuanmuc, colThuchien, colNgungsd });
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.OptionsEditForm.EditFormColumnCount = 1;
            gridView1.OptionsNavigation.AutoFocusNewRow = true;
            gridView1.OptionsSelection.InvertSelection = true;
            gridView1.OptionsView.ColumnAutoWidth = false;
            gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            gridView1.OptionsView.ShowGroupPanel = false;
            gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] { new DevExpress.XtraGrid.Columns.GridColumnSortInfo(colMa, DevExpress.Data.ColumnSortOrder.Ascending) });
            // 
            // barManager1
            // 
            barManager1.AllowCustomization = false;
            barManager1.AllowQuickCustomization = false;
            barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] { bar1 });
            barManager1.DockControls.Add(barDockControlTop);
            barManager1.DockControls.Add(barDockControlBottom);
            barManager1.DockControls.Add(barDockControlLeft);
            barManager1.DockControls.Add(barDockControlRight);
            barManager1.Form = this;
            barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { btnAdd, btnDelete, btnRefresh, btnClose });
            barManager1.MaxItemId = 5;
            // 
            // bar1
            // 
            bar1.BarName = "Custom 3";
            bar1.DockCol = 0;
            bar1.DockRow = 0;
            bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(btnAdd), new DevExpress.XtraBars.LinkPersistInfo(btnDelete, true), new DevExpress.XtraBars.LinkPersistInfo(btnRefresh, true), new DevExpress.XtraBars.LinkPersistInfo(btnClose, true) });
            bar1.Text = "Custom 3";
            // 
            // btnAdd
            // 
            btnAdd.Caption = "Thêm";
            btnAdd.Id = 0;
            btnAdd.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnAdd.ImageOptions.SvgImage");
            btnAdd.ItemShortcut = new DevExpress.XtraBars.BarShortcut(Keys.Control | Keys.Insert);
            btnAdd.Name = "btnAdd";
            btnAdd.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            btnAdd.ItemClick += btnAdd_ItemClick;
            // 
            // btnDelete
            // 
            btnDelete.Caption = "Xóa";
            btnDelete.Id = 1;
            btnDelete.ImageOptions.Image = (Image)resources.GetObject("btnDelete.ImageOptions.Image");
            btnDelete.ImageOptions.LargeImage = (Image)resources.GetObject("btnDelete.ImageOptions.LargeImage");
            btnDelete.ItemShortcut = new DevExpress.XtraBars.BarShortcut(Keys.Control | Keys.Delete);
            btnDelete.Name = "btnDelete";
            btnDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            btnDelete.ItemClick += btnDelete_ItemClick;
            // 
            // btnRefresh
            // 
            btnRefresh.Caption = "Nạp lại";
            btnRefresh.Id = 3;
            btnRefresh.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnRefresh.ImageOptions.SvgImage");
            btnRefresh.Name = "btnRefresh";
            btnRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            btnRefresh.ItemClick += btnRefresh_ItemClick;
            // 
            // btnClose
            // 
            btnClose.Caption = "Đóng";
            btnClose.Id = 4;
            btnClose.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnClose.ImageOptions.SvgImage");
            btnClose.ItemShortcut = new DevExpress.XtraBars.BarShortcut(Keys.Control | Keys.F4);
            btnClose.Name = "btnClose";
            btnClose.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            btnClose.ItemClick += btnClose_ItemClick;
            // 
            // barDockControlTop
            // 
            barDockControlTop.CausesValidation = false;
            barDockControlTop.Dock = DockStyle.Top;
            barDockControlTop.Location = new Point(0, 0);
            barDockControlTop.Manager = barManager1;
            barDockControlTop.Size = new Size(575, 31);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = DockStyle.Bottom;
            barDockControlBottom.Location = new Point(0, 456);
            barDockControlBottom.Manager = barManager1;
            barDockControlBottom.Size = new Size(575, 0);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = DockStyle.Left;
            barDockControlLeft.Location = new Point(0, 31);
            barDockControlLeft.Manager = barManager1;
            barDockControlLeft.Size = new Size(0, 425);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = DockStyle.Right;
            barDockControlRight.Location = new Point(575, 31);
            barDockControlRight.Manager = barManager1;
            barDockControlRight.Size = new Size(0, 425);
            // 
            // bar2
            // 
            bar2.BarName = "Main menu";
            bar2.DockCol = 0;
            bar2.DockRow = 0;
            bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(btnAdd), new DevExpress.XtraBars.LinkPersistInfo(btnDelete, true) });
            bar2.OptionsBar.MultiLine = true;
            bar2.OptionsBar.UseWholeRow = true;
            bar2.Text = "Main menu";
            // 
            // colMa
            // 
            colMa.AppearanceHeader.Options.UseTextOptions = true;
            colMa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colMa.Caption = "Mã";
            colMa.FieldName = "Ma";
            colMa.Name = "colMa";
            colMa.Visible = true;
            colMa.VisibleIndex = 0;
            // 
            // colTen
            // 
            colTen.AppearanceHeader.Options.UseTextOptions = true;
            colTen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colTen.Caption = "Tên";
            colTen.FieldName = "Ten";
            colTen.Name = "colTen";
            colTen.Visible = true;
            colTen.VisibleIndex = 1;
            colTen.Width = 180;
            // 
            // colPhuongphap
            // 
            colPhuongphap.AppearanceHeader.Options.UseTextOptions = true;
            colPhuongphap.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colPhuongphap.Caption = "Phương pháp";
            colPhuongphap.FieldName = "Phuongphap";
            colPhuongphap.Name = "colPhuongphap";
            colPhuongphap.Visible = true;
            colPhuongphap.VisibleIndex = 2;
            // 
            // colTansuat
            // 
            colTansuat.AppearanceHeader.Options.UseTextOptions = true;
            colTansuat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colTansuat.Caption = "Tần suất";
            colTansuat.FieldName = "Tansuat";
            colTansuat.Name = "colTansuat";
            colTansuat.Visible = true;
            colTansuat.VisibleIndex = 3;
            // 
            // colChuanmuc
            // 
            colChuanmuc.AppearanceHeader.Options.UseTextOptions = true;
            colChuanmuc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colChuanmuc.Caption = "Chuẩn mực";
            colChuanmuc.FieldName = "Chuanmuc";
            colChuanmuc.Name = "colChuanmuc";
            colChuanmuc.Visible = true;
            colChuanmuc.VisibleIndex = 4;
            colChuanmuc.Width = 82;
            // 
            // colThuchien
            // 
            colThuchien.AppearanceHeader.Options.UseTextOptions = true;
            colThuchien.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colThuchien.Caption = "Thực hiện";
            colThuchien.FieldName = "Thuchien";
            colThuchien.Name = "colThuchien";
            colThuchien.Visible = true;
            colThuchien.VisibleIndex = 5;
            colThuchien.Width = 86;
            // 
            // colNgungsd
            // 
            colNgungsd.AppearanceHeader.Options.UseTextOptions = true;
            colNgungsd.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colNgungsd.Caption = "Ngưng sd";
            colNgungsd.FieldName = "Ngungsd";
            colNgungsd.Name = "colNgungsd";
            colNgungsd.Visible = true;
            colNgungsd.VisibleIndex = 6;
            // 
            // frmDanhmucKT
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 456);
            Controls.Add(gridControl1);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            Name = "frmDanhmucKT";
            Text = "Danh mục kiểm tra vật tư ";
            ((System.ComponentModel.ISupportInitialize)bdSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)barManager1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource bdSource;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraGrid.Columns.GridColumn colMa;
        private DevExpress.XtraGrid.Columns.GridColumn colTen;
        private DevExpress.XtraGrid.Columns.GridColumn colPhuongphap;
        private DevExpress.XtraGrid.Columns.GridColumn colTansuat;
        private DevExpress.XtraGrid.Columns.GridColumn colChuanmuc;
        private DevExpress.XtraGrid.Columns.GridColumn colThuchien;
        private DevExpress.XtraGrid.Columns.GridColumn colNgungsd;
    }
}