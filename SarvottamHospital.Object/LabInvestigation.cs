using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace SarvottamHospital.Object
{
    public sealed class LabInvestigation : Objectbase
    {
        internal struct Columns
        {
            public const string LabInvestigationId = "LabInvestigationId";
            public const string LabInvestigationGuid = "LabInvestigationGuid";
            public const string LabInvestigationName = "LabInvestigationName";
            public const string LabInvestigationDescription = "LabInvestigationDescription";
            public const string LabInvestigationCreatedBy = "LabInvestigationCreatedBy";
            public const string LabInvestigationCreatedOn = "LabInvestigationCreatedOn";
            public const string LabInvestigationModifiedBy = "LabInvestigationModifiedBy";
            public const string LabInvestigationModifiedOn = "LabInvestigationModifiedOn";
        }

        #region Constructor
        public LabInvestigation() : base() { }

        public LabInvestigation(Guid key) : base(key) { }

        public LabInvestigation(OPDInvestigationProcedure obj)
        {
            this.Referer = obj;
        }

        public LabInvestigation(SqlDataReader dr) : base(dr) { }

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

        private Guid mLabInvestigationGuid;

        public Guid LabInvestigationGuid
        {
            get { return mLabInvestigationGuid; }
            set { mLabInvestigationGuid = value; }
        }

        private Guid mLabInvestigationCreatedBy;

        public Guid LabInvestigationCreatedBy
        {
            get { return mLabInvestigationCreatedBy; }
            set { mLabInvestigationCreatedBy = value; }
        }
        private Guid mLabInvestigationModifiedBy;

        public Guid LabInvestigationModifiedBy
        {
            get { return mLabInvestigationModifiedBy; }
            set { mLabInvestigationModifiedBy = value; }
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

            if (dr != null && AppShared.IsNotNull(dr[Columns.LabInvestigationGuid]))
            {
                this.mId = AppShared.DbValueToInteger(dr[Columns.LabInvestigationId]);
                this.mObjectGuid = AppShared.DbValueToGuid(dr[Columns.LabInvestigationGuid]);
                this.mName = AppShared.DbValueToString(dr[Columns.LabInvestigationName]);
                this.mDescription = AppShared.DbValueToString(dr[Columns.LabInvestigationDescription]);
                this.mCreatedByUser = AppShared.DbValueToGuid(dr[Columns.LabInvestigationCreatedBy]);
                this.mCreatedOn = AppShared.DbValueToDateTime(dr[Columns.LabInvestigationCreatedOn]);
                this.mModifiedByUser = AppShared.DbValueToGuid(dr[Columns.LabInvestigationModifiedBy]);
                this.mModifiedOn = AppShared.DbValueToDateTime(dr[Columns.LabInvestigationModifiedOn]);
                this.Status = ObjectStatus.Opened;
                r = true;

            }
            return r;
        }
        protected override bool OpenRecord(Guid key)
        {
            bool r = false;
            using (SqlDataReader dr = AppDAL.LabInvestigationSelect(key))
                r = dr != null && dr.Read() && this.Populate(dr);
            return r;
        }
        protected override bool InsertRecord()
        {
            Guid createdBy = AppContext.UserGuid;
            DateTime CreatedOn;

            bool r = AppDAL.LabInvestigationInsert(this.mObjectGuid, this.mName, this.mDescription, createdBy, out CreatedOn);
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

            bool r = AppDAL.LabInvestigationUpdate(this.mObjectGuid, this.mName, this.mDescription, modifiedBy, out modifiedOn);
            if (r)
            {
                this.mModifiedByUser = modifiedBy;
                this.mModifiedOn = modifiedOn;
            }
            return r;
        }
        protected override bool DeleteRecord()
        {
            return AppDAL.LabInvestigationDelete(this.mObjectGuid);
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
        public sealed class LabInvestigationCollection : ObjectCollection<LabInvestigation>
        {
            #region LabInvestigationCollection
            public LabInvestigationCollection()
            {
                using (SqlDataReader dr = AppDAL.LabInvestigationSelectAll())
                {
                    LoadObjectsFromReader(dr);
                }
            }
            #endregion

            #region LabInvestigationCollection
            public LabInvestigationCollection(string searchText)
            {
                using (SqlDataReader dr = AppDAL.LabInvestigationSearch(searchText))
                {
                    LoadObjectsFromReader(dr);
                }
            }
            #endregion

            #region LabInvestigationCollection
            public LabInvestigationCollection(Guid LabInvestigationGuid)
            {
                using (SqlDataReader dr = AppDAL.LabInvestigationSelect(LabInvestigationGuid))
                {
                    LoadObjectsFromReader(dr);
                }
            }
            #endregion
        }
    
}
