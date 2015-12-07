using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Security.Principal;

namespace SarvottamHospital.Object 
{
    public sealed class IPDPatientTreatment : Objectbase
    {
        internal struct Columns
        {
            public const string IPDPatientTreatmentId = "IPDPatientTreatmentId";
            public const string IPDPatientTreatmentGuid = "IPDPatientTreatmentGuid";
            public const string IPDPatientTreatmentPatientGuid = "IPDPatientTreatmentPatientGuid";
            public const string IPDPatientTreatmentTreatmentGuid = "IPDPatientTreatmentTreatmentGuid";
            public const string IPDPatientTreatmentCreatedBy = "IPDPatientTreatmentCreatedBy";
            public const string IPDPatientTreatmentCreatedOn = "IPDPatientTreatmentCreatedOn";
            public const string IPDPatientTreatmentModifiedBy = "IPDPatientTreatmentModifiedBy";
            public const string IPDPatientTreatmentModifiedOn = "IPDPatientTreatmentModifiedOn";
        }

        #region constructor

        public IPDPatientTreatment() : base() { }

        public IPDPatientTreatment(Guid key) : base(key) { }

        public IPDPatientTreatment(SqlDataReader dr) : base(dr) { }

        #endregion

        #region properties

        public override string DisplayName
        {
            get { return string.Empty; }
        }

        private Guid mPatientGuid;
        public Guid PatientGuid
        {
            get { return this.mPatientGuid; }
            set { this.mPatientGuid = value; }
        }

        private Guid mTreatmentGuid;
        public Guid TreatmentGuid
        {
            get { return this.mTreatmentGuid; }
            set { this.mTreatmentGuid = value; }
        }
        #endregion

        #region Overiden

        internal override bool CreateRecord()
        {
            return base.CreateRecord();
        }

        internal override bool Populate(SqlDataReader dr)
        {
            bool r = false;

            if (dr != null && AppShared.IsNotNull(dr[Columns.IPDPatientTreatmentPatientGuid]))
            {
                //this.mId = AppShared.DbValueToInteger(dr[Columns.IPDPatientTreatmentId]);
                //this.mObjectGuid = AppShared.DbValueToGuid(dr[Columns.IPDPatientTreatmentGuid]);
                this.mPatientGuid = AppShared.DbValueToGuid(dr[Columns.IPDPatientTreatmentPatientGuid]);
                this.mTreatmentGuid = AppShared.DbValueToGuid(dr[Columns.IPDPatientTreatmentTreatmentGuid]);
                this.mCreatedByUser = AppShared.DbValueToGuid(dr[Columns.IPDPatientTreatmentCreatedBy]);
                this.mCreatedOn = AppShared.DbValueToDateTime(dr[Columns.IPDPatientTreatmentCreatedOn]);
                this.mModifiedByUser = AppShared.DbValueToGuid(dr[Columns.IPDPatientTreatmentModifiedBy]);
                this.mModifiedOn = AppShared.DbValueToDateTime(dr[Columns.IPDPatientTreatmentModifiedOn]);
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
            Guid createdBy = AppContext.UserGuid;
            DateTime createdOn;
            bool r = AppDAL.IPDPatientTreatmentInsert(this.mObjectGuid, this.mPatientGuid, this.mTreatmentGuid, createdBy, out createdOn);
            if (r)
            {
                this.mCreatedByUser = createdBy;
                this.mCreatedOn = createdOn;
                this.mModifiedByUser = createdBy;
                this.mModifiedOn = createdOn;
            }
            return r;
        }

        protected override bool UpdateRecord()
        {
            Guid modifiedBy = AppContext.UserGuid;
            DateTime modifiedOn;
            bool r = AppDAL.IPDPatientTreatmentInsert(this.mObjectGuid, this.mPatientGuid, this.mTreatmentGuid, modifiedBy, out modifiedOn);
            if (r)
            {
                this.mModifiedByUser = modifiedBy;
                this.mModifiedOn = modifiedOn;
            }
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

    public sealed class IPDPatientTreatments : ObjectCollection<IPDPatientTreatment>
    {
        public IPDPatientTreatments(Guid patientGuid)
        {
            using (SqlDataReader dr = AppDAL.IPDPatientTreatmentSelectAll(patientGuid))
            {
                LoadObjectsFromReader(dr);
            }
        }

        //public IPDPatientTreatments(Patient obj)
        //{
        //    using (SqlDataReader dr = AppDAL.IPDPatientTreatmentSelectAll(obj.ObjectGuid))
        //    {
        //        LoadObjectsFromReader(dr);
        //    }
        //}
    }
}
