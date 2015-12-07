namespace SarvottamHospital
{
    partial class PatientProcedureForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tspToolbar = new System.Windows.Forms.ToolStrip();
            this.tsbOpen = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.tblBillTotal = new System.Windows.Forms.TableLayoutPanel();
            this.lblBalanceToCollect = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblBalanceToCollectValue = new System.Windows.Forms.Label();
            this.lblTotalAmountValue = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.clmProcedureDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProcedure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpAdmitedDate = new System.Windows.Forms.DateTimePicker();
            this.lblAdmitedDate = new System.Windows.Forms.Label();
            this.lblProcedureDate = new System.Windows.Forms.Label();
            this.dtpProcedureDate = new System.Windows.Forms.DateTimePicker();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.btnChild = new System.Windows.Forms.Button();
            this.lblAssignDoctor = new System.Windows.Forms.Label();
            this.lblProcedure = new System.Windows.Forms.Label();
            this.cmbProcedure = new System.Windows.Forms.ComboBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.nupAmount = new System.Windows.Forms.NumericUpDown();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.btnGenerateBill = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tspToolbar.SuspendLayout();
            this.tblBillTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // lineAction
            // 
            this.lineAction.Location = new System.Drawing.Point(0, 506);
            this.lineAction.Size = new System.Drawing.Size(1000, 2);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(902, 515);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(902, 233);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(6, 515);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Controls.Add(this.tspToolbar, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.lblLastName, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtMiddleName, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblMiddleName, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtFirstName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFirstName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tblBillTotal, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.dgvData, 2, 11);
            this.tableLayoutPanel1.Controls.Add(this.dtpAdmitedDate, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblAdmitedDate, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblProcedureDate, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtpProcedureDate, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtLastName, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnChild, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblAssignDoctor, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblProcedure, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cmbProcedure, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblAmount, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.nupAmount, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblNotes, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.txtNotes, 1, 9);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 51);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 14;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(988, 446);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tspToolbar
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tspToolbar, 7);
            this.tspToolbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tspToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOpen,
            this.tsbDelete});
            this.tspToolbar.Location = new System.Drawing.Point(0, 182);
            this.tspToolbar.Name = "tspToolbar";
            this.tspToolbar.Size = new System.Drawing.Size(1019, 25);
            this.tspToolbar.TabIndex = 27;
            this.tspToolbar.Text = "toolStrip1";
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
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(44, 22);
            this.tsbDelete.Text = "&Delete";
            this.tsbDelete.Visible = false;
            // 
            // lblLastName
            // 
            this.lblLastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(660, 6);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(68, 15);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Last Name";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMiddleName.Enabled = false;
            this.txtMiddleName.Location = new System.Drawing.Point(405, 6);
            this.txtMiddleName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(249, 21);
            this.txtMiddleName.TabIndex = 3;
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Location = new System.Drawing.Point(306, 6);
            this.lblMiddleName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(93, 15);
            this.lblMiddleName.TabIndex = 2;
            this.lblMiddleName.Text = "Middle Name";
            this.lblMiddleName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFirstName.Enabled = false;
            this.txtFirstName.Location = new System.Drawing.Point(90, 6);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(210, 21);
            this.txtFirstName.TabIndex = 1;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(3, 6);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(81, 15);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tblBillTotal
            // 
            this.tblBillTotal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tblBillTotal.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblBillTotal.ColumnCount = 3;
            this.tableLayoutPanel1.SetColumnSpan(this.tblBillTotal, 7);
            this.tblBillTotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblBillTotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblBillTotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblBillTotal.Controls.Add(this.lblBalanceToCollect, 1, 1);
            this.tblBillTotal.Controls.Add(this.lblTotalAmount, 1, 0);
            this.tblBillTotal.Controls.Add(this.lblBalanceToCollectValue, 2, 1);
            this.tblBillTotal.Controls.Add(this.lblTotalAmountValue, 2, 0);
            this.tblBillTotal.Location = new System.Drawing.Point(3, 382);
            this.tblBillTotal.Name = "tblBillTotal";
            this.tblBillTotal.RowCount = 2;
            this.tblBillTotal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblBillTotal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblBillTotal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblBillTotal.Size = new System.Drawing.Size(964, 59);
            this.tblBillTotal.TabIndex = 28;
            // 
            // lblBalanceToCollect
            // 
            this.lblBalanceToCollect.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblBalanceToCollect.AutoSize = true;
            this.lblBalanceToCollect.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceToCollect.Location = new System.Drawing.Point(658, 36);
            this.lblBalanceToCollect.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblBalanceToCollect.Name = "lblBalanceToCollect";
            this.lblBalanceToCollect.Size = new System.Drawing.Size(61, 15);
            this.lblBalanceToCollect.TabIndex = 4;
            this.lblBalanceToCollect.Text = "To Collect";
            this.lblBalanceToCollect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(642, 7);
            this.lblTotalAmount.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(77, 15);
            this.lblTotalAmount.TabIndex = 0;
            this.lblTotalAmount.Text = "Total Amount";
            this.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBalanceToCollectValue
            // 
            this.lblBalanceToCollectValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBalanceToCollectValue.AutoSize = true;
            this.lblBalanceToCollectValue.Location = new System.Drawing.Point(919, 35);
            this.lblBalanceToCollectValue.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblBalanceToCollectValue.Name = "lblBalanceToCollectValue";
            this.lblBalanceToCollectValue.Size = new System.Drawing.Size(41, 15);
            this.lblBalanceToCollectValue.TabIndex = 5;
            this.lblBalanceToCollectValue.Text = "label1";
            this.lblBalanceToCollectValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalAmountValue
            // 
            this.lblTotalAmountValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalAmountValue.AutoSize = true;
            this.lblTotalAmountValue.Location = new System.Drawing.Point(919, 7);
            this.lblTotalAmountValue.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblTotalAmountValue.Name = "lblTotalAmountValue";
            this.lblTotalAmountValue.Size = new System.Drawing.Size(41, 15);
            this.lblTotalAmountValue.TabIndex = 1;
            this.lblTotalAmountValue.Text = "label1";
            this.lblTotalAmountValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmProcedureDate,
            this.clmProcedure,
            this.clmAmount,
            this.clmNotes,
            this.clmFill});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvData, 7);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvData.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvData.Location = new System.Drawing.Point(3, 210);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(973, 166);
            this.dgvData.StandardTab = true;
            this.dgvData.TabIndex = 26;
            this.dgvData.TabStop = false;
            // 
            // clmProcedureDate
            // 
            this.clmProcedureDate.HeaderText = "Date";
            this.clmProcedureDate.Name = "clmProcedureDate";
            this.clmProcedureDate.ReadOnly = true;
            this.clmProcedureDate.Width = 200;
            // 
            // clmProcedure
            // 
            this.clmProcedure.HeaderText = "Procedure";
            this.clmProcedure.Name = "clmProcedure";
            this.clmProcedure.ReadOnly = true;
            this.clmProcedure.Width = 400;
            // 
            // clmAmount
            // 
            this.clmAmount.HeaderText = "Amount";
            this.clmAmount.Name = "clmAmount";
            this.clmAmount.ReadOnly = true;
            // 
            // clmNotes
            // 
            this.clmNotes.HeaderText = "Notes";
            this.clmNotes.Name = "clmNotes";
            this.clmNotes.ReadOnly = true;
            this.clmNotes.Width = 200;
            // 
            // clmFill
            // 
            this.clmFill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmFill.HeaderText = "";
            this.clmFill.Name = "clmFill";
            this.clmFill.ReadOnly = true;
            this.clmFill.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dtpAdmitedDate
            // 
            this.dtpAdmitedDate.CustomFormat = "dd/MM/yyyy";
            this.dtpAdmitedDate.Enabled = false;
            this.dtpAdmitedDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAdmitedDate.Location = new System.Drawing.Point(90, 39);
            this.dtpAdmitedDate.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.dtpAdmitedDate.Name = "dtpAdmitedDate";
            this.dtpAdmitedDate.Size = new System.Drawing.Size(210, 21);
            this.dtpAdmitedDate.TabIndex = 7;
            // 
            // lblAdmitedDate
            // 
            this.lblAdmitedDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAdmitedDate.AutoSize = true;
            this.lblAdmitedDate.Location = new System.Drawing.Point(3, 39);
            this.lblAdmitedDate.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblAdmitedDate.Name = "lblAdmitedDate";
            this.lblAdmitedDate.Size = new System.Drawing.Size(81, 15);
            this.lblAdmitedDate.TabIndex = 6;
            this.lblAdmitedDate.Text = "Admited Date";
            this.lblAdmitedDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblProcedureDate
            // 
            this.lblProcedureDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProcedureDate.AutoSize = true;
            this.lblProcedureDate.Location = new System.Drawing.Point(306, 39);
            this.lblProcedureDate.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblProcedureDate.Name = "lblProcedureDate";
            this.lblProcedureDate.Size = new System.Drawing.Size(93, 15);
            this.lblProcedureDate.TabIndex = 8;
            this.lblProcedureDate.Text = "Procedure Date";
            this.lblProcedureDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpProcedureDate
            // 
            this.dtpProcedureDate.CustomFormat = "dd/MM/yyyy";
            this.dtpProcedureDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpProcedureDate.Location = new System.Drawing.Point(405, 39);
            this.dtpProcedureDate.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.dtpProcedureDate.Name = "dtpProcedureDate";
            this.dtpProcedureDate.Size = new System.Drawing.Size(142, 21);
            this.dtpProcedureDate.TabIndex = 9;
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLastName.Enabled = false;
            this.txtLastName.Location = new System.Drawing.Point(734, 6);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(202, 21);
            this.txtLastName.TabIndex = 5;
            // 
            // btnChild
            // 
            this.btnChild.Location = new System.Drawing.Point(942, 69);
            this.btnChild.Name = "btnChild";
            this.btnChild.Size = new System.Drawing.Size(23, 26);
            this.btnChild.TabIndex = 26;
            this.btnChild.TabStop = false;
            this.btnChild.UseVisualStyleBackColor = true;
            this.btnChild.Visible = false;
            // 
            // lblAssignDoctor
            // 
            this.lblAssignDoctor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAssignDoctor.AutoSize = true;
            this.lblAssignDoctor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssignDoctor.Location = new System.Drawing.Point(734, 39);
            this.lblAssignDoctor.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblAssignDoctor.Name = "lblAssignDoctor";
            this.lblAssignDoctor.Size = new System.Drawing.Size(202, 18);
            this.lblAssignDoctor.TabIndex = 29;
            this.lblAssignDoctor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProcedure
            // 
            this.lblProcedure.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProcedure.AutoSize = true;
            this.lblProcedure.Location = new System.Drawing.Point(3, 72);
            this.lblProcedure.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblProcedure.Name = "lblProcedure";
            this.lblProcedure.Size = new System.Drawing.Size(81, 15);
            this.lblProcedure.TabIndex = 14;
            this.lblProcedure.Text = "Procedure";
            this.lblProcedure.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbProcedure
            // 
            this.cmbProcedure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProcedure.FormattingEnabled = true;
            this.cmbProcedure.Location = new System.Drawing.Point(90, 72);
            this.cmbProcedure.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.cmbProcedure.Name = "cmbProcedure";
            this.cmbProcedure.Size = new System.Drawing.Size(200, 23);
            this.cmbProcedure.Sorted = true;
            this.cmbProcedure.TabIndex = 15;
            // 
            // lblAmount
            // 
            this.lblAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(306, 72);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(93, 15);
            this.lblAmount.TabIndex = 20;
            this.lblAmount.Text = "Amount";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nupAmount
            // 
            this.nupAmount.Location = new System.Drawing.Point(405, 72);
            this.nupAmount.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.nupAmount.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nupAmount.Minimum = new decimal(new int[] {
            1215752192,
            23,
            0,
            -2147483648});
            this.nupAmount.Name = "nupAmount";
            this.nupAmount.Size = new System.Drawing.Size(120, 21);
            this.nupAmount.TabIndex = 21;
            // 
            // lblNotes
            // 
            this.lblNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(3, 107);
            this.lblNotes.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(81, 15);
            this.lblNotes.TabIndex = 24;
            this.lblNotes.Text = "Notes";
            this.lblNotes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNotes
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtNotes, 4);
            this.txtNotes.Location = new System.Drawing.Point(90, 107);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtNotes.MaxLength = 1000;
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotes.Size = new System.Drawing.Size(529, 69);
            this.txtNotes.TabIndex = 25;
            // 
            // btnGenerateBill
            // 
            this.btnGenerateBill.Image = global::SarvottamHospital.Properties.Resources.PrintIcon;
            this.btnGenerateBill.Location = new System.Drawing.Point(794, 515);
            this.btnGenerateBill.Name = "btnGenerateBill";
            this.btnGenerateBill.Size = new System.Drawing.Size(102, 24);
            this.btnGenerateBill.TabIndex = 109;
            this.btnGenerateBill.Text = "Generate Bill";
            this.btnGenerateBill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenerateBill.UseVisualStyleBackColor = true;
            // 
            // PatientProcedureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 547);
            this.Controls.Add(this.btnGenerateBill);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PatientProcedureForm";
            this.Text = "PatientProcedureForm";
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.lineAction, 0);
            this.Controls.SetChildIndex(this.btnGenerateBill, 0);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tspToolbar.ResumeLayout(false);
            this.tspToolbar.PerformLayout();
            this.tblBillTotal.ResumeLayout(false);
            this.tblBillTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip tspToolbar;
        private System.Windows.Forms.ToolStripButton tsbOpen;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TableLayoutPanel tblBillTotal;
        private System.Windows.Forms.Label lblBalanceToCollect;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblBalanceToCollectValue;
        private System.Windows.Forms.Label lblTotalAmountValue;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.DateTimePicker dtpAdmitedDate;
        private System.Windows.Forms.Label lblAdmitedDate;
        private System.Windows.Forms.Label lblProcedureDate;
        private System.Windows.Forms.DateTimePicker dtpProcedureDate;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.NumericUpDown nupAmount;
        private System.Windows.Forms.ComboBox cmbProcedure;
        private System.Windows.Forms.Button btnChild;
        private System.Windows.Forms.Label lblAssignDoctor;
        private System.Windows.Forms.Label lblProcedure;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProcedureDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProcedure;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFill;
        private System.Windows.Forms.Button btnGenerateBill;


    }
}