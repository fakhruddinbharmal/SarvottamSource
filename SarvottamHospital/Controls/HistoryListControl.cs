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
    public partial class HistoryListControl : SarvottamHospital.Controls.ObjectListControl
    {
         public HistoryListControl()
            : base()
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

        private void LoadListData(History selected)
        {
            int count = 0;
            this.LoadEntityList<History>(this.dgvData, this.clmHistoryOfProblem.Index, new HistoryCollection(tstSearch.Text), selected,
                delegate(DataGridViewRow row, History obj)
                {
                    count++;
                    row.Cells[this.clmHistoryOfProblem.Index].Value = obj.Name;
                    row.Cells[this.clmHistoryDescription.Index].Value = obj.Description;
                }
            );
            bool hasRows = count > 0;
            this.tsbOpen.Enabled = hasRows;
        }

        private History GetSelected()
        {
            return GetSelectedEntity(this.dgvData) as History;
        }

        private void OnAddClick(object sender, EventArgs e)
        {
            History obj = new History();
            if (HistoryForm.ShowForm(obj))
                this.LoadListData(obj);
        }

        protected override void LoadListData()
        {
            EntityCollection ent = AppContext.UserRoleEntities;
            foreach (Entity e in ent)
            {
                if (e.DisplayName == "History Details")
                {
                    this.tsbAdd.Enabled = AppContext.CanCreate(e.ObjectGuid);
                }
            }
            this.LoadListData(this.GetSelectedEntityObject());
        }

        private void OnOpenClick(object sender, EventArgs e)
        {
            History obj = this.GetSelected();
            if (obj != null)
                obj.RefershData();

            if (HistoryForm.ShowForm(obj))
                this.LoadListData(obj);
        }

        private History GetSelectedEntityObject()
        {
            return GetSelectedEntity(this.dgvData) as History;
        }

        private void OnSearchClick(object sender, EventArgs e)
        {
            this.LoadListData(this.GetSelected());
        }

        private void OnCloseClick(object sender, EventArgs e)
        {
            this.SendCloseTabRequest();
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

        private void OnCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e != null && e.RowIndex >= 0)
                this.tsbOpen.PerformClick();
        }
    }
}
