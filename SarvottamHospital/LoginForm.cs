using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Principal;
using System.Configuration;
using SarvottamHospital.Object;

namespace SarvottamHospital
{
    public sealed partial class LoginForm : SarvottamHospital.ObjectbaseForm
    {
        System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

        public LoginForm()
            : base(new User())
        {
            InitializeComponent();
            this.UserInitialize();
        }


        private void UserInitialize()
        {
            this.lblUserName.Click += new EventHandler(this.OnLabelClick);
            this.lblPassword.Click += new EventHandler(this.OnLabelClick);

            this.txtUserName.Tag = this.lblUserName;
            this.txtUserName.Enter += new EventHandler(OnControlEnter);
            this.txtUserName.Leave += new EventHandler(OnControlLeave);

            this.txtPassword.Tag = this.lblPassword;
            this.txtPassword.Enter += new EventHandler(OnControlEnter);
            this.txtPassword.Leave += new EventHandler(OnControlLeave);
            this.btnCancel.Click += new EventHandler(OnCancelClick);
        }

        private void OnCancelClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected override void OnDataShow()
        {
            base.OnDataShow();
            this.Text = string.Format("Login - {0} Ver. {1}", Application.ProductName, Application.ProductVersion);
            this.btnSave.Text = "&Login";
            if (!string.IsNullOrEmpty(AppContext.LastLoginUsername))
            {
                this.txtUserName.Text = AppContext.LastLoginUsername;
                this.txtPassword.Select();
            }
            else
            {
                this.txtUserName.Select();
            }
        }

        protected override void OnSaveClick()
        {
            if (!AppContext.IsUserLoggedIn)
            {
                if (this.OnDataValidation())
                {
                    if (AppContext.Login(this.txtUserName.Text, this.txtPassword.Text))
                    {
                        if (this.chkRememberMe.Checked)
                            AppContext.RememberMe();

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        lblError.Text = "User is not verfied by system.";
                        this.txtUserName.Select();
                    }
                }
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        protected override bool OnDataValidation()
        {
            bool r = true;
            if (this.txtUserName.Text.Trim().Length <= 0)
            {
                this.ShowTooltip(this.txtUserName, "Username", "Username Required!", ContentAlignment.TopRight);
                if (r)
                    this.txtUserName.Select();
                r = false;
            }
            return r;
        }

        public static bool ShowForm()
        {
            bool r = false;
            using (LoginForm frm = new LoginForm())
            {
                r = frm.ShowDialog() == DialogResult.OK && AppContext.IsUserLoggedIn;
            }
            return r;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //if (!Utility.IsEligibleToRun())
            //{
            //if (MessageBox.Show(this, "Application is not able to execute, please contact administrator..!!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.OK)
            //{
            //this.Close();
            //}
            //}
        }
    }
}
