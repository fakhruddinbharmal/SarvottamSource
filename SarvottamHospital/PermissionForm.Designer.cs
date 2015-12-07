namespace SarvottamHospital
{
    partial class PermissionForm
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
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.clmImgIcon = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmEntityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmView = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmCreate = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmEdit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmDelete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmCanSpecial = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmFill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // lineAction
            // 
            this.lineAction.Location = new System.Drawing.Point(0, 352);
            this.lineAction.Size = new System.Drawing.Size(646, 2);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(554, 362);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(468, 362);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 362);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AllowUserToResizeRows = false;
            this.dgvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvData.ColumnHeadersHeight = 24;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmImgIcon,
            this.clmEntityName,
            this.clmView,
            this.clmCreate,
            this.clmEdit,
            this.clmDelete,
            this.clmCanSpecial,
            this.clmFill});
            this.dgvData.Location = new System.Drawing.Point(13, 55);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(621, 282);
            this.dgvData.TabIndex = 109;
            // 
            // clmImgIcon
            // 
            this.clmImgIcon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmImgIcon.DataPropertyName = "EntitySmallIcon";
            this.clmImgIcon.FillWeight = 24F;
            this.clmImgIcon.HeaderText = "";
            this.clmImgIcon.Name = "clmImgIcon";
            this.clmImgIcon.ReadOnly = true;
            this.clmImgIcon.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmImgIcon.Width = 24;
            // 
            // clmEntityName
            // 
            this.clmEntityName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmEntityName.DataPropertyName = "EntityName";
            this.clmEntityName.FillWeight = 5F;
            this.clmEntityName.HeaderText = "Entity Name";
            this.clmEntityName.MaxInputLength = 200;
            this.clmEntityName.Name = "clmEntityName";
            this.clmEntityName.ReadOnly = true;
            this.clmEntityName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // clmView
            // 
            this.clmView.DataPropertyName = "CanView";
            this.clmView.HeaderText = "View";
            this.clmView.Name = "clmView";
            this.clmView.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmView.Width = 48;
            // 
            // clmCreate
            // 
            this.clmCreate.DataPropertyName = "CanCreate";
            this.clmCreate.HeaderText = "Create";
            this.clmCreate.Name = "clmCreate";
            this.clmCreate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmCreate.Width = 48;
            // 
            // clmEdit
            // 
            this.clmEdit.DataPropertyName = "CanEdit";
            this.clmEdit.HeaderText = "Edit";
            this.clmEdit.Name = "clmEdit";
            this.clmEdit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmEdit.Width = 48;
            // 
            // clmDelete
            // 
            this.clmDelete.DataPropertyName = "CanDelete";
            this.clmDelete.HeaderText = "Delete";
            this.clmDelete.Name = "clmDelete";
            this.clmDelete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmDelete.Width = 48;
            // 
            // clmCanSpecial
            // 
            this.clmCanSpecial.DataPropertyName = "CanSpecial";
            this.clmCanSpecial.HeaderText = "Special";
            this.clmCanSpecial.Name = "clmCanSpecial";
            this.clmCanSpecial.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmCanSpecial.Width = 52;
            // 
            // clmFill
            // 
            this.clmFill.FillWeight = 5F;
            this.clmFill.HeaderText = "";
            this.clmFill.Name = "clmFill";
            this.clmFill.ReadOnly = true;
            this.clmFill.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmFill.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmFill.Width = 20;
            // 
            // PermissionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 392);
            this.Controls.Add(this.dgvData);
            this.Name = "PermissionForm";
            this.Text = "PermissionForm";
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.lineAction, 0);
            this.Controls.SetChildIndex(this.dgvData, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.DataGridViewImageColumn clmImgIcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEntityName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmCreate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmEdit;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmDelete;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmCanSpecial;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFill;

    }
}