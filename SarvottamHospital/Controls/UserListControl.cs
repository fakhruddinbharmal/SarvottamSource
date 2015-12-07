using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SarvottamHospital.Object;

namespace SarvottamHospital.Controls
{
    public partial class UserListControl : SarvottamHospital.Controls.ObjectListControl
    {
        public UserListControl()
            : base()
        {
            this.InitializeComponent();
            this.tspToolbar.Font = this.Font;

            this.tstSearch.TextBox.Enter += new EventHandler(this.OnControlEnter);
            this.tstSearch.TextBox.Leave += new EventHandler(this.OnControlLeave);
            this.FormatGrid(this.dgvData);

            this.dgvData.CellDoubleClick += new DataGridViewCellEventHandler(this.OnCellDoubleClick);
            this.dgvData.KeyDown += new KeyEventHandler(this.OnGridKeyDown);
            this.tstSearch.KeyDown += new KeyEventHandler(this.OnSearchKeyDown);

            this.tsbAdd.Click += new EventHandler(this.OnAddClick);
            this.tsbOpen.Click += new EventHandler(this.OnOpenClick);
            this.tsbSearch.Click += new EventHandler(this.OnSearchClick);
            this.tsbClose.Click += new EventHandler(this.OnCloseClick);
            this.dgvData.CellContentClick += new DataGridViewCellEventHandler(this.CellContentClick);
            this.tsbResetPassword.Click += new EventHandler(OnResetPassword);
        }

        private void OnResetPassword(object sender, EventArgs e)
        {
            User obj = this.GetSelected();
            if (!Objectbase.IsNullOrEmpty(obj))
            {
                if (MessageBox.Show(this, "Are you sure to Reset the password for " + obj.LoginName + "?", "Reset Password", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    obj.Password = string.Empty;
                    obj.MarkToSave();
                    obj.UpdateChanges();
                }
            }
        }

        private void LoadListData(User selected)
        {
            int count = 0;

            this.LoadEntityList<User>(this.dgvData, this.clmLoginName.Index, new Users(this.tstSearch.Text), selected,
                delegate(DataGridViewRow row, User obj)
                {
                    count++;
                    row.Cells[this.clmIsDisabled.Index].Value = obj.IsDisabled;
                    row.Cells[this.clmUserRoleName.Index].Value = obj.UserRole.UserRoleName;
                    row.Cells[this.clmLoginName.Index].Value = obj.LoginName;
                    row.Cells[this.clmName.Index].Value = obj.Name;
                    row.Cells[this.clmPhoneNo.Index].Value = obj.PhoneNo;
                    row.Cells[this.clmMobileNo.Index].Value = obj.MobileNo;
                    row.Cells[this.clmGuid.Index].Value = obj.ObjectGuid;
                    // row.Cells[this.clmpatientGuid.Index].Value = obj.ObjectPatientGuid;


                }
            );
            bool hasRows = count > 0;
            this.tsbOpen.Enabled = hasRows;
        }

        protected override void LoadListData()
        {
            if (!AppContext.IsAdministrator)
            {
                EntityCollection ent = AppContext.UserRoleEntities;
                foreach (Entity e in ent)
                {
                    if (e.DisplayName == "Users")
                    {
                        if (!AppContext.CanSpecial(e.ObjectGuid))
                            this.tssResetPsw.Visible = this.tsbResetPassword.Visible = false;
                        this.tsbAdd.Enabled = AppContext.CanCreate(e.ObjectGuid);
                    }
                }
            }
            this.LoadListData(this.GetSelected());
        }

        private User GetSelected()
        {
            return GetSelectedEntity(this.dgvData) as User;
        }

        private void OnCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e != null && e.RowIndex >= 0)
                this.tsbOpen.PerformClick();
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

        private void OnSearchKeyDown(object sender, KeyEventArgs e)
        {
            if (e != null && e.KeyCode == Keys.Enter)
            {
                this.tsbSearch.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void OnCloseClick(object sender, EventArgs e)
        {
            this.SendCloseTabRequest();
        }

        private void OnAddClick(object sender, EventArgs e)
        {
            User obj = new User();
            if (UserForm.ShowForm(obj))
                this.LoadListData(obj);
        }

        private void OnOpenClick(object sender, EventArgs e)
        {
            User obj = this.GetSelected();
            if (obj != null)
                obj.RefershData();

            if (UserForm.ShowForm(obj))
                this.LoadListData(obj);
        }

        private void OnSearchClick(object sender, EventArgs e)
        {
            this.LoadListData(this.GetSelected());
        }


        private void CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0 && ((DataGridView)sender).Columns[e.ColumnIndex].GetType() == typeof(DataGridViewImageColumn))
            //{
            //    int rowIndex = e.RowIndex;
            //    DataGridViewRow row = dgvData.Rows[rowIndex];
            //    DoctorReport f = new DoctorReport();

            //    f.DoctorGuid = (Guid)(row.Cells[8].Value);
            //    // f.PatientGuid =(Guid)(row.Cells[9].Value);
            //    f.Show();

            //}

        }
    }
}
