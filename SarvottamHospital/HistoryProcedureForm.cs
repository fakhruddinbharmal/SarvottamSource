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
    public partial class HistoryProcedureForm : SarvottamHospital.ObjectbaseForm
    {
        private HistoryProcedure mHistoryProcedure;

        private HistoryProcedureCollection mHistoryCollection;

        private HistoryProcedureCollections mHistoryCollections;
        
        private Patient mPatient;

        //Chief Complain

        private OPDChiefComplains OPDChiefComplains;

        private OPDHistoryProcedureChiefComplain obj1;
        

        // Associate Complain

        private OPDAssociateComplains OPDAssociateComplains;

        private OPDHistoryProcedureAssociateComplain obj2;
        

        // History 

        private OPDHistorys OPDHistorys;

        private OPDHistoryProcedureHistory obj3;

       //

         public HistoryProcedureForm(Patient obj)
             : base(obj,false)
        {
            this.mPatient = obj;
            this.mHistoryProcedure = new HistoryProcedure();

            this.mHistoryCollection = new HistoryProcedureCollection(this.mPatient.ObjectGuid);
            this.mHistoryCollections = new HistoryProcedureCollections(this.mHistoryProcedure.ObjectGuid);

            this.OPDChiefComplains = new OPDChiefComplains(this.mHistoryProcedure.ObjectGuid);
            this.OPDAssociateComplains = new OPDAssociateComplains(this.mHistoryProcedure.ObjectGuid);
            this.OPDHistorys = new OPDHistorys(this.mHistoryProcedure.ObjectGuid);

            this.InitializeComponent();
            this.UserInitialize();
        }

         private void UserInitialize()
         {      
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

             this.btnAddNewChiefComplain.Click += new EventHandler(OnAddNewChiefComplainClick);
             this.btnAddNewAssociateComplain.Click += new EventHandler(OnAddNewAssociateComplainClick);
             this.btnAddNewHistory.Click += new EventHandler(OnAddNewHistoryClick);

             this.tsbOpen.Click += new EventHandler(this.OnOpenClick);
             this.dgvHistoryData.DoubleClick += new EventHandler(this.OnCellDoubleClick);
             
         }

         private void OnAddNewHistoryClick(object sender, EventArgs e)
         {
             History obj = new History(this.mHistoryProcedure);
             HistoryForm.ShowForm(obj);
             HistoryCollection historyList = new HistoryCollection();             
             this.cmbHistoryOfProblem.DataSource = historyList;
             this.cmbHistoryOfProblem.DisplayMember = "DisplayName";
         }

         private void OnAddNewAssociateComplainClick(object sender, EventArgs e)
         {
             AssociateComplain obj = new AssociateComplain(this.mHistoryProcedure);
             AssociateComplainForm.ShowForm(obj);
             AssociateComplainCollection associateComplainList = new AssociateComplainCollection();          
             this.cmbAssociateComplain.DataSource = associateComplainList;
             this.cmbAssociateComplain.DisplayMember = "DisplayName";
         }

         private void OnAddNewChiefComplainClick(object sender, EventArgs e)
         {
             ChiefComplain obj = new ChiefComplain(this.mHistoryProcedure);
             ChiefComplainForm.ShowForm(obj);
             ChiefComplainCollection chiefComplainList = new ChiefComplainCollection();             
             this.cmbChiefComplain.DataSource = chiefComplainList;
             this.cmbChiefComplain.DisplayMember = "DisplayName";
         }

         private HistoryProcedure GetSelectedProcedure(DataGridView dgv)
         {
             HistoryProcedure obj = null;
             if (dgv != null && dgv.CurrentRow != null)
                 obj = dgv.CurrentRow.Tag as HistoryProcedure;
             return obj;
         }

         #region OnDataShow
         protected override void OnDataShow()
         {
             base.OnDataShow();
             this.cmbChiefComplain.Select();
             this.Text = "History Procedure";

             ChiefComplainCollection chiefComplainList = new ChiefComplainCollection();
             this.cmbChiefComplain.DataSource = chiefComplainList;
             this.cmbChiefComplain.DisplayMember = "DisplayName";
             this.cmbChiefComplain.SelectedItem = null;
          
             
             AssociateComplainCollection associateComplainList = new AssociateComplainCollection();
             this.cmbAssociateComplain.DataSource = associateComplainList;
             this.cmbAssociateComplain.DisplayMember = "DisplayName";
             this.cmbAssociateComplain.SelectedItem = null;

             HistoryCollection historyList = new HistoryCollection();
             this.cmbHistoryOfProblem.DataSource = historyList;
             this.cmbHistoryOfProblem.DisplayMember = "DisplayName";
             this.cmbHistoryOfProblem.SelectedItem = null;

             this.txtProblemSince.Text = this.mHistoryProcedure.ProblemSince;
             this.txtAssociateComplainDuration.Text = this.mHistoryProcedure.AssociateComplainDuration;
             this.txtFamilyHistory.Text = this.mHistoryProcedure.FamilyHistory;
             this.txtFamilyHistoryDuration.Text = this.mHistoryProcedure.FamilyHistoryDuration;
             if(!string.IsNullOrEmpty(this.mHistoryProcedure.Date.ToString()) && (this.mHistoryProcedure.Date != DateTime.MinValue)) 
             {
                this.dtpHistoryDate.Value = this.mHistoryProcedure.Date;
             }

             //ChiefComplain
             if (this.OPDChiefComplains.Count > 0)
             {
                 for (int i = 0; i < cmbChiefComplain.Items.Count; i++)
                 {
                     for (int j = 0; j < this.OPDChiefComplains.Count; j++)
                     {
                         if (OPDChiefComplains[j].ChiefComplainGuid == new Guid(cmbChiefComplain.Items[i].ToString()))
                         {
                             cmbChiefComplain.SetItemChecked(i, true);
                             break;
                         }
                     }
                 }
             }

             //Associate Complain

             if (this.OPDAssociateComplains.Count > 0)
             {
                 for (int i = 0; i < cmbAssociateComplain.Items.Count; i++)
                 {
                     for (int j = 0; j < this.OPDAssociateComplains.Count; j++)
                     {
                         if (OPDAssociateComplains[j].AssociateComplainGuid == new Guid(cmbAssociateComplain.Items[i].ToString()))
                         {
                             cmbAssociateComplain.SetItemChecked(i, true);
                             break;
                         }
                     }
                 }
             }
             
             //History

             if (this.OPDHistorys.Count > 0)
             {
                 for (int i = 0; i < cmbHistoryOfProblem.Items.Count; i++)
                 {
                     for (int j = 0; j < this.OPDHistorys.Count; j++)
                     {
                         if (OPDHistorys[j].HistoryGuid == new Guid(cmbHistoryOfProblem.Items[i].ToString()))
                         {
                             cmbHistoryOfProblem.SetItemChecked(i, true);
                             break;
                         }
                     }
                 }

             }
            
             LoadHistoryProcedure(GetSelectedProcedure(this.dgvHistoryData));

         }
         #endregion
     
         #region OnDataSet
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
                 //Chief Complain

                 this.mPatient.HistoryProcedure = this.mHistoryProcedure;
                 this.mHistoryProcedure.OPDChiefComplains.Clear();

                 for (int i = 0; i < cmbChiefComplain.Items.Count; i++)
                 {
                     if (cmbChiefComplain.GetItemChecked(i))
                     {
                         obj1 = new OPDHistoryProcedureChiefComplain();
                         Guid gd = new Guid(cmbChiefComplain.Items[i].ToString());
                         obj1.PatientGuid = this.mPatient.ObjectGuid;
                         obj1.ChiefComplainGuid = gd;                        
                         this.mHistoryProcedure.OPDChiefComplains.Add(obj1);
                     }
                 }
                 // For Clear Of Cheif Complain

                 for (int i = 0; i < cmbChiefComplain.Items.Count;i++)
                 {
                     if (cmbChiefComplain.GetItemChecked(i))
                     {
                         cmbChiefComplain.SetItemChecked(i, false);
                     }
                 }

                 //Associate Complain

                 this.mHistoryProcedure.OPDAssociateComplains.Clear();

                 for (int i = 0; i < cmbAssociateComplain.Items.Count; i++)
                 {
                     if (cmbAssociateComplain.GetItemChecked(i))
                     {
                         obj2 = new OPDHistoryProcedureAssociateComplain();
                         Guid gd = new Guid(cmbAssociateComplain.Items[i].ToString());
                         obj2.PatientGuid = this.mPatient.ObjectGuid;
                         obj2.AssociateComplainGuid = gd;
                         this.mHistoryProcedure.OPDAssociateComplains.Add(obj2);
                     }
                 }
                 // For clear Of Associate complain

                 for (int i = 0; i < cmbAssociateComplain.Items.Count; i++)
                 {
                     if (cmbAssociateComplain.GetItemChecked(i))
                     {
                         cmbAssociateComplain.SetItemChecked(i, false);
                     }
                 }

                 //History

                 this.mHistoryProcedure.OPDHistorys.Clear();
                 for (int i = 0; i < cmbHistoryOfProblem.Items.Count; i++)
                 {
                     if (cmbHistoryOfProblem.GetItemChecked(i))
                     {
                         obj3 = new OPDHistoryProcedureHistory();
                         Guid gd = new Guid(cmbHistoryOfProblem.Items[i].ToString());
                         obj3.PatientGuid = this.mPatient.ObjectGuid;
                         obj3.HistoryGuid = gd;
                         this.mHistoryProcedure.OPDHistorys.Add(obj3);
                     }
                 }
                 // For Clear Of History Procedure

                 for (int i = 0; i < cmbHistoryOfProblem.Items.Count; i++)
                 {
                     if (cmbHistoryOfProblem.GetItemChecked(i))
                     {
                         cmbHistoryOfProblem.SetItemChecked(i, false);
                     }
                 }

             }
         }
         #endregion

         #region OnSaveComplete
         protected override void OnSaveComplete()
         {
             base.OnSaveComplete();
             HistoryProcedure obj = this.GetSelectedProcedure(this.dgvHistoryData);
             this.LoadHistoryProcedure(obj);

             this.cmbAssociateComplain.SelectedItem = null;
             this.cmbChiefComplain.SelectedItem=null;
             this.cmbHistoryOfProblem.SelectedItem=null;
             this.txtAssociateComplainDuration.ResetText();
             this.txtFamilyHistory.ResetText();
             this.txtFamilyHistoryDuration.ResetText();
             this.txtProblemSince.ResetText();
             this.dtpHistoryDate.Value = DateTime.Now;

             this.mHistoryProcedure = new HistoryProcedure();
         }
         #endregion

         #region OnOpenClick
         private void OnOpenClick(object sender, EventArgs e)
         {
             HistoryProcedure obj = this.GetSelectedProcedure(this.dgvHistoryData);
             if (obj != null)
             {
                 obj.RefershData();
                 this.mHistoryProcedure = obj;

                 // Chief Complain Clear

                 for (int i = 0; i < cmbChiefComplain.Items.Count; i++)
                 {
                     if (cmbChiefComplain.GetItemChecked(i))
                     {
                         cmbChiefComplain.SetItemChecked(i, false);
                     }
                 }

                 //Chief Complain
                 if (this.mHistoryProcedure.OPDChiefComplains.Count > 0)
                 {
                     for (int i = 0; i < cmbChiefComplain.Items.Count; i++)
                     {
                         for (int j = 0; j < this.mHistoryProcedure.OPDChiefComplains.Count; j++)
                         {
                             if (mHistoryProcedure.OPDChiefComplains[j].ChiefComplainGuid == new Guid(cmbChiefComplain.Items[i].ToString()))
                             {
                                 cmbChiefComplain.SetItemChecked(i, true);
                                 break;
                             }
                         }
                     }
                 }

                 // Associate Complain Clear

                 for (int i = 0; i < cmbAssociateComplain.Items.Count; i++)
                 {
                     if (cmbAssociateComplain.GetItemChecked(i))
                     {
                         cmbAssociateComplain.SetItemChecked(i, false);
                     }
                 }

                 //Associate Complain
                 if (this.mHistoryProcedure.OPDAssociateComplains.Count > 0)
                 {
                     for (int i = 0; i < cmbAssociateComplain.Items.Count; i++)
                     {
                         for (int j = 0; j < this.mHistoryProcedure.OPDAssociateComplains.Count; j++)
                         {
                             if (mHistoryProcedure.OPDAssociateComplains[j].AssociateComplainGuid == new Guid(cmbAssociateComplain.Items[i].ToString()))
                             {
                                 cmbAssociateComplain.SetItemChecked(i, true);
                                 break;
                             }
                         }
                     }
                 }

                 // History Complain Clear

                 for (int i = 0; i < cmbHistoryOfProblem.Items.Count; i++)
                 {
                     if (cmbHistoryOfProblem.GetItemChecked(i))
                     {
                         cmbHistoryOfProblem.SetItemChecked(i, false);
                     }
                 }

                 //History Complain
                 if (this.mHistoryProcedure.OPDHistorys.Count > 0)
                 {
                     for (int i = 0; i < cmbHistoryOfProblem.Items.Count; i++)
                     {
                         for (int j = 0; j < this.mHistoryProcedure.OPDHistorys.Count; j++)
                         {
                             if (mHistoryProcedure.OPDHistorys[j].HistoryGuid == new Guid(cmbHistoryOfProblem.Items[i].ToString()))
                             {
                                 cmbHistoryOfProblem.SetItemChecked(i, true);
                                 break;
                             }
                         }
                     }
                 }


                 this.txtProblemSince.Text = obj.ProblemSince;
                 this.txtFamilyHistory.Text = obj.FamilyHistory;
                 this.txtFamilyHistoryDuration.Text = obj.FamilyHistoryDuration;
                 this.txtAssociateComplainDuration.Text = obj.AssociateComplainDuration;
                 this.dtpHistoryDate.Value = obj.Date;
             }
         }
         #endregion

         #region OnDeleteClick
         protected override void OnDeleteClick()
         {
             HistoryProcedure obj = this.GetSelectedProcedure(this.dgvHistoryData);
             if (obj != null)
             {
                 this.mHistoryProcedure = obj;
                 this.mHistoryProcedure.MarkToDelete();
                 this.mHistoryProcedure.UpdateChanges();
             }
             // Chief Complain Clear

             for (int i = 0; i < cmbChiefComplain.Items.Count; i++)
             {
                 if (cmbChiefComplain.GetItemChecked(i))
                 {
                     cmbChiefComplain.SetItemChecked(i, false);
                 }
             }

             // Associate Complain Clear

             for (int i = 0; i < cmbAssociateComplain.Items.Count; i++)
             {
                 if (cmbAssociateComplain.GetItemChecked(i))
                 {
                     cmbAssociateComplain.SetItemChecked(i, false);
                 }
             }

             // History Complain Clear

             for (int i = 0; i < cmbHistoryOfProblem.Items.Count; i++)
             {
                 if (cmbHistoryOfProblem.GetItemChecked(i))
                 {
                     cmbHistoryOfProblem.SetItemChecked(i, false);
                 }
             }

             this.txtAssociateComplainDuration.ResetText();
             this.txtFamilyHistory.ResetText();
             this.txtFamilyHistoryDuration.ResetText();
             this.txtProblemSince.ResetText();
             this.dtpHistoryDate.Value = DateTime.Now;
             LoadHistoryProcedure(GetSelectedProcedure(this.dgvHistoryData));

             this.mHistoryProcedure = new HistoryProcedure();
             this.cmbAssociateComplain.SelectedItem = null;
             this.cmbChiefComplain.SelectedItem = null;
             this.cmbHistoryOfProblem.SelectedItem = null;

         }
         #endregion

         #region OnCellDoubleClick
         private void OnCellDoubleClick(object sender, EventArgs e)
         {
             this.tsbOpen.PerformClick();
             //this.cmbAssociateComplain.SelectedItem = null;
             //this.cmbChiefComplain.SelectedItem = null;
             //this.cmbHistoryOfProblem.SelectedItem = null;
         }
         #endregion

         #region OnDataValidation
         protected override bool OnDataValidation()
         {
             bool r = true;
             if (Objectbase.IsNullOrEmpty(this.cmbChiefComplain.SelectedItem as ChiefComplain))
             {
                 this.ShowTooltip(this.cmbChiefComplain, "ChiefComplain", "ChiefComplain is required", ContentAlignment.TopLeft);
                 if (r)
                     this.cmbChiefComplain.Select();
                 r = false;
             }
             if (Objectbase.IsNullOrEmpty(this.cmbAssociateComplain.SelectedItem as AssociateComplain))
             {
                 this.ShowTooltip(this.cmbAssociateComplain, "AssociateComplain", "AssociateComplain is required", ContentAlignment.TopRight);
                 if (r)
                     this.cmbAssociateComplain.Select();
                 r = false;
             }
             if (Objectbase.IsNullOrEmpty(this.cmbHistoryOfProblem.SelectedItem as History))
             {
                 this.ShowTooltip(this.cmbHistoryOfProblem, "History", "History is required", ContentAlignment.TopRight);
                 if (r)
                     this.cmbHistoryOfProblem.Select();
                 r = false;
             }
            
             return base.OnDataValidation() && r;
         }
        #endregion

         #region LoadHistoryProcedure
         private void LoadHistoryProcedure(HistoryProcedure selected)
         {
             int count = 0;
             this.LoadEntityList<HistoryProcedure>(this.dgvHistoryData, this.clmDate.Index, new HistoryProcedureCollection(this.mPatient.ObjectGuid), selected, true, true,
                                                     delegate(DataGridViewRow row, HistoryProcedure obj)
                                                     {
                                                         count++;
                                                         row.Cells[this.clmChiefComplain.Index].Value = obj.ChiefComplain;
                                                         row.Cells[this.clmProblemSince.Index].Value = obj.ProblemSince;
                                                         row.Cells[this.clmAssociateComplain.Index].Value = obj.AssociateComplain;
                                                         row.Cells[this.clmAssociateComplainDuration.Index].Value = obj.AssociateComplainDuration;
                                                         row.Cells[this.clmHistoryOfProblem.Index].Value = obj.History;
                                                         row.Cells[this.clmFamilyHistory.Index].Value = obj.FamilyHistory;
                                                         row.Cells[this.clmFamilyHistoryDuration.Index].Value = obj.FamilyHistoryDuration;
                                                         row.Cells[this.clmDate.Index].Value = obj.Date.ToString() != string.Empty ? string.Format("{0:dd/MM/yyyy}",obj.Date) : string.Empty;
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
                 using (HistoryProcedureForm frm = new HistoryProcedureForm(obj))
                 {
                     r = frm.ShowDialog() == DialogResult.OK;
                 }
             }
             return r;
         }
        #endregion
    }
}
