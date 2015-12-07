using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SarvottamHospital.Object
{
    public sealed class FieldPermission : Objectbase
    {
        internal struct Columns
        {
            public const string PermissionUserRoleGuid = "PermissionUserRoleGuid";
            public const string PermisionFieldGuid = "PermisionFieldGuid";
            public const string PermissionCanView = "PermissionCanView";
            public const string PermissionCreatedBy = "PermissionCreatedBy";
            public const string PermissionModifiedBy = "PermissionModifiedBy";
        }

        #region Constructor

        public FieldPermission() : base() { }

        public FieldPermission(UserRole userRole, Field field)
            : base(true)
        {
            this.UserRole = userRole;
            this.Field = field;
        }

        public FieldPermission(Guid userRoleGuid, Guid fieldGuid)
            : base()
        {
            this.OpenRecord(userRoleGuid, fieldGuid);
        }

        public FieldPermission(SqlDataReader dr) : base(dr) { }

        #endregion

        #region Property

        public override string DisplayName
        {
            get { return this.mUserRole.DisplayName; }
        }

        private Guid mUserRoleGuid;
        public Guid UserRoleGuid
        {
            get { return this.mUserRoleGuid; }
        }

        private UserRole mUserRole;
        public UserRole UserRole
        {
            get
            {
                if (IsNullOrEmpty(this.mUserRole) || this.mUserRole.ObjectGuid != this.mUserRoleGuid)
                    this.mUserRole = (this.mUserRoleGuid != Guid.Empty ? new UserRole(this.mUserRoleGuid) : null);

                return this.mUserRole;
            }
            private set
            {
                if (Objectbase.IsNullOrEmpty(value))
                {
                    this.mUserRole = null;
                    this.mUserRoleGuid = Guid.Empty;
                }
                else
                {
                    this.mUserRole = value;
                    this.mUserRoleGuid = value.ObjectGuid;
                }
            }
        }

        public string UserRoleName
        {
            get
            {
                UserRole obj = this.UserRole;
                return (obj == null ? string.Empty : obj.DisplayName);
            }
        }

        private Guid mFieldGuid;
        public Guid FieldGuid
        {
            get { return this.mFieldGuid; }
            set { this.mFieldGuid = value; }
        }

        private Field mField;
        public Field Field
        {
            get
            {
                if (IsNullOrEmpty(this.mField) || this.mField.ObjectGuid != this.mFieldGuid)
                    this.mField = (this.mFieldGuid != Guid.Empty ? new Field(this.mFieldGuid) : null);

                return this.mField;
            }
            private set
            {
                if (Objectbase.IsNullOrEmpty(value))
                {
                    this.mField = null;
                    this.mFieldGuid = Guid.Empty;
                }
                else
                {
                    this.mField = value;
                    this.mFieldGuid = value.ObjectGuid;
                }
            }
        }

        public string FieldName
        {
            get
            {
                Field obj = this.Field;
                return (obj == null ? string.Empty : obj.Name);
            }
        }

        private bool mCanView;
        public bool CanView
        {
            get { return this.mCanView; }
            set { this.mCanView = value; }
        }

        #endregion

        #region Overiden

        internal override bool CreateRecord()
        {
            return base.CreateRecord();
        }

        internal override bool Populate(SqlDataReader dr)
        {
            bool r = false;

            if (dr != null && AppShared.IsNotNull(dr[Columns.PermissionUserRoleGuid]) && AppShared.IsNotNull(dr[Columns.PermisionFieldGuid]))
            {
                this.mUserRoleGuid = AppShared.DbValueToGuid(dr[Columns.PermissionUserRoleGuid]);
                this.mFieldGuid = AppShared.DbValueToGuid(dr[Columns.PermisionFieldGuid]);
                this.mCanView = AppShared.DbValueToBoolean(dr[Columns.PermissionCanView]);
                this.mCreatedByUser = AppShared.DbValueToGuid(dr[Columns.PermissionCreatedBy]);
                this.mModifiedByUser = AppShared.DbValueToGuid(dr[Columns.PermissionModifiedBy]);
                this.Status = ObjectStatus.Opened;
                r = true;
            }
            else
            {
                this.Reset();
            }
            return r;
        }

        protected override bool OpenRecord(Guid key)
        {
            if (this.IsOpen)
                return this.OpenRecord(this.mUserRoleGuid, this.mFieldGuid);
            else
                throw new NotImplementedException();

        }

        protected override bool InsertRecord()
        {
            Guid createdBy = AppContext.UserGuid;
            DateTime createdOn;
            bool r = AppDAL.FieldPermissionInsert(this.mUserRoleGuid, this.mFieldGuid, this.mCanView, createdBy, out createdOn);
            if (r)
            {
                this.mCreatedByUser = createdBy;
                this.mCreatedOn = createdOn;
                this.mModifiedByUser = createdBy;
                this.mModifiedOn = createdOn;
            }
            return r;
        }

        protected override bool UpdateRecord()
        {
            Guid modifiedBy = AppContext.UserGuid;
            DateTime modifiedOn;
            bool r = AppDAL.FieldPermissionUpdate(this.mUserRoleGuid, this.mFieldGuid, this.mCanView, modifiedBy, out modifiedOn);
            if (r)
            {
                this.mModifiedByUser = modifiedBy;
                this.mModifiedOn = modifiedOn;
            }
            return r;
        }

        protected override bool DeleteRecord()
        {
            //hasConcurrency = false;
            return AppDAL.FieldPermissionDelete(this.mUserRoleGuid, this.mFieldGuid);
        }

        protected override void Reset()
        {
            base.Reset();
            this.mUserRoleGuid = Guid.Empty;
            this.mFieldGuid = Guid.Empty;
        }

        #endregion

        private bool OpenRecord(Guid userRoleGuid, Guid fieldGuid)
        {
            bool r = false;
            using (SqlDataReader dr = AppDAL.FieldPermssionSelect(userRoleGuid, fieldGuid))
                r = dr != null && dr.Read() && this.Populate(dr);
            return r;
        }

    }

    public sealed class FieldPermissions : ObjectCollection<FieldPermission>
    {
        private UserRole mUserRole;

        public FieldPermissions()
        {
            using (SqlDataReader dr = AppDAL.FieldPermissionSelectAll())
            {
                LoadObjectsFromReader(dr);
            }
        }

        public FieldPermissions(Guid userRoleGuid, Guid fieldGuid)
        {
            using (SqlDataReader dr = AppDAL.FieldPermssionSelect(userRoleGuid, fieldGuid))
            {
                LoadObjectsFromReader(dr);
            }
        }

        public FieldPermissions(UserRole userRole)
        {
            if (!Objectbase.IsNullOrEmpty(userRole))
            {
                this.mUserRole = userRole;
                using (SqlDataReader dr = AppDAL.FieldPermssionSelectAllEntityByUser(userRole.ObjectGuid))
                {
                    if (dr != null)
                    {
                        while (dr.Read())
                        {
                            FieldPermission obj = null;
                            if (AppShared.IsNull(dr[FieldPermission.Columns.PermisionFieldGuid]))
                            {
                                Field field = new Field();
                                if (field.Populate(dr))
                                {
                                    obj = new FieldPermission(userRole, field);
                                    this.Add(obj);
                                }
                            }
                            else
                            {
                                obj = new FieldPermission();
                                if (obj.Populate(dr))
                                    this.Add(obj);
                            }
                        }
                    }
                }
            }
        }

        public bool UpdateChanges()
        {
            bool r = false;

            if (!Objectbase.IsNullOrEmpty(mUserRole))
            {
                foreach (FieldPermission obj in this.Items)
                {
                    if ((obj.CanView))
                        obj.MarkToSave();
                    else
                        obj.MarkToDelete();

                    obj.UpdateChanges();
                }
                r = true;
            }

            return r;
        }

    }
}
