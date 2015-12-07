using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Security.Principal;

namespace SarvottamHospital.Object
{
    public sealed class Patient : Objectbase
    {
        internal struct Columns
        {
            public const string PatientId = "PatientId";
            public const string PatientGuid = "PatientGuid";
            public const string PatientNo = "PatientNo";
            public const string PatientFirstName = "PatientFirstName";
            public const string PatientMiddleName = "PatientMiddleName";
            public const string PatientLastName = "PatientLastName";
            public const string PatientGender = "PatientGender";
            public const string PatientAge = "PatientAge";
            public const string PatientAddress = "PatientAddress";
            public const string PatientCity = "PatientCity";
            public const string PatientContactNo = "PatientContactNo";
            public const string PatientNotes = "PatientNotes";
            public const string PatientWardGuid = "PatientWardGuid";
            public const string PatientRoomGuid = "PatientRoomGuid";
            public const string PatientAdmittedDate = "PatientAdmittedDate";
            public const string PatientAdmittedTime = "PatientAdmittedTime";
            public const string PatientOperation = "PatientOperation";
            public const string PatientFollowUpDate = "PatientFollowUpDate";
            public const string PatientAmountReceived = "PatientAmountReceived";
            public const string PatientIsIPD = "PatientIsIPD";
            public const string PatientReferenceDoctorGuid = "PatientReferenceDoctorGuid";
            public const string PatientReferenceDoctorShare = "PatientReferenceDoctorShare";
            public const string PatientIsDischarge = "PatientIsDischarge";
            public const string PatiendDischargeDate = "PatiendDischargeDate";
            public const string PatientInvoiceNo = "PatientInvoiceNo";
            public const string PatientInvoiceDate = "PatientInvoiceDate";
            public const string PatientCreatedBy = "PatientCreatedBy";
            public const string PatientCreatedOn = "PatientCreatedOn";
            public const string PatientModifiedBy = "PatientModifiedBy";
            public const string PatientModifiedOn = "PatientModifiedOn";
            public const string MaxInvoiceNo = "MaxInvoiceNo";
        }

        #region Constructor

        public Patient() : base() { }

        public Patient(Guid key) : base(key) { }

        public Patient(SqlDataReader dr) : base(dr) { }

        #endregion

        #region properties

        public override string DisplayName
        {
            get { return this.mFirstName + " " + this.mLastName; }
        }

        private int mNumber;
        public int Number
        {
            get { return this.mNumber; }
            set { this.mNumber = value; }
        }

        private string mFirstName;
        public string FirstName
        {
            get { return this.mFirstName; }
            set { this.mFirstName = value; }
        }

        private string mMiddleName;
        public string MiddleName
        {
            get { return this.mMiddleName; }
            set { this.mMiddleName = value; }
        }

        private string mLastName;
        public string LastName
        {
            get { return this.mLastName; }
            set { this.mLastName = value; }
        }

        private Gender mGender;
        public Gender Gender
        {
            get { return this.mGender; }
            set { this.mGender = value; }
        }

        private int mAge;
        public int Age
        {
            get { return this.mAge; }
            set { this.mAge = value; }
        }

        private string mAddress;
        public string Address
        {
            get { return this.mAddress; }
            set { this.mAddress = value; }
        }

        private string mCity;
        public string City
        {
            get { return this.mCity; }
            set { this.mCity = value; }
        }

        private string mContactNo;
        public string ContactNo
        {
            get { return this.mContactNo; }
            set { this.mContactNo = value; }
        }

        private string mNotes;
        public string Notes
        {
            get { return this.mNotes; }
            set { this.mNotes = value; }
        }

        private Guid mWardGuid;
        public Guid WardGuid
        {
            get { return this.mWardGuid; }
            set { this.mWardGuid = value; }
        }

