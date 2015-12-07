namespace SarvottamHospital
{
    partial class UserRoleForm
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
            this.tlpUserRole = new System.Windows.Forms.TableLayoutPanel();
            this.lblUserRoleLevel = new System.Windows.Forms.Label();
            this.lblUserRoleName = new System.Windows.Forms.Label();
            this.txtRoleName = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.cmbUserRoleLevel = new System.Windows.Forms.ComboBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.tlpUserRole.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpUserRole
            // 
            this.tlpUserRole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpUserRole.ColumnCount = 2;
            this.tlpUserRole.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tlpUserRole.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlpUserRole.Controls.Add(this.lblUserRoleLevel, 0, 1);
            this.tlpUserRole.Controls.Add(this.lblUserRoleName, 0, 0);
            this.tlpUserRole.Controls.Add(this.txtRoleName, 1, 0);
            this.tlpUserRole.Controls.Add(this.txtDesc, 1, 2);
            this.tlpUserRole.Controls.Add(this.cmbUserRoleLevel, 1, 1);
            this.tlpUserRole.Controls.Add(this.lblDesc, 0, 2);
            this.tlpUserRole.Location = new System.Drawing.Point(27, 58);
            this.tlpUserRole.Name = "tlpUserRole";
            this.tlpUserRole.RowCount = 3;
            this.tlpUserRole.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpUserRole.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpUserRole.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpUserRole.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpUserRole.Size = new System.Drawing.Size(496, 183);
            this.tlpUserRole.TabIndex = 109;
            // 
            // lblUserRoleLevel
            // 
            this.lblUserRoleLevel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserRoleLevel.AutoSize = true;
            this.lblUserRoleLevel.Location = new System.Drawing.Point(3, 33);
            this.lblUserRoleLevel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblUserRoleLevel.Name = "lblUserRoleLevel";
            this.lblUserRoleLevel.Size = new System.Drawing.Size(109, 15);
            this.lblUserRoleLevel.TabIndex = 2;
            this.lblUserRoleLevel.Text = "User Role Level";
            this.lblUserRoleLevel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUserRoleName
            // 
            this.lblUserRoleName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserRoleName.AutoSize = true;
            this.lblUserRoleName.Location = new System.Drawing.Point(3, 6);
            this.lblUserRoleName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblUserRoleName.Name = "lblUserRoleName";
            this.lblUserRoleName.Size = new System.Drawing.Size(109, 15);
            this.lblUserRoleName.TabIndex = 0;
            this.lblUserRoleName.Text = "User Role Name";
            this.lblUserRoleName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRoleName
            // 
            this.txtRoleName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRoleName.Location = new System.Drawing.Point(118, 3);
            this.txtRoleName.MaxLength = 50;
            this.txtRoleName.Name = "txtRoleName";
            this.txtRoleName.Size = new System.Drawing.Size(375, 21);
            this.txtRoleName.TabIndex = 1;
            // 
            // txtDesc
            // 
            this.txtDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDesc.Location = new System.Drawing.Point(118, 59);
            this.txtDesc.MaxLength = 4000;
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDesc.Size = new System.Drawing.Size(375, 121);
            this.txtDesc.TabIndex = 5;
            // 
            // cmbUserRoleLevel
            // 
            this.cmbUserRoleLevel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbUserRoleLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserRoleLevel.FormattingEnabled = true;
            this.cmbUserRoleLevel.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.cmbUserRoleLevel.Location = new System.Drawing.Point(118, 30);
            this.cmbUserRoleLevel.Name = "cmbUserRoleLevel";
            this.cmbUserRoleLevel.Size = new System.Drawing.Size(375, 23);
            this.cmbUserRoleLevel.TabIndex = 3;
            // 
            // lblDesc
            // 
            this.lblDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(3, 62);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(109, 45);
            this.lblDesc.TabIndex = 4;
            this.lblDesc.Text = "Description\r\n(Press Ctl+Enter for New line)";
            this.lblDesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UserRoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 298);
            this.Controls.Add(this.tlpUserRole);
            this.Name = "UserRoleForm";
            this.Text = "UserRoleForm";
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.lineAction, 0);
            this.Controls.SetChildIndex(this.tlpUserRole, 0);
            this.tlpUserRole.ResumeLayout(false);
            this.tlpUserRole.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpUserRole;
        private System.Windows.Forms.Label lblUserRoleLevel;
        private System.Windows.Forms.Label lblUserRoleName;
        private System.Windows.Forms.TextBox txtRoleName;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.ComboBox cmbUserRoleLevel;
        private System.Windows.Forms.Label lblDesc;
    }
}