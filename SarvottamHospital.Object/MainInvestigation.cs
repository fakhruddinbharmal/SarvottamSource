using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace SarvottamHospital.Object
{
    public sealed class MainInvestigation : Objectbase
    {
        internal struct Columns
        {
            public const string MainInvestigationId = "MainInvestigationId";
            public const string MainInvestigationGuid = "MainInvestigationGuid";
            public const string MainInvestigationName = "MainInvestigationName";
            public const string MainInvestigationDescription = "MainInvestigationDescription";
            public const string MainInvestigationCreatedBy = "MainInvestigationCreatedBy";
            public const string MainInvestigationCreatedOn = "MainInvestigationCreatedOn";
            public const string MainInvestigationModifiedBy = "MainInvestigationModifiedBy";
            public const string MainInvestigationModifiedOn = "MainInvestigationModifiedOn";
        }

        #region Constructor
        public MainInvestigation() : base() { }

        public MainInvestigation(Guid key) : base(key) { }

        public MainInvestigation(OPDInvestigationProcedure obj)
        {
            this.Referer = obj;
        }

        public MainInvestigation(SqlDataReader dr) : base(dr) { }

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

        private Guid mMainInvestigationGuid;

        public Guid MainInvestigationGuid
        {
            get { return mMainInvestigationGuid; }
            set { mMainInvestigationGuid = value; }
        }

        private Guid mMainInvestigationCreatedBy;

        public Guid MainInvestigationCreatedBy
        {
            get { return mMainInvestigationCreatedBy; }
            set { mMainInvestigationCreatedBy = value; }
        }
        private Guid mMainInvestigationModifiedBy;

        public Guid MainInvestigationModifiedBy
        {
            get { return mMainInvestigationModifiedBy; }
            set { mMainInvestigationModifiedBy = value; }
        }

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

            if (dr != null && AppShared.IsNotNull(dr[Columns.MainInvestigationGuid]))
            {
                this.mId = AppShared.DbValueToInteger(dr[Columns.MainInvestigationId]);
                this.mObjectGuid = AppShared.DbValueToGuid(dr[Columns.MainInvestigationGuid]);
                this.mName = AppShared.DbValueToString(dr[Columns.MainInvestigationName]);
                this.mDescription = AppShared.DbValueToString(dr[Columns.MainInvestigationDescription]);
                this.mCreatedByUser = AppShared.DbValueToGuid(dr[Columns.MainInvestigationCreatedBy]);
                this.mCreatedOn = AppShared.DbValueToDateTime(dr[Columns.MainInvestigationCreatedOn]);
                this.mModifiedByUser = AppShared.DbValueToGuid(dr[Columns.MainInvestigationModifiedBy]);
                this.mModifiedOn = AppShared.DbValueToDateTime(dr[Columns.MainInvestigationModifiedOn]);
                this.Status = ObjectStatus.Opened;
                r = true;

            }
            return r;
        }
        protected override bool OpenRecord(Guid key)
        {
            bool r = false;
            using (SqlDataReader dr = AppDAL.MainInvestigationSelect(key))
                r = dr != null && dr.Read() && this.Populate(dr);
            return r;
        }
        protected override bool InsertRecord()
        {
            Guid createdBy = AppContext.UserGuid;
            DateTime CreatedOn;

            bool r = AppDAL.MainInvestigationInsert(this.mObjectGuid, this.mName, this.mDescription, createdBy, out CreatedOn);
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

            bool r = AppDAL.MainInvestigationUpdate(this.mObjectGuid, this.mName, this.mDescription, modifiedBy, out modifiedOn);
            if (r)
            {
                this.mModifiedByUser = modifiedBy;
                this.mModifiedOn = modifiedOn;
            }
            return r;
        }
        protected override bool DeleteRecord()
        {
            return AppDAL.MainInvestigationDelete(this.mObjectGuid);
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
        public sealed class MainInvestigationCollection : ObjectCollection<MainInvestigation>
        {
            #region MainInvestigationCollection
            public MainInvestigationCollection()
            {
                using (SqlDataReader dr = AppDAL.MainInvestigationSelectAll())
                {
                    LoadObjectsFromReader(dr);
                }
            }
            #endregion

            #region MainInvestigationCollection
            public MainInvestigationCollection(string searchText)
            {
                using (SqlDataReader dr = AppDAL.MainInvestigationSearch(searchText))
                {
                    LoadObjectsFromReader(dr);
                }
            }
            #endregion

            #region MainInvestigationCollection
            public MainInvestigationCollection(Guid MainInvestigationGuid)
            {
                using (SqlDataReader dr = AppDAL.MainInvestigationSelect(MainInvestigationGuid))
                {
                    LoadObjectsFromReader(dr);
                }
            }
            #endregion
        }
    
}
