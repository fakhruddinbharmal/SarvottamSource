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
    public partial class LabInvestigationForm : SarvottamHospital.ObjectbaseForm
    {
          private LabInvestigation mEntry;

       #region LabInvestigationForm

        public LabInvestigationForm() : this(null) { }

        public LabInvestigationForm(LabInvestigation LabInvestigation)
            : base(LabInvestigation)
        {
            this.mEntry = LabInvestigation;
            this.InitializeComponent();
        }              
        #endregion

        #region UserInitialize

        public void UserInitialize()
        {
            this.txtLabInvestigation.Tag = this.lblLabInvestigation;
            lblLabInvestigation.Click += new EventHandler(OnLabelClick);
            txtLabInvestigation.Enter += new EventHandler(OnControlEnter);
            txtLabInvestigation.Leave += new EventHandler(OnControlLeave);

            this.txtLabInvestigationDesc.Tag = this.lblLabInvestigationDesc;
            lblLabInvestigationDesc.Click += new EventHandler(OnLabelClick);
            txtLabInvestigationDesc.Enter += new EventHandler(OnControlEnter);
            txtLabInvestigationDesc.Leave += new EventHandler(OnControlLeave);
        }
        #endregion

        #region OnDataSet

        protected override void OnDataSet()
        {
            base.OnDataSet();
            if (!Objectbase.IsNullOrEmpty(this.mEntry))
            {
                this.mEntry.Name = txtLabInvestigation.Text.Trim();
                this.mEntry.Description = txtLabInvestigationDesc.Text.Trim();
            }
        }

        #endregion

        #region OnDataShow

        protected override void OnDataShow()
        {
            base.OnDataShow();
            if (!Objectbase.IsNullOrEmpty(this.mEntry))
            {
                //this.c
                this.txtLabInvestigation.Text = this.mEntry.Name;
                this.txtLabInvestigationDesc.Text = this.mEntry.Description;
                this.txtLabInvestigation.Select();
            }
        }
        #endregion

        #region CheckPermission

        private void CheckPermission()
        {
            if (!AppContext.IsMainUser)
            {
                EntityCollection ent = AppContext.UserRoleEntities;
                foreach (Entity e in ent)
                {
                    if (e.DisplayName == "Lab Investigation Details")
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
                {
                    this.btnDelete.Visible = true;
                }
            }
        }
        #endregion

        #region OnDataValidation
        protected override bool OnDataValidation()
        {
            bool r = true;
            if (this.txtLabInvestigation.Text.Trim().Length <= 0)
            {
                this.ShowTooltip(this.txtLabInvestigation, "Lab Investigation", "Lab Investigation is Required!", ContentAlignment.TopRight);
                if (r)
                    this.txtLabInvestigation.Select();
                r = false;
            }
            return r && base.OnDataValidation();
        }
        #endregion

        #region ShowForm
        public static bool ShowForm(LabInvestigation obj)
        {
            bool r = false;
            if (!Objectbase.IsNullOrEmpty(obj))
            {
                using (LabInvestigationForm frm = new LabInvestigationForm(obj))
                {
                    r = frm.ShowDialog() == DialogResult.OK;
                }
            }
            return r;
        }
        #endregion
    }
}
