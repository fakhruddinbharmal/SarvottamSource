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
    public partial class PatientProcedureForm : ObjectbaseForm
    {
        private Patient mPatient;

        private PatientProcedures mPatientProcedureCollection;

        private PatientProcedure mEntry;

        public PatientProcedureForm(Patient obj)
            : base(obj, false)
        {
            this.mPatient = obj;
            this.mPatientProcedureCollection = new PatientProcedures(obj.ObjectGuid);
            this.mEntry = new PatientProcedure();
            this.InitializeComponent();
            this.UserInitialize();
        }

        private void UserInitialize()
        {
            this.dtpProcedureDate.Tag = this.lblProcedureDate;
            this.lblProcedureDate.Click += new EventHandler(OnLabelClick);
            this.dtpProcedureDate.Enter += new EventHandler(OnControlEnter);
            this.dtpProcedureDate.Leave += new EventHandler(OnControlLeave);

            this.cmbProcedure.Tag = this.lblProcedure;
            this.lblProcedure.Click += new EventHandler(OnLabelClick);
            this.cmbProcedure.Enter += new EventHandler(OnControlEnter);
            this.cmbProcedure.Leave += new EventHandler(OnControlLeave);

            this.nupAmount.Tag = this.lblAmount;
            this.lblAmount.Click += new EventHandler(OnLabelClick);
            this.nupAmount.Enter += new EventHandler(OnControlEnter);
            this.nupAmount.Leave += new EventHandler(OnControlLeave);

            this.txtNotes.Tag = this.lblNotes;
            this.lblNotes.Click += new EventHandler(OnLabelClick);
            this.txtNotes.Enter += new EventHandler(OnControlEnter);
            this.txtNotes.Leave += new EventHandler(OnControlLeave);

            this.tsbOpen.Click += new EventHandler(this.OnOpenClick);
            this.dgvData.DoubleClick += new EventHandler(this.OnCellDoubleClick);

            // this.btnChild.Click += new EventHandler(OnChildClick);
            this.dgvData.DoubleClick += new EventHandler(this.OnCellDoubleClick);
            btnDelete.Visible = false;

            this.btnGenerateBill.Click += new EventHandler(this.OnGenerateBillClick);
        }

        #region OnDataShow

        protected override void OnDataShow()
        {
            base.OnDataShow();
            this.cmbProcedure.Select();
            this.Text = "Manage Patient Procedure";

            Procedures procedures = new Procedures();
            this.cmbProcedure.DataSource = procedures;
            this.cmbProcedure.DisplayMember = "DisplayName";

            this.txtFirstName.Text = this.mPatient.FirstName;
            this.txtMiddleName.Text = this.mPatient.MiddleName;
            this.txtLastName.Text = this.mPatient.LastName;

            this.dtpAdmitedDate.Value = this.mPatient.AdmittedDate;
            LoadPatientAllProcedure(GetSelectedProcedure(this.dgvData));
        }

        #endregion

        private PatientProcedure GetSelectedProcedure(DataGridView dgv)
        {
            PatientProcedure obj = null;
            if (dgv != null && dgv.CurrentRow != null)
                obj = dgv.CurrentRow.Tag as PatientProcedure;
            return obj;
        }

        #region OnDataSet

        protected override void OnDataSet()
        {
            base.OnDataSet();
            if (!Objectbase.IsNullOrEmpty(this.mEntry))
            {
                this.mEntry.Patient = mPatient;
                this.mEntry.ProcedureDate = this.dtpProcedureDate.Value;
                this.mEntry.Procedure = this.cmbProcedure.SelectedItem as Procedure;
                this.mEntry.Amount = nupAmount.Value;
                this.mEntry.Notes = txtNotes.Text;
                this.mPatient.PatientProcedure = this.mEntry;
                //this.mPatient.PatientProcedure = this.mEntry;
            }
        }

        #endregion

        #region onSaveComplete

        protected override void OnSaveComplete()
        {
            base.OnSaveComplete();
            PatientProcedure obj = this.GetSelectedProcedure(this.dgvData);
            this.LoadPatientAllProcedure(obj);
            this.cmbProcedure.SelectedIndex = 0;
            this.nupAmount.ResetText();
            this.txtNotes.ResetText();
            this.mEntry = new PatientProcedure();
            this.cmbProcedure.Focus();
        }

        #endregion

        #region onOpenclick

        private void OnOpenClick(object sender, EventArgs e)
        {
            PatientProcedure obj = this.GetSelectedProcedure(this.dgvData);
            if (obj != null)
            {
                this.mEntry = obj;
                this.cmbProcedure.SelectedItem = obj.Procedure;
                this.dtpProcedureDate.Value = obj.ProcedureDate;
                this.nupAmount.Value = obj.Amount;
                this.txtNotes.Text = obj.Notes;
            }
        }

        #endregion

        #region Ondeleteclick

        protected override void OnDeleteClick()
        {
            PatientProcedure obj = this.GetSelectedProcedure(this.dgvData);
            if (obj != null)
            {
                this.mEntry = obj;
                this.mEntry.MarkToDelete();
                this.mEntry.UpdateChanges();
            }
            LoadPatientAllProcedure(GetSelectedProcedure(this.dgvData));
        }

        #endregion

        #region oncelldoubleclick

        private void OnCellDoubleClick(object sender, EventArgs e)
        {
            this.tsbOpen.PerformClick();
        }

        #endregion

        #region ondatavalidation
        protected override bool OnDataValidation()
        {
            bool r = true;

            if (this.dtpProcedureDate.Text.Trim().Length <= 0)
            {
                this.ShowTooltip(this.dtpProcedureDate, "Procedure  Date", "Procedure date is required", ContentAlignment.TopRight);
                if (r)
                    this.dtpProcedureDate.Select();
                r = false;
            }

            if (Objectbase.IsNullOrEmpty(this.cmbProcedure.SelectedItem as Procedure))
            {
                this.ShowTooltip(this.cmbProcedure, "Procedure", "Procedure is required", ContentAlignment.TopRight);
                if (r)
                    this.cmbProcedure.Select();
                r = false;
            }

            if (nupAmount.Value <= 0)
            {
                this.ShowTooltip(this.nupAmount, "Amount", "Amount is required", ContentAlignment.TopRight);
                if (r)
                    this.nupAmount.Select();
                r = false;
            }
            return r && base.OnDataValidation();
        }

        #endregion

        #region loadpatientprocedure

        private void LoadPatientAllProcedure(PatientProcedure selected)
        {
            int count = 0;
            decimal totalAmount = 0;
            decimal balanceToCollect = 0;
            this.LoadEntityList<PatientProcedure>(this.dgvData, this.clmProcedureDate.Index, new PatientProcedures(this.mPatient.ObjectGuid), selected, true, true,
                delegate(DataGridViewRow row, PatientProcedure obj)
                {
                    count++;
                    row.Cells[this.clmProcedureDate.Index].Value = Common.DateToString(obj.ProcedureDate);
                    row.Cells[this.clmProcedure.Index].Value = obj.ProcedureName;
                    row.Cells[this.clmAmount.Index].Value = obj.Amount;
                    row.Cells[this.clmNotes.Index].Value = obj.Notes;
                    totalAmount = totalAmount + obj.Amount;
                }
            );
            balanceToCollect = totalAmount;
            lblTotalAmountValue.Text = totalAmount.ToString();
            lblBalanceToCollectValue.Text = balanceToCollect.ToString();
        }

        #endregion

        #region showform

        public static bool ShowForm(Patient obj)
        {
            bool r = false;
            if (!Objectbase.IsNullOrEmpty(obj))
            {
                using (PatientProcedureForm frm = new PatientProcedureForm(obj))
                {
                    r = frm.ShowDialog() == DialogResult.OK;
                }
            }
            return r;
        }

        #endregion

        #region generateBill

        private void OnGenerateBillClick(object sender, EventArgs e)
        {
            PatientInvoice p = new PatientInvoice();
            p.PatientGuid = mPatient.ObjectGuid;
            p.Show();
        }
        #endregion
    }
}
