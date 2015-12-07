using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
namespace SarvottamHospital.Object
{
    public sealed class InvestigationProcedure : Objectbase
    {
        internal struct Columns
        {
            public const string InvestigationProcedureId = "InvestigationProcedureId";
            public const string InvestigationProcedureGuid = "InvestigationProcedureGuid";
            public const string MainInvestigationGUID="MainInvestigationGUID";
            public const string LabInvestigationGUID = "LabInvestigationGUID";
            public const string InvestigationProcedureRadiologyInvestigation = "InvestigationProcedureRadiologyInvestigation";
            public const string InvestigationProcedureSpecialInvestigation = "InvestigationProcedureSpecialInvestigation";
            public const string InvestigationProcedureDate = "InvestigationProcedureDate";
            public const string InvestigationProcedureCreatedBy = "InvestigationProcedureCreatedBy";
            public const string InvestigationProcedureCreatedOn = "InvestigationProcedureCreatedOn";
            public const string InvestigationProcedureModifiedBy = "InvestigationProcedureModifiedBy";
            public const string InvestigationProcedureModifiedOn = "InvestigationProcedureModifiedOn";
        }

        #region Constructor
        public InvestigationProcedure() : base() { }

        public InvestigationProcedure(Guid key) : base(key) { }

        public InvestigationProcedure(SqlDataReader dr) : base(dr) { }

        #endregion

        #region Properties
        public override string DisplayName
        {
            get { return string.Empty; }
        }

        private string mRadiologyInvestigation;

        public string RadiologyInvestigation
        {
            get { return mRadiologyInvestigation; }
            set { mRadiologyInvestigation = value; }
        }
        private string mSpecialInvestigation;

        public string SpecialInvestigation
        {
            get { return mSpecialInvestigation; }
            set { mSpecialInvestigation = value; }
        }

        private DateTime mInvestigationProcedureDate;
        public DateTime InvestigationProcedureDate
        {
            get { return this.mInvestigationProcedureDate; }
            set { this.mInvestigationProcedureDate = value; }
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

        private Guid mInvestigationProcedureGuid;

        public Guid InvestigationProcedureGuid
        {
            get { return mInvestigationProcedureGuid; }
            set { mInvestigationProcedureGuid = value; }
        }

        private Guid mInvestigationProcedureCreatedBy;

        public Guid InvestigationProcedureCreatedBy
        {
            get { return mInvestigationProcedureCreatedBy; }
            set { mInvestigationProcedureCreatedBy = value; }
        }
        private Guid mInvestigationProcedureModifiedBy;

        public Guid InvestigationProcedureModifiedBy
        {
            get { return mInvestigationProcedureModifiedBy; }
            set { mInvestigationProcedureModifiedBy = value; }
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

            if (dr != null && AppShared.IsNotNull(dr[Columns.InvestigationProcedureGuid]))
            {
                this.mId = AppShared.DbValueToInteger(dr[Columns.InvestigationProcedureId]);
                this.mObjectGuid = AppShared.DbValueToGuid(dr[Columns.InvestigationProcedureGuid]);
                this.mMainInvestigationGUID = AppShared.DbValueToGuid(dr[Columns.MainInvestigationGUID]);
                this.mLabInvestigationGUID= AppShared.DbValueToGuid(dr[Columns.LabInvestigationGUID]);
                this.mRadiologyInvestigation = AppShared.DbValueToString(dr[Columns.InvestigationProcedureRadiologyInvestigation]);
                this.mSpecialInvestigation = AppShared.DbValueToString(dr[Columns.InvestigationProcedureSpecialInvestigation]);
                this.mCreatedByUser = AppShared.DbValueToGuid(dr[Columns.InvestigationProcedureCreatedBy]);
                this.mCreatedOn = AppShared.DbValueToDateTime(dr[Columns.InvestigationProcedureCreatedOn]);
                this.mModifiedByUser = AppShared.DbValueToGuid(dr[Columns.InvestigationProcedureModifiedBy]);
                this.mModifiedOn = AppShared.DbValueToDateTime(dr[Columns.InvestigationProcedureModifiedOn]);
                this.Status = ObjectStatus.Opened;
                r = true;

            }
            return r;
        }
        protected override bool OpenRecord(Guid key)
        {
            bool r = false;
            using (SqlDataReader dr = AppDAL.InvestigationProcedureSelect(key))
                r = dr != null && dr.Read() && this.Populate(dr);
            return r;
        }
        protected override bool InsertRecord()
        {
            Guid createdBy = AppContext.UserGuid;
            DateTime CreatedOn;

            bool r = AppDAL.InvestigationProcedureInsert(this.mObjectGuid, this.mMainInvestigationGUID, this.mLabInvestigationGUID,this.mRadiologyInvestigation,this.mSpecialInvestigation,this.mInvestigationProcedureDate, createdBy, out CreatedOn);
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

            bool r = AppDAL.InvestigationProcedureUpdate(this.mObjectGuid, this.mMainInvestigationGUID, this.mLabInvestigationGUID, this.mRadiologyInvestigation, this.mSpecialInvestigation, this.mInvestigationProcedureDate, modifiedBy, out modifiedOn);
            if (r)
            {
                this.mModifiedByUser = modifiedBy;
                this.mModifiedOn = modifiedOn;
            }
            return r;
        }
        protected override bool DeleteRecord()
        {
            return AppDAL.InvestigationProcedureDelete(this.mObjectGuid);
        }
        protected override void Reset()
        {
            base.Reset();
            this.mObjectGuid = Guid.Empty;
            this.mRadiologyInvestigation = string.Empty;
            this.mSpecialInvestigation = string.Empty;
        }
        #endregion

        public sealed class InvestigationProcedureCollection : ObjectCollection<InvestigationProcedure>
        {
            #region InvestigationProcedureCollection
            public InvestigationProcedureCollection()
            {
                using (SqlDataReader dr = AppDAL.InvestigationProcedureSelectAll())
                {
                    LoadObjectsFromReader(dr);
                }
            }
            #endregion

            #region InvestigationProcedureCollection
            public InvestigationProcedureCollection(string searchText)
            {
                using (SqlDataReader dr = AppDAL.InvestigationProcedureSearch(searchText))
                {
                    LoadObjectsFromReader(dr);
                }
            }
            #endregion

            #region InvestigationProcedureCollection
            public InvestigationProcedureCollection(Guid InvestigationProcedureGuid)
            {
                using (SqlDataReader dr = AppDAL.InvestigationProcedureSelect(InvestigationProcedureGuid))
                {
                    LoadObjectsFromReader(dr);
                }
            }
            #endregion
        }
    }
}
