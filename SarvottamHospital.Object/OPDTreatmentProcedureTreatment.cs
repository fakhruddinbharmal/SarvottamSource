using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Security.Principal;

namespace SarvottamHospital.Object
{
    public sealed class OPDTreatmentProcedureTreatment  : Objectbase
    {
        internal struct Columns
        {
            public const string  OPDTreatmentProcedurePatientGuid    = "OPDTreatmentProcedurePatientGuid"; 
            public const string  OPDTreatmentProcedureTreatment      = "OPDTreatmentProcedureTreatment";  
            public const string  OPDTreatmentProcedureGuid           = "OPDTreatmentProcedureGuid";
            public const string  OPDTreatmentProcedureModifiedOn     = "OPDTreatmentProcedureModifiedOn";
        }

        #region Constructor

        public OPDTreatmentProcedureTreatment() : base() { }

        public OPDTreatmentProcedureTreatment(Guid key) : base(key) { }

        public OPDTreatmentProcedureTreatment(SqlDataReader dr) : base(dr) { }

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

        private Guid mTreatmentGuid;

        public Guid TreatmentGuid
        {
            get { return mTreatmentGuid; }
            set { mTreatmentGuid = value; }
        }

        private Guid mProcedureGuid;

        public Guid TreatmentProcedureGuid
        {
            get { return mProcedureGuid; }
            set { mProcedureGuid = value; }
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

            if (dr != null && AppShared.IsNotNull(dr[Columns.OPDTreatmentProcedurePatientGuid]))
            {
                this.mProcedureGuid = AppShared.DbValueToGuid(dr[Columns.OPDTreatmentProcedureGuid]);
                this.mPatientGuid = AppShared.DbValueToGuid(dr[Columns.OPDTreatmentProcedurePatientGuid]);
                this.mTreatmentGuid = AppShared.DbValueToGuid(dr[Columns.OPDTreatmentProcedureTreatment]);
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
            bool r = AppDAL.OPDTreatmentProcedureTreatmentInsert(this.mProcedureGuid, this.mPatientGuid, this.mTreatmentGuid);
            return r;
        }

        protected override bool UpdateRecord()
        {
            bool r = AppDAL.OPDTreatmentProcedureTreatmentInsert(this.mProcedureGuid, this.mPatientGuid, this.mTreatmentGuid);
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
            this.mTreatmentGuid = Guid.Empty;
        }
        #endregion
    }
    public sealed class OPDTreatments : ObjectCollection<OPDTreatmentProcedureTreatment>
    {
        public OPDTreatments(Guid TreatmentProcedureGuid)
        { 
            using(SqlDataReader dr = AppDAL.OPDTreatmentProcedureTreatmentSelectAll(TreatmentProcedureGuid))
            {
                LoadObjectsFromReader(dr);
            }
        }
    }
}
