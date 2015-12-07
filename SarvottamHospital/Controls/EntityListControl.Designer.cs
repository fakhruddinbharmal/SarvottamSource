namespace SarvottamHospital.Controls
{
    partial class EntityListControl
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
            this.tsbOpen = new System.Windows.Forms.ToolStripButton();
            this.tsp1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslSearch = new System.Windows.Forms.ToolStripLabel();
            this.tstSearch = new System.Windows.Forms.ToolStripTextBox();
            this.tsbSearch = new System.Windows.Forms.ToolStripButton();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.clmImgIcon = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCaption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmListType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmListCaption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tspToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // tspToolbar
            // 
            this.tspToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.tsbOpen,
            this.tsp1,
            this.tslSearch,
            this.tstSearch,
            this.tsbSearch,
            this.tsbClose});
            this.tspToolbar.Location = new System.Drawing.Point(0, 0);
            this.tspToolbar.Name = "tspToolbar";
            this.tspToolbar.Size = new System.Drawing.Size(910, 25);
            this.tspToolbar.TabIndex = 4;
            this.tspToolbar.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            this.tsbAdd.Image = global::SarvottamHospital.Properties.Resources.Add;
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(49, 22);
            this.tsbAdd.Text = "&Add";
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // tsbOpen
            // 
            this.tsbOpen.Image = global::SarvottamHospital.Properties.Resources.Open;
            this.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpen.Name = "tsbOpen";
            this.tsbOpen.Size = new System.Drawing.Size(56, 22);
            this.tsbOpen.Text = "&Open";
            this.tsbOpen.Click += new System.EventHandler(this.tsbOpen_Click);
            // 
            // tsp1
            // 
            this.tsp1.Name = "tsp1";
            this.tsp1.Size = new System.Drawing.Size(6, 25);
            // 
            // tslSearch
            // 
            this.tslSearch.Name = "tslSearch";
            this.tslSearch.Size = new System.Drawing.Size(48, 22);
            this.tslSearch.Text = "&Search :";
            // 
            // tstSearch
            // 
            this.tstSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tstSearch.Name = "tstSearch";
            this.tstSearch.Size = new System.Drawing.Size(116, 25);
            // 
            // tsbSearch
            // 
            this.tsbSearch.Image = global::SarvottamHospital.Properties.Resources.Find;
            this.tsbSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSearch.Name = "tsbSearch";
            this.tsbSearch.Size = new System.Drawing.Size(42, 22);
            this.tsbSearch.Text = "&Go";
            this.tsbSearch.Click += new System.EventHandler(this.tsbSearch_Click);
            // 
            // tsbClose
            // 
            this.tsbClose.Image = global::SarvottamHospital.Properties.Resources.Cancel;
            this.tsbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(56, 22);
            this.tsbClose.Text = "&Close";
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AllowUserToResizeRows = false;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmImgIcon,
            this.clmName,
            this.clmType,
            this.clmCaption,
            this.clmListType,
            this.clmListCaption,
            this.clmFill});
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(0, 25);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(910, 565);
            this.dgvData.StandardTab = true;
            this.dgvData.TabIndex = 5;
            // 
            // clmImgIcon
            // 
            this.clmImgIcon.FillWeight = 24F;
            this.clmImgIcon.HeaderText = "";
            this.clmImgIcon.Name = "clmImgIcon";
            this.clmImgIcon.ReadOnly = true;
            this.clmImgIcon.Width = 24;
            // 
            // clmName
            // 
            this.clmName.HeaderText = "Entity Name";
            this.clmName.Name = "clmName";
            this.clmName.ReadOnly = true;
            this.clmName.Width = 200;
            // 
            // clmType
            // 
            this.clmType.HeaderText = "Entity Type Name";
            this.clmType.Name = "clmType";
            this.clmType.ReadOnly = true;
            this.clmType.Width = 200;
            // 
            // clmCaption
            // 
            this.clmCaption.HeaderText = "Entity Caption";
            this.clmCaption.Name = "clmCaption";
            this.clmCaption.ReadOnly = true;
            this.clmCaption.Width = 200;
            // 
            // clmListType
            // 
            this.clmListType.HeaderText = "List Type Name";
            this.clmListType.Name = "clmListType";
            this.clmListType.ReadOnly = true;
            this.clmListType.Width = 200;
            // 
            // clmListCaption
            // 
            this.clmListCaption.HeaderText = "List Caption";
            this.clmListCaption.Name = "clmListCaption";
            this.clmListCaption.ReadOnly = true;
            this.clmListCaption.Width = 200;
            // 
            // clmFill
            // 
            this.clmFill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmFill.HeaderText = "";
            this.clmFill.Name = "clmFill";
            this.clmFill.ReadOnly = true;
            this.clmFill.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // EntityListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.tspToolbar);
            this.Name = "EntityListControl";
            this.Size = new System.Drawing.Size(910, 590);
            this.tspToolbar.ResumeLayout(false);
            this.tspToolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tspToolbar;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbOpen;
        private System.Windows.Forms.ToolStripSeparator tsp1;
        private System.Windows.Forms.ToolStripLabel tslSearch;
        private System.Windows.Forms.ToolStripTextBox tstSearch;
        private System.Windows.Forms.ToolStripButton tsbSearch;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.DataGridViewImageColumn clmImgIcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCaption;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmListType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmListCaption;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFill;
    }
}
