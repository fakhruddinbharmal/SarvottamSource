namespace SarvottamHospital
{
    partial class AppointmentForm
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
            this.dtpAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.lblAppointmentDate = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtAppointmentDescription = new System.Windows.Forms.TextBox();
            this.lblAppointmentDescription = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.clmAppointmentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAppointmentDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tspToolbar = new System.Windows.Forms.ToolStrip();
            this.tsbOpen = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.tspToolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lineAction
            // 
            this.lineAction.Location = new System.Drawing.Point(0, 436);
            this.lineAction.Size = new System.Drawing.Size(1030, 2);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(938, 446);
            this.btnCancel.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(852, 446);
            this.btnSave.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 446);
            // 
            // dtpAppointmentDate
            // 
            this.dtpAppointmentDate.CustomFormat = "dd/MM/yyyy";
            this.dtpAppointmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAppointmentDate.Location = new System.Drawing.Point(124, 57);
            this.dtpAppointmentDate.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.dtpAppointmentDate.Name = "dtpAppointmentDate";
            this.dtpAppointmentDate.Size = new System.Drawing.Size(193, 21);
            this.dtpAppointmentDate.TabIndex = 0;
            // 
            // lblAppointmentDate
            // 
            this.lblAppointmentDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAppointmentDate.AutoSize = true;
            this.lblAppointmentDate.Location = new System.Drawing.Point(3, 57);
            this.lblAppointmentDate.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblAppointmentDate.Name = "lblAppointmentDate";
            this.lblAppointmentDate.Size = new System.Drawing.Size(115, 15);
            this.lblAppointmentDate.TabIndex = 2;
            this.lblAppointmentDate.Text = "Appointment Date";
            this.lblAppointmentDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.8125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.1875F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 198F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 204F));
            this.tableLayoutPanel1.Controls.Add(this.txtAppointmentDescription, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblAppointmentDescription, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblFirstName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtFirstName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblMiddleName, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtMiddleName, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblLastName, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtLastName, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtpAppointmentDate, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblAppointmentDate, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(51, 66);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(962, 133);
            this.tableLayoutPanel1.TabIndex = 109;
            // 
            // txtAppointmentDescription
            // 
            this.txtAppointmentDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAppointmentDescription.Location = new System.Drawing.Point(472, 57);
            this.txtAppointmentDescription.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtAppointmentDescription.Multiline = true;
            this.txtAppointmentDescription.Name = "txtAppointmentDescription";
            this.txtAppointmentDescription.Size = new System.Drawing.Size(192, 49);
            this.txtAppointmentDescription.TabIndex = 1;
            // 
            // lblAppointmentDescription
            // 
            this.lblAppointmentDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAppointmentDescription.AutoSize = true;
            this.lblAppointmentDescription.Location = new System.Drawing.Point(323, 57);
            this.lblAppointmentDescription.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblAppointmentDescription.Name = "lblAppointmentDescription";
            this.lblAppointmentDescription.Size = new System.Drawing.Size(143, 15);
            this.lblAppointmentDescription.TabIndex = 15;
            this.lblAppointmentDescription.Text = "Appointment Description";
            this.lblAppointmentDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(3, 6);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(115, 15);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFirstName.Enabled = false;
            this.txtFirstName.Location = new System.Drawing.Point(124, 6);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(193, 21);
            this.txtFirstName.TabIndex = 2;
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Location = new System.Drawing.Point(323, 6);
            this.lblMiddleName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(143, 15);
            this.lblMiddleName.TabIndex = 3;
            this.lblMiddleName.Text = "Middle Name";
            this.lblMiddleName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMiddleName.Enabled = false;
            this.txtMiddleName.Location = new System.Drawing.Point(472, 6);
            this.txtMiddleName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(192, 21);
            this.txtMiddleName.TabIndex = 4;
            // 
            // lblLastName
            // 
            this.lblLastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(670, 6);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(85, 15);
            this.lblLastName.TabIndex = 5;
            this.lblLastName.Text = "Last Name";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLastName.Enabled = false;
            this.txtLastName.Location = new System.Drawing.Point(761, 6);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(198, 21);
            this.txtLastName.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.dgvData, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tspToolbar, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(51, 208);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.04348F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.95652F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(962, 207);
            this.tableLayoutPanel2.TabIndex = 111;
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
            this.clmAppointmentDate,
            this.clmAppointmentDescription,
            this.clmFill});
            this.tableLayoutPanel2.SetColumnSpan(this.dgvData, 7);
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
            this.dgvData.Location = new System.Drawing.Point(3, 30);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(956, 166);
            this.dgvData.StandardTab = true;
            this.dgvData.TabIndex = 112;
            this.dgvData.TabStop = false;
            // 
            // clmAppointmentDate
            // 
            this.clmAppointmentDate.HeaderText = "Appointment Date";
            this.clmAppointmentDate.Name = "clmAppointmentDate";
            this.clmAppointmentDate.ReadOnly = true;
            this.clmAppointmentDate.Width = 400;
            // 
            // clmAppointmentDescription
            // 
            this.clmAppointmentDescription.HeaderText = "AppointmentDescription";
            this.clmAppointmentDescription.Name = "clmAppointmentDescription";
            this.clmAppointmentDescription.ReadOnly = true;
            this.clmAppointmentDescription.Width = 400;
            // 
            // clmFill
            // 
            this.clmFill.HeaderText = "";
            this.clmFill.Name = "clmFill";
            this.clmFill.ReadOnly = true;
            this.clmFill.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmFill.Width = 300;
            // 
            // tspToolbar
            // 
            this.tspToolbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tspToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOpen,
            this.tsbDelete});
            this.tspToolbar.Location = new System.Drawing.Point(0, 2);
            this.tspToolbar.Name = "tspToolbar";
            this.tspToolbar.Size = new System.Drawing.Size(962, 25);
            this.tspToolbar.TabIndex = 111;
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
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 476);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AppointmentForm";
            this.Text = "AppointmentForm";
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.tableLayoutPanel2, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.lineAction, 0);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.tspToolbar.ResumeLayout(false);
            this.tspToolbar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAppointmentDate;
        private System.Windows.Forms.DateTimePicker dtpAppointmentDate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblAppointmentDescription;
        private System.Windows.Forms.TextBox txtAppointmentDescription;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.ToolStrip tspToolbar;
        private System.Windows.Forms.ToolStripButton tsbOpen;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAppointmentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAppointmentDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFill;
    }
}