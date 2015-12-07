namespace SarvottamHospital.Controls
{
    partial class PatientListControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.clmNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAdmitedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmContactNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDischargeDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBill = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tspToolbar = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbPatientProcedure = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.cmbPatientStatus = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslSearch = new System.Windows.Forms.ToolStripLabel();
            this.tstSearch = new System.Windows.Forms.ToolStripTextBox();
            this.tsp2 = new System.Windows.Forms.ToolStripSeparator();
            this.tslDateFrom = new System.Windows.Forms.ToolStripLabel();
            this.tstDateFrom = new System.Windows.Forms.ToolStripTextBox();
            this.tslDateTo = new System.Windows.Forms.ToolStripLabel();
            this.tstDateTo = new System.Windows.Forms.ToolStripTextBox();
            this.tsbSearch = new System.Windows.Forms.ToolStripButton();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
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
            this.clmAdmitedDate,
            this.clmGender,
            this.clmContactNo,
            this.clmAge,
            this.clmCity,
            this.clmWard,
            this.clmRoom,
            this.clmNote,
            this.clmDischargeDate,
            this.clmBill,
            this.clmGuid,
            this.clmFill});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvData.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(0, 25);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(1353, 505);
            this.dgvData.StandardTab = true;
            this.dgvData.TabIndex = 12;
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
            // clmAdmitedDate
            // 
            this.clmAdmitedDate.FillWeight = 120F;
            this.clmAdmitedDate.HeaderText = "Admited Date";
            this.clmAdmitedDate.Name = "clmAdmitedDate";
            this.clmAdmitedDate.ReadOnly = true;
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
            // clmWard
            // 
            this.clmWard.FillWeight = 80F;
            this.clmWard.HeaderText = "Ward";
            this.clmWard.Name = "clmWard";
            this.clmWard.ReadOnly = true;
            this.clmWard.Width = 120;
            // 
            // clmRoom
            // 
            this.clmRoom.FillWeight = 50F;
            this.clmRoom.HeaderText = "Room";
            this.clmRoom.Name = "clmRoom";
            this.clmRoom.ReadOnly = true;
            this.clmRoom.Width = 120;
            // 
            // clmNote
            // 
            this.clmNote.HeaderText = "Note";
            this.clmNote.Name = "clmNote";
            this.clmNote.ReadOnly = true;
            this.clmNote.Width = 200;
            // 
            // clmDischargeDate
            // 
            this.clmDischargeDate.HeaderText = "Discharge Date";
            this.clmDischargeDate.Name = "clmDischargeDate";
            this.clmDischargeDate.ReadOnly = true;
            // 
            // clmBill
            // 
            this.clmBill.FillWeight = 140F;
            this.clmBill.HeaderText = "Bill";
            this.clmBill.Image = global::SarvottamHospital.Properties.Resources.PrintIcon;
            this.clmBill.Name = "clmBill";
            this.clmBill.ReadOnly = true;
            this.clmBill.Width = 50;
            // 
            // clmGuid
            // 
            this.clmGuid.HeaderText = "Guid";
            this.clmGuid.Name = "clmGuid";
            this.clmGuid.ReadOnly = true;
            this.clmGuid.Visible = false;
            // 
            // clmFill
            // 
            this.clmFill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmFill.HeaderText = "";
            this.clmFill.Name = "clmFill";
            this.clmFill.ReadOnly = true;
            // 
            // tspToolbar
            // 
            this.tspToolbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tspToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.toolStripSeparator2,
            this.tsbOpen,
            this.toolStripSeparator3,
            this.tsbPatientProcedure,
            this.toolStripSeparator4,
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
            this.tspToolbar.Size = new System.Drawing.Size(1353, 25);
            this.tspToolbar.TabIndex = 11;
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
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbPatientProcedure
            // 
            this.tsbPatientProcedure.Image = global::SarvottamHospital.Properties.Resources.Attachment;
            this.tsbPatientProcedure.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPatientProcedure.Name = "tsbPatientProcedure";
            this.tsbPatientProcedure.Size = new System.Drawing.Size(121, 22);
            this.tsbPatientProcedure.Text = "&Patient Procedure";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // cmbPatientStatus
            // 
            this.cmbPatientStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPatientStatus.Items.AddRange(new object[] {
            "Current",
            "D"});
            this.cmbPatientStatus.Name = "cmbPatientStatus";
            this.cmbPatientStatus.Size = new System.Drawing.Size(121, 25);
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
            this.tstSearch.Size = new System.Drawing.Size(100, 25);
            // 
            // tsp2
            // 
            this.tsp2.Name = "tsp2";
            this.tsp2.Size = new System.Drawing.Size(6, 25);
            // 
            // tslDateFrom
            // 
            this.tslDateFrom.Name = "tslDateFrom";
            this.tslDateFrom.Size = new System.Drawing.Size(68, 22);
            this.tslDateFrom.Text = "Date From :";
            // 
            // tstDateFrom
            // 
            this.tstDateFrom.Name = "tstDateFrom";
            this.tstDateFrom.Size = new System.Drawing.Size(120, 25);
            // 
            // tslDateTo
            // 
            this.tslDateTo.Name = "tslDateTo";
            this.tslDateTo.Size = new System.Drawing.Size(54, 22);
            this.tslDateTo.Text = "Date To :";
            // 
            // tstDateTo
            // 
            this.tstDateTo.Name = "tstDateTo";
            this.tstDateTo.Size = new System.Drawing.Size(120, 25);
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
            // dtpDateFrom
            // 
            this.dtpDateFrom.Checked = false;
            this.dtpDateFrom.CustomFormat = "dd/MM/yyyy";
            this.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateFrom.Location = new System.Drawing.Point(615, 2);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.ShowCheckBox = true;
            this.dtpDateFrom.Size = new System.Drawing.Size(121, 21);
            this.dtpDateFrom.TabIndex = 13;
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.Checked = false;
            this.dtpDateTo.CustomFormat = "dd/MM/yyyy";
            this.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateTo.Location = new System.Drawing.Point(792, 1);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.ShowCheckBox = true;
            this.dtpDateTo.Size = new System.Drawing.Size(120, 21);
            this.dtpDateTo.TabIndex = 14;
            // 
            // PatientListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtpDateTo);
            this.Controls.Add(this.dtpDateFrom);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.tspToolbar);
            this.Name = "PatientListControl";
            this.Size = new System.Drawing.Size(1353, 530);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.tspToolbar.ResumeLayout(false);
            this.tspToolbar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.ToolStrip tspToolbar;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbPatientProcedure;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripComboBox cmbPatientStatus;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tslSearch;
        private System.Windows.Forms.ToolStripTextBox tstSearch;
        private System.Windows.Forms.ToolStripSeparator tsp2;
        private System.Windows.Forms.ToolStripLabel tslDateFrom;
        private System.Windows.Forms.ToolStripTextBox tstDateFrom;
        private System.Windows.Forms.ToolStripLabel tslDateTo;
        private System.Windows.Forms.ToolStripTextBox tstDateTo;
        private System.Windows.Forms.ToolStripButton tsbSearch;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAdmitedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmContactNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWard;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDischargeDate;
        private System.Windows.Forms.DataGridViewImageColumn clmBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFill;

    }
}
