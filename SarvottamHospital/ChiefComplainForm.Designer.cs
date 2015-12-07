namespace SarvottamHospital
{
    partial class ChiefComplainForm
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
            this.lblChiefComplain = new System.Windows.Forms.Label();
            this.txtChiefComplain = new System.Windows.Forms.TextBox();
            this.lblChiefComplainDesc = new System.Windows.Forms.Label();
            this.txtChiefComplainDesc = new System.Windows.Forms.TextBox();
            this.tlpUserRole.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpUserRole
            // 
            this.tlpUserRole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpUserRole.ColumnCount = 2;
            this.tlpUserRole.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tlpUserRole.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 381F));
            this.tlpUserRole.Controls.Add(this.lblChiefComplain, 0, 0);
            this.tlpUserRole.Controls.Add(this.txtChiefComplain, 1, 0);
            this.tlpUserRole.Controls.Add(this.lblChiefComplainDesc, 0, 2);
            this.tlpUserRole.Controls.Add(this.txtChiefComplainDesc, 1, 2);
            this.tlpUserRole.Location = new System.Drawing.Point(27, 57);
            this.tlpUserRole.Name = "tlpUserRole";
            this.tlpUserRole.RowCount = 3;
            this.tlpUserRole.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpUserRole.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpUserRole.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tlpUserRole.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpUserRole.Size = new System.Drawing.Size(496, 184);
            this.tlpUserRole.TabIndex = 109;
            // 
            // lblChiefComplain
            // 
            this.lblChiefComplain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblChiefComplain.AutoSize = true;
            this.lblChiefComplain.Location = new System.Drawing.Point(3, 6);
            this.lblChiefComplain.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblChiefComplain.Name = "lblChiefComplain";
            this.lblChiefComplain.Size = new System.Drawing.Size(109, 15);
            this.lblChiefComplain.TabIndex = 0;
            this.lblChiefComplain.Text = "Chief Complain";
            this.lblChiefComplain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtChiefComplain
            // 
            this.txtChiefComplain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChiefComplain.Location = new System.Drawing.Point(118, 3);
            this.txtChiefComplain.MaxLength = 50;
            this.txtChiefComplain.Name = "txtChiefComplain";
            this.txtChiefComplain.Size = new System.Drawing.Size(375, 21);
            this.txtChiefComplain.TabIndex = 1;
            // 
            // lblChiefComplainDesc
            // 
            this.lblChiefComplainDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblChiefComplainDesc.AutoSize = true;
            this.lblChiefComplainDesc.Location = new System.Drawing.Point(3, 33);
            this.lblChiefComplainDesc.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblChiefComplainDesc.Name = "lblChiefComplainDesc";
            this.lblChiefComplainDesc.Size = new System.Drawing.Size(109, 45);
            this.lblChiefComplainDesc.TabIndex = 4;
            this.lblChiefComplainDesc.Text = "Description\r\n(Press Ctl+Enter for New line)";
            this.lblChiefComplainDesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtChiefComplainDesc
            // 
            this.txtChiefComplainDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChiefComplainDesc.Location = new System.Drawing.Point(118, 30);
            this.txtChiefComplainDesc.MaxLength = 1000;
            this.txtChiefComplainDesc.Multiline = true;
            this.txtChiefComplainDesc.Name = "txtChiefComplainDesc";
            this.txtChiefComplainDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtChiefComplainDesc.Size = new System.Drawing.Size(375, 151);
            this.txtChiefComplainDesc.TabIndex = 5;
            // 
            // ChiefComplainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 298);
            this.Controls.Add(this.tlpUserRole);
            this.Name = "ChiefComplainForm";
            this.Text = "ChiefComplainForm";
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
        private System.Windows.Forms.Label lblChiefComplain;
        private System.Windows.Forms.TextBox txtChiefComplain;
        private System.Windows.Forms.Label lblChiefComplainDesc;
        private System.Windows.Forms.TextBox txtChiefComplainDesc;
    }
}