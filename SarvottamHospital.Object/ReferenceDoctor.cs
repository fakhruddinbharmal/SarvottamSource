using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace SarvottamHospital.Object
{
    public sealed class ReferenceDoctor : Objectbase
    {
        internal struct Columns
        {
            public const string ReferenceDoctorId = "ReferenceDoctorId";
            public const string ReferenceDoctorGuid = "ReferenceDoctorGuid";
            public const string ReferenceDoctorName = "ReferenceDoctorName";
            public const string ReferenceDoctorDescription = "ReferenceDoctorDescription";
            public const string ReferenceDoctorShare = "ReferenceDoctorShare";
            public const string ReferenceDoctorCreatedBy = "ReferenceDoctorCreatedBy";
            public const string ReferenceDoctorCreatedOn = "ReferenceDoctorCreatedOn";
            public const string ReferenceDoctorModifiedBy = "ReferenceDoctorModifiedBy";
            public const string ReferenceDoctorModifiedOn = "ReferenceDoctorModifiedOn";
        }

         #region Constructor

        public ReferenceDoctor() : base() { }

        public ReferenceDoctor(Guid key) : base(key) { }

        public ReferenceDoctor(SqlDataReader dr) : base(dr) { }

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

        private decimal mShare;
        public decimal Share
        {
            get { return this.mShare; }
            set { this.mShare = value; }
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

            if (dr != null && AppShared.IsNotNull(dr[Columns.ReferenceDoctorGuid]))
            {
                this.mId = AppShared.DbValueToInteger(dr[Columns.ReferenceDoctorId]);
                this.mObjectGuid = AppShared.DbValueToGuid(dr[Columns.ReferenceDoctorGuid]);
                this.mName = AppShared.DbValueToString(dr[Columns.ReferenceDoctorName]);
                this.mDescription = AppShared.DbValueToString(dr[Columns.ReferenceDoctorDescription]);
                this.mShare = AppShared.DbValueToDecimal(dr[Columns.ReferenceDoctorShare]);
                this.mCreatedByUser = AppShared.DbValueToGuid(dr[Columns.ReferenceDoctorCreatedBy]);
                this.mCreatedOn = AppShared.DbValueToDateTime(dr[Columns.ReferenceDoctorCreatedOn]);
                this.mModifiedByUser = AppShared.DbValueToGuid(dr[Columns.ReferenceDoctorModifiedBy]);
                this.mModifiedOn = AppShared.DbValueToDateTime(dr[Columns.ReferenceDoctorModifiedOn]);
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
            using (SqlDataReader dr = AppDAL.ReferenceDoctorSelect(key))
                r = dr != null && dr.Read() && this.Populate(dr);
            return r;

        }

        protected override bool InsertRecord()
        {
            Guid createdBy = AppContext.UserGuid;
            DateTime createdOn;

            bool r = AppDAL.ReferenceDoctorInsert(this.mObjectGuid, this.mName, this.mDescription,this.mShare, createdBy, out createdOn);
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
            bool r = AppDAL.ReferenceDoctorUpdate(this.mObjectGuid, this.mName, this.mDescription,this.mShare, modifiedBy, out modifiedOn);
            if (r)
            {
                this.mModifiedByUser = modifiedBy;
                this.mModifiedOn = modifiedOn;
            }
            return r;
        }

        protected override bool DeleteRecord()
        {
            return AppDAL.ReferenceDoctorDelete(this.mObjectGuid);
        }

        protected override void Reset()
        {
            base.Reset();
            this.mName = string.Empty;
            this.mDescription = string.Empty;
            this.mShare = 0;
        }
        #endregion
    }

    public sealed class ReferenceDoctors : ObjectCollection<ReferenceDoctor>
    {
        public ReferenceDoctors()
        {
            using (SqlDataReader dr = AppDAL.ReferenceDoctorSelectAll())
            {
                LoadObjectsFromReader(dr);
            }
        }

        public ReferenceDoctors(string searchText)
        {
            using (SqlDataReader dr = AppDAL.ReferenceDoctorSearch(searchText))
            {
                LoadObjectsFromReader(dr);
            }
        }
    }
}
