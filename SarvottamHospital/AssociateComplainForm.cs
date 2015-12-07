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
    public partial class AssociateComplainForm : SarvottamHospital.ObjectbaseForm
    {
        private AssociateComplain mEntry;

       #region AssociateComplainForm

        public AssociateComplainForm() : this(null) { }

        public AssociateComplainForm(AssociateComplain Associatecomplain)
            : base(Associatecomplain)
        {
            this.mEntry = Associatecomplain;
            this.InitializeComponent();
        }              
        #endregion

        #region UserInitialize

        public void UserInitialize()
        {
            this.txtAssociateComplain.Tag = this.lblAssociateComplain;
            lblAssociateComplain.Click += new EventHandler(OnLabelClick);
            txtAssociateComplain.Enter += new EventHandler(OnControlEnter);
            txtAssociateComplain.Leave += new EventHandler(OnControlLeave);

            this.txtAssociateComplainDesc.Tag = this.lblAssociateComplainDesc;
            lblAssociateComplainDesc.Click += new EventHandler(OnLabelClick);
            txtAssociateComplainDesc.Enter += new EventHandler(OnControlEnter);
            txtAssociateComplainDesc.Leave += new EventHandler(OnControlLeave);
        }
        #endregion

        #region OnDataSet

        protected override void OnDataSet()
        {
            base.OnDataSet();
            if (!Objectbase.IsNullOrEmpty(this.mEntry))
            {
                this.mEntry.Name = txtAssociateComplain.Text.Trim();
                this.mEntry.Description = txtAssociateComplainDesc.Text.Trim();
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
                this.txtAssociateComplain.Text = this.mEntry.Name;
                this.txtAssociateComplainDesc.Text = this.mEntry.Description;
                this.txtAssociateComplain.Select();
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
                    if (e.DisplayName == "Associate Complain Details")
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
            if (this.txtAssociateComplain.Text.Trim().Length <= 0)
            {
                this.ShowTooltip(this.txtAssociateComplain, "Associate Complain", "Associate Complain is Required!", ContentAlignment.TopRight);
                if (r)
                    this.txtAssociateComplain.Select();
                r = false;
            }
            return r && base.OnDataValidation();
        }
        #endregion

        #region ShowForm
        public static bool ShowForm(AssociateComplain obj)
        {
            bool r = false;
            if (!Objectbase.IsNullOrEmpty(obj))
            {
                using (AssociateComplainForm frm = new AssociateComplainForm(obj))
                {
                    r = frm.ShowDialog() == DialogResult.OK;
                }
            }
            return r;
        }
        #endregion
    }
}