        private Ward mWard;
        public Ward Ward
        {
            get
            {
                if (IsNullOrEmpty(this.mWard) || this.mWard.ObjectGuid != this.mWardGuid)
                    this.mWard = (this.mWardGuid != Guid.Empty ? new Ward(this.mWardGuid) : null);
                return this.mWard;
            }
            set
            {
                if (IsNullOrEmpty(value))
                {
                    this.mWardGuid = Guid.Empty;
                    this.mWard = null;
                }
                else
                {
                    this.mWardGuid = value.ObjectGuid;
                    this.mWard = value;
                }
            }
        }

        public string WardName
        {
            get
            {
                Ward obj = this.Ward;
                return IsNullOrEmpty(obj) ? string.Empty : obj.Name;
            }
        }

        private Guid mRoomGuid;
        public Guid RoomGuid
        {
            get { return this.mRoomGuid; }
            set { this.mRoomGuid = value; }
        }

        private Room mRoom;
        public Room Room
        {
            get {
                if (IsNullOrEmpty(this.mRoom) || this.mRoom.ObjectGuid != this.mRoomGuid)
                    this.mRoom = (this.mRoomGuid != Guid.Empty ? new Room(this.mRoomGuid) : null);
                return this.mRoom;
            }
            set
            {
                if (IsNullOrEmpty(value))
                {
                    this.mRoomGuid = Guid.Empty;
                    this.mRoom = null;
                }
                else
                {
                    this.mRoomGuid = value.ObjectGuid;
                    this.mRoom = value;
                }
            }
        }

        public string RoomTypeName
        {
            get {
                Room obj = this.Room;
                return IsNullOrEmpty(obj) ? string.Empty : obj.Type;
            }
        }

        private DateTime mAdmittedDate;
        public DateTime AdmittedDate
        {
            get {
                return this.mAdmittedDate;
            }
            set
            {
                this.mAdmittedDate = value;
            }
        }

        private string mAdmittedTime;
        public string AdmittedTime
        {
            get {
                return this.mAdmittedTime;
            }
            set
            {
                this.mAdmittedTime = value;
            }
        }

        private string mOpetation;
        public string Operation
        {
            get {
                return this.mOpetation;
            }
            set
            {
                this.mOpetation = value;
            }
        }

        private DateTime mFollowUpDate;
        public DateTime FollowUpDate
        {
            get { return this.mFollowUpDate; }
            set { this.mFollowUpDate = value; }
        }

        private decimal mAmountReceived;
        public decimal AmountReceived
        {
            get { return this.mAmountReceived; }
            set { this.mAmountReceived = value; }
        }

        private bool mIsIPD;
        public bool IsIPD
        {
            get { return this.mIsIPD; }
            set { this.mIsIPD = value; }
        }

        private Guid mReferenceDoctorGuid;
        public Guid ReferenceDoctorGuid
        {
            get { return this.mReferenceDoctorGuid; }
            set { this.mReferenceDoctorGuid = value; }
        }

        private ReferenceDoctor mReferenceDoctor;
        public ReferenceDoctor ReferenceDoctor
        {
            get {
                if (IsNullOrEmpty(this.mReferenceDoctor) || this.mReferenceDoctor.ObjectGuid != this.mReferenceDoctorGuid)
                    this.mReferenceDoctor = (this.mReferenceDoctorGuid != Guid.Empty ? new ReferenceDoctor(this.mReferenceDoctorGuid) : null);
                return this.mReferenceDoctor;
            }
            set
            {
                if (IsNullOrEmpty(value))
                {
                    this.mReferenceDoctorGuid = Guid.Empty;
                    this.mReferenceDoctor = null;
                }
                else
                {
                    this.mReferenceDoctorGuid = value.ObjectGuid;
                    this.mReferenceDoctor = value;
                }
            }
        }

        public string ReferenceDoctorName
        {
            get
            {
                ReferenceDoctor obj = this.ReferenceDoctor;
                return IsNullOrEmpty(obj) ? string.Empty : obj.Name;
            }
        }

        private decimal mReferenceDoctorShare;
        public decimal ReferenceDoctorShare
        {
            get { return this.mReferenceDoctorShare; }
            set { this.mReferenceDoctorShare = value; }
        }

