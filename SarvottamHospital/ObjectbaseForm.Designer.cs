namespace SarvottamHospital
{
    partial class ObjectbaseForm
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
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lineTitle = new System.Windows.Forms.Label();
            this.picTitle = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lineAction = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.White;
            this.pnlTitle.Controls.Add(this.lineTitle);
            this.pnlTitle.Controls.Add(this.picTitle);
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(550, 48);
            this.pnlTitle.TabIndex = 104;
            // 
            // lineTitle
            // 
            this.lineTitle.BackColor = System.Drawing.Color.Transparent;
            this.lineTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lineTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lineTitle.Location = new System.Drawing.Point(0, 46);
            this.lineTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lineTitle.Name = "lineTitle";
            this.lineTitle.Size = new System.Drawing.Size(550, 2);
            this.lineTitle.TabIndex = 1;
            this.lineTitle.UseMnemonic = false;
            // 
            // picTitle
            // 
            this.picTitle.ErrorImage = null;
            this.picTitle.InitialImage = null;
            this.picTitle.Location = new System.Drawing.Point(0, 0);
            this.picTitle.Margin = new System.Windows.Forms.Padding(0);
            this.picTitle.Name = "picTitle";
            this.picTitle.Size = new System.Drawing.Size(46, 46);
            this.picTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picTitle.TabIndex = 5;
            this.picTitle.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoEllipsis = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitle.Location = new System.Drawing.Point(48, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(502, 48);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Entry";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.UseMnemonic = false;
            // 
            // lineAction
            // 
            this.lineAction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lineAction.BackColor = System.Drawing.Color.Transparent;
            this.lineAction.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lineAction.Location = new System.Drawing.Point(0, 258);
            this.lineAction.Margin = new System.Windows.Forms.Padding(0);
            this.lineAction.Name = "lineAction";
            this.lineAction.Size = new System.Drawing.Size(550, 2);
            this.lineAction.TabIndex = 105;
            this.lineAction.UseMnemonic = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::SarvottamHospital.Properties.Resources.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(458, 268);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 24);
            this.btnCancel.TabIndex = 107;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Image = global::SarvottamHospital.Properties.Resources.Save;
            this.btnSave.Location = new System.Drawing.Point(372, 268);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 24);
            this.btnSave.TabIndex = 106;
            this.btnSave.Text = "&Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.Image = global::SarvottamHospital.Properties.Resources.Delete;
            this.btnDelete.Location = new System.Drawing.Point(12, 268);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 24);
            this.btnDelete.TabIndex = 108;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ObjectbaseForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(550, 298);
            this.Controls.Add(this.lineAction);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.pnlTitle);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ObjectbaseForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Entityname";
            this.pnlTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lineTitle;
        private System.Windows.Forms.PictureBox picTitle;
        private System.Windows.Forms.Label lblTitle;
        protected internal System.Windows.Forms.Label lineAction;
        protected internal System.Windows.Forms.Button btnCancel;
        protected internal System.Windows.Forms.Button btnSave;
        protected internal System.Windows.Forms.Button btnDelete;



    }
}