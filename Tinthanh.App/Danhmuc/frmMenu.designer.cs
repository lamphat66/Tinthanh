
namespace Tinthanh.App.Danhmuc
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            bdSource = new BindingSource(components);
            tlHethong = new DevExpress.XtraTreeList.TreeList();
            colTen = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            colThuoc = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            colIsCaption = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            barManager1 = new DevExpress.XtraBars.BarManager(components);
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            barEdit = new DevExpress.XtraBars.BarButtonItem();
            barAdd = new DevExpress.XtraBars.BarButtonItem();
            barAddChild = new DevExpress.XtraBars.BarButtonItem();
            popupMenu = new DevExpress.XtraBars.PopupMenu(components);
            ((System.ComponentModel.ISupportInitialize)bdSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tlHethong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)barManager1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)popupMenu).BeginInit();
            SuspendLayout();
            // 
            // bdSource
            // 
            bdSource.DataSource = typeof(Tinthanh.Data.Entities.Chucnang);
            // 
            // tlHethong
            // 
            tlHethong.Appearance.BandPanel.Options.UseTextOptions = true;
            tlHethong.Appearance.BandPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            tlHethong.Appearance.Row.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tlHethong.Appearance.Row.Options.UseFont = true;
            tlHethong.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] { colTen, colThuoc, colIsCaption });
            tlHethong.DataSource = bdSource;
            tlHethong.Dock = DockStyle.Left;
            tlHethong.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tlHethong.KeyFieldName = "Ma";
            tlHethong.Location = new Point(0, 0);
            tlHethong.Name = "tlHethong";
            tlHethong.OptionsBehavior.Editable = false;
            tlHethong.OptionsBehavior.ReadOnly = true;
            tlHethong.OptionsMenu.ShowExpandCollapseItems = false;
            tlHethong.OptionsSelection.InvertSelection = true;
            tlHethong.OptionsSelection.SelectNodesOnRightClick = true;
            tlHethong.OptionsView.BestFitNodes = DevExpress.XtraTreeList.TreeListBestFitNodes.All;
            tlHethong.ParentFieldName = "Thuoc";
            tlHethong.Size = new Size(574, 511);
            tlHethong.TabIndex = 0;
            tlHethong.ViewStyle = DevExpress.XtraTreeList.TreeListViewStyle.TreeView;
            tlHethong.CustomDrawNodeCell += tlHethong_CustomDrawNodeCell;
            tlHethong.MouseUp += tlHethong_MouseUp;
            // 
            // colTen
            // 
            colTen.AppearanceHeader.Options.UseTextOptions = true;
            colTen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colTen.Caption = "Tên";
            colTen.FieldName = "Ten";
            colTen.Name = "colTen";
            colTen.Visible = true;
            colTen.VisibleIndex = 0;
            colTen.Width = 281;
            // 
            // colThuoc
            // 
            colThuoc.AppearanceHeader.Options.UseTextOptions = true;
            colThuoc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colThuoc.Caption = "Thuộc";
            colThuoc.FieldName = "Thuoc";
            colThuoc.Name = "colThuoc";
            colThuoc.Width = 74;
            // 
            // colIsCaption
            // 
            colIsCaption.AppearanceHeader.Options.UseTextOptions = true;
            colIsCaption.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colIsCaption.Caption = "Là tiêu đề";
            colIsCaption.FieldName = "IsCaption";
            colIsCaption.Name = "colIsCaption";
            // 
            // barManager1
            // 
            barManager1.DockControls.Add(barDockControlTop);
            barManager1.DockControls.Add(barDockControlBottom);
            barManager1.DockControls.Add(barDockControlLeft);
            barManager1.DockControls.Add(barDockControlRight);
            barManager1.Form = this;
            barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { barEdit, barAdd, barAddChild });
            barManager1.MaxItemId = 3;
            // 
            // barDockControlTop
            // 
            barDockControlTop.CausesValidation = false;
            barDockControlTop.Dock = DockStyle.Top;
            barDockControlTop.Location = new Point(0, 0);
            barDockControlTop.Manager = barManager1;
            barDockControlTop.Size = new Size(580, 0);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = DockStyle.Bottom;
            barDockControlBottom.Location = new Point(0, 511);
            barDockControlBottom.Manager = barManager1;
            barDockControlBottom.Size = new Size(580, 0);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = DockStyle.Left;
            barDockControlLeft.Location = new Point(0, 0);
            barDockControlLeft.Manager = barManager1;
            barDockControlLeft.Size = new Size(0, 511);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = DockStyle.Right;
            barDockControlRight.Location = new Point(580, 0);
            barDockControlRight.Manager = barManager1;
            barDockControlRight.Size = new Size(0, 511);
            // 
            // barEdit
            // 
            barEdit.Caption = "Hiệu chỉnh";
            barEdit.Id = 0;
            barEdit.ImageOptions.Image = (Image)resources.GetObject("barEdit.ImageOptions.Image");
            barEdit.ImageOptions.LargeImage = (Image)resources.GetObject("barEdit.ImageOptions.LargeImage");
            barEdit.Name = "barEdit";
            // 
            // barAdd
            // 
            barAdd.Caption = "Thêm chức năng cùng cấp";
            barAdd.Id = 1;
            barAdd.ImageOptions.Image = (Image)resources.GetObject("barAdd.ImageOptions.Image");
            barAdd.ImageOptions.LargeImage = (Image)resources.GetObject("barAdd.ImageOptions.LargeImage");
            barAdd.Name = "barAdd";
            // 
            // barAddChild
            // 
            barAddChild.Caption = "Thêm chức năng con";
            barAddChild.Id = 2;
            barAddChild.ImageOptions.Image = (Image)resources.GetObject("barAddChild.ImageOptions.Image");
            barAddChild.ImageOptions.LargeImage = (Image)resources.GetObject("barAddChild.ImageOptions.LargeImage");
            barAddChild.Name = "barAddChild";
            // 
            // popupMenu
            // 
            popupMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(barEdit), new DevExpress.XtraBars.LinkPersistInfo(barAdd), new DevExpress.XtraBars.LinkPersistInfo(barAddChild) });
            popupMenu.Manager = barManager1;
            popupMenu.Name = "popupMenu";
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 511);
            Controls.Add(tlHethong);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            Name = "frmMenu";
            Text = "Chức năng hệ thống";
            Load += frmMenu_Load;
            ((System.ComponentModel.ISupportInitialize)bdSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)tlHethong).EndInit();
            ((System.ComponentModel.ISupportInitialize)barManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)popupMenu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.BindingSource bdSource;
        private DevExpress.XtraTreeList.TreeList tlHethong;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colTen;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colThuoc;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colIsCaption;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barEdit;
        private DevExpress.XtraBars.BarButtonItem barAdd;
        private DevExpress.XtraBars.BarButtonItem barAddChild;
        private DevExpress.XtraBars.PopupMenu popupMenu;
    }
}