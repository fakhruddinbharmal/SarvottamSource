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
    public partial class MedicineForm : SarvottamHospital.ObjectbaseForm
    {
        private Medicine mEntry;

        #region MedicineForm
        public MedicineForm() : this(null) { }
        public MedicineForm(Medicine medicine)  : base(medicine)
        {
            this.mEntry = medicine;
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

            this.txtMedicine.Tag = this.lblMedicine;
            this.lblMedicine.Click += new EventHandler(OnLabelClick);
            this.txtMedicine.Enter += new EventHandler(OnControlEnter);
            this.txtMedicine.Leave += new EventHandler(OnControlLeave);


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
                this.mEntry.Name = txtMedicine.Text;
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
                this.txtMedicine.Text = this.mEntry.Name;
                this.txtDescription.Text = this.mEntry.Description;
                this.cmbChiefComplain.Select();
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
            if (this.txtMedicine.Text.Trim().Length <= 0)
            {
                this.ShowTooltip(this.txtMedicine, "Medicine", "Medicine is Required!", ContentAlignment.TopLeft);
                if (r)
                    this.txtMedicine.Select();
                r = false;
            }
            return r && base.OnDataValidation();
        }
        #endregion

        public static bool ShowForm(Medicine obj)
        {
            bool r = false;
            if (!Objectbase.IsNullOrEmpty(obj))
            {
                using (MedicineForm frm = new MedicineForm(obj))
                {
                    r = frm.ShowDialog() == DialogResult.OK;
                }
            }
            return r;
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

    }
}
