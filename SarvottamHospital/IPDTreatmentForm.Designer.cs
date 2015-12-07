namespace SarvottamHospital
{
    partial class IPDTreatmentForm
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
            this.tlpWard = new System.Windows.Forms.TableLayoutPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.tlpWard.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpWard
            // 
            this.tlpWard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpWard.ColumnCount = 2;
            this.tlpWard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tlpWard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 381F));
            this.tlpWard.Controls.Add(this.lblName, 0, 0);
            this.tlpWard.Controls.Add(this.txtName, 1, 0);
            this.tlpWard.Controls.Add(this.lblDesc, 0, 1);
            this.tlpWard.Controls.Add(this.txtDesc, 1, 1);
            this.tlpWard.Location = new System.Drawing.Point(27, 57);
            this.tlpWard.Name = "tlpWard";
            this.tlpWard.RowCount = 2;
            this.tlpWard.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpWard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tlpWard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpWard.Size = new System.Drawing.Size(496, 184);
            this.tlpWard.TabIndex = 110;
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
            this.lblName.Text = "Treatment Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(118, 3);
            this.txtName.MaxLength = 200;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(375, 21);
            this.txtName.TabIndex = 1;
            // 
            // lblDesc
            // 
            this.lblDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(3, 33);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(109, 45);
            this.lblDesc.TabIndex = 2;
            this.lblDesc.Text = "Description\r\n(Press Ctl+Enter for New line)";
            this.lblDesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDesc
            // 
            this.txtDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDesc.Location = new System.Drawing.Point(118, 30);
            this.txtDesc.MaxLength = 500;
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDesc.Size = new System.Drawing.Size(375, 151);
            this.txtDesc.TabIndex = 3;
            // 
            // IPDTreatmentForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 298);
            this.Controls.Add(this.tlpWard);
            this.Name = "IPDTreatmentForm";
            this.Text = "TreatmentForm";
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.lineAction, 0);
            this.Controls.SetChildIndex(this.tlpWard, 0);
            this.tlpWard.ResumeLayout(false);
            this.tlpWard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpWard;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtDesc;
    }
}