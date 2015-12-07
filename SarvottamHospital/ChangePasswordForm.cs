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
    public sealed partial class ChangePasswordForm : SarvottamHospital.ObjectbaseForm
    {
        private User mUser;

        public ChangePasswordForm() : this(AppContext.LoggedUser) { }


        public ChangePasswordForm(User obj)
            : base(obj)
        {
            this.mUser = obj;
            this.InitializeComponent();
            this.UserInitialize();
        }

        private void UserInitialize()
        {
            this.txtOldPassword.Tag = this.lblOldPassword;
            this.lblOldPassword.Click += new EventHandler(OnLabelClick);
            this.lblOldPassword.Height = this.txtOldPassword.Height;
            this.txtOldPassword.Enter += new EventHandler(OnControlEnter);
            this.txtOldPassword.Leave += new EventHandler(OnControlLeave);

            this.txtNewPassword.Tag = this.lblNewPassword;
            this.lblNewPassword.Click += new EventHandler(OnLabelClick);
            this.lblNewPassword.Height = this.txtNewPassword.Height;
            this.txtNewPassword.Enter += new EventHandler(OnControlEnter);
            this.txtNewPassword.Leave += new EventHandler(OnControlLeave);

            this.txtConfirmPassword.Tag = this.lblConfirmPassword;
            this.lblConfirmPassword.Click += new EventHandler(OnLabelClick);
            this.lblConfirmPassword.Height = this.txtConfirmPassword.Height;
            this.txtConfirmPassword.Enter += new EventHandler(OnControlEnter);
            this.txtConfirmPassword.Leave += new EventHandler(OnControlLeave);
        }

        protected override void OnDataShow()
        {
            base.OnDataShow();
            this.txtOldPassword.Select();
            this.btnDelete.Visible = false;
            this.btnSave.Visible = true;
            this.btnSave.Text = "&Ok";
            this.Text = string.Format("{0} Password of {1}", (this.mUser.IsLoggedIn ? "Change" : "Reset"), this.mUser.Name);
            this.txtUsername.Text = this.mUser.LoginName;
            this.lblOldPassword.Visible = this.mUser.IsLoggedIn;
            this.txtOldPassword.Visible = this.mUser.IsLoggedIn;
        }

        protected override bool OnDataValidation()
        {
            bool r = true;

            if (txtNewPassword.Text.Length <= 0)
            {
                this.ShowTooltip(txtNewPassword, "New Password", "New Password Required!", ContentAlignment.MiddleCenter, ToolTipIcon.Error);
                if (r)
                    this.txtNewPassword.Select();
                r = false;
            }

            if (txtConfirmPassword.Text.Length <= 0)
            {
                this.ShowTooltip(txtConfirmPassword, "Confirm Password", "Confirm Password Required!", ContentAlignment.MiddleRight, ToolTipIcon.Error);
                if (r)
                    this.txtConfirmPassword.Select();
                r = false;
            }
            else if (txtConfirmPassword.Text != txtNewPassword.Text)
            {
                this.ShowTooltip(txtConfirmPassword, "Confirm Password", "New password is not confirm!", ContentAlignment.MiddleRight, ToolTipIcon.Error);
                if (r)
                    this.txtConfirmPassword.Select();
                r = false;
            }
            return r && base.OnDataValidation();
        }

        protected override void OnSaveClick()
        {
            if (this.OnDataValidation())
            {
                if ((this.mUser.IsLoggedIn ? this.mUser.ChangePassword(this.txtOldPassword.Text, this.txtNewPassword.Text) : this.mUser.ResetPassword(this.txtNewPassword.Text)))
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    this.ShowTooltip(txtOldPassword, "Change Password", "Unable to change password!\r\nPlease make sure, you had provided valid old password.", ContentAlignment.MiddleRight, ToolTipIcon.Error);
                    txtOldPassword.Select();
                }
            }
        }

        public static bool ShowForm()
        {
            return ShowForm(AppContext.LoggedUser);
        }

        public static bool ShowForm(User obj)
        {
            bool r = false;
            if (!Objectbase.IsNullOrEmpty(obj))
            {
                using (ChangePasswordForm frm = new ChangePasswordForm(obj))
                {
                    r = frm.ShowDialog() == DialogResult.OK;
                }
            }
            return r;
        }
    }
}
