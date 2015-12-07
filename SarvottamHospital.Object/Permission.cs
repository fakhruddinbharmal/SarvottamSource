using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SarvottamHospital.Object
{
    public sealed class Permission : Objectbase
    {
        internal struct Columns
        {
            public const string PermissionUserRoleGuid = "PermissionUserRoleGuid";
            public const string PermissionEntityGuid = "PermissionEntityGuid";
            public const string PermissionCanView = "PermissionCanView";
            public const string PermissionCanCreate = "PermissionCanCreate";
            public const string PermissionCanEdit = "PermissionCanEdit";
            public const string PermissionCanDelete = "PermissionCanDelete";
            public const string PermissionCanSpecial = "PermissionCanSpecial";
            public const string PermissionModifiedBy = "PermissionModifiedBy";
        }


        #region Constructor

        public Permission() : base() { }

        public Permission(UserRole userRole, Entity entity)
            : base(true)
        {
            this.UserRole = userRole;
            this.Entity = entity;
        }

        public Permission(Guid userRoleGuid, Guid entityGuid)
            : base()
        {
            this.OpenRecord(userRoleGuid, entityGuid);
        }

        public Permission(SqlDataReader dr) : base(dr) { }

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

        private Guid mEntityGuid;
        public Guid EntityGuid
        {
            get { return this.mEntityGuid; }
            set { this.mEntityGuid = value; }
        }

        private Entity mEntity;
        public Entity Entity
        {
            get
            {
                if (IsNullOrEmpty(this.mEntity) || this.mEntity.ObjectGuid != this.mEntityGuid)
                    this.mEntity = (this.mEntityGuid != Guid.Empty ? new Entity(this.mEntityGuid) : null);

                return this.mEntity;
            }
            private set
            {
                if (Objectbase.IsNullOrEmpty(value))
                {
                    this.mEntity = null;
                    this.mEntityGuid = Guid.Empty;
                }
                else
                {
                    this.mEntity = value;
                    this.mEntityGuid = value.ObjectGuid;
                }
            }
        }

        public string EntityName
        {
            get
            {
                Entity obj = this.Entity;
                return (obj == null ? string.Empty : obj.Name);
            }
        }

        public byte[] EntitySmallIcon
        {
            get
            {
                Entity obj = this.Entity;
                return (obj == null ? null : obj.IconSmall);
            }
        }

        private bool mCanView;
        public bool CanView
        {
            get { return this.mCanView; }
            set { this.mCanView = value; }
        }

        private bool mCanSpecial;
        public bool CanSpecial
        {
            get { return this.mCanSpecial; }
            set { this.mCanSpecial = value; }
        }


        private bool mCanCreate;
        public bool CanCreate
        {
            get { return this.mCanCreate; }
            set { this.mCanCreate = value; }
        }

        public bool mCanEdit;
        public bool CanEdit
        {
            get { return this.mCanEdit; }
            set { this.mCanEdit = value; }
        }

        private bool mCanDelete;
        public bool CanDelete
        {
            get { return this.mCanDelete; }
            set { this.mCanDelete = value; }
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

            if (dr != null && AppShared.IsNotNull(dr[Columns.PermissionUserRoleGuid]) && AppShared.IsNotNull(dr[Columns.PermissionEntityGuid]))
            {
                this.mUserRoleGuid = AppShared.DbValueToGuid(dr[Columns.PermissionUserRoleGuid]);
                this.mEntityGuid = AppShared.DbValueToGuid(dr[Columns.PermissionEntityGuid]);
                this.mCanView = AppShared.DbValueToBoolean(dr[Columns.PermissionCanView]);
                this.mCanCreate = AppShared.DbValueToBoolean(dr[Columns.PermissionCanCreate]);
                this.mCanEdit = AppShared.DbValueToBoolean(dr[Columns.PermissionCanEdit]);
                this.mCanDelete = AppShared.DbValueToBoolean(dr[Columns.PermissionCanDelete]);
                this.mCanSpecial = AppShared.DbValueToBoolean(dr[Columns.PermissionCanSpecial]);

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
                return this.OpenRecord(this.mUserRoleGuid, this.mEntityGuid);
            else
                throw new NotImplementedException();

        }

        protected override bool InsertRecord()
        {
            Guid createdBy = AppContext.UserGuid;
            DateTime createdOn;
            bool r = AppDAL.PermissionInsert(this.mUserRoleGuid, this.mEntityGuid, this.mCanView, this.CanCreate, this.mCanEdit, this.mCanDelete, this.mCanSpecial, createdBy, out createdOn);
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
            bool r = AppDAL.PermissionUpdate(this.mUserRoleGuid, this.mEntityGuid, this.mCanView, this.mCanCreate, this.mCanEdit, this.mCanDelete, this.mCanSpecial, modifiedBy, out modifiedOn);
            if (r)
            {
                this.mModifiedByUser = modifiedBy;
                this.mModifiedOn = modifiedOn;
            }
            return r;
        }

        //protected override bool DeleteRecord(out bool hasConcurrency) 
        //{
        //    hasConcurrency = false;
        //    return AppDAL.PermissionDelete(this.mUserGuid, this.mEntityGuid);
        //}

        protected override bool DeleteRecord()
        {
            //hasConcurrency = false;
            return AppDAL.PermissionDelete(this.mUserRoleGuid, this.mEntityGuid);
        }

        protected override void Reset()
        {
            base.Reset();
            this.mUserRoleGuid = Guid.Empty;
            this.mEntityGuid = Guid.Empty;
            this.mCanCreate = false;
            this.mCanEdit = false;
            this.mCanDelete = false;
        }

        #endregion

        private bool OpenRecord(Guid userGuid, Guid entityGuid)
        {
            bool r = false;
            using (SqlDataReader dr = AppDAL.PermssionSelect(userGuid, entityGuid))
                r = dr != null && dr.Read() && this.Populate(dr);
            return r;
        }

    }

    public sealed class Permissions : ObjectCollection<Permission>
    {
        private UserRole mUserRole;

        public Permissions()
        {
            using (SqlDataReader dr = AppDAL.PermissionSelectAll())
            {
                LoadObjectsFromReader(dr);
            }
        }

        public Permissions(Guid userRoleGuid, Guid entityGuid)
        {
            using (SqlDataReader dr = AppDAL.PermssionSelect(userRoleGuid, entityGuid))
            {
                LoadObjectsFromReader(dr);
            }
        }

        public Permissions(UserRole userRole)
        {
            if (!Objectbase.IsNullOrEmpty(userRole))
            {
                this.mUserRole = userRole;
                using (SqlDataReader dr = AppDAL.PermssionSelect_AllEntityByUser(userRole.ObjectGuid))
                {
                    if (dr != null)
                    {
                        while (dr.Read())
                        {
                            Permission obj = null;
                            if (AppShared.IsNull(dr[Permission.Columns.PermissionEntityGuid]))
                            {
                                Entity entity = new Entity();
                                if (entity.Populate(dr))
                                {
                                    obj = new Permission(userRole, entity);
                                    this.Add(obj);
                                }
                            }
                            else
                            {
                                obj = new Permission();
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
                foreach (Permission obj in this.Items)
                {
                    if ((obj.CanCreate || obj.CanView || obj.CanEdit || obj.CanDelete || obj.CanSpecial))
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
