
namespace Tinthanh.App.Danhmuc
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            panel1 = new Panel();
            lblVersion = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            cmdCancel = new DevExpress.XtraEditors.SimpleButton();
            cmdOK = new DevExpress.XtraEditors.SimpleButton();
            txtPass = new DevExpress.XtraEditors.TextEdit();
            txtUser = new DevExpress.XtraEditors.TextEdit();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtPass.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtUser.Properties).BeginInit();
            SuspendLayout();
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(labelControl1);
            panelControl1.Dock = DockStyle.Top;
            panelControl1.Location = new Point(0, 0);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(432, 39);
            panelControl1.TabIndex = 0;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelControl1.Appearance.ForeColor = Color.Navy;
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Appearance.Options.UseForeColor = true;
            labelControl1.Location = new Point(40, 12);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(362, 19);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "HỆ THỐNG QUẢN LÝ THÔNG TIN TÍN THÀNH";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblVersion);
            panel1.Controls.Add(labelControl4);
            panel1.Controls.Add(cmdCancel);
            panel1.Controls.Add(cmdOK);
            panel1.Controls.Add(txtPass);
            panel1.Controls.Add(txtUser);
            panel1.Controls.Add(labelControl3);
            panel1.Controls.Add(labelControl2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(432, 205);
            panel1.TabIndex = 1;
            // 
            // lblVersion
            // 
            lblVersion.Appearance.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVersion.Appearance.Options.UseFont = true;
            lblVersion.Location = new Point(157, 143);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(70, 14);
            lblVersion.TabIndex = 15;
            lblVersion.Text = "labelControl5";
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Location = new Point(127, 163);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(131, 16);
            labelControl4.TabIndex = 14;
            labelControl4.Text = "@Copyright 2014-2024";
            // 
            // cmdCancel
            // 
            cmdCancel.DialogResult = DialogResult.Cancel;
            cmdCancel.ImageOptions.Image = (Image)resources.GetObject("cmdCancel.ImageOptions.Image");
            cmdCancel.Location = new Point(243, 92);
            cmdCancel.Name = "cmdCancel";
            cmdCancel.Size = new Size(75, 23);
            cmdCancel.TabIndex = 13;
            cmdCancel.Text = "Cancel";
            cmdCancel.Click += cmdCancel_Click;
            // 
            // cmdOK
            // 
            cmdOK.DialogResult = DialogResult.OK;
            cmdOK.ImageOptions.Image = (Image)resources.GetObject("cmdOK.ImageOptions.Image");
            cmdOK.Location = new Point(107, 92);
            cmdOK.Name = "cmdOK";
            cmdOK.Size = new Size(75, 23);
            cmdOK.TabIndex = 12;
            cmdOK.Text = "OK";
            cmdOK.Click += cmdOK_Click;
            // 
            // txtPass
            // 
            txtPass.EnterMoveNextControl = true;
            txtPass.Location = new Point(157, 51);
            txtPass.Name = "txtPass";
            txtPass.Properties.UseSystemPasswordChar = true;
            txtPass.Size = new Size(161, 20);
            txtPass.TabIndex = 11;
            // 
            // txtUser
            // 
            txtUser.EnterMoveNextControl = true;
            txtUser.Location = new Point(157, 25);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(161, 20);
            txtUser.TabIndex = 10;
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new Point(71, 52);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(52, 16);
            labelControl3.TabIndex = 9;
            labelControl3.Text = "Mật khẩu";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new Point(71, 25);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(65, 16);
            labelControl2.TabIndex = 8;
            labelControl2.Text = "Người dùng";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 244);
            Controls.Add(panel1);
            Controls.Add(panelControl1);
            FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            panelControl1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtPass.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtUser.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton cmdCancel;
        private DevExpress.XtraEditors.SimpleButton cmdOK;
        private DevExpress.XtraEditors.TextEdit txtPass;
        private DevExpress.XtraEditors.TextEdit txtUser;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lblVersion;
    }
}