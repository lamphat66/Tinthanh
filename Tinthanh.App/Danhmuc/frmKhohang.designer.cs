
namespace Tinthanh.App.Danhmuc;

partial class frmKhohang
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhohang));
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
        bdSource = new BindingSource(components);
        txtTen = new DevExpress.XtraEditors.TextEdit();
        txtTentat = new DevExpress.XtraEditors.TextEdit();
        lkNhom = new DevExpress.XtraEditors.LookUpEdit();
        txtDiachi = new DevExpress.XtraEditors.TextEdit();
        chkKhoao = new DevExpress.XtraEditors.CheckEdit();
        chkVitri = new DevExpress.XtraEditors.CheckEdit();
        chkNgungsd = new DevExpress.XtraEditors.CheckEdit();
        Root = new DevExpress.XtraLayout.LayoutControlGroup();
        layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
        layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
        layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
        layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
        layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
        layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
        layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
        layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
        sidePanel2 = new DevExpress.XtraEditors.SidePanel();
        gridControl1 = new DevExpress.XtraGrid.GridControl();
        gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
        colMa = new DevExpress.XtraGrid.Columns.GridColumn();
        colTen = new DevExpress.XtraGrid.Columns.GridColumn();
        gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
        ((System.ComponentModel.ISupportInitialize)barManager1).BeginInit();
        sidePanel1.SuspendLayout();
        sidePanel3.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
        layoutControl1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)txtMa.Properties).BeginInit();
        ((System.ComponentModel.ISupportInitialize)bdSource).BeginInit();
        ((System.ComponentModel.ISupportInitialize)txtTen.Properties).BeginInit();
        ((System.ComponentModel.ISupportInitialize)txtTentat.Properties).BeginInit();
        ((System.ComponentModel.ISupportInitialize)lkNhom.Properties).BeginInit();
        ((System.ComponentModel.ISupportInitialize)txtDiachi.Properties).BeginInit();
        ((System.ComponentModel.ISupportInitialize)chkKhoao.Properties).BeginInit();
        ((System.ComponentModel.ISupportInitialize)chkVitri.Properties).BeginInit();
        ((System.ComponentModel.ISupportInitialize)chkNgungsd.Properties).BeginInit();
        ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
        ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
        ((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
        ((System.ComponentModel.ISupportInitialize)layoutControlItem5).BeginInit();
        ((System.ComponentModel.ISupportInitialize)layoutControlItem6).BeginInit();
        ((System.ComponentModel.ISupportInitialize)layoutControlItem7).BeginInit();
        ((System.ComponentModel.ISupportInitialize)layoutControlItem8).BeginInit();
        sidePanel2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
        SuspendLayout();
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
        // 
        // btnCancel
        // 
        btnCancel.Caption = "Hủy";
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
        // 
        // barDockControlTop
        // 
        barDockControlTop.CausesValidation = false;
        barDockControlTop.Dock = DockStyle.Top;
        barDockControlTop.Location = new Point(0, 0);
        barDockControlTop.Manager = barManager1;
        barDockControlTop.Size = new Size(719, 31);
        // 
        // barDockControlBottom
        // 
        barDockControlBottom.CausesValidation = false;
        barDockControlBottom.Dock = DockStyle.Bottom;
        barDockControlBottom.Location = new Point(0, 888);
        barDockControlBottom.Manager = barManager1;
        barDockControlBottom.Size = new Size(719, 0);
        // 
        // barDockControlLeft
        // 
        barDockControlLeft.CausesValidation = false;
        barDockControlLeft.Dock = DockStyle.Left;
        barDockControlLeft.Location = new Point(0, 31);
        barDockControlLeft.Manager = barManager1;
        barDockControlLeft.Size = new Size(0, 857);
        // 
        // barDockControlRight
        // 
        barDockControlRight.CausesValidation = false;
        barDockControlRight.Dock = DockStyle.Right;
        barDockControlRight.Location = new Point(719, 31);
        barDockControlRight.Manager = barManager1;
        barDockControlRight.Size = new Size(0, 857);
        // 
        // sidePanel1
        // 
        sidePanel1.Controls.Add(sidePanel3);
        sidePanel1.Controls.Add(sidePanel2);
        sidePanel1.Dock = DockStyle.Left;
        sidePanel1.Location = new Point(0, 31);
        sidePanel1.Name = "sidePanel1";
        sidePanel1.Size = new Size(719, 857);
        sidePanel1.TabIndex = 9;
        sidePanel1.Text = "sidePanel1";
        // 
        // sidePanel3
        // 
        sidePanel3.Controls.Add(layoutControl1);
        sidePanel3.Dock = DockStyle.Fill;
        sidePanel3.Location = new Point(339, 0);
        sidePanel3.Name = "sidePanel3";
        sidePanel3.Size = new Size(379, 857);
        sidePanel3.TabIndex = 1;
        sidePanel3.Text = "sidePanel3";
        // 
        // layoutControl1
        // 
        layoutControl1.Controls.Add(txtMa);
        layoutControl1.Controls.Add(txtTen);
        layoutControl1.Controls.Add(txtTentat);
        layoutControl1.Controls.Add(lkNhom);
        layoutControl1.Controls.Add(txtDiachi);
        layoutControl1.Controls.Add(chkKhoao);
        layoutControl1.Controls.Add(chkVitri);
        layoutControl1.Controls.Add(chkNgungsd);
        layoutControl1.Dock = DockStyle.Fill;
        layoutControl1.Location = new Point(0, 0);
        layoutControl1.Name = "layoutControl1";
        layoutControl1.Root = Root;
        layoutControl1.Size = new Size(379, 857);
        layoutControl1.TabIndex = 0;
        layoutControl1.Text = "layoutControl1";
        // 
        // txtMa
        // 
        txtMa.DataBindings.Add(new Binding("EditValue", bdSource, "Ma", true, DataSourceUpdateMode.OnPropertyChanged));
        txtMa.Location = new Point(54, 12);
        txtMa.MenuManager = barManager1;
        txtMa.Name = "txtMa";
        txtMa.Size = new Size(313, 20);
        txtMa.StyleController = layoutControl1;
        txtMa.TabIndex = 4;
        // 
        // bdSource
        // 
        bdSource.DataSource = typeof(Data.Entities.Kho);
        // 
        // txtTen
        // 
        txtTen.DataBindings.Add(new Binding("EditValue", bdSource, "Ten", true, DataSourceUpdateMode.OnPropertyChanged));
        txtTen.Location = new Point(54, 36);
        txtTen.MenuManager = barManager1;
        txtTen.Name = "txtTen";
        txtTen.Size = new Size(313, 20);
        txtTen.StyleController = layoutControl1;
        txtTen.TabIndex = 5;
        // 
        // txtTentat
        // 
        txtTentat.DataBindings.Add(new Binding("EditValue", bdSource, "Tentat", true, DataSourceUpdateMode.OnPropertyChanged));
        txtTentat.Location = new Point(54, 60);
        txtTentat.MenuManager = barManager1;
        txtTentat.Name = "txtTentat";
        txtTentat.Size = new Size(313, 20);
        txtTentat.StyleController = layoutControl1;
        txtTentat.TabIndex = 6;
        // 
        // lkNhom
        // 
        lkNhom.DataBindings.Add(new Binding("EditValue", bdSource, "Manhom", true, DataSourceUpdateMode.OnPropertyChanged));
        lkNhom.Location = new Point(54, 84);
        lkNhom.MenuManager = barManager1;
        lkNhom.Name = "lkNhom";
        lkNhom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
        lkNhom.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] { new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten", "Name1") });
        lkNhom.Properties.NullText = "";
        lkNhom.Properties.ShowHeader = false;
        lkNhom.Size = new Size(313, 20);
        lkNhom.StyleController = layoutControl1;
        lkNhom.TabIndex = 7;
        // 
        // txtDiachi
        // 
        txtDiachi.DataBindings.Add(new Binding("EditValue", bdSource, "Diachi", true, DataSourceUpdateMode.OnPropertyChanged));
        txtDiachi.Location = new Point(54, 108);
        txtDiachi.MenuManager = barManager1;
        txtDiachi.Name = "txtDiachi";
        txtDiachi.Size = new Size(313, 20);
        txtDiachi.StyleController = layoutControl1;
        txtDiachi.TabIndex = 8;
        // 
        // chkKhoao
        // 
        chkKhoao.DataBindings.Add(new Binding("EditValue", bdSource, "Kho_ao", true, DataSourceUpdateMode.OnPropertyChanged));
        chkKhoao.Location = new Point(12, 132);
        chkKhoao.MenuManager = barManager1;
        chkKhoao.Name = "chkKhoao";
        chkKhoao.Properties.Caption = "Kho ảo";
        chkKhoao.Size = new Size(355, 19);
        chkKhoao.StyleController = layoutControl1;
        chkKhoao.TabIndex = 9;
        // 
        // chkVitri
        // 
        chkVitri.DataBindings.Add(new Binding("EditValue", bdSource, "vitri", true, DataSourceUpdateMode.OnPropertyChanged));
        chkVitri.Location = new Point(12, 155);
        chkVitri.MenuManager = barManager1;
        chkVitri.Name = "chkVitri";
        chkVitri.Properties.Caption = "Vị trí";
        chkVitri.Size = new Size(355, 19);
        chkVitri.StyleController = layoutControl1;
        chkVitri.TabIndex = 10;
        // 
        // chkNgungsd
        // 
        chkNgungsd.DataBindings.Add(new Binding("EditValue", bdSource, "Ngungsd", true, DataSourceUpdateMode.OnPropertyChanged));
        chkNgungsd.Location = new Point(12, 178);
        chkNgungsd.MenuManager = barManager1;
        chkNgungsd.Name = "chkNgungsd";
        chkNgungsd.Properties.Caption = "Ngưng sử dụng";
        chkNgungsd.Size = new Size(355, 19);
        chkNgungsd.StyleController = layoutControl1;
        chkNgungsd.TabIndex = 11;
        // 
        // Root
        // 
        Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
        Root.GroupBordersVisible = false;
        Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, layoutControlItem2, layoutControlItem3, layoutControlItem4, layoutControlItem5, layoutControlItem6, layoutControlItem7, layoutControlItem8 });
        Root.Name = "Root";
        Root.Size = new Size(379, 857);
        Root.TextVisible = false;
        // 
        // layoutControlItem1
        // 
        layoutControlItem1.Control = txtMa;
        layoutControlItem1.Location = new Point(0, 0);
        layoutControlItem1.Name = "layoutControlItem1";
        layoutControlItem1.Size = new Size(359, 24);
        layoutControlItem1.Text = "Mã";
        layoutControlItem1.TextSize = new Size(38, 13);
        // 
        // layoutControlItem2
        // 
        layoutControlItem2.Control = txtTen;
        layoutControlItem2.Location = new Point(0, 24);
        layoutControlItem2.Name = "layoutControlItem2";
        layoutControlItem2.Size = new Size(359, 24);
        layoutControlItem2.Text = "Tên kho";
        layoutControlItem2.TextSize = new Size(38, 13);
        // 
        // layoutControlItem3
        // 
        layoutControlItem3.Control = txtTentat;
        layoutControlItem3.Location = new Point(0, 48);
        layoutControlItem3.Name = "layoutControlItem3";
        layoutControlItem3.Size = new Size(359, 24);
        layoutControlItem3.Text = "Tên tắt";
        layoutControlItem3.TextSize = new Size(38, 13);
        // 
        // layoutControlItem4
        // 
        layoutControlItem4.Control = lkNhom;
        layoutControlItem4.Location = new Point(0, 72);
        layoutControlItem4.Name = "layoutControlItem4";
        layoutControlItem4.Size = new Size(359, 24);
        layoutControlItem4.Text = "Nhóm";
        layoutControlItem4.TextSize = new Size(38, 13);
        // 
        // layoutControlItem5
        // 
        layoutControlItem5.Control = txtDiachi;
        layoutControlItem5.Location = new Point(0, 96);
        layoutControlItem5.Name = "layoutControlItem5";
        layoutControlItem5.Size = new Size(359, 24);
        layoutControlItem5.Text = "Địa chỉ";
        layoutControlItem5.TextSize = new Size(38, 13);
        // 
        // layoutControlItem6
        // 
        layoutControlItem6.Control = chkKhoao;
        layoutControlItem6.Location = new Point(0, 120);
        layoutControlItem6.Name = "layoutControlItem6";
        layoutControlItem6.Size = new Size(359, 23);
        layoutControlItem6.TextSize = new Size(0, 0);
        layoutControlItem6.TextVisible = false;
        // 
        // layoutControlItem7
        // 
        layoutControlItem7.Control = chkVitri;
        layoutControlItem7.Location = new Point(0, 143);
        layoutControlItem7.Name = "layoutControlItem7";
        layoutControlItem7.Size = new Size(359, 23);
        layoutControlItem7.TextSize = new Size(0, 0);
        layoutControlItem7.TextVisible = false;
        // 
        // layoutControlItem8
        // 
        layoutControlItem8.Control = chkNgungsd;
        layoutControlItem8.Location = new Point(0, 166);
        layoutControlItem8.Name = "layoutControlItem8";
        layoutControlItem8.Size = new Size(359, 671);
        layoutControlItem8.TextSize = new Size(0, 0);
        layoutControlItem8.TextVisible = false;
        // 
        // sidePanel2
        // 
        sidePanel2.Controls.Add(gridControl1);
        sidePanel2.Dock = DockStyle.Left;
        sidePanel2.Location = new Point(0, 0);
        sidePanel2.Name = "sidePanel2";
        sidePanel2.Size = new Size(339, 857);
        sidePanel2.TabIndex = 0;
        sidePanel2.Text = "sidePanel2";
        // 
        // gridControl1
        // 
        gridControl1.Dock = DockStyle.Fill;
        gridControl1.Location = new Point(0, 0);
        gridControl1.MainView = gridView1;
        gridControl1.MenuManager = barManager1;
        gridControl1.Name = "gridControl1";
        gridControl1.Size = new Size(338, 857);
        gridControl1.TabIndex = 0;
        gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
        // 
        // gridView1
        // 
        gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn1, colMa, colTen });
        gridView1.GridControl = gridControl1;
        gridView1.Name = "gridView1";
        gridView1.OptionsBehavior.Editable = false;
        gridView1.OptionsView.ShowGroupPanel = false;
        // 
        // colMa
        // 
        colMa.AppearanceHeader.Font = new Font("Tahoma", 8.25F, FontStyle.Bold);
        colMa.AppearanceHeader.Options.UseFont = true;
        colMa.AppearanceHeader.Options.UseTextOptions = true;
        colMa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
        colMa.Caption = "Mã kho";
        colMa.FieldName = "Ma";
        colMa.Name = "colMa";
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
        colTen.Caption = "Tên kho";
        colTen.FieldName = "Ten";
        colTen.Name = "colTen";
        colTen.Visible = true;
        colTen.VisibleIndex = 1;
        colTen.Width = 231;
        // 
        // gridColumn1
        // 
        gridColumn1.Caption = "gridColumn1";
        gridColumn1.FieldName = "Id";
        gridColumn1.Name = "gridColumn1";
        // 
        // frmKhohang
        // 
        AutoScaleDimensions = new SizeF(6F, 13F);
        AutoScaleMode = AutoScaleMode.Font;
        AutoScroll = true;
        AutoSizeMode = AutoSizeMode.GrowAndShrink;
        ClientSize = new Size(703, 905);
        Controls.Add(sidePanel1);
        Controls.Add(barDockControlLeft);
        Controls.Add(barDockControlRight);
        Controls.Add(barDockControlBottom);
        Controls.Add(barDockControlTop);
        Margin = new Padding(2);
        Name = "frmKhohang";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Danh mục kho hàng";
        ((System.ComponentModel.ISupportInitialize)barManager1).EndInit();
        sidePanel1.ResumeLayout(false);
        sidePanel3.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
        layoutControl1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)txtMa.Properties).EndInit();
        ((System.ComponentModel.ISupportInitialize)bdSource).EndInit();
        ((System.ComponentModel.ISupportInitialize)txtTen.Properties).EndInit();
        ((System.ComponentModel.ISupportInitialize)txtTentat.Properties).EndInit();
        ((System.ComponentModel.ISupportInitialize)lkNhom.Properties).EndInit();
        ((System.ComponentModel.ISupportInitialize)txtDiachi.Properties).EndInit();
        ((System.ComponentModel.ISupportInitialize)chkKhoao.Properties).EndInit();
        ((System.ComponentModel.ISupportInitialize)chkVitri.Properties).EndInit();
        ((System.ComponentModel.ISupportInitialize)chkNgungsd.Properties).EndInit();
        ((System.ComponentModel.ISupportInitialize)Root).EndInit();
        ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
        ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
        ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
        ((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
        ((System.ComponentModel.ISupportInitialize)layoutControlItem5).EndInit();
        ((System.ComponentModel.ISupportInitialize)layoutControlItem6).EndInit();
        ((System.ComponentModel.ISupportInitialize)layoutControlItem7).EndInit();
        ((System.ComponentModel.ISupportInitialize)layoutControlItem8).EndInit();
        sidePanel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
        ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
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
    private DevExpress.XtraEditors.TextEdit txtTen;
    private DevExpress.XtraEditors.TextEdit txtTentat;
    private DevExpress.XtraEditors.LookUpEdit lkNhom;
    private DevExpress.XtraEditors.TextEdit txtDiachi;
    private DevExpress.XtraLayout.LayoutControlGroup Root;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    private DevExpress.XtraGrid.Columns.GridColumn colMa;
    private DevExpress.XtraGrid.Columns.GridColumn colTen;
    private DevExpress.XtraEditors.CheckEdit chkKhoao;
    private DevExpress.XtraEditors.CheckEdit chkVitri;
    private DevExpress.XtraEditors.CheckEdit chkNgungsd;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
    private BindingSource bdSource;
    private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
}