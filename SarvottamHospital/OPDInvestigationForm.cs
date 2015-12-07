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
    public partial class OPDInvestigationForm : SarvottamHospital.ObjectbaseForm
    {
        private OPDInvestigationProcedure mOPDInvestigationProcedure;

        private Patient mPatient;

        private OPDInvestigationProcedureCollection mOPDInvestigationProcedureCollection;

        // Main Investigation
        private OPDMainInvestigations OPDMainInvestigations;

        private OPDInvestigationProcedureMainInvestigation obj;


        //Lab Investigation
    
        private OPDLabInvestigations OPDLabInvestigations;

        private OPDInvestigationProcedureLabInvestigation obj1;


        public OPDInvestigationForm(Patient obj)
             : base(obj,false)
        {
            this.mPatient = obj;
            this.mOPDInvestigationProcedure = new OPDInvestigationProcedure();

            this.mOPDInvestigationProcedureCollection = new OPDInvestigationProcedureCollection(this.mPatient.ObjectGuid);
            // Main Investigation
            this.OPDMainInvestigations = new OPDMainInvestigations(this.mOPDInvestigationProcedure.ObjectGuid);
            //Lab Investigation
            this.OPDLabInvestigations = new OPDLabInvestigations(this.mOPDInvestigationProcedure.ObjectGuid);

            this.InitializeComponent();
            this.UserInitialize();
        }

        private void UserInitialize()
        {
            this.cmbMainInvestigation.Tag = this.lblMainInvestigation;
            this.lblMainInvestigation.Click += new EventHandler(OnLabelClick);
            this.cmbMainInvestigation.Enter += new EventHandler(OnControlEnter);
            this.cmbMainInvestigation.Leave += new EventHandler(OnControlLeave);

            this.cmbLabInvestigation.Tag = this.lblLabInvestigation;
            this.lblLabInvestigation.Click += new EventHandler(OnLabelClick);
            this.cmbLabInvestigation.Enter += new EventHandler(OnControlEnter);
            this.cmbLabInvestigation.Leave += new EventHandler(OnControlLeave);

            this.txtRadiologyInvestigation.Tag = this.lblRadiologyInvestigation;
            this.lblRadiologyInvestigation.Click += new EventHandler(OnLabelClick);
            this.txtRadiologyInvestigation.Enter += new EventHandler(OnControlEnter);
            this.txtRadiologyInvestigation.Leave += new EventHandler(OnControlLeave);

            this.txtSpecialInvestigation.Tag = this.lblSpecialInvestigation;
            this.lblSpecialInvestigation.Click += new EventHandler(OnLabelClick);
            this.txtSpecialInvestigation.Enter += new EventHandler(OnControlEnter);
            this.txtSpecialInvestigation.Leave += new EventHandler(OnControlLeave);

            this.dptInvestigationDate.Tag = this.lblInvestigationDate;
            this.lblInvestigationDate.Click += new EventHandler(OnLabelClick);
            this.dptInvestigationDate.Enter += new EventHandler(OnControlEnter);
            this.dptInvestigationDate.Leave += new EventHandler(OnControlLeave);

            this.btnAddNewLabInvestigation.Click += new EventHandler(OnAddNewLabInvestigationClick);
            this.btnAddNewMainInvestigation.Click += new EventHandler(OnAddNewMainInvestigationClick);

            this.tsbOpen.Click += new EventHandler(this.OnOpenClick);
            this.dgvInvestionData.DoubleClick += new EventHandler(this.OnCellDoubleClick);
        }

        private void OnAddNewMainInvestigationClick(object sender, EventArgs e)
        {
            MainInvestigation obj = new MainInvestigation(this.mOPDInvestigationProcedure);
            MainInvestigationForm.ShowForm(obj);
            MainInvestigationCollection opdMainInvestigationList = new MainInvestigationCollection();
            this.cmbMainInvestigation.DataSource = opdMainInvestigationList;
            this.cmbMainInvestigation.DisplayMember = "DisplayName";
        }

        private void OnAddNewLabInvestigationClick(object sender, EventArgs e)
        {
            LabInvestigation obj = new LabInvestigation(this.mOPDInvestigationProcedure);
            LabInvestigationForm.ShowForm(obj);
            LabInvestigationCollection opdLabInvestigationList = new LabInvestigationCollection();
            this.cmbLabInvestigation.DataSource = opdLabInvestigationList;
            this.cmbLabInvestigation.DisplayMember = "DisplayName";
        }

        private OPDInvestigationProcedure GetSelectedProcedure(DataGridView dgv)
        {
            OPDInvestigationProcedure obj = null;
            if (dgv != null && dgv.CurrentRow != null)
                obj = dgv.CurrentRow.Tag as OPDInvestigationProcedure;
            return obj;
        }

        #region OnDataShow

        protected override void OnDataShow()
        {
            base.OnDataShow();
            this.cmbMainInvestigation.Select();
            this.Text = "Investigation";


            // Main Investigation

            MainInvestigationCollection opdMainInvestigationList = new MainInvestigationCollection();
            this.cmbMainInvestigation.DataSource = opdMainInvestigationList;
            this.cmbMainInvestigation.DisplayMember = "DisplayName";
            this.cmbMainInvestigation.SelectedItem = null;

            //Lab Investigation
    
            LabInvestigationCollection opdLabInvestigationList = new LabInvestigationCollection();
            this.cmbLabInvestigation.DataSource = opdLabInvestigationList;
            this.cmbLabInvestigation.DisplayMember = "DisplayName";
            this.cmbLabInvestigation.SelectedItem = null;


            this.txtRadiologyInvestigation.Text = this.mOPDInvestigationProcedure.RadiologyInvestigation;
            this.txtSpecialInvestigation.Text = this.mOPDInvestigationProcedure.SpecialInvestigation;
            if (!string.IsNullOrEmpty(this.mOPDInvestigationProcedure.OPDInvestigationProcedureDate.ToString()) && (this.mOPDInvestigationProcedure.OPDInvestigationProcedureDate != DateTime.MinValue))
            {
                this.dptInvestigationDate.Value = this.mOPDInvestigationProcedure.OPDInvestigationProcedureDate;
            }

            if (this.OPDMainInvestigations.Count > 0)
            {
                for (int i = 0; i < cmbMainInvestigation.Items.Count; i++)
                {
                    for (int j = 0; j < OPDMainInvestigations.Count; j++)
                    {
                        if (OPDMainInvestigations[j].MainInvestigationGuid == new Guid(cmbMainInvestigation.Items[i].ToString()))
                        {
                            cmbMainInvestigation.SetItemChecked(i, true);
                            break;
                        }
                    }
                }
            }

            if (this.OPDLabInvestigations.Count > 0)
            {
                for (int i = 0; i < cmbLabInvestigation.Items.Count; i++)
                {
                    for (int j = 0; j < OPDLabInvestigations.Count; j++)
                    {
                        if (OPDLabInvestigations[j].LabInvestigationGuid == new Guid(cmbLabInvestigation.Items[i].ToString()))
                        {
                            cmbLabInvestigation.SetItemChecked(i, true);
                            break;
                        }
                    }
                }
            }
            LoadInvestigationData(GetSelectedProcedure(this.dgvInvestionData));

        }

        #endregion

        #region OnDataSet

        protected override void OnDataSet()
        {
            if (!Objectbase.IsNullOrEmpty(this.mOPDInvestigationProcedure))
            {
                this.mOPDInvestigationProcedure.RadiologyInvestigation = this.txtRadiologyInvestigation.Text;
                this.mOPDInvestigationProcedure.SpecialInvestigation = this.txtSpecialInvestigation.Text;
                this.mOPDInvestigationProcedure.OPDInvestigationProcedureDate = this.dptInvestigationDate.Value;

                //Main Investigation

                this.mPatient.OPDInvestigationProcedure = this.mOPDInvestigationProcedure;
                this.mOPDInvestigationProcedure.OPDMainInvestigations.Clear();

                for (int i = 0; i < cmbMainInvestigation.Items.Count; i++)
                {
                    if (cmbMainInvestigation.GetItemChecked(i))
                    {
                        obj = new OPDInvestigationProcedureMainInvestigation();
                        Guid gd = new Guid(cmbMainInvestigation.Items[i].ToString());
                        obj.PatientGuid = this.mPatient.ObjectGuid;
                        obj.MainInvestigationGuid = gd;
                        this.mOPDInvestigationProcedure.OPDMainInvestigations.Add(obj);
                    }
                }
                // For Clear Main Investigation

                for (int i = 0; i < cmbMainInvestigation.Items.Count; i++)
                {
                    if (cmbMainInvestigation.GetItemChecked(i))
                    {
                        cmbMainInvestigation.SetItemChecked(i, false);
                       
                    }                   
                }

                //Lab Investigation

                this.mOPDInvestigationProcedure.OPDLabInvestigations.Clear();

                for (int i = 0; i < cmbLabInvestigation.Items.Count; i++)
                {
                    if (cmbLabInvestigation.GetItemChecked(i))
                    {
                        obj1 = new OPDInvestigationProcedureLabInvestigation();
                        Guid gd = new Guid(cmbLabInvestigation.Items[i].ToString());
                        obj1.PatientGuid = this.mPatient.ObjectGuid;
                        obj1.LabInvestigationGuid = gd;
                        this.mOPDInvestigationProcedure.OPDLabInvestigations.Add(obj1);

                    }
                }

                //For Clear Lab Investigation

                for (int i = 0; i < cmbLabInvestigation.Items.Count; i++)
                {
                    if (cmbLabInvestigation.GetItemChecked(i))
                    {
                        cmbLabInvestigation.SetItemChecked(i, false);
                    }
                }

            }            
        }
        #endregion

        #region OnSaveComplete

        protected override void OnSaveComplete()
        {
            base.OnSaveComplete();
            OPDInvestigationProcedure obj = this.GetSelectedProcedure(this.dgvInvestionData);

            //Load List Data Method
            LoadInvestigationData(obj);
      
            this.cmbLabInvestigation.SelectedItem = null;
            this.cmbMainInvestigation.SelectedItem = null;
            this.txtRadiologyInvestigation.ResetText();
            this.txtSpecialInvestigation.ResetText();
            this.dptInvestigationDate.Value = DateTime.Now;
            this.mOPDInvestigationProcedure = new OPDInvestigationProcedure();
        }

        #endregion

        #region OnOpenClick
        private void OnOpenClick(object sender, EventArgs e)
        {
            OPDInvestigationProcedure obj = this.GetSelectedProcedure(this.dgvInvestionData);
            if(obj != null)
            {
                obj.RefershData();
                this.mOPDInvestigationProcedure = obj;
                //Main Investigation
                for (int i = 0; i < cmbMainInvestigation.Items.Count; i++)
                {
                    if (cmbMainInvestigation.GetItemChecked(i))
                    {
                        cmbMainInvestigation.SetItemChecked(i, false);
                    }
                }
                if (this.mOPDInvestigationProcedure.OPDMainInvestigations.Count > 0)
                {
                    for (int i = 0; i < cmbMainInvestigation.Items.Count; i++)
                    {
                        for (int j = 0; j < this.mOPDInvestigationProcedure.OPDMainInvestigations.Count; j++)
                        {
                            if (mOPDInvestigationProcedure.OPDMainInvestigations[j].MainInvestigationGuid == new Guid(cmbMainInvestigation.Items[i].ToString()))
                            {
                                cmbMainInvestigation.SetItemChecked(i, true);
                                break;
                            }
                        }
                    }
                }
                //Lab Investigation
                for (int i = 0; i < cmbLabInvestigation.Items.Count;i++)
                {
                    if (cmbLabInvestigation.GetItemChecked(i))
                    {
                        cmbLabInvestigation.SetItemChecked(i, false);
                    }
                }
                if (this.mOPDInvestigationProcedure.OPDLabInvestigations.Count > 0)
                {
                    for (int i = 0; i < cmbLabInvestigation.Items.Count; i++)
                    {
                        for (int j = 0; j < this.mOPDInvestigationProcedure.OPDLabInvestigations.Count; j++)
                        {
                            if (mOPDInvestigationProcedure.OPDLabInvestigations[j].LabInvestigationGuid == new Guid(cmbLabInvestigation.Items[i].ToString()))
                            {
                                cmbLabInvestigation.SetItemChecked(i, true);
                                break;
                            }
                        }
                    }
                }
                this.txtRadiologyInvestigation.Text = obj.RadiologyInvestigation;
                this.txtSpecialInvestigation.Text = obj.SpecialInvestigation;
                this.dptInvestigationDate.Value = obj.OPDInvestigationProcedureDate;
            }
        }
        #endregion

        #region OnDeleteClick

        protected override void OnDeleteClick()
        {
             OPDInvestigationProcedure obj = this.GetSelectedProcedure(this.dgvInvestionData);
             if (obj != null)
             {
                 this.mOPDInvestigationProcedure = obj;
                 this.mOPDInvestigationProcedure.MarkToDelete();
                 this.mOPDInvestigationProcedure.UpdateChanges();
             }
             for (int i = 0; i < cmbMainInvestigation.Items.Count; i++)
             {
                 if (cmbMainInvestigation.GetItemChecked(i))
                 {
                     cmbMainInvestigation.SetItemChecked(i, false);
                 }
             }
             for (int i = 0; i < cmbLabInvestigation.Items.Count; i++)
             {
                 if (cmbLabInvestigation.GetItemChecked(i))
                 {
                     cmbLabInvestigation.SetItemChecked(i, false);
                 }
             }
             this.txtRadiologyInvestigation.ResetText();
             this.txtSpecialInvestigation.ResetText();
             this.dptInvestigationDate.Value = DateTime.Now;            
             LoadInvestigationData(obj);
             this.mOPDInvestigationProcedure = new OPDInvestigationProcedure();
             this.cmbMainInvestigation.SelectedItem = null;
             this.cmbLabInvestigation.SelectedItem = null;
        }
        #endregion

        #region OnCellDoubleClick
        private void OnCellDoubleClick(object sender, EventArgs e)
        {
            this.tsbOpen.PerformClick();
            this.cmbMainInvestigation.SelectedItem = null;
            this.cmbLabInvestigation.SelectedItem = null;
        }
        #endregion

        #region OnDataValidation
        protected override bool OnDataValidation()
        {
            bool r = true;
            if (Objectbase.IsNullOrEmpty(this.cmbMainInvestigation.SelectedItem as MainInvestigation))
            {
                this.ShowTooltip(this.cmbMainInvestigation, "MainInvestigation", "MainInvestigation is required", ContentAlignment.TopRight);
                if (r)
                    this.cmbMainInvestigation.Select();
                r = false;
            }
            if (Objectbase.IsNullOrEmpty(this.cmbLabInvestigation.SelectedItem as LabInvestigation))
            {
                this.ShowTooltip(this.cmbLabInvestigation, "LabInvestigation", "LabInvestigation is required", ContentAlignment.TopRight);
                if (r)
                    this.cmbLabInvestigation.Select();
                r = false;
            }
            if (this.dptInvestigationDate.Text.Trim().Length <= 0)
            {
                this.ShowTooltip(this.dptInvestigationDate, "Date", "Date is required", ContentAlignment.TopRight);
                if (r)
                    this.dptInvestigationDate.Select();
                r = false;
            }
            return r && base.OnDataValidation();
        }
        #endregion

        #region LoadInvestigationData

        private void LoadInvestigationData(OPDInvestigationProcedure selected)
        {
            int count = 0;
            this.LoadEntityList<OPDInvestigationProcedure>(this.dgvInvestionData, this.clmInvestigationDate.Index, new OPDInvestigationProcedureCollection(this.mPatient.ObjectGuid), selected,
                                                            true, true, delegate(DataGridViewRow row, OPDInvestigationProcedure obj)
                                                            {
                                                                count++;
                                                                row.Cells[this.clmMainInvestigation.Index].Value = obj.MainInvestigation;
                                                                row.Cells[this.clmLabInvestigation.Index].Value = obj.LabInvestigation;
                                                                row.Cells[this.clmRadiology.Index].Value = obj.RadiologyInvestigation;
                                                                row.Cells[this.clmSpecial.Index].Value = obj.SpecialInvestigation;
                                                                row.Cells[this.clmInvestigationDate.Index].Value = obj.OPDInvestigationProcedureDate.ToString() != string.Empty ? string.Format("{0:dd/MM/yyyy}", obj.OPDInvestigationProcedureDate) : string.Empty; 
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
                using (OPDInvestigationForm frm = new OPDInvestigationForm(obj))
                {
                    r = frm.ShowDialog() == DialogResult.OK;
                }
            }
            return r;
        }
        #endregion
    }
}
