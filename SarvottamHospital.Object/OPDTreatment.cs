using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace SarvottamHospital.Object
{
    public sealed class OPDTreatment : Objectbase
    {
        internal struct Columns
        {
            public const string TreatmentId = "TreatmentId";
            public const string TreatmentGuid = "TreatmentGuid";
            public const string ChiefComplainGuid = "ChiefComplainGuid";
            public const string TreatmentName = "TreatmentName";
            public const string TreatmentDescription = "TreatmentDescription";
            public const string TreatmentCreatedBy = "TreatmentCreatedBy";
            public const string TreatmentCreatedOn = "TreatmentCreatedOn";
            public const string TreatmentModifiedBy = "TreatmentModifiedBy";
            public const string TreatmentModifiedOn = "TreatmentModifiedOn";
        }

        #region Constructor

        public OPDTreatment() : base() { }

        public OPDTreatment(OPDTreatmentProcedure obj)
        {
            this.Referer = obj;
        }

        public OPDTreatment(Guid key) : base(key) { }

        public OPDTreatment(SqlDataReader dr) : base(dr) { }

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

        private Objectbase mReferer;
        private Objectbase Referer
        {
            get { return this.mReferer; }
            set { this.mReferer = value; }
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
        #endregion

        #region Overiden

        internal override bool CreateRecord()
        {
            return base.CreateRecord();
        }

        internal override bool Populate(SqlDataReader dr)
        {
            bool r = false;

            if (dr != null && AppShared.IsNotNull(dr[Columns.TreatmentGuid]))
            {
                this.mId = AppShared.DbValueToInteger(dr[Columns.TreatmentId]);
                this.mObjectGuid = AppShared.DbValueToGuid(dr[Columns.TreatmentGuid]);
                this.mName = AppShared.DbValueToString(dr[Columns.TreatmentName]);
                this.mChiefComplainGuid = AppShared.DbValueToGuid(dr[Columns.ChiefComplainGuid]);
                this.mDescription = AppShared.DbValueToString(dr[Columns.TreatmentDescription]);
                this.mCreatedByUser = AppShared.DbValueToGuid(dr[Columns.TreatmentCreatedBy]);
                this.mCreatedOn = AppShared.DbValueToDateTime(dr[Columns.TreatmentCreatedOn]);
                this.mModifiedByUser = AppShared.DbValueToGuid(dr[Columns.TreatmentModifiedBy]);
                this.mModifiedOn = AppShared.DbValueToDateTime(dr[Columns.TreatmentModifiedOn]);
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
            using (SqlDataReader dr = AppDAL.OPDTreatmentSelect(key))
                r = dr != null && dr.Read() && this.Populate(dr);
            return r;

        }

        protected override bool InsertRecord()
        {
            Guid createdBy = AppContext.UserGuid;
            DateTime createdOn;

            bool r = AppDAL.OPDTreatmentInsert(this.mObjectGuid, this.ChiefComplainGuid,this.mName, this.mDescription, createdBy, out createdOn);
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
            bool r = AppDAL.OPDTreatmentUpdate(this.mObjectGuid,this.ChiefComplainGuid, this.mName, this.mDescription, modifiedBy, out modifiedOn);
            if (r)
            {
                this.mModifiedByUser = modifiedBy;
                this.mModifiedOn = modifiedOn;
            }
            return r;
        }

        protected override bool DeleteRecord()
        {
            return AppDAL.OPDTreatmentDelete(this.mObjectGuid);
        }

        protected override void Reset()
        {
            base.Reset();
            this.mName = string.Empty;
            this.mDescription = string.Empty;
        }
        #endregion
    }

    public sealed class OPDTreatmentCollection : ObjectCollection<OPDTreatment>
    {
        #region OPDTreatmentCollection
        public OPDTreatmentCollection(string searchText)
        {
            using (SqlDataReader dr = AppDAL.OPDTreatmentSearch(searchText))
            {
                LoadObjectsFromReader(dr);
            }
        }
        #endregion

        #region OPDTreatmentCollection

        public OPDTreatmentCollection()
        {
            using (SqlDataReader dr = AppDAL.OPDTreatmentSelectAll())
            {
                LoadObjectsFromReader(dr);
            }
        }
        #endregion
    }
}
