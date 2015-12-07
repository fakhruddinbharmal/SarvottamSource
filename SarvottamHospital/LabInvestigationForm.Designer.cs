namespace SarvottamHospital
{
    partial class LabInvestigationForm
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
            this.lblLabInvestigation = new System.Windows.Forms.Label();
            this.txtLabInvestigation = new System.Windows.Forms.TextBox();
            this.lblLabInvestigationDesc = new System.Windows.Forms.Label();
            this.txtLabInvestigationDesc = new System.Windows.Forms.TextBox();
            this.tlpUserRole.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpUserRole
            // 
            this.tlpUserRole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpUserRole.ColumnCount = 2;
            this.tlpUserRole.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tlpUserRole.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 381F));
            this.tlpUserRole.Controls.Add(this.lblLabInvestigation, 0, 0);
            this.tlpUserRole.Controls.Add(this.txtLabInvestigation, 1, 0);
            this.tlpUserRole.Controls.Add(this.lblLabInvestigationDesc, 0, 2);
            this.tlpUserRole.Controls.Add(this.txtLabInvestigationDesc, 1, 2);
            this.tlpUserRole.Location = new System.Drawing.Point(27, 57);
            this.tlpUserRole.Name = "tlpUserRole";
            this.tlpUserRole.RowCount = 3;
            this.tlpUserRole.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpUserRole.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpUserRole.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tlpUserRole.Size = new System.Drawing.Size(496, 184);
            this.tlpUserRole.TabIndex = 112;
            // 
            // lblLabInvestigation
            // 
            this.lblLabInvestigation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLabInvestigation.AutoSize = true;
            this.lblLabInvestigation.Location = new System.Drawing.Point(3, 6);
            this.lblLabInvestigation.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblLabInvestigation.Name = "lblLabInvestigation";
            this.lblLabInvestigation.Size = new System.Drawing.Size(124, 15);
            this.lblLabInvestigation.TabIndex = 0;
            this.lblLabInvestigation.Text = "Lab Investigation";
            this.lblLabInvestigation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLabInvestigation
            // 
            this.txtLabInvestigation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLabInvestigation.Location = new System.Drawing.Point(133, 3);
            this.txtLabInvestigation.MaxLength = 50;
            this.txtLabInvestigation.Name = "txtLabInvestigation";
            this.txtLabInvestigation.Size = new System.Drawing.Size(375, 21);
            this.txtLabInvestigation.TabIndex = 1;
            // 
            // lblLabInvestigationDesc
            // 
            this.lblLabInvestigationDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLabInvestigationDesc.AutoSize = true;
            this.lblLabInvestigationDesc.Location = new System.Drawing.Point(3, 33);
            this.lblLabInvestigationDesc.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblLabInvestigationDesc.Name = "lblLabInvestigationDesc";
            this.lblLabInvestigationDesc.Size = new System.Drawing.Size(124, 45);
            this.lblLabInvestigationDesc.TabIndex = 4;
            this.lblLabInvestigationDesc.Text = "Description\r\n(Press Ctl+Enter for New line)";
            this.lblLabInvestigationDesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLabInvestigationDesc
            // 
            this.txtLabInvestigationDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLabInvestigationDesc.Location = new System.Drawing.Point(133, 30);
            this.txtLabInvestigationDesc.MaxLength = 1000;
            this.txtLabInvestigationDesc.Multiline = true;
            this.txtLabInvestigationDesc.Name = "txtLabInvestigationDesc";
            this.txtLabInvestigationDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLabInvestigationDesc.Size = new System.Drawing.Size(375, 151);
            this.txtLabInvestigationDesc.TabIndex = 5;
            // 
            // LabInvestigationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 298);
            this.Controls.Add(this.tlpUserRole);
            this.Name = "LabInvestigationForm";
            this.Text = "LabInvestigationForm";
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.lineAction, 0);
            this.Controls.SetChildIndex(this.tlpUserRole, 0);
            this.tlpUserRole.ResumeLayout(false);
            this.tlpUserRole.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpUserRole;
        private System.Windows.Forms.Label lblLabInvestigation;
        private System.Windows.Forms.TextBox txtLabInvestigation;
        private System.Windows.Forms.Label lblLabInvestigationDesc;
        private System.Windows.Forms.TextBox txtLabInvestigationDesc;
    }
}