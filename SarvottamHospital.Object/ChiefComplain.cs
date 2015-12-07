using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace SarvottamHospital.Object
{
    public sealed class ChiefComplain : Objectbase
    {
        internal struct Columns
        {
            public const string ChiefComplain = "ChiefComplain";
            public const string ChiefComplainGuid = "ChiefComplainGuid";
            public const string ChiefComplainName = "ChiefComplainName";
            public const string ChiefComplainDescription = "ChiefComplainDescription";
            public const string ChiefComplainCreatedBy = "ChiefComplainCreatedBy";
            public const string ChiefComplainCreatedOn = "ChiefComplainCreatedOn";
            public const string ChiefComplainModifiedBy = "ChiefComplainModifiedBy";
            public const string ChiefComplainModifiedOn = "ChiefComplainModifiedOn";
        }
        #region Constructor
        public ChiefComplain() : base() { }

        public ChiefComplain(HistoryProcedure obj) { this.Referer = obj; }

        public ChiefComplain(Guid key) : base(key) { }

        public ChiefComplain(SqlDataReader dr) : base(dr) { }

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

        private Guid mChiefComplainGuid;

        public Guid ChiefComplainGuid
        {
            get { return mChiefComplainGuid; }
            set { mChiefComplainGuid = value; }
        }

        private Guid mChiefComplainCreatedBy;

        public Guid ChiefComplainCreatedBy
        {
            get { return mChiefComplainCreatedBy; }
            set { mChiefComplainCreatedBy = value; }
        }
        private Guid mChiefComplainModifiedBy;

        public Guid ChiefComplainModifiedBy
        {
            get { return mChiefComplainModifiedBy; }
            set { mChiefComplainModifiedBy = value; }
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

            if (dr != null && AppShared.IsNotNull(dr[Columns.ChiefComplainGuid]))
            {
                this.mId = AppShared.DbValueToInteger(dr[Columns.ChiefComplain]);
                this.mObjectGuid = AppShared.DbValueToGuid(dr[Columns.ChiefComplainGuid]);
                this.mName = AppShared.DbValueToString(dr[Columns.ChiefComplainName]);
                this.mDescription = AppShared.DbValueToString(dr[Columns.ChiefComplainDescription]);
                this.mCreatedByUser = AppShared.DbValueToGuid(dr[Columns.ChiefComplainCreatedBy]);
                this.mCreatedOn = AppShared.DbValueToDateTime(dr[Columns.ChiefComplainCreatedOn]);
                this.mModifiedByUser = AppShared.DbValueToGuid(dr[Columns.ChiefComplainModifiedBy]);
                this.mModifiedOn = AppShared.DbValueToDateTime(dr[Columns.ChiefComplainModifiedOn]);
                this.Status = ObjectStatus.Opened;
                r = true;

            }
            return r;
        }
        protected override bool OpenRecord(Guid key)
        {
            bool r = false;
            using (SqlDataReader dr = AppDAL.ChiefComplainSelect(key))
                r = dr != null && dr.Read() && this.Populate(dr);
            return r;
        }
        protected override bool InsertRecord()
        {
            Guid createdBy = AppContext.UserGuid;
            DateTime CreatedOn;

            bool r = AppDAL.ChiefComplainInsert(this.mObjectGuid, this.mName, this.mDescription, createdBy, out CreatedOn);
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

            bool r = AppDAL.ChiefComplainUpdate(this.mObjectGuid, this.mName, this.mDescription, modifiedBy, out modifiedOn);
            if (r)
            {
                this.mModifiedByUser = modifiedBy;
                this.mModifiedOn = modifiedOn;
            }
            return r;
        }
        protected override bool DeleteRecord()
        {
            return AppDAL.ChiefComplainDelete(this.mObjectGuid);
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
        public sealed class ChiefComplainCollection : ObjectCollection<ChiefComplain>
        {
            #region ChiefComplainCollection
            public ChiefComplainCollection()
            {
                using (SqlDataReader dr = AppDAL.ChiefComplainSelectAll())
                {
                    LoadObjectsFromReader(dr);
                }
            }
            #endregion

            #region ChiefComplainCollection
            public ChiefComplainCollection(string searchText)
            {
                using (SqlDataReader dr = AppDAL.ChiefComplainSearch(searchText))
                {
                    LoadObjectsFromReader(dr);
                }
            }
            #endregion

            #region ChiefComplainCollection
            public ChiefComplainCollection(Guid ChiefComplainGuid)
            {
                using(SqlDataReader dr = AppDAL.ChiefComplainSelect(ChiefComplainGuid))
                {
                    LoadObjectsFromReader(dr);
                }
            }
            //public ChiefComplainCollection(Guid ChiefComplainGuid)
            //{
            //    using (SqlDataReader dr = AppDAL.ChiefComplainSelect(ChiefComplainGuid))
            //    {
            //        LoadObjectsFromReader(dr);
            //    }
            //}
            #endregion
           
        }
    
}
