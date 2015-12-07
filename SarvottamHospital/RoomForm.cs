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
    public partial class RoomForm : ObjectbaseForm
    {
         private Room mEntry;

        #region RoomForm

        public RoomForm() : this(null) { }

        public RoomForm(Room room)
            : base(room)
        {
            this.mEntry = room;
            this.InitializeComponent();
            this.UserInitialize();
        }

        #endregion

        #region UserIntialize
        private void UserInitialize()
        {
            this.txtRoomType.Tag = this.lblRoomType;
            lblRoomType.Click += new EventHandler(OnLabelClick);
            txtRoomType.Enter += new EventHandler(OnControlEnter);
            txtRoomType.Leave += new EventHandler(OnControlLeave);

            this.txtRoomDesc.Tag = this.lblRoomDesc;
            this.lblRoomDesc.Click += new EventHandler(OnLabelClick);
            this.txtRoomDesc.Enter += new EventHandler(OnControlEnter);
            this.txtRoomDesc.Leave += new EventHandler(OnControlLeave);
        }
        #endregion

        #region OnDataSet
        protected override void OnDataSet()
        {
            base.OnDataSet();
            if (!Objectbase.IsNullOrEmpty(this.mEntry))
            {
                this.mEntry.Type = txtRoomType.Text.Trim();
                this.mEntry.Description = txtRoomDesc.Text.Trim();
            }
        }
        #endregion

        #region OnDataShow
        protected override void OnDataShow()
        {
            base.OnDataShow();
            if (!Objectbase.IsNullOrEmpty(this.mEntry))
            {
                this.CheckPermission();
                this.txtRoomType.Text = this.mEntry.Type;
                this.txtRoomDesc.Text = this.mEntry.Description;
                this.txtRoomType.Select();
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
                    if (e.DisplayName == "Rooms Details")
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
            if (this.txtRoomType.Text.Trim().Length <= 0)
            {
                this.ShowTooltip(this.txtRoomType, "Room Type", "Room Type is Required!", ContentAlignment.TopRight);
                if (r)
                    this.txtRoomType.Select();
                r = false;
            }

            return r && base.OnDataValidation();
        }
        #endregion

        #region ShowForm
        public static bool ShowForm(Room obj)
        {
            bool r = false;
            if (!Objectbase.IsNullOrEmpty(obj))
            {
                using (RoomForm frm = new RoomForm(obj))
                {
                    r = frm.ShowDialog() == DialogResult.OK;
                }
            }
            return r;
        }
        #endregion
    }
}
