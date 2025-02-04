
namespace Tinthanh.App.Danhmuc;

partial class frmThanhphamBG
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThanhphamBG));
        bdSource = new BindingSource(components);
        barManager1 = new DevExpress.XtraBars.BarManager(components);
        bar1 = new DevExpress.XtraBars.Bar();
        btnAdd = new DevExpress.XtraBars.BarButtonItem();
        btnSave = new DevExpress.XtraBars.BarButtonItem();
        btnCancel = new DevExpress.XtraBars.BarButtonItem();
        btnDelete = new DevExpress.XtraBars.BarButtonItem();
        btnClose = new DevExpress.XtraBars.BarButtonItem();
        barDockControlTop = new DevExpress.XtraBars.BarDockControl();
        barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
        barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
        barDockControlRight = new DevExpress.XtraBars.BarDockControl();
        sidePanel1 = new DevExpress.XtraEditors.SidePanel();
        sidePanel3 = new DevExpress.XtraEditors.SidePanel();
        layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
        txtMa = new DevExpress.XtraEditors.TextEdit();
        checkEdit3 = new DevExpress.XtraEditors.CheckEdit();
        txtTen = new DevExpress.XtraEditors.MemoEdit();
        lkDonvi = new DevExpress.XtraEditors.LookUpEdit();
        dateEdit1 = new DevExpress.XtraEditors.DateEdit();
        Root = new DevExpress.XtraLayout.LayoutControlGroup();
        layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
        layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
        layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
        layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
        emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
        layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
        sidePanel2 = new DevExpress.XtraEditors.SidePanel();
        gridControl1 = new DevExpress.XtraGrid.GridControl();
        gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
        colMa = new DevExpress.XtraGrid.Columns.GridColumn();
        colTen = new DevExpress.XtraGrid.Columns.GridColumn();
        textEdit1 = new DevExpress.XtraEditors.TextEdit();
        layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
        ((System.ComponentModel.ISupportInitialize)bdSource).BeginInit();
        ((System.ComponentModel.ISupportInitialize)barManager1).BeginInit();
        sidePanel1.SuspendLayout();
        sidePanel3.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
        layoutControl1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)txtMa.Properties).BeginInit();
        ((System.ComponentModel.ISupportInitialize)checkEdit3.Properties).BeginInit();
        ((System.ComponentModel.ISupportInitialize)txtTen.Properties).BeginInit();
        ((System.ComponentModel.ISupportInitialize)lkDonvi.Properties).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties.CalendarTimeProperties).BeginInit();
        ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
        ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
        ((System.ComponentModel.ISupportInitialize)layoutControlItem8).BeginInit();
        ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
        sidePanel2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
        ((System.ComponentModel.ISupportInitialize)layoutControlItem5).BeginInit();
        SuspendLayout();
        // 
        // bdSource
        // 
        bdSource.DataSource = typeof(Data.Entities.ThanhphamBG);
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
        barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { btnAdd, btnSave, btnCancel, btnClose, btnDelete });
        barManager1.MaxItemId = 5;
        // 
        // bar1
        // 
        bar1.BarName = "Tools";
        bar1.DockCol = 0;
        bar1.DockRow = 0;
        bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
        bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(btnAdd), new DevExpress.XtraBars.LinkPersistInfo(btnSave, true), new DevExpress.XtraBars.LinkPersistInfo(btnCancel, true), new DevExpress.XtraBars.LinkPersistInfo(btnDelete, true), new DevExpress.XtraBars.LinkPersistInfo(btnClose, true) });
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
        // 
        // btnSave
        // 
        btnSave.Caption = "Lưu";
        btnSave.Id = 1;
        btnSave.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnSave.ImageOptions.SvgImage");
        btnSave.ItemShortcut = new DevExpress.XtraBars.BarShortcut(Keys.Control | Keys.S);
        btnSave.Name = "btnSave";
        btnSave.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
        btnSave.ItemClick += btnSave_ItemClick;
        // 
        // btnCancel
        // 
        btnCancel.Caption = "Nạp lại";
        btnCancel.Id = 2;
        btnCancel.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnCancel.ImageOptions.SvgImage");
        btnCancel.ItemShortcut = new DevExpress.XtraBars.BarShortcut(Keys.Control | Keys.U);
        btnCancel.Name = "btnCancel";
        btnCancel.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
        // 
        // btnDelete
        // 
        btnDelete.Caption = "Xóa";
        btnDelete.Id = 4;
        btnDelete.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnDelete.ImageOptions.SvgImage");
        btnDelete.ItemShortcut = new DevExpress.XtraBars.BarShortcut(Keys.Control | Keys.E);
        btnDelete.Name = "btnDelete";
        btnDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
        // 
        // btnClose
        // 
        btnClose.Caption = "Đóng";
        btnClose.Id = 3;
        btnClose.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnClose.ImageOptions.SvgImage");
        btnClose.ItemShortcut = new DevExpress.XtraBars.BarShortcut(Keys.Alt | Keys.F4);
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
        barDockControlTop.Size = new Size(721, 31);
        // 
        // barDockControlBottom
        // 
        barDockControlBottom.CausesValidation = false;
        barDockControlBottom.Dock = DockStyle.Bottom;
        barDockControlBottom.Location = new Point(0, 601);
        barDockControlBottom.Manager = barManager1;
        barDockControlBottom.Size = new Size(721, 0);
        // 
        // barDockControlLeft
        // 
        barDockControlLeft.CausesValidation = false;
        barDockControlLeft.Dock = DockStyle.Left;
        barDockControlLeft.Location = new Point(0, 31);
        barDockControlLeft.Manager = barManager1;
        barDockControlLeft.Size = new Size(0, 570);
        // 
        // barDockControlRight
        // 
        barDockControlRight.CausesValidation = false;
        barDockControlRight.Dock = DockStyle.Right;
        barDockControlRight.Location = new Point(721, 31);
        barDockControlRight.Manager = barManager1;
        barDockControlRight.Size = new Size(0, 570);
        // 
        // sidePanel1
        // 
        sidePanel1.Controls.Add(sidePanel3);
        sidePanel1.Controls.Add(sidePanel2);
        sidePanel1.Dock = DockStyle.Left;
        sidePanel1.Location = new Point(0, 31);
        sidePanel1.Name = "sidePanel1";
        sidePanel1.Size = new Size(719, 570);
        sidePanel1.TabIndex = 9;
        sidePanel1.Text = "sidePanel1";
        // 
        // sidePanel3
        // 
        sidePanel3.Controls.Add(layoutControl1);
        sidePanel3.Dock = DockStyle.Fill;
        sidePanel3.Location = new Point(339, 0);
        sidePanel3.Name = "sidePanel3";
        sidePanel3.Size = new Size(379, 570);
        sidePanel3.TabIndex = 1;
        sidePanel3.Text = "sidePanel3";
        // 
        // layoutControl1
        // 
        layoutControl1.Controls.Add(txtMa);
        layoutControl1.Controls.Add(checkEdit3);
        layoutControl1.Controls.Add(txtTen);
        layoutControl1.Controls.Add(lkDonvi);
        layoutControl1.Controls.Add(dateEdit1);
        layoutControl1.Controls.Add(textEdit1);
        layoutControl1.Dock = DockStyle.Fill;
        layoutControl1.Location = new Point(0, 0);
        layoutControl1.Name = "layoutControl1";
        layoutControl1.Root = Root;
        layoutControl1.Size = new Size(379, 570);
        layoutControl1.TabIndex = 0;
        layoutControl1.Text = "layoutControl1";
        // 
        // txtMa
        // 
        txtMa.DataBindings.Add(new Binding("EditValue", bdSource, "Ma", true, DataSourceUpdateMode.OnPropertyChanged));
        txtMa.Location = new Point(60, 12);
        txtMa.MenuManager = barManager1;
        txtMa.Name = "txtMa";
        txtMa.Size = new Size(198, 20);
        txtMa.StyleController = layoutControl1;
        txtMa.TabIndex = 0;
        // 
        // checkEdit3
        // 
        checkEdit3.DataBindings.Add(new Binding("EditValue", bdSource, "Ngungsd", true));
        checkEdit3.Location = new Point(12, 129);
        checkEdit3.MenuManager = barManager1;
        checkEdit3.Name = "checkEdit3";
        checkEdit3.Properties.Caption = "Ngưng sử dụng";
        checkEdit3.Size = new Size(355, 19);
        checkEdit3.StyleController = layoutControl1;
        checkEdit3.TabIndex = 6;
        // 
        // txtTen
        // 
        txtTen.DataBindings.Add(new Binding("EditValue", bdSource, "Ten", true, DataSourceUpdateMode.OnPropertyChanged));
        txtTen.Location = new Point(60, 36);
        txtTen.MenuManager = barManager1;
        txtTen.Name = "txtTen";
        txtTen.Size = new Size(307, 41);
        txtTen.StyleController = layoutControl1;
        txtTen.TabIndex = 3;
        // 
        // lkDonvi
        // 
        lkDonvi.DataBindings.Add(new Binding("EditValue", bdSource, "Donvi", true));
        lkDonvi.Location = new Point(60, 81);
        lkDonvi.MenuManager = barManager1;
        lkDonvi.Name = "lkDonvi";
        lkDonvi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
        lkDonvi.Properties.NullText = "";
        lkDonvi.Properties.ShowHeader = false;
        lkDonvi.Size = new Size(307, 20);
        lkDonvi.StyleController = layoutControl1;
        lkDonvi.TabIndex = 4;
        // 
        // dateEdit1
        // 
        dateEdit1.DataBindings.Add(new Binding("EditValue", bdSource, "CreateDate", true));
        dateEdit1.EditValue = null;
        dateEdit1.Location = new Point(60, 105);
        dateEdit1.MenuManager = barManager1;
        dateEdit1.Name = "dateEdit1";
        dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
        dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
        dateEdit1.Size = new Size(307, 20);
        dateEdit1.StyleController = layoutControl1;
        dateEdit1.TabIndex = 5;
        // 
        // Root
        // 
        Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
        Root.GroupBordersVisible = false;
        Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, layoutControlItem2, layoutControlItem3, layoutControlItem8, emptySpaceItem1, layoutControlItem4, layoutControlItem5 });
        Root.Name = "Root";
        Root.Size = new Size(379, 570);
        Root.TextVisible = false;
        // 
        // layoutControlItem1
        // 
        layoutControlItem1.Control = txtMa;
        layoutControlItem1.Location = new Point(0, 0);
        layoutControlItem1.Name = "layoutControlItem1";
        layoutControlItem1.Size = new Size(250, 24);
        layoutControlItem1.Text = "Mã";
        layoutControlItem1.TextSize = new Size(44, 13);
        // 
        // layoutControlItem2
        // 
        layoutControlItem2.Control = txtTen;
        layoutControlItem2.Location = new Point(0, 24);
        layoutControlItem2.Name = "layoutControlItem2";
        layoutControlItem2.Size = new Size(359, 45);
        layoutControlItem2.Text = "Tên";
        layoutControlItem2.TextSize = new Size(44, 13);
        // 
        // layoutControlItem3
        // 
        layoutControlItem3.Control = lkDonvi;
        layoutControlItem3.Location = new Point(0, 69);
        layoutControlItem3.Name = "layoutControlItem3";
        layoutControlItem3.Size = new Size(359, 24);
        layoutControlItem3.Text = "Đơn vị";
        layoutControlItem3.TextSize = new Size(44, 13);
        // 
        // layoutControlItem8
        // 
        layoutControlItem8.Control = checkEdit3;
        layoutControlItem8.Location = new Point(0, 117);
        layoutControlItem8.Name = "layoutControlItem8";
        layoutControlItem8.Size = new Size(359, 23);
        layoutControlItem8.TextSize = new Size(0, 0);
        layoutControlItem8.TextVisible = false;
        // 
        // emptySpaceItem1
        // 
        emptySpaceItem1.AllowHotTrack = false;
        emptySpaceItem1.Location = new Point(0, 140);
        emptySpaceItem1.Name = "emptySpaceItem1";
        emptySpaceItem1.Size = new Size(359, 410);
        emptySpaceItem1.TextSize = new Size(0, 0);
        // 
        // layoutControlItem4
        // 
        layoutControlItem4.Control = dateEdit1;
        layoutControlItem4.Location = new Point(0, 93);
        layoutControlItem4.Name = "layoutControlItem4";
        layoutControlItem4.Size = new Size(359, 24);
        layoutControlItem4.Text = "Ngày tạo";
        layoutControlItem4.TextSize = new Size(44, 13);
        // 
        // sidePanel2
        // 
        sidePanel2.Controls.Add(gridControl1);
        sidePanel2.Dock = DockStyle.Left;
        sidePanel2.Location = new Point(0, 0);
        sidePanel2.Name = "sidePanel2";
        sidePanel2.Size = new Size(339, 570);
        sidePanel2.TabIndex = 0;
        sidePanel2.Text = "sidePanel2";
        // 
        // gridControl1
        // 
        gridControl1.DataSource = bdSource;
        gridControl1.Dock = DockStyle.Fill;
        gridControl1.Location = new Point(0, 0);
        gridControl1.MainView = gridView1;
        gridControl1.MenuManager = barManager1;
        gridControl1.Name = "gridControl1";
        gridControl1.Size = new Size(338, 570);
        gridControl1.TabIndex = 0;
        gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
        // 
        // gridView1
        // 
        gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colMa, colTen });
        gridView1.GridControl = gridControl1;
        gridView1.Name = "gridView1";
        gridView1.OptionsBehavior.Editable = false;
        gridView1.OptionsFind.AlwaysVisible = true;
        gridView1.OptionsView.ShowFooter = true;
        gridView1.OptionsView.ShowGroupPanel = false;
        // 
        // colMa
        // 
        colMa.AppearanceHeader.Font = new Font("Tahoma", 8.25F, FontStyle.Bold);
        colMa.AppearanceHeader.Options.UseFont = true;
        colMa.AppearanceHeader.Options.UseTextOptions = true;
        colMa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
        colMa.Caption = "Mã  ";
        colMa.FieldName = "Ma";
        colMa.Name = "colMa";
        colMa.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] { new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Ma", "{0}") });
        colMa.Visible = true;
        colMa.VisibleIndex = 0;
        colMa.Width = 80;
        // 
        // colTen
        // 
        colTen.AppearanceHeader.Font = new Font("Tahoma", 8.25F, FontStyle.Bold);
        colTen.AppearanceHeader.Options.UseFont = true;
        colTen.AppearanceHeader.Options.UseTextOptions = true;
        colTen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
        colTen.Caption = "Tên ";
        colTen.FieldName = "Ten";
        colTen.Name = "colTen";
        colTen.Visible = true;
        colTen.VisibleIndex = 1;
        colTen.Width = 231;
        // 
        // textEdit1
        // 
        textEdit1.DataBindings.Add(new Binding("EditValue", bdSource, "Id", true));
        textEdit1.Location = new Point(310, 12);
        textEdit1.MenuManager = barManager1;
        textEdit1.Name = "textEdit1";
        textEdit1.Properties.ReadOnly = true;
        textEdit1.Size = new Size(57, 20);
        textEdit1.StyleController = layoutControl1;
        textEdit1.TabIndex = 2;
        textEdit1.TabStop = false;
        // 
        // layoutControlItem5
        // 
        layoutControlItem5.Control = textEdit1;
        layoutControlItem5.Location = new Point(250, 0);
        layoutControlItem5.Name = "layoutControlItem5";
        layoutControlItem5.Size = new Size(109, 24);
        layoutControlItem5.Text = "Id";
        layoutControlItem5.TextSize = new Size(44, 13);
        // 
        // frmThanhphamBG
        // 
        AutoScaleDimensions = new SizeF(6F, 13F);
        AutoScaleMode = AutoScaleMode.Font;
        AutoScroll = true;
        AutoSizeMode = AutoSizeMode.GrowAndShrink;
        ClientSize = new Size(721, 601);
        Controls.Add(sidePanel1);
        Controls.Add(barDockControlLeft);
        Controls.Add(barDockControlRight);
        Controls.Add(barDockControlBottom);
        Controls.Add(barDockControlTop);
        Margin = new Padding(2);
        Name = "frmThanhphamBG";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Danh mục thành phẩm báo giá";
        ((System.ComponentModel.ISupportInitialize)bdSource).EndInit();
        ((System.ComponentModel.ISupportInitialize)barManager1).EndInit();
        sidePanel1.ResumeLayout(false);
        sidePanel3.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
        layoutControl1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)txtMa.Properties).EndInit();
        ((System.ComponentModel.ISupportInitialize)checkEdit3.Properties).EndInit();
        ((System.ComponentModel.ISupportInitialize)txtTen.Properties).EndInit();
        ((System.ComponentModel.ISupportInitialize)lkDonvi.Properties).EndInit();
        ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties.CalendarTimeProperties).EndInit();
        ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties).EndInit();
        ((System.ComponentModel.ISupportInitialize)Root).EndInit();
        ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
        ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
        ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
        ((System.ComponentModel.ISupportInitialize)layoutControlItem8).EndInit();
        ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
        ((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
        sidePanel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
        ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
        ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
        ((System.ComponentModel.ISupportInitialize)layoutControlItem5).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private System.Windows.Forms.BindingSource bdSource;
    private DevExpress.XtraBars.BarManager barManager1;
    private DevExpress.XtraBars.Bar bar1;
    private DevExpress.XtraBars.BarButtonItem btnAdd;
    private DevExpress.XtraBars.BarButtonItem btnSave;
    private DevExpress.XtraBars.BarButtonItem btnCancel;
    private DevExpress.XtraBars.BarButtonItem btnClose;
    private DevExpress.XtraBars.BarDockControl barDockControlTop;
    private DevExpress.XtraBars.BarDockControl barDockControlBottom;
    private DevExpress.XtraBars.BarDockControl barDockControlLeft;
    private DevExpress.XtraBars.BarDockControl barDockControlRight;
    private DevExpress.XtraBars.BarButtonItem btnDelete;
    private DevExpress.XtraEditors.SidePanel sidePanel1;
    private DevExpress.XtraEditors.SidePanel sidePanel3;
    private DevExpress.XtraEditors.SidePanel sidePanel2;
    private DevExpress.XtraGrid.GridControl gridControl1;
    private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    private DevExpress.XtraLayout.LayoutControl layoutControl1;
    private DevExpress.XtraEditors.TextEdit txtMa;
    private DevExpress.XtraLayout.LayoutControlGroup Root;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    private DevExpress.XtraGrid.Columns.GridColumn colMa;
    private DevExpress.XtraGrid.Columns.GridColumn colTen;
    private DevExpress.XtraEditors.CheckEdit checkEdit3;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
    private DevExpress.XtraEditors.MemoEdit txtTen;
    private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    private DevExpress.XtraEditors.LookUpEdit lkDonvi;
    private DevExpress.XtraEditors.DateEdit dateEdit1;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    private DevExpress.XtraEditors.TextEdit textEdit1;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
}