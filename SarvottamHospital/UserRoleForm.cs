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
    public sealed partial class UserRoleForm : SarvottamHospital.ObjectbaseForm
    {
        private UserRole mRole;

        public UserRoleForm() : this(null) { }

        public UserRoleForm(UserRole UserRole)
            : base(UserRole)
        {
            this.mRole = UserRole;
            this.InitializeComponent();
            this.UserRoleInitialize();
        }

        private void UserRoleInitialize()
        {
            this.txtRoleName.Tag = this.lblUserRoleName;
            this.lblUserRoleName.Click += new EventHandler(OnLabelClick);
            this.txtRoleName.Enter += new EventHandler(OnControlEnter);
            this.txtRoleName.Leave += new EventHandler(OnControlLeave);

            this.cmbUserRoleLevel.Tag = this.lblUserRoleLevel;
            this.lblUserRoleLevel.Click += new EventHandler(OnLabelClick);
            this.cmbUserRoleLevel.Enter += new EventHandler(OnControlEnter);
            this.cmbUserRoleLevel.Leave += new EventHandler(OnControlLeave);

            this.txtDesc.Tag = this.lblDesc;
            this.lblDesc.Click += new EventHandler(OnLabelClick);
            this.txtDesc.Enter += new EventHandler(OnControlEnter);
            this.txtDesc.Leave += new EventHandler(OnControlLeave);
        }

        protected override void OnDataSet()
        {
            base.OnDataSet();
            if (!Objectbase.IsNullOrEmpty(this.mRole))
            {
                if (AppContext.IsAdministrator)
                    this.mRole.UserRoleLevel = Convert.ToInt32(this.cmbUserRoleLevel.SelectedItem);
                else
                    this.mRole.UserRoleLevel = 0;
                this.mRole.UserRoleName = this.txtRoleName.Text;
                this.mRole.UserRoleDesc = this.txtDesc.Text;
            }
        }

        protected override void OnDataShow()
        {
            base.OnDataShow();
            this.CheckPermission();
            if (!Objectbase.IsNullOrEmpty(this.mRole))
            {
                if (!this.mRole.IsNew)
                    this.txtRoleName.Select();
                if (!AppContext.IsAdministrator)
                    this.lblUserRoleLevel.Visible = this.cmbUserRoleLevel.Visible = false;
                else
                    this.cmbUserRoleLevel.SelectedItem = this.mRole.UserRoleLevel.ToString();

                this.txtRoleName.Text = this.mRole.UserRoleName;
                this.txtDesc.Text = this.mRole.UserRoleDesc;
            }
        }

        private void CheckPermission()
        {
            if (!AppContext.IsMainUser)
            {
                EntityCollection ent = AppContext.UserRoleEntities;
                foreach (Entity e in ent)
                {
                    if (e.DisplayName == "User Roles")
                    {
                        if (!this.mRole.IsNew)
                        {
                            this.btnDelete.Visible = AppContext.CanDelete(e.ObjectGuid);
                            this.btnSave.Visible = AppContext.CanEdit(e.ObjectGuid);
                        }
                    }
                }
            }
            else
            {
                if (!this.mRole.IsNew)
                {
                    this.btnDelete.Visible = true;
                }
            }
        }

        protected override bool OnDataValidation()
        {
            bool r = true;
            if (this.txtRoleName.Text.Trim().Length <= 0)
            {
                this.ShowTooltip(this.txtRoleName, "Role Name", "Role Name Required!", ContentAlignment.TopRight);
                if (r)
                    this.txtRoleName.Select();
                r = false;
            }

            return r && base.OnDataValidation();
        }

        public static bool ShowForm(UserRole obj)
        {
            bool r = false;
            if (!Objectbase.IsNullOrEmpty(obj))
            {
                using (UserRoleForm frm = new UserRoleForm(obj))
                {
                    r = frm.ShowDialog() == DialogResult.OK;
                }
            }
            return r;
        }
    }
}
