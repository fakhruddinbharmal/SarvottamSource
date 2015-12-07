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
    public partial class OPDTreatmentProcedureForm : SarvottamHospital.ObjectbaseForm
    {
        private OPDTreatmentProcedure mOpdTreatmentProcedure;

        private Patient mPatient;

        private OPDTreatmentProcedureCollection mOPDTreatmentProcedureCollection;

        private OPDTreatments OPDTreatments;

        private OPDTreatmentProcedureTreatment obj;

        public OPDTreatmentProcedureForm(Patient obj)
            :base(obj,false)
        {           
            this.mPatient = obj;
            this.mOpdTreatmentProcedure = new OPDTreatmentProcedure();

            this.mOPDTreatmentProcedureCollection = new OPDTreatmentProcedureCollection(this.mPatient.ObjectGuid);
            this.OPDTreatments = new OPDTreatments(this.mOpdTreatmentProcedure.ObjectGuid);

            this.InitializeComponent();
            this.UserInitialize();
        }

        private void UserInitialize()
        {
            this.cmbTreatment.Tag = this.lblTreatment;
            this.lblTreatment.Click += new EventHandler(OnLabelClick);
            this.cmbTreatment.Enter += new EventHandler(OnControlEnter);
            this.cmbTreatment.Leave += new EventHandler(OnControlLeave);

            this.btnAddNewTreatment.Click += new EventHandler(OnAddNewTreatmentClick);
            this.tsbOpen.Click += new EventHandler(this.OnOpenClick);
            this.dgvTreatmentProcedure.DoubleClick += new EventHandler(this.OnCellDoubleClick);
        }

        private void OnAddNewTreatmentClick(object sender, EventArgs e)
        {
            OPDTreatment obj = new OPDTreatment(this.mOpdTreatmentProcedure);
            OPDTreatmentForm.ShowForm(obj);
            OPDTreatmentCollection opdTreatmentList = new OPDTreatmentCollection();
            this.cmbTreatment.DataSource = opdTreatmentList;
            this.cmbTreatment.DisplayMember = "DisplayName";   
        }

        private OPDTreatmentProcedure GetSelectedProcedure(DataGridView dgv)
        {
            OPDTreatmentProcedure obj = null;
            if (dgv != null && dgv.CurrentRow != null)
                obj = dgv.CurrentRow.Tag as OPDTreatmentProcedure;
            return obj;

        }

        #region OnDataShow

        protected override void OnDataShow()
        {
            base.OnDataShow();
            this.cmbTreatment.Select();
            this.Text = "Treatment";

            OPDTreatmentCollection opdTreatmentList = new OPDTreatmentCollection();
            this.cmbTreatment.DataSource = opdTreatmentList;
            this.cmbTreatment.DisplayMember = "DisplayName";
            this.cmbTreatment.SelectedItem = null;

            if (!string.IsNullOrEmpty(this.mOpdTreatmentProcedure.OPDTreatmentDate.ToString()) && (this.mOpdTreatmentProcedure.OPDTreatmentDate != DateTime.MinValue))
            {
                this.dptTreatmentDate.Value = this.mOpdTreatmentProcedure.OPDTreatmentDate;
            }
            // Treatments

            if (this.OPDTreatments.Count > 0)
            {
                for (int i = 0; i < cmbTreatment.Items.Count; i++)
                {
                    for (int j = 0; j < this.OPDTreatments.Count; j++)
                    {
                        if (OPDTreatments[j].TreatmentGuid == new Guid(cmbTreatment.Items[i].ToString()))
                        {
                            cmbTreatment.SetItemChecked(i, true);
                            break;
                        }
                    }
                }
            }
            LoadOPDTreatmentProcedure(GetSelectedProcedure(this.dgvTreatmentProcedure));
        }
        #endregion
        
        #region OnDataSet

        protected override void OnDataSet()
        {
            
            if (!Objectbase.IsNullOrEmpty(this.mOpdTreatmentProcedure))
            {
                this.mOpdTreatmentProcedure.OPDTreatmentDate = this.dptTreatmentDate.Value;
                // treatment 

                this.mPatient.OPDTreatmentProcedure = this.mOpdTreatmentProcedure;
                this.mOpdTreatmentProcedure.OPDTreatments.Clear();

                for (int i = 0; i < cmbTreatment.Items.Count; i++)
                {
                    if (cmbTreatment.GetItemChecked(i))
                    {
                        obj = new OPDTreatmentProcedureTreatment();
                        Guid gd = new Guid(cmbTreatment.Items[i].ToString());
                        obj.PatientGuid = this.mPatient.ObjectGuid;
                        obj.TreatmentGuid = gd;
                        this.mOpdTreatmentProcedure.OPDTreatments.Add(obj);
                    }
                }

                for (int i = 0; i < cmbTreatment.Items.Count; i++)
                {
                    if (cmbTreatment.GetItemChecked(i))
                    {
                        cmbTreatment.SetItemChecked(i, false);
                    }
                }
            }
        }
        #endregion

        #region OnSaveComplete

        protected override void OnSaveComplete()
        {
            base.OnSaveComplete();
            OPDTreatmentProcedure obj = this.GetSelectedProcedure(this.dgvTreatmentProcedure);
            this.LoadOPDTreatmentProcedure(obj);
            
            this.cmbTreatment.SelectedIndex = 0;
            this.dptTreatmentDate.Value = DateTime.Now;
            this.mOpdTreatmentProcedure = new OPDTreatmentProcedure();
        }

        #endregion

        #region OnOpenClick

        private void OnOpenClick(object sender, EventArgs e)
        {
            OPDTreatmentProcedure obj = this.GetSelectedProcedure(this.dgvTreatmentProcedure);
            if (obj != null)
            {
                obj.RefershData();               
                this.mOpdTreatmentProcedure = obj;
                for (int i = 0; i < cmbTreatment.Items.Count; i++)
                {
                    if (cmbTreatment.GetItemChecked(i))
                    {
                        cmbTreatment.SetItemChecked(i, false);
                    }
                }
                if (this.mOpdTreatmentProcedure.OPDTreatments.Count > 0)
                {
                    for (int i = 0; i < cmbTreatment.Items.Count; i++)
                    {
                        for (int j = 0; j < this.mOpdTreatmentProcedure.OPDTreatments.Count; j++)
                        {
                            if (mOpdTreatmentProcedure.OPDTreatments[j].TreatmentGuid == new Guid(cmbTreatment.Items[i].ToString()))
                            {
                                cmbTreatment.SetItemChecked(i, true);
                                break;
                            }
                        }
                    }
                }
                this.dptTreatmentDate.Value = obj.OPDTreatmentDate;
            }
        }

        #endregion

        #region OnDeleteClick

        protected override void OnDeleteClick()
        {
            OPDTreatmentProcedure obj = this.GetSelectedProcedure(this.dgvTreatmentProcedure);

            if (obj != null)
            {
                this.mOpdTreatmentProcedure = obj;
                this.mOpdTreatmentProcedure.MarkToDelete();
                this.mOpdTreatmentProcedure.UpdateChanges();
            }
            for (int i = 0; i < cmbTreatment.Items.Count; i++)
            {
                if (cmbTreatment.GetItemChecked(i))
                {
                    cmbTreatment.SetItemChecked(i, false);
                }
            }
            this.dptTreatmentDate.Value = DateTime.Now;           
            LoadOPDTreatmentProcedure(GetSelectedProcedure(this.dgvTreatmentProcedure));
            this.mOpdTreatmentProcedure = new OPDTreatmentProcedure();
            this.cmbTreatment.SelectedItem = null;
        }  
        #endregion

        #region OnCellDoubleClick
        private void OnCellDoubleClick(object sender, EventArgs e)
        {
            this.tsbOpen.PerformClick();
            this.cmbTreatment.SelectedItem = null;
        }
        #endregion

        #region OnDataValidation
        protected override bool OnDataValidation()
        {
            bool r = true;
            if (Objectbase.IsNullOrEmpty(this.cmbTreatment.SelectedItem as OPDTreatment))
            {
                this.ShowTooltip(this.cmbTreatment, "OPDTreatment", "Treatment is required", ContentAlignment.TopRight);
                if (r)
                    this.cmbTreatment.Select();
                r = false;
            }
            return r && base.OnDataValidation();
        }
        #endregion

        #region LoadOPDTreatmentProcedure

        private void LoadOPDTreatmentProcedure(OPDTreatmentProcedure selected)
        {
            int count = 0;
            this.LoadEntityList<OPDTreatmentProcedure>(this.dgvTreatmentProcedure, this.clmTreatmentDate.Index, new OPDTreatmentProcedureCollection(this.mPatient.ObjectGuid), selected, true, true,
                                                        delegate(DataGridViewRow row, OPDTreatmentProcedure obj)
                                                        {
                                                            count++;
                                                            row.Cells[this.clmTreatment.Index].Value = obj.Treatment;
                                                            row.Cells[this.clmTreatmentDate.Index].Value = obj.OPDTreatmentDate.ToString() != string.Empty ? string.Format("{0:dd/MM/yyyy}", obj.OPDTreatmentDate) : string.Empty;
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
                using (OPDTreatmentProcedureForm frm = new OPDTreatmentProcedureForm(obj))
                {
                    r = frm.ShowDialog() == DialogResult.OK;
                }
            }
            return r;
        }
        #endregion
    }
}
