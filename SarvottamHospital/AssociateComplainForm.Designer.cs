namespace SarvottamHospital
{
    partial class AssociateComplainForm
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
            this.lblAssociateComplain = new System.Windows.Forms.Label();
            this.txtAssociateComplain = new System.Windows.Forms.TextBox();
            this.lblAssociateComplainDesc = new System.Windows.Forms.Label();
            this.txtAssociateComplainDesc = new System.Windows.Forms.TextBox();
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
            this.tlpUserRole.Controls.Add(this.lblAssociateComplain, 0, 0);
            this.tlpUserRole.Controls.Add(this.txtAssociateComplain, 1, 0);
            this.tlpUserRole.Controls.Add(this.lblAssociateComplainDesc, 0, 2);
            this.tlpUserRole.Controls.Add(this.txtAssociateComplainDesc, 1, 2);
            this.tlpUserRole.Location = new System.Drawing.Point(27, 57);
            this.tlpUserRole.Name = "tlpUserRole";
            this.tlpUserRole.RowCount = 3;
            this.tlpUserRole.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpUserRole.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpUserRole.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tlpUserRole.Size = new System.Drawing.Size(496, 184);
            this.tlpUserRole.TabIndex = 110;
            // 
            // lblAssociateComplain
            // 
            this.lblAssociateComplain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAssociateComplain.AutoSize = true;
            this.lblAssociateComplain.Location = new System.Drawing.Point(3, 6);
            this.lblAssociateComplain.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblAssociateComplain.Name = "lblAssociateComplain";
            this.lblAssociateComplain.Size = new System.Drawing.Size(124, 15);
            this.lblAssociateComplain.TabIndex = 0;
            this.lblAssociateComplain.Text = "Associate Complain";
            this.lblAssociateComplain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAssociateComplain
            // 
            this.txtAssociateComplain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAssociateComplain.Location = new System.Drawing.Point(133, 3);
            this.txtAssociateComplain.MaxLength = 50;
            this.txtAssociateComplain.Name = "txtAssociateComplain";
            this.txtAssociateComplain.Size = new System.Drawing.Size(375, 21);
            this.txtAssociateComplain.TabIndex = 1;
            // 
            // lblAssociateComplainDesc
            // 
            this.lblAssociateComplainDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAssociateComplainDesc.AutoSize = true;
            this.lblAssociateComplainDesc.Location = new System.Drawing.Point(3, 33);
            this.lblAssociateComplainDesc.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblAssociateComplainDesc.Name = "lblAssociateComplainDesc";
            this.lblAssociateComplainDesc.Size = new System.Drawing.Size(124, 45);
            this.lblAssociateComplainDesc.TabIndex = 4;
            this.lblAssociateComplainDesc.Text = "Description\r\n(Press Ctl+Enter for New line)";
            this.lblAssociateComplainDesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAssociateComplainDesc
            // 
            this.txtAssociateComplainDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAssociateComplainDesc.Location = new System.Drawing.Point(133, 30);
            this.txtAssociateComplainDesc.MaxLength = 1000;
            this.txtAssociateComplainDesc.Multiline = true;
            this.txtAssociateComplainDesc.Name = "txtAssociateComplainDesc";
            this.txtAssociateComplainDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAssociateComplainDesc.Size = new System.Drawing.Size(375, 151);
            this.txtAssociateComplainDesc.TabIndex = 5;
            // 
            // AssociateComplainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 298);
            this.Controls.Add(this.tlpUserRole);
            this.Name = "AssociateComplainForm";
            this.Text = "AssociateComplainForm";
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
        private System.Windows.Forms.Label lblAssociateComplain;
        private System.Windows.Forms.TextBox txtAssociateComplain;
        private System.Windows.Forms.Label lblAssociateComplainDesc;
        private System.Windows.Forms.TextBox txtAssociateComplainDesc;
    }
}