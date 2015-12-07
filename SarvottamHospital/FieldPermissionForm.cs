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
    public sealed partial class FieldPermissionForm : ObjectbaseForm
    {
        private UserRole mUserRole;

        private FieldPermissions mUserPermissions;

        public FieldPermissionForm()
        {
            InitializeComponent();
            this.UserInitialize();
        }

        public FieldPermissionForm(UserRole obj)
            : base(obj, true)
        {
            this.mUserRole = obj;
            this.mUserPermissions = new FieldPermissions(obj);

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
                using (FieldPermissionForm frm = new FieldPermissionForm(obj))
                {
                    r = frm.ShowDialog() == DialogResult.OK;
                }
            }
            return r;
        }
    }
}
