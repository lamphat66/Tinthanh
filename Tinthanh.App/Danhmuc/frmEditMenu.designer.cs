
namespace Tinthanh.App.Danhmuc
{
    partial class frmEditMenu
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
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            btnCancel = new DevExpress.XtraEditors.SimpleButton();
            btnSave = new DevExpress.XtraEditors.SimpleButton();
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            textEdit3 = new DevExpress.XtraEditors.TextEdit();
            bdSource = new BindingSource(components);
            checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            textEdit2 = new DevExpress.XtraEditors.TextEdit();
            textEdit4 = new DevExpress.XtraEditors.TextEdit();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bdSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)checkEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit4.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem2).BeginInit();
            SuspendLayout();
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(btnCancel);
            panelControl1.Controls.Add(btnSave);
            panelControl1.Dock = DockStyle.Bottom;
            panelControl1.Location = new Point(0, 195);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(411, 34);
            panelControl1.TabIndex = 0;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(236, 5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.OK;
            btnSave.Location = new Point(104, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(textEdit3);
            layoutControl1.Controls.Add(checkEdit1);
            layoutControl1.Controls.Add(textEdit2);
            layoutControl1.Controls.Add(textEdit4);
            layoutControl1.Dock = DockStyle.Fill;
            layoutControl1.Location = new Point(0, 0);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.Root = Root;
            layoutControl1.Size = new Size(411, 195);
            layoutControl1.TabIndex = 1;
            layoutControl1.Text = "layoutControl1";
            // 
            // textEdit3
            // 
            textEdit3.DataBindings.Add(new Binding("EditValue", bdSource, "Thuoc", true));
            textEdit3.EnterMoveNextControl = true;
            textEdit3.Location = new Point(98, 60);
            textEdit3.Name = "textEdit3";
            textEdit3.Size = new Size(105, 20);
            textEdit3.StyleController = layoutControl1;
            textEdit3.TabIndex = 7;
            // 
            // bdSource
            // 
            bdSource.DataSource = typeof(Tinthanh.Data.Entities.Chucnang);
            // 
            // checkEdit1
            // 
            checkEdit1.DataBindings.Add(new Binding("EditValue", bdSource, "IsCaption", true));
            checkEdit1.Location = new Point(207, 60);
            checkEdit1.Name = "checkEdit1";
            checkEdit1.Properties.Caption = "Là tiêu đề";
            checkEdit1.Properties.ContentAlignment = DevExpress.Utils.HorzAlignment.Far;
            checkEdit1.Size = new Size(192, 19);
            checkEdit1.StyleController = layoutControl1;
            checkEdit1.TabIndex = 6;
            // 
            // textEdit2
            // 
            textEdit2.DataBindings.Add(new Binding("EditValue", bdSource, "Ten", true));
            textEdit2.EnterMoveNextControl = true;
            textEdit2.Location = new Point(98, 36);
            textEdit2.Name = "textEdit2";
            textEdit2.Size = new Size(301, 20);
            textEdit2.StyleController = layoutControl1;
            textEdit2.TabIndex = 5;
            // 
            // textEdit4
            // 
            textEdit4.DataBindings.Add(new Binding("EditValue", bdSource, "Ma", true));
            textEdit4.Location = new Point(98, 12);
            textEdit4.Name = "textEdit4";
            textEdit4.Size = new Size(105, 20);
            textEdit4.StyleController = layoutControl1;
            textEdit4.TabIndex = 8;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { emptySpaceItem1, layoutControlItem2, layoutControlItem3, layoutControlItem4, layoutControlItem5, emptySpaceItem2 });
            Root.Name = "Root";
            Root.Size = new Size(411, 195);
            Root.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.AllowHotTrack = false;
            emptySpaceItem1.Location = new Point(0, 72);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new Size(391, 103);
            emptySpaceItem1.TextSize = new Size(0, 0);
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = textEdit2;
            layoutControlItem2.Location = new Point(0, 24);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new Size(391, 24);
            layoutControlItem2.Text = "Tên chức năng";
            layoutControlItem2.TextSize = new Size(82, 13);
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = checkEdit1;
            layoutControlItem3.Location = new Point(195, 48);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new Size(196, 24);
            layoutControlItem3.TextSize = new Size(0, 0);
            layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.Control = textEdit3;
            layoutControlItem4.Location = new Point(0, 48);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.Size = new Size(195, 24);
            layoutControlItem4.Text = "Thuộc chức năng";
            layoutControlItem4.TextSize = new Size(82, 13);
            // 
            // layoutControlItem5
            // 
            layoutControlItem5.Control = textEdit4;
            layoutControlItem5.Location = new Point(0, 0);
            layoutControlItem5.Name = "layoutControlItem5";
            layoutControlItem5.Size = new Size(195, 24);
            layoutControlItem5.Text = "Mã";
            layoutControlItem5.TextSize = new Size(82, 13);
            // 
            // emptySpaceItem2
            // 
            emptySpaceItem2.AllowHotTrack = false;
            emptySpaceItem2.Location = new Point(195, 0);
            emptySpaceItem2.Name = "emptySpaceItem2";
            emptySpaceItem2.Size = new Size(196, 24);
            emptySpaceItem2.TextSize = new Size(0, 0);
            // 
            // frmEditMenu
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 229);
            Controls.Add(layoutControl1);
            Controls.Add(panelControl1);
            Name = "frmEditMenu";
            Text = "Chức năng hệ thống";
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)bdSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)checkEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit4.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private System.Windows.Forms.BindingSource bdSource;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    }
}