namespace SarvottamHospital
{
    partial class ChangePasswordForm
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
            this.tlpPriority = new System.Windows.Forms.TableLayoutPanel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.lblOldPassword = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.tlpPriority.SuspendLayout();
            this.SuspendLayout();
            // 
            // lineAction
            // 
            this.lineAction.Location = new System.Drawing.Point(0, 172);
            this.lineAction.Size = new System.Drawing.Size(434, 2);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(342, 182);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(256, 182);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 182);
            // 
            // tlpPriority
            // 
            this.tlpPriority.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpPriority.BackColor = System.Drawing.Color.Transparent;
            this.tlpPriority.ColumnCount = 4;
            this.tlpPriority.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tlpPriority.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPriority.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpPriority.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPriority.Controls.Add(this.lblUsername, 0, 0);
            this.tlpPriority.Controls.Add(this.lblConfirmPassword, 0, 3);
            this.tlpPriority.Controls.Add(this.txtOldPassword, 1, 1);
            this.tlpPriority.Controls.Add(this.lblOldPassword, 0, 1);
            this.tlpPriority.Controls.Add(this.lblNewPassword, 0, 2);
            this.tlpPriority.Controls.Add(this.txtNewPassword, 1, 2);
            this.tlpPriority.Controls.Add(this.txtConfirmPassword, 1, 3);
            this.tlpPriority.Controls.Add(this.txtUsername, 1, 0);
            this.tlpPriority.Location = new System.Drawing.Point(12, 49);
            this.tlpPriority.Name = "tlpPriority";
            this.tlpPriority.RowCount = 4;
            this.tlpPriority.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPriority.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPriority.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPriority.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPriority.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPriority.Size = new System.Drawing.Size(410, 120);
            this.tlpPriority.TabIndex = 109;
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(3, 6);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(134, 15);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "&Username";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Location = new System.Drawing.Point(3, 87);
            this.lblConfirmPassword.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(134, 15);
            this.lblConfirmPassword.TabIndex = 6;
            this.lblConfirmPassword.Text = "&Confirm Password";
            this.lblConfirmPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpPriority.SetColumnSpan(this.txtOldPassword, 3);
            this.txtOldPassword.Location = new System.Drawing.Point(143, 30);
            this.txtOldPassword.MaxLength = 50;
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.Size = new System.Drawing.Size(264, 21);
            this.txtOldPassword.TabIndex = 3;
            this.txtOldPassword.UseSystemPasswordChar = true;
            // 
            // lblOldPassword
            // 
            this.lblOldPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOldPassword.AutoSize = true;
            this.lblOldPassword.Location = new System.Drawing.Point(3, 33);
            this.lblOldPassword.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblOldPassword.Name = "lblOldPassword";
            this.lblOldPassword.Size = new System.Drawing.Size(134, 15);
            this.lblOldPassword.TabIndex = 2;
            this.lblOldPassword.Text = "&Old Password";
            this.lblOldPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Location = new System.Drawing.Point(3, 60);
            this.lblNewPassword.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(134, 15);
            this.lblNewPassword.TabIndex = 4;
            this.lblNewPassword.Text = "&New Password";
            this.lblNewPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpPriority.SetColumnSpan(this.txtNewPassword, 3);
            this.txtNewPassword.Location = new System.Drawing.Point(143, 57);
            this.txtNewPassword.MaxLength = 50;
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(264, 21);
            this.txtNewPassword.TabIndex = 5;
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpPriority.SetColumnSpan(this.txtConfirmPassword, 3);
            this.txtConfirmPassword.Location = new System.Drawing.Point(143, 84);
            this.txtConfirmPassword.MaxLength = 50;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(264, 21);
            this.txtConfirmPassword.TabIndex = 7;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.BackColor = System.Drawing.SystemColors.Window;
            this.tlpPriority.SetColumnSpan(this.txtUsername, 3);
            this.txtUsername.Location = new System.Drawing.Point(143, 3);
            this.txtUsername.MaxLength = 50;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.Size = new System.Drawing.Size(264, 21);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.TabStop = false;
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 212);
            this.Controls.Add(this.tlpPriority);
            this.Name = "ChangePasswordForm";
            this.Text = "ChangePasswordForm";
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.lineAction, 0);
            this.Controls.SetChildIndex(this.tlpPriority, 0);
            this.tlpPriority.ResumeLayout(false);
            this.tlpPriority.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPriority;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.Label lblOldPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtUsername;
    }
}