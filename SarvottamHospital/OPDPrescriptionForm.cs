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
    public partial class OPDPrescriptionForm : SarvottamHospital.ObjectbaseForm
    {
        private OPDPrescription mOPDPrescription;

        private Patient mPatient;

        private OPDPrescriptionCollection mOPDPrescriptionCollection;

        //Medicine 

        private OPDMedicines OPDMedicines;

        private OPDPrescriptionProcedureMedicine obj;


        public OPDPrescriptionForm( Patient obj)
            :base(obj,false)
        {
            this.mPatient = obj;
            this.mOPDPrescription = new OPDPrescription();

            this.mOPDPrescriptionCollection = new OPDPrescriptionCollection(this.mPatient.ObjectGuid);

            //Medicine

            this.OPDMedicines = new Object.OPDMedicines(this.mOPDPrescription.ObjectGuid);

            this.InitializeComponent();
            this.UserInitialize();
        }

        private void UserInitialize()
        {
            this.cmbMedicine.Tag = this.lblMedicine;
            this.lblMedicine.Click += new EventHandler(OnLabelClick);
            this.cmbMedicine.Enter += new EventHandler(OnControlEnter);
            this.cmbMedicine.Leave += new EventHandler(OnControlLeave);

            this.txtDoseage.Tag = this.lblDoseage;
            this.lblDoseage.Click += new EventHandler(OnLabelClick);
            this.txtDoseage.Enter += new EventHandler(OnControlEnter);
            this.txtDoseage.Leave += new EventHandler(OnControlLeave);

            this.txtTimings.Tag = this.lblTimings;
            this.lblTimings.Click += new EventHandler(OnLabelClick);
            this.txtTimings.Enter += new EventHandler(OnControlEnter);
            this.txtTimings.Leave += new EventHandler(OnControlLeave);

            this.dptPrescriptionDate.Tag = this.lblPrescriptionDate;
            this.lblPrescriptionDate.Click += new EventHandler(OnLabelClick);
            this.dptPrescriptionDate.Enter += new EventHandler(OnControlEnter);
            this.dptPrescriptionDate.Leave += new EventHandler(OnControlLeave);

            this.btnAddNewMedicine.Click += new EventHandler(OnAddNewMedicineClick);

            this.tsbOpen.Click += new EventHandler(this.OnOpenClick);
            this.dgvPrescription.DoubleClick += new EventHandler(this.OnCellDoubleClick);
        }

        private void OnAddNewMedicineClick(object sender, EventArgs e)
        {
            Medicine obj = new Medicine(this.mOPDPrescription);
            MedicineForm.ShowForm(obj);
            MedicineCollection opdMedicineList = new MedicineCollection();
            this.cmbMedicine.DataSource = opdMedicineList;
            this.cmbMedicine.DisplayMember = "DisplayName";
        }

        private OPDPrescription GetSelectedProcedure(DataGridView dgv)
        {
            OPDPrescription obj = null;
            if (dgv != null && dgv.CurrentRow != null)
                obj = dgv.CurrentRow.Tag as OPDPrescription;
            return obj;
        }
        
        #region OnDataShow

        protected override void OnDataShow()
        {
            base.OnDataShow();
            this.cmbMedicine.Select();
            this.Text = "Prescription";

            //Medicine
            MedicineCollection opdMedicineList = new MedicineCollection();
            this.cmbMedicine.DataSource = opdMedicineList;
            this.cmbMedicine.DisplayMember = "DisplayName";
            this.cmbMedicine.SelectedItem = null;

            this.txtDoseage.Text = this.mOPDPrescription.Doseage;
            this.txtTimings.Text = this.mOPDPrescription.Timings;
            if (!string.IsNullOrEmpty(this.mOPDPrescription.OPDPrescriptionDate.ToString()) && (this.mOPDPrescription.OPDPrescriptionDate != DateTime.MinValue))
            {
                this.dptPrescriptionDate.Value = this.mOPDPrescription.OPDPrescriptionDate;
            }
            // Medicine

            if (this.OPDMedicines.Count > 0)
            {
                for (int i = 0; i < cmbMedicine.Items.Count; i++)
                {
                    for (int j = 0; j < this.OPDMedicines.Count; j++)
                    {
                        if (OPDMedicines[j].MedicineGuid == new Guid(cmbMedicine.Items[i].ToString()))
                        {
                            cmbMedicine.SetItemChecked(i, true);
                            break;
                        }
                    }
                }
            }
            LoadListPrescriptionData(GetSelectedProcedure(this.dgvPrescription));
        }
        #endregion

        #region OnDataSet

        protected override void OnDataSet()
        {
            if (!Objectbase.IsNullOrEmpty(this.mOPDPrescription))
            {
                this.mOPDPrescription.Doseage = this.txtDoseage.Text;
                this.mOPDPrescription.Timings = this.txtTimings.Text;
                this.mOPDPrescription.OPDPrescriptionDate = this.dptPrescriptionDate.Value;

                //Medicine

                this.mPatient.OPDPrescription = this.mOPDPrescription;
                this.mOPDPrescription.OPDMedicines.Clear();

                for (int i = 0; i < cmbMedicine.Items.Count; i++)
                {
                    if (cmbMedicine.GetItemChecked(i))
                    {
                        obj = new OPDPrescriptionProcedureMedicine();
                        Guid gd = new Guid(cmbMedicine.Items[i].ToString());
                        obj.PatientGuid = this.mPatient.ObjectGuid;
                        obj.MedicineGuid = gd;
                        this.mOPDPrescription.OPDMedicines.Add(obj);
                    }
                }
                for (int i = 0; i < cmbMedicine.Items.Count; i++)
                {
                    if (cmbMedicine.GetItemChecked(i)) 
                    {
                        cmbMedicine.SetItemChecked(i, false);
                    }
                }
            }
        }
        #endregion

        #region OnSaveComplete

        protected override void OnSaveComplete()
        {
            base.OnSaveComplete();
            OPDPrescription obj = this.GetSelectedProcedure(this.dgvPrescription);    
            LoadListPrescriptionData(obj);

            this.cmbMedicine.SelectedIndex = 0;
            this.txtDoseage.ResetText();
            this.txtTimings.ResetText();
            this.dptPrescriptionDate.Value = DateTime.Now;

            this.mOPDPrescription = new OPDPrescription();
        }
        #endregion

        #region OnOpenClick
        private void OnOpenClick(object sender, EventArgs e)
        {
            OPDPrescription obj = this.GetSelectedProcedure(this.dgvPrescription);
            if (obj != null)
            {
                obj.RefershData();
                this.mOPDPrescription = obj;
                for (int i = 0; i < cmbMedicine.Items.Count; i++)
                {
                    if (cmbMedicine.GetItemChecked(i))
                    {
                        cmbMedicine.SetItemChecked(i, false);
                    }
                }
                if (this.mOPDPrescription.OPDMedicines.Count > 0)
                {
                    for (int i = 0; i < cmbMedicine.Items.Count; i++)
                    {
                        for (int j = 0; j < this.mOPDPrescription.OPDMedicines.Count; j++)
                        {
                            if (mOPDPrescription.OPDMedicines[j].MedicineGuid == new Guid(cmbMedicine.Items[i].ToString()))
                            {
                                cmbMedicine.SetItemChecked(i, true);
                                break;
                            }
                        }
                    }
                }

                this.txtDoseage.Text = obj.Doseage;
                this.txtTimings.Text = obj.Timings;
                this.dptPrescriptionDate.Value = obj.OPDPrescriptionDate;

            }
        }
        #endregion

        #region OnDeleteClick
        protected override void OnDeleteClick()
        {
            OPDPrescription obj = this.GetSelectedProcedure(this.dgvPrescription);
            if (obj != null)
            {
                this.mOPDPrescription = obj;
                this.mOPDPrescription.MarkToDelete();
                this.mOPDPrescription.UpdateChanges();                
            }
            for (int i = 0; i < cmbMedicine.Items.Count; i++)
            {
                if (cmbMedicine.GetItemChecked(i))
                {
                    cmbMedicine.SetItemChecked(i, false);
                }
            }
            this.txtDoseage.ResetText();
            this.txtTimings.ResetText();
            this.dptPrescriptionDate.Value = DateTime.Now;
            LoadListPrescriptionData(obj);
            this.mOPDPrescription = new OPDPrescription();
            this.cmbMedicine.SelectedItem = null;
        }
        #endregion

        #region OnCellDoubleClick
        private void OnCellDoubleClick(object sender, EventArgs e)
        {
            this.tsbOpen.PerformClick();
            this.cmbMedicine.SelectedItem = null;
            
        }
        #endregion

        #region OnDataValidation

        protected override bool OnDataValidation()
        {
            bool r = true;
            if (Objectbase.IsNullOrEmpty(this.cmbMedicine.SelectedItem as Medicine))
            {
                this.ShowTooltip(this.cmbMedicine, "Medicine", "Medicine is required", ContentAlignment.TopRight);
                if (r)
                    this.cmbMedicine.Select();
                r = false;
            }
            if (this.txtDoseage.Text.Trim().Length <= 0)
            {
                this.ShowTooltip(this.txtDoseage, "Doseage", "Doseage is Required!", ContentAlignment.TopRight);
                if (r)
                    this.txtDoseage.Select();
                r = false;
            }
            if (this.txtTimings.Text.Trim().Length <= 0)
            {
                this.ShowTooltip(this.txtTimings, "Timings", "Timings is Required!", ContentAlignment.TopRight);
                if (r)
                    this.txtTimings.Select();
                r = false;
            }

            return r && base.OnDataValidation();
        }
        #endregion

        #region LoadListPrescriptionData

        private void LoadListPrescriptionData(OPDPrescription Selected)
        {
            int count = 0;
            this.LoadEntityList<OPDPrescription>(this.dgvPrescription,this.clmPrescriptionDate.Index,new OPDPrescriptionCollection(this.mPatient.ObjectGuid),Selected,   
                                                    true,true,delegate(DataGridViewRow row,OPDPrescription obj)
                                                    {
                                                        count++;
                                                        row.Cells[this.clmMedicine.Index].Value = obj.Medicine;
                                                        row.Cells[this.clmDoseage.Index].Value = obj.Doseage;
                                                        row.Cells[this.clmTimings.Index].Value = obj.Timings;
                                                        row.Cells[this.clmPrescriptionDate.Index].Value = obj.OPDPrescriptionDate.ToString() != string.Empty ? string.Format("{0:dd/MM/yyyy}", obj.OPDPrescriptionDate) : string.Empty;                                      
                                                    }
            );                                                    
        }
        #endregion

        #region ShowForm

        public static bool ShowForm(Patient obj)
        {
            bool r = false;
            if (!Objectbase.IsNullOrEmpty(obj))
            {
                using (OPDPrescriptionForm frm = new OPDPrescriptionForm(obj))
                {
                    r = frm.ShowDialog() == DialogResult.OK;
                }
            }
            return r;
        }
        #endregion
    }
}
