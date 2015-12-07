using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SarvottamHospital.Object;

namespace SarvottamHospital
{
    public sealed partial class PermissionForm : ObjectbaseForm
    {
        private UserRole mUserRole;

        private Permissions mUserPermissions;

        public PermissionForm()
        {
            this.InitializeComponent();
            this.UserInitialize();
        }

        public PermissionForm(UserRole obj)
            : base(obj, true)
        {
            this.mUserRole = obj;
            this.mUserPermissions = new Permissions(obj);

            this.InitializeComponent();
            this.UserInitialize();
        }

        private void UserInitialize()
        {
            this.dgvData.AutoGenerateColumns = false;
        }

        protected override void OnDataShow()
        {
            base.OnDataShow();
            this.btnDelete.Visible = false;
            if (!Objectbase.IsNullOrEmpty(this.mUserRole))
            {
                this.Text = "Permission To " + this.mUserRole.DisplayName;
                this.dgvData.AutoGenerateColumns = false;
                this.dgvData.DataSource = mUserPermissions;
            }
        }

        protected override void OnDataSet() { }

        protected override void OnDeleteClick() { /*Do nothing*/ }

        protected override void OnSaveClick()
        {
            //To Do :: Update changes to mUserPermissions collection
            if (this.mUserPermissions.UpdateChanges())
                this.btnCancel.PerformClick();
            else
                this.ShowError("Unable to apply permission!");
        }

        public static bool ShowForm(UserRole obj)
        {
            bool r = false;
            if (!Objectbase.IsNullOrEmpty(obj))
            {
                using (PermissionForm frm = new PermissionForm(obj))
                {
                    r = frm.ShowDialog() == DialogResult.OK;
                }
            }
            return r;
        }
    }
}
