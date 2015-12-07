using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace SarvottamHospital.Object
{
    public sealed class AssociateComplain : Objectbase
    {
        internal struct Columns
        {
            public const string AssociateComplainId = "AssociateComplainId";
            public const string AssociateComplainGuid = "AssociateComplainGuid";
            public const string AssociateComplainName = "AssociateComplainName";
            public const string AssociateComplainDescription = "AssociateComplainDescription";
            public const string AssociateComplainCreatedBy = "AssociateComplainCreatedBy";
            public const string AssociateComplainCreatedOn = "AssociateComplainCreatedOn";
            public const string AssociateComplainModifiedBy = "AssociateComplainModifiedBy";
            public const string AssociateComplainModifiedOn = "AssociateComplainModifiedOn";
        }

        #region Constructor
        public AssociateComplain() : base() { }

        public AssociateComplain(HistoryProcedure obj) { this.Referer = obj; }

        public AssociateComplain(Guid key) : base(key) { }

        public AssociateComplain(SqlDataReader dr) : base(dr) { }

        #endregion

        #region Properties
        public override string DisplayName
        {
            get { return this.mName; }
        }

        private string mName;

        public string Name
        {
            get { return mName; }
            set { mName = value; }
        }
        private string mDescription;

        public string Description
        {
            get { return mDescription; }
            set { mDescription = value; }
        }

        private Guid mAssociateComplainGuid;

        public Guid AssociateComplainGuid
        {
            get { return mAssociateComplainGuid; }
            set { mAssociateComplainGuid = value; }
        }

        private Guid mAssociateComplainCreatedBy;

        public Guid AssociateComplainCreatedBy
        {
            get { return mAssociateComplainCreatedBy; }
            set { mAssociateComplainCreatedBy = value; }
        }
        private Guid mAssociateComplainModifiedBy;

        public Guid AssociateComplainModifiedBy
        {
            get { return mAssociateComplainModifiedBy; }
            set { mAssociateComplainModifiedBy = value; }
        }
        //public override string ToString()
        //{
        //    return this.Name;
        //}
        private Objectbase mReferer;
        private Objectbase Referer
        {
            get { return this.mReferer; }
            set { this.mReferer = value; }
        }

        #endregion

        #region overridden

        internal override bool CreateRecord()
        {
            return base.CreateRecord();
        }
        internal override bool Populate(SqlDataReader dr)
        {
            bool r = false;

            if (dr != null && AppShared.IsNotNull(dr[Columns.AssociateComplainGuid]))
            {
                this.mId = AppShared.DbValueToInteger(dr[Columns.AssociateComplainId]);
                this.mObjectGuid = AppShared.DbValueToGuid(dr[Columns.AssociateComplainGuid]);
                this.mName = AppShared.DbValueToString(dr[Columns.AssociateComplainName]);
                this.mDescription = AppShared.DbValueToString(dr[Columns.AssociateComplainDescription]);
                this.mCreatedByUser = AppShared.DbValueToGuid(dr[Columns.AssociateComplainCreatedBy]);
                this.mCreatedOn = AppShared.DbValueToDateTime(dr[Columns.AssociateComplainCreatedOn]);
                this.mModifiedByUser = AppShared.DbValueToGuid(dr[Columns.AssociateComplainModifiedBy]);
                this.mModifiedOn = AppShared.DbValueToDateTime(dr[Columns.AssociateComplainModifiedOn]);
                this.Status = ObjectStatus.Opened;
                r = true;

            }
            return r;
        }
        protected override bool OpenRecord(Guid key)
        {
            bool r = false;
            using (SqlDataReader dr = AppDAL.AssociateComplainSelect(key))
                r = dr != null && dr.Read() && this.Populate(dr);
            return r;
        }
        protected override bool InsertRecord()
        {
            Guid createdBy = AppContext.UserGuid;
            DateTime CreatedOn;

            bool r = AppDAL.AssociateComplainInsert(this.mObjectGuid, this.mName, this.mDescription, createdBy, out CreatedOn);
            if (r)
            {
                this.mCreatedByUser = createdBy;
                this.mCreatedOn = CreatedOn;
                this.mModifiedByUser = createdBy;
                this.mModifiedOn = CreatedOn;
            }
            return r;
        }
        protected override bool UpdateRecord()
        {
            Guid modifiedBy = AppContext.UserGuid;
            DateTime modifiedOn;

            bool r = AppDAL.AssociateComplainUpdate(this.mObjectGuid, this.mName, this.mDescription, modifiedBy, out modifiedOn);
            if (r)
            {
                this.mModifiedByUser = modifiedBy;
                this.mModifiedOn = modifiedOn;
            }
            return r;
        }
        protected override bool DeleteRecord()
        {
            return AppDAL.AssociateComplainDelete(this.mObjectGuid);
        }
        protected override void Reset()
        {
            base.Reset();
            this.mObjectGuid = Guid.Empty;
            this.mName = string.Empty;
            this.mDescription = string.Empty;
        }
        #endregion
    }
        public sealed class AssociateComplainCollection : ObjectCollection<AssociateComplain>
        {
            #region AssociateComplainCollection
            public AssociateComplainCollection()
            {
                using (SqlDataReader dr = AppDAL.AssociateComplainSelectAll())
                {
                    LoadObjectsFromReader(dr);
                }
            }
            #endregion

            #region AssociateComplainCollection
            public AssociateComplainCollection(string searchText)
            {
                using (SqlDataReader dr = AppDAL.AssociateComplainSearch(searchText))
                {
                    LoadObjectsFromReader(dr);
                }
            }
            #endregion

            #region AssociateComplainCollection
            public AssociateComplainCollection(Guid AssociateComplainGuid)
            {
                using (SqlDataReader dr = AppDAL.AssociateComplainSelect(AssociateComplainGuid))
                {
                    LoadObjectsFromReader(dr);
                }
            }
            #endregion
        }
    
}
