using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace SarvottamHospital.Object
{
    public sealed class UserRole : Objectbase
    {
        internal struct Columns
        {
            public const string UserRoleId = "UserRoleId";
            public const string UserRoleGuid = "UserRoleGuid";
            public const string UserRoleName = "UserRoleName";
            public const string UserRoleLevel = "UserRoleLevel";
            public const string UserRoleDesc = "UserRoleDesc";
            public const string UserRoleCreatedOn = "UserRoleCreatedOn";
            public const string UserRoleCreatedBy = "UserRoleCreatedBy";
            public const string UserRoleModifiedOn = "UserRoleModifiedOn";
            public const string UserRoleModifiedBy = "UserRoleModifiedBy";
        }

        #region Constructor

        public UserRole() : base() { }

        public UserRole(Guid key) : base(key) { }

        public UserRole(SqlDataReader dr) : base(dr) { }

        #endregion

        #region Properties

        public override string DisplayName
        {
            get { return this.mUserRoleName; }
        }

        private string mUserRoleName;
        public string UserRoleName
        {
            get { return this.mUserRoleName; }
            set { this.mUserRoleName = value; }
        }

        private int mUserRoleLevel;
        public int UserRoleLevel
        {
            get { return this.mUserRoleLevel; }
            set { this.mUserRoleLevel = value; }
        }

        private string mUserRoleDesc;
        public string UserRoleDesc
        {
            get { return this.mUserRoleDesc; }
            set { this.mUserRoleDesc = value; }
        }

        private int mUserRoleId;
        public int UserRoleId
        {
            get { return this.mUserRoleId; }
            set { this.mUserRoleId = value; }
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

            if (dr != null && AppShared.IsNotNull(dr[Columns.UserRoleGuid]))
            {
                this.mUserRoleId = AppShared.DbValueToInteger(dr[Columns.UserRoleId]);
                this.mObjectGuid = AppShared.DbValueToGuid(dr[Columns.UserRoleGuid]);
                this.mUserRoleName = AppShared.DbValueToString(dr[Columns.UserRoleName]);
                this.mUserRoleLevel = AppShared.DbValueToInteger(dr[Columns.UserRoleLevel]);
                this.mUserRoleDesc = AppShared.DbValueToString(dr[Columns.UserRoleDesc]);
                this.mCreatedByUser = AppShared.DbValueToGuid(dr[Columns.UserRoleCreatedBy]);
                this.mCreatedOn = AppShared.DbValueToDateTime(dr[Columns.UserRoleCreatedOn]);
                this.mModifiedByUser = AppShared.DbValueToGuid(dr[Columns.UserRoleModifiedBy]);
                this.mModifiedOn = AppShared.DbValueToDateTime(dr[Columns.UserRoleModifiedOn]);
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
            bool r = false;
            using (SqlDataReader dr = AppDAL.UserRoleSelect(key))
                r = dr != null && dr.Read() && this.Populate(dr);
            return r;

        }

        protected override bool InsertRecord()
        {
            int newid;
            Guid createdBy = AppContext.UserGuid;
            DateTime createdOn;

            bool r = AppDAL.UserRoleInsert(this.mObjectGuid, this.mUserRoleName, this.mUserRoleLevel, this.mUserRoleDesc, createdBy, out createdOn, out newid);
            if (r)
            {
                this.mId = newid;
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
            bool r = AppDAL.UserRoleUpdate(this.mObjectGuid, this.mUserRoleName, this.mUserRoleLevel, this.mUserRoleDesc, modifiedBy, out modifiedOn);
            if (r)
            {
                this.mModifiedByUser = modifiedBy;
                this.mModifiedOn = modifiedOn;
            }
            return r;
        }

        protected override bool DeleteRecord()
        {
            return AppDAL.UserRoleDelete(this.mObjectGuid);
        }

        protected override void Reset()
        {
            base.Reset();
            this.mUserRoleId = 0;
            this.mUserRoleLevel = 0;
            this.mUserRoleName = string.Empty;
        }

        //public static string SelectUserRoleByName(string RoleName)
        //{
        //    using (SqlDataReader dr = AppDAL.UserRoleSelectByName(RoleName))
        //    {
        //        if (dr != null && AppShared.IsNotNull(dr[Columns.UserRoleGuid]))
        //        {
        //           return AppShared.DbValueToString(dr[Columns.UserRoleGuid]);
        //        }
        //    }
        //}
        #endregion
    }
    public sealed class UserRoles : ObjectCollection<UserRole>
    {
        public UserRoles()
        {
            using (SqlDataReader dr = AppDAL.UserRoleSelectAll())
            {
                LoadObjectsFromReader(dr);
            }
        }

        public UserRoles(string searchText)
        {
            using (SqlDataReader dr = AppDAL.UserRoleSearch(searchText))
            {
                LoadObjectsFromReader(dr);
            }
        }

    }
}
