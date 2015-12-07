namespace SarvottamHospital.Controls
{
    partial class OPDPatientListControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.clmNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmContactNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbOPDHistoryProcedure = new System.Windows.Forms.ToolStripButton();
            this.tsbOPDInvestigationProcedure = new System.Windows.Forms.ToolStripButton();
            this.tsbOPDTreatmentProcedure = new System.Windows.Forms.ToolStripButton();
            this.tsbOPDPrescription = new System.Windows.Forms.ToolStripButton();
            this.tsbAppointment = new System.Windows.Forms.ToolStripButton();
            this.tsbAppointmentReport = new System.Windows.Forms.ToolStripButton();
            this.cmbPatientStatus = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslSearch = new System.Windows.Forms.ToolStripLabel();
            this.tstSearch = new System.Windows.Forms.ToolStripTextBox();
            this.tsp2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSearch = new System.Windows.Forms.ToolStripButton();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.tspToolbar = new System.Windows.Forms.ToolStrip();
            this.tstDateTo = new System.Windows.Forms.ToolStripTextBox();
            this.tstDateFrom = new System.Windows.Forms.ToolStripTextBox();
            this.tslDateTo = new System.Windows.Forms.ToolStripLabel();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.tslDateFrom = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.tspToolbar.SuspendLayout();
            this.SuspendLayout();
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
            this.clmNumber,
            this.clmPatientName,
            this.clmGender,
            this.clmContactNo,
            this.clmAge,
            this.clmCity,
            this.clmNote,
            this.clmFill});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvData.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(0, 25);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(1343, 542);
            this.dgvData.StandardTab = true;
            this.dgvData.TabIndex = 16;
            // 
            // clmNumber
            // 
            this.clmNumber.HeaderText = "Patient No";
            this.clmNumber.Name = "clmNumber";
            this.clmNumber.ReadOnly = true;
            // 
            // clmPatientName
            // 
            this.clmPatientName.HeaderText = "Patient Name";
            this.clmPatientName.Name = "clmPatientName";
            this.clmPatientName.ReadOnly = true;
            this.clmPatientName.Width = 200;
            // 
            // clmGender
            // 
            this.clmGender.HeaderText = "Gender";
            this.clmGender.Name = "clmGender";
            this.clmGender.ReadOnly = true;
            this.clmGender.Width = 70;
            // 
            // clmContactNo
            // 
            this.clmContactNo.FillWeight = 120F;
            this.clmContactNo.HeaderText = "Contact No";
            this.clmContactNo.Name = "clmContactNo";
            this.clmContactNo.ReadOnly = true;
            // 
            // clmAge
            // 
            this.clmAge.HeaderText = "Age";
            this.clmAge.Name = "clmAge";
            this.clmAge.ReadOnly = true;
            this.clmAge.Width = 70;
            // 
            // clmCity
            // 
            this.clmCity.HeaderText = "City";
            this.clmCity.Name = "clmCity";
            this.clmCity.ReadOnly = true;
            // 
            // clmNote
            // 
            this.clmNote.HeaderText = "Note";
            this.clmNote.Name = "clmNote";
            this.clmNote.ReadOnly = true;
            this.clmNote.Width = 200;
            // 
            // clmFill
            // 
            this.clmFill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmFill.HeaderText = "";
            this.clmFill.Name = "clmFill";
            this.clmFill.ReadOnly = true;
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
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbOPDHistoryProcedure
            // 
            this.tsbOPDHistoryProcedure.Image = global::SarvottamHospital.Properties.Resources.Attachment;
            this.tsbOPDHistoryProcedure.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOPDHistoryProcedure.Name = "tsbOPDHistoryProcedure";
            this.tsbOPDHistoryProcedure.Size = new System.Drawing.Size(122, 22);
            this.tsbOPDHistoryProcedure.Text = "&History Procedure";
            this.tsbOPDHistoryProcedure.Click += new System.EventHandler(this.tsbOPDHistoryProcedure_Click);
            // 
            // tsbOPDInvestigationProcedure
            // 
            this.tsbOPDInvestigationProcedure.Image = global::SarvottamHospital.Properties.Resources.Attachment;
            this.tsbOPDInvestigationProcedure.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOPDInvestigationProcedure.Name = "tsbOPDInvestigationProcedure";
            this.tsbOPDInvestigationProcedure.Size = new System.Drawing.Size(152, 22);
            this.tsbOPDInvestigationProcedure.Text = "&Investigation Procedure";
            this.tsbOPDInvestigationProcedure.Click += new System.EventHandler(this.tsbOPDInvestigationProcedure_Click);
            // 
            // tsbOPDTreatmentProcedure
            // 
            this.tsbOPDTreatmentProcedure.Image = global::SarvottamHospital.Properties.Resources.Attachment;
            this.tsbOPDTreatmentProcedure.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOPDTreatmentProcedure.Name = "tsbOPDTreatmentProcedure";
            this.tsbOPDTreatmentProcedure.Size = new System.Drawing.Size(139, 22);
            this.tsbOPDTreatmentProcedure.Text = "&Treatment Procedure";
            this.tsbOPDTreatmentProcedure.Click += new System.EventHandler(this.tsbOPDTreatmentProcedure_Click);
            // 
            // tsbOPDPrescription
            // 
            this.tsbOPDPrescription.Image = global::SarvottamHospital.Properties.Resources.Attachment;
            this.tsbOPDPrescription.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOPDPrescription.Name = "tsbOPDPrescription";
            this.tsbOPDPrescription.Size = new System.Drawing.Size(90, 22);
            this.tsbOPDPrescription.Text = "&Prescription";
            this.tsbOPDPrescription.Click += new System.EventHandler(this.tsbOPDPrescription_Click);
            // 
            // tsbAppointment
            // 
            this.tsbAppointment.Image = global::SarvottamHospital.Properties.Resources.Attachment;
            this.tsbAppointment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAppointment.Name = "tsbAppointment";
            this.tsbAppointment.Size = new System.Drawing.Size(98, 22);
            this.tsbAppointment.Text = "&Appointment";
            this.tsbAppointment.Click += new System.EventHandler(this.tsbAppointment_Click);
            // 
            // tsbAppointmentReport
            // 
            this.tsbAppointmentReport.Image = global::SarvottamHospital.Properties.Resources.Attachment;
            this.tsbAppointmentReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAppointmentReport.Name = "tsbAppointmentReport";
            this.tsbAppointmentReport.Size = new System.Drawing.Size(136, 22);
            this.tsbAppointmentReport.Text = "&Appointment Report";
            this.tsbAppointmentReport.Click += new System.EventHandler(this.tsbAppointmentReport_Click);
            // 
            // cmbPatientStatus
            // 
            this.cmbPatientStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPatientStatus.Items.AddRange(new object[] {
            "Current",
            "D"});
            this.cmbPatientStatus.Name = "cmbPatientStatus";
            this.cmbPatientStatus.Size = new System.Drawing.Size(75, 25);
            this.cmbPatientStatus.SelectedIndexChanged += new System.EventHandler(this.cmbPatientStatus_SelectedIndexChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
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
            this.tstSearch.Size = new System.Drawing.Size(40, 25);
            // 
            // tsp2
            // 
            this.tsp2.Name = "tsp2";
            this.tsp2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbSearch
            // 
            this.tsbSearch.Image = global::SarvottamHospital.Properties.Resources.Find;
            this.tsbSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSearch.MergeIndex = 0;
            this.tsbSearch.Name = "tsbSearch";
            this.tsbSearch.Size = new System.Drawing.Size(42, 22);
            this.tsbSearch.Text = "&Go";
            // 
            // tsbClose
            // 
            this.tsbClose.Image = global::SarvottamHospital.Properties.Resources.Cancel;
            this.tsbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(56, 22);
            this.tsbClose.Text = "&Close";
            // 
            // tspToolbar
            // 
            this.tspToolbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tspToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.toolStripSeparator2,
            this.tsbOpen,
            this.toolStripSeparator3,
            this.tsbOPDHistoryProcedure,
            this.tsbOPDInvestigationProcedure,
            this.tsbOPDTreatmentProcedure,
            this.tsbOPDPrescription,
            this.tsbAppointment,
            this.tsbAppointmentReport,
            this.cmbPatientStatus,
            this.toolStripSeparator1,
            this.tslSearch,
            this.tstSearch,
            this.tsp2,
            this.tslDateFrom,
            this.tstDateFrom,
            this.tslDateTo,
            this.tstDateTo,
            this.tsbSearch,
            this.tsbClose});
            this.tspToolbar.Location = new System.Drawing.Point(0, 0);
            this.tspToolbar.Name = "tspToolbar";
            this.tspToolbar.Padding = new System.Windows.Forms.Padding(6, 0, 1, 0);
            this.tspToolbar.Size = new System.Drawing.Size(1343, 25);
            this.tspToolbar.TabIndex = 12;
            this.tspToolbar.Text = "toolStrip1";
            // 
            // tstDateTo
            // 
            this.tstDateTo.Name = "tstDateTo";
            this.tstDateTo.Size = new System.Drawing.Size(80, 25);
            // 
            // tstDateFrom
            // 
            this.tstDateFrom.Name = "tstDateFrom";
            this.tstDateFrom.Size = new System.Drawing.Size(80, 25);
            // 
            // tslDateTo
            // 
            this.tslDateTo.Name = "tslDateTo";
            this.tslDateTo.Size = new System.Drawing.Size(51, 22);
            this.tslDateTo.Text = "DateTo :";
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.Checked = false;
            this.dtpDateTo.CustomFormat = "dd/MM/yyyy";
            this.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateTo.Location = new System.Drawing.Point(1253, 1);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.ShowCheckBox = true;
            this.dtpDateTo.Size = new System.Drawing.Size(95, 21);
            this.dtpDateTo.TabIndex = 15;
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.Checked = false;
            this.dtpDateFrom.CustomFormat = "dd/MM/yyyy";
            this.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateFrom.Location = new System.Drawing.Point(1116, 1);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.ShowCheckBox = true;
            this.dtpDateFrom.Size = new System.Drawing.Size(95, 21);
            this.dtpDateFrom.TabIndex = 14;
            // 
            // tslDateFrom
            // 
            this.tslDateFrom.Name = "tslDateFrom";
            this.tslDateFrom.Size = new System.Drawing.Size(65, 22);
            this.tslDateFrom.Text = "DateFrom :";
            // 
            // OPDPatientListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.dtpDateTo);
            this.Controls.Add(this.dtpDateFrom);
            this.Controls.Add(this.tspToolbar);
            this.Name = "OPDPatientListControl";
            this.Size = new System.Drawing.Size(1343, 567);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.tspToolbar.ResumeLayout(false);
            this.tspToolbar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmContactNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFill;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbOPDHistoryProcedure;
        private System.Windows.Forms.ToolStripButton tsbOPDInvestigationProcedure;
        private System.Windows.Forms.ToolStripButton tsbOPDTreatmentProcedure;
        private System.Windows.Forms.ToolStripButton tsbOPDPrescription;
        private System.Windows.Forms.ToolStripButton tsbAppointment;
        private System.Windows.Forms.ToolStripButton tsbAppointmentReport;
        private System.Windows.Forms.ToolStripComboBox cmbPatientStatus;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tslSearch;
        private System.Windows.Forms.ToolStripTextBox tstSearch;
        private System.Windows.Forms.ToolStripSeparator tsp2;
        private System.Windows.Forms.ToolStripButton tsbSearch;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStrip tspToolbar;
        private System.Windows.Forms.ToolStripLabel tslDateFrom;
        private System.Windows.Forms.ToolStripTextBox tstDateFrom;
        private System.Windows.Forms.ToolStripLabel tslDateTo;
        private System.Windows.Forms.ToolStripTextBox tstDateTo;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
    }
}
