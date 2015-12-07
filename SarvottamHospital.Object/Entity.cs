using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SarvottamHospital.Object
{
    public sealed class Entity : Objectbase
    {
        internal struct Columns
        {
            public const string Id = "EntityId";
            public const string Guid = "EntityGuid";
            public const string Name = "EntityName";
            public const string Caption = "EntityCaption";
            public const string TypeName = "EntityTypeName";
            public const string ListCaption = "EntityListCaption";
            public const string ListTypeName = "EntityListTypeName";
            public const string IconSmall = "EntityIconSmall";
            public const string IconLarge = "EntityIconLarge";
            public const string GroupName = "EntityGroupName";
            public const string Desc = "EntityDesc";
            public const string CreatedBy = "EntityCreatedBy";
            public const string CreatedOn = "EntityCreatedOn";
            public const string ModifiedBy = "EntityModifiedBy";
            public const string ModifiedOn = "EntityModifiedOn";
        }

        #region Constructor

        public Entity() : base() { }

        public Entity(Guid key) : base(key) { }

        public Entity(SqlDataReader dr) : base(dr) { }

        #endregion

        #region Property

        public override string DisplayName
        {
            get { return this.mName; }
        }

        private string mName;
        public string Name
        {
            get { return this.mName; }
            set { this.mName = value; }
        }

        private string mGroupName;
        public string GroupName
        {
            get { return this.mGroupName; }
            set { this.mGroupName = value; }
        }

        private string mCaption;
        public string Caption
        {
            get { return this.mCaption; }
            set { this.mCaption = value; }
        }

        private string mTypeName;
        public string TypeName
        {
            get { return this.mTypeName; }
            set { this.mTypeName = value; }
        }

        private string mListCaption;
        public string ListCaption
        {
            get { return this.mListCaption; }
            set { this.mListCaption = value; }
        }

        private string mListTypeName;
        public string ListTypeName
        {
            get { return this.mListTypeName; }
            set { this.mListTypeName = value; }
        }

        private byte[] mIconSmall;
        public byte[] IconSmall
        {
            get { return this.mIconSmall; }
            set { this.mIconSmall = value; }
        }

        private byte[] mIconLarge;
        public byte[] IconLarge
        {
            get { return this.mIconLarge; }
            set { this.mIconLarge = value; }
        }

        private string mDescription;
        public string Description
        {
            get { return this.mDescription; }
            set { this.mDescription = value; }
        }

        #endregion

        #region Overiden

        internal override bool CreateRecord()
        {
            return base.CreateRecord();
        }

        internal override bool Populate(System.Data.SqlClient.SqlDataReader dr)
        {
            bool r = false;

            if (dr != null && AppShared.IsNotNull(dr[Columns.Id]))
            {
                this.mId = AppShared.DbValueToInteger(dr[Columns.Id]);
                this.mObjectGuid = AppShared.DbValueToGuid(dr[Columns.Guid]);
                this.mCaption = AppShared.DbValueToString(dr[Columns.Caption]);
                this.mGroupName = AppShared.DbValueToString(dr[Columns.GroupName]);
                this.mIconLarge = AppShared.DbValueToBytes(dr, Columns.IconLarge);
                this.mIconSmall = AppShared.DbValueToBytes(dr, Columns.IconSmall);
                this.mListCaption = AppShared.DbValueToString(dr[Columns.ListCaption]);
                this.mListTypeName = AppShared.DbValueToString(dr[Columns.ListTypeName]);
                this.mName = AppShared.DbValueToString(dr[Columns.Name]);
                this.mTypeName = AppShared.DbValueToString(dr[Columns.TypeName]);
                this.mDescription = AppShared.DbValueToString(dr[Columns.Desc]);
                this.mCreatedByUser = AppShared.DbValueToGuid(dr[Columns.CreatedBy]);
                this.mCreatedOn = AppShared.DbValueToDateTime(dr[Columns.CreatedOn]);
                this.mModifiedByUser= AppShared.DbValueToGuid(dr[Columns.ModifiedBy]);
                this.mModifiedOn = AppShared.DbValueToDateTime(dr[Columns.ModifiedOn]);
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
            using (SqlDataReader dr = AppDAL.EntitySelect(key))
                r = dr != null && dr.Read() && this.Populate(dr);
            return r;
        }

        protected override bool DeleteRecord()
        {
            return AppDAL.EntityDelete(this.mObjectGuid);
        }

        protected override bool InsertRecord()
        {
            int newid;
            Guid createdBy = AppContext.UserGuid;
            DateTime createdOn;
            bool r = AppDAL.EntityInsert(this.mObjectGuid, this.mName, this.mCaption, this.mTypeName, this.mListCaption, this.mListTypeName, this.mIconSmall, this.mIconLarge, this.mGroupName, this.mDescription, createdBy, out createdOn, out newid);
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
            bool r = AppDAL.EntityUpdate(this.mObjectGuid, this.mName, this.mCaption, this.mTypeName, this.mListCaption, this.mListTypeName, this.mIconSmall, this.mIconLarge, this.mGroupName, this.mDescription, modifiedBy, out modifiedOn);
            if (r)
            {
                this.mModifiedByUser = modifiedBy;
                this.mModifiedOn = modifiedOn;
            }
            return r;
        }

        protected override void Reset()
        {
            base.Reset();

            this.Name = string.Empty;
            this.GroupName = string.Empty;
            this.Caption = string.Empty;
            this.TypeName = string.Empty;
            this.ListCaption = string.Empty;
            this.ListTypeName = string.Empty;
            this.IconSmall = null;
            this.IconLarge = null;
        }

        #endregion

        public static System.Collections.Specialized.StringCollection GetGroups()
        {
            System.Collections.Specialized.StringCollection r = new System.Collections.Specialized.StringCollection();

            using (SqlDataReader dr = AppDAL.EntityGroupSelectAll())
            {
                if (dr != null)
                {
                    string str = string.Empty;
                    while (dr.Read())
                    {
                        str = AppShared.DbValueToString(dr[Entity.Columns.GroupName]);
                        if (!string.IsNullOrEmpty(str))
                            r.Add(str);
                    }
                }
            }

            return r;
        }
    }

    public sealed class EntityCollection : ObjectCollection<Entity>
    {
        public EntityCollection()
        {
            using (SqlDataReader dr = AppDAL.EntitySelectAll())
            {
                LoadObjectsFromReader(dr);
            }
        }

        public EntityCollection(string searchText)
        {
            using (SqlDataReader dr = AppDAL.EntitySearch(searchText))
            {
                LoadObjectsFromReader(dr);
            }
        }
        public EntityCollection(Guid userRoleGuid)
        {
            using (SqlDataReader dr = AppDAL.EntityByUser(userRoleGuid))
            {
                LoadObjectsFromReader(dr);
            }
        }
    }
}
