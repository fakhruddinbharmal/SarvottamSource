using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace SarvottamHospital.Object
{
    public sealed class OPDInvestigation : Objectbase
    {
        internal struct Columns
        {
            public const string OPDInvestigationId = "InvestigationProcedureId";
            public const string OPDInvestigationGuid = "InvestigationProcedureGUID";
            public const string MainInvestigationGUID = "MainInvestigationGUID";
            public const string LabInvestigationGUID = "LabInvestigationGUID";
            public const string OPDRadiologyInvestigation = "InvestigationProcedureRadiologyInvestigation";
            public const string OPDSpecialInvestigation = "InvestigationProcedureSpecialInvestigation";
            public const string OPDInvestigationDate = "InvestigationProcedureDate";
            public const string OPDInvestigationCreatedBy = "InvestigationProcedureCreatedBy";
            public const string OPDInvestigationCreatedOn = "InvestigationProcedureCreatedOn";
            public const string OPDInvestigationModifiedBy = "InvestigationProcedureModifiedBy";
            public const string OPDInvestigationModifiedOn = "InvestigationProcedureModifiedOn";
        }

        #region Constructor
        public OPDInvestigation() : base() { }

        public OPDInvestigation(Guid key) : base(key) { }

        public OPDInvestigation(SqlDataReader dr) : base(dr) { }

        #endregion

        #region Properties
        public override string DisplayName
        {
            get { return string.Empty; }
        }
        
        private Guid mOPDInvestigationGuid;

        public Guid OPDInvestigationGuid
        {
            get { return mOPDInvestigationGuid; }
            set { mOPDInvestigationGuid = value; }
        }

        private Guid mMainInvestigationGUID;

        public Guid MainInvestigationGUID
        {
            get { return mMainInvestigationGUID; }
            set { mMainInvestigationGUID = value; }
        }

        private Guid mLabInvestigationGUID;

        public Guid LabInvestigationGUID
        {
            get { return mLabInvestigationGUID; }
            set { mLabInvestigationGUID = value; }
        }

        private string mOPDRadiologyInvestigation;

        public string OPDRadiologyInvestigation
        {
            get { return mOPDRadiologyInvestigation; }
            set { mOPDRadiologyInvestigation = value; }
        }

        private string mOPDSpecialInvestigation;

        public string OPDSpecialInvestigation
        {
            get { return mOPDSpecialInvestigation; }
            set { mOPDSpecialInvestigation = value; }
        }

        private DateTime mOPDInvestigationDate;

        public DateTime OPDInvestigationDate
        {
            get { return mOPDInvestigationDate; }
            set { mOPDInvestigationDate = value; }
        }

        private Guid mOPDInvestigationCreatedBy;

        public Guid OPDInvestigationCreatedBy
        {
            get { return mOPDInvestigationCreatedBy; }
            set { mOPDInvestigationCreatedBy = value; }
        }
        private Guid mOPDInvestigationModifiedBy;

        public Guid OPDInvestigationModifiedBy
        {
            get { return mOPDInvestigationModifiedBy; }
            set { mOPDInvestigationModifiedBy = value; }
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

            if (dr != null && AppShared.IsNotNull(dr[Columns.OPDInvestigationGuid]))
            {
                this.mId = AppShared.DbValueToInteger(dr[Columns.OPDInvestigationId]);
                this.mObjectGuid = AppShared.DbValueToGuid(dr[Columns.OPDInvestigationGuid]);
                this.mMainInvestigationGUID = AppShared.DbValueToGuid(dr[Columns.MainInvestigationGUID]);
                this.mLabInvestigationGUID = AppShared.DbValueToGuid(dr[Columns.LabInvestigationGUID]);
                this.mOPDRadiologyInvestigation = AppShared.DbValueToString(dr[Columns.OPDRadiologyInvestigation]);
                this.mOPDSpecialInvestigation = AppShared.DbValueToString(dr[Columns.OPDSpecialInvestigation]);
                this.mOPDInvestigationDate = AppShared.DbValueToDateTime(dr[Columns.OPDInvestigationDate]);
                this.mCreatedByUser = AppShared.DbValueToGuid(dr[Columns.OPDInvestigationCreatedBy]);
                this.mCreatedOn = AppShared.DbValueToDateTime(dr[Columns.OPDInvestigationCreatedOn]);
                this.mModifiedByUser = AppShared.DbValueToGuid(dr[Columns.OPDInvestigationModifiedBy]);
                this.mModifiedOn = AppShared.DbValueToDateTime(dr[Columns.OPDInvestigationModifiedOn]);
                this.Status = ObjectStatus.Opened;
                r = true;

            }
            return r;
        }
        protected override bool OpenRecord(Guid key)
        {
            bool r = false;
            using (SqlDataReader dr = AppDAL.OPDInvestigationSelect(key))
                r = dr != null && dr.Read() && this.Populate(dr);
            return r;
        }
        protected override bool InsertRecord()
        {
            Guid createdBy = AppContext.UserGuid;
            DateTime CreatedOn;

            bool r = AppDAL.OPDInvestigationInsert(this.mObjectGuid, this.mMainInvestigationGUID, this.mLabInvestigationGUID, this.mOPDRadiologyInvestigation, this.mOPDSpecialInvestigation, this.mOPDInvestigationDate, createdBy, out CreatedOn);
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

            bool r = AppDAL.OPDInvestigationUpdate(this.mObjectGuid, this.mMainInvestigationGUID, this.mLabInvestigationGUID, this.mOPDRadiologyInvestigation, this.mOPDSpecialInvestigation, this.mOPDInvestigationDate, modifiedBy, out modifiedOn);
            if (r)
            {
                this.mModifiedByUser = modifiedBy;
                this.mModifiedOn = modifiedOn;
            }
            return r;
        }
        protected override bool DeleteRecord()
        {
            return AppDAL.OPDInvestigationDelete(this.mObjectGuid);
        }
        protected override void Reset()
        {
            base.Reset();
            this.mObjectGuid = Guid.Empty;
            this.mOPDRadiologyInvestigation = string.Empty;
            this.mOPDSpecialInvestigation = string.Empty;
        }
        #endregion

        public sealed class OPDInvestigationCollection : ObjectCollection<OPDInvestigation>
        {
            #region OPDInvestigationCollection
            public OPDInvestigationCollection()
            {
                using (SqlDataReader dr = AppDAL.OPDInvestigationSelectAll())
                {
                    LoadObjectsFromReader(dr);
                }
            }
            #endregion

            #region OPDInvestigationCollection
            public OPDInvestigationCollection(string searchText)
            {
                using (SqlDataReader dr = AppDAL.OPDInvestigationSearch(searchText))
                {
                    LoadObjectsFromReader(dr);
                }
            }
            #endregion

            #region OPDInvestigationCollection
            public OPDInvestigationCollection(Guid OPDInvestigationGuid)
            {
                using (SqlDataReader dr = AppDAL.OPDInvestigationSelect(OPDInvestigationGuid))
                {
                    LoadObjectsFromReader(dr);
                }
            }
            #endregion
        }
    }
}
