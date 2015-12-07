namespace SarvottamHospital.Controls
{
    partial class UserRoleListControl
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
            this.tsp1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbPermission = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbFieldPermission = new System.Windows.Forms.ToolStripButton();
            this.tslSearch = new System.Windows.Forms.ToolStripLabel();
            this.tstSearch = new System.Windows.Forms.ToolStripTextBox();
            this.tsbSearch = new System.Windows.Forms.ToolStripButton();
            this.tsp2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.clmRoleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tsp1,
            this.tsbPermission,
            this.toolStripSeparator1,
            this.tsbFieldPermission,
            this.tslSearch,
            this.tstSearch,
            this.tsbSearch,
            this.tsp2,
            this.tsbClose});
            this.tspToolbar.Location = new System.Drawing.Point(0, 0);
            this.tspToolbar.Name = "tspToolbar";
            this.tspToolbar.Padding = new System.Windows.Forms.Padding(6, 0, 1, 0);
            this.tspToolbar.Size = new System.Drawing.Size(684, 25);
            this.tspToolbar.TabIndex = 9;
            this.tspToolbar.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            this.tsbAdd.Image = global::SarvottamHospital.Properties.Resources.Add;
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(49, 22);
            this.tsbAdd.Text = "&Add";
            this.tsbAdd.Visible = false;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            this.toolStripSeparator2.Visible = false;
            // 
            // tsbOpen
            // 
            this.tsbOpen.Image = global::SarvottamHospital.Properties.Resources.Open;
            this.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpen.Name = "tsbOpen";
            this.tsbOpen.Size = new System.Drawing.Size(56, 22);
            this.tsbOpen.Text = "&Open";
            this.tsbOpen.Visible = false;
            // 
            // tsp1
            // 
            this.tsp1.Name = "tsp1";
            this.tsp1.Size = new System.Drawing.Size(6, 25);
            this.tsp1.Visible = false;
            // 
            // tsbPermission
            // 
            this.tsbPermission.Image = global::SarvottamHospital.Properties.Resources.Key;
            this.tsbPermission.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPermission.Name = "tsbPermission";
            this.tsbPermission.Size = new System.Drawing.Size(85, 22);
            this.tsbPermission.Text = "P&ermission";
            this.tsbPermission.ToolTipText = "Permission";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbFieldPermission
            // 
            this.tsbFieldPermission.Image = global::SarvottamHospital.Properties.Resources.Key;
            this.tsbFieldPermission.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFieldPermission.Name = "tsbFieldPermission";
            this.tsbFieldPermission.Size = new System.Drawing.Size(110, 22);
            this.tsbFieldPermission.Text = "FieldP&ermission";
            this.tsbFieldPermission.Visible = false;
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
            this.clmRoleName,
            this.clmDesc,
            this.clmFill});
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(0, 25);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(684, 316);
            this.dgvData.StandardTab = true;
            this.dgvData.TabIndex = 10;
            // 
            // clmRoleName
            // 
            this.clmRoleName.HeaderText = "Role Name";
            this.clmRoleName.Name = "clmRoleName";
            this.clmRoleName.ReadOnly = true;
            this.clmRoleName.Width = 200;
            // 
            // clmDesc
            // 
            this.clmDesc.HeaderText = "Description";
            this.clmDesc.Name = "clmDesc";
            this.clmDesc.ReadOnly = true;
            this.clmDesc.Width = 200;
            // 
            // clmFill
            // 
            this.clmFill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmFill.HeaderText = "";
            this.clmFill.Name = "clmFill";
            this.clmFill.ReadOnly = true;
            // 
            // UserRoleListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.tspToolbar);
            this.Name = "UserRoleListControl";
            this.Size = new System.Drawing.Size(684, 341);
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
        private System.Windows.Forms.ToolStripSeparator tsp1;
        private System.Windows.Forms.ToolStripButton tsbPermission;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tslSearch;
        private System.Windows.Forms.ToolStripTextBox tstSearch;
        private System.Windows.Forms.ToolStripButton tsbSearch;
        private System.Windows.Forms.ToolStripSeparator tsp2;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRoleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFill;
        private System.Windows.Forms.ToolStripButton tsbFieldPermission;

    }
}
