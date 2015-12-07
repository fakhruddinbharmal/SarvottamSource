using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace SarvottamHospital.Object
{
    public sealed class OPDInvestigationProcedureMainInvestigation : Objectbase
    {
        internal struct Columns
        {
            public const string OPDInvestigationProcedurePatientGuid                = "OPDInvestigationProcedurePatientGuid";
            public const string OPDInvestigationProcedureMainInvestigationGuid      = "OPDInvestigationProcedureMainInvestigationGuid";
            public const string OPDInvestigationProcedureGuid                       = "OPDInvestigationProcedureGuid";
            public const string OPDInvestigationProcedureModifiedOn                 = "OPDInvestigationProcedureModifiedOn";
        }

        #region Constructor

        public OPDInvestigationProcedureMainInvestigation() : base() { }

        public OPDInvestigationProcedureMainInvestigation(Guid key) : base(key) { }

        public OPDInvestigationProcedureMainInvestigation(SqlDataReader dr) : base(dr) { }
        
        #endregion

        #region Properties

        public override string DisplayName
        {
            get { return string.Empty; }
        }

        private Guid mPatientGuid;

        public Guid PatientGuid
        {
            get { return mPatientGuid; }
            set { mPatientGuid = value; }
        }

        private Guid mProcedureGuid;

        public Guid ProcedureGuid
        {
            get { return mProcedureGuid; }
            set { mProcedureGuid = value; }
        }

        private Guid mMainInvestigationGuid;

        public Guid MainInvestigationGuid
        {
            get { return mMainInvestigationGuid; }
            set { mMainInvestigationGuid = value; }
        }
        #endregion

        #region Overridden

        internal override bool CreateRecord()
        {
            return base.CreateRecord();
        }

        internal override bool Populate(SqlDataReader dr)
        {
            bool r = false;

            if (dr != null && AppShared.IsNotNull(dr[Columns.OPDInvestigationProcedurePatientGuid]))
            {
                this.mProcedureGuid = AppShared.DbValueToGuid(dr[Columns.OPDInvestigationProcedureGuid]);
                this.mPatientGuid = AppShared.DbValueToGuid(dr[Columns.OPDInvestigationProcedurePatientGuid]);
                this.mMainInvestigationGuid = AppShared.DbValueToGuid(dr[Columns.OPDInvestigationProcedureMainInvestigationGuid]);
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
             using (SqlDataReader dr = AppDAL.PatientSelect(key))
                 r = dr != null && dr.Read() && this.Populate(dr);
             return r;
           }

        protected override bool InsertRecord()
        {
            bool r = AppDAL.OPDInvestigationProcedureMainInvestigationInsert(this.mProcedureGuid, this.mPatientGuid, this.mMainInvestigationGuid);
            return r;
        }

        protected override bool UpdateRecord()
        {
            bool r = AppDAL.OPDInvestigationProcedureMainInvestigationInsert(this.mProcedureGuid, this.mPatientGuid, this.mMainInvestigationGuid);
            return r;
        }

        protected override bool DeleteRecord()
        {
            return AppDAL.PatientDelete(this.mObjectGuid);
        }

        protected override void Reset()
        {
            base.Reset();
            this.mPatientGuid = Guid.Empty;
            this.mMainInvestigationGuid = Guid.Empty;
        }      

        #endregion
    }

    public sealed class OPDMainInvestigations : ObjectCollection<OPDInvestigationProcedureMainInvestigation>
    {
        #region OPDMainInvestigations

        public OPDMainInvestigations(Guid InvestigationProcedureGuid)
        {
            using (SqlDataReader dr = AppDAL.OPDInvestigationProcedureMainInvestigationSelectAll(InvestigationProcedureGuid))
            {
                LoadObjectsFromReader(dr);
            }
        }
        #endregion        
    }
}
