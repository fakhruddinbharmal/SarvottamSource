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
    public partial class MainInvestigationForm : SarvottamHospital.ObjectbaseForm
    {
         private MainInvestigation mEntry;

       #region MainInvestigationForm

        public MainInvestigationForm() : this(null) { }

        public MainInvestigationForm(MainInvestigation MainInvestigation)
            : base(MainInvestigation)
        {
            this.mEntry = MainInvestigation;
            this.InitializeComponent();
        }              
        #endregion

        #region UserInitialize

        public void UserInitialize()
        {
            this.txtMainInvestigation.Tag = this.lblMainInvestigation;
            lblMainInvestigation.Click += new EventHandler(OnLabelClick);
            txtMainInvestigation.Enter += new EventHandler(OnControlEnter);
            txtMainInvestigation.Leave += new EventHandler(OnControlLeave);

            this.txtMainInvestigationDesc.Tag = this.lblMainInvestigationDesc;
            lblMainInvestigationDesc.Click += new EventHandler(OnLabelClick);
            txtMainInvestigationDesc.Enter += new EventHandler(OnControlEnter);
            txtMainInvestigationDesc.Leave += new EventHandler(OnControlLeave);
        }
        #endregion

        #region OnDataSet

        protected override void OnDataSet()
        {
            base.OnDataSet();
            if (!Objectbase.IsNullOrEmpty(this.mEntry))
            {
                this.mEntry.Name = txtMainInvestigation.Text.Trim();
                this.mEntry.Description = txtMainInvestigationDesc.Text.Trim();
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
                this.txtMainInvestigation.Text = this.mEntry.Name;
                this.txtMainInvestigationDesc.Text = this.mEntry.Description;
                this.txtMainInvestigation.Select();
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
                    if (e.DisplayName == "Main Investigation Details")
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
            if (this.txtMainInvestigation.Text.Trim().Length <= 0)
            {
                this.ShowTooltip(this.txtMainInvestigation, "Main Investigation", "Main Investigation is Required!", ContentAlignment.TopRight);
                if (r)
                    this.txtMainInvestigation.Select();
                r = false;
            }
            return r && base.OnDataValidation();
        }
        #endregion

        #region ShowForm
        public static bool ShowForm(MainInvestigation obj)
        {
            bool r = false;
            if (!Objectbase.IsNullOrEmpty(obj))
            {
                using (MainInvestigationForm frm = new MainInvestigationForm(obj))
                {
                    r = frm.ShowDialog() == DialogResult.OK;
                }
            }
            return r;
        }
        #endregion
    }
}
