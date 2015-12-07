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
    public partial class AppointmentForm : SarvottamHospital.ObjectbaseForm
    {
        private Patient mPatient;

        private Appointment mEntry;

        private AppointmentCollection mAppointmentCollection;

        public AppointmentForm(Patient obj) :
            base(obj,false)
        {
            this.mPatient = obj;
            this.mEntry = new Appointment();
            this.mAppointmentCollection = new AppointmentCollection(this.mPatient.ObjectGuid);
           
            this.InitializeComponent();
            this.UserInitialize();
        }

        private void UserInitialize()
        {
            this.dtpAppointmentDate.Tag = this.lblAppointmentDate;
            this.lblAppointmentDate.Click += new EventHandler(OnLabelClick);
            this.dtpAppointmentDate.Enter += new EventHandler(OnControlEnter);
            this.dtpAppointmentDate.Leave += new EventHandler(OnControlLeave);

            this.txtAppointmentDescription.Tag = this.lblAppointmentDescription;
            this.lblAppointmentDescription.Click += new EventHandler(OnLabelClick);
            this.txtAppointmentDescription.Enter += new EventHandler(OnControlEnter);
            this.txtAppointmentDescription.Leave += new EventHandler(OnControlLeave);

            this.tsbOpen.Click += new EventHandler(this.OnOpenClick);
            this.dgvData.DoubleClick += new EventHandler(this.OnCellDoubleClick);                      
        }

        private Appointment GetSelectedProcedure(DataGridView dgv)
        {
            Appointment obj = null;
            if (dgv != null && dgv.CurrentRow != null)
                obj = dgv.CurrentRow.Tag as Appointment;
            return obj;
        }

        #region OnDataShow
        protected override void OnDataShow()
        {
            base.OnDataShow();
            this.txtFirstName.Text = this.mPatient.FirstName;
            this.txtLastName.Text = this.mPatient.LastName;
            this.txtMiddleName.Text = this.mPatient.MiddleName;

            this.txtAppointmentDescription.Text = this.mEntry.AppointmentDescription;
            if (!string.IsNullOrEmpty(this.mEntry.AppointmentDate.ToString()) && (this.mEntry.AppointmentDate != DateTime.MinValue))
            {
                this.dtpAppointmentDate.Value = this.mEntry.AppointmentDate;
            }
            LoadListData(GetSelectedProcedure(this.dgvData));
        }
        #endregion

        #region OnDataSet

        protected override void OnDataSet()
        {
            base.OnDataSet();
            if (!Objectbase.IsNullOrEmpty(this.mEntry))
            {
                this.mEntry.AppointmentDate = this.dtpAppointmentDate.Value;
                this.mEntry.AppointmentDescription = this.txtAppointmentDescription.Text;
                this.mPatient.Appointment = this.mEntry;
            }
        }
        #endregion

        #region OnSaveComplete

        protected override void OnSaveComplete()
        {
            base.OnSaveComplete();
            Appointment obj = this.GetSelectedProcedure(this.dgvData);
            this.LoadListData(obj);

            this.dtpAppointmentDate.Value = DateTime.Now;
            this.txtAppointmentDescription.Text = string.Empty;

            this.mEntry = new Appointment();

        }
        #endregion

        #region OnDeleteClick
        protected override void OnDeleteClick()
        {
            Appointment obj = this.GetSelectedProcedure(this.dgvData);
            if (obj != null)
            {
                this.mEntry = obj;
                this.mEntry.MarkToDelete();
                this.mEntry.UpdateChanges();
            }
            this.LoadListData(obj);
            this.dtpAppointmentDate.Value = DateTime.Now;
            this.txtAppointmentDescription.Text = string.Empty;

            this.mEntry = new Appointment();
        }
        #endregion

        #region OnCellDoubleClick
        private void OnCellDoubleClick(object sender, EventArgs e)
        {
            this.tsbOpen.PerformClick();
        }
        #endregion

        #region OnOpenClick
        private void OnOpenClick(object sender, EventArgs e)
        {
            Appointment obj = this.GetSelectedProcedure(this.dgvData);
            if (obj != null)
            {
                this.mEntry = obj;
                this.dtpAppointmentDate.Value = obj.AppointmentDate;
                this.txtAppointmentDescription.Text = obj.AppointmentDescription;
            }
        }
        #endregion

        #region OnLoadListData

        private void LoadListData(Appointment Selected)
        {
            int count = 0;
            this.LoadEntityList<Appointment>(this.dgvData, this.clmAppointmentDate.Index, new AppointmentCollection(this.mPatient.ObjectGuid), Selected, true, true,
                                            delegate(DataGridViewRow row, Appointment obj)
                                            {
                                                count++;
                                                row.Cells[this.clmAppointmentDate.Index].Value = obj.AppointmentDate.ToString() != string.Empty ? string.Format("{0:dd/MM/yyyy}", obj.AppointmentDate) : string.Empty;
                                                row.Cells[this.clmAppointmentDescription.Index].Value = obj.AppointmentDescription;
                                            }
            );
        }
        #endregion

        #region OnShowForm
        public static bool ShowForm(Patient obj)
        {
            bool r = false;
            if (!Objectbase.IsNullOrEmpty(obj))
            {
                using (AppointmentForm frm = new AppointmentForm(obj))
                {
                    r = frm.ShowDialog() == DialogResult.OK;
                }
            }
            return r;
        }
        #endregion
   
    }
}
