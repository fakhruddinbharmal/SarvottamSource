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
    public sealed partial class UserForm : SarvottamHospital.ObjectbaseForm
    {
        private User mEntry;

        public UserForm() : this(null) { }

        public UserForm(User user)
            : base(user)
        {
            this.mEntry = user;
            this.InitializeComponent();
            this.UserInitialize();
        }

        private void UserInitialize()
        {
            this.txtLoginName.Tag = this.lblLoginName;
            this.lblLoginName.Click += new EventHandler(OnLabelClick);
            this.txtLoginName.Enter += new EventHandler(OnControlEnter);
            this.txtLoginName.Leave += new EventHandler(OnControlLeave);

            this.txtName.Tag = this.lblName;
            this.lblName.Click += new EventHandler(OnLabelClick);
            this.txtName.Enter += new EventHandler(OnControlEnter);
            this.txtName.Leave += new EventHandler(OnControlLeave);

            this.txtAddress1.Tag = this.lblAddress;
            this.lblAddress.Click += new EventHandler(OnLabelClick);
            this.txtAddress1.Enter += new EventHandler(OnControlEnter);
            this.txtAddress1.Leave += new EventHandler(OnControlLeave);

            this.txtAddress2.Tag = this.lblAddress;
            this.txtAddress2.Enter += new EventHandler(OnControlEnter);
            this.txtAddress2.Leave += new EventHandler(OnControlLeave);

            this.txtAddress3.Tag = this.lblAddress;
            this.txtAddress3.Enter += new EventHandler(OnControlEnter);
            this.txtAddress3.Leave += new EventHandler(OnControlLeave);

            this.txtPhoneNo.Tag = this.lblPhoneNo;
            this.lblPhoneNo.Click += new EventHandler(OnLabelClick);
            this.txtPhoneNo.Enter += new EventHandler(OnControlEnter);
            this.txtPhoneNo.Leave += new EventHandler(OnControlLeave);

            this.txtMobileNo.Tag = this.lblMobileNo;
            this.lblMobileNo.Click += new EventHandler(OnLabelClick);
            this.txtMobileNo.Enter += new EventHandler(OnControlEnter);
            this.txtMobileNo.Leave += new EventHandler(OnControlLeave);

            this.imgPhoto.Tag = this.lblPhoto;
            this.lblPhoto.Click += new EventHandler(OnLabelClick);
            this.imgPhoto.Enter += new EventHandler(OnControlEnter);
            this.imgPhoto.Leave += new EventHandler(OnControlLeave);
            this.imgPhoto.Click += new EventHandler(this.btnAddPhoto_Click);

            this.txtDesc.Tag = this.lblDesc;
            this.lblDesc.Click += new EventHandler(OnLabelClick);
            this.txtDesc.Enter += new EventHandler(OnControlEnter);
            this.txtDesc.Leave += new EventHandler(OnControlLeave);

            this.btnAddPhoto.Click += new EventHandler(this.btnAddPhoto_Click);
            this.btnRemovePhoto.Click += new EventHandler(this.btnRemovePhoto_Click);

            this.dlgOpenPhoto.Title = "Please select a photo for user...";
            this.dlgOpenPhoto.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
        }

        protected override void OnDataSet()
        {
            base.OnDataSet();
            if (!Objectbase.IsNullOrEmpty(this.mEntry))
            {
                this.mEntry.LoginName = this.txtLoginName.Text;
                this.mEntry.Name = this.txtName.Text;
                this.mEntry.AddressLine1 = this.txtAddress1.Text;
                this.mEntry.AddressLine2 = this.txtAddress2.Text;
                this.mEntry.AddressLine3 = this.txtAddress3.Text;
                this.mEntry.PhoneNo = this.txtPhoneNo.Text;
                this.mEntry.MobileNo = this.txtMobileNo.Text;
                if (this.mEntry.IsNew || AppContext.IsAdministrator)
                    this.mEntry.UserRole = this.cmbUserRole.SelectedItem as UserRole;

                this.mEntry.Photo = this.imgPhoto.Image == null ? null : Common.BytesToImage(this.imgPhoto.Image);
                this.mEntry.Description = this.txtDesc.Text;

                if (this.mEntry.IsOpen)
                    this.mEntry.IsDisabled = this.chkIsDisable.Checked;
            }
        }

        protected override void OnDataShow()
        {
            base.OnDataShow();
            if (!Objectbase.IsNullOrEmpty(this.mEntry))
            {
                this.CheckPermission();
                UserRoles roleList = new UserRoles();
                this.cmbUserRole.DisplayMember = "DisplayName";
                this.cmbUserRole.DataSource = roleList;

                if (!this.mEntry.IsNew && (!AppContext.IsAdministrator))
                {
                    this.txtLoginName.ReadOnly = true;
                    this.txtName.Select();
                    this.cmbUserRole.SelectedItem = this.mEntry.UserRole;
                }
                if (this.mEntry.IsNew)
                {
                    this.lblWindowsUserName.Visible = false;
                    this.txtWindowsUserName.Visible = false;
                }
                this.cmbUserRole.SelectedItem = this.mEntry.UserRole;
                this.txtLoginName.Text = this.mEntry.LoginName;
                this.txtName.Text = this.mEntry.Name;
                this.txtAddress1.Text = this.mEntry.AddressLine1;
                this.txtAddress2.Text = this.mEntry.AddressLine2;
                this.txtAddress3.Text = this.mEntry.AddressLine3;
                this.txtPhoneNo.Text = this.mEntry.PhoneNo;
                this.txtMobileNo.Text = this.mEntry.MobileNo;
                this.txtDesc.Text = this.mEntry.Description;
                this.txtWindowsUserName.Text = this.mEntry.WindowsUserName;
                this.chkIsDisable.Checked = this.mEntry.IsDisabled;

                this.chkIsDisable.Visible = this.mEntry.IsOpen;
                bool hasPhoto = this.mEntry.Photo != null;

                if (hasPhoto)
                    this.imgPhoto.Image = Common.ImageFromBytes(this.mEntry.Photo);

                this.btnRemovePhoto.Visible = hasPhoto;

                if (this.mEntry.IsLoggedIn)
                {
                    this.Text = string.Format("Profile of {0}", this.mEntry.Name);
                    this.chkIsDisable.Visible = false;
                    this.btnDelete.Visible = false;
                    this.btnSave.Visible = true;
                }

            }

        }

        private void CheckPermission()
        {
            if (!AppContext.IsMainUser)
            {
                EntityCollection ent = AppContext.UserRoleEntities;
                foreach (Entity e in ent)
                {
                    if (e.DisplayName == "Users")
                    {
                        if (!this.mEntry.IsNew)
                        {
                            if (AppContext.CanSpecial(e.ObjectGuid))
                                this.cmbUserRole.Enabled = true;
                            else
                                this.ReplaceWithTextbox(this.cmbUserRole, this.mEntry.UserRole.DisplayName);

                            this.btnDelete.Visible = AppContext.CanDelete(e.ObjectGuid);
                            this.btnSave.Visible = AppContext.CanEdit(e.ObjectGuid);
                        }
                    }
                }
            }
            else
            {
                if (!this.mEntry.IsNew)
                {
                    this.btnDelete.Visible = true;
                }
            }

        }

        protected override bool OnDataValidation()
        {
            bool r = true;
            if (this.txtLoginName.Text.Trim().Length <= 0)
            {
                this.ShowTooltip(this.txtLoginName, "Login Name", "Login Name Required!", ContentAlignment.TopRight);
                if (r)
                    this.txtLoginName.Select();
                r = false;
            }

            if (this.txtName.Text.Trim().Length <= 0)
            {
                this.ShowTooltip(this.txtName, "Person Name", "Person Name Required!", ContentAlignment.MiddleRight);
                if (r)
                    this.txtName.Select();
                r = false;
            }

            if (!this.mEntry.CheckAvailability(this.txtLoginName.Text.Trim().ToLower()))
            {
                this.ShowTooltip(this.txtLoginName, "Login Name", "Login Name must be Unique", ContentAlignment.MiddleRight);
                if (r)
                    this.txtLoginName.Select();
                r = false;
            }

            return r && base.OnDataValidation();
        }

        private void btnAddPhoto_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dlgOpenPhoto.ShowDialog() == DialogResult.OK)
                {
                    this.imgPhoto.Image = Common.LoadFromFile(dlgOpenPhoto.FileName, 72, 72);
                }
                if (this.imgPhoto.Image == null)
                    this.btnRemovePhoto.Visible = false;
                else
                    this.btnRemovePhoto.Visible = true;
            }
            catch { }
        }

        private void btnRemovePhoto_Click(object sender, EventArgs e)
        {
            this.imgPhoto.Image = null;
            this.btnRemovePhoto.Visible = false;
        }

        public static bool ShowForm(User obj)
        {
            bool r = false;
            if (!Objectbase.IsNullOrEmpty(obj))
            {
                using (UserForm frm = new UserForm(obj))
                {
                    r = frm.ShowDialog() == DialogResult.OK;
                }
            }
            return r;
        }
    }
}
