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
    public sealed  partial class EntityForm : SarvottamHospital.ObjectbaseForm
    {
        private Entity mEntity;

        public EntityForm() : this(null) { }

        public EntityForm(Entity obj)
            : base(obj)
        {
            this.mEntity = obj;
            this.InitializeComponent();
            this.UserInitialize();
        }

        private void UserInitialize()
        {
            this.txtCaption.Tag = this.lblCaption;
            this.lblCaption.Click += new EventHandler(OnLabelClick);
            this.txtCaption.Enter += new EventHandler(OnControlEnter);
            this.txtCaption.Leave += new EventHandler(OnControlLeave);

            this.txtDescription.Tag = this.lblDescription;
            this.lblDescription.Click += new EventHandler(OnLabelClick);
            this.txtDescription.Enter += new EventHandler(OnControlEnter);
            this.txtDescription.Leave += new EventHandler(OnControlLeave);

            this.txtListCaption.Tag = this.lblListCaption;
            this.lblListCaption.Click += new EventHandler(OnLabelClick);
            this.txtListCaption.Enter += new EventHandler(OnControlEnter);
            this.txtListCaption.Leave += new EventHandler(OnControlLeave);

            this.txtListTypeName.Tag = this.lblListTypeName;
            this.lblListTypeName.Click += new EventHandler(OnLabelClick);
            this.txtListTypeName.Enter += new EventHandler(OnControlEnter);
            this.txtListTypeName.Leave += new EventHandler(OnControlLeave);

            this.txtName.Tag = this.lblName;
            this.lblName.Click += new EventHandler(OnLabelClick);
            this.txtName.Enter += new EventHandler(OnControlEnter);
            this.txtName.Leave += new EventHandler(OnControlLeave);

            this.txtTypeName.Tag = this.lblTypeName;
            this.lblTypeName.Click += new EventHandler(OnLabelClick);
            this.txtTypeName.Enter += new EventHandler(OnControlEnter);
            this.txtTypeName.Leave += new EventHandler(OnControlLeave);

            this.cmbEntityGroup.Tag = this.lblEntityGroup;
            this.lblEntityGroup.Click += new EventHandler(this.OnLabelClick);
            this.cmbEntityGroup.Enter += new EventHandler(this.OnControlEnter);
            this.cmbEntityGroup.Leave += new EventHandler(this.OnControlLeave);

            this.picIconSmall.Tag = this.lblIconSmall;
            this.lblIconSmall.Click += new EventHandler(this.OnLabelClick);
            this.picIconSmall.Click += new EventHandler(this.OnImageClick);

            this.btnRemoveSmallIcon.Click += new EventHandler(this.OnRemoveIconLinkClick);

            this.picIconLarge.Tag = this.lblIconLarge;
            this.lblIconLarge.Click += new EventHandler(this.OnLabelClick);
            this.picIconLarge.Click += new EventHandler(this.OnImageClick);

            this.btnRemoveLargeIcon.Click += new EventHandler(this.OnRemoveIconLinkClick);

            this.dlgOpen.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            this.dlgOpen.Filter = "Image Files(*.bmp;*.dib;*.jpg;*.jpeg;*.gif;*.tif;*.tiff;*.png)|*.bmp;*.dib;*.jpg;*.jpeg;*.gif;*.tif;*.tiff;*.png";

        }

        private void OnImageClick(object sender, EventArgs e)
        {
            if (sender != null)
            {
                if (this.dlgOpen.ShowDialog() == DialogResult.OK && this.dlgOpen.CheckFileExists)
                {
                    if (Objectbase.ReferenceEquals(sender, this.picIconSmall))
                    {
                        this.picIconSmall.Image = Common.LoadFromFile(this.dlgOpen.FileName, 16, 16);
                        this.btnRemoveSmallIcon.Visible = (this.picIconSmall.Image != null);
                    }
                    else if (Objectbase.ReferenceEquals(sender, this.picIconLarge))
                    {
                        this.picIconLarge.Image = Common.LoadFromFile(this.dlgOpen.FileName, 32, 32);
                        this.btnRemoveLargeIcon.Visible = (this.picIconLarge.Image != null);
                    }
                }
            }
        }

        private void OnRemoveIconLinkClick(object sender, EventArgs e)
        {
            if (Objectbase.ReferenceEquals(sender, this.btnRemoveSmallIcon))
            {
                this.picIconSmall.Image = null;
                this.btnRemoveSmallIcon.Visible = false;
            }
            else if (Objectbase.ReferenceEquals(sender, this.btnRemoveLargeIcon))
            {
                this.picIconLarge.Image = null;
                this.btnRemoveLargeIcon.Visible = false;
            }

        }

        protected override bool OnDataValidation()
        {
            bool r = true;

            if (this.txtName.Text.Trim().Length <= 0)
            {
                this.ShowTooltip(this.txtName, "Name", "Name can't be empty!", ContentAlignment.TopRight);
                if (r)
                    this.txtName.Select();
                r = false;
            }

            if (this.txtListCaption.Text.Trim().Length <= 0)
            {
                this.ShowTooltip(this.txtListCaption, "List Caption", "List Caption can't be empty!", ContentAlignment.MiddleCenter);
                if (r)
                    this.txtListCaption.Select();
                r = false;
            }

            if (this.txtListTypeName.Text.Trim().Length <= 0)
            {
                this.ShowTooltip(this.txtListTypeName, "Namespace", "Namespace can't be empty!", ContentAlignment.TopRight);
                if (r)
                    this.txtListTypeName.Select();
                r = false;
            }

            if (this.txtCaption.Text.Trim().Length <= 0)
            {
                this.ShowTooltip(this.txtCaption, "Caption", "Caption can't be empty!", ContentAlignment.MiddleCenter);
                if (r)
                    this.txtCaption.Select();
                r = false;
            }

            if (this.txtTypeName.Text.Trim().Length <= 0)
            {
                this.ShowTooltip(this.txtTypeName, "Type Name", "Type Name can't be empty!", ContentAlignment.MiddleRight);
                if (r)
                    this.txtTypeName.Select();
                r = false;
            }
            return r && base.OnDataValidation();
        }

        protected override void OnDataShow()
        {
            base.OnDataShow();
            this.CheckPermission();

            this.cmbEntityGroup.DataSource = Entity.GetGroups();
            this.txtName.Text = this.mEntity.Name;
            this.txtListCaption.Text = this.mEntity.ListCaption;
            this.txtListTypeName.Text = this.mEntity.ListTypeName;
            this.txtCaption.Text = this.mEntity.Caption;
            this.txtTypeName.Text = this.mEntity.TypeName;
            this.txtDescription.Text = this.mEntity.Description;
            this.cmbEntityGroup.Text = this.mEntity.GroupName;

            if (this.mEntity.IconSmall != null)
                this.picIconSmall.Image = Common.ImageFromBytes(this.mEntity.IconSmall);
            else
                this.btnRemoveSmallIcon.Visible = false;

            if (this.mEntity.IconLarge != null)
                this.picIconLarge.Image = Common.ImageFromBytes(this.mEntity.IconLarge);
            else
                this.btnRemoveLargeIcon.Visible = false;

        }

        private void CheckPermission()
        {
            if (!AppContext.IsMainUser)
            {
                EntityCollection ent = AppContext.UserRoleEntities;
                foreach (Entity e in ent)
                {
                    if (e.DisplayName == "Entities")
                    {
                        if (!this.mEntity.IsNew)
                        {
                            this.btnDelete.Visible = AppContext.CanDelete(e.ObjectGuid);
                            this.btnSave.Visible = AppContext.CanEdit(e.ObjectGuid);
                        }
                    }
                }
            }
            else
            {
                if (!this.mEntity.IsNew)
                {
                    this.btnDelete.Visible = true;
                }
            }
        }

        protected override void OnDataSet()
        {
            base.OnDataSet();
            if (!Objectbase.IsNullOrEmpty(this.mEntity))
            {
                this.mEntity.Name = this.txtName.Text;
                this.mEntity.ListCaption = this.txtListCaption.Text;
                this.mEntity.ListTypeName = this.txtListTypeName.Text;
                this.mEntity.Caption = this.txtCaption.Text;
                this.mEntity.TypeName = this.txtTypeName.Text;

                this.mEntity.IconSmall = Common.BytesToImage(this.picIconSmall.Image);
                this.mEntity.IconLarge = Common.BytesToImage(this.picIconLarge.Image);

                this.mEntity.GroupName = this.cmbEntityGroup.Text;
                this.mEntity.Description = this.txtDescription.Text;
            }
        }

        public static bool ShowForm(Entity obj)
        {
            bool r = false;
            if (!Objectbase.IsNullOrEmpty(obj))
            {
                using (EntityForm frm = new EntityForm(obj))
                {
                    r = frm.ShowDialog() == DialogResult.OK;
                }
            }
            return r;
        }
    }
}
