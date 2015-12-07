using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Security.Principal;

namespace SarvottamHospital.Object
{
    public sealed class OPDHistoryProcedureAssociateComplain : Objectbase
    {
        internal struct Columns
        {
            public const string OPDHistoryProcedurePatientGuid      = "OPDHistoryProcedurePatientGuid";
            public const string OPDHistoryProcedureAssociateComplain = "OPDHistoryProcedureAssociateComplain";
            public const string OPDHistoryProcedureGuid              = "OPDHistoryProcedureGuid";
            public const string OPDHistoryProcedureModifiedOn       = "OPDHistoryProcedureModifiedOn";
        }
         #region Constructor

        public OPDHistoryProcedureAssociateComplain() : base() { }

        public OPDHistoryProcedureAssociateComplain(Guid key) : base(key) { }

        public OPDHistoryProcedureAssociateComplain(SqlDataReader dr) : base(dr) { }
        
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

        private Guid mAssociateComplainGuid;

        public Guid AssociateComplainGuid
        {
            get { return mAssociateComplainGuid; }
            set { mAssociateComplainGuid = value; }
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
                this.mAssociateComplainGuid = AppShared.DbValueToGuid(dr[Columns.OPDHistoryProcedureAssociateComplain]);
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
            bool r = AppDAL.OPDHistoryProcedureAssociateComplainInsert(this.mHistoryProcedureGuid, this.mPatientGuid, this.mAssociateComplainGuid);
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
            bool r = AppDAL.OPDHistoryProcedureAssociateComplainInsert(this.mHistoryProcedureGuid, this.PatientGuid, this.AssociateComplainGuid);
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
            this.mAssociateComplainGuid = Guid.Empty;
        }
        #endregion
    }
    public sealed class OPDAssociateComplains : ObjectCollection<OPDHistoryProcedureAssociateComplain>
    {
        public OPDAssociateComplains(Guid historyProcedureGuid)
        {
            using (SqlDataReader dr = AppDAL.OPDHistoryProcedureAssociateComplainSelectAll(historyProcedureGuid))
            {
                LoadObjectsFromReader(dr);
            }
        }
    }
}
