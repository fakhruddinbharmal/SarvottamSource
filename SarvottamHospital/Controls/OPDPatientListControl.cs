using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SarvottamHospital.Object;
using SarvottamHospital;

namespace SarvottamHospital.Controls
{
    public partial class OPDPatientListControl : ObjectListControl
    {
        public OPDPatientListControl()
        {
            InitializeComponent();
            this.tspToolbar.Font = Common.ApplicationFont;

            this.FormatGrid(this.dgvData);

            this.tstSearch.TextBox.Enter += new EventHandler(this.OnControlEnter);
            this.tstSearch.TextBox.Leave += new EventHandler(this.OnControlLeave);

            this.tstSearch.KeyDown += new KeyEventHandler(this.OnSearchKeyDown);
            this.dgvData.KeyDown += new KeyEventHandler(this.OnGridKeyDown);

            this.tsbAdd.Click += new EventHandler(this.OnAddClick);
            this.tsbOpen.Click += new EventHandler(this.OnOpenClick);
            this.tsbSearch.Click += new EventHandler(this.OnSearchClick);
            this.tsbClose.Click += new EventHandler(this.OnCloseClick);

            //this.tsbOPDInvestigationProcedure.Click += new EventHandler(OnpatientProcedureClick);
            
            this.dgvData.CellDoubleClick += new DataGridViewCellEventHandler(this.OnCellDoubleClick);
        }

        private void LoadListData(Patient selected)
        {
            int count = 0;
            DateTime fromDate = dtpDateFrom.Checked == true ? dtpDateFrom.Value : DateTime.MinValue;
            DateTime toDate = dtpDateTo.Checked == true ? dtpDateTo.Value : DateTime.MaxValue;

            this.LoadEntityList<Patient>(this.dgvData, this.clmNumber.Index, new Patients(tstSearch.Text, false, cmbPatientStatus.SelectedIndex, fromDate, toDate), selected,
                delegate(DataGridViewRow row, Patient obj)
                {
                    count++;
                    row.Cells[this.clmNumber.Index].Value = obj.Number;
                    row.Cells[this.clmPatientName.Index].Value = obj.DisplayName;                    
                    row.Cells[this.clmGender.Index].Value = obj.Gender;
                    row.Cells[this.clmContactNo.Index].Value = obj.ContactNo;
                    row.Cells[this.clmAge.Index].Value = Common.IntToString(obj.Age);
                    row.Cells[this.clmCity.Index].Value = obj.City;                    
                }
            );
            bool hasRows = count > 0;
            this.tsbOpen.Enabled = hasRows;
        }

        protected override void LoadListData()
        {
            EntityCollection ent = AppContext.UserRoleEntities;
            foreach (Entity e in ent)
            {
                if (e.DisplayName == "Patient Details")
                {
                    this.tsbAdd.Enabled = AppContext.CanCreate(e.ObjectGuid);
                }
            }
            cmbPatientStatus.SelectedIndex = 0;
            this.LoadListData(this.GetSelectedEntityObject());
        }

        private void OnAddClick(object sender, EventArgs e)
        {
            Patient obj = new Patient();
            if (OPDPatientForm.ShowForm(obj))
                this.LoadListData(obj);
        }

        private void OnOpenClick(object sender, EventArgs e)
        {
            Patient obj = this.GetSelected();

            if (obj != null)
                obj.RefershData();

            if (OPDPatientForm.ShowForm(obj))
                this.LoadListData(obj);
        }
        
        private void OnSearchKeyDown(object sender, KeyEventArgs e)
        {
            if (e != null && e.KeyCode == Keys.Enter)
            {
                this.tsbSearch.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void OnGridKeyDown(object sender, KeyEventArgs e)
        {
            if (e != null)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    this.tsbOpen.PerformClick();
                    e.SuppressKeyPress = true;
                }
                else if (e.KeyCode == Keys.Add || e.KeyCode == Keys.Oemplus)
                {
                    this.tsbAdd.PerformClick();
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.SendCloseTabRequest();
        }

        private Patient GetSelected()
        {
            return GetSelectedEntity(this.dgvData) as Patient;
        }

        private Patient GetSelectedEntityObject()
        {
            return GetSelectedEntity(this.dgvData) as Patient;
        }

        private void OnCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e != null && e.RowIndex >= 0)
                this.tsbOpen.PerformClick();
        }

        private void OnSearchClick(object sender, EventArgs e)
        {
            this.LoadListData(this.GetSelected());
        }

        private void OnCloseClick(object sender, EventArgs e)
        {
            this.SendCloseTabRequest();
        }

        private void tsbSearch_Click(object sender, EventArgs e)
        {
            this.LoadListData(this.GetSelectedEntityObject());
        }

        private void cmbPatientStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LoadListData(this.GetSelectedEntityObject());
        }

        private void tsbOPDInvestigationProcedure_Click(object sender, EventArgs e)
        {
            Patient obj = this.GetSelected();
             OPDInvestigationForm.ShowForm(obj);
        }

        private void tsbOPDHistoryProcedure_Click(object sender, EventArgs e)
        {
            Patient obj = this.GetSelected();
            HistoryProcedureForm.ShowForm(obj); 
        }

        private void tsbOPDTreatmentProcedure_Click(object sender, EventArgs e)
        {
            Patient obj = this.GetSelected();
            OPDTreatmentProcedureForm.ShowForm(obj);
        }

        private void tsbOPDPrescription_Click(object sender, EventArgs e)
        {
            Patient obj = this.GetSelected();
            OPDPrescriptionForm.ShowForm(obj);

        }

        private void tsbAppointment_Click(object sender, EventArgs e)
        {
            Patient obj = this.GetSelected();
            AppointmentForm.ShowForm(obj);
        }

        private void tsbAppointmentReport_Click(object sender, EventArgs e)
        {
            OPDPatientAppointmentReport obj = new OPDPatientAppointmentReport();
            obj.Show();
        }
    }
}
