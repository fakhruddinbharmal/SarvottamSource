using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace SarvottamHospital.Object
{
    public sealed class History : Objectbase
    {
        internal struct Columns
        {
            public const string HistoryId = "HistoryId";
            public const string HistoryGuid = "HistoryGuid";
            public const string HistoryName = "HistoryName";
            public const string HistoryDescription = "HistoryDescription";
            public const string HistoryCreatedBy = "HistoryCreatedBy";
            public const string HistoryCreatedOn = "HistoryCreatedOn";
            public const string HistoryModifiedBy = "HistoryModifiedBy";
            public const string HistoryModifiedOn = "HistoryModifiedOn";
        }

        #region Constructor
        public History() : base() { }

        public History(HistoryProcedure obj) { this.Referer = obj; }

        public History(Guid key) : base(key) { }

        public History(SqlDataReader dr) : base(dr) { }

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

        private Guid mHistoryGuid;

        public Guid HistoryGuid
        {
            get { return mHistoryGuid; }
            set { mHistoryGuid = value; }
        }

        private Guid mHistoryCreatedBy;

        public Guid HistoryCreatedBy
        {
            get { return mHistoryCreatedBy; }
            set { mHistoryCreatedBy = value; }
        }
        private Guid mHistoryModifiedBy;

        public Guid HistoryModifiedBy
        {
            get { return mHistoryModifiedBy; }
            set { mHistoryModifiedBy = value; }
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

            if (dr != null && AppShared.IsNotNull(dr[Columns.HistoryGuid]))
            {
                this.mId = AppShared.DbValueToInteger(dr[Columns.HistoryId]);
                this.mObjectGuid = AppShared.DbValueToGuid(dr[Columns.HistoryGuid]);
                this.mName = AppShared.DbValueToString(dr[Columns.HistoryName]);
                this.mDescription = AppShared.DbValueToString(dr[Columns.HistoryDescription]);
                this.mCreatedByUser = AppShared.DbValueToGuid(dr[Columns.HistoryCreatedBy]);
                this.mCreatedOn = AppShared.DbValueToDateTime(dr[Columns.HistoryCreatedOn]);
                this.mModifiedByUser = AppShared.DbValueToGuid(dr[Columns.HistoryModifiedBy]);
                this.mModifiedOn = AppShared.DbValueToDateTime(dr[Columns.HistoryModifiedOn]);
                this.Status = ObjectStatus.Opened;
                r = true;

            }
            return r;
        }
        protected override bool OpenRecord(Guid key)
        {
            bool r = false;
            using (SqlDataReader dr = AppDAL.HistorySelect(key))
                r = dr != null && dr.Read() && this.Populate(dr);
            return r;
        }
        protected override bool InsertRecord()
        {
            Guid createdBy = AppContext.UserGuid;
            DateTime CreatedOn;

            bool r = AppDAL.HistoryInsert(this.mObjectGuid, this.mName, this.mDescription, createdBy, out CreatedOn);
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

            bool r = AppDAL.HistoryUpdate(this.mObjectGuid, this.mName, this.mDescription, modifiedBy, out modifiedOn);
            if (r)
            {
                this.mModifiedByUser = modifiedBy;
                this.mModifiedOn = modifiedOn;
            }
            return r;
        }
        protected override bool DeleteRecord()
        {
            return AppDAL.HistoryDelete(this.mObjectGuid);
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
        public sealed class HistoryCollection : ObjectCollection<History>
        {
            #region HistoryCollection
            public HistoryCollection()
            {
                using (SqlDataReader dr = AppDAL.HistorySelectAll())
                {
                    LoadObjectsFromReader(dr);
                }
            }
            #endregion

            #region HistoryCollection
            public HistoryCollection(string searchText)
            {
                using (SqlDataReader dr = AppDAL.HistorySearch(searchText))
                {
                    LoadObjectsFromReader(dr);
                }
            }
            #endregion

            #region HistoryCollection
            public HistoryCollection(Guid HistoryGuid)
            {
                using (SqlDataReader dr = AppDAL.HistorySelect(HistoryGuid))
                {
                    LoadObjectsFromReader(dr);
                }
            }
            #endregion
        }
    
}
