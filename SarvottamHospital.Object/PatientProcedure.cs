using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace SarvottamHospital.Object
{
    public sealed class PatientProcedure : Objectbase
    {
        internal struct Columns
        {
            public const string PatientProcedureId = "PatientProcedureId";
            public const string PatientProcedureGuid = "PatientProcedureGuid";
            public const string PatietProcedurePatientGuid = "PatietProcedurePatientGuid";
            public const string PatientProcedureProcedureGuid = "PatientProcedureProcedureGuid";
            public const string PatientProcedureDate = "PatientProcedureDate";
            public const string PatientProcedureAmount = "PatientProcedureAmount";
            public const string PatientProcedureNotes = "PatientProcedureNotes";
            public const string PatientProcedureCreatedBy = "PatientProcedureCreatedBy";
            public const string PatientProcedureCreatedOn = "PatientProcedureCreatedOn";
            public const string PatientProcedureModifiedBy = "PatientProcedureModifiedBy";
            public const string PatientProcedureModifiedOn = "PatientProcedureModifiedOn";
            
        }

        #region Constructor

        public PatientProcedure() : base() { }

        public PatientProcedure(Guid key) : base(key) { }

        public PatientProcedure(SqlDataReader dr) : base(dr) { }

        #endregion

        #region Properties

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

        private Patient mPatient;
        public Patient Patient
        {
            get
            {
                if (IsNullOrEmpty(this.mPatient) || this.mPatient.ObjectGuid != this.mPatientGuid)
                    this.mPatient = (this.mPatientGuid != Guid.Empty ? new Patient(this.mPatientGuid) : null);

                return this.mPatient;
            }
            set
            {
                if (IsNullOrEmpty(value))
                {
                    this.mPatientGuid = Guid.Empty;
                    this.mPatient = null;
                }
                else
                {
                    this.mPatientGuid = value.ObjectGuid;
                    this.mPatient = value;
                }
            }
        }

        public string PatientName
        {
            get
            {
                Patient obj = this.Patient;
                return (IsNullOrEmpty(obj) ? string.Empty : obj.DisplayName);
            }
        }

        private Guid mProcedureGuid;
        public Guid ProcedureGuid
        {
            get { return this.mProcedureGuid; }
            set { this.mProcedureGuid = value; }
        }
       
        private Procedure mProcedure;
        public Procedure Procedure
        {
            get
            {
                if (IsNullOrEmpty(this.mProcedure) || this.mProcedure.ObjectGuid != this.mProcedureGuid)
                    this.mProcedure = (this.mProcedureGuid != Guid.Empty ? new Procedure(this.mProcedureGuid) : null);
                return this.mProcedure;
            }
            set
            {
                if (IsNullOrEmpty(value))
                {
                    this.mProcedureGuid = Guid.Empty;
                    this.mProcedure = null;
                }
                else
                {
                    this.mProcedureGuid = value.ObjectGuid;
                    this.mProcedure = value;
                }
            }
        }

        public string ProcedureName
        {
            get
            {
                Procedure obj = this.Procedure;
                return (IsNullOrEmpty(obj) ? string.Empty : obj.Name);
            }
        }

        private DateTime mProcedureDate;
        public DateTime ProcedureDate
        {
            get { return this.mProcedureDate; }
            set { this.mProcedureDate = value; }
        }

        private decimal mAmount;
        public decimal Amount
        {
            get { return this.mAmount; }
            set { this.mAmount = value; }
        }

        private string mNotes;
        public string Notes
        {
            get { return this.mNotes; }
            set { this.mNotes = value; }
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

            if (dr != null && AppShared.IsNotNull(dr[Columns.PatientProcedureId]))
            {
                this.mId = AppShared.DbValueToInteger(dr[Columns.PatientProcedureId]);
                this.mObjectGuid = AppShared.DbValueToGuid(dr[Columns.PatientProcedureGuid]);
                this.mPatientGuid = AppShared.DbValueToGuid(dr[Columns.PatietProcedurePatientGuid]);
                this.mProcedureGuid = AppShared.DbValueToGuid(dr[Columns.PatientProcedureProcedureGuid]);
                this.mProcedureDate = AppShared.DbValueToDateTime(dr[Columns.PatientProcedureDate]);
                this.mAmount = AppShared.DbValueToDecimal(dr[Columns.PatientProcedureAmount]);
                this.mNotes = AppShared.DbValueToString(dr[Columns.PatientProcedureNotes]);
                this.mCreatedByUser = AppShared.DbValueToGuid(dr[Columns.PatientProcedureCreatedBy]);
                this.mCreatedOn = AppShared.DbValueToDateTime(dr[Columns.PatientProcedureCreatedOn]);
                this.mModifiedByUser = AppShared.DbValueToGuid(dr[Columns.PatientProcedureModifiedBy]);
                this.mModifiedOn = AppShared.DbValueToDateTime(dr[Columns.PatientProcedureModifiedOn]);
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
            using (SqlDataReader dr = AppDAL.PatientProcedureSelect(key))
                r = dr != null && dr.Read() && this.Populate(dr);
            return r;

        }

        protected override bool InsertRecord()
        {
            Guid createdBy = AppContext.UserGuid;
            DateTime createdOn;
            bool r = AppDAL.PatientProcedureInsert(this.mObjectGuid, this.mPatientGuid, this.mProcedureGuid, this.mProcedureDate, this.mAmount, this.mNotes, createdBy, out createdOn);
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
            bool r = AppDAL.PatientProcedureUpdate(this.mObjectGuid, this.mPatientGuid, this.mProcedureGuid, this.mProcedureDate, this.mAmount, this.mNotes, modifiedBy, out modifiedOn);
            if (r)
            {
                this.mModifiedByUser = modifiedBy;
                this.mModifiedOn = modifiedOn;
            }
            return r;
        }

        protected override bool DeleteRecord()
        {
            return AppDAL.PatientProcedureDelete(this.mObjectGuid);
        }

        protected override void Reset()
        {
            base.Reset();
            this.mPatientGuid = Guid.Empty;
            this.mProcedureGuid = Guid.Empty;
            this.mAmount = 0;
            this.mNotes = string.Empty;
        }

        #endregion
    }

    public sealed class PatientProcedures : ObjectCollection<PatientProcedure>
    {
        public PatientProcedures(Guid patientGuid)
        {
            using (SqlDataReader dr = AppDAL.PatientProcedureSearch(patientGuid))
            {
                LoadObjectsFromReader(dr);
            }
        }
    }
}
