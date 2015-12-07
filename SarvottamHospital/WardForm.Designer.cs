namespace SarvottamHospital
{
    partial class WardForm
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
            this.lblWardName = new System.Windows.Forms.Label();
            this.txtWardName = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtWardDesc = new System.Windows.Forms.TextBox();
            this.tlpWard.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.TabIndex = 2;
            // 
            // tlpWard
            // 
            this.tlpWard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpWard.ColumnCount = 2;
            this.tlpWard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tlpWard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 381F));
            this.tlpWard.Controls.Add(this.lblWardName, 0, 0);
            this.tlpWard.Controls.Add(this.txtWardName, 1, 0);
            this.tlpWard.Controls.Add(this.lblDesc, 0, 1);
            this.tlpWard.Controls.Add(this.txtWardDesc, 1, 1);
            this.tlpWard.Location = new System.Drawing.Point(27, 57);
            this.tlpWard.Name = "tlpWard";
            this.tlpWard.RowCount = 2;
            this.tlpWard.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpWard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tlpWard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpWard.Size = new System.Drawing.Size(496, 184);
            this.tlpWard.TabIndex = 109;
            // 
            // lblWardName
            // 
            this.lblWardName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWardName.AutoSize = true;
            this.lblWardName.Location = new System.Drawing.Point(3, 6);
            this.lblWardName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblWardName.Name = "lblWardName";
            this.lblWardName.Size = new System.Drawing.Size(109, 15);
            this.lblWardName.TabIndex = 0;
            this.lblWardName.Text = "Ward Name";
            this.lblWardName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtWardName
            // 
            this.txtWardName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWardName.Location = new System.Drawing.Point(118, 3);
            this.txtWardName.MaxLength = 100;
            this.txtWardName.Name = "txtWardName";
            this.txtWardName.Size = new System.Drawing.Size(375, 21);
            this.txtWardName.TabIndex = 1;
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
            // txtWardDesc
            // 
            this.txtWardDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWardDesc.Location = new System.Drawing.Point(118, 30);
            this.txtWardDesc.MaxLength = 500;
            this.txtWardDesc.Multiline = true;
            this.txtWardDesc.Name = "txtWardDesc";
            this.txtWardDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtWardDesc.Size = new System.Drawing.Size(375, 151);
            this.txtWardDesc.TabIndex = 3;
            // 
            // WardForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 298);
            this.Controls.Add(this.tlpWard);
            this.Name = "WardForm";
            this.Text = "WardForm";
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
        private System.Windows.Forms.Label lblWardName;
        private System.Windows.Forms.TextBox txtWardName;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtWardDesc;
    }
}