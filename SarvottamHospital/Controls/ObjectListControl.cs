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
    public partial class ObjectListControl : UserControl
    {
        protected delegate void LoadRowData<T>(DataGridViewRow row, T obj) where T : Objectbase;

        /// <summary>Raise event to close a windows form.</summary>
        public event EventHandler CloseTabRequest;

        public ObjectListControl()
        {
            this.Font = Common.ApplicationFont;
        }

        protected void SendCloseTabRequest()
        {
            EventHandler eh = CloseTabRequest;
            if (null != eh)
                eh(this, EventArgs.Empty);
        }

        protected void FormatGrid(DataGridView dgv)
        {
            /// *** General ***
            Color gridColor = Color.Silver; //SystemColors.ControlDark;

            DataGridViewCellStyle defRowCellStyle = new DataGridViewCellStyle();
            defRowCellStyle.BackColor = Color.Empty; //SystemColors.Window;

            DataGridViewCellStyle altRowCellStyle = new DataGridViewCellStyle();
            altRowCellStyle.BackColor = Color.Azure; //Color.LightCyan;

            dgv.GridColor = gridColor;
            dgv.DefaultCellStyle = defRowCellStyle;
            dgv.AlternatingRowsDefaultCellStyle = altRowCellStyle;

        }

        protected void LoadEntityList<T>(DataGridView dgv, int defColumnIndex, ObjectCollection<T> list, T selected, LoadRowData<T> loadRowData) where T : Objectbase
        {
            this.LoadEntityList<T>(dgv, defColumnIndex, list, selected, true, false, loadRowData);
        }

        protected void LoadEntityList<T>(DataGridView dgv, int defColumnIndex, ObjectCollection<T> list, T selected, bool needSort, bool isDefDesc, LoadRowData<T> loadRowData) where T : Objectbase
        {
            int relativeIndex = 0;
            if (dgv.CurrentRow != null)
                relativeIndex = dgv.FirstDisplayedScrollingRowIndex - dgv.CurrentRow.Index;

            dgv.SuspendLayout();

            dgv.Rows.Clear();
            DataGridViewColumn clmSorted = dgv.SortedColumn;
            SortOrder ordSort = dgv.SortOrder == SortOrder.None ? (isDefDesc ? SortOrder.Descending : SortOrder.Ascending) : dgv.SortOrder;

            DataGridViewRow selectedRow = null;
            for (int i = 0, j = list.Count; i < j; i++)
            {
                T obj = list[i];
                if (obj != null)
                {
                    DataGridViewRow row = dgv.Rows[dgv.Rows.Add()];
                    row.Tag = obj;
                    loadRowData.Invoke(row, obj);
                    if (obj.Equals(selected))
                        selectedRow = row;
                }
            }

            //if (ordSort == SortOrder.None)
            //    dgv.Sort(dgv.Columns[(clmSorted == null ? defColumnIndex : clmSorted.Index)], ListSortDirection.Ascending);
            //else
            if (needSort)
                dgv.Sort(dgv.Columns[(clmSorted == null ? defColumnIndex : clmSorted.Index)], (ordSort == SortOrder.Ascending ? ListSortDirection.Ascending : ListSortDirection.Descending));

            bool hasRows = dgv.Rows.Count > 0;

            if (null == selectedRow && hasRows)
                selectedRow = dgv.Rows[0];

            if (selectedRow != null)
            {
                selectedRow.Cells[defColumnIndex].Selected = true;
                selectedRow.Selected = true;

                int selectedIndex = selectedRow.Index + relativeIndex;
                if (selectedIndex >= 0 && selectedIndex < dgv.Rows.Count)
                    dgv.FirstDisplayedScrollingRowIndex = selectedIndex;
            }
            else if (hasRows)
            {
                dgv.FirstDisplayedScrollingRowIndex = 0;
            }

            if (hasRows)
                dgv.Select();

            dgv.ResumeLayout(false);
        }

        public void RefreshData()
        {
            if (!this.DesignMode)
                this.LoadListData();
        }

        protected virtual void LoadListData() { }

        protected static Objectbase GetSelectedEntity(DataGridView dgv)
        {
            Objectbase r = null;
            if (dgv != null && dgv.CurrentRow != null)
                r = dgv.CurrentRow.Tag as Objectbase;
            return r;
        }

        protected void OnLabelClick(object sender, EventArgs e)
        {
            Label lblControl = sender as Label;
            if (lblControl != null)
                this.SelectNextControl(lblControl, true, false, true, true);
        }

        protected void OnControlEnter(object sender, EventArgs e)
        {
            Control ctlObj = sender as Control;
            if (null != ctlObj)
            {
                HighlightFont(ctlObj.Tag as Label);

                TextBox txtControl = ctlObj as TextBox;
                if (null != txtControl)
                    txtControl.SelectAll();

                NumericUpDown nudControl = ctlObj as NumericUpDown;
                if (null != nudControl)
                    nudControl.Select(0, int.MaxValue);

                if (ctlObj is IButtonControl)
                    HighlightFont(ctlObj);
                else
                    ctlObj.BackColor = System.Drawing.SystemColors.Info;
            }

        }

        protected void OnControlLeave(object sender, EventArgs e)
        {
            Control ctl = sender as Control;
            if (null != ctl)
            {
                this.DeHighlightFont(ctl.Tag as Label);

                if (ctl is IButtonControl)
                    this.DeHighlightFont(ctl);
                else
                {
                    TextBoxBase txt = ctl as TextBoxBase;
                    UpDownBase upb = ctl as UpDownBase;
                    bool isReadOnly = (null != txt && txt.ReadOnly) || (null != upb && upb.ReadOnly);
                    ctl.BackColor = (isReadOnly ? SystemColors.Window : Color.Empty);
                }
            }
        }

        private void HighlightFont(Control ctl)
        {
            if (ctl != null)
            {
                //ctl.ForeColor = SystemColors.Highlight;
                ctl.Font = new Font(ctl.Font, FontStyle.Bold);
            }
        }

        private void DeHighlightFont(Control ctl)
        {
            if (ctl != null)
            {
                //ctl.ForeColor = System.Drawing.Color.Empty;
                ctl.Font = null;
            }
        }


    }
}
