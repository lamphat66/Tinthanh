namespace Tinthanh.App
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            mnuThoat = new DevExpress.XtraBars.BarButtonItem();
            stNum = new DevExpress.XtraBars.BarStaticItem();
            stIns = new DevExpress.XtraBars.BarStaticItem();
            stUser = new DevExpress.XtraBars.BarStaticItem();
            stNgay = new DevExpress.XtraBars.BarStaticItem();
            stCap = new DevExpress.XtraBars.BarStaticItem();
            mnuDonvi = new DevExpress.XtraBars.BarButtonItem();
            mnuDanhdiem = new DevExpress.XtraBars.BarButtonItem();
            mnuDoituong = new DevExpress.XtraBars.BarButtonItem();
            btnKhachhang = new DevExpress.XtraBars.BarButtonItem();
            btnKho = new DevExpress.XtraBars.BarButtonItem();
            btnNganhang = new DevExpress.XtraBars.BarButtonItem();
            mnuKhuvuc = new DevExpress.XtraBars.BarButtonItem();
            mnuDanhmuc = new DevExpress.XtraBars.BarButtonItem();
            mnuKhachhangTN = new DevExpress.XtraBars.BarButtonItem();
            mnuNhaCC = new DevExpress.XtraBars.BarButtonItem();
            mnuThanhpham = new DevExpress.XtraBars.BarButtonItem();
            mnuVattu = new DevExpress.XtraBars.BarButtonItem();
            mnuKhuon = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            mnuThanhphamBG = new DevExpress.XtraBars.BarButtonItem();
            mnuKhuonBG = new DevExpress.XtraBars.BarButtonItem();
            mnuDanhmucKT = new DevExpress.XtraBars.BarButtonItem();
            mnuTieuchiKT = new DevExpress.XtraBars.BarButtonItem();
            mnuBanggiaKH = new DevExpress.XtraBars.BarButtonItem();
            mnuBanggiaNCC = new DevExpress.XtraBars.BarButtonItem();
            mnuKhomay = new DevExpress.XtraBars.BarButtonItem();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(components);
            tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(components);
            ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)documentManager1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tabbedView1).BeginInit();
            SuspendLayout();
            // 
            // ribbon
            // 
            ribbon.ExpandCollapseItem.Id = 0;
            ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbon.ExpandCollapseItem, mnuThoat, stNum, stIns, stUser, stNgay, stCap, mnuDonvi, mnuDanhdiem, mnuDoituong, btnKhachhang, btnKho, btnNganhang, mnuKhuvuc, mnuDanhmuc, mnuKhachhangTN, mnuNhaCC, mnuThanhpham, mnuVattu, mnuKhuon, barButtonItem2, mnuThanhphamBG, mnuKhuonBG, mnuDanhmucKT, mnuTieuchiKT, mnuBanggiaKH, mnuBanggiaNCC, mnuKhomay });
            ribbon.Location = new Point(0, 0);
            ribbon.MaxItemId = 28;
            ribbon.Name = "ribbon";
            ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1, ribbonPage2 });
            ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2019;
            ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            ribbon.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            ribbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            ribbon.ShowToolbarCustomizeItem = false;
            ribbon.Size = new Size(1089, 143);
            ribbon.StatusBar = ribbonStatusBar;
            ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // mnuThoat
            // 
            mnuThoat.Caption = "Thoát";
            mnuThoat.Id = 1;
            mnuThoat.ImageOptions.Image = (Image)resources.GetObject("mnuThoat.ImageOptions.Image");
            mnuThoat.ImageOptions.LargeImage = (Image)resources.GetObject("mnuThoat.ImageOptions.LargeImage");
            mnuThoat.Name = "mnuThoat";
            mnuThoat.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            mnuThoat.ItemClick += mnuThoat_ItemClick;
            // 
            // stNum
            // 
            stNum.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            stNum.Caption = "NUM";
            stNum.Id = 2;
            stNum.Name = "stNum";
            // 
            // stIns
            // 
            stIns.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            stIns.Caption = "INS";
            stIns.Id = 3;
            stIns.Name = "stIns";
            // 
            // stUser
            // 
            stUser.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            stUser.Caption = "stUser";
            stUser.Id = 4;
            stUser.Name = "stUser";
            // 
            // stNgay
            // 
            stNgay.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            stNgay.Caption = "barStaticItem4";
            stNgay.Id = 5;
            stNgay.Name = "stNgay";
            // 
            // stCap
            // 
            stCap.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            stCap.Caption = "CAP";
            stCap.Id = 6;
            stCap.Name = "stCap";
            // 
            // mnuDonvi
            // 
            mnuDonvi.Caption = "Đơn vị";
            mnuDonvi.Id = 7;
            mnuDonvi.ImageOptions.Image = (Image)resources.GetObject("mnuDonvi.ImageOptions.Image");
            mnuDonvi.ImageOptions.LargeImage = (Image)resources.GetObject("mnuDonvi.ImageOptions.LargeImage");
            mnuDonvi.Name = "mnuDonvi";
            mnuDonvi.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            mnuDonvi.ItemClick += mnuDonvi_ItemClick;
            // 
            // mnuDanhdiem
            // 
            mnuDanhdiem.Caption = "Danh điểm";
            mnuDanhdiem.Id = 8;
            mnuDanhdiem.ImageOptions.Image = (Image)resources.GetObject("mnuDanhdiem.ImageOptions.Image");
            mnuDanhdiem.ImageOptions.LargeImage = (Image)resources.GetObject("mnuDanhdiem.ImageOptions.LargeImage");
            mnuDanhdiem.Name = "mnuDanhdiem";
            mnuDanhdiem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            mnuDanhdiem.ItemClick += mnuDanhdiem_ItemClick;
            // 
            // mnuDoituong
            // 
            mnuDoituong.Caption = "Đối tượng";
            mnuDoituong.Id = 9;
            mnuDoituong.ImageOptions.Image = (Image)resources.GetObject("mnuDoituong.ImageOptions.Image");
            mnuDoituong.ImageOptions.LargeImage = (Image)resources.GetObject("mnuDoituong.ImageOptions.LargeImage");
            mnuDoituong.Name = "mnuDoituong";
            mnuDoituong.ItemClick += mnuDoituong_ItemClick;
            // 
            // btnKhachhang
            // 
            btnKhachhang.Caption = "Khách hàng";
            btnKhachhang.Id = 10;
            btnKhachhang.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnKhachhang.ImageOptions.SvgImage");
            btnKhachhang.Name = "btnKhachhang";
            btnKhachhang.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            btnKhachhang.ItemClick += btnKhachhang_ItemClick;
            // 
            // btnKho
            // 
            btnKho.Caption = "Kho hàng";
            btnKho.Id = 11;
            btnKho.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnKho.ImageOptions.SvgImage");
            btnKho.Name = "btnKho";
            btnKho.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            btnKho.ItemClick += btnKho_ItemClick;
            // 
            // btnNganhang
            // 
            btnNganhang.Caption = "Ngân hàng";
            btnNganhang.Id = 12;
            btnNganhang.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnNganhang.ImageOptions.SvgImage");
            btnNganhang.Name = "btnNganhang";
            btnNganhang.ItemClick += btnNganhang_ItemClick;
            // 
            // mnuKhuvuc
            // 
            mnuKhuvuc.Caption = "Khu vực";
            mnuKhuvuc.Id = 13;
            mnuKhuvuc.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("mnuKhuvuc.ImageOptions.SvgImage");
            mnuKhuvuc.Name = "mnuKhuvuc";
            mnuKhuvuc.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            mnuKhuvuc.ItemClick += mnuKhuvuc_ItemClick;
            // 
            // mnuDanhmuc
            // 
            mnuDanhmuc.Caption = "Danh mục chung";
            mnuDanhmuc.Id = 14;
            mnuDanhmuc.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("mnuDanhmuc.ImageOptions.SvgImage");
            mnuDanhmuc.Name = "mnuDanhmuc";
            mnuDanhmuc.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            mnuDanhmuc.ItemClick += mnuDanhmuc_ItemClick;
            // 
            // mnuKhachhangTN
            // 
            mnuKhachhangTN.Caption = "Khách hàng tiềm năng";
            mnuKhachhangTN.Id = 15;
            mnuKhachhangTN.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("mnuKhachhangTN.ImageOptions.SvgImage");
            mnuKhachhangTN.Name = "mnuKhachhangTN";
            mnuKhachhangTN.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            mnuKhachhangTN.ItemClick += mnuKhachhangTN_ItemClick;
            // 
            // mnuNhaCC
            // 
            mnuNhaCC.Caption = "Nhà cung cấp";
            mnuNhaCC.Id = 16;
            mnuNhaCC.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("mnuNhaCC.ImageOptions.SvgImage");
            mnuNhaCC.Name = "mnuNhaCC";
            mnuNhaCC.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            mnuNhaCC.ItemClick += mnuNhaCC_ItemClick;
            // 
            // mnuThanhpham
            // 
            mnuThanhpham.Caption = "Thành phẩm";
            mnuThanhpham.Id = 17;
            mnuThanhpham.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("mnuThanhpham.ImageOptions.SvgImage");
            mnuThanhpham.Name = "mnuThanhpham";
            mnuThanhpham.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            mnuThanhpham.ItemClick += mnuThanhpham_ItemClick;
            // 
            // mnuVattu
            // 
            mnuVattu.Caption = "Vật tư";
            mnuVattu.Id = 18;
            mnuVattu.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("mnuVattu.ImageOptions.SvgImage");
            mnuVattu.Name = "mnuVattu";
            mnuVattu.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            mnuVattu.ItemClick += mnuVattu_ItemClick;
            // 
            // mnuKhuon
            // 
            mnuKhuon.Caption = "Khuôn";
            mnuKhuon.Id = 19;
            mnuKhuon.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("mnuKhuon.ImageOptions.SvgImage");
            mnuKhuon.Name = "mnuKhuon";
            mnuKhuon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            mnuKhuon.ItemClick += mnuKhuon_ItemClick;
            // 
            // barButtonItem2
            // 
            barButtonItem2.Caption = "Xe máy";
            barButtonItem2.Id = 20;
            barButtonItem2.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem2.ImageOptions.SvgImage");
            barButtonItem2.Name = "barButtonItem2";
            barButtonItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // mnuThanhphamBG
            // 
            mnuThanhphamBG.Caption = "Thành phẩm báo giá";
            mnuThanhphamBG.Id = 21;
            mnuThanhphamBG.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("mnuThanhphamBG.ImageOptions.SvgImage");
            mnuThanhphamBG.Name = "mnuThanhphamBG";
            mnuThanhphamBG.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            mnuThanhphamBG.ItemClick += mnuThanhphamBG_ItemClick;
            // 
            // mnuKhuonBG
            // 
            mnuKhuonBG.Caption = "Khuôn báo giá";
            mnuKhuonBG.Id = 22;
            mnuKhuonBG.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("mnuKhuonBG.ImageOptions.SvgImage");
            mnuKhuonBG.Name = "mnuKhuonBG";
            mnuKhuonBG.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            mnuKhuonBG.ItemClick += mnuKhuonBG_ItemClick;
            // 
            // mnuDanhmucKT
            // 
            mnuDanhmucKT.Caption = "Danh mục kiểm tra";
            mnuDanhmucKT.Id = 23;
            mnuDanhmucKT.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("mnuDanhmucKT.ImageOptions.SvgImage");
            mnuDanhmucKT.Name = "mnuDanhmucKT";
            mnuDanhmucKT.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            mnuDanhmucKT.ItemClick += mnuDanhmucKT_ItemClick;
            // 
            // mnuTieuchiKT
            // 
            mnuTieuchiKT.Caption = "Tiêu chí kiểm tra";
            mnuTieuchiKT.Id = 24;
            mnuTieuchiKT.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("mnuTieuchiKT.ImageOptions.SvgImage");
            mnuTieuchiKT.Name = "mnuTieuchiKT";
            mnuTieuchiKT.ItemClick += mnuTieuchiKT_ItemClick;
            // 
            // mnuBanggiaKH
            // 
            mnuBanggiaKH.Caption = "Bảng giá khách hàng";
            mnuBanggiaKH.Id = 25;
            mnuBanggiaKH.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("mnuBanggiaKH.ImageOptions.SvgImage");
            mnuBanggiaKH.Name = "mnuBanggiaKH";
            mnuBanggiaKH.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            mnuBanggiaKH.ItemClick += mnuBanggiaKH_ItemClick;
            // 
            // mnuBanggiaNCC
            // 
            mnuBanggiaNCC.Caption = "Bảng giá nhà cung cấp";
            mnuBanggiaNCC.Id = 26;
            mnuBanggiaNCC.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("mnuBanggiaNCC.ImageOptions.SvgImage");
            mnuBanggiaNCC.Name = "mnuBanggiaNCC";
            mnuBanggiaNCC.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            mnuBanggiaNCC.ItemClick += mnuBanggiaNCC_ItemClick;
            // 
            // mnuKhomay
            // 
            mnuKhomay.Caption = "Khổ máy";
            mnuKhomay.Id = 27;
            mnuKhomay.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("mnuKhomay.ImageOptions.SvgImage");
            mnuKhomay.Name = "mnuKhomay";
            mnuKhomay.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            mnuKhomay.ItemClick += mnuKhomay_ItemClick;
            // 
            // ribbonPage1
            // 
            ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup1 });
            ribbonPage1.Name = "ribbonPage1";
            ribbonPage1.Text = "Hệ thống";
            // 
            // ribbonPageGroup1
            // 
            ribbonPageGroup1.ItemLinks.Add(mnuThoat);
            ribbonPageGroup1.ItemLinks.Add(mnuDonvi, true);
            ribbonPageGroup1.ItemLinks.Add(mnuDanhdiem, true);
            ribbonPageGroup1.ItemLinks.Add(mnuDoituong, true);
            ribbonPageGroup1.ItemLinks.Add(btnKho, true);
            ribbonPageGroup1.ItemLinks.Add(btnNganhang, true);
            ribbonPageGroup1.ItemLinks.Add(mnuKhuvuc, true);
            ribbonPageGroup1.ItemLinks.Add(mnuDanhmuc, true);
            ribbonPageGroup1.ItemLinks.Add(mnuDanhmucKT, true);
            ribbonPageGroup1.ItemLinks.Add(mnuTieuchiKT, true);
            ribbonPageGroup1.ItemLinks.Add(mnuBanggiaKH, true);
            ribbonPageGroup1.ItemLinks.Add(mnuBanggiaNCC, true);
            ribbonPageGroup1.ItemLinks.Add(mnuKhomay, true);
            ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPage2
            // 
            ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup2, ribbonPageGroup3 });
            ribbonPage2.Name = "ribbonPage2";
            ribbonPage2.Text = "Danh mục";
            // 
            // ribbonPageGroup2
            // 
            ribbonPageGroup2.ItemLinks.Add(mnuKhachhangTN);
            ribbonPageGroup2.ItemLinks.Add(btnKhachhang, true);
            ribbonPageGroup2.ItemLinks.Add(mnuNhaCC, true);
            ribbonPageGroup2.ItemLinks.Add(mnuThanhpham, true);
            ribbonPageGroup2.ItemLinks.Add(mnuThanhphamBG, true);
            ribbonPageGroup2.ItemLinks.Add(mnuVattu, true);
            ribbonPageGroup2.Name = "ribbonPageGroup2";
            ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            ribbonPageGroup3.ItemLinks.Add(mnuKhuon);
            ribbonPageGroup3.ItemLinks.Add(mnuKhuonBG, true);
            ribbonPageGroup3.ItemLinks.Add(barButtonItem2, true);
            ribbonPageGroup3.Name = "ribbonPageGroup3";
            ribbonPageGroup3.Text = "Tài sản cố định";
            // 
            // ribbonStatusBar
            // 
            ribbonStatusBar.ItemLinks.Add(stCap);
            ribbonStatusBar.ItemLinks.Add(stNum, true);
            ribbonStatusBar.ItemLinks.Add(stIns, true);
            ribbonStatusBar.ItemLinks.Add(stUser, true);
            ribbonStatusBar.ItemLinks.Add(stNgay, true);
            ribbonStatusBar.Location = new Point(0, 687);
            ribbonStatusBar.Name = "ribbonStatusBar";
            ribbonStatusBar.Ribbon = ribbon;
            ribbonStatusBar.Size = new Size(1089, 35);
            // 
            // documentManager1
            // 
            documentManager1.MdiParent = this;
            documentManager1.MenuManager = ribbon;
            documentManager1.View = tabbedView1;
            documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] { tabbedView1 });
            // 
            // ribbonPage3
            // 
            ribbonPage3.Name = "ribbonPage3";
            ribbonPage3.Text = "ribbonPage3";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 722);
            Controls.Add(ribbonStatusBar);
            Controls.Add(ribbon);
            IsMdiContainer = true;
            KeyPreview = true;
            Name = "frmMain";
            Ribbon = ribbon;
            StatusBar = ribbonStatusBar;
            Text = "HỆ THỐNG QUẢN LÝ THÔNG TIN TÍN THÀNH";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)ribbon).EndInit();
            ((System.ComponentModel.ISupportInitialize)documentManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tabbedView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem mnuThoat;
        private DevExpress.XtraBars.BarStaticItem stNum;
        private DevExpress.XtraBars.BarStaticItem stIns;
        private DevExpress.XtraBars.BarStaticItem stUser;
        private DevExpress.XtraBars.BarStaticItem stNgay;
        private DevExpress.XtraBars.BarStaticItem stCap;
        private DevExpress.XtraBars.BarButtonItem mnuDonvi;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.BarButtonItem mnuDanhdiem;
        private DevExpress.XtraBars.BarButtonItem mnuDoituong;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
 
        private DevExpress.XtraBars.BarButtonItem btnKhachhang;
        private DevExpress.XtraBars.BarButtonItem btnKho;
        private DevExpress.XtraBars.BarButtonItem btnNganhang;
        private DevExpress.XtraBars.BarButtonItem mnuKhuvuc;
        private DevExpress.XtraBars.BarButtonItem mnuDanhmuc;
        private DevExpress.XtraBars.BarButtonItem mnuKhachhangTN;
        private DevExpress.XtraBars.BarButtonItem mnuNhaCC;
        private DevExpress.XtraBars.BarButtonItem mnuThanhpham;
        private DevExpress.XtraBars.BarButtonItem mnuVattu;
        private DevExpress.XtraBars.BarButtonItem mnuKhuon;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem mnuThanhphamBG;
        private DevExpress.XtraBars.BarButtonItem mnuKhuonBG;
        private DevExpress.XtraBars.BarButtonItem mnuDanhmucKT;
        private DevExpress.XtraBars.BarButtonItem mnuTieuchiKT;
        private DevExpress.XtraBars.BarButtonItem mnuBanggiaKH;
        private DevExpress.XtraBars.BarButtonItem mnuBanggiaNCC;
        private DevExpress.XtraBars.BarButtonItem mnuKhomay;
 
    }
}