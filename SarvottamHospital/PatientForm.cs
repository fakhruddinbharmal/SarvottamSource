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
    public partial class PatientForm : ObjectbaseForm
    {
        private Patient mEntry;
        private IPDPatientTreatments IPDPatienttreatments;
        private IPDPatientTreatment obj;
        #region PatientForm

        public PatientForm() : this(null) { }

        public PatientForm(Patient patient)
            : base(patient)
        {
            this.mEntry = patient;
            this.IPDPatienttreatments = new IPDPatientTreatments(this.mEntry.ObjectGuid);
            this.InitializeComponent();
            this.UserInitialize();

        }
        #endregion

        #region UserIntialize
        private void UserInitialize()
        {
            this.txtFirstName.Tag = this.lblFirstName;
            this.lblFirstName.Click += new EventHandler(OnLabelClick);
            this.txtFirstName.Enter += new EventHandler(OnControlEnter);
            this.txtFirstName.Leave += new EventHandler(OnControlLeave);

            this.txtMiddleName.Tag = this.lblMiddleName;
            this.lblMiddleName.Click += new EventHandler(OnLabelClick);
            this.txtMiddleName.Enter += new EventHandler(OnControlEnter);
            this.txtMiddleName.Leave += new EventHandler(OnControlLeave);

            this.txtLastName.Tag = this.lblLastName;
            this.lblLastName.Click += new EventHandler(OnLabelClick);
            this.txtLastName.Enter += new EventHandler(OnControlEnter);
            this.txtLastName.Leave += new EventHandler(OnControlLeave);

            this.cmbGender.Tag = this.lblGender;
            this.lblGender.Click += new EventHandler(OnLabelClick);
            this.cmbGender.Enter += new EventHandler(OnControlEnter);
            this.cmbGender.Leave += new EventHandler(OnControlLeave);

            this.nupAge.Tag = this.lblAge;
            this.lblAge.Click += new EventHandler(OnLabelClick);
            this.nupAge.Enter += new EventHandler(OnControlEnter);
            this.nupAge.Leave += new EventHandler(OnControlLeave);

            this.txtAddress.Tag = this.lblAddress;
            this.lblAddress.Click += new EventHandler(OnLabelClick);
            this.txtAddress.Enter += new EventHandler(OnControlEnter);
            this.txtAddress.Leave += new EventHandler(OnControlLeave);

            this.txtCity.Tag = this.lblCityTown;
            this.lblCityTown.Click += new EventHandler(OnLabelClick);
            this.txtCity.Enter += new EventHandler(OnControlEnter);
            this.txtCity.Leave += new EventHandler(OnControlLeave);

            this.txtContactNo.Tag = this.lblPhoneNo;
            this.lblPhoneNo.Click += new EventHandler(OnLabelClick);
            this.txtContactNo.Enter += new EventHandler(OnControlEnter);
            this.txtContactNo.Leave += new EventHandler(OnControlLeave);

            this.txtContactNo.Tag = this.lblPhoneNo;
            this.lblPhoneNo.Click += new EventHandler(OnLabelClick);
            this.txtContactNo.Enter += new EventHandler(OnControlEnter);
            this.txtContactNo.Leave += new EventHandler(OnControlLeave);

            this.dtpAdmitedDate.Tag = this.lblAdmitedDate;
            this.lblAdmitedDate.Click += new EventHandler(OnLabelClick);
            this.dtpAdmitedDate.Enter += new EventHandler(OnControlEnter);
            this.dtpAdmitedDate.Leave += new EventHandler(OnControlLeave);

            this.cmbAdmitedTime.Tag = this.lblAdmitedTime;
            this.lblAdmitedTime.Click += new EventHandler(OnLabelClick);
            this.cmbAdmitedTime.Enter += new EventHandler(OnControlEnter);
            this.cmbAdmitedTime.Leave += new EventHandler(OnControlLeave);

            this.cmbReferredDoctor.Tag = this.lblRefferedDoctor;
            this.lblRefferedDoctor.Click += new EventHandler(OnLabelClick);
            this.cmbReferredDoctor.Enter += new EventHandler(OnControlEnter);
            this.cmbReferredDoctor.Leave += new EventHandler(OnControlLeave);

            this.cmbWards.Tag = this.lblWards;
            this.lblWards.Click += new EventHandler(OnLabelClick);
            this.cmbWards.Enter += new EventHandler(OnControlEnter);
            this.cmbWards.Leave += new EventHandler(OnControlLeave);

            this.cmbRoomBedNo.Tag = this.lblRoomNo;
            this.lblRoomNo.Click += new EventHandler(OnLabelClick);
            this.cmbRoomBedNo.Enter += new EventHandler(OnControlEnter);
            this.cmbRoomBedNo.Leave += new EventHandler(OnControlLeave);

            this.lbTreatment.Tag = this.lblTreatment;
            this.lblTreatment.Click += new EventHandler(OnLabelClick);
            this.lbTreatment.Enter += new EventHandler(OnControlEnter);
            this.lbTreatment.Leave += new EventHandler(OnControlLeave);

            this.dtpDischargDate.Tag = this.lblDischargeDate;
            this.lblDischargeDate.Click += new EventHandler(OnLabelClick);
            this.dtpDischargDate.Enter += new EventHandler(OnControlEnter);
            this.dtpDischargDate.Leave += new EventHandler(OnControlLeave);

            this.dptInvoiceDate.Tag = this.lblInvoiceDate;
            this.lblInvoiceDate.Click += new EventHandler(OnLabelClick);
            this.dptInvoiceDate.Enter += new EventHandler(OnControlEnter);
            this.dptInvoiceDate.Leave += new EventHandler(OnControlLeave);

            this.txtNotes.Tag = this.lblNotes;
            this.lblNotes.Click += new EventHandler(OnLabelClick);
            this.txtNotes.Enter += new EventHandler(OnControlEnter);
            this.txtNotes.Leave += new EventHandler(OnControlLeave);

            this.nupReferredDoctorShare.Tag = this.lblReferredDoctorShare;
            this.lblReferredDoctorShare.Click += new EventHandler(OnLabelClick);
            this.nupReferredDoctorShare.Enter += new EventHandler(OnControlEnter);
            this.nupReferredDoctorShare.Leave += new EventHandler(OnControlLeave);

            this.txtOperation.Tag = this.lblOperation;
            this.lblOperation.Click += new EventHandler(OnLabelClick);
            this.txtOperation.Enter += new EventHandler(OnControlEnter);
            this.txtOperation.Leave += new EventHandler(OnControlLeave);
        }
        #endregion

        #region OnDataSet

        protected override void OnDataSet()
        {
            base.OnDataSet();
            if (!Objectbase.IsNullOrEmpty(this.mEntry))
            {
                this.mEntry.FirstName = txtFirstName.Text.Trim();
                this.mEntry.MiddleName = txtMiddleName.Text.Trim();
                this.mEntry.LastName = txtLastName.Text.Trim();
                this.mEntry.Gender = (Gender)this.cmbGender.SelectedItem;
                this.mEntry.Age = (int)(nupAge.Value);
                this.mEntry.Address = txtAddress.Text;
                this.mEntry.City = txtCity.Text;
                this.mEntry.ContactNo = txtContactNo.Text;
                this.mEntry.AdmittedDate = dtpAdmitedDate.Value;
                if (this.cmbAdmitedTime.SelectedItem != null)
                {
                    this.mEntry.AdmittedTime = cmbAdmitedTime.SelectedItem.ToString();
                }
                this.mEntry.ReferenceDoctor = cmbReferredDoctor.SelectedItem as ReferenceDoctor;
                this.mEntry.ReferenceDoctorShare = nupReferredDoctorShare.Value;
                this.mEntry.Ward = this.cmbWards.SelectedItem as Ward;
                this.mEntry.Room = this.cmbRoomBedNo.SelectedItem as Room;
                this.mEntry.Notes = txtNotes.Text;
                this.mEntry.IsDischarge = chkDischarge.Checked;
                this.mEntry.Operation = txtOperation.Text;
                this.mEntry.IsIPD = true;
                if (!this.mEntry.IsNew)
                {
                    if (chkDischarge.Checked)
                    {
                        if (this.mEntry.InvoiceNo <= 0)
                        {
                            this.mEntry.InvoiceNo = this.mEntry.MaxInvoiceNo > 0 == true ? this.mEntry.MaxInvoiceNo + 1 : 1;
                        }
                        if (dtpDischargDate.Enabled == true && dptInvoiceDate.Enabled == true)
                        {
                            this.mEntry.DischargeDate = dtpDischargDate.Value;
                            this.mEntry.InvoiceDate = dptInvoiceDate.Value;
                        }
                    }
                    else
                    {
                        this.mEntry.InvoiceNo = 0;
                        this.mEntry.DischargeDate = DateTime.MinValue;
                        this.mEntry.InvoiceDate = DateTime.MinValue;
                    }

                }

                // treatment
                this.mEntry.IPDPatientTreatment.Clear();

                for (int i = 0; i < lbTreatment.Items.Count; i++)
                {
                    if (lbTreatment.GetItemChecked(i))
                    {
                        obj = new IPDPatientTreatment();
                        Guid gd = new Guid(lbTreatment.Items[i].ToString());
                        obj.TreatmentGuid = gd;
                        this.mEntry.IPDPatientTreatment.Add(obj);
                    }

                }
                //
            }
        }

        #endregion

        protected override void OnDataShow()
        {
            base.OnDataShow();

            Wards wards = new Wards();
            this.cmbWards.DataSource = wards;
            this.cmbWards.DisplayMember = "DisplayName";

            Rooms rooms = new Rooms();
            this.cmbRoomBedNo.DataSource = rooms;
            this.cmbRoomBedNo.DisplayMember = "DisplayName";

            ReferenceDoctors referredDoctorList = new ReferenceDoctors();
            this.cmbReferredDoctor.DataSource = referredDoctorList;
            this.cmbReferredDoctor.DisplayMember = "DisplayName";

            Treatments treatmentLists = new Treatments();
            this.lbTreatment.DataSource = treatmentLists;
            this.lbTreatment.DisplayMember = "DisplayName";
            lbTreatment.SelectedItem = null;

            this.cmbGender.DataSource = Enum.GetValues(typeof(Gender));

            if (!Objectbase.IsNullOrEmpty(this.mEntry))
            {
                this.CheckPermission();
                //this.CheckFieldPermission();
                dtpDischargDate.Enabled = false;
                dptInvoiceDate.Enabled = false;
                this.txtFirstName.Select();
                this.txtFirstName.Text = this.mEntry.FirstName;
                this.txtMiddleName.Text = this.mEntry.MiddleName;
                this.txtLastName.Text = this.mEntry.LastName;
                this.cmbGender.SelectedItem = (Gender)this.mEntry.Gender;
                this.nupAge.Value = this.mEntry.Age;
                this.txtAddress.Text = this.mEntry.Address;
                this.txtCity.Text = this.mEntry.City;
                this.txtContactNo.Text = this.mEntry.ContactNo;
                this.cmbWards.SelectedItem = this.mEntry.Ward as Ward;
                this.chkDischarge.Checked = this.mEntry.IsDischarge;
                this.cmbAdmitedTime.SelectedItem = this.mEntry.AdmittedTime;
                this.cmbReferredDoctor.SelectedItem = this.mEntry.ReferenceDoctor as ReferenceDoctor;
                this.cmbRoomBedNo.SelectedItem = this.mEntry.Room;
                txtOperation.Text = this.mEntry.Operation;
                if (!string.IsNullOrEmpty(this.mEntry.DischargeDate.ToString()) && (this.mEntry.DischargeDate != DateTime.MinValue))
                {
                    this.dtpDischargDate.Value = this.mEntry.DischargeDate;
                }
                this.txtNotes.Text = this.mEntry.Notes;
                if (this.mEntry.IsNew)
                {
                    this.dtpAdmitedDate.Value = DateTime.Now;
                    chkDischarge.Visible = false;
                    dtpDischargDate.Visible = false;
                    dptInvoiceDate.Visible = false;
                    lblInvoiceDate.Visible = false;
                    lblDischargeDate.Visible = false;
                    chkDischarge.Enabled = false;
                }
                else
                {
                    if (!string.IsNullOrEmpty(this.mEntry.AdmittedDate.ToString()))
                        this.dtpAdmitedDate.Value = this.mEntry.AdmittedDate;
                    if (!string.IsNullOrEmpty(this.mEntry.DischargeDate.ToString()) && (this.mEntry.DischargeDate != DateTime.MinValue))
                    {
                        this.dtpDischargDate.Value = this.mEntry.DischargeDate;
                    }
                    if (!string.IsNullOrEmpty(this.mEntry.InvoiceDate.ToString()) && (this.mEntry.InvoiceDate != DateTime.MinValue))
                    {
                        this.dptInvoiceDate.Value = this.mEntry.InvoiceDate;
                    }
                    if (this.mEntry.ReferenceDoctor != null)
                    {
                        nupReferredDoctorShare.Visible = true;
                        this.lblReferredDoctorShare.Visible = true;
                    }
                    if (!this.mEntry.IsDischarge)
                    {
                        this.lblInvoiceDate.Visible = false;
                        this.lblDischargeDate.Visible = false;
                        this.dtpDischargDate.Visible = false;
                        this.dptInvoiceDate.Visible = false;
                    }
                    nupReferredDoctorShare.Value = this.mEntry.ReferenceDoctorShare;
                    this.cmbRoomBedNo.SelectedItem = this.mEntry.Room as Room;
                }

                // treatment
                if (this.IPDPatienttreatments.Count > 0)
                {
                    for (int i = 0; i < lbTreatment.Items.Count; i++)
                    {
                        for (int j = 0; j < this.IPDPatienttreatments.Count; j++)
                        {
                            if (IPDPatienttreatments[j].TreatmentGuid == new Guid(lbTreatment.Items[i].ToString()))
                            {
                                lbTreatment.SetItemChecked(i, true);
                                break;
                            }
                        }
                    }
                }
                //
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

            if (this.txtFirstName.Text.Trim().Length <= 0)
            {
                this.ShowTooltip(this.txtFirstName, "First Name", "First Name is Required!", ContentAlignment.TopLeft);
                if (r)
                    this.txtFirstName.Select();
                r = false;
            }


            if (this.cmbGender.SelectedItem == null)
            {
                this.ShowTooltip(this.cmbGender, "Gender", "Gender is required!", ContentAlignment.TopRight);
                if (r)
                    this.cmbGender.Select();
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
                using (PatientForm frm = new PatientForm(obj))
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
                dptInvoiceDate.Enabled = true;
                this.dtpDischargDate.Visible = true;
                this.dptInvoiceDate.Visible = true;
                this.lblDischargeDate.Visible = true;
                this.lblInvoiceDate.Visible = true;
            }
            else
            {
                dtpDischargDate.Enabled = false;
                dptInvoiceDate.Enabled = false;
                this.dtpDischargDate.Visible = false;
                this.dptInvoiceDate.Visible = false;
                this.lblDischargeDate.Visible = false;
                this.lblInvoiceDate.Visible = false;
            }
        }

        private void cmbReferredDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbReferredDoctor.SelectedItem != null)
            {
                var objReference = this.cmbReferredDoctor.SelectedItem as ReferenceDoctor;
                ReferenceDoctor obj = new ReferenceDoctor(objReference.ObjectGuid);
                this.lblReferredDoctorShare.Visible = true;
                this.nupReferredDoctorShare.Visible = true;
                this.nupReferredDoctorShare.Value = obj.Share;
            }
            else
            {
                this.lblReferredDoctorShare.Visible = false;
                this.nupReferredDoctorShare.Visible = false;
                this.nupReferredDoctorShare.Value = 0;
            }
        }

    }
}
