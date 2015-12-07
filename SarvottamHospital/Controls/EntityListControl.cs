using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SarvottamHospital.Object;
using SarvottamHospital.Controls;

namespace SarvottamHospital.Controls
{
    public sealed partial class EntityListControl : SarvottamHospital.Controls.ObjectListControl
    {
        public EntityListControl()
            : base()
        {
            InitializeComponent();

            this.tspToolbar.Font = Common.ApplicationFont;

            this.FormatGrid(this.dgvData);
            this.clmImgIcon.Image = Common.BlankImage;

            this.tstSearch.TextBox.Enter += new EventHandler(this.OnControlEnter);
            this.tstSearch.TextBox.Leave += new EventHandler(this.OnControlLeave);

            this.tstSearch.KeyDown += new KeyEventHandler(this.OnSearchKeyDown);
            this.dgvData.KeyDown += new KeyEventHandler(this.OnGridKeyDown);

        }

        private void tsbOpen_Click(object sender, EventArgs e)
        {
            Entity obj = this.GetSelectedEntityObject();

            EntityForm form = new EntityForm(obj);
            if (EntityForm.ShowForm(obj))
            {
                this.LoadListData(obj);
            }
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            Entity obj = new Entity();
            if (EntityForm.ShowForm(obj))
                this.LoadListData(obj);
        }

        private void tsbSearch_Click(object sender, EventArgs e)
        {
            this.LoadListData(this.GetSelectedEntityObject());
        }

        private Entity GetSelectedEntityObject()
        {
            return GetSelectedEntity(this.dgvData) as Entity;
        }

        private void LoadListData(Entity selected)
        {
            int count = 0;
            this.LoadEntityList<Entity>(this.dgvData, this.clmName.Index, new EntityCollection(tstSearch.Text), selected,
                delegate(DataGridViewRow row, Entity obj)
                {
                    count++;
                    row.Cells[this.clmName.Index].Value = obj.Name;
                    row.Cells[this.clmType.Index].Value = obj.TypeName;
                    row.Cells[this.clmCaption.Index].Value = obj.Caption;
                    row.Cells[this.clmListType.Index].Value = obj.ListTypeName;
                    row.Cells[this.clmListCaption.Index].Value = obj.ListCaption;
                    row.Cells[this.clmImgIcon.Index].Value = obj.IconSmall;
                }
            );
            bool hasRows = count > 0;
            this.tsbOpen.Enabled = hasRows;
        }

        protected override void LoadListData()
        {
            EntityCollection ent = AppContext.UserRoleEntities;
            foreach (Entity e in ent)
            {
                if (e.DisplayName == "Entities")
                {
                    this.tsbAdd.Enabled = AppContext.CanCreate(e.ObjectGuid);
                }
            }
            this.LoadListData(this.GetSelectedEntityObject());
        }

        private void OnSearchKeyDown(object sender, KeyEventArgs e)
        {
            if (e != null && e.KeyCode == Keys.Enter)
            {
                this.tsbSearch.PerformClick();
                e.SuppressKeyPress = true;
            }
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

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e != null && e.RowIndex >= 0)
                this.tsbOpen.PerformClick();
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.SendCloseTabRequest();
        }
    }
}
