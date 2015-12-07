using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SarvottamHospital.Controls;
using SarvottamHospital.Object;

namespace SarvottamHospital.Controls
{
    public sealed partial class UserRoleListControl : SarvottamHospital.Controls.ObjectListControl
    {
        public UserRoleListControl()
            : base()
        {
            this.InitializeComponent();
            this.tspToolbar.Font = this.Font;

            this.tstSearch.TextBox.Enter += new EventHandler(this.OnControlEnter);
            this.tstSearch.TextBox.Leave += new EventHandler(this.OnControlLeave);
            this.FormatGrid(this.dgvData);

            this.dgvData.KeyDown += new KeyEventHandler(this.OnGridKeyDown);
            this.tstSearch.KeyDown += new KeyEventHandler(this.OnSearchKeyDown);

            this.tsbAdd.Click += new EventHandler(this.OnAddClick);
            this.tsbOpen.Click += new EventHandler(this.OnOpenClick);
            this.tsbSearch.Click += new EventHandler(this.OnSearchClick);
            this.tsbClose.Click += new EventHandler(this.OnCloseClick);
            this.tsbPermission.Click += new EventHandler(OnPermissionClick);
            this.tsbFieldPermission.Click += new EventHandler(OnFieldPermissionClick);
            this.dgvData.CellDoubleClick += new DataGridViewCellEventHandler(this.OnCellDoubleClick);
        }
        private void OnPermissionClick(object sender, EventArgs e)
        {
            UserRole obj = this.GetSelected();
            if (PermissionForm.ShowForm(obj))
                this.LoadListData(obj);
        }

        private void OnFieldPermissionClick(object sender, EventArgs e)
        {
            UserRole obj = this.GetSelected();
            if (FieldPermissionForm.ShowForm(obj))
                this.LoadListData(obj);
        }

        private void LoadListData(UserRole selected)
        {
            int count = 0;

            this.LoadEntityList<UserRole>(this.dgvData, this.clmRoleName.Index, new UserRoles(this.tstSearch.Text), selected,
                delegate(DataGridViewRow row, UserRole obj)
                {
                    count++;
                    row.Cells[this.clmRoleName.Index].Value = obj.UserRoleName;
                    row.Cells[this.clmDesc.Index].Value = obj.UserRoleDesc;
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
                    if (e.DisplayName == "User Roles")
                    {
                        this.tsbAdd.Enabled = AppContext.CanCreate(e.ObjectGuid);
                        this.tsbPermission.Enabled = AppContext.CanSpecial(e.ObjectGuid);
                    }
                }
            }
            this.LoadListData(this.GetSelected());
        }

        private UserRole GetSelected()
        {
            return GetSelectedEntity(this.dgvData) as UserRole;
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
            UserRole obj = new UserRole();
            if (UserRoleForm.ShowForm(obj))
                this.LoadListData(obj);
        }

        private void OnOpenClick(object sender, EventArgs e)
        {
            UserRole obj = this.GetSelected();
            if (obj != null)
                obj.RefershData();

            if (UserRoleForm.ShowForm(obj))
                this.LoadListData(obj);
        }

        private void OnSearchClick(object sender, EventArgs e)
        {
            this.LoadListData(this.GetSelected());
        }
    }
}
