using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Security.Principal;

namespace SarvottamHospital.Object
{
    public sealed class OPDHistoryProcedureChiefComplain : Objectbase
    {
        internal struct Columns
        {
            public const string OPDHistoryProcedurePatientGuid      = "OPDHistoryProcedurePatientGuid";
            public const string OPDHistoryProcedureChiefComplain    = "OPDHistoryProcedureChiefComplain";
            public const string OPDHistoryProcedureGuid             = "OPDHistoryProcedureGuid";
            public const string OPDHistoryProcedureModifiedOn       = "OPDHistoryProcedureModifiedOn";
        }
        #region Constructor

        public OPDHistoryProcedureChiefComplain() : base() { }

        public OPDHistoryProcedureChiefComplain(Guid key) : base(key) { }

        public OPDHistoryProcedureChiefComplain(SqlDataReader dr) : base(dr) { }
        
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

        private Guid mHistoryProcedureGuid;

        public Guid HistoryProcedureGuid
        {
            get { return mHistoryProcedureGuid; }
            set { mHistoryProcedureGuid = value; }
        }

        private Guid mChiefComplainGuid;

        public Guid ChiefComplainGuid
        {
            get { return mChiefComplainGuid; }
            set { mChiefComplainGuid = value; }
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

            if (dr != null && AppShared.IsNotNull(dr[Columns.OPDHistoryProcedurePatientGuid]))
            {
                this.mHistoryProcedureGuid = AppShared.DbValueToGuid(dr[Columns.OPDHistoryProcedureGuid]);
                this.mPatientGuid = AppShared.DbValueToGuid(dr[Columns.OPDHistoryProcedurePatientGuid]);
                this.mChiefComplainGuid = AppShared.DbValueToGuid(dr[Columns.OPDHistoryProcedureChiefComplain]);
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
            bool r = AppDAL.OPDHistoryProcedureChiefComplainInsert(this.mHistoryProcedureGuid, this.mPatientGuid, this.mChiefComplainGuid);           
            return r;
         }

         protected override bool UpdateRecord()
         {
             bool r = AppDAL.OPDHistoryProcedureChiefComplainInsert(this.mHistoryProcedureGuid, this.PatientGuid, this.ChiefComplainGuid);
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
             this.mChiefComplainGuid = Guid.Empty;
         }
        #endregion
    }

    public sealed class OPDChiefComplains : ObjectCollection<OPDHistoryProcedureChiefComplain>
    {
        public OPDChiefComplains(Guid historyProcedureGuid)
        {
            using (SqlDataReader dr = AppDAL.OPDHistoryProcedureChiefComplainSelectAll(historyProcedureGuid))
            {
                LoadObjectsFromReader(dr);
            }
        }
    }
}