        private bool mIsDischarge;
        public bool IsDischarge
        {
            get { return this.mIsDischarge; }
            set { this.mIsDischarge = value; }

        }

        private DateTime mDischargeDate;
        public DateTime DischargeDate
        {
            get { return this.mDischargeDate; }
            set { this.mDischargeDate = value; }
        }

        private int mInvoiceNo;
        public int InvoiceNo
        {
            get { return this.mInvoiceNo; }
            set { this.mInvoiceNo = value; }
        }

        private DateTime mInvoiceDate;
        public DateTime InvoiceDate
        {
            get { return this.mInvoiceDate; }
            set { this.mInvoiceDate = value; }
        }

        private int mMaxInvoiceNo;
        public int MaxInvoiceNo
        {
            get { return this.mMaxInvoiceNo; }
            set { this.mMaxInvoiceNo = value; }
        }

        PatientProcedure mPatientProcedure;
        public PatientProcedure PatientProcedure
        {
            get { return this.mPatientProcedure; }
            set { this.mPatientProcedure = value; }
        }

        IPDPatientTreatments mIPDPatientTreatment;
        public IPDPatientTreatments IPDPatientTreatment
        {
            get
            {
                if (this.mIPDPatientTreatment == null)
                    this.mIPDPatientTreatment = new IPDPatientTreatments(this.ObjectGuid);

                return mIPDPatientTreatment;
            }
            set
            {
                this.mIPDPatientTreatment = value;
            }
        }

        Appointment mAppointment;

        public Appointment Appointment
        {
            get { return this.mAppointment; }
            set { this.mAppointment = value; }
        }

        HistoryProcedure mHistoryProcedure;
        public HistoryProcedure HistoryProcedure
        {
            get { return this.mHistoryProcedure; }
            set { this.mHistoryProcedure = value; }
        }

        OPDTreatmentProcedure mOPDTreatmentProcedure;

        public OPDTreatmentProcedure OPDTreatmentProcedure
        {
            get { return this.mOPDTreatmentProcedure; }
            set { this.mOPDTreatmentProcedure = value; }
        }

        OPDInvestigationProcedure mOPDInvestigationProcedure;

        public OPDInvestigationProcedure OPDInvestigationProcedure
        {
            get { return mOPDInvestigationProcedure; }
            set { mOPDInvestigationProcedure = value; }
        }

        OPDPrescription mOPDPrescription;

