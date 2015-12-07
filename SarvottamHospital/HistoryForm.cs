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
    public partial class HistoryForm : SarvottamHospital.ObjectbaseForm
    {
        private History mEntry;

       #region HistoryForm

        public HistoryForm() : this(null) { }

        public HistoryForm(History History)
            : base(History)
        {
            this.mEntry = History;
            this.InitializeComponent();
        }              
        #endregion

        #region UserInitialize

        public void UserInitialize()
        {
            this.txtHistoryOfProblem.Tag = this.lblHistoryOfProblem;
            lblHistoryOfProblem.Click += new EventHandler(OnLabelClick);
            txtHistoryOfProblem.Enter += new EventHandler(OnControlEnter);
            txtHistoryOfProblem.Leave += new EventHandler(OnControlLeave);

            this.txtHistoryOfProblemDesc.Tag = this.lblHistoryOfProblemDesc;
            lblHistoryOfProblemDesc.Click += new EventHandler(OnLabelClick);
            txtHistoryOfProblemDesc.Enter += new EventHandler(OnControlEnter);
            txtHistoryOfProblemDesc.Leave += new EventHandler(OnControlLeave);
        }
        #endregion

        #region OnDataSet

        protected override void OnDataSet()
        {
            base.OnDataSet();
            if (!Objectbase.IsNullOrEmpty(this.mEntry))
            {
                this.mEntry.Name = txtHistoryOfProblem.Text.Trim();
                this.mEntry.Description = txtHistoryOfProblemDesc.Text.Trim();
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
                this.txtHistoryOfProblem.Text = this.mEntry.Name;
                this.txtHistoryOfProblemDesc.Text = this.mEntry.Description;
                this.txtHistoryOfProblem.Select();
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
                    if (e.DisplayName == "History Details")
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
            if (this.txtHistoryOfProblem.Text.Trim().Length <= 0)
            {
                this.ShowTooltip(this. txtHistoryOfProblem, "History", "History is Required!", ContentAlignment.TopRight);
                if (r)
                    this.txtHistoryOfProblem.Select();
                r = false;
            }
            return r && base.OnDataValidation();
        }
        #endregion

        #region ShowForm
        public static bool ShowForm(History obj)
        {
            bool r = false;
            if (!Objectbase.IsNullOrEmpty(obj))
            {
                using (HistoryForm frm = new HistoryForm(obj))
                {
                    r = frm.ShowDialog() == DialogResult.OK;
                }
            }
            return r;
        }
        #endregion
    }
}
