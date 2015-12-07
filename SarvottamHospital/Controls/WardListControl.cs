using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SarvottamHospital.Object;

namespace SarvottamHospital.Controls
{
    public partial class WardListControl : SarvottamHospital.Controls.ObjectListControl
    {
        public WardListControl() : base()
        {
            InitializeComponent();
            this.tspToolbar.Font = Common.ApplicationFont;

            this.FormatGrid(this.dgvData);
            this.dgvData.CellDoubleClick += new DataGridViewCellEventHandler(this.OnCellDoubleClick);

            this.tstSearch.TextBox.Enter += new EventHandler(this.OnControlEnter);
            this.tstSearch.TextBox.Leave += new EventHandler(this.OnControlLeave);

            this.tstSearch.KeyDown += new KeyEventHandler(this.OnSearchKeyDown);
            this.dgvData.KeyDown += new KeyEventHandler(this.OnGridKeyDown);

            this.tsbAdd.Click += new EventHandler(this.OnAddClick);
            this.tsbOpen.Click += new EventHandler(this.OnOpenClick);
            this.tsbSearch.Click += new EventHandler(this.OnSearchClick);
            this.tsbClose.Click += new EventHandler(this.OnCloseClick);
        }

        private void tsbSearch_Click(object sender, EventArgs e)
        {
            this.LoadListData(this.GetSelectedEntityObject());
        }

        private Ward GetSelectedEntityObject()
        {
            return GetSelectedEntity(this.dgvData) as Ward;
        }

        private void LoadListData(Ward selected)
        {
            int count = 0;
            this.LoadEntityList<Ward>(this.dgvData, this.clmName.Index, new Wards(tstSearch.Text), selected,
                delegate(DataGridViewRow row, Ward obj)
                {
                    count++;
                    row.Cells[this.clmName.Index].Value = obj.Name;
                    row.Cells[this.clmDescription.Index].Value = obj.Description;
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
                if (e.DisplayName == "Wards Details")
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

        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.SendCloseTabRequest();
        }

        private void OnAddClick(object sender, EventArgs e)
        {
            Ward obj = new Ward();
            if (WardForm.ShowForm(obj))
                this.LoadListData(obj);
        }

        private Ward GetSelected()
        {
            return GetSelectedEntity(this.dgvData) as Ward;
        }

        private void OnOpenClick(object sender, EventArgs e)
        {
            Ward obj = this.GetSelected();
            if (obj != null)
                obj.RefershData();

            if (WardForm.ShowForm(obj))
                this.LoadListData(obj);
        }

        private void OnSearchClick(object sender, EventArgs e)
        {
            this.LoadListData(this.GetSelected());
        }

        private void OnCloseClick(object sender, EventArgs e)
        {
            this.SendCloseTabRequest();
        }

        private void OnCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e != null && e.RowIndex >= 0)
                this.tsbOpen.PerformClick();
        }

    }
}
