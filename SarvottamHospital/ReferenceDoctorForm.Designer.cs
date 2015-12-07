namespace SarvottamHospital
{
    partial class ReferenceDoctorForm
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
            this.tlpReferenceDoctor = new System.Windows.Forms.TableLayoutPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblShare = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.nupShare = new System.Windows.Forms.NumericUpDown();
            this.tlpReferenceDoctor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupShare)).BeginInit();
            this.SuspendLayout();
            // 
            // lineAction
            // 
            this.lineAction.Location = new System.Drawing.Point(0, 272);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(458, 282);
            this.btnCancel.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(372, 282);
            this.btnSave.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 282);
            this.btnDelete.TabIndex = 2;
            // 
            // tlpReferenceDoctor
            // 
            this.tlpReferenceDoctor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpReferenceDoctor.ColumnCount = 2;
            this.tlpReferenceDoctor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tlpReferenceDoctor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 381F));
            this.tlpReferenceDoctor.Controls.Add(this.lblName, 0, 0);
            this.tlpReferenceDoctor.Controls.Add(this.txtName, 1, 0);
            this.tlpReferenceDoctor.Controls.Add(this.lblDesc, 0, 2);
            this.tlpReferenceDoctor.Controls.Add(this.lblShare, 0, 1);
            this.tlpReferenceDoctor.Controls.Add(this.txtDesc, 1, 2);
            this.tlpReferenceDoctor.Controls.Add(this.nupShare, 1, 1);
            this.tlpReferenceDoctor.Location = new System.Drawing.Point(27, 57);
            this.tlpReferenceDoctor.Name = "tlpReferenceDoctor";
            this.tlpReferenceDoctor.RowCount = 3;
            this.tlpReferenceDoctor.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpReferenceDoctor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpReferenceDoctor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlpReferenceDoctor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpReferenceDoctor.Size = new System.Drawing.Size(496, 200);
            this.tlpReferenceDoctor.TabIndex = 110;
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(3, 6);
            this.lblName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(109, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(118, 3);
            this.txtName.MaxLength = 100;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(375, 21);
            this.txtName.TabIndex = 1;
            // 
            // lblDesc
            // 
            this.lblDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(3, 61);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(109, 45);
            this.lblDesc.TabIndex = 4;
            this.lblDesc.Text = "Description\r\n(Press Ctl+Enter for New line)";
            this.lblDesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblShare
            // 
            this.lblShare.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblShare.AutoSize = true;
            this.lblShare.Location = new System.Drawing.Point(3, 33);
            this.lblShare.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblShare.Name = "lblShare";
            this.lblShare.Size = new System.Drawing.Size(109, 15);
            this.lblShare.TabIndex = 2;
            this.lblShare.Text = "Share";
            this.lblShare.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDesc
            // 
            this.txtDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDesc.Location = new System.Drawing.Point(118, 58);
            this.txtDesc.MaxLength = 500;
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDesc.Size = new System.Drawing.Size(375, 139);
            this.txtDesc.TabIndex = 5;
            // 
            // nupShare
            // 
            this.nupShare.DecimalPlaces = 2;
            this.nupShare.Location = new System.Drawing.Point(118, 30);
            this.nupShare.Name = "nupShare";
            this.nupShare.Size = new System.Drawing.Size(120, 21);
            this.nupShare.TabIndex = 3;
            // 
            // ReferenceDoctorForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 312);
            this.Controls.Add(this.tlpReferenceDoctor);
            this.Name = "ReferenceDoctorForm";
            this.Text = "ReferenceDoctorForm";
            this.Controls.SetChildIndex(this.tlpReferenceDoctor, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.lineAction, 0);
            this.tlpReferenceDoctor.ResumeLayout(false);
            this.tlpReferenceDoctor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupShare)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpReferenceDoctor;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lblShare;
        private System.Windows.Forms.NumericUpDown nupShare;
    }
}