namespace SarvottamHospital
{
    partial class LoginForm
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
            this.tlpUser = new System.Windows.Forms.TableLayoutPanel();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.chkRememberMe = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tlpUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lineAction
            // 
            this.lineAction.Location = new System.Drawing.Point(0, 232);
            this.lineAction.Size = new System.Drawing.Size(463, 2);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(355, 243);
            this.btnCancel.Text = "Exit";
            // 
            // btnSave
            // 
            this.btnSave.Image = global::SarvottamHospital.Properties.Resources.Key;
            this.btnSave.Location = new System.Drawing.Point(255, 243);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(14, 243);
            // 
            // tlpUser
            // 
            this.tlpUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpUser.BackColor = System.Drawing.Color.Transparent;
            this.tlpUser.ColumnCount = 2;
            this.tlpUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tlpUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 272F));
            this.tlpUser.Controls.Add(this.txtUserName, 1, 1);
            this.tlpUser.Controls.Add(this.txtPassword, 1, 3);
            this.tlpUser.Controls.Add(this.lblUserName, 1, 0);
            this.tlpUser.Controls.Add(this.lblPassword, 1, 2);
            this.tlpUser.Controls.Add(this.lblError, 1, 5);
            this.tlpUser.Controls.Add(this.chkRememberMe, 1, 4);
            this.tlpUser.Controls.Add(this.pictureBox1, 0, 0);
            this.tlpUser.Location = new System.Drawing.Point(6, 62);
            this.tlpUser.Name = "tlpUser";
            this.tlpUser.RowCount = 6;
            this.tlpUser.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpUser.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpUser.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpUser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlpUser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpUser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpUser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpUser.Size = new System.Drawing.Size(442, 167);
            this.tlpUser.TabIndex = 109;
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserName.Location = new System.Drawing.Point(173, 32);
            this.txtUserName.MaxLength = 50;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(266, 21);
            this.txtUserName.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Location = new System.Drawing.Point(173, 89);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(266, 21);
            this.txtPassword.TabIndex = 3;
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserName.Location = new System.Drawing.Point(173, 3);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(3);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(266, 23);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "User Name";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPassword.Location = new System.Drawing.Point(173, 59);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(3);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(266, 24);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblError
            // 
            this.lblError.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(173, 142);
            this.lblError.Margin = new System.Windows.Forms.Padding(3);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(263, 17);
            this.lblError.TabIndex = 5;
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkRememberMe
            // 
            this.chkRememberMe.AutoSize = true;
            this.chkRememberMe.Location = new System.Drawing.Point(173, 118);
            this.chkRememberMe.Name = "chkRememberMe";
            this.chkRememberMe.Size = new System.Drawing.Size(108, 18);
            this.chkRememberMe.TabIndex = 4;
            this.chkRememberMe.Text = "Remember Me";
            this.chkRememberMe.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::SarvottamHospital.Properties.Resources.AppLogo;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.tlpUser.SetRowSpan(this.pictureBox1, 4);
            this.pictureBox1.Size = new System.Drawing.Size(164, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 278);
            this.Controls.Add(this.tlpUser);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Controls.SetChildIndex(this.tlpUser, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.lineAction, 0);
            this.tlpUser.ResumeLayout(false);
            this.tlpUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpUser;
        public System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.CheckBox chkRememberMe;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}