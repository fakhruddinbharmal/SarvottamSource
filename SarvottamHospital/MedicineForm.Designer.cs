namespace SarvottamHospital
{
    partial class MedicineForm
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
            this.tlpUserRole = new System.Windows.Forms.TableLayoutPanel();
            this.txtMedicine = new System.Windows.Forms.TextBox();
            this.lblChiefComplain = new System.Windows.Forms.Label();
            this.lblMedicine = new System.Windows.Forms.Label();
            this.cmbChiefComplain = new System.Windows.Forms.ComboBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.tlpUserRole.SuspendLayout();
            this.SuspendLayout();
            // 
            // lineAction
            // 
            this.lineAction.Location = new System.Drawing.Point(0, 304);
            this.lineAction.Size = new System.Drawing.Size(587, 2);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(495, 314);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(409, 314);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 314);
            // 
            // tlpUserRole
            // 
            this.tlpUserRole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpUserRole.ColumnCount = 3;
            this.tlpUserRole.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpUserRole.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpUserRole.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 535F));
            this.tlpUserRole.Controls.Add(this.txtMedicine, 1, 1);
            this.tlpUserRole.Controls.Add(this.lblChiefComplain, 0, 0);
            this.tlpUserRole.Controls.Add(this.lblMedicine, 0, 1);
            this.tlpUserRole.Controls.Add(this.cmbChiefComplain, 1, 0);
            this.tlpUserRole.Controls.Add(this.lblDescription, 0, 2);
            this.tlpUserRole.Controls.Add(this.txtDescription, 1, 2);
            this.tlpUserRole.Location = new System.Drawing.Point(51, 54);
            this.tlpUserRole.Name = "tlpUserRole";
            this.tlpUserRole.RowCount = 3;
            this.tlpUserRole.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpUserRole.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpUserRole.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpUserRole.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpUserRole.Size = new System.Drawing.Size(510, 247);
            this.tlpUserRole.TabIndex = 110;
            // 
            // txtMedicine
            // 
            this.txtMedicine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMedicine.Location = new System.Drawing.Point(123, 41);
            this.txtMedicine.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtMedicine.MaxLength = 25;
            this.txtMedicine.Name = "txtMedicine";
            this.txtMedicine.Size = new System.Drawing.Size(387, 21);
            this.txtMedicine.TabIndex = 3;
            // 
            // lblChiefComplain
            // 
            this.lblChiefComplain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblChiefComplain.AutoSize = true;
            this.lblChiefComplain.Location = new System.Drawing.Point(3, 6);
            this.lblChiefComplain.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblChiefComplain.Name = "lblChiefComplain";
            this.lblChiefComplain.Size = new System.Drawing.Size(114, 15);
            this.lblChiefComplain.TabIndex = 0;
            this.lblChiefComplain.Text = "ChiefComplain";
            this.lblChiefComplain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMedicine
            // 
            this.lblMedicine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMedicine.AutoSize = true;
            this.lblMedicine.Location = new System.Drawing.Point(3, 41);
            this.lblMedicine.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblMedicine.Name = "lblMedicine";
            this.lblMedicine.Size = new System.Drawing.Size(114, 15);
            this.lblMedicine.TabIndex = 2;
            this.lblMedicine.Text = "Medicine";
            this.lblMedicine.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbChiefComplain
            // 
            this.cmbChiefComplain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbChiefComplain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChiefComplain.DropDownWidth = 200;
            this.cmbChiefComplain.FormattingEnabled = true;
            this.cmbChiefComplain.Items.AddRange(new object[] {
            "Private",
            "SemiPrivate",
            "StandardWard"});
            this.cmbChiefComplain.Location = new System.Drawing.Point(123, 6);
            this.cmbChiefComplain.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.cmbChiefComplain.Name = "cmbChiefComplain";
            this.cmbChiefComplain.Size = new System.Drawing.Size(387, 23);
            this.cmbChiefComplain.Sorted = true;
            this.cmbChiefComplain.TabIndex = 1;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(3, 74);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(114, 45);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = " Description\r\n(Press Ctl+Enter for New line)";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDescription
            // 
            this.txtDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescription.Location = new System.Drawing.Point(123, 74);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtDescription.MaxLength = 1000;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(387, 167);
            this.txtDescription.TabIndex = 5;
            // 
            // MedicineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 344);
            this.Controls.Add(this.tlpUserRole);
            this.Name = "MedicineForm";
            this.Text = "MedicineForm";
            this.Controls.SetChildIndex(this.tlpUserRole, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.lineAction, 0);
            this.tlpUserRole.ResumeLayout(false);
            this.tlpUserRole.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpUserRole;
        private System.Windows.Forms.TextBox txtMedicine;
        private System.Windows.Forms.Label lblChiefComplain;
        private System.Windows.Forms.Label lblMedicine;
        private System.Windows.Forms.ComboBox cmbChiefComplain;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
    }
}