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
    public partial class EntityTabPage : TabPage
    {

        private ObjectListControl listCtrl;

        public EntityTabPage(ObjectListControl ctl, string caption)
            : base(caption)
        {
            this.Caption = caption;
            if (null != ctl && !ctl.IsDisposed)
            {
                this.listCtrl = ctl;
                this.ClientSize = ctl.Size;
                ctl.Location = new Point(0, 0);
                ctl.Dock = DockStyle.Fill;
                ctl.CloseTabRequest += new EventHandler(this.OnCloseTabRequest);
                this.Controls.Add(ctl);
            }
        }

        //private void OnResultChanged(object sender, ResultChangedArgs e)
        //{
        //    if (null != e)
        //        this.Text = string.Format("{0} ({1})", this.Caption, e.Count);
        //}

        private void OnCloseTabRequest(object sender, EventArgs e)
        {
            TabControl tab = this.Parent as TabControl;
            if (null != tab)
            {
                tab.Controls.Remove(this);
                this.Dispose();
            }
        }

        private string mCaption = string.Empty;
        public string Caption
        {
            get { return this.mCaption; }
            set { this.mCaption = (null == value ? string.Empty : value); }
        }

        public void RefreshData()
        {
            if (null != listCtrl && !listCtrl.IsDisposed)
                listCtrl.RefreshData();
        }

    }
}
