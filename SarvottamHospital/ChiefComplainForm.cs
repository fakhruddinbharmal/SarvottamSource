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
    public partial class ChiefComplainForm : SarvottamHospital.ObjectbaseForm
    {
        private ChiefComplain mEntry;

        #region ChiefComplainForm

        public ChiefComplainForm() : this(null) { }

        public ChiefComplainForm(ChiefComplain chiefcomplain)
            : base(chiefcomplain)
        {
            this.mEntry = chiefcomplain;
            this.InitializeComponent();
        }              
        #endregion

        #region UserInitialize

        public void UserInitialize()
        {
            this.txtChiefComplain.Tag = this.lblChiefComplain;
            lblChiefComplain.Click += new EventHandler(OnLabelClick);
            txtChiefComplain.Enter += new EventHandler(OnControlEnter);
            txtChiefComplain.Leave += new EventHandler(OnControlLeave);

            this.txtChiefComplainDesc.Tag = this.lblChiefComplainDesc;
            lblChiefComplainDesc.Click += new EventHandler(OnLabelClick);
            txtChiefComplainDesc.Enter += new EventHandler(OnControlEnter);
            txtChiefComplainDesc.Leave += new EventHandler(OnControlLeave);
        }
        #endregion

        #region OnDataSet

        protected override void OnDataSet()
        {
            base.OnDataSet();
            if (!Objectbase.IsNullOrEmpty(this.mEntry))
            {
                this.mEntry.Name = txtChiefComplain.Text.Trim();
                this.mEntry.Description = txtChiefComplainDesc.Text.Trim();
            }
        } 

        #endregion

        #region OnDataShow

        protected override void OnDataShow()
        {
            base.OnDataShow();
            if (!Objectbase.IsNullOrEmpty(this.mEntry))
            { 
                //this.c
                this.txtChiefComplain.Text = this.mEntry.Name;
                this.txtChiefComplainDesc.Text = this.mEntry.Description;
                this.txtChiefComplain.Select();
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
                    if (e.DisplayName == "Chief Complain Details")
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
            if (this.txtChiefComplain.Text.Trim().Length <= 0)
            {
                this.ShowTooltip(this.txtChiefComplain, "Chief Complain", "Chief Complain is Required!", ContentAlignment.TopRight);
                if (r)
                    this.txtChiefComplain.Select();
                r = false;
            }           
            return r && base.OnDataValidation();
        }
        #endregion

        #region ShowForm
        public static bool ShowForm(ChiefComplain obj)
        {
            bool r = false;
            if (!Objectbase.IsNullOrEmpty(obj))
            {
                using (ChiefComplainForm frm = new ChiefComplainForm(obj))
                {
                    r = frm.ShowDialog() == DialogResult.OK;
                }
            }
            return r;
        }
        #endregion
    }
}
