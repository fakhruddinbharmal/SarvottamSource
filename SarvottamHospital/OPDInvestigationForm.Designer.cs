namespace SarvottamHospital
{
    partial class OPDInvestigationForm
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblMainInvestigation = new System.Windows.Forms.Label();
            this.lblLabInvestigation = new System.Windows.Forms.Label();
            this.lblRadiologyInvestigation = new System.Windows.Forms.Label();
            this.txtRadiologyInvestigation = new System.Windows.Forms.TextBox();
            this.lblSpecialInvestigation = new System.Windows.Forms.Label();
            this.txtSpecialInvestigation = new System.Windows.Forms.TextBox();
            this.lblInvestigationDate = new System.Windows.Forms.Label();
            this.dptInvestigationDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddNewMainInvestigation = new System.Windows.Forms.Button();
            this.btnAddNewLabInvestigation = new System.Windows.Forms.Button();
            this.cmbMainInvestigation = new System.Windows.Forms.CheckedListBox();
            this.cmbLabInvestigation = new System.Windows.Forms.CheckedListBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbOpen = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.dgvInvestionData = new System.Windows.Forms.DataGridView();
            this.clmMainInvestigation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLabInvestigation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRadiology = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSpecial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmInvestigationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvestionData)).BeginInit();
            this.SuspendLayout();
            // 
            // lineAction
            // 
            this.lineAction.Location = new System.Drawing.Point(0, 575);
            this.lineAction.Size = new System.Drawing.Size(1297, 2);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1205, 585);
            this.btnCancel.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1119, 585);
            this.btnSave.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 585);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.72985F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.27015F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 205F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 413F));
            this.tableLayoutPanel2.Controls.Add(this.lblMainInvestigation, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblLabInvestigation, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblRadiologyInvestigation, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtRadiologyInvestigation, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblSpecialInvestigation, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtSpecialInvestigation, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblInvestigationDate, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.dptInvestigationDate, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.btnAddNewMainInvestigation, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAddNewLabInvestigation, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.cmbMainInvestigation, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cmbLabInvestigation, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(51, 54);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1087, 261);
            this.tableLayoutPanel2.TabIndex = 109;
            // 
            // lblMainInvestigation
            // 
            this.lblMainInvestigation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMainInvestigation.AutoSize = true;
            this.lblMainInvestigation.Location = new System.Drawing.Point(3, 6);
            this.lblMainInvestigation.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblMainInvestigation.Name = "lblMainInvestigation";
            this.lblMainInvestigation.Size = new System.Drawing.Size(146, 15);
            this.lblMainInvestigation.TabIndex = 0;
            this.lblMainInvestigation.Text = "Main Investigation";
            this.lblMainInvestigation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLabInvestigation
            // 
            this.lblLabInvestigation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLabInvestigation.AutoSize = true;
            this.lblLabInvestigation.Location = new System.Drawing.Point(3, 83);
            this.lblLabInvestigation.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblLabInvestigation.Name = "lblLabInvestigation";
            this.lblLabInvestigation.Size = new System.Drawing.Size(146, 15);
            this.lblLabInvestigation.TabIndex = 13;
            this.lblLabInvestigation.Text = "Lab Investigation";
            this.lblLabInvestigation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRadiologyInvestigation
            // 
            this.lblRadiologyInvestigation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRadiologyInvestigation.AutoSize = true;
            this.lblRadiologyInvestigation.Location = new System.Drawing.Point(3, 167);
            this.lblRadiologyInvestigation.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblRadiologyInvestigation.Name = "lblRadiologyInvestigation";
            this.lblRadiologyInvestigation.Size = new System.Drawing.Size(146, 15);
            this.lblRadiologyInvestigation.TabIndex = 17;
            this.lblRadiologyInvestigation.Text = "Radiology Investigation";
            this.lblRadiologyInvestigation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRadiologyInvestigation
            // 
            this.txtRadiologyInvestigation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRadiologyInvestigation.Location = new System.Drawing.Point(155, 167);
            this.txtRadiologyInvestigation.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtRadiologyInvestigation.MaxLength = 25;
            this.txtRadiologyInvestigation.Name = "txtRadiologyInvestigation";
            this.txtRadiologyInvestigation.Size = new System.Drawing.Size(267, 21);
            this.txtRadiologyInvestigation.TabIndex = 2;
            // 
            // lblSpecialInvestigation
            // 
            this.lblSpecialInvestigation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSpecialInvestigation.AutoSize = true;
            this.lblSpecialInvestigation.Location = new System.Drawing.Point(3, 198);
            this.lblSpecialInvestigation.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSpecialInvestigation.Name = "lblSpecialInvestigation";
            this.lblSpecialInvestigation.Size = new System.Drawing.Size(146, 15);
            this.lblSpecialInvestigation.TabIndex = 32;
            this.lblSpecialInvestigation.Text = "Special Investigation";
            this.lblSpecialInvestigation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSpecialInvestigation
            // 
            this.txtSpecialInvestigation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSpecialInvestigation.Location = new System.Drawing.Point(155, 198);
            this.txtSpecialInvestigation.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtSpecialInvestigation.MaxLength = 25;
            this.txtSpecialInvestigation.Name = "txtSpecialInvestigation";
            this.txtSpecialInvestigation.Size = new System.Drawing.Size(267, 21);
            this.txtSpecialInvestigation.TabIndex = 3;
            // 
            // lblInvestigationDate
            // 
            this.lblInvestigationDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInvestigationDate.AutoSize = true;
            this.lblInvestigationDate.Location = new System.Drawing.Point(3, 235);
            this.lblInvestigationDate.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblInvestigationDate.Name = "lblInvestigationDate";
            this.lblInvestigationDate.Size = new System.Drawing.Size(146, 15);
            this.lblInvestigationDate.TabIndex = 34;
            this.lblInvestigationDate.Text = "Date";
            this.lblInvestigationDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dptInvestigationDate
            // 
            this.dptInvestigationDate.CustomFormat = "dd/MM/yyyy";
            this.dptInvestigationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dptInvestigationDate.Location = new System.Drawing.Point(155, 235);
            this.dptInvestigationDate.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.dptInvestigationDate.Name = "dptInvestigationDate";
            this.dptInvestigationDate.Size = new System.Drawing.Size(125, 21);
            this.dptInvestigationDate.TabIndex = 4;
            // 
            // btnAddNewMainInvestigation
            // 
            this.btnAddNewMainInvestigation.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddNewMainInvestigation.Image = global::SarvottamHospital.Properties.Resources.Add;
            this.btnAddNewMainInvestigation.Location = new System.Drawing.Point(428, 3);
            this.btnAddNewMainInvestigation.Name = "btnAddNewMainInvestigation";
            this.btnAddNewMainInvestigation.Size = new System.Drawing.Size(95, 26);
            this.btnAddNewMainInvestigation.TabIndex = 5;
            this.btnAddNewMainInvestigation.Text = "&Add ";
            this.btnAddNewMainInvestigation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddNewMainInvestigation.UseVisualStyleBackColor = true;
            // 
            // btnAddNewLabInvestigation
            // 
            this.btnAddNewLabInvestigation.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddNewLabInvestigation.Image = global::SarvottamHospital.Properties.Resources.Add;
            this.btnAddNewLabInvestigation.Location = new System.Drawing.Point(428, 80);
            this.btnAddNewLabInvestigation.Name = "btnAddNewLabInvestigation";
            this.btnAddNewLabInvestigation.Size = new System.Drawing.Size(95, 26);
            this.btnAddNewLabInvestigation.TabIndex = 6;
            this.btnAddNewLabInvestigation.Text = "&Add ";
            this.btnAddNewLabInvestigation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddNewLabInvestigation.UseVisualStyleBackColor = true;
            // 
            // cmbMainInvestigation
            // 
            this.cmbMainInvestigation.CheckOnClick = true;
            this.cmbMainInvestigation.FormattingEnabled = true;
            this.cmbMainInvestigation.Location = new System.Drawing.Point(155, 3);
            this.cmbMainInvestigation.Name = "cmbMainInvestigation";
            this.cmbMainInvestigation.Size = new System.Drawing.Size(267, 68);
            this.cmbMainInvestigation.Sorted = true;
            this.cmbMainInvestigation.TabIndex = 0;
            // 
            // cmbLabInvestigation
            // 
            this.cmbLabInvestigation.FormattingEnabled = true;
            this.cmbLabInvestigation.Location = new System.Drawing.Point(155, 80);
            this.cmbLabInvestigation.Name = "cmbLabInvestigation";
            this.cmbLabInvestigation.Size = new System.Drawing.Size(267, 68);
            this.cmbLabInvestigation.Sorted = true;
            this.cmbLabInvestigation.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.toolStrip1, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(51, 314);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1234, 29);
            this.tableLayoutPanel3.TabIndex = 45;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOpen,
            this.tsbDelete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 4);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1234, 25);
            this.toolStrip1.TabIndex = 45;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbOpen
            // 
            this.tsbOpen.Image = global::SarvottamHospital.Properties.Resources.Open;
            this.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpen.Name = "tsbOpen";
            this.tsbOpen.Size = new System.Drawing.Size(56, 22);
            this.tsbOpen.Text = "&Open";
            // 
            // tsbDelete
            // 
            this.tsbDelete.Image = global::SarvottamHospital.Properties.Resources.Delete;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(60, 22);
            this.tsbDelete.Text = "&Delete";
            this.tsbDelete.Visible = false;
            // 
            // dgvInvestionData
            // 
            this.dgvInvestionData.AllowUserToAddRows = false;
            this.dgvInvestionData.AllowUserToDeleteRows = false;
            this.dgvInvestionData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvestionData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMainInvestigation,
            this.clmLabInvestigation,
            this.clmRadiology,
            this.clmSpecial,
            this.clmInvestigationDate});
            this.dgvInvestionData.Location = new System.Drawing.Point(51, 348);
            this.dgvInvestionData.Name = "dgvInvestionData";
            this.dgvInvestionData.ReadOnly = true;
            this.dgvInvestionData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvestionData.Size = new System.Drawing.Size(1234, 214);
            this.dgvInvestionData.TabIndex = 0;
            // 
            // clmMainInvestigation
            // 
            this.clmMainInvestigation.HeaderText = "Main Investigation";
            this.clmMainInvestigation.Name = "clmMainInvestigation";
            this.clmMainInvestigation.ReadOnly = true;
            this.clmMainInvestigation.Width = 300;
            // 
            // clmLabInvestigation
            // 
            this.clmLabInvestigation.HeaderText = "Lab Investigation";
            this.clmLabInvestigation.Name = "clmLabInvestigation";
            this.clmLabInvestigation.ReadOnly = true;
            this.clmLabInvestigation.Width = 300;
            // 
            // clmRadiology
            // 
            this.clmRadiology.HeaderText = "Radiology";
            this.clmRadiology.Name = "clmRadiology";
            this.clmRadiology.ReadOnly = true;
            this.clmRadiology.Width = 200;
            // 
            // clmSpecial
            // 
            this.clmSpecial.HeaderText = "Special";
            this.clmSpecial.Name = "clmSpecial";
            this.clmSpecial.ReadOnly = true;
            this.clmSpecial.Width = 200;
            // 
            // clmInvestigationDate
            // 
            this.clmInvestigationDate.HeaderText = "Date";
            this.clmInvestigationDate.Name = "clmInvestigationDate";
            this.clmInvestigationDate.ReadOnly = true;
            this.clmInvestigationDate.Width = 200;
            // 
            // OPDInvestigationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 615);
            this.Controls.Add(this.dgvInvestionData);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "OPDInvestigationForm";
            this.Text = "OPDInvestigationForm";
            this.Controls.SetChildIndex(this.tableLayoutPanel2, 0);
            this.Controls.SetChildIndex(this.tableLayoutPanel3, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.lineAction, 0);
            this.Controls.SetChildIndex(this.dgvInvestionData, 0);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvestionData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblMainInvestigation;
        private System.Windows.Forms.Label lblLabInvestigation;
        private System.Windows.Forms.Label lblRadiologyInvestigation;
        private System.Windows.Forms.TextBox txtRadiologyInvestigation;
        private System.Windows.Forms.Label lblSpecialInvestigation;
        private System.Windows.Forms.TextBox txtSpecialInvestigation;
        private System.Windows.Forms.Label lblInvestigationDate;
        private System.Windows.Forms.DateTimePicker dptInvestigationDate;
        private System.Windows.Forms.Button btnAddNewMainInvestigation;
        private System.Windows.Forms.Button btnAddNewLabInvestigation;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbOpen;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.DataGridView dgvInvestionData;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMainInvestigation;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLabInvestigation;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRadiology;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSpecial;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmInvestigationDate;
        private System.Windows.Forms.CheckedListBox cmbMainInvestigation;
        private System.Windows.Forms.CheckedListBox cmbLabInvestigation;

    }
}