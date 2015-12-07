namespace SarvottamHospital.Controls
{
    partial class UserListControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tspToolbar = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbOpen = new System.Windows.Forms.ToolStripButton();
            this.tssResetPsw = new System.Windows.Forms.ToolStripSeparator();
            this.tsbResetPassword = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tslSearch = new System.Windows.Forms.ToolStripLabel();
            this.tstSearch = new System.Windows.Forms.ToolStripTextBox();
            this.tsbSearch = new System.Windows.Forms.ToolStripButton();
            this.tsp2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIsDisabled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmUserRoleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLoginName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPhoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMobileNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmpatientGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tspToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // tspToolbar
            // 
            this.tspToolbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tspToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.toolStripSeparator2,
            this.tsbOpen,
            this.tssResetPsw,
            this.tsbResetPassword,
            this.toolStripSeparator3,
            this.tslSearch,
            this.tstSearch,
            this.tsbSearch,
            this.tsp2,
            this.tsbClose});
            this.tspToolbar.Location = new System.Drawing.Point(0, 0);
            this.tspToolbar.Name = "tspToolbar";
            this.tspToolbar.Padding = new System.Windows.Forms.Padding(6, 0, 1, 0);
            this.tspToolbar.Size = new System.Drawing.Size(684, 25);
            this.tspToolbar.TabIndex = 8;
            this.tspToolbar.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            this.tsbAdd.Image = global::SarvottamHospital.Properties.Resources.Add;
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(49, 22);
            this.tsbAdd.Text = "&Add";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbOpen
            // 
            this.tsbOpen.Image = global::SarvottamHospital.Properties.Resources.Open;
            this.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpen.Name = "tsbOpen";
            this.tsbOpen.Size = new System.Drawing.Size(56, 22);
            this.tsbOpen.Text = "&Open";
            // 
            // tssResetPsw
            // 
            this.tssResetPsw.Name = "tssResetPsw";
            this.tssResetPsw.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbResetPassword
            // 
            this.tsbResetPassword.Image = global::SarvottamHospital.Properties.Resources.Password;
            this.tsbResetPassword.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbResetPassword.Name = "tsbResetPassword";
            this.tsbResetPassword.Size = new System.Drawing.Size(108, 22);
            this.tsbResetPassword.Text = "Reset Password";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tslSearch
            // 
            this.tslSearch.Name = "tslSearch";
            this.tslSearch.Size = new System.Drawing.Size(51, 22);
            this.tslSearch.Text = "&Search : ";
            // 
            // tstSearch
            // 
            this.tstSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tstSearch.Name = "tstSearch";
            this.tstSearch.Size = new System.Drawing.Size(100, 25);
            // 
            // tsbSearch
            // 
            this.tsbSearch.Image = global::SarvottamHospital.Properties.Resources.Find;
            this.tsbSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSearch.Name = "tsbSearch";
            this.tsbSearch.Size = new System.Drawing.Size(42, 22);
            this.tsbSearch.Text = "&Go";
            // 
            // tsp2
            // 
            this.tsp2.Name = "tsp2";
            this.tsp2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbClose
            // 
            this.tsbClose.Image = global::SarvottamHospital.Properties.Resources.Cancel;
            this.tsbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(56, 22);
            this.tsbClose.Text = "&Close";
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AllowUserToResizeRows = false;
            this.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvData.ColumnHeadersHeight = 24;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmID,
            this.clmIsDisabled,
            this.clmUserRoleName,
            this.clmLoginName,
            this.clmName,
            this.clmPhoneNo,
            this.clmMobileNo,
            this.Action,
            this.clmGuid,
            this.clmpatientGuid,
            this.clmFill});
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvData.Location = new System.Drawing.Point(0, 25);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(684, 291);
            this.dgvData.StandardTab = true;
            this.dgvData.TabIndex = 9;
            // 
            // clmID
            // 
            this.clmID.HeaderText = "ID";
            this.clmID.Name = "clmID";
            this.clmID.ReadOnly = true;
            this.clmID.Visible = false;
            // 
            // clmIsDisabled
            // 
            this.clmIsDisabled.HeaderText = "Disabled";
            this.clmIsDisabled.Name = "clmIsDisabled";
            this.clmIsDisabled.ReadOnly = true;
            this.clmIsDisabled.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmIsDisabled.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmIsDisabled.Visible = false;
            this.clmIsDisabled.Width = 70;
            // 
            // clmUserRoleName
            // 
            this.clmUserRoleName.HeaderText = "UserRole";
            this.clmUserRoleName.Name = "clmUserRoleName";
            this.clmUserRoleName.ReadOnly = true;
            // 
            // clmLoginName
            // 
            this.clmLoginName.HeaderText = "Login Name";
            this.clmLoginName.Name = "clmLoginName";
            this.clmLoginName.ReadOnly = true;
            this.clmLoginName.Width = 200;
            // 
            // clmName
            // 
            this.clmName.HeaderText = "Person Name";
            this.clmName.Name = "clmName";
            this.clmName.ReadOnly = true;
            this.clmName.Width = 200;
            // 
            // clmPhoneNo
            // 
            this.clmPhoneNo.HeaderText = "Phone No";
            this.clmPhoneNo.Name = "clmPhoneNo";
            this.clmPhoneNo.ReadOnly = true;
            // 
            // clmMobileNo
            // 
            this.clmMobileNo.HeaderText = "Mobile No";
            this.clmMobileNo.Name = "clmMobileNo";
            this.clmMobileNo.ReadOnly = true;
            // 
            // Action
            // 
            this.Action.HeaderText = "Doctor Bill";
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            this.Action.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Action.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Action.Visible = false;
            // 
            // clmGuid
            // 
            this.clmGuid.HeaderText = "Guid";
            this.clmGuid.Name = "clmGuid";
            this.clmGuid.ReadOnly = true;
            this.clmGuid.Visible = false;
            // 
            // clmpatientGuid
            // 
            this.clmpatientGuid.HeaderText = "PatientGuid";
            this.clmpatientGuid.Name = "clmpatientGuid";
            this.clmpatientGuid.ReadOnly = true;
            this.clmpatientGuid.Visible = false;
            // 
            // clmFill
            // 
            this.clmFill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmFill.HeaderText = "";
            this.clmFill.Name = "clmFill";
            this.clmFill.ReadOnly = true;
            // 
            // UserListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.tspToolbar);
            this.Name = "UserListControl";
            this.Size = new System.Drawing.Size(684, 316);
            this.tspToolbar.ResumeLayout(false);
            this.tspToolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tspToolbar;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbOpen;
        private System.Windows.Forms.ToolStripSeparator tssResetPsw;
        private System.Windows.Forms.ToolStripButton tsbResetPassword;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel tslSearch;
        private System.Windows.Forms.ToolStripTextBox tstSearch;
        private System.Windows.Forms.ToolStripButton tsbSearch;
        private System.Windows.Forms.ToolStripSeparator tsp2;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmIsDisabled;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUserRoleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLoginName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPhoneNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMobileNo;
        private System.Windows.Forms.DataGridViewImageColumn Action;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmpatientGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFill;
    }
}
