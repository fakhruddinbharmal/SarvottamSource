using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace SarvottamHospital.Object
{
    public sealed class OPDInvestigationProcedureLabInvestigation : Objectbase
    {
        internal struct Columns
        {
            public const string OPDInvestigationProcedurePatientGuid = "OPDInvestigationProcedurePatientGuid";
            public const string OPDInvestigationProcedureLabInvestigationGuid = "OPDInvestigationProcedureLabInvestigationGuid";
            public const string OPDInvestigationProcedureGuid = "OPDInvestigationProcedureGuid";
            public const string OPDInvestigationProcedureModifiedOn = "OPDInvestigationProcedureModifiedOn";
        }
        #region Constructor

        public OPDInvestigationProcedureLabInvestigation() : base() { }

        public OPDInvestigationProcedureLabInvestigation(Guid key) : base(key) { }

        public OPDInvestigationProcedureLabInvestigation(SqlDataReader dr) : base(dr) { }
        
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

        private Guid mLabInvestigationGuid;

        public Guid LabInvestigationGuid
        {
            get { return mLabInvestigationGuid; }
            set { mLabInvestigationGuid = value; }
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
                this.mLabInvestigationGuid = AppShared.DbValueToGuid(dr[Columns.OPDInvestigationProcedureLabInvestigationGuid]);
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
            bool r = AppDAL.OPDInvestigationProcedureLabInvestigationInsert(this.mProcedureGuid, this.mPatientGuid, this.mLabInvestigationGuid);
            return r;
        }

        protected override bool UpdateRecord()
        {
            bool r = AppDAL.OPDInvestigationProcedureLabInvestigationInsert(this.mProcedureGuid, this.mPatientGuid, this.mLabInvestigationGuid);
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
            this.mLabInvestigationGuid = Guid.Empty;
        }

        #endregion
    }
    public sealed class OPDLabInvestigations : ObjectCollection<OPDInvestigationProcedureLabInvestigation>
    {
        #region OPDLabInvestigations

        public OPDLabInvestigations(Guid InvestigationProcedureGuid)
        {
            using (SqlDataReader dr = AppDAL.OPDInvestigationProcedureLabInvestigationSelectAll(InvestigationProcedureGuid))
            {
                LoadObjectsFromReader(dr);
            }
        }
        #endregion
    }
}
