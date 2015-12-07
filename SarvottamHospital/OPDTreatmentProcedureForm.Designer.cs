namespace SarvottamHospital
{
    partial class OPDTreatmentProcedureForm
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
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTreatment = new System.Windows.Forms.Label();
            this.lblTreatmentDate = new System.Windows.Forms.Label();
            this.dptTreatmentDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddNewTreatment = new System.Windows.Forms.Button();
            this.cmbTreatment = new System.Windows.Forms.CheckedListBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbOpen = new System.Windows.Forms.ToolStripButton();
            this.tsbdelete = new System.Windows.Forms.ToolStripButton();
            this.dgvTreatmentProcedure = new System.Windows.Forms.DataGridView();
            this.clmTreatment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTreatmentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreatmentProcedure)).BeginInit();
            this.SuspendLayout();
            // 
            // lineAction
            // 
            this.lineAction.Location = new System.Drawing.Point(0, 444);
            this.lineAction.Size = new System.Drawing.Size(909, 2);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(817, 454);
            this.btnCancel.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(731, 454);
            this.btnSave.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 454);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 6;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.81919F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.18081F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 184F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 171F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel4.Controls.Add(this.lblTreatment, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblTreatmentDate, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.dptTreatmentDate, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.btnAddNewTreatment, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.cmbTreatment, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(51, 70);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(844, 131);
            this.tableLayoutPanel4.TabIndex = 109;
            // 
            // lblTreatment
            // 
            this.lblTreatment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTreatment.AutoSize = true;
            this.lblTreatment.Location = new System.Drawing.Point(3, 6);
            this.lblTreatment.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblTreatment.Name = "lblTreatment";
            this.lblTreatment.Size = new System.Drawing.Size(76, 15);
            this.lblTreatment.TabIndex = 0;
            this.lblTreatment.Text = "Treatment";
            this.lblTreatment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTreatmentDate
            // 
            this.lblTreatmentDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTreatmentDate.AutoSize = true;
            this.lblTreatmentDate.Location = new System.Drawing.Point(3, 106);
            this.lblTreatmentDate.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblTreatmentDate.Name = "lblTreatmentDate";
            this.lblTreatmentDate.Size = new System.Drawing.Size(76, 15);
            this.lblTreatmentDate.TabIndex = 34;
            this.lblTreatmentDate.Text = "Date";
            this.lblTreatmentDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dptTreatmentDate
            // 
            this.dptTreatmentDate.CustomFormat = "dd/MM/yyyy";
            this.dptTreatmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dptTreatmentDate.Location = new System.Drawing.Point(85, 106);
            this.dptTreatmentDate.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.dptTreatmentDate.Name = "dptTreatmentDate";
            this.dptTreatmentDate.Size = new System.Drawing.Size(197, 21);
            this.dptTreatmentDate.TabIndex = 1;
            // 
            // btnAddNewTreatment
            // 
            this.btnAddNewTreatment.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddNewTreatment.Image = global::SarvottamHospital.Properties.Resources.Add;
            this.btnAddNewTreatment.Location = new System.Drawing.Point(440, 3);
            this.btnAddNewTreatment.Name = "btnAddNewTreatment";
            this.btnAddNewTreatment.Size = new System.Drawing.Size(83, 26);
            this.btnAddNewTreatment.TabIndex = 2;
            this.btnAddNewTreatment.Text = "&Add ";
            this.btnAddNewTreatment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddNewTreatment.UseVisualStyleBackColor = true;
            // 
            // cmbTreatment
            // 
            this.cmbTreatment.FormattingEnabled = true;
            this.cmbTreatment.Location = new System.Drawing.Point(85, 3);
            this.cmbTreatment.Name = "cmbTreatment";
            this.cmbTreatment.Size = new System.Drawing.Size(349, 84);
            this.cmbTreatment.Sorted = true;
            this.cmbTreatment.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Controls.Add(this.toolStrip2, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(51, 207);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(844, 29);
            this.tableLayoutPanel5.TabIndex = 110;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOpen,
            this.tsbdelete});
            this.toolStrip2.Location = new System.Drawing.Point(0, 4);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(844, 25);
            this.toolStrip2.TabIndex = 36;
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
            // tsbdelete
            // 
            this.tsbdelete.Image = global::SarvottamHospital.Properties.Resources.Delete;
            this.tsbdelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbdelete.Name = "tsbdelete";
            this.tsbdelete.Size = new System.Drawing.Size(60, 22);
            this.tsbdelete.Text = "&Delete";
            this.tsbdelete.Visible = false;
            // 
            // dgvTreatmentProcedure
            // 
            this.dgvTreatmentProcedure.AllowUserToAddRows = false;
            this.dgvTreatmentProcedure.AllowUserToDeleteRows = false;
            this.dgvTreatmentProcedure.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTreatmentProcedure.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmTreatment,
            this.clmTreatmentDate});
            this.dgvTreatmentProcedure.Location = new System.Drawing.Point(51, 243);
            this.dgvTreatmentProcedure.Name = "dgvTreatmentProcedure";
            this.dgvTreatmentProcedure.ReadOnly = true;
            this.dgvTreatmentProcedure.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTreatmentProcedure.Size = new System.Drawing.Size(844, 189);
            this.dgvTreatmentProcedure.TabIndex = 111;
            // 
            // clmTreatment
            // 
            this.clmTreatment.HeaderText = "Treatment";
            this.clmTreatment.Name = "clmTreatment";
            this.clmTreatment.ReadOnly = true;
            this.clmTreatment.Width = 500;
            // 
            // clmTreatmentDate
            // 
            this.clmTreatmentDate.HeaderText = "Date";
            this.clmTreatmentDate.Name = "clmTreatmentDate";
            this.clmTreatmentDate.ReadOnly = true;
            this.clmTreatmentDate.Width = 300;
            // 
            // OPDTreatmentProcedureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 484);
            this.Controls.Add(this.dgvTreatmentProcedure);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Name = "OPDTreatmentProcedureForm";
            this.Text = "OPDTreatmentProcedureForm";
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.lineAction, 0);
            this.Controls.SetChildIndex(this.tableLayoutPanel4, 0);
            this.Controls.SetChildIndex(this.tableLayoutPanel5, 0);
            this.Controls.SetChildIndex(this.dgvTreatmentProcedure, 0);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreatmentProcedure)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lblTreatment;
        private System.Windows.Forms.Label lblTreatmentDate;
        private System.Windows.Forms.DateTimePicker dptTreatmentDate;
        private System.Windows.Forms.Button btnAddNewTreatment;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.DataGridView dgvTreatmentProcedure;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTreatment;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTreatmentDate;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsbOpen;
        private System.Windows.Forms.ToolStripButton tsbdelete;
        private System.Windows.Forms.CheckedListBox cmbTreatment;
    }
}