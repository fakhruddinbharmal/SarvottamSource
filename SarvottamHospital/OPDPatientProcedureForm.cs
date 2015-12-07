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
    public partial class OPDPatientProcedureForm : SarvottamHospital.ObjectbaseForm
    {
        private HistoryProcedure mHistoryProcedure;

        private ChiefComplain mChiefComplain;



        public OPDPatientProcedureForm() : this(null)
        {

        }

        public OPDPatientProcedureForm(HistoryProcedure obj) : base(obj)
        {            
            this.mHistoryProcedure = obj;
            this.InitializeComponent();
            this.UserInitialize();
        }

        private void UserInitialize()
        {
            //History Procedure

            this.cmbChiefComplain.Tag = this.lblChiefComplain;
            this.lblChiefComplain.Click += new EventHandler(OnLabelClick);
            this.cmbChiefComplain.Enter += new EventHandler(OnControlEnter);
            this.cmbChiefComplain.Leave += new EventHandler(OnControlLeave);

            this.cmbAssociateComplain.Tag = this.lblAssociateComplain;
            this.lblAssociateComplain.Click += new EventHandler(OnLabelClick);
            this.cmbAssociateComplain.Enter += new EventHandler(OnControlEnter);
            this.cmbAssociateComplain.Leave += new EventHandler(OnControlLeave);

            this.cmbHistoryOfProblem.Tag = this.lblHistoryOfProblem;
            this.lblHistoryOfProblem.Click += new EventHandler(OnLabelClick);
            this.cmbHistoryOfProblem.Enter += new EventHandler(OnControlEnter);
            this.cmbHistoryOfProblem.Leave += new EventHandler(OnControlLeave);

            this.txtProblemSince.Tag = this.lblProblemSince;
            this.lblProblemSince.Click += new EventHandler(OnLabelClick);
            this.txtProblemSince.Enter += new EventHandler(OnControlEnter);
            this.txtProblemSince.Leave += new EventHandler(OnControlLeave);

            this.txtAssociateComplainDuration.Tag = this.lblAssociateComplainDuration;
            this.lblAssociateComplainDuration.Click += new EventHandler(OnLabelClick);
            this.txtAssociateComplainDuration.Enter += new EventHandler(OnControlEnter);
            this.txtAssociateComplainDuration.Leave += new EventHandler(OnControlLeave);

            this.txtFamilyHistoryDuration.Tag = this.lblFamilyHistoryDuration;
            this.lblFamilyHistoryDuration.Click += new EventHandler(OnLabelClick);
            this.txtFamilyHistoryDuration.Enter += new EventHandler(OnControlEnter);
            this.txtFamilyHistoryDuration.Leave += new EventHandler(OnControlLeave);

            this.txtFamilyHistory.Tag = this.lblFamilyHistory;
            this.lblFamilyHistory.Click += new EventHandler(OnLabelClick);
            this.txtFamilyHistory.Enter += new EventHandler(OnControlEnter);
            this.txtFamilyHistory.Leave += new EventHandler(OnControlLeave);

            this.dtpHistoryDate.Tag = this.lblDate;
            this.lblDate.Click += new EventHandler(OnLabelClick);
            this.dtpHistoryDate.Enter += new EventHandler(OnControlEnter);
            this.dtpHistoryDate.Leave += new EventHandler(OnControlLeave);


            this.txtNewChiefComplain.Tag = this.lblAddNewChiefComplain;
            this.lblAddNewChiefComplain.Click += new EventHandler(OnLabelClick);
            this.txtNewChiefComplain.Enter += new EventHandler(OnControlEnter);
            this.txtNewChiefComplain.Leave += new EventHandler(OnControlLeave);


            this.txtNewAssociateComplain.Tag = this.lblNewAssociateComplain;
            this.lblNewAssociateComplain.Click += new EventHandler(OnLabelClick);
            this.txtNewAssociateComplain.Enter += new EventHandler(OnControlEnter);
            this.txtNewAssociateComplain.Leave += new EventHandler(OnControlLeave);

            this.txtNewHistoryOfProblem.Tag = this.lblNewHistoryOfProblem;
            this.lblNewHistoryOfProblem.Click += new EventHandler(OnLabelClick);
            this.txtNewHistoryOfProblem.Enter += new EventHandler(OnControlEnter);
            this.txtNewHistoryOfProblem.Leave += new EventHandler(OnControlLeave);

            this.btnAddNewChiefComplain.Click += new EventHandler(OnAddNewChiefComplainClick);
            this.btnAddNewAssociateComplain.Click += new EventHandler(OnAddNewAssociateComplainClick);
            this.btnAddNewHistory.Click += new EventHandler(OnAddNewHistoryClick);


            this.tsbOpen.Click += new EventHandler(this.OnOpenClick);
            this.dgvHistoryData.DoubleClick += new EventHandler(this.OnCellDoubleClick);
            this.tsbDelete.Click += new EventHandler(this.OnDeleteClick);
        }

        private void OnOpenClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnCellDoubleClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnDeleteClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnAddNewHistoryClick(object sender, EventArgs e)
        {
            History obj = new History(this.mHistoryProcedure);
            HistoryForm.ShowForm(obj);
            SarvottamHospital.Object.History.HistoryCollection historyList = new History.HistoryCollection();
            this.cmbHistoryOfProblem.DisplayMember = "DisplayName";
            this.cmbHistoryOfProblem.DataSource = historyList;
        }

        private void OnAddNewAssociateComplainClick(object sender, EventArgs e)
        {
            AssociateComplain obj = new AssociateComplain(this.mHistoryProcedure);
            AssociateComplainForm.ShowForm(obj);
            SarvottamHospital.Object.AssociateComplain.AssociateComplainCollection associateComplainList = new AssociateComplain.AssociateComplainCollection();
            this.cmbAssociateComplain.DisplayMember = "DisplayName";
            this.cmbAssociateComplain.DataSource = associateComplainList;
            
        }

        private void OnAddNewChiefComplainClick(object sender, EventArgs e)
        {
            ChiefComplain obj = new ChiefComplain(this.mHistoryProcedure);
            ChiefComplainForm.ShowForm(obj);
            SarvottamHospital.Object.ChiefComplain.ChiefComplainCollection chiefComplainList = new SarvottamHospital.Object.ChiefComplain.ChiefComplainCollection();
            this.cmbChiefComplain.DisplayMember = "DisplayName";
            this.cmbChiefComplain.DataSource = chiefComplainList;

        }

        protected override void OnDataSet()
        {
            base.OnDataSet();
            if (!Objectbase.IsNullOrEmpty(this.mHistoryProcedure))
            {
                this.mHistoryProcedure.ProblemSince = this.txtProblemSince.Text;
                this.mHistoryProcedure.AssociateComplainDuration = this.txtAssociateComplainDuration.Text;
                this.mHistoryProcedure.FamilyHistory = this.txtFamilyHistory.Text;
                this.mHistoryProcedure.FamilyHistoryDuration = this.txtFamilyHistoryDuration.Text;
                this.mHistoryProcedure.Date = this.dtpHistoryDate.Value;
                this.mHistoryProcedure.chiefcomplain = this.cmbChiefComplain.SelectedItem as ChiefComplain;
                this.mHistoryProcedure.Associatecomplain = this.cmbAssociateComplain.SelectedItem as AssociateComplain;
                this.mHistoryProcedure.History = this.cmbHistoryOfProblem.SelectedItem as History;
                
            }
        }

        protected override void OnDataShow()
        {
            base.OnDataShow();
            this.cmbChiefComplain.Select();

            SarvottamHospital.Object.ChiefComplain.ChiefComplainCollection chiefComplainList = new SarvottamHospital.Object.ChiefComplain.ChiefComplainCollection();
            this.cmbChiefComplain.DisplayMember = "DisplayName";            
            this.cmbChiefComplain.DataSource = chiefComplainList;

            SarvottamHospital.Object.AssociateComplain.AssociateComplainCollection associateComplainList = new AssociateComplain.AssociateComplainCollection();
            this.cmbAssociateComplain.DisplayMember = "DisplayName";
            this.cmbAssociateComplain.DataSource = associateComplainList;

            SarvottamHospital.Object.History.HistoryCollection historyList = new History.HistoryCollection();
            this.cmbHistoryOfProblem.DisplayMember = "DisplayName";
            this.cmbHistoryOfProblem.DataSource = historyList;

        }

        public static bool ShowForm(HistoryProcedure obj)
        {
            bool r = false;
            if (!Objectbase.IsNullOrEmpty(obj))
            {
                using (OPDPatientProcedureForm frm = new OPDPatientProcedureForm(obj))
                {
                    r = frm.ShowDialog() == DialogResult.OK;
                }
            }
            return r;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
