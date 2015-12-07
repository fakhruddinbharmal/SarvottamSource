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
    public partial class OPDPatientForm : ObjectbaseForm
    {
        private Patient mEntry;

        #region PatientForm
        public OPDPatientForm() : this(null) { }
        public OPDPatientForm(Patient patient)
            : base(patient)
        {
            this.mEntry = patient;
            this.InitializeComponent();
            this.UserInitialize();

        }
        #endregion

        #region UserIntialize
        private void UserInitialize()
        {
            this.txtOPDFirstName.Tag = this.lblOPDFirstName;
            this.lblOPDFirstName.Click += new EventHandler(OnLabelClick);
            this.txtOPDFirstName.Enter += new EventHandler(OnControlEnter);
            this.txtOPDFirstName.Leave += new EventHandler(OnControlLeave);

            this.txtOPDMiddleName.Tag = this.lblOPDMiddleName;
            this.lblOPDMiddleName.Click += new EventHandler(OnLabelClick);
            this.txtOPDMiddleName.Enter += new EventHandler(OnControlEnter);
            this.txtOPDMiddleName.Leave += new EventHandler(OnControlLeave);

            this.txtOPDLastName.Tag = this.lblOPDLastName;
            this.lblOPDLastName.Click += new EventHandler(OnLabelClick);
            this.txtOPDLastName.Enter += new EventHandler(OnControlEnter);
            this.txtOPDLastName.Leave += new EventHandler(OnControlLeave);

            this.cmbOPDGender.Tag = this.lblOPDGender;
            this.lblOPDGender.Click += new EventHandler(OnLabelClick);
            this.cmbOPDGender.Enter += new EventHandler(OnControlEnter);
            this.cmbOPDGender.Leave += new EventHandler(OnControlLeave);

            this.nupOPDAge.Tag = this.lblOPDAge;
            this.lblOPDAge.Click += new EventHandler(OnLabelClick);
            this.nupOPDAge.Enter += new EventHandler(OnControlEnter);
            this.nupOPDAge.Leave += new EventHandler(OnControlLeave);

            this.txtOPDAddress.Tag = this.lblOPDAddress;
            this.lblOPDAddress.Click += new EventHandler(OnLabelClick);
            this.txtOPDAddress.Enter += new EventHandler(OnControlEnter);
            this.txtOPDAddress.Leave += new EventHandler(OnControlLeave);

            this.txtOPDCity.Tag = this.lblOPDCityTown;
            this.lblOPDCityTown.Click += new EventHandler(OnLabelClick);
            this.txtOPDCity.Enter += new EventHandler(OnControlEnter);
            this.txtOPDCity.Leave += new EventHandler(OnControlLeave);

            this.txtOPDContactNo.Tag = this.lblOPDPhoneNo;
            this.lblOPDPhoneNo.Click += new EventHandler(OnLabelClick);
            this.txtOPDContactNo.Enter += new EventHandler(OnControlEnter);
            this.txtOPDContactNo.Leave += new EventHandler(OnControlLeave);

            this.txtOPDContactNo.Tag = this.lblOPDPhoneNo;
            this.lblOPDPhoneNo.Click += new EventHandler(OnLabelClick);
            this.txtOPDContactNo.Enter += new EventHandler(OnControlEnter);
            this.txtOPDContactNo.Leave += new EventHandler(OnControlLeave);

           
            this.txtNotes.Tag = this.lblOPDNotes;
            this.lblOPDNotes.Click += new EventHandler(OnLabelClick);
            this.txtNotes.Enter += new EventHandler(OnControlEnter);
            this.txtNotes.Leave += new EventHandler(OnControlLeave);

          
        }
        #endregion

        #region OnDataSet

        protected override void OnDataSet()
        {
            base.OnDataSet();
            if (!Objectbase.IsNullOrEmpty(this.mEntry))
            {
                this.mEntry.FirstName = txtOPDFirstName.Text.Trim();
                this.mEntry.MiddleName = txtOPDMiddleName.Text.Trim();
                this.mEntry.LastName = txtOPDLastName.Text.Trim();
                this.mEntry.Gender = (Gender)this.cmbOPDGender.SelectedItem;
                this.mEntry.Age = (int)(nupOPDAge.Value);
                this.mEntry.Address = txtOPDAddress.Text;
                this.mEntry.City = txtOPDCity.Text;
                this.mEntry.ContactNo = txtOPDContactNo.Text;               
                this.mEntry.Notes = txtNotes.Text;                
                this.mEntry.IsIPD = false;

                this.mEntry.IsDischarge = chkDischarge.Checked;
                if (!this.mEntry.IsNew)
                {
                    if (chkDischarge.Checked)
                    {
                        if (dtpDischargDate.Enabled == true)
                        {
                            this.mEntry.DischargeDate = dtpDischargDate.Value;
                        }
                    }
                }
                else
                {
                    this.mEntry.DischargeDate = DateTime.MinValue;
                }
                                
            }
        }

        #endregion

        protected override void OnDataShow()
        {
            base.OnDataShow();          
            this.cmbOPDGender.DataSource = Enum.GetValues(typeof(Gender));

            if (!Objectbase.IsNullOrEmpty(this.mEntry))
            {
                this.CheckPermission();
                //this.CheckFieldPermission();
                this.txtOPDFirstName.Select();
                this.txtOPDFirstName.Text = this.mEntry.FirstName;
                this.txtOPDMiddleName.Text = this.mEntry.MiddleName;
                this.txtOPDLastName.Text = this.mEntry.LastName;
                this.cmbOPDGender.SelectedItem = (Gender)this.mEntry.Gender;
                this.nupOPDAge.Value = this.mEntry.Age;
                this.txtOPDAddress.Text = this.mEntry.Address;
                this.txtOPDCity.Text = this.mEntry.City;
                this.txtOPDContactNo.Text = this.mEntry.ContactNo;
                this.txtNotes.Text = this.mEntry.Notes;
                this.chkDischarge.Checked = this.mEntry.IsDischarge;
                if (this.mEntry.IsNew)
                {
                    chkDischarge.Visible = false;
                    chkDischarge.Enabled = false;
                    dtpDischargDate.Visible = false;
                    lblDischargeDate.Visible = false;
                }
                else
                {
                    if (!string.IsNullOrEmpty(this.mEntry.DischargeDate.ToString()) && (this.mEntry.DischargeDate != DateTime.MinValue))
                    {
                        this.dtpDischargDate.Value = this.mEntry.DischargeDate;
                    }
                    if (!this.mEntry.IsDischarge)
                    {                       
                        this.lblDischargeDate.Visible = false;
                        this.dtpDischargDate.Visible = false;                        
                    }
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
                    if (e.DisplayName == "Patient Details")
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

       //private void CheckFieldPermission()
       // {
       //     if (!AppContext.IsMainUser)
       //     {
       //         FieldCollection field = AppContext.UserRoleFields;
       //         foreach (Field f in field)
       //         {
       //             if (f.DisplayName == "ReferredDoctorShare")
       //             {
       //                 this.nupReferredDoctorShare.Visible = this.lblReferredDoctorShare.Visible = AppContext.CanFieldView(f.ObjectGuid);
       //             }
       //         }
       //     }
       // }

        #region OnDataValidation
        protected override bool OnDataValidation()
        {
            bool r = true;

            if (this.txtOPDFirstName.Text.Trim().Length <= 0)
            {
                this.ShowTooltip(this.txtOPDFirstName, "First Name", "First Name is Required!", ContentAlignment.TopLeft);
                if (r)
                    this.txtOPDFirstName.Select();
                r = false;
            }


            if (this.cmbOPDGender.SelectedItem == null)
            {
                this.ShowTooltip(this.cmbOPDGender, "Gender", "Gender is required!", ContentAlignment.TopRight);
                if (r)
                    this.cmbOPDGender.Select();
                r = false;
            }

            return r && base.OnDataValidation();
        }
        #endregion

        public static bool ShowForm(Patient obj)
        {
            bool r = false;
            if (!Objectbase.IsNullOrEmpty(obj))
            {
                using (OPDPatientForm frm = new OPDPatientForm(obj))
                {
                    r = frm.ShowDialog() == DialogResult.OK;
                }
            }
            return r;
        }

        private void chkDischarge_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDischarge.Checked)
            {
                dtpDischargDate.Enabled = true;
                this.dtpDischargDate.Visible = true;
                this.lblDischargeDate.Visible = true;
            }
            else
            {
                dtpDischargDate.Enabled = false;
                this.dtpDischargDate.Visible = false;
                this.lblDischargeDate.Visible = false;
            }
        }

       

        
    }
}
