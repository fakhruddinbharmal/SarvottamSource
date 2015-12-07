namespace SarvottamHospital
{
    partial class HistoryForm
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
            this.lblHistoryOfProblem = new System.Windows.Forms.Label();
            this.txtHistoryOfProblem = new System.Windows.Forms.TextBox();
            this.lblHistoryOfProblemDesc = new System.Windows.Forms.Label();
            this.txtHistoryOfProblemDesc = new System.Windows.Forms.TextBox();
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
            this.tlpUserRole.Controls.Add(this.lblHistoryOfProblem, 0, 0);
            this.tlpUserRole.Controls.Add(this.txtHistoryOfProblem, 1, 0);
            this.tlpUserRole.Controls.Add(this.lblHistoryOfProblemDesc, 0, 2);
            this.tlpUserRole.Controls.Add(this.txtHistoryOfProblemDesc, 1, 2);
            this.tlpUserRole.Location = new System.Drawing.Point(27, 57);
            this.tlpUserRole.Name = "tlpUserRole";
            this.tlpUserRole.RowCount = 3;
            this.tlpUserRole.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpUserRole.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpUserRole.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tlpUserRole.Size = new System.Drawing.Size(496, 184);
            this.tlpUserRole.TabIndex = 111;
            // 
            // lblHistoryOfProblem
            // 
            this.lblHistoryOfProblem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHistoryOfProblem.AutoSize = true;
            this.lblHistoryOfProblem.Location = new System.Drawing.Point(3, 6);
            this.lblHistoryOfProblem.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblHistoryOfProblem.Name = "lblHistoryOfProblem";
            this.lblHistoryOfProblem.Size = new System.Drawing.Size(124, 15);
            this.lblHistoryOfProblem.TabIndex = 0;
            this.lblHistoryOfProblem.Text = "History Of Problem";
            this.lblHistoryOfProblem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtHistoryOfProblem
            // 
            this.txtHistoryOfProblem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHistoryOfProblem.Location = new System.Drawing.Point(133, 3);
            this.txtHistoryOfProblem.MaxLength = 50;
            this.txtHistoryOfProblem.Name = "txtHistoryOfProblem";
            this.txtHistoryOfProblem.Size = new System.Drawing.Size(375, 21);
            this.txtHistoryOfProblem.TabIndex = 1;
            // 
            // lblHistoryOfProblemDesc
            // 
            this.lblHistoryOfProblemDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHistoryOfProblemDesc.AutoSize = true;
            this.lblHistoryOfProblemDesc.Location = new System.Drawing.Point(3, 33);
            this.lblHistoryOfProblemDesc.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblHistoryOfProblemDesc.Name = "lblHistoryOfProblemDesc";
            this.lblHistoryOfProblemDesc.Size = new System.Drawing.Size(124, 45);
            this.lblHistoryOfProblemDesc.TabIndex = 4;
            this.lblHistoryOfProblemDesc.Text = "Description\r\n(Press Ctl+Enter for New line)";
            this.lblHistoryOfProblemDesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtHistoryOfProblemDesc
            // 
            this.txtHistoryOfProblemDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHistoryOfProblemDesc.Location = new System.Drawing.Point(133, 30);
            this.txtHistoryOfProblemDesc.MaxLength = 1000;
            this.txtHistoryOfProblemDesc.Multiline = true;
            this.txtHistoryOfProblemDesc.Name = "txtHistoryOfProblemDesc";
            this.txtHistoryOfProblemDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHistoryOfProblemDesc.Size = new System.Drawing.Size(375, 151);
            this.txtHistoryOfProblemDesc.TabIndex = 5;
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 298);
            this.Controls.Add(this.tlpUserRole);
            this.Name = "HistoryForm";
            this.Text = "HistoryForm";
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
        private System.Windows.Forms.Label lblHistoryOfProblem;
        private System.Windows.Forms.TextBox txtHistoryOfProblem;
        private System.Windows.Forms.Label lblHistoryOfProblemDesc;
        private System.Windows.Forms.TextBox txtHistoryOfProblemDesc;

    }
}