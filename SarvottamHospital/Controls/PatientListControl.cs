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
    public partial class PatientListControl : ObjectListControl
    {
        public PatientListControl()
            : base()
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

            this.tsbPatientProcedure.Click += new EventHandler(OnpatientProcedureClick);
            this.dgvData.CellDoubleClick += new DataGridViewCellEventHandler(this.OnCellDoubleClick);
            this.dgvData.CellContentClick += new DataGridViewCellEventHandler(this.CellContentClick);
        }

        private void OnpatientProcedureClick(object sender, EventArgs e)
        {
            Patient obj = this.GetSelected();
            PatientProcedureForm.ShowForm(obj);
            //this.LoadListData(obj);
        }

        private void tsbSearch_Click(object sender, EventArgs e)
        {
            this.LoadListData(this.GetSelectedEntityObject());
        }

        private Patient GetSelectedEntityObject()
        {
            return GetSelectedEntity(this.dgvData) as Patient;
        }

        private void LoadListData(Patient selected)
        {
            int count = 0;
            DateTime fromDate = dtpDateFrom.Checked == true ? dtpDateFrom.Value : DateTime.MinValue;
            DateTime toDate = dtpDateTo.Checked == true ? dtpDateTo.Value : DateTime.MaxValue;

            this.LoadEntityList<Patient>(this.dgvData, this.clmNumber.Index, new Patients(tstSearch.Text,true, cmbPatientStatus.SelectedIndex, fromDate, toDate), selected,
                delegate(DataGridViewRow row, Patient obj)
                {
                    count++;
                    row.Cells[this.clmNumber.Index].Value = obj.Number;
                    row.Cells[this.clmPatientName.Index].Value = obj.DisplayName;
                    row.Cells[this.clmAdmitedDate.Index].Value = Common.DateToString(obj.AdmittedDate);
                    row.Cells[this.clmGender.Index].Value = obj.Gender;
                    row.Cells[this.clmContactNo.Index].Value = obj.ContactNo;
                    row.Cells[this.clmAge.Index].Value = Common.IntToString(obj.Age);
                    row.Cells[this.clmCity.Index].Value = obj.City;
                    row.Cells[this.clmWard.Index].Value = obj.WardName;
                    row.Cells[this.clmRoom.Index].Value = obj.RoomTypeName;
                    row.Cells[this.clmDischargeDate.Index].Value = Common.DateToString(obj.DischargeDate);
                    row.Cells[this.clmGuid.Index].Value = obj.ObjectGuid;
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

        private void OnCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e != null && e.RowIndex >= 0)
                this.tsbOpen.PerformClick();
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.SendCloseTabRequest();
        }

        private void OnAddClick(object sender, EventArgs e)
        {
            Patient obj = new Patient();
            if (PatientForm.ShowForm(obj))
                this.LoadListData(obj);
        }

        private Patient GetSelected()
        {
            return GetSelectedEntity(this.dgvData) as Patient;
        }

        private void OnOpenClick(object sender, EventArgs e)
        {
            Patient obj = this.GetSelected();

            if (obj != null)
                obj.RefershData();

            if (PatientForm.ShowForm(obj))
                this.LoadListData(obj);
        }

        private void OnSearchClick(object sender, EventArgs e)
        {
            this.LoadListData(this.GetSelected());
        }

        private void OnCloseClick(object sender, EventArgs e)
        {
            this.SendCloseTabRequest();
        }

        private void cmbPatientStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LoadListData(this.GetSelectedEntityObject());
        }

        private void CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && ((DataGridView)sender).Columns[e.ColumnIndex].GetType() == typeof(DataGridViewImageColumn))
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = dgvData.Rows[rowIndex];
                PatientInvoice p = new PatientInvoice();
                p.PatientGuid = (Guid)(row.Cells[12].Value);
                p.Show();

            }

        }
    }
}
