namespace SarvottamHospital
{
    partial class MainInvestigationForm
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
            this.lblMainInvestigation = new System.Windows.Forms.Label();
            this.txtMainInvestigation = new System.Windows.Forms.TextBox();
            this.lblMainInvestigationDesc = new System.Windows.Forms.Label();
            this.txtMainInvestigationDesc = new System.Windows.Forms.TextBox();
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
            this.tlpUserRole.Controls.Add(this.lblMainInvestigation, 0, 0);
            this.tlpUserRole.Controls.Add(this.txtMainInvestigation, 1, 0);
            this.tlpUserRole.Controls.Add(this.lblMainInvestigationDesc, 0, 2);
            this.tlpUserRole.Controls.Add(this.txtMainInvestigationDesc, 1, 2);
            this.tlpUserRole.Location = new System.Drawing.Point(27, 57);
            this.tlpUserRole.Name = "tlpUserRole";
            this.tlpUserRole.RowCount = 3;
            this.tlpUserRole.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpUserRole.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpUserRole.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tlpUserRole.Size = new System.Drawing.Size(496, 184);
            this.tlpUserRole.TabIndex = 111;
            // 
            // lblMainInvestigation
            // 
            this.lblMainInvestigation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMainInvestigation.AutoSize = true;
            this.lblMainInvestigation.Location = new System.Drawing.Point(3, 6);
            this.lblMainInvestigation.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblMainInvestigation.Name = "lblMainInvestigation";
            this.lblMainInvestigation.Size = new System.Drawing.Size(124, 15);
            this.lblMainInvestigation.TabIndex = 0;
            this.lblMainInvestigation.Text = "Main Investigation";
            this.lblMainInvestigation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMainInvestigation
            // 
            this.txtMainInvestigation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMainInvestigation.Location = new System.Drawing.Point(133, 3);
            this.txtMainInvestigation.MaxLength = 50;
            this.txtMainInvestigation.Name = "txtMainInvestigation";
            this.txtMainInvestigation.Size = new System.Drawing.Size(375, 21);
            this.txtMainInvestigation.TabIndex = 1;
            // 
            // lblMainInvestigationDesc
            // 
            this.lblMainInvestigationDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMainInvestigationDesc.AutoSize = true;
            this.lblMainInvestigationDesc.Location = new System.Drawing.Point(3, 33);
            this.lblMainInvestigationDesc.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblMainInvestigationDesc.Name = "lblMainInvestigationDesc";
            this.lblMainInvestigationDesc.Size = new System.Drawing.Size(124, 45);
            this.lblMainInvestigationDesc.TabIndex = 4;
            this.lblMainInvestigationDesc.Text = "Description\r\n(Press Ctl+Enter for New line)";
            this.lblMainInvestigationDesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMainInvestigationDesc
            // 
            this.txtMainInvestigationDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMainInvestigationDesc.Location = new System.Drawing.Point(133, 30);
            this.txtMainInvestigationDesc.MaxLength = 1000;
            this.txtMainInvestigationDesc.Multiline = true;
            this.txtMainInvestigationDesc.Name = "txtMainInvestigationDesc";
            this.txtMainInvestigationDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMainInvestigationDesc.Size = new System.Drawing.Size(375, 151);
            this.txtMainInvestigationDesc.TabIndex = 5;
            // 
            // MainInvestigationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 298);
            this.Controls.Add(this.tlpUserRole);
            this.Name = "MainInvestigationForm";
            this.Text = "MainInvestigationForm";
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
        private System.Windows.Forms.Label lblMainInvestigation;
        private System.Windows.Forms.TextBox txtMainInvestigation;
        private System.Windows.Forms.Label lblMainInvestigationDesc;
        private System.Windows.Forms.TextBox txtMainInvestigationDesc;
    }
}