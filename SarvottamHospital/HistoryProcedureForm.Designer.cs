namespace SarvottamHospital
{
    partial class HistoryProcedureForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tspToolbar = new System.Windows.Forms.ToolStrip();
            this.tsbOpen = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblChiefComplain = new System.Windows.Forms.Label();
            this.lblProblemSince = new System.Windows.Forms.Label();
            this.lblAssociateComplain = new System.Windows.Forms.Label();
            this.lblAssociateComplainDuration = new System.Windows.Forms.Label();
            this.lblHistoryOfProblem = new System.Windows.Forms.Label();
            this.lblFamilyHistory = new System.Windows.Forms.Label();
            this.lblFamilyHistoryDuration = new System.Windows.Forms.Label();
            this.txtProblemSince = new System.Windows.Forms.TextBox();
            this.txtAssociateComplainDuration = new System.Windows.Forms.TextBox();
            this.txtFamilyHistory = new System.Windows.Forms.TextBox();
            this.txtFamilyHistoryDuration = new System.Windows.Forms.TextBox();
            this.dtpHistoryDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddNewChiefComplain = new System.Windows.Forms.Button();
            this.btnAddNewAssociateComplain = new System.Windows.Forms.Button();
            this.btnAddNewHistory = new System.Windows.Forms.Button();
            this.cmbChiefComplain = new System.Windows.Forms.CheckedListBox();
            this.cmbAssociateComplain = new System.Windows.Forms.CheckedListBox();
            this.cmbHistoryOfProblem = new System.Windows.Forms.CheckedListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvHistoryData = new System.Windows.Forms.DataGridView();
            this.clmChiefComplain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProblemSince = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAssociateComplain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAssociateComplainDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHistoryOfProblem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFamilyHistory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFamilyHistoryDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tspToolbar.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoryData)).BeginInit();
            this.SuspendLayout();
            // 
            // lineAction
            // 
            this.lineAction.Location = new System.Drawing.Point(0, 667);
            this.lineAction.Size = new System.Drawing.Size(1136, 2);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1044, 677);
            this.btnCancel.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(958, 677);
            this.btnSave.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 677);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.30131F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.69869F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 364F));
            this.tableLayoutPanel1.Controls.Add(this.tspToolbar, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.lblDate, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblChiefComplain, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblProblemSince, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblAssociateComplain, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblAssociateComplainDuration, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblHistoryOfProblem, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblFamilyHistory, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblFamilyHistoryDuration, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtProblemSince, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtAssociateComplainDuration, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtFamilyHistory, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtFamilyHistoryDuration, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.dtpHistoryDate, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.btnAddNewChiefComplain, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAddNewAssociateComplain, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnAddNewHistory, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.cmbChiefComplain, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbAssociateComplain, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbHistoryOfProblem, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(51, 51);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1060, 497);
            this.tableLayoutPanel1.TabIndex = 109;
            // 
            // tspToolbar
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tspToolbar, 7);
            this.tspToolbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tspToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOpen,
            this.tsbDelete});
            this.tspToolbar.Location = new System.Drawing.Point(0, 472);
            this.tspToolbar.Name = "tspToolbar";
            this.tspToolbar.Size = new System.Drawing.Size(1060, 25);
            this.tspToolbar.TabIndex = 44;
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
            this.tsbDelete.Image = global::SarvottamHospital.Properties.Resources.Delete;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(60, 22);
            this.tsbDelete.Text = "&Delete";
            this.tsbDelete.Visible = false;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(3, 434);
            this.lblDate.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(171, 15);
            this.lblDate.TabIndex = 8;
            this.lblDate.Text = "Date";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblChiefComplain
            // 
            this.lblChiefComplain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblChiefComplain.AutoSize = true;
            this.lblChiefComplain.Location = new System.Drawing.Point(3, 6);
            this.lblChiefComplain.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblChiefComplain.Name = "lblChiefComplain";
            this.lblChiefComplain.Size = new System.Drawing.Size(171, 15);
            this.lblChiefComplain.TabIndex = 1;
            this.lblChiefComplain.Text = "Chief Complain";
            this.lblChiefComplain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblProblemSince
            // 
            this.lblProblemSince.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProblemSince.AutoSize = true;
            this.lblProblemSince.Location = new System.Drawing.Point(3, 89);
            this.lblProblemSince.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblProblemSince.Name = "lblProblemSince";
            this.lblProblemSince.Size = new System.Drawing.Size(171, 15);
            this.lblProblemSince.TabIndex = 2;
            this.lblProblemSince.Text = "Problem Since";
            this.lblProblemSince.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAssociateComplain
            // 
            this.lblAssociateComplain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAssociateComplain.AutoSize = true;
            this.lblAssociateComplain.Location = new System.Drawing.Point(3, 126);
            this.lblAssociateComplain.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblAssociateComplain.Name = "lblAssociateComplain";
            this.lblAssociateComplain.Size = new System.Drawing.Size(171, 15);
            this.lblAssociateComplain.TabIndex = 3;
            this.lblAssociateComplain.Text = "Associate Complain";
            this.lblAssociateComplain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAssociateComplainDuration
            // 
            this.lblAssociateComplainDuration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAssociateComplainDuration.AutoSize = true;
            this.lblAssociateComplainDuration.Location = new System.Drawing.Point(3, 203);
            this.lblAssociateComplainDuration.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblAssociateComplainDuration.Name = "lblAssociateComplainDuration";
            this.lblAssociateComplainDuration.Size = new System.Drawing.Size(171, 15);
            this.lblAssociateComplainDuration.TabIndex = 4;
            this.lblAssociateComplainDuration.Text = "Associate Complain Duration";
            this.lblAssociateComplainDuration.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHistoryOfProblem
            // 
            this.lblHistoryOfProblem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHistoryOfProblem.AutoSize = true;
            this.lblHistoryOfProblem.Location = new System.Drawing.Point(3, 244);
            this.lblHistoryOfProblem.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblHistoryOfProblem.Name = "lblHistoryOfProblem";
            this.lblHistoryOfProblem.Size = new System.Drawing.Size(171, 15);
            this.lblHistoryOfProblem.TabIndex = 5;
            this.lblHistoryOfProblem.Text = "History Of Problem";
            this.lblHistoryOfProblem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFamilyHistory
            // 
            this.lblFamilyHistory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFamilyHistory.AutoSize = true;
            this.lblFamilyHistory.Location = new System.Drawing.Point(3, 319);
            this.lblFamilyHistory.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblFamilyHistory.Name = "lblFamilyHistory";
            this.lblFamilyHistory.Size = new System.Drawing.Size(171, 15);
            this.lblFamilyHistory.TabIndex = 6;
            this.lblFamilyHistory.Text = "Family History";
            this.lblFamilyHistory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFamilyHistoryDuration
            // 
            this.lblFamilyHistoryDuration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFamilyHistoryDuration.AutoSize = true;
            this.lblFamilyHistoryDuration.Location = new System.Drawing.Point(3, 399);
            this.lblFamilyHistoryDuration.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblFamilyHistoryDuration.Name = "lblFamilyHistoryDuration";
            this.lblFamilyHistoryDuration.Size = new System.Drawing.Size(171, 15);
            this.lblFamilyHistoryDuration.TabIndex = 7;
            this.lblFamilyHistoryDuration.Text = "Family History Duration ";
            this.lblFamilyHistoryDuration.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtProblemSince
            // 
            this.txtProblemSince.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProblemSince.Location = new System.Drawing.Point(180, 89);
            this.txtProblemSince.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtProblemSince.MaxLength = 25;
            this.txtProblemSince.Name = "txtProblemSince";
            this.txtProblemSince.Size = new System.Drawing.Size(268, 21);
            this.txtProblemSince.TabIndex = 1;
            // 
            // txtAssociateComplainDuration
            // 
            this.txtAssociateComplainDuration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAssociateComplainDuration.Location = new System.Drawing.Point(180, 203);
            this.txtAssociateComplainDuration.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtAssociateComplainDuration.MaxLength = 25;
            this.txtAssociateComplainDuration.Name = "txtAssociateComplainDuration";
            this.txtAssociateComplainDuration.Size = new System.Drawing.Size(268, 21);
            this.txtAssociateComplainDuration.TabIndex = 3;
            // 
            // txtFamilyHistory
            // 
            this.txtFamilyHistory.Location = new System.Drawing.Point(180, 316);
            this.txtFamilyHistory.Multiline = true;
            this.txtFamilyHistory.Name = "txtFamilyHistory";
            this.txtFamilyHistory.Size = new System.Drawing.Size(268, 74);
            this.txtFamilyHistory.TabIndex = 5;
            // 
            // txtFamilyHistoryDuration
            // 
            this.txtFamilyHistoryDuration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFamilyHistoryDuration.Location = new System.Drawing.Point(180, 399);
            this.txtFamilyHistoryDuration.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtFamilyHistoryDuration.MaxLength = 25;
            this.txtFamilyHistoryDuration.Name = "txtFamilyHistoryDuration";
            this.txtFamilyHistoryDuration.Size = new System.Drawing.Size(268, 21);
            this.txtFamilyHistoryDuration.TabIndex = 6;
            // 
            // dtpHistoryDate
            // 
            this.dtpHistoryDate.CustomFormat = "dd/MM/yyyy";
            this.dtpHistoryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHistoryDate.Location = new System.Drawing.Point(180, 434);
            this.dtpHistoryDate.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.dtpHistoryDate.Name = "dtpHistoryDate";
            this.dtpHistoryDate.Size = new System.Drawing.Size(142, 21);
            this.dtpHistoryDate.TabIndex = 7;
            // 
            // btnAddNewChiefComplain
            // 
            this.btnAddNewChiefComplain.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddNewChiefComplain.Image = global::SarvottamHospital.Properties.Resources.Add;
            this.btnAddNewChiefComplain.Location = new System.Drawing.Point(454, 3);
            this.btnAddNewChiefComplain.Name = "btnAddNewChiefComplain";
            this.btnAddNewChiefComplain.Size = new System.Drawing.Size(91, 26);
            this.btnAddNewChiefComplain.TabIndex = 8;
            this.btnAddNewChiefComplain.Text = "&Add ";
            this.btnAddNewChiefComplain.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddNewChiefComplain.UseVisualStyleBackColor = true;
            // 
            // btnAddNewAssociateComplain
            // 
            this.btnAddNewAssociateComplain.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddNewAssociateComplain.Image = global::SarvottamHospital.Properties.Resources.Add;
            this.btnAddNewAssociateComplain.Location = new System.Drawing.Point(454, 123);
            this.btnAddNewAssociateComplain.Name = "btnAddNewAssociateComplain";
            this.btnAddNewAssociateComplain.Size = new System.Drawing.Size(91, 26);
            this.btnAddNewAssociateComplain.TabIndex = 9;
            this.btnAddNewAssociateComplain.Text = "&Add";
            this.btnAddNewAssociateComplain.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddNewAssociateComplain.UseVisualStyleBackColor = true;
            // 
            // btnAddNewHistory
            // 
            this.btnAddNewHistory.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddNewHistory.Image = global::SarvottamHospital.Properties.Resources.Add;
            this.btnAddNewHistory.Location = new System.Drawing.Point(454, 241);
            this.btnAddNewHistory.Name = "btnAddNewHistory";
            this.btnAddNewHistory.Size = new System.Drawing.Size(91, 26);
            this.btnAddNewHistory.TabIndex = 10;
            this.btnAddNewHistory.Text = "&Add ";
            this.btnAddNewHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddNewHistory.UseVisualStyleBackColor = true;
            // 
            // cmbChiefComplain
            // 
            this.cmbChiefComplain.FormattingEnabled = true;
            this.cmbChiefComplain.Location = new System.Drawing.Point(180, 3);
            this.cmbChiefComplain.Name = "cmbChiefComplain";
            this.cmbChiefComplain.Size = new System.Drawing.Size(268, 68);
            this.cmbChiefComplain.Sorted = true;
            this.cmbChiefComplain.TabIndex = 0;
            // 
            // cmbAssociateComplain
            // 
            this.cmbAssociateComplain.FormattingEnabled = true;
            this.cmbAssociateComplain.Location = new System.Drawing.Point(180, 123);
            this.cmbAssociateComplain.Name = "cmbAssociateComplain";
            this.cmbAssociateComplain.Size = new System.Drawing.Size(268, 68);
            this.cmbAssociateComplain.Sorted = true;
            this.cmbAssociateComplain.TabIndex = 2;
            // 
            // cmbHistoryOfProblem
            // 
            this.cmbHistoryOfProblem.FormattingEnabled = true;
            this.cmbHistoryOfProblem.Location = new System.Drawing.Point(180, 241);
            this.cmbHistoryOfProblem.Name = "cmbHistoryOfProblem";
            this.cmbHistoryOfProblem.Size = new System.Drawing.Size(268, 68);
            this.cmbHistoryOfProblem.Sorted = true;
            this.cmbHistoryOfProblem.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.dgvHistoryData, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(51, 551);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1060, 118);
            this.tableLayoutPanel2.TabIndex = 110;
            // 
            // dgvHistoryData
            // 
            this.dgvHistoryData.AllowUserToAddRows = false;
            this.dgvHistoryData.AllowUserToDeleteRows = false;
            this.dgvHistoryData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistoryData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmChiefComplain,
            this.clmProblemSince,
            this.clmAssociateComplain,
            this.clmAssociateComplainDuration,
            this.clmHistoryOfProblem,
            this.clmFamilyHistory,
            this.clmFamilyHistoryDuration,
            this.clmDate});
            this.dgvHistoryData.Location = new System.Drawing.Point(3, 3);
            this.dgvHistoryData.Name = "dgvHistoryData";
            this.dgvHistoryData.ReadOnly = true;
            this.dgvHistoryData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistoryData.Size = new System.Drawing.Size(1054, 110);
            this.dgvHistoryData.TabIndex = 0;
            // 
            // clmChiefComplain
            // 
            this.clmChiefComplain.HeaderText = "Chief Complain";
            this.clmChiefComplain.Name = "clmChiefComplain";
            this.clmChiefComplain.ReadOnly = true;
            this.clmChiefComplain.Width = 150;
            // 
            // clmProblemSince
            // 
            this.clmProblemSince.HeaderText = "Problem Since";
            this.clmProblemSince.Name = "clmProblemSince";
            this.clmProblemSince.ReadOnly = true;
            // 
            // clmAssociateComplain
            // 
            this.clmAssociateComplain.HeaderText = "Associate Complain";
            this.clmAssociateComplain.Name = "clmAssociateComplain";
            this.clmAssociateComplain.ReadOnly = true;
            this.clmAssociateComplain.Width = 150;
            // 
            // clmAssociateComplainDuration
            // 
            this.clmAssociateComplainDuration.HeaderText = "Associate Complain Duration";
            this.clmAssociateComplainDuration.Name = "clmAssociateComplainDuration";
            this.clmAssociateComplainDuration.ReadOnly = true;
            this.clmAssociateComplainDuration.Width = 150;
            // 
            // clmHistoryOfProblem
            // 
            this.clmHistoryOfProblem.HeaderText = "History Of Problem";
            this.clmHistoryOfProblem.Name = "clmHistoryOfProblem";
            this.clmHistoryOfProblem.ReadOnly = true;
            this.clmHistoryOfProblem.Width = 150;
            // 
            // clmFamilyHistory
            // 
            this.clmFamilyHistory.HeaderText = "Family History";
            this.clmFamilyHistory.Name = "clmFamilyHistory";
            this.clmFamilyHistory.ReadOnly = true;
            this.clmFamilyHistory.Width = 150;
            // 
            // clmFamilyHistoryDuration
            // 
            this.clmFamilyHistoryDuration.HeaderText = "Family History Duration";
            this.clmFamilyHistoryDuration.Name = "clmFamilyHistoryDuration";
            this.clmFamilyHistoryDuration.ReadOnly = true;
            this.clmFamilyHistoryDuration.Width = 150;
            // 
            // clmDate
            // 
            this.clmDate.HeaderText = "Date";
            this.clmDate.Name = "clmDate";
            this.clmDate.ReadOnly = true;
            // 
            // HistoryProcedureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 707);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "HistoryProcedureForm";
            this.Text = "HistoryProcedureForm";
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.tableLayoutPanel2, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.lineAction, 0);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tspToolbar.ResumeLayout(false);
            this.tspToolbar.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoryData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblChiefComplain;
        private System.Windows.Forms.Label lblProblemSince;
        private System.Windows.Forms.Label lblAssociateComplain;
        private System.Windows.Forms.Label lblAssociateComplainDuration;
        private System.Windows.Forms.Label lblHistoryOfProblem;
        private System.Windows.Forms.Label lblFamilyHistory;
        private System.Windows.Forms.Label lblFamilyHistoryDuration;
        private System.Windows.Forms.TextBox txtProblemSince;
        private System.Windows.Forms.TextBox txtAssociateComplainDuration;
        private System.Windows.Forms.TextBox txtFamilyHistory;
        private System.Windows.Forms.TextBox txtFamilyHistoryDuration;
        private System.Windows.Forms.DateTimePicker dtpHistoryDate;
        private System.Windows.Forms.Button btnAddNewChiefComplain;
        private System.Windows.Forms.Button btnAddNewAssociateComplain;
        private System.Windows.Forms.Button btnAddNewHistory;
        private System.Windows.Forms.CheckedListBox cmbChiefComplain;
        private System.Windows.Forms.CheckedListBox cmbAssociateComplain;
        private System.Windows.Forms.CheckedListBox cmbHistoryOfProblem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dgvHistoryData;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmChiefComplain;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProblemSince;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAssociateComplain;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAssociateComplainDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHistoryOfProblem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFamilyHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFamilyHistoryDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDate;
        private System.Windows.Forms.ToolStrip tspToolbar;
        private System.Windows.Forms.ToolStripButton tsbOpen;
        private System.Windows.Forms.ToolStripButton tsbDelete;
    }
}