using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace SarvottamHospital.Object
{
    public sealed class OPDPrescription : Objectbase
    {
        internal struct Columns
        {
            public const string OPDPrescriptionId = "OPDPrescriptionId";
            public const string OPDPrescriptionProcedureGuid = "OPDPrescriptionProcedureGuid";
            public const string OPDPrescriptionPatientGuid = "OPDPrescriptionPatientGuid";
            public const string MedicineGuid = "MedicineGuid";
            public const string Doseage = "Doseage";
            public const string Timings = "Timings";
            public const string OPDPrescriptionDate = "OPDPrescriptionDate";
            public const string OPDPrescriptionCreatedBy = "OPDPrescriptionCreatedBy";
            public const string OPDPrescriptionCreatedOn = "OPDPrescriptionCreatedOn";
            public const string OPDPrescriptionModifiedBy = "OPDPrescriptionModifiedBy";
            public const string OPDPrescriptionModifiedOn = "OPDPrescriptionModifiedOn";
            public const string Medicine = "Medicine";
        }
        #region Constructor

        public OPDPrescription() : base() { }

        public OPDPrescription(Guid key) : base(key) { }

        public OPDPrescription(SqlDataReader dr) : base(dr) { }

        #endregion

        #region Properties

        public override string DisplayName
        {
            get { return string.Empty; }
        }

        private string mDoseage;

        public string Doseage
        {
            get { return mDoseage; }
            set { mDoseage = value; }
        }

        private string mTimings;

        public string Timings
        {
            get { return mTimings; }
            set { mTimings = value; }
        }
        private DateTime mOPDPrescriptionDate;

        public DateTime OPDPrescriptionDate
        {
            get { return mOPDPrescriptionDate; }
            set { mOPDPrescriptionDate = value; }
        }

        private Guid mPatientGuid;

        public Guid PatientGuid
        {
            get { return mPatientGuid; }
            set { mPatientGuid = value; }
        }

        //Medicine Listing

        private string mMedicine;

        public string Medicine
        {
            get { return mMedicine; }
            set { mMedicine = value; }
        }

        //Medicine

        OPDMedicines mOPDMedicines;

        public OPDMedicines OPDMedicines
        {
            get
            {
                if (this.mOPDMedicines == null)
                    this.mOPDMedicines = new OPDMedicines(this.ObjectGuid);
                return mOPDMedicines;
            }
            set { this.mOPDMedicines = value; }
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
            if (dr != null && AppShared.IsNotNull(dr[Columns.OPDPrescriptionProcedureGuid]))
            {
                this.mObjectGuid = AppShared.DbValueToGuid(dr[Columns.OPDPrescriptionProcedureGuid]);
                this.mPatientGuid = AppShared.DbValueToGuid(dr[Columns.OPDPrescriptionPatientGuid]);
                this.mDoseage = AppShared.DbValueToString(dr[Columns.Doseage]);
                this.mTimings = AppShared.DbValueToString(dr[Columns.Timings]);
                this.OPDPrescriptionDate = AppShared.DbValueToDateTime(dr[Columns.OPDPrescriptionDate]);

                if (AppShared.HasColumn(dr, "Medicine"))
                {
                    this.mMedicine = AppShared.DbValueToString(dr[Columns.Medicine]);
                }

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
            using (SqlDataReader dr = AppDAL.OPDPrescriptionSelect(key))
                r = dr != null && dr.Read() && this.Populate(dr);
            return r;
        }

        protected override bool InsertRecord()
        {
            Guid createdBy = AppContext.UserGuid;
            DateTime CreatedOn;

            bool r = AppDAL.OPDPrescriptionInsert(this.mObjectGuid, this.mPatientGuid, this.Doseage, this.Timings, this.OPDPrescriptionDate, createdBy, out CreatedOn);
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
            bool r = AppDAL.OPDPrescriptionUpdate(this.mObjectGuid, this.mPatientGuid, this.Doseage, this.Timings, this.OPDPrescriptionDate, modifiedBy, out modifiedOn);
            if (r)
            {
                this.mModifiedByUser = modifiedBy;
                this.mModifiedOn = modifiedOn;
            }
            return r;
        }

        protected override bool DeleteRecord()
        {
            return AppDAL.OPDPrescriptionDelete(this.mObjectGuid);
        }

        protected override void Reset()
        {
            base.Reset();
            this.mObjectGuid = Guid.Empty;
            this.mDoseage = string.Empty;
            this.mTimings = string.Empty;
        }

        protected override bool UpdateChild()
        {
            bool r = true;

            if (this.mOPDMedicines != null)
            {
                using (SqlDataReader dr = AppDAL.OPDPrescriptionProcedureMedicineDelete(this.mObjectGuid))
                {
 
                }
            }
            if (this.mOPDMedicines != null)
            {
                foreach (OPDPrescriptionProcedureMedicine item in this.mOPDMedicines)
                {
                    item.PrescriptionProcedureGuid = this.mObjectGuid;
                    item.MarkToSave();
                    item.UpdateChanges();
                }                
            }
            return r;              
        }

        #endregion
    }

    public sealed class OPDPrescriptionCollection : ObjectCollection<OPDPrescription>
    {
        #region OPDPrescriptionCollection

        public OPDPrescriptionCollection()
        {
            using (SqlDataReader dr = AppDAL.OPDPrescriptionSelectAll())
            {
                LoadObjectsFromReader(dr);
            }
        }
        #endregion

        #region OPDPrescriptionCollection
        public OPDPrescriptionCollection(Guid PatientGuid)
        {
            using (SqlDataReader dr = AppDAL.OPDPrescriptionSearch(PatientGuid))
            {
                LoadObjectsFromReader(dr);
            }
        }
        #endregion
    }
}
