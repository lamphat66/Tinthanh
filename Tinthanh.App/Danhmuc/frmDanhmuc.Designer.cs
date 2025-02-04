namespace Tinthanh.App.Danhmuc
{
    partial class frmDanhmuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDanhmuc));
            sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            bdSource = new BindingSource(components);
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            colMa = new DevExpress.XtraGrid.Columns.GridColumn();
            colTen = new DevExpress.XtraGrid.Columns.GridColumn();
            sidePanel2 = new DevExpress.XtraEditors.SidePanel();
            gridControl2 = new DevExpress.XtraGrid.GridControl();
            gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            colTen1 = new DevExpress.XtraGrid.Columns.GridColumn();
            colNgungsd = new DevExpress.XtraGrid.Columns.GridColumn();
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
            bar3 = new DevExpress.XtraBars.Bar();
            bdSourceCT = new BindingSource(components);
            btnSave = new DevExpress.XtraBars.BarButtonItem();
            sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bdSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            sidePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControl2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)barManager1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bdSourceCT).BeginInit();
            SuspendLayout();
            // 
            // sidePanel1
            // 
            sidePanel1.Controls.Add(gridControl1);
            sidePanel1.Dock = DockStyle.Left;
            sidePanel1.Location = new Point(0, 31);
            sidePanel1.Name = "sidePanel1";
            sidePanel1.Size = new Size(324, 528);
            sidePanel1.TabIndex = 0;
            sidePanel1.Text = "sidePanel1";
            // 
            // gridControl1
            // 
            gridControl1.DataSource = bdSource;
            gridControl1.Dock = DockStyle.Fill;
            gridControl1.Location = new Point(0, 0);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(323, 528);
            gridControl1.TabIndex = 4;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // bdSource
            // 
            bdSource.DataSource = typeof(Data.Entities.Danhmuc);
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colMa, colTen });
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.OptionsEditForm.EditFormColumnCount = 1;
            gridView1.OptionsNavigation.AutoFocusNewRow = true;
            gridView1.OptionsSelection.InvertSelection = true;
            gridView1.OptionsView.ColumnAutoWidth = false;
            gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            gridView1.OptionsView.ShowDetailButtons = false;
            gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colMa
            // 
            colMa.AppearanceHeader.Font = new Font("Tahoma", 8.25F, FontStyle.Bold);
            colMa.AppearanceHeader.Options.UseFont = true;
            colMa.AppearanceHeader.Options.UseTextOptions = true;
            colMa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colMa.Caption = "Mã";
            colMa.FieldName = "Ma";
            colMa.Name = "colMa";
            colMa.Visible = true;
            colMa.VisibleIndex = 0;
            colMa.Width = 77;
            // 
            // colTen
            // 
            colTen.AppearanceHeader.Font = new Font("Tahoma", 8.25F, FontStyle.Bold);
            colTen.AppearanceHeader.Options.UseFont = true;
            colTen.AppearanceHeader.Options.UseTextOptions = true;
            colTen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colTen.Caption = "Tên";
            colTen.FieldName = "Ten";
            colTen.Name = "colTen";
            colTen.Visible = true;
            colTen.VisibleIndex = 1;
            colTen.Width = 215;
            // 
            // sidePanel2
            // 
            sidePanel2.Controls.Add(gridControl2);
            sidePanel2.Dock = DockStyle.Left;
            sidePanel2.Location = new Point(324, 31);
            sidePanel2.Name = "sidePanel2";
            sidePanel2.Size = new Size(387, 528);
            sidePanel2.TabIndex = 1;
            sidePanel2.Text = "sidePanel2";
            // 
            // gridControl2
            // 
            gridControl2.Dock = DockStyle.Fill;
            gridControl2.Location = new Point(0, 0);
            gridControl2.MainView = gridView2;
            gridControl2.Name = "gridControl2";
            gridControl2.Size = new Size(386, 528);
            gridControl2.TabIndex = 3;
            gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView2 });
            // 
            // gridView2
            // 
            gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colSTT, colTen1, colNgungsd });
            gridView2.GridControl = gridControl2;
            gridView2.Name = "gridView2";
            gridView2.NewItemRowText = "Click tại đây để thêm 1 dòng mới or nhấn Ctrl+Insert";
            gridView2.OptionsEditForm.EditFormColumnCount = 1;
            gridView2.OptionsNavigation.AutoFocusNewRow = true;
            gridView2.OptionsSelection.InvertSelection = true;
            gridView2.OptionsView.ColumnAutoWidth = false;
            gridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colSTT
            // 
            colSTT.AppearanceHeader.Font = new Font("Tahoma", 8.25F, FontStyle.Bold);
            colSTT.AppearanceHeader.Options.UseFont = true;
            colSTT.AppearanceHeader.Options.UseTextOptions = true;
            colSTT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colSTT.Caption = "Mã";
            colSTT.FieldName = "STT";
            colSTT.Name = "colSTT";
            colSTT.Visible = true;
            colSTT.VisibleIndex = 0;
            colSTT.Width = 64;
            // 
            // colTen1
            // 
            colTen1.AppearanceHeader.Font = new Font("Tahoma", 8.25F, FontStyle.Bold);
            colTen1.AppearanceHeader.Options.UseFont = true;
            colTen1.AppearanceHeader.Options.UseTextOptions = true;
            colTen1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colTen1.Caption = "Tên";
            colTen1.FieldName = "Ten";
            colTen1.Name = "colTen1";
            colTen1.Visible = true;
            colTen1.VisibleIndex = 1;
            colTen1.Width = 200;
            // 
            // colNgungsd
            // 
            colNgungsd.AppearanceHeader.Font = new Font("Tahoma", 8.25F, FontStyle.Bold);
            colNgungsd.AppearanceHeader.Options.UseFont = true;
            colNgungsd.AppearanceHeader.Options.UseTextOptions = true;
            colNgungsd.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colNgungsd.Caption = "Ngưng sd";
            colNgungsd.FieldName = "Ngungsd";
            colNgungsd.Name = "colNgungsd";
            colNgungsd.Visible = true;
            colNgungsd.VisibleIndex = 2;
            // 
            // barManager1
            // 
            barManager1.AllowQuickCustomization = false;
            barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] { bar1 });
            barManager1.DockControls.Add(barDockControlTop);
            barManager1.DockControls.Add(barDockControlBottom);
            barManager1.DockControls.Add(barDockControlLeft);
            barManager1.DockControls.Add(barDockControlRight);
            barManager1.Form = this;
            barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { btnAdd, btnDelete, btnRefresh, btnClose, btnSave });
            barManager1.MaxItemId = 11;
            // 
            // bar1
            // 
            bar1.BarName = "Tools";
            bar1.DockCol = 0;
            bar1.DockRow = 0;
            bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(btnAdd), new DevExpress.XtraBars.LinkPersistInfo(btnSave, true), new DevExpress.XtraBars.LinkPersistInfo(btnDelete, true), new DevExpress.XtraBars.LinkPersistInfo(btnRefresh, true), new DevExpress.XtraBars.LinkPersistInfo(btnClose, true) });
            bar1.Text = "Tools";
            // 
            // btnAdd
            // 
            btnAdd.Caption = "Thêm";
            btnAdd.Id = 0;
            btnAdd.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnAdd.ImageOptions.SvgImage");
            btnAdd.ItemShortcut = new DevExpress.XtraBars.BarShortcut(Keys.Control | Keys.N);
            btnAdd.Name = "btnAdd";
            btnAdd.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            btnAdd.ItemClick += btnAdd_ItemClick;
            // 
            // btnDelete
            // 
            btnDelete.Caption = "Xóa";
            btnDelete.Id = 1;
            btnDelete.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnDelete.ImageOptions.SvgImage");
            btnDelete.ItemShortcut = new DevExpress.XtraBars.BarShortcut(Keys.Control | Keys.Delete);
            btnDelete.Name = "btnDelete";
            btnDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            btnDelete.ItemClick += btnDelete_ItemClick;
            // 
            // btnRefresh
            // 
            btnRefresh.Caption = "Nạp lại";
            btnRefresh.Id = 2;
            btnRefresh.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnRefresh.ImageOptions.SvgImage");
            btnRefresh.ItemShortcut = new DevExpress.XtraBars.BarShortcut(Keys.F5);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            btnRefresh.ItemClick += btnRefresh_ItemClick;
            // 
            // btnClose
            // 
            btnClose.Caption = "Đóng";
            btnClose.Id = 9;
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
            barDockControlTop.Size = new Size(731, 31);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = DockStyle.Bottom;
            barDockControlBottom.Location = new Point(0, 559);
            barDockControlBottom.Manager = barManager1;
            barDockControlBottom.Size = new Size(731, 0);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = DockStyle.Left;
            barDockControlLeft.Location = new Point(0, 31);
            barDockControlLeft.Manager = barManager1;
            barDockControlLeft.Size = new Size(0, 528);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = DockStyle.Right;
            barDockControlRight.Location = new Point(731, 31);
            barDockControlRight.Manager = barManager1;
            barDockControlRight.Size = new Size(0, 528);
            // 
            // bar3
            // 
            bar3.BarName = "Status bar";
            bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            bar3.DockCol = 0;
            bar3.DockRow = 0;
            bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            bar3.OptionsBar.AllowQuickCustomization = false;
            bar3.OptionsBar.DrawDragBorder = false;
            bar3.OptionsBar.UseWholeRow = true;
            bar3.Text = "Status bar";
            // 
            // btnSave
            // 
            btnSave.Caption = "Lưu";
            btnSave.Id = 10;
            btnSave.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem1.ImageOptions.SvgImage");
            btnSave.Name = "btnSave";
            btnSave.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // frmDanhmuc
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(731, 559);
            Controls.Add(sidePanel2);
            Controls.Add(sidePanel1);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            KeyPreview = true;
            Name = "frmDanhmuc";
            Text = "Danh mục chung";
            sidePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bdSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            sidePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControl2).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)barManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bdSourceCT).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraEditors.SidePanel sidePanel2;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private BindingSource bdSource;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMa;
        private DevExpress.XtraGrid.Columns.GridColumn colTen;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraGrid.Columns.GridColumn colTen1;
        private DevExpress.XtraGrid.Columns.GridColumn colNgungsd;
        private BindingSource bdSourceCT;
        private DevExpress.XtraBars.BarButtonItem btnSave;
    }
}