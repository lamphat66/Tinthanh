namespace Tinthanh.App.Danhmuc
{
    partial class frmBanggiaNCC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBanggiaNCC));
            bdSource = new BindingSource(components);
            barManager1 = new DevExpress.XtraBars.BarManager(components);
            bar1 = new DevExpress.XtraBars.Bar();
            btnAdd = new DevExpress.XtraBars.BarButtonItem();
            btnDelete = new DevExpress.XtraBars.BarButtonItem();
            btnClose = new DevExpress.XtraBars.BarButtonItem();
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            bar2 = new DevExpress.XtraBars.Bar();
            sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            sidePanel3 = new DevExpress.XtraEditors.SidePanel();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            colMasp = new DevExpress.XtraGrid.Columns.GridColumn();
            colTenSPKH = new DevExpress.XtraGrid.Columns.GridColumn();
            colDonvi = new DevExpress.XtraGrid.Columns.GridColumn();
            colTenSPTT = new DevExpress.XtraGrid.Columns.GridColumn();
            colGiaban = new DevExpress.XtraGrid.Columns.GridColumn();
            colGiacu = new DevExpress.XtraGrid.Columns.GridColumn();
            colChietkhau = new DevExpress.XtraGrid.Columns.GridColumn();
            colBaohanh = new DevExpress.XtraGrid.Columns.GridColumn();
            colHoadon = new DevExpress.XtraGrid.Columns.GridColumn();
            colChietkhauSP = new DevExpress.XtraGrid.Columns.GridColumn();
            colTienChietKhau = new DevExpress.XtraGrid.Columns.GridColumn();
            colUsers = new DevExpress.XtraGrid.Columns.GridColumn();
            colNgaycapnhat = new DevExpress.XtraGrid.Columns.GridColumn();
            colVAT = new DevExpress.XtraGrid.Columns.GridColumn();
            colROHS = new DevExpress.XtraGrid.Columns.GridColumn();
            colGhichu = new DevExpress.XtraGrid.Columns.GridColumn();
            sidePanel2 = new DevExpress.XtraEditors.SidePanel();
            gridControl2 = new DevExpress.XtraGrid.GridControl();
            gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            colMa = new DevExpress.XtraGrid.Columns.GridColumn();
            colTen = new DevExpress.XtraGrid.Columns.GridColumn();
            sidePanel4 = new DevExpress.XtraEditors.SidePanel();
            btnFind = new DevExpress.XtraEditors.SimpleButton();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            txtFind = new DevExpress.XtraEditors.TextEdit();
            gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)bdSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)barManager1).BeginInit();
            sidePanel1.SuspendLayout();
            sidePanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            sidePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControl2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView2).BeginInit();
            sidePanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtFind.Properties).BeginInit();
            SuspendLayout();
            // 
            // bdSource
            // 
            bdSource.DataSource = typeof(Data.Entities.BanggiaNCC);
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
            barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { btnAdd, btnDelete, btnClose });
            barManager1.MaxItemId = 5;
            // 
            // bar1
            // 
            bar1.BarName = "Custom 3";
            bar1.DockCol = 0;
            bar1.DockRow = 0;
            bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(btnAdd), new DevExpress.XtraBars.LinkPersistInfo(btnDelete, true), new DevExpress.XtraBars.LinkPersistInfo(btnClose, true) });
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
            barDockControlTop.Size = new Size(1083, 31);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = DockStyle.Bottom;
            barDockControlBottom.Location = new Point(0, 647);
            barDockControlBottom.Manager = barManager1;
            barDockControlBottom.Size = new Size(1083, 0);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = DockStyle.Left;
            barDockControlLeft.Location = new Point(0, 31);
            barDockControlLeft.Manager = barManager1;
            barDockControlLeft.Size = new Size(0, 616);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = DockStyle.Right;
            barDockControlRight.Location = new Point(1083, 31);
            barDockControlRight.Manager = barManager1;
            barDockControlRight.Size = new Size(0, 616);
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
            // sidePanel1
            // 
            sidePanel1.Controls.Add(sidePanel3);
            sidePanel1.Controls.Add(sidePanel2);
            sidePanel1.Dock = DockStyle.Fill;
            sidePanel1.Location = new Point(0, 31);
            sidePanel1.Name = "sidePanel1";
            sidePanel1.Size = new Size(1083, 616);
            sidePanel1.TabIndex = 7;
            sidePanel1.Text = "sidePanel1";
            // 
            // sidePanel3
            // 
            sidePanel3.Controls.Add(gridControl1);
            sidePanel3.Dock = DockStyle.Fill;
            sidePanel3.Location = new Point(390, 0);
            sidePanel3.Name = "sidePanel3";
            sidePanel3.Size = new Size(693, 616);
            sidePanel3.TabIndex = 1;
            sidePanel3.Text = "sidePanel3";
            // 
            // gridControl1
            // 
            gridControl1.DataSource = bdSource;
            gridControl1.Dock = DockStyle.Fill;
            gridControl1.Location = new Point(0, 0);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(693, 616);
            gridControl1.TabIndex = 3;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colMasp, colTenSPKH, colDonvi, colTenSPTT, colGiaban, colGiacu, colChietkhau, colBaohanh, colHoadon, colChietkhauSP, colTienChietKhau, colUsers, colNgaycapnhat, colVAT, colROHS, colGhichu });
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.OptionsEditForm.EditFormColumnCount = 1;
            gridView1.OptionsNavigation.AutoFocusNewRow = true;
            gridView1.OptionsSelection.InvertSelection = true;
            gridView1.OptionsView.ColumnAutoWidth = false;
            gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            gridView1.OptionsView.ShowFooter = true;
            gridView1.OptionsView.ShowGroupPanel = false;
            gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] { new DevExpress.XtraGrid.Columns.GridColumnSortInfo(colROHS, DevExpress.Data.ColumnSortOrder.Ascending) });
            // 
            // colMasp
            // 
            colMasp.AppearanceHeader.Options.UseTextOptions = true;
            colMasp.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colMasp.Caption = "Mã VT";
            colMasp.FieldName = "VattuId";
            colMasp.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            colMasp.Name = "colMasp";
            colMasp.OptionsColumn.FixedWidth = true;
            colMasp.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] { new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "MaVT", "{0}") });
            colMasp.Visible = true;
            colMasp.VisibleIndex = 0;
            colMasp.Width = 104;
            // 
            // colTenSPKH
            // 
            colTenSPKH.AppearanceHeader.Options.UseTextOptions = true;
            colTenSPKH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colTenSPKH.Caption = "Tên vật tư";
            colTenSPKH.FieldName = "TenVT";
            colTenSPKH.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            colTenSPKH.Name = "colTenSPKH";
            colTenSPKH.Visible = true;
            colTenSPKH.VisibleIndex = 1;
            colTenSPKH.Width = 177;
            // 
            // colDonvi
            // 
            colDonvi.AppearanceHeader.Options.UseTextOptions = true;
            colDonvi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colDonvi.Caption = "Đơn vị";
            colDonvi.FieldName = "Donvi";
            colDonvi.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            colDonvi.Name = "colDonvi";
            colDonvi.Visible = true;
            colDonvi.VisibleIndex = 2;
            // 
            // colTenSPTT
            // 
            colTenSPTT.AppearanceHeader.Options.UseTextOptions = true;
            colTenSPTT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colTenSPTT.Caption = "Tên nội bộ";
            colTenSPTT.FieldName = "TenNB";
            colTenSPTT.Name = "colTenSPTT";
            colTenSPTT.Visible = true;
            colTenSPTT.VisibleIndex = 3;
            colTenSPTT.Width = 179;
            // 
            // colGiaban
            // 
            colGiaban.AppearanceHeader.Options.UseTextOptions = true;
            colGiaban.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colGiaban.Caption = "Giá mua";
            colGiaban.DisplayFormat.FormatString = "n0";
            colGiaban.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colGiaban.FieldName = "Giaban";
            colGiaban.Name = "colGiaban";
            colGiaban.Visible = true;
            colGiaban.VisibleIndex = 4;
            // 
            // colGiacu
            // 
            colGiacu.AppearanceHeader.Options.UseTextOptions = true;
            colGiacu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colGiacu.Caption = "Giá củ";
            colGiacu.DisplayFormat.FormatString = "n0";
            colGiacu.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colGiacu.FieldName = "Giacu";
            colGiacu.Name = "colGiacu";
            colGiacu.Visible = true;
            colGiacu.VisibleIndex = 5;
            // 
            // colChietkhau
            // 
            colChietkhau.AppearanceHeader.Options.UseTextOptions = true;
            colChietkhau.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colChietkhau.Caption = "Chiết khấu";
            colChietkhau.FieldName = "Chietkhau";
            colChietkhau.Name = "colChietkhau";
            colChietkhau.Visible = true;
            colChietkhau.VisibleIndex = 6;
            // 
            // colBaohanh
            // 
            colBaohanh.AppearanceHeader.Options.UseTextOptions = true;
            colBaohanh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colBaohanh.Caption = "Bảo hành";
            colBaohanh.FieldName = "Baohanh";
            colBaohanh.Name = "colBaohanh";
            colBaohanh.Visible = true;
            colBaohanh.VisibleIndex = 9;
            // 
            // colHoadon
            // 
            colHoadon.AppearanceHeader.Options.UseTextOptions = true;
            colHoadon.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colHoadon.Caption = "Hoá đơn";
            colHoadon.FieldName = "Hoadon";
            colHoadon.Name = "colHoadon";
            colHoadon.Visible = true;
            colHoadon.VisibleIndex = 11;
            // 
            // colChietkhauSP
            // 
            colChietkhauSP.AppearanceHeader.Options.UseTextOptions = true;
            colChietkhauSP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colChietkhauSP.Caption = "C.Khấu SP";
            colChietkhauSP.FieldName = "ChietkhauSP";
            colChietkhauSP.Name = "colChietkhauSP";
            colChietkhauSP.Visible = true;
            colChietkhauSP.VisibleIndex = 7;
            // 
            // colTienChietKhau
            // 
            colTienChietKhau.AppearanceHeader.Options.UseTextOptions = true;
            colTienChietKhau.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colTienChietKhau.Caption = "Tiền C.Khấu";
            colTienChietKhau.FieldName = "TienChietKhau";
            colTienChietKhau.Name = "colTienChietKhau";
            colTienChietKhau.Visible = true;
            colTienChietKhau.VisibleIndex = 8;
            // 
            // colUsers
            // 
            colUsers.AppearanceHeader.Options.UseTextOptions = true;
            colUsers.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colUsers.Caption = "User";
            colUsers.FieldName = "Users";
            colUsers.Name = "colUsers";
            colUsers.Visible = true;
            colUsers.VisibleIndex = 13;
            // 
            // colNgaycapnhat
            // 
            colNgaycapnhat.AppearanceHeader.Options.UseTextOptions = true;
            colNgaycapnhat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colNgaycapnhat.Caption = "Ngày update";
            colNgaycapnhat.FieldName = "NgayUpdate";
            colNgaycapnhat.Name = "colNgaycapnhat";
            colNgaycapnhat.Visible = true;
            colNgaycapnhat.VisibleIndex = 14;
            // 
            // colVAT
            // 
            colVAT.AppearanceHeader.Options.UseTextOptions = true;
            colVAT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colVAT.Caption = "VAT";
            colVAT.FieldName = "VAT";
            colVAT.Name = "colVAT";
            colVAT.Visible = true;
            colVAT.VisibleIndex = 12;
            // 
            // colROHS
            // 
            colROHS.AppearanceHeader.Options.UseTextOptions = true;
            colROHS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colROHS.FieldName = "ROHS";
            colROHS.Name = "colROHS";
            colROHS.Visible = true;
            colROHS.VisibleIndex = 10;
            // 
            // colGhichu
            // 
            colGhichu.Caption = "Ghi chú";
            colGhichu.FieldName = "Ghichu";
            colGhichu.Name = "colGhichu";
            colGhichu.Visible = true;
            colGhichu.VisibleIndex = 15;
            colGhichu.Width = 120;
            // 
            // sidePanel2
            // 
            sidePanel2.Controls.Add(gridControl2);
            sidePanel2.Controls.Add(sidePanel4);
            sidePanel2.Dock = DockStyle.Left;
            sidePanel2.Location = new Point(0, 0);
            sidePanel2.Name = "sidePanel2";
            sidePanel2.Size = new Size(390, 616);
            sidePanel2.TabIndex = 0;
            sidePanel2.Text = "sidePanel2";
            // 
            // gridControl2
            // 
            gridControl2.Dock = DockStyle.Fill;
            gridControl2.Location = new Point(0, 0);
            gridControl2.MainView = gridView2;
            gridControl2.MenuManager = barManager1;
            gridControl2.Name = "gridControl2";
            gridControl2.Size = new Size(389, 563);
            gridControl2.TabIndex = 2;
            gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView2 });
            // 
            // gridView2
            // 
            gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colMa, colTen, gridColumn1 });
            gridView2.GridControl = gridControl2;
            gridView2.Name = "gridView2";
            gridView2.OptionsBehavior.Editable = false;
            gridView2.OptionsView.ShowFooter = true;
            gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colMa
            // 
            colMa.AppearanceHeader.Font = new Font("Tahoma", 8.25F, FontStyle.Bold);
            colMa.AppearanceHeader.Options.UseFont = true;
            colMa.AppearanceHeader.Options.UseTextOptions = true;
            colMa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colMa.Caption = "Mã ";
            colMa.FieldName = "Ma";
            colMa.Name = "colMa";
            colMa.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] { new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Ma", "{0}") });
            colMa.Visible = true;
            colMa.VisibleIndex = 0;
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
            colTen.Width = 292;
            // 
            // sidePanel4
            // 
            sidePanel4.Controls.Add(btnFind);
            sidePanel4.Controls.Add(labelControl1);
            sidePanel4.Controls.Add(txtFind);
            sidePanel4.Dock = DockStyle.Bottom;
            sidePanel4.Location = new Point(0, 563);
            sidePanel4.Name = "sidePanel4";
            sidePanel4.Size = new Size(389, 53);
            sidePanel4.TabIndex = 0;
            sidePanel4.Text = "sidePanel4";
            // 
            // btnFind
            // 
            btnFind.ImageOptions.Image = (Image)resources.GetObject("btnFind.ImageOptions.Image");
            btnFind.Location = new Point(300, 15);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(77, 23);
            btnFind.TabIndex = 5;
            btnFind.Text = "Tìm";
            // 
            // labelControl1
            // 
            labelControl1.Location = new Point(12, 20);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(76, 13);
            labelControl1.TabIndex = 4;
            labelControl1.Text = "Nhập tên để tìm";
            // 
            // txtFind
            // 
            txtFind.Location = new Point(105, 17);
            txtFind.MenuManager = barManager1;
            txtFind.Name = "txtFind";
            txtFind.Size = new Size(189, 20);
            txtFind.TabIndex = 3;
            // 
            // gridColumn1
            // 
            gridColumn1.Caption = "gridColumn1";
            gridColumn1.FieldName = "Id";
            gridColumn1.Name = "gridColumn1";
            // 
            // frmBanggiaNCC
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1083, 647);
            Controls.Add(sidePanel1);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            Name = "frmBanggiaNCC";
            Text = "Bảng giá nhà cung cấp";
            ((System.ComponentModel.ISupportInitialize)bdSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)barManager1).EndInit();
            sidePanel1.ResumeLayout(false);
            sidePanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            sidePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControl2).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView2).EndInit();
            sidePanel4.ResumeLayout(false);
            sidePanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtFind.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource bdSource;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraEditors.SidePanel sidePanel3;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMasp;
        private DevExpress.XtraGrid.Columns.GridColumn colTenSPKH;
        private DevExpress.XtraGrid.Columns.GridColumn colDonvi;
        private DevExpress.XtraGrid.Columns.GridColumn colTenSPTT;
        private DevExpress.XtraGrid.Columns.GridColumn colGiaban;
        private DevExpress.XtraGrid.Columns.GridColumn colGiacu;
        private DevExpress.XtraGrid.Columns.GridColumn colUsers;
        private DevExpress.XtraGrid.Columns.GridColumn colNgaycapnhat;
        private DevExpress.XtraEditors.SidePanel sidePanel2;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMa;
        private DevExpress.XtraGrid.Columns.GridColumn colTen;
        private DevExpress.XtraEditors.SidePanel sidePanel4;
        private DevExpress.XtraEditors.SimpleButton btnFind;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtFind;
        private DevExpress.XtraGrid.Columns.GridColumn colChietkhau;
        private DevExpress.XtraGrid.Columns.GridColumn colBaohanh;
        private DevExpress.XtraGrid.Columns.GridColumn colHoadon;
        private DevExpress.XtraGrid.Columns.GridColumn colChietkhauSP;
        private DevExpress.XtraGrid.Columns.GridColumn colTienChietKhau;
        private DevExpress.XtraGrid.Columns.GridColumn colVAT;
        private DevExpress.XtraGrid.Columns.GridColumn colROHS;
        private DevExpress.XtraGrid.Columns.GridColumn colGhichu;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}