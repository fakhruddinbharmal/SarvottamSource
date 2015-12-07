namespace SarvottamHospital
{
    partial class OPDPrescriptionForm
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
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.lblMedicine = new System.Windows.Forms.Label();
            this.lblPrescriptionDate = new System.Windows.Forms.Label();
            this.dptPrescriptionDate = new System.Windows.Forms.DateTimePicker();
            this.lblDoseage = new System.Windows.Forms.Label();
            this.lblTimings = new System.Windows.Forms.Label();
            this.txtDoseage = new System.Windows.Forms.TextBox();
            this.txtTimings = new System.Windows.Forms.TextBox();
            this.cmbMedicine = new System.Windows.Forms.CheckedListBox();
            this.btnAddNewMedicine = new System.Windows.Forms.Button();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbOpen = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.dgvPrescription = new System.Windows.Forms.DataGridView();
            this.clmMedicine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDoseage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTimings = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrescriptionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrescription)).BeginInit();
            this.SuspendLayout();
            // 
            // lineAction
            // 
            this.lineAction.Location = new System.Drawing.Point(0, 512);
            this.lineAction.Size = new System.Drawing.Size(1196, 2);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1104, 522);
            this.btnCancel.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1018, 522);
            this.btnSave.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 522);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 6;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.72985F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.27015F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 246F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 222F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 176F));
            this.tableLayoutPanel6.Controls.Add(this.lblMedicine, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.lblPrescriptionDate, 0, 3);
            this.tableLayoutPanel6.Controls.Add(this.dptPrescriptionDate, 1, 3);
            this.tableLayoutPanel6.Controls.Add(this.lblDoseage, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.lblTimings, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.txtDoseage, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.txtTimings, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.cmbMedicine, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.btnAddNewMedicine, 2, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(42, 54);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 4;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(1142, 216);
            this.tableLayoutPanel6.TabIndex = 109;
            // 
            // lblMedicine
            // 
            this.lblMedicine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMedicine.AutoSize = true;
            this.lblMedicine.Location = new System.Drawing.Point(3, 6);
            this.lblMedicine.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblMedicine.Name = "lblMedicine";
            this.lblMedicine.Size = new System.Drawing.Size(130, 15);
            this.lblMedicine.TabIndex = 0;
            this.lblMedicine.Text = "Medicine";
            this.lblMedicine.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPrescriptionDate
            // 
            this.lblPrescriptionDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrescriptionDate.AutoSize = true;
            this.lblPrescriptionDate.Location = new System.Drawing.Point(3, 174);
            this.lblPrescriptionDate.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblPrescriptionDate.Name = "lblPrescriptionDate";
            this.lblPrescriptionDate.Size = new System.Drawing.Size(130, 15);
            this.lblPrescriptionDate.TabIndex = 34;
            this.lblPrescriptionDate.Text = "Date";
            this.lblPrescriptionDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dptPrescriptionDate
            // 
            this.dptPrescriptionDate.CustomFormat = "dd/MM/yyyy";
            this.dptPrescriptionDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dptPrescriptionDate.Location = new System.Drawing.Point(139, 174);
            this.dptPrescriptionDate.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.dptPrescriptionDate.Name = "dptPrescriptionDate";
            this.dptPrescriptionDate.Size = new System.Drawing.Size(197, 21);
            this.dptPrescriptionDate.TabIndex = 3;
            // 
            // lblDoseage
            // 
            this.lblDoseage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDoseage.AutoSize = true;
            this.lblDoseage.Location = new System.Drawing.Point(3, 97);
            this.lblDoseage.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblDoseage.Name = "lblDoseage";
            this.lblDoseage.Size = new System.Drawing.Size(130, 15);
            this.lblDoseage.TabIndex = 44;
            this.lblDoseage.Text = "Doseage";
            this.lblDoseage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTimings
            // 
            this.lblTimings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimings.AutoSize = true;
            this.lblTimings.Location = new System.Drawing.Point(3, 137);
            this.lblTimings.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblTimings.Name = "lblTimings";
            this.lblTimings.Size = new System.Drawing.Size(130, 15);
            this.lblTimings.TabIndex = 45;
            this.lblTimings.Text = "Timings";
            this.lblTimings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDoseage
            // 
            this.txtDoseage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDoseage.Location = new System.Drawing.Point(139, 97);
            this.txtDoseage.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtDoseage.MaxLength = 25;
            this.txtDoseage.Name = "txtDoseage";
            this.txtDoseage.Size = new System.Drawing.Size(238, 21);
            this.txtDoseage.TabIndex = 1;
            // 
            // txtTimings
            // 
            this.txtTimings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimings.Location = new System.Drawing.Point(139, 137);
            this.txtTimings.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtTimings.MaxLength = 25;
            this.txtTimings.Name = "txtTimings";
            this.txtTimings.Size = new System.Drawing.Size(238, 21);
            this.txtTimings.TabIndex = 2;
            // 
            // cmbMedicine
            // 
            this.cmbMedicine.FormattingEnabled = true;
            this.cmbMedicine.Location = new System.Drawing.Point(139, 3);
            this.cmbMedicine.Name = "cmbMedicine";
            this.cmbMedicine.Size = new System.Drawing.Size(238, 84);
            this.cmbMedicine.Sorted = true;
            this.cmbMedicine.TabIndex = 0;
            // 
            // btnAddNewMedicine
            // 
            this.btnAddNewMedicine.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddNewMedicine.Image = global::SarvottamHospital.Properties.Resources.Add;
            this.btnAddNewMedicine.Location = new System.Drawing.Point(383, 3);
            this.btnAddNewMedicine.Name = "btnAddNewMedicine";
            this.btnAddNewMedicine.Size = new System.Drawing.Size(110, 26);
            this.btnAddNewMedicine.TabIndex = 4;
            this.btnAddNewMedicine.Text = "&Add ";
            this.btnAddNewMedicine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddNewMedicine.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.Controls.Add(this.toolStrip2, 0, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(42, 276);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(1142, 29);
            this.tableLayoutPanel7.TabIndex = 49;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOpen,
            this.tsbDelete});
            this.toolStrip2.Location = new System.Drawing.Point(0, 4);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1142, 25);
            this.toolStrip2.TabIndex = 50;
            this.toolStrip2.Text = "toolStrip2";
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
            // dgvPrescription
            // 
            this.dgvPrescription.AllowUserToAddRows = false;
            this.dgvPrescription.AllowUserToDeleteRows = false;
            this.dgvPrescription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrescription.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMedicine,
            this.clmDoseage,
            this.clmTimings,
            this.clmPrescriptionDate});
            this.dgvPrescription.Location = new System.Drawing.Point(42, 321);
            this.dgvPrescription.Name = "dgvPrescription";
            this.dgvPrescription.ReadOnly = true;
            this.dgvPrescription.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrescription.Size = new System.Drawing.Size(1142, 188);
            this.dgvPrescription.TabIndex = 2;
            // 
            // clmMedicine
            // 
            this.clmMedicine.HeaderText = "Medicine";
            this.clmMedicine.Name = "clmMedicine";
            this.clmMedicine.ReadOnly = true;
            this.clmMedicine.Width = 300;
            // 
            // clmDoseage
            // 
            this.clmDoseage.HeaderText = "Doseage";
            this.clmDoseage.Name = "clmDoseage";
            this.clmDoseage.ReadOnly = true;
            this.clmDoseage.Width = 300;
            // 
            // clmTimings
            // 
            this.clmTimings.HeaderText = "Timings";
            this.clmTimings.Name = "clmTimings";
            this.clmTimings.ReadOnly = true;
            this.clmTimings.Width = 300;
            // 
            // clmPrescriptionDate
            // 
            this.clmPrescriptionDate.HeaderText = "Date";
            this.clmPrescriptionDate.Name = "clmPrescriptionDate";
            this.clmPrescriptionDate.ReadOnly = true;
            this.clmPrescriptionDate.Width = 250;
            // 
            // OPDPrescriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 552);
            this.Controls.Add(this.dgvPrescription);
            this.Controls.Add(this.tableLayoutPanel7);
            this.Controls.Add(this.tableLayoutPanel6);
            this.Name = "OPDPrescriptionForm";
            this.Text = "OPDPrescriptionForm";
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.lineAction, 0);
            this.Controls.SetChildIndex(this.tableLayoutPanel6, 0);
            this.Controls.SetChildIndex(this.tableLayoutPanel7, 0);
            this.Controls.SetChildIndex(this.dgvPrescription, 0);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrescription)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label lblMedicine;
        private System.Windows.Forms.Button btnAddNewMedicine;
        private System.Windows.Forms.Label lblPrescriptionDate;
        private System.Windows.Forms.DateTimePicker dptPrescriptionDate;
        private System.Windows.Forms.Label lblDoseage;
        private System.Windows.Forms.Label lblTimings;
        private System.Windows.Forms.TextBox txtDoseage;
        private System.Windows.Forms.TextBox txtTimings;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.DataGridView dgvPrescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMedicine;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDoseage;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTimings;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrescriptionDate;
        private System.Windows.Forms.CheckedListBox cmbMedicine;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsbOpen;
        private System.Windows.Forms.ToolStripButton tsbDelete;
    }
}