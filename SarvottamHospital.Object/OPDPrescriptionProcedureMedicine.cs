using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Security.Principal;

namespace SarvottamHospital.Object
{
    public sealed class OPDPrescriptionProcedureMedicine :  Objectbase
    {
        internal struct Columns
        {
            public const string  OPDPrescriptionProcedurePatientGuid    = "OPDPrescriptionProcedurePatientGuid";
            public const string  OPDPrescriptionProcedureMedicineGuid   ="OPDPrescriptionProcedureMedicineGuid";
            public const string  OPDPrescriptionProcedureGuid           ="OPDPrescriptionProcedureGuid";
            public const string OPDPrescriptionProcedureModifiedOn      = "OPDPrescriptionProcedureModifiedOn";
        }

        #region Constructor

        public OPDPrescriptionProcedureMedicine() : base() { }

        public OPDPrescriptionProcedureMedicine(Guid key) : base(key) { }

        public OPDPrescriptionProcedureMedicine(SqlDataReader dr) : base(dr) { }
        
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

        private Guid mPrescriptionProcedureGuid;

        public Guid PrescriptionProcedureGuid
        {
            get { return mPrescriptionProcedureGuid; }
            set { mPrescriptionProcedureGuid = value; }
        }

        private Guid mMedicineGuid;

        public Guid MedicineGuid
        {
            get { return mMedicineGuid; }
            set { mMedicineGuid = value; }
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
            if (dr != null && AppShared.IsNotNull(dr[Columns.OPDPrescriptionProcedurePatientGuid]))
            {
                this.mPrescriptionProcedureGuid = AppShared.DbValueToGuid(dr[Columns.OPDPrescriptionProcedureGuid]);
                this.mPatientGuid = AppShared.DbValueToGuid(dr[Columns.OPDPrescriptionProcedurePatientGuid]);
                this.mMedicineGuid = AppShared.DbValueToGuid(dr[Columns.OPDPrescriptionProcedureMedicineGuid]);
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
            bool r = AppDAL.OPDPrescriptionProcedureMedicineInsert(this.mPrescriptionProcedureGuid, this.mPatientGuid, this.mMedicineGuid);
            return r;
        }

        protected override bool UpdateRecord()
        {
            bool r = AppDAL.OPDPrescriptionProcedureMedicineInsert(this.mPrescriptionProcedureGuid, this.mPatientGuid, this.mMedicineGuid);
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
            this.mMedicineGuid = Guid.Empty;
        }

        #endregion
    }
    public sealed class OPDMedicines : ObjectCollection<OPDPrescriptionProcedureMedicine>
    {
        #region OPDMedicines

        public OPDMedicines(Guid PrescriptionProcedureGuid)
        {
            using (SqlDataReader dr = AppDAL.OPDPrescriptionProcedureMedicineSelectAll(PrescriptionProcedureGuid))
            {
                LoadObjectsFromReader(dr);
            }
        }
        #endregion 
    }

}