        public OPDPrescription OPDPrescription
        {
            get { return mOPDPrescription; }
            set { mOPDPrescription = value; }
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

            if (dr != null && AppShared.IsNotNull(dr[Columns.PatientGuid]))
            {
                this.mId = AppShared.DbValueToInteger(dr[Columns.PatientId]);
                this.mObjectGuid = AppShared.DbValueToGuid(dr[Columns.PatientGuid]);
                this.mNumber = AppShared.DbValueToInteger(dr[Columns.PatientNo]);
                this.mFirstName = AppShared.DbValueToString(dr[Columns.PatientFirstName]);
                this.mMiddleName = AppShared.DbValueToString(dr[Columns.PatientMiddleName]);
                this.mLastName = AppShared.DbValueToString(dr[Columns.PatientLastName]);
                this.mGender = (Gender)AppShared.DbValueToInteger(dr[Columns.PatientGender]);
                this.mAge = AppShared.DbValueToInteger(dr[Columns.PatientAge]);
                this.mAddress = AppShared.DbValueToString(dr[Columns.PatientAddress]);
                this.mCity = AppShared.DbValueToString(dr[Columns.PatientCity]);
                this.mContactNo = AppShared.DbValueToString(dr[Columns.PatientContactNo]);
                this.mNotes = AppShared.DbValueToString(dr[Columns.PatientNotes]);
                this.mWardGuid = AppShared.DbValueToGuid(dr[Columns.PatientWardGuid]);
                this.mRoomGuid = AppShared.DbValueToGuid(dr[Columns.PatientRoomGuid]);
                this.mAdmittedDate = AppShared.DbValueToDateTime(dr[Columns.PatientAdmittedDate]);
                this.mAdmittedTime = AppShared.DbValueToString(dr[Columns.PatientAdmittedTime]);
                this.mOpetation = AppShared.DbValueToString(dr[Columns.PatientOperation]);
                this.mFollowUpDate = AppShared.DbValueToDateTime(dr[Columns.PatientFollowUpDate]);
                this.mAmountReceived = AppShared.DbValueToDecimal(dr[Columns.PatientAmountReceived]);
                this.mIsIPD = AppShared.DbValueToBoolean(dr[Columns.PatientIsIPD]);
                this.mReferenceDoctorGuid = AppShared.DbValueToGuid(dr[Columns.PatientReferenceDoctorGuid]);
                this.mReferenceDoctorShare = AppShared.DbValueToDecimal(dr[Columns.PatientReferenceDoctorShare]);
                this.mIsDischarge = AppShared.DbValueToBoolean(dr[Columns.PatientIsDischarge]);
                this.mDischargeDate = AppShared.DbValueToDateTime(dr[Columns.PatiendDischargeDate]);
                this.mInvoiceNo = AppShared.DbValueToInteger(dr[Columns.PatientInvoiceNo]);
                this.mInvoiceDate = AppShared.DbValueToDateTime(dr[Columns.PatientInvoiceDate]);
                this.mCreatedByUser = AppShared.DbValueToGuid(dr[Columns.PatientCreatedBy]);
                this.mCreatedOn = AppShared.DbValueToDateTime(dr[Columns.PatientCreatedOn]);
                this.mModifiedByUser = AppShared.DbValueToGuid(dr[Columns.PatientModifiedBy]);
                this.mModifiedOn = AppShared.DbValueToDateTime(dr[Columns.PatientModifiedOn]);
                if (AppShared.HasColumn(dr, "MaxInvoiceNo"))
                {
                    this.mMaxInvoiceNo = AppShared.DbValueToInteger(dr[Columns.MaxInvoiceNo]);
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
            using (SqlDataReader dr = AppDAL.PatientSelect(key))
                r = dr != null && dr.Read() && this.Populate(dr);
            return r;

        }

        protected override bool InsertRecord()
        {
            Guid createdBy = AppContext.UserGuid;
            DateTime createdOn;
            int gender = (int)this.mGender;
            bool r = AppDAL.PatientInsert(this.mObjectGuid, this.mFirstName, this.mMiddleName, this.mLastName, gender, this.mAge, this.mAddress, this.mCity,
               this.mContactNo, this.mNotes, this.mWardGuid, this.mRoomGuid, this.mAdmittedDate, this.mAdmittedTime, this.mOpetation, this.mFollowUpDate, this.mAmountReceived,
               this.mIsIPD, this.mReferenceDoctorGuid, this.mReferenceDoctorShare, this.mIsDischarge, this.mDischargeDate, this.mInvoiceNo, this.mInvoiceDate, createdBy, out createdOn);
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
            int gender = (int)this.mGender;
            bool r = AppDAL.PatientUpdate(this.mObjectGuid, this.mFirstName, this.mMiddleName, this.mLastName, gender, this.mAge, this.mAddress, this.mCity,
               this.mContactNo, this.mNotes, this.mWardGuid, this.mRoomGuid, this.mAdmittedDate, this.mAdmittedTime, this.mOpetation, this.mFollowUpDate, this.mAmountReceived,
               this.mIsIPD, this.mReferenceDoctorGuid, this.mReferenceDoctorShare, this.mIsDischarge, this.mDischargeDate, this.mInvoiceNo, this.mInvoiceDate, modifiedBy, out modifiedOn);
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
            this.mNumber = 0;
            this.mFirstName = string.Empty;
            this.mMiddleName = string.Empty;
            this.mLastName = string.Empty;
            this.mGender = 0;
            this.mAge = 0;
            this.mAddress = string.Empty;
            this.mCity = string.Empty;
            this.mContactNo = string.Empty;
            this.mNotes = string.Empty;
            this.mWardGuid = Guid.Empty;
            this.mRoomGuid = Guid.Empty;
            this.mAdmittedDate = DateTime.MinValue;
            this.mAdmittedTime = string.Empty;
            this.mOpetation = string.Empty;
            this.mFollowUpDate = DateTime.MinValue;
            this.mAmountReceived = 0;
            this.mIsIPD = false;
            this.mReferenceDoctorGuid = Guid.Empty;
            this.mReferenceDoctorShare = 0;
            this.mIsDischarge = false;
            this.mDischargeDate = DateTime.MinValue;
        }

        protected override bool UpdateChild()
        {
            bool r = true;
            if (this.mPatientProcedure != null)
            {
                this.mPatientProcedure.PatientGuid = this.mObjectGuid;
                this.mPatientProcedure.MarkToSave();
                this.mPatientProcedure.UpdateChanges();
            }

            if (this.mIPDPatientTreatment != null)
            {
                using (SqlDataReader dr = AppDAL.IPDPatientTreatmentDelete(this.mObjectGuid))
                {
                   
                }
                foreach (IPDPatientTreatment item in this.mIPDPatientTreatment)
                {
                    item.PatientGuid = this.mObjectGuid;
                    item.MarkToSave();
                    item.UpdateChanges();
                }
            }

            // Chief Complain
            if (this.mHistoryProcedure != null)
            {
                this.mHistoryProcedure.PatientGuid = this.mObjectGuid;
                this.mHistoryProcedure.MarkToSave();
                this.mHistoryProcedure.UpdateChanges();
            }

            //Associate Complain

            if (this.mHistoryProcedure != null)
            {
                this.mHistoryProcedure.PatientGuid = this.mObjectGuid;
                this.mHistoryProcedure.MarkToSave();
                this.mHistoryProcedure.UpdateChanges();          
               }
           
            // History

            if (this.mHistoryProcedure != null)
            {
                this.mHistoryProcedure.PatientGuid = this.mObjectGuid;
                this.mHistoryProcedure.MarkToSave();
                this.mHistoryProcedure.UpdateChanges();       
            }

            //Main Investigation

            if (this.mOPDInvestigationProcedure != null)
            {
                this.mOPDInvestigationProcedure.PatientGuid = this.mObjectGuid;
                this.OPDInvestigationProcedure.MarkToSave();
                this.OPDInvestigationProcedure.UpdateChanges();
            }

            //Lab Investigation

            if (this.mOPDInvestigationProcedure != null)
            {
                this.mOPDInvestigationProcedure.PatientGuid = this.mObjectGuid;
                this.OPDInvestigationProcedure.MarkToSave();
                this.OPDInvestigationProcedure.UpdateChanges();
            }

            // Treatment
            if (this.mOPDTreatmentProcedure != null)
            {
                this.mOPDTreatmentProcedure.PatientGuid = this.mObjectGuid;
                this.mOPDTreatmentProcedure.MarkToSave();
                this.mOPDTreatmentProcedure.UpdateChanges();

            }
            //Medicine
            if (this.mOPDPrescription != null)
            {
                this.mOPDPrescription.PatientGuid = this.mObjectGuid;
                this.mOPDPrescription.MarkToSave();
                this.mOPDPrescription.UpdateChanges();
            }
            // Appointment
            if (this.mAppointment != null)
            {
                this.mAppointment.PatientGuid = this.mObjectGuid;
                this.mAppointment.MarkToSave();
                this.mAppointment.UpdateChanges();
            }
            return r;
        }

        #endregion
    }

    public sealed class Patients : ObjectCollection<Patient>
    {
        public Patients(string searchText, bool IsIpd, int isDischarge, DateTime dateFrom, DateTime dateTo)
        {
            using (SqlDataReader dr = AppDAL.PatientSearch(searchText, IsIpd, isDischarge, dateFrom, dateTo))
            {
                LoadObjectsFromReader(dr);
            }
        }
    }
}
