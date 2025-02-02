
namespace Tinthanh.App.Danhmuc
{
    partial class frmChangePass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangePass));
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtConfirm = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtNewPass = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtOldPass = new DevExpress.XtraEditors.TextEdit();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfirm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOldPass.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanel1
            // 
            this.sidePanel1.BorderThickness = 2;
            this.sidePanel1.Controls.Add(this.btnCancel);
            this.sidePanel1.Controls.Add(this.btnOK);
            this.sidePanel1.Controls.Add(this.labelControl3);
            this.sidePanel1.Controls.Add(this.txtConfirm);
            this.sidePanel1.Controls.Add(this.labelControl2);
            this.sidePanel1.Controls.Add(this.txtNewPass);
            this.sidePanel1.Controls.Add(this.labelControl1);
            this.sidePanel1.Controls.Add(this.txtOldPass);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidePanel1.Location = new System.Drawing.Point(0, 0);
            this.sidePanel1.Margin = new System.Windows.Forms.Padding(5);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(385, 226);
            this.sidePanel1.TabIndex = 0;
            this.sidePanel1.Text = "sidePanel1";
            this.sidePanel1.Click += new System.EventHandler(this.sidePanel1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.Location = new System.Drawing.Point(202, 138);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.ImageOptions.Image")));
            this.btnOK.Location = new System.Drawing.Point(85, 138);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(72, 97);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(38, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Nhập lại";
            // 
            // txtConfirm
            // 
            this.txtConfirm.EnterMoveNextControl = true;
            this.txtConfirm.Location = new System.Drawing.Point(141, 94);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Properties.UseSystemPasswordChar = true;
            this.txtConfirm.Size = new System.Drawing.Size(149, 20);
            this.txtConfirm.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(72, 71);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(63, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Mật khẩu mới";
            // 
            // txtNewPass
            // 
            this.txtNewPass.EnterMoveNextControl = true;
            this.txtNewPass.Location = new System.Drawing.Point(141, 68);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Properties.UseSystemPasswordChar = true;
            this.txtNewPass.Size = new System.Drawing.Size(149, 20);
            this.txtNewPass.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(72, 45);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(58, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Mật khẩu củ";
            // 
            // txtOldPass
            // 
            this.txtOldPass.EnterMoveNextControl = true;
            this.txtOldPass.Location = new System.Drawing.Point(141, 42);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.Properties.UseSystemPasswordChar = true;
            this.txtOldPass.Size = new System.Drawing.Size(149, 20);
            this.txtOldPass.TabIndex = 0;
            // 
            // frmChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 226);
            this.Controls.Add(this.sidePanel1);
            this.Name = "frmChangePass";
            this.Text = "Đỗi Passworrd";
            this.Load += new System.EventHandler(this.frmChangePass_Load);
            this.sidePanel1.ResumeLayout(false);
            this.sidePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfirm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOldPass.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtOldPass;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtConfirm;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtNewPass;
    }
}