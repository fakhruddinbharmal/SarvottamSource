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
    public partial class WardForm : ObjectbaseForm
    {
        private Ward mEntry;

        #region WardForm

        public WardForm() : this(null) { }

        public WardForm(Ward ward)
            : base(ward)
        {
            this.mEntry = ward;
            this.InitializeComponent();
            this.UserInitialize();
        }

        #endregion

        #region UserIntialize
        private void UserInitialize()
        {
            this.txtWardName.Tag = this.lblWardName;
            lblWardName.Click += new EventHandler(OnLabelClick);
            txtWardName.Enter += new EventHandler(OnControlEnter);
            txtWardName.Leave += new EventHandler(OnControlLeave);

            this.txtWardDesc.Tag = this.lblDesc;
            this.lblDesc.Click += new EventHandler(OnLabelClick);
            this.txtWardDesc.Enter += new EventHandler(OnControlEnter);
            this.txtWardDesc.Leave += new EventHandler(OnControlLeave);
        }
        #endregion

        #region OnDataSet
        protected override void OnDataSet()
        {
            base.OnDataSet();
            if (!Objectbase.IsNullOrEmpty(this.mEntry))
            {
                this.mEntry.Name = txtWardName.Text.Trim();
                this.mEntry.Description = txtWardDesc.Text.Trim();
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
                this.txtWardName.Text = this.mEntry.Name;
                this.txtWardDesc.Text = this.mEntry.Description;
                this.txtWardName.Select();
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
                    if (e.DisplayName == "Wards Details")
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
            if (this.txtWardName.Text.Trim().Length <= 0)
            {
                this.ShowTooltip(this.txtWardName, "Ward Name", "Ward Name is Required!", ContentAlignment.TopRight);
                if (r)
                    this.txtWardName.Select();
                r = false;
            }

            return r && base.OnDataValidation();
        }
        #endregion

        #region ShowForm
        public static bool ShowForm(Ward obj)
        {
            bool r = false;
            if (!Objectbase.IsNullOrEmpty(obj))
            {
                using (WardForm frm = new WardForm(obj))
                {
                    r = frm.ShowDialog() == DialogResult.OK;
                }
            }
            return r;
        }
        #endregion
    }
}
