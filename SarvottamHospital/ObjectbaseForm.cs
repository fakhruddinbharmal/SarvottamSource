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
    public partial class ObjectbaseForm : Form
    {
        private Objectbase mEntity;

        private bool mIsPostUpdate;

        //private bool mIsReadOnly;

        protected delegate void LoadRowData<T>(DataGridViewRow row, T obj) where T : Objectbase;

        private Dictionary<string, ToolTip> mToolTips;

        public ObjectbaseForm() : this(null, false) { }

        public ObjectbaseForm(Objectbase obj) : this(obj, false) { }

        public ObjectbaseForm(Objectbase obj, bool isPostUpdate)
        {
            this.mEntity = obj;
            this.mIsPostUpdate = isPostUpdate;

            this.InitializeComponent();

            this.lblTitle.Font = Common.ApplicationTitleFont;
            this.lblTitle.ForeColor = Common.LightTextColor;

            this.btnDelete.Enter += new EventHandler(this.OnControlEnter);
            this.btnDelete.Leave += new EventHandler(this.OnControlLeave);

            this.btnSave.Enter += new EventHandler(this.OnControlEnter);
            this.btnSave.Leave += new EventHandler(this.OnControlLeave);

            this.btnCancel.Enter += new EventHandler(this.OnControlEnter);
            this.btnCancel.Leave += new EventHandler(this.OnControlLeave);

            this.picTitle.Image = Common.ApplicationIcon.ToBitmap();

            this.Icon = Common.ApplicationIcon;
            this.Font = Common.ApplicationFont;

            //this.btnSave.Visible = this.CanEdit || this.CanCreate;
        }

        //private bool mIsReadOnly;
        //public bool IsReadOnly
        //{
        //    get
        //    {
        //        bool r = false;
        //        if (Objectbase.IsNullOrEmpty(this.mEntity) || this.mIsReadOnly)
        //        {
        //            r = true;
        //        }
        //        else if (!this.mEntity.IsNew)
        //        {
        //            r = !(this.mEntity.UserCanEdit || this.mEntity.UserCanDelete);
        //        }
        //        return r;
        //    }
        //}

        public bool CanView
        {
            get { return (Objectbase.IsNullOrEmpty(this.mEntity) ? false : this.mEntity.UserCanView); }
        }

        public bool CanEdit
        {
            get { return (Objectbase.IsNullOrEmpty(this.mEntity) ? false : this.mEntity.UserCanEdit); }
        }

        public bool CanDelete
        {
            get { return (Objectbase.IsNullOrEmpty(this.mEntity) ? false : this.mEntity.UserCanDelete); }
        }

        public bool CanCreate
        {
            get { return (Objectbase.IsNullOrEmpty(this.mEntity) ? false : this.mEntity.UserCanCreate); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Objectbase.IsNullOrEmpty(this.mEntity))
            {
                this.ShowInvalidState();
            }
            else
            {
                if (this.ShowConfirm("Are you sure you want to delete?"))
                {
                    this.OnDeleteClick();
                }

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.OnSaveClick(); 
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!this.DesignMode)
            {
                this.MinimumSize = this.Size;
                if (Objectbase.IsNullOrEmpty(this.mEntity))
                    this.ShowInvalidState();
                else
                    this.OnDataShow();
            }
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);

            if (null != this.lblTitle)
                this.lblTitle.Text = this.Text;
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (!e.Control && e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
            else if (e.Control && e.KeyCode == Keys.S)
            {
                this.btnSave.PerformClick();
            }
            else if (e.Alt && e.KeyCode == Keys.Delete)
            {
                this.btnDelete.PerformClick();
            }
        }

        protected void ShowInvalidState()
        {
            this.SuspendLayout();

            Control.ControlCollection ctls = this.Controls;
            for (int i = ctls.Count - 1; i >= 0; i--)
            {
                Control ctl = ctls[i];
                if (!object.ReferenceEquals(ctl, this.btnCancel) && !object.ReferenceEquals(ctl, this.pnlTitle) && !object.ReferenceEquals(ctl, this.lineAction))
                {
                    ctls.Remove(ctl);
                    ctl.Dispose();
                }
            }

            Label lblMsg = new Label();
            lblMsg.Name = "lblMsg";
            lblMsg.Text = "Invalid object state!";
            lblMsg.UseMnemonic = false;
            lblMsg.BorderStyle = BorderStyle.None;
            lblMsg.Location = new Point(12, this.lblTitle.Height + 12);
            lblMsg.Size = new Size(this.ClientSize.Width - 24, this.ClientSize.Height - this.btnCancel.Height - this.lblTitle.Height - 30);
            lblMsg.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right;

            if (this.mEntity != null)
                this.Text = this.mEntity.GetType().Name;
            this.btnCancel.Text = "&Close";

            this.Controls.Add(lblMsg);
            this.ResumeLayout(false);

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
                if (!Objectbase.IsNullOrEmpty(obj) && obj.IsViewable)
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

        protected void SetEntity(Objectbase obj)
        {
            this.mEntity = obj;
        }

        #region Polymorphs

        protected virtual void OnDeleteClick()
        {
            if (this.mEntity.MarkToDelete() && (this.mIsPostUpdate || this.mEntity.UpdateChanges()))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                this.ShowError("Unable to Delete..!");
            }
        }

        protected virtual void OnSaveClick()
        {
            if (this.OnDataValidation())
            {
                this.OnDataSet();
                try
                {
                    var names = this.GetType().ToString();
                    if (this.mEntity.MarkToSave() && (this.mIsPostUpdate || this.mEntity.UpdateChanges()))
                    {
                        if (string.Compare(names, "SarvottamHospital.HistoryProcedureForm", StringComparison.InvariantCultureIgnoreCase) != 0)
                        {
                            if (string.Compare(names, "SarvottamHospital.OPDTreatmentProcedureForm", StringComparison.InvariantCultureIgnoreCase) != 0)
                            {
                                if (string.Compare(names, "SarvottamHospital.OPDInvestigationForm", StringComparison.InvariantCultureIgnoreCase) != 0)
                                {
                                    if (string.Compare(names, "SarvottamHospital.OPDPrescriptionForm", StringComparison.InvariantCultureIgnoreCase) != 0)
                                    {
                                        if (string.Compare(names, "SarvottamHospital.AppointmentForm", StringComparison.InvariantCultureIgnoreCase) != 0)
                                        {
                                            this.DialogResult = DialogResult.OK;
                                            this.Close();
                                        }
                                        else
                                        {
                                            this.OnSaveComplete();
                                        }
                                    }
                                    else
                                    {
                                        this.OnSaveComplete();
                                    }
                                }
                                else
                                {
                                    this.OnSaveComplete();
                                }
                            }
                            else
                            {
                                this.OnSaveComplete();
                            }                           
                        }
                        else
                        {
                            this.OnSaveComplete();                            
                        }
                    }
                    else
                    {
                        this.ShowError("Unable to save ...!");
                    }
                }
                catch (DBConcurrencyException)
                {
                    this.ShowError(string.Format("While your save operation, someone has changed same data.{0}Your save operation can't be perform on old data!{0}Your changes will be discarded and new data will be loaded after this message.", Environment.NewLine));
                    this.OnDataShow();
                }
                catch (Exception ex)
                {
                    this.ShowError(ex.Message);
                }

            }
        }

        protected virtual void OnDataShow()
        {
            this.Text = (this.mEntity.IsNew ? "New " : "Manage ") + Common.ToHumanCase(this.mEntity.GetType().Name);
            this.btnSave.Visible = true;
            //if (AppContext.IsUserLoggedIn)
            //    this.btnSave.Visible = AppContext.g;
            if (AppContext.IsUserLoggedIn && !this.mEntity.IsNew)
                this.btnDelete.Visible = true;
            else
                this.btnDelete.Visible = false;
        }

        protected virtual void OnDataSet() { }

        protected virtual void OnSaveComplete() { }

        protected virtual bool OnDataValidation() { return true; }

        #endregion

        #region Utility Methods


        protected TextBox ReplaceWithTextbox(Control ctl, string value)
        {
            TextBox r = null;
            if (ctl != null)
            {
                r = new TextBox();
                r.Name = "txt_" + ctl.Name;
                r.ReadOnly = true;
                r.BackColor = SystemColors.Window;
                r.Location = ctl.Location;
                r.Width = ctl.Width;
                r.Margin = ctl.Margin;
                r.Anchor = ctl.Anchor;
                r.Dock = ctl.Dock;
                r.Text = value;
                r.TabIndex = ctl.TabIndex;
                r.Tag = ctl.Tag;
                r.Enter += new EventHandler(OnControlEnter);
                r.Leave += new EventHandler(OnControlLeave);


                Control ctlParent = ctl.Parent;
                TableLayoutPanel tblParent = ctlParent as TableLayoutPanel;
                if (tblParent != null)
                {
                    TableLayoutPanelCellPosition pos = tblParent.GetCellPosition(ctl);
                    int colSpan = tblParent.GetColumnSpan(ctl);
                    tblParent.Controls.Remove(ctl);
                    ctl.Dispose();
                    tblParent.Controls.Add(r, pos.Column, pos.Row);
                    tblParent.SetColumnSpan(r, colSpan);
                }
                else if (ctlParent != null)
                {
                    ctlParent.Controls.Remove(ctl);
                    ctl.Dispose();
                    ctlParent.Controls.Add(r);
                }
            }
            return r;
        }

        protected LinkLabel ReplaceWithLinklable(Control ctl, string value)
        {
            LinkLabel r = null;
            if (ctl != null)
            {
                value = (value == null ? string.Empty : value);
                r = new LinkLabel();
                r.Name = "lnk_" + ctl.Name;
                r.Location = ctl.Location;
                r.Width = ctl.Width;
                r.Margin = ctl.Margin;
                r.Anchor = ctl.Anchor;
                r.Dock = ctl.Dock;
                r.Text = value;
                r.TextAlign = ContentAlignment.MiddleLeft;
                r.Links.Add(0, value.Length, value);
                r.TabIndex = ctl.TabIndex;
                r.Tag = ctl.Tag;
                r.Enter += new EventHandler(OnControlEnter);
                r.Leave += new EventHandler(OnControlLeave);

                Control ctlParent = ctl.Parent;
                TableLayoutPanel tblParent = ctlParent as TableLayoutPanel;

                if (tblParent != null)
                {
                    TableLayoutPanelCellPosition pos = tblParent.GetCellPosition(ctl);
                    int colSpan = tblParent.GetColumnSpan(ctl);
                    tblParent.Controls.Remove(ctl);
                    ctl.Dispose();
                    tblParent.Controls.Add(r, pos.Column, pos.Row);
                    tblParent.SetColumnSpan(r, colSpan);
                }
                else if (ctlParent != null)
                {
                    ctlParent.Controls.Remove(ctl);
                    ctl.Dispose();
                    ctlParent.Controls.Add(r);
                }
            }
            return r;
        }

        protected Label ReplaceWithLable(Control ctl, string value)
        {
            Label r = null;
            if (ctl != null)
            {
                r = new Label();
                r.Name = "lbl_" + ctl.Name;
                r.Location = ctl.Location;
                r.Width = ctl.Width;
                r.Margin = ctl.Margin;
                r.Dock = ctl.Dock;
                r.Anchor = ctl.Anchor;
                r.Text = value;
                r.TextAlign = ContentAlignment.MiddleRight;
                r.TabIndex = ctl.TabIndex;
                r.Tag = ctl.Tag;
                r.Click += new EventHandler(this.OnLabelClick);

                Control ctlParent = ctl.Parent;
                TableLayoutPanel tblParent = ctlParent as TableLayoutPanel;

                if (tblParent != null)
                {
                    TableLayoutPanelCellPosition pos = tblParent.GetCellPosition(ctl);
                    int colSpan = tblParent.GetColumnSpan(ctl);
                    tblParent.Controls.Remove(ctl);
                    ctl.Dispose();
                    tblParent.Controls.Add(r, pos.Column, pos.Row);
                    tblParent.SetColumnSpan(r, colSpan);
                }
                else if (ctlParent != null)
                {
                    ctlParent.Controls.Remove(ctl);
                    ctl.Dispose();
                    ctlParent.Controls.Add(r);
                }
            }
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

        protected void SetValue(NumericUpDown ctl, decimal value)
        {
            if (ctl != null)
                ctl.Value = (value <= ctl.Maximum && value >= ctl.Minimum) ? value : ctl.Minimum;
        }

        protected void SetValue(NumericUpDown ctl, int value)
        {
            SetValue(ctl, (decimal)value);
        }

        protected void SetValue(DateTimePicker ctl, DateTime value)
        {
            if (ctl != null)
                ctl.Value = (value >= ctl.MinDate && value <= ctl.MaxDate) ? value : ctl.MinDate;
        }

        protected void SetValue(DateTimePicker ctl, DateTime? value)
        {
            if (ctl != null)
            {
                if (value == null)
                    ctl.Checked = false;
                else
                    ctl.Value = (value.Value >= ctl.MinDate && value.Value <= ctl.MaxDate) ? value.Value : ctl.MinDate;
            }
        }

        protected void SetDateTime(DateTimePicker ctlDate, NumericUpDown nudHours, NumericUpDown nudMins, DateTime value)
        {
            this.SetValue(ctlDate, value.Date);
            this.SetValue(nudHours, value.Hour);
            this.SetValue(nudMins, value.Minute);
        }

        protected DateTime GetDateTime(DateTimePicker ctlDate, NumericUpDown nudHours, NumericUpDown nudMins)
        {
            if (ctlDate.Checked)
                return ctlDate.Value.Date.AddHours((double)nudHours.Value).AddMinutes((double)nudMins.Value);
            else
                return DateTime.MinValue;
        }

        protected void ShowInformation(string msg)
        {
            MessageBox.Show(this, msg, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        protected void ShowError(string msg)
        {
            MessageBox.Show(this, msg, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        protected void ShowWarning(string msg)
        {
            MessageBox.Show(this, msg, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        protected bool ShowConfirm(string msg)
        {
            return MessageBox.Show(this, msg, this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
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

        private Point GetPosition(Size size, ContentAlignment position)
        {
            int x = 0, y = 0;
            switch (position)
            {
                case ContentAlignment.TopCenter:
                    x = size.Width / 2;
                    break;
                case ContentAlignment.TopRight:
                    x = size.Width;
                    break;
                case ContentAlignment.MiddleLeft:
                    y = size.Height / 2;
                    break;
                case ContentAlignment.MiddleCenter:
                    x = size.Width / 2;
                    y = size.Height / 2;
                    break;
                case ContentAlignment.MiddleRight:
                    x = size.Width;
                    y = size.Height / 2;
                    break;
                case ContentAlignment.BottomLeft:
                    y = size.Height;
                    break;
                case ContentAlignment.BottomCenter:
                    x = size.Width / 2;
                    y = size.Height;
                    break;
                case ContentAlignment.BottomRight:
                    x = size.Width;
                    y = size.Height;
                    break;
            }
            return new Point(x, y);
        }

        protected void ShowTooltip(Control tipControl, string tipTitle, string tipMessage, ContentAlignment tipPosition, ToolTipIcon tipIcon, int duration)
        {
            if (null != tipControl && !tipControl.IsDisposed)
            {
                ToolTip r = null;

                if (null == mToolTips)
                    this.mToolTips = new Dictionary<string, ToolTip>();

                if (this.mToolTips.ContainsKey(tipControl.Name))
                {
                    r = this.mToolTips[tipControl.Name];
                }
                else
                {
                    if (null == this.components)
                        this.components = new System.ComponentModel.Container();
                    r = new ToolTip(this.components);
                    this.mToolTips.Add(tipControl.Name, r);
                    r.Active = true;
                    r.IsBalloon = true;
                    r.ShowAlways = true;
                    r.AutomaticDelay = int.MaxValue;
                    r.AutoPopDelay = int.MaxValue;
                    r.InitialDelay = int.MaxValue;
                    r.ReshowDelay = int.MaxValue;
                }

                if (null != r)
                {
                    r.Hide(tipControl);
                    r.ToolTipIcon = tipIcon;
                    r.ToolTipTitle = tipTitle;
                    r.SetToolTip(tipControl, tipMessage);
                    Point p = (this.GetPosition(tipControl.Size, tipPosition));
                    r.Show(tipMessage, tipControl, p, duration);
                    //r.Show(tipMessage, tipControl, this.GetPosition(tipControl, tipPosition), duration);

                }
            }
        }

        protected void ShowTooltip(Control tipControl, string tipTitle, string tipMessage, ContentAlignment tipPosition)
        {
            this.ShowTooltip(tipControl, tipTitle, tipMessage, tipPosition, ToolTipIcon.Error, 5000);
        }

        protected void ShowTooltip(Control tipControl, string tipTitle, string tipMessage)
        {
            this.ShowTooltip(tipControl, tipTitle, tipMessage, ContentAlignment.MiddleRight, ToolTipIcon.Error, 5000);
        }

        protected void ShowTooltip(Control tipControl, string tipTitle, string tipMessage, ContentAlignment tipPosition, ToolTipIcon tipIcon)
        {
            this.ShowTooltip(tipControl, tipTitle, tipMessage, tipPosition, tipIcon, 5000);
        }

        protected void ShowTooltip(Control tipControl, string tipTitle, string tipMessage, ToolTipIcon tipIcon)
        {
            this.ShowTooltip(tipControl, tipTitle, tipMessage, ContentAlignment.MiddleRight, tipIcon, 5000);
        }

        private void ProcessKeyDown(KeyEventArgs e)
        {
            if (!e.Control && e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        #endregion
       
    }
}
