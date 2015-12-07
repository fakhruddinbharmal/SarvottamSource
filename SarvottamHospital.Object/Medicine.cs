using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace SarvottamHospital.Object
{
    public sealed class Medicine : Objectbase
    {
        internal struct Columns
        {
            public const string ChiefComplainGuid       = "ChiefComplainGuid";
            public const string MedicineId              = "MedicineId";
            public const string MedicineGuid            = "MedicineGuid";            
            public const string MedicineName            = "MedicineName";
            public const string MedicineDescription     = "MedicineDescription";
            public const string MedicineCreatedBy       = "MedicineCreatedBy";
            public const string MedicineCreatedOn       = "MedicineCreatedOn";
            public const string MedicineModifiedBy      = "MedicineModifiedBy";
            public const string MedicineModifiedOn      = "MedicineModifiedOn";
        }

        #region Constructor

        public Medicine() : base() { }

        public Medicine(Guid key) : base(key) { }

        public Medicine(OPDPrescription obj)
        {
            this.Referer = obj;
        }

        public Medicine(SqlDataReader dr) : base(dr) { }

        #endregion

        #region properties

        public override string DisplayName
        {
            get { return this.mName; }
        }

        private string mName;
        public string Name
        {
            get { return this.mName; }
            set { this.mName = value; }
        }

        private string mDescription;
        public string Description
        {
            get { return this.mDescription; }
            set { this.mDescription = value; }
        }
        private Guid mChiefComplainGuid;

        public Guid ChiefComplainGuid
        {
            get { return mChiefComplainGuid; }
            set { mChiefComplainGuid = value; }
        }

        private ChiefComplain mChiefComplain;
        public ChiefComplain chiefcomplain
        {
            get
            {
                if (IsNullOrEmpty(this.mChiefComplain) || this.mChiefComplain.ObjectGuid != this.mChiefComplainGuid)
                    this.mChiefComplain = (this.mChiefComplainGuid != Guid.Empty ? new ChiefComplain(this.mChiefComplainGuid) : null);

                return this.mChiefComplain;
            }
            set
            {
                if (IsNullOrEmpty(value))
                {
                    this.mChiefComplainGuid = Guid.Empty;
                    this.mChiefComplain = null;
                }
                else
                {
                    this.mChiefComplainGuid = value.ObjectGuid;
                    this.mChiefComplain = value;
                }
            }
        }

        public string ChiefComplainName
        {
            get
            {
                ChiefComplain obj = this.mChiefComplain;
                return (IsNullOrEmpty(obj) ? string.Empty : obj.Name);

            }
        }

        private Objectbase mReferer;
        private Objectbase Referer
        {
            get { return this.mReferer; }
            set { this.mReferer = value; }
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

            if (dr != null && AppShared.IsNotNull(dr[Columns.MedicineGuid]))
            {
                this.mId = AppShared.DbValueToInteger(dr[Columns.MedicineId]);
                this.mObjectGuid = AppShared.DbValueToGuid(dr[Columns.MedicineGuid]);
                this.mName = AppShared.DbValueToString(dr[Columns.MedicineName]);
                this.mChiefComplainGuid = AppShared.DbValueToGuid(dr[Columns.ChiefComplainGuid]);
                this.mDescription = AppShared.DbValueToString(dr[Columns.MedicineDescription]);
                this.mCreatedByUser = AppShared.DbValueToGuid(dr[Columns.MedicineCreatedBy]);
                this.mCreatedOn = AppShared.DbValueToDateTime(dr[Columns.MedicineCreatedOn]);
                this.mModifiedByUser = AppShared.DbValueToGuid(dr[Columns.MedicineModifiedBy]);
                this.mModifiedOn = AppShared.DbValueToDateTime(dr[Columns.MedicineModifiedOn]);
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
            using (SqlDataReader dr = AppDAL.MedicineSelect(key))
                r = dr != null && dr.Read() && this.Populate(dr);
            return r;

        }

        protected override bool InsertRecord()
        {
            Guid createdBy = AppContext.UserGuid;
            DateTime createdOn;

            bool r = AppDAL.MedicineInsert(this.mObjectGuid, this.ChiefComplainGuid, this.mName, this.mDescription, createdBy, out createdOn);
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
            bool r = AppDAL.MedicineUpdate(this.mObjectGuid, this.ChiefComplainGuid, this.mName, this.mDescription, modifiedBy, out modifiedOn);
            if (r)
            {
                this.mModifiedByUser = modifiedBy;
                this.mModifiedOn = modifiedOn;
            }
            return r;
        }

        protected override bool DeleteRecord()
        {
            return AppDAL.MedicineDelete(this.mObjectGuid);
        }

        protected override void Reset()
        {
            base.Reset();
            this.mName = string.Empty;
            this.mDescription = string.Empty;
        }
        #endregion

    }

    public sealed class MedicineCollection : ObjectCollection<Medicine>
    {

        #region MedicineCollection
        public MedicineCollection(string searchText)
        {
            using (SqlDataReader dr = AppDAL.MedicineSearch(searchText))
            {
                LoadObjectsFromReader(dr);
            }
        }
        #endregion

        #region MedicineCollection

        public MedicineCollection()
        {
            using (SqlDataReader dr = AppDAL.MedicineSelectAll())
            {
                LoadObjectsFromReader(dr);
            }
        }
        #endregion

    }
}
