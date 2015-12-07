using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Security.Principal;

namespace SarvottamHospital.Object
{
    public sealed class IPDTreatment : Objectbase
    {
        internal struct Columns
        {
            public const string TreatmentId = "IPDTreatmentId";
            public const string TreatmentGuid = "IPDTreatmentGuid";
            public const string TreatmentName = "IPDTreatmentName";
            public const string TreatmentDescription = "IPDTreatmentDescription";
            public const string TreatmentCreatedBy = "IPDTreatmentCreatedBy";
            public const string TreatmentCreatedOn = "IPDTreatmentCreatedOn";
            public const string TreatmentModifiedBy = "IPDTreatmentModifiedBy";
            public const string TreatmentModifiedOn = "IPDTreatmentModifiedOn";
        }

         #region Constructor

        public IPDTreatment() : base() { }

        public IPDTreatment(Guid key) : base(key) { }

        public IPDTreatment(SqlDataReader dr) : base(dr) { }

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
            using (SqlDataReader dr = AppDAL.TreatmentSelect(key))
                r = dr != null && dr.Read() && this.Populate(dr);
            return r;

        }

        protected override bool InsertRecord()
        {
            Guid createdBy = AppContext.UserGuid;
            DateTime createdOn;

            bool r = AppDAL.TreatmentInsert(this.mObjectGuid, this.mName, this.mDescription, createdBy, out createdOn);
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
            bool r = AppDAL.TreatmentUpdate(this.mObjectGuid, this.mName,this.mDescription, modifiedBy, out modifiedOn);
            if (r)
            {
                this.mModifiedByUser = modifiedBy;
                this.mModifiedOn = modifiedOn;
            }
            return r;
        }

        protected override bool DeleteRecord()
        {
            return AppDAL.TreatmentDelete(this.mObjectGuid);
        }

        protected override void Reset()
        {
            base.Reset();
            this.mName = string.Empty;
            this.mDescription = string.Empty;
        }
        #endregion
    }

    public sealed class Treatments : ObjectCollection<IPDTreatment>
    {
        public Treatments()
        {
            using (SqlDataReader dr = AppDAL.TreatmentSelectAll())
            {
                LoadObjectsFromReader(dr);
            }
        }

        public Treatments(string searchText)
        {
            using (SqlDataReader dr = AppDAL.TreatmentSearch(searchText))
            {
                LoadObjectsFromReader(dr);
            }
        }

    }
}
