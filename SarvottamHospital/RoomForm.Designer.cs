namespace SarvottamHospital
{
    partial class RoomForm
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
            this.tlpRoom = new System.Windows.Forms.TableLayoutPanel();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.txtRoomType = new System.Windows.Forms.TextBox();
            this.lblRoomDesc = new System.Windows.Forms.Label();
            this.txtRoomDesc = new System.Windows.Forms.TextBox();
            this.tlpRoom.SuspendLayout();
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
            // tlpRoom
            // 
            this.tlpRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpRoom.ColumnCount = 2;
            this.tlpRoom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tlpRoom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 381F));
            this.tlpRoom.Controls.Add(this.lblRoomType, 0, 0);
            this.tlpRoom.Controls.Add(this.txtRoomType, 1, 0);
            this.tlpRoom.Controls.Add(this.lblRoomDesc, 0, 1);
            this.tlpRoom.Controls.Add(this.txtRoomDesc, 1, 1);
            this.tlpRoom.Location = new System.Drawing.Point(27, 57);
            this.tlpRoom.Name = "tlpRoom";
            this.tlpRoom.RowCount = 2;
            this.tlpRoom.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpRoom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tlpRoom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpRoom.Size = new System.Drawing.Size(496, 184);
            this.tlpRoom.TabIndex = 110;
            // 
            // lblRoomType
            // 
            this.lblRoomType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Location = new System.Drawing.Point(3, 6);
            this.lblRoomType.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(109, 15);
            this.lblRoomType.TabIndex = 0;
            this.lblRoomType.Text = "Room Type";
            this.lblRoomType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRoomType
            // 
            this.txtRoomType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRoomType.Location = new System.Drawing.Point(118, 3);
            this.txtRoomType.MaxLength = 100;
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.Size = new System.Drawing.Size(375, 21);
            this.txtRoomType.TabIndex = 1;
            // 
            // lblRoomDesc
            // 
            this.lblRoomDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRoomDesc.AutoSize = true;
            this.lblRoomDesc.Location = new System.Drawing.Point(3, 33);
            this.lblRoomDesc.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblRoomDesc.Name = "lblRoomDesc";
            this.lblRoomDesc.Size = new System.Drawing.Size(109, 45);
            this.lblRoomDesc.TabIndex = 2;
            this.lblRoomDesc.Text = "Description\r\n(Press Ctl+Enter for New line)";
            this.lblRoomDesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRoomDesc
            // 
            this.txtRoomDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRoomDesc.Location = new System.Drawing.Point(118, 30);
            this.txtRoomDesc.MaxLength = 500;
            this.txtRoomDesc.Multiline = true;
            this.txtRoomDesc.Name = "txtRoomDesc";
            this.txtRoomDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRoomDesc.Size = new System.Drawing.Size(375, 151);
            this.txtRoomDesc.TabIndex = 3;
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 298);
            this.Controls.Add(this.tlpRoom);
            this.Name = "RoomForm";
            this.Text = "RoomForm";
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.lineAction, 0);
            this.Controls.SetChildIndex(this.tlpRoom, 0);
            this.tlpRoom.ResumeLayout(false);
            this.tlpRoom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpRoom;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.TextBox txtRoomType;
        private System.Windows.Forms.Label lblRoomDesc;
        private System.Windows.Forms.TextBox txtRoomDesc;
    }
}