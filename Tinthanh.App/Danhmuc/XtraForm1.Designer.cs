namespace Tinthanh.App.Danhmuc
{
    partial class XtraForm1
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
            gridControl3 = new DevExpress.XtraGrid.GridControl();
            gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)gridControl3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView3).BeginInit();
            SuspendLayout();
            // 
            // gridControl3
            // 
            gridControl3.Dock = DockStyle.Fill;
            gridControl3.Location = new Point(0, 0);
            gridControl3.MainView = gridView3;
            gridControl3.Name = "gridControl3";
            gridControl3.Size = new Size(750, 505);
            gridControl3.TabIndex = 2;
            gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView3 });
            // 
            // gridView3
            // 
            gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn3, gridColumn4, gridColumn5, gridColumn6, gridColumn7, gridColumn8, gridColumn9, gridColumn10, gridColumn11 });
            gridView3.GridControl = gridControl3;
            gridView3.Name = "gridView3";
            gridView3.OptionsBehavior.Editable = false;
            gridView3.OptionsView.ColumnAutoWidth = false;
            gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn3
            // 
            gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumn3.Caption = "Mã KH";
            gridColumn3.FieldName = "Makh";
            gridColumn3.Name = "gridColumn3";
            gridColumn3.Visible = true;
            gridColumn3.VisibleIndex = 0;
            gridColumn3.Width = 83;
            // 
            // gridColumn4
            // 
            gridColumn4.AppearanceHeader.Options.UseTextOptions = true;
            gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumn4.Caption = "Tên khách hàng";
            gridColumn4.FieldName = "Tenkh";
            gridColumn4.Name = "gridColumn4";
            gridColumn4.Visible = true;
            gridColumn4.VisibleIndex = 1;
            gridColumn4.Width = 192;
            // 
            // gridColumn5
            // 
            gridColumn5.AppearanceHeader.Options.UseTextOptions = true;
            gridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumn5.Caption = "Đơn vị";
            gridColumn5.FieldName = "Donvi";
            gridColumn5.Name = "gridColumn5";
            gridColumn5.Visible = true;
            gridColumn5.VisibleIndex = 2;
            gridColumn5.Width = 58;
            // 
            // gridColumn6
            // 
            gridColumn6.AppearanceHeader.Options.UseTextOptions = true;
            gridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumn6.Caption = "Giá bán";
            gridColumn6.DisplayFormat.FormatString = "n0";
            gridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gridColumn6.FieldName = "Giaban";
            gridColumn6.Name = "gridColumn6";
            gridColumn6.Visible = true;
            gridColumn6.VisibleIndex = 3;
            gridColumn6.Width = 58;
            // 
            // gridColumn7
            // 
            gridColumn7.AppearanceHeader.Options.UseTextOptions = true;
            gridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumn7.Caption = "Giá củ";
            gridColumn7.DisplayFormat.FormatString = "n0";
            gridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gridColumn7.FieldName = "Giacu";
            gridColumn7.Name = "gridColumn7";
            gridColumn7.Visible = true;
            gridColumn7.VisibleIndex = 4;
            gridColumn7.Width = 58;
            // 
            // gridColumn8
            // 
            gridColumn8.AppearanceHeader.Options.UseTextOptions = true;
            gridColumn8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumn8.Caption = "Giá bán NT";
            gridColumn8.DisplayFormat.FormatString = "n3";
            gridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gridColumn8.FieldName = "GiabanNT";
            gridColumn8.Name = "gridColumn8";
            gridColumn8.Visible = true;
            gridColumn8.VisibleIndex = 5;
            gridColumn8.Width = 58;
            // 
            // gridColumn9
            // 
            gridColumn9.AppearanceHeader.Options.UseTextOptions = true;
            gridColumn9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumn9.Caption = "Giá củ NT";
            gridColumn9.DisplayFormat.FormatString = "n3";
            gridColumn9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gridColumn9.FieldName = "GiacuNT";
            gridColumn9.Name = "gridColumn9";
            gridColumn9.Visible = true;
            gridColumn9.VisibleIndex = 6;
            gridColumn9.Width = 58;
            // 
            // gridColumn10
            // 
            gridColumn10.AppearanceHeader.Options.UseTextOptions = true;
            gridColumn10.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumn10.Caption = "Giá ảo";
            gridColumn10.DisplayFormat.FormatString = "n0";
            gridColumn10.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gridColumn10.FieldName = "Giaao";
            gridColumn10.Name = "gridColumn10";
            gridColumn10.Visible = true;
            gridColumn10.VisibleIndex = 7;
            gridColumn10.Width = 58;
            // 
            // gridColumn11
            // 
            gridColumn11.AppearanceHeader.Options.UseTextOptions = true;
            gridColumn11.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumn11.Caption = "Giá lẽ";
            gridColumn11.DisplayFormat.FormatString = "n0";
            gridColumn11.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gridColumn11.FieldName = "Giale";
            gridColumn11.Name = "gridColumn11";
            gridColumn11.Visible = true;
            gridColumn11.VisibleIndex = 8;
            gridColumn11.Width = 69;
            // 
            // XtraForm1
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 505);
            Controls.Add(gridControl3);
            Name = "XtraForm1";
            Text = "XtraForm1";
            ((System.ComponentModel.ISupportInitialize)gridControl3).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
    }
}