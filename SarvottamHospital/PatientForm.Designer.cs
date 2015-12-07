namespace SarvottamHospital
{
    partial class PatientForm
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
            this.tlpPatient = new System.Windows.Forms.TableLayoutPanel();
            this.nupReferredDoctorShare = new System.Windows.Forms.NumericUpDown();
            this.lblReferredDoctorShare = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.nupAge = new System.Windows.Forms.NumericUpDown();
            this.lblCityTown = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblAdmitedDate = new System.Windows.Forms.Label();
            this.dtpAdmitedDate = new System.Windows.Forms.DateTimePicker();
            this.lblAdmitedTime = new System.Windows.Forms.Label();
            this.lblRefferedDoctor = new System.Windows.Forms.Label();
            this.lblWards = new System.Windows.Forms.Label();
            this.cmbWards = new System.Windows.Forms.ComboBox();
            this.lblRoomNo = new System.Windows.Forms.Label();
            this.cmbRoomBedNo = new System.Windows.Forms.ComboBox();
            this.cmbAdmitedTime = new System.Windows.Forms.ComboBox();
            this.cmbReferredDoctor = new System.Windows.Forms.ComboBox();
            this.lblPhoneNo = new System.Windows.Forms.Label();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblTreatment = new System.Windows.Forms.Label();
            this.chkDischarge = new System.Windows.Forms.CheckBox();
            this.lblDischargeDate = new System.Windows.Forms.Label();
            this.dptInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.dtpDischargDate = new System.Windows.Forms.DateTimePicker();
            this.lblInvoiceDate = new System.Windows.Forms.Label();
            this.lblOperation = new System.Windows.Forms.Label();
            this.txtOperation = new System.Windows.Forms.TextBox();
            this.lbTreatment = new System.Windows.Forms.CheckedListBox();
            this.tlpPatient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupReferredDoctorShare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupAge)).BeginInit();
            this.SuspendLayout();
            // 
            // lineAction
            // 
            this.lineAction.Location = new System.Drawing.Point(0, 597);
            this.lineAction.Size = new System.Drawing.Size(649, 2);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(557, 607);
            this.btnCancel.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(471, 607);
            this.btnSave.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 607);
            this.btnDelete.TabIndex = 2;
            // 
            // tlpPatient
            // 
            this.tlpPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpPatient.ColumnCount = 4;
            this.tlpPatient.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpPatient.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpPatient.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpPatient.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpPatient.Controls.Add(this.nupReferredDoctorShare, 3, 15);
            this.tlpPatient.Controls.Add(this.lblReferredDoctorShare, 2, 15);
            this.tlpPatient.Controls.Add(this.txtLastName, 1, 1);
            this.tlpPatient.Controls.Add(this.lblLastName, 0, 1);
            this.tlpPatient.Controls.Add(this.txtMiddleName, 3, 0);
            this.tlpPatient.Controls.Add(this.txtAddress, 1, 5);
            this.tlpPatient.Controls.Add(this.lblFirstName, 0, 0);
            this.tlpPatient.Controls.Add(this.txtFirstName, 1, 0);
            this.tlpPatient.Controls.Add(this.lblAddress, 0, 5);
            this.tlpPatient.Controls.Add(this.lblGender, 0, 2);
            this.tlpPatient.Controls.Add(this.lblMiddleName, 2, 0);
            this.tlpPatient.Controls.Add(this.cmbGender, 1, 2);
            this.tlpPatient.Controls.Add(this.lblAge, 2, 2);
            this.tlpPatient.Controls.Add(this.nupAge, 3, 2);
            this.tlpPatient.Controls.Add(this.lblCityTown, 0, 7);
            this.tlpPatient.Controls.Add(this.txtCity, 1, 7);
            this.tlpPatient.Controls.Add(this.lblAdmitedDate, 0, 13);
            this.tlpPatient.Controls.Add(this.dtpAdmitedDate, 1, 13);
            this.tlpPatient.Controls.Add(this.lblAdmitedTime, 2, 13);
            this.tlpPatient.Controls.Add(this.lblRefferedDoctor, 0, 15);
            this.tlpPatient.Controls.Add(this.lblWards, 0, 16);
            this.tlpPatient.Controls.Add(this.cmbWards, 1, 16);
            this.tlpPatient.Controls.Add(this.lblRoomNo, 2, 16);
            this.tlpPatient.Controls.Add(this.cmbRoomBedNo, 3, 16);
            this.tlpPatient.Controls.Add(this.cmbAdmitedTime, 3, 13);
            this.tlpPatient.Controls.Add(this.cmbReferredDoctor, 1, 15);
            this.tlpPatient.Controls.Add(this.lblPhoneNo, 2, 7);
            this.tlpPatient.Controls.Add(this.txtContactNo, 3, 7);
            this.tlpPatient.Controls.Add(this.txtNotes, 1, 20);
            this.tlpPatient.Controls.Add(this.lblNotes, 0, 20);
            this.tlpPatient.Controls.Add(this.lblTreatment, 0, 17);
            this.tlpPatient.Controls.Add(this.chkDischarge, 0, 18);
            this.tlpPatient.Controls.Add(this.lblDischargeDate, 2, 18);
            this.tlpPatient.Controls.Add(this.dptInvoiceDate, 1, 19);
            this.tlpPatient.Controls.Add(this.dtpDischargDate, 3, 18);
            this.tlpPatient.Controls.Add(this.lblInvoiceDate, 0, 19);
            this.tlpPatient.Controls.Add(this.lblOperation, 2, 17);
            this.tlpPatient.Controls.Add(this.txtOperation, 3, 17);
            this.tlpPatient.Controls.Add(this.lbTreatment, 1, 17);
            this.tlpPatient.Location = new System.Drawing.Point(12, 51);
            this.tlpPatient.Name = "tlpPatient";
            this.tlpPatient.RowCount = 21;
            this.tlpPatient.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPatient.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPatient.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPatient.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPatient.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPatient.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPatient.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPatient.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPatient.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPatient.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPatient.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPatient.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPatient.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPatient.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPatient.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPatient.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPatient.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPatient.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPatient.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPatient.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPatient.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPatient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPatient.Size = new System.Drawing.Size(625, 543);
            this.tlpPatient.TabIndex = 109;
            // 
            // nupReferredDoctorShare
            // 
            this.nupReferredDoctorShare.Location = new System.Drawing.Point(440, 256);
            this.nupReferredDoctorShare.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.nupReferredDoctorShare.Name = "nupReferredDoctorShare";
            this.nupReferredDoctorShare.Size = new System.Drawing.Size(120, 21);
            this.nupReferredDoctorShare.TabIndex = 23;
            this.nupReferredDoctorShare.Visible = false;
            // 
            // lblReferredDoctorShare
            // 
            this.lblReferredDoctorShare.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReferredDoctorShare.AutoSize = true;
            this.lblReferredDoctorShare.Location = new System.Drawing.Point(315, 256);
            this.lblReferredDoctorShare.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblReferredDoctorShare.Name = "lblReferredDoctorShare";
            this.lblReferredDoctorShare.Size = new System.Drawing.Size(119, 30);
            this.lblReferredDoctorShare.TabIndex = 22;
            this.lblReferredDoctorShare.Text = "Referred Doctor Share(%)";
            this.lblReferredDoctorShare.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblReferredDoctorShare.Visible = false;
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLastName.Location = new System.Drawing.Point(128, 33);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtLastName.MaxLength = 50;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(181, 21);
            this.txtLastName.TabIndex = 5;
            // 
            // lblLastName
            // 
            this.lblLastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(3, 33);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(119, 15);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Last Name";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMiddleName.Location = new System.Drawing.Point(440, 3);
            this.txtMiddleName.MaxLength = 50;
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(182, 21);
            this.txtMiddleName.TabIndex = 3;
            // 
            // txtAddress
            // 
            this.tlpPatient.SetColumnSpan(this.txtAddress, 3);
            this.txtAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAddress.Location = new System.Drawing.Point(128, 101);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtAddress.MaxLength = 500;
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.tlpPatient.SetRowSpan(this.txtAddress, 2);
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAddress.Size = new System.Drawing.Size(494, 75);
            this.txtAddress.TabIndex = 11;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(3, 6);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(119, 15);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFirstName.Location = new System.Drawing.Point(128, 3);
            this.txtFirstName.MaxLength = 50;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(181, 21);
            this.txtFirstName.TabIndex = 1;
            // 
            // lblAddress
            // 
            this.lblAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(3, 101);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblAddress.Name = "lblAddress";
            this.tlpPatient.SetRowSpan(this.lblAddress, 2);
            this.lblAddress.Size = new System.Drawing.Size(119, 45);
            this.lblAddress.TabIndex = 10;
            this.lblAddress.Text = "Address\r\n(Press Ctl+Enter for New line)";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGender
            // 
            this.lblGender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(3, 66);
            this.lblGender.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(119, 15);
            this.lblGender.TabIndex = 6;
            this.lblGender.Text = "Gender";
            this.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Location = new System.Drawing.Point(315, 6);
            this.lblMiddleName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(119, 15);
            this.lblMiddleName.TabIndex = 2;
            this.lblMiddleName.Text = "Middle Name";
            this.lblMiddleName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbGender
            // 
            this.cmbGender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cmbGender.Location = new System.Drawing.Point(128, 66);
            this.cmbGender.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(181, 23);
            this.cmbGender.TabIndex = 7;
            // 
            // lblAge
            // 
            this.lblAge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(315, 66);
            this.lblAge.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(119, 15);
            this.lblAge.TabIndex = 8;
            this.lblAge.Text = "Age";
            this.lblAge.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nupAge
            // 
            this.nupAge.Location = new System.Drawing.Point(440, 66);
            this.nupAge.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.nupAge.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nupAge.Name = "nupAge";
            this.nupAge.Size = new System.Drawing.Size(120, 21);
            this.nupAge.TabIndex = 9;
            // 
            // lblCityTown
            // 
            this.lblCityTown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCityTown.AutoSize = true;
            this.lblCityTown.Location = new System.Drawing.Point(3, 188);
            this.lblCityTown.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCityTown.Name = "lblCityTown";
            this.lblCityTown.Size = new System.Drawing.Size(119, 15);
            this.lblCityTown.TabIndex = 12;
            this.lblCityTown.Text = "City/Town";
            this.lblCityTown.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCity
            // 
            this.txtCity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCity.Location = new System.Drawing.Point(128, 188);
            this.txtCity.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtCity.MaxLength = 50;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(181, 21);
            this.txtCity.TabIndex = 13;
            // 
            // lblAdmitedDate
            // 
            this.lblAdmitedDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAdmitedDate.AutoSize = true;
            this.lblAdmitedDate.Location = new System.Drawing.Point(3, 221);
            this.lblAdmitedDate.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblAdmitedDate.Name = "lblAdmitedDate";
            this.lblAdmitedDate.Size = new System.Drawing.Size(119, 15);
            this.lblAdmitedDate.TabIndex = 16;
            this.lblAdmitedDate.Text = "Admitted Date";
            this.lblAdmitedDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpAdmitedDate
            // 
            this.dtpAdmitedDate.CustomFormat = "dd/MM/yyyy";
            this.dtpAdmitedDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAdmitedDate.Location = new System.Drawing.Point(128, 221);
            this.dtpAdmitedDate.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.dtpAdmitedDate.Name = "dtpAdmitedDate";
            this.dtpAdmitedDate.Size = new System.Drawing.Size(140, 21);
            this.dtpAdmitedDate.TabIndex = 17;
            // 
            // lblAdmitedTime
            // 
            this.lblAdmitedTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAdmitedTime.AutoSize = true;
            this.lblAdmitedTime.Location = new System.Drawing.Point(315, 221);
            this.lblAdmitedTime.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblAdmitedTime.Name = "lblAdmitedTime";
            this.lblAdmitedTime.Size = new System.Drawing.Size(119, 15);
            this.lblAdmitedTime.TabIndex = 18;
            this.lblAdmitedTime.Text = "Admitted Time";
            this.lblAdmitedTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRefferedDoctor
            // 
            this.lblRefferedDoctor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRefferedDoctor.AutoSize = true;
            this.lblRefferedDoctor.Location = new System.Drawing.Point(3, 256);
            this.lblRefferedDoctor.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblRefferedDoctor.Name = "lblRefferedDoctor";
            this.lblRefferedDoctor.Size = new System.Drawing.Size(119, 15);
            this.lblRefferedDoctor.TabIndex = 20;
            this.lblRefferedDoctor.Text = "Referred Doctor";
            this.lblRefferedDoctor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWards
            // 
            this.lblWards.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWards.AutoSize = true;
            this.lblWards.Location = new System.Drawing.Point(3, 298);
            this.lblWards.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblWards.Name = "lblWards";
            this.lblWards.Size = new System.Drawing.Size(119, 15);
            this.lblWards.TabIndex = 24;
            this.lblWards.Text = "Ward";
            this.lblWards.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbWards
            // 
            this.cmbWards.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbWards.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWards.FormattingEnabled = true;
            this.cmbWards.Location = new System.Drawing.Point(128, 298);
            this.cmbWards.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.cmbWards.MaxDropDownItems = 100;
            this.cmbWards.Name = "cmbWards";
            this.cmbWards.Size = new System.Drawing.Size(181, 23);
            this.cmbWards.Sorted = true;
            this.cmbWards.TabIndex = 25;
            // 
            // lblRoomNo
            // 
            this.lblRoomNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRoomNo.AutoSize = true;
            this.lblRoomNo.Location = new System.Drawing.Point(315, 298);
            this.lblRoomNo.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblRoomNo.Name = "lblRoomNo";
            this.lblRoomNo.Size = new System.Drawing.Size(119, 15);
            this.lblRoomNo.TabIndex = 26;
            this.lblRoomNo.Text = "Room";
            this.lblRoomNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbRoomBedNo
            // 
            this.cmbRoomBedNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbRoomBedNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoomBedNo.FormattingEnabled = true;
            this.cmbRoomBedNo.Location = new System.Drawing.Point(440, 298);
            this.cmbRoomBedNo.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.cmbRoomBedNo.MaxDropDownItems = 100;
            this.cmbRoomBedNo.Name = "cmbRoomBedNo";
            this.cmbRoomBedNo.Size = new System.Drawing.Size(182, 23);
            this.cmbRoomBedNo.Sorted = true;
            this.cmbRoomBedNo.TabIndex = 27;
            // 
            // cmbAdmitedTime
            // 
            this.cmbAdmitedTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAdmitedTime.FormattingEnabled = true;
            this.cmbAdmitedTime.Items.AddRange(new object[] {
            "01 AM",
            "02 AM",
            "03 AM",
            "04 AM",
            "05 AM",
            "06 AM",
            "07 AM",
            "08 AM",
            "09 AM",
            "10 AM",
            "11 AM",
            "12 PM",
            "01 PM",
            "02 PM",
            "03 PM",
            "04 PM",
            "05 PM",
            "06 PM",
            "07 PM",
            "08 PM",
            "09 PM",
            "10 PM",
            "11 PM",
            "12 AM"});
            this.cmbAdmitedTime.Location = new System.Drawing.Point(440, 221);
            this.cmbAdmitedTime.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.cmbAdmitedTime.Name = "cmbAdmitedTime";
            this.cmbAdmitedTime.Size = new System.Drawing.Size(58, 23);
            this.cmbAdmitedTime.TabIndex = 19;
            // 
            // cmbReferredDoctor
            // 
            this.cmbReferredDoctor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbReferredDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReferredDoctor.FormattingEnabled = true;
            this.cmbReferredDoctor.Location = new System.Drawing.Point(128, 256);
            this.cmbReferredDoctor.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.cmbReferredDoctor.MaxDropDownItems = 100;
            this.cmbReferredDoctor.Name = "cmbReferredDoctor";
            this.cmbReferredDoctor.Size = new System.Drawing.Size(181, 23);
            this.cmbReferredDoctor.TabIndex = 21;
            this.cmbReferredDoctor.SelectedIndexChanged += new System.EventHandler(this.cmbReferredDoctor_SelectedIndexChanged);
            // 
            // lblPhoneNo
            // 
            this.lblPhoneNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPhoneNo.AutoSize = true;
            this.lblPhoneNo.Location = new System.Drawing.Point(315, 188);
            this.lblPhoneNo.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblPhoneNo.Name = "lblPhoneNo";
            this.lblPhoneNo.Size = new System.Drawing.Size(119, 15);
            this.lblPhoneNo.TabIndex = 14;
            this.lblPhoneNo.Text = "Contact No";
            this.lblPhoneNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtContactNo
            // 
            this.txtContactNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContactNo.Location = new System.Drawing.Point(440, 188);
            this.txtContactNo.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtContactNo.MaxLength = 10;
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(182, 21);
            this.txtContactNo.TabIndex = 15;
            // 
            // txtNotes
            // 
            this.tlpPatient.SetColumnSpan(this.txtNotes, 3);
            this.txtNotes.Location = new System.Drawing.Point(128, 501);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtNotes.MaxLength = 500;
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotes.Size = new System.Drawing.Size(494, 69);
            this.txtNotes.TabIndex = 34;
            // 
            // lblNotes
            // 
            this.lblNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(3, 501);
            this.lblNotes.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(119, 45);
            this.lblNotes.TabIndex = 33;
            this.lblNotes.Text = "Notes\r\n(Press Ctl+Enter for New line)";
            this.lblNotes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTreatment
            // 
            this.lblTreatment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTreatment.AutoSize = true;
            this.lblTreatment.Location = new System.Drawing.Point(59, 333);
            this.lblTreatment.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblTreatment.Name = "lblTreatment";
            this.lblTreatment.Size = new System.Drawing.Size(63, 15);
            this.lblTreatment.TabIndex = 35;
            this.lblTreatment.Text = "Treatment";
            // 
            // chkDischarge
            // 
            this.chkDischarge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkDischarge.AutoSize = true;
            this.chkDischarge.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkDischarge.Location = new System.Drawing.Point(3, 432);
            this.chkDischarge.Name = "chkDischarge";
            this.chkDischarge.Size = new System.Drawing.Size(119, 19);
            this.chkDischarge.TabIndex = 28;
            this.chkDischarge.Text = "Discharge";
            this.chkDischarge.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkDischarge.UseVisualStyleBackColor = true;
            this.chkDischarge.CheckedChanged += new System.EventHandler(this.chkDischarge_CheckedChanged);
            // 
            // lblDischargeDate
            // 
            this.lblDischargeDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDischargeDate.AutoSize = true;
            this.lblDischargeDate.Location = new System.Drawing.Point(315, 435);
            this.lblDischargeDate.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblDischargeDate.Name = "lblDischargeDate";
            this.lblDischargeDate.Size = new System.Drawing.Size(119, 15);
            this.lblDischargeDate.TabIndex = 29;
            this.lblDischargeDate.Text = "Discharge Date";
            this.lblDischargeDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dptInvoiceDate
            // 
            this.dptInvoiceDate.CustomFormat = "dd/MM/yyyy";
            this.dptInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dptInvoiceDate.Location = new System.Drawing.Point(128, 468);
            this.dptInvoiceDate.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.dptInvoiceDate.Name = "dptInvoiceDate";
            this.dptInvoiceDate.Size = new System.Drawing.Size(181, 21);
            this.dptInvoiceDate.TabIndex = 32;
            // 
            // dtpDischargDate
            // 
            this.dtpDischargDate.CustomFormat = "dd/MM/yyyy";
            this.dtpDischargDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDischargDate.Location = new System.Drawing.Point(440, 435);
            this.dtpDischargDate.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.dtpDischargDate.Name = "dtpDischargDate";
            this.dtpDischargDate.Size = new System.Drawing.Size(181, 21);
            this.dtpDischargDate.TabIndex = 30;
            // 
            // lblInvoiceDate
            // 
            this.lblInvoiceDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInvoiceDate.AutoSize = true;
            this.lblInvoiceDate.Location = new System.Drawing.Point(3, 468);
            this.lblInvoiceDate.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblInvoiceDate.Name = "lblInvoiceDate";
            this.lblInvoiceDate.Size = new System.Drawing.Size(119, 15);
            this.lblInvoiceDate.TabIndex = 31;
            this.lblInvoiceDate.Text = "Invoice Date";
            this.lblInvoiceDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblOperation
            // 
            this.lblOperation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOperation.AutoSize = true;
            this.lblOperation.Location = new System.Drawing.Point(373, 333);
            this.lblOperation.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblOperation.Name = "lblOperation";
            this.lblOperation.Size = new System.Drawing.Size(61, 15);
            this.lblOperation.TabIndex = 37;
            this.lblOperation.Text = "Operation";
            // 
            // txtOperation
            // 
            this.txtOperation.Location = new System.Drawing.Point(440, 333);
            this.txtOperation.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtOperation.Name = "txtOperation";
            this.txtOperation.Size = new System.Drawing.Size(182, 21);
            this.txtOperation.TabIndex = 38;
            // 
            // lbTreatment
            // 
            this.lbTreatment.FormattingEnabled = true;
            this.lbTreatment.Location = new System.Drawing.Point(128, 330);
            this.lbTreatment.Name = "lbTreatment";
            this.lbTreatment.Size = new System.Drawing.Size(153, 84);
            this.lbTreatment.TabIndex = 39;
            // 
            // PatientForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 637);
            this.Controls.Add(this.tlpPatient);
            this.Name = "PatientForm";
            this.Text = "PatientForm";
            this.Controls.SetChildIndex(this.tlpPatient, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.lineAction, 0);
            this.tlpPatient.ResumeLayout(false);
            this.tlpPatient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupReferredDoctorShare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupAge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPatient;
        private System.Windows.Forms.NumericUpDown nupReferredDoctorShare;
        private System.Windows.Forms.Label lblReferredDoctorShare;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblPhoneNo;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.NumericUpDown nupAge;
        private System.Windows.Forms.Label lblCityTown;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblAdmitedDate;
        private System.Windows.Forms.DateTimePicker dtpAdmitedDate;
        private System.Windows.Forms.Label lblAdmitedTime;
        private System.Windows.Forms.Label lblRefferedDoctor;
        private System.Windows.Forms.Label lblWards;
        private System.Windows.Forms.ComboBox cmbWards;
        private System.Windows.Forms.Label lblRoomNo;
        private System.Windows.Forms.ComboBox cmbRoomBedNo;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.ComboBox cmbAdmitedTime;
        private System.Windows.Forms.ComboBox cmbReferredDoctor;
        private System.Windows.Forms.CheckBox chkDischarge;
        private System.Windows.Forms.Label lblDischargeDate;
        private System.Windows.Forms.DateTimePicker dtpDischargDate;
        private System.Windows.Forms.Label lblInvoiceDate;
        private System.Windows.Forms.DateTimePicker dptInvoiceDate;
        private System.Windows.Forms.Label lblTreatment;
        private System.Windows.Forms.Label lblOperation;
        private System.Windows.Forms.TextBox txtOperation;
        private System.Windows.Forms.CheckedListBox lbTreatment;
    }
}