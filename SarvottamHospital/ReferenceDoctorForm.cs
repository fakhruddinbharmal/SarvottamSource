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
    public partial class ReferenceDoctorForm : ObjectbaseForm
    {
        private ReferenceDoctor mEntry;

        #region ReferenceDoctorForm

        public ReferenceDoctorForm() : this(null) { }

        public ReferenceDoctorForm(ReferenceDoctor referenceDoctor)
            : base(referenceDoctor)
        {
            this.mEntry = referenceDoctor;
            this.InitializeComponent();
            this.UserInitialize();
        }

        #endregion

        #region UserIntialize
        private void UserInitialize()
        {
            this.txtName.Tag = this.lblName;
            lblName.Click += new EventHandler(OnLabelClick);
            txtName.Enter += new EventHandler(OnControlEnter);
            txtName.Leave += new EventHandler(OnControlLeave);

            this.txtDesc.Tag = this.lblDesc;
            this.lblDesc.Click += new EventHandler(OnLabelClick);
            this.txtDesc.Enter += new EventHandler(OnControlEnter);
            this.txtDesc.Leave += new EventHandler(OnControlLeave);

            this.nupShare.Tag = this.lblShare;
            this.lblShare.Click += new EventHandler(OnLabelClick);
            this.nupShare.Enter += new EventHandler(OnControlEnter);
            this.nupShare.Leave += new EventHandler(OnControlLeave);
        }
        #endregion

        #region OnDataSet
        protected override void OnDataSet()
        {
            base.OnDataSet();
            if (!Objectbase.IsNullOrEmpty(this.mEntry))
            {
                this.mEntry.Name = txtName.Text.Trim();
                this.mEntry.Share = nupShare.Value;
                this.mEntry.Description = txtDesc.Text.Trim();
            }
        }
        #endregion

        #region OnDataShow
        protected override void OnDataShow()
        {
            base.OnDataShow();
            if (!Objectbase.IsNullOrEmpty(this.mEntry))
            {
                this.CheckPermission();
                this.txtName.Text = this.mEntry.Name;
                this.nupShare.Value = this.mEntry.Share;
                this.txtDesc.Text = this.mEntry.Description;
                this.txtName.Select();
            }
        }
        #endregion

        #region CheckPermission
        private void CheckPermission()
        {
            if (!AppContext.IsMainUser)
            {
                EntityCollection ent = AppContext.UserRoleEntities;
                foreach (Entity e in ent)
                {
                    if (e.DisplayName == "Reference Doctors Details")
                    {
                        if (!this.mEntry.IsNew)
                        {
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
        #endregion

        #region OnDataValidation
        protected override bool OnDataValidation()
        {
            bool r = true;
            if (this.txtName.Text.Trim().Length <= 0)
            {
                this.ShowTooltip(this.txtName, "Name", "Name is Required!", ContentAlignment.TopRight);
                if (r)
                    this.txtName.Select();
                r = false;
            }

            return r && base.OnDataValidation();
        }
        #endregion

        #region ShowForm
        public static bool ShowForm(ReferenceDoctor obj)
        {
            bool r = false;
            if (!Objectbase.IsNullOrEmpty(obj))
            {
                using (ReferenceDoctorForm frm = new ReferenceDoctorForm(obj))
                {
                    r = frm.ShowDialog() == DialogResult.OK;
                }
            }
            return r;
        }
        #endregion
    }
}
