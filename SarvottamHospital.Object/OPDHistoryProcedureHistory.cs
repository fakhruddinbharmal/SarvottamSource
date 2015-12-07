using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Security.Principal;

namespace SarvottamHospital.Object
{
    public sealed class OPDHistoryProcedureHistory : Objectbase
    {
        internal struct Columns
        {
            public const string OPDHistoryProcedurePatientGuid = "OPDHistoryProcedurePatientGuid";
            public const string OPDHistoryProcedureHistory = "OPDHistoryProcedureHistory";
            public const string OPDHistoryProcedureGuid = "OPDHistoryProcedureGuid";
            public const string OPDHistoryProcedureModifiedOn = "OPDHistoryProcedureModifiedOn";
        }

        #region Constructor

        public OPDHistoryProcedureHistory() : base() { }

        public OPDHistoryProcedureHistory(Guid key) : base(key) { }

        public OPDHistoryProcedureHistory(SqlDataReader dr) : base(dr) { }
        
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

        private Guid mHistoryGuid;

        public Guid HistoryGuid
        {
            get { return mHistoryGuid; }
            set { mHistoryGuid = value; }
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
                this.mHistoryGuid = AppShared.DbValueToGuid(dr[Columns.OPDHistoryProcedureHistory]);
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
            bool r = AppDAL.OPDHistoryProcedureHistoryInsert(this.mHistoryProcedureGuid, this.mPatientGuid, this.mHistoryGuid);
            //if (r)
            //{
            //    this.mCreatedByUser = createdBy;
            //    this.mCreatedOn = createdOn;
            //    this.mModifiedByUser = createdBy;
            //    this.mModifiedOn = createdOn;
            //}
            return r;
        }

        protected override bool UpdateRecord()
        {
            bool r = AppDAL.OPDHistoryProcedureHistoryInsert(this.mHistoryProcedureGuid, this.PatientGuid, this.HistoryGuid);
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
            this.mHistoryGuid = Guid.Empty;
        }
        #endregion
    }
    public sealed class OPDHistorys : ObjectCollection<OPDHistoryProcedureHistory>
    {
        public OPDHistorys(Guid historyProcedureGuid)
        {
            using (SqlDataReader dr = AppDAL.OPDHistoryProcedureHistorySelectAll(historyProcedureGuid))
            {
                LoadObjectsFromReader(dr);
            }
        }
    }
}
