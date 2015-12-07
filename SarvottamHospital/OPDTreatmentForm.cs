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
    public partial class OPDTreatmentForm : SarvottamHospital.ObjectbaseForm
    {
        private OPDTreatment mEntry;

        #region OPDTreatmentForm

        public OPDTreatmentForm() : this(null) { }

        public OPDTreatmentForm(OPDTreatment opdTreatment) : base(opdTreatment)
        {
            this.mEntry = opdTreatment;
            this.InitializeComponent();
            this.UserInitialize();
            
        }

        #endregion

        #region UserIntialize
        private void UserInitialize()
        {
            this.cmbChiefComplain.Tag = this.lblChiefComplain;
            this.lblChiefComplain.Click += new EventHandler(OnLabelClick);
            this.cmbChiefComplain.Enter += new EventHandler(OnControlEnter);
            this.cmbChiefComplain.Leave += new EventHandler(OnControlLeave);

            this.txtTreatment.Tag = this.lblTreatment;
            this.lblTreatment.Click += new EventHandler(OnLabelClick);
            this.txtTreatment.Enter += new EventHandler(OnControlEnter);
            this.txtTreatment.Leave += new EventHandler(OnControlLeave);
        

            this.txtDescription.Tag = this.lblDescription;
            this.lblDescription.Click += new EventHandler(OnLabelClick);
            this.txtDescription.Enter += new EventHandler(OnControlEnter);
            this.txtDescription.Leave += new EventHandler(OnControlLeave);
        }
        #endregion

        #region OnDataSet
        protected override void OnDataSet()
        {
            base.OnDataSet();
            if (!Objectbase.IsNullOrEmpty(this.mEntry))
            {
                this.mEntry.chiefcomplain = this.cmbChiefComplain.SelectedItem as ChiefComplain;
                this.mEntry.Name = txtTreatment.Text;
                this.mEntry.Description = txtDescription.Text;                
            }
        }            
        #endregion

        #region OnDataShow

        protected override void OnDataShow()
        {
            base.OnDataShow();
            ChiefComplainCollection opdtreatmentcollection = new ChiefComplainCollection();            
            this.cmbChiefComplain.DataSource = opdtreatmentcollection;
            this.cmbChiefComplain.DisplayMember = "DisplayName";
            this.cmbChiefComplain.SelectedItem = null;

            if (!Objectbase.IsNullOrEmpty(this.mEntry))
            {
                this.CheckPermission();
                this.cmbChiefComplain.SelectedItem = this.mEntry.chiefcomplain;
                this.txtTreatment.Text = this.mEntry.Name;
                this.txtDescription.Text = this.mEntry.Description;
                this.cmbChiefComplain.Select();
            }
        }

        private void CheckPermission()
        {
            if (!AppContext.IsMainUser)
            {
                EntityCollection ent = AppContext.UserRoleEntities;
                foreach (Entity e in ent)
                {
                    if (e.DisplayName == "OPDTreatment")
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
                    this.btnDelete.Visible = true;
            }
        }
        #endregion

        #region OnDataValidation
        protected override bool OnDataValidation()
        {
            bool r = true;
            if (Objectbase.IsNullOrEmpty(this.cmbChiefComplain.SelectedItem as ChiefComplain))
            {
                this.ShowTooltip(this.cmbChiefComplain, "ChiefComplain", "ChiefComplain is required", ContentAlignment.TopRight);
                if (r)
                    this.cmbChiefComplain.Select();
                r = false;
            }
            if (this.txtTreatment.Text.Trim().Length <= 0)
            {
                this.ShowTooltip(this.txtTreatment, "Treatment", "Treatment is Required!", ContentAlignment.TopLeft);
                if (r)
                    this.txtTreatment.Select();
                r = false;
            }
            return r && base.OnDataValidation();
        }
        #endregion

        public static bool ShowForm(OPDTreatment obj)
        {
            bool r = false;
            if (!Objectbase.IsNullOrEmpty(obj))
            {
                using (OPDTreatmentForm frm = new OPDTreatmentForm(obj))
                {
                    r = frm.ShowDialog() == DialogResult.OK;
                }
            }
            return r;
        }
    }
}
