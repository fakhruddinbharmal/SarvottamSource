using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Security.Principal;

namespace SarvottamHospital.Object
{
   public sealed class Ward : Objectbase 
    {
        internal struct Columns
        {
            public const string WardId = "WardId";
            public const string WardGuid = "WardGuid";
            public const string WardName = "WardName";
            public const string WardDescription = "WardDescription";
            public const string WardCreatedBy = "WardCreatedBy";
            public const string WardCreatedOn = "WardCreatedOn";
            public const string WardModifiedBy = "WardModifiedBy";
            public const string WardModifiedOn = "WardModifiedOn";
            public const string WardRowStamp = "WardRowStamp";
        }

         #region Constructor

        public Ward() : base() { }

        public Ward(Guid key) : base(key) { }

        public Ward(SqlDataReader dr) : base(dr) { }

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

            if (dr != null && AppShared.IsNotNull(dr[Columns.WardGuid]))
            {
                this.mId = AppShared.DbValueToInteger(dr[Columns.WardId]);
                this.mObjectGuid = AppShared.DbValueToGuid(dr[Columns.WardGuid]);
                this.mName = AppShared.DbValueToString(dr[Columns.WardName]);
                this.mDescription = AppShared.DbValueToString(dr[Columns.WardDescription]);
                //this.mCreatedBy = AppShared.DbValueToString(dr[Columns.UserCreatedBy]);
                this.mCreatedByUser = AppShared.DbValueToGuid(dr[Columns.WardCreatedBy]);
                this.mCreatedOn = AppShared.DbValueToDateTime(dr[Columns.WardCreatedOn]);
                //this.mModifiedBy = AppShared.DbValueToString(dr[Columns.UserModifiedBy]);
                this.mModifiedByUser = AppShared.DbValueToGuid(dr[Columns.WardModifiedBy]);
                this.mModifiedOn = AppShared.DbValueToDateTime(dr[Columns.WardModifiedOn]);
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
            using (SqlDataReader dr = AppDAL.WardSelect(key))
                r = dr != null && dr.Read() && this.Populate(dr);
            return r;

        }

        protected override bool InsertRecord()
        {
            Guid createdBy = AppContext.UserGuid;
            DateTime createdOn;

            bool r = AppDAL.WardInsert(this.mObjectGuid, this.mName, this.mDescription, createdBy, out createdOn);
            if (r)
            {
                //this.mCreatedBy = createdBy;
                this.mCreatedByUser = createdBy;
                this.mCreatedOn = createdOn;
                //this.mModifiedBy = createdBy;
                this.mModifiedByUser = createdBy;
                this.mModifiedOn = createdOn;
            }
            return r;
        }

        protected override bool UpdateRecord()
        {
            Guid modifiedBy = AppContext.UserGuid;
            DateTime modifiedOn;
            bool r = AppDAL.WardUpdate(this.mObjectGuid, this.mName,this.mDescription, modifiedBy, out modifiedOn);
            if (r)
            {
                //this.mModifiedBy = modifiedBy;
                this.mModifiedByUser = modifiedBy;
                this.mModifiedOn = modifiedOn;
            }
            return r;
        }

        protected override bool DeleteRecord()
        {
            return AppDAL.WardDelete(this.mObjectGuid);
        }

        protected override void Reset()
        {
            base.Reset();
            this.mName = string.Empty;
            this.mDescription = string.Empty;
        }
        #endregion
    }

   public sealed class Wards : ObjectCollection<Ward>
   {
       public Wards()
        {
            using (SqlDataReader dr = AppDAL.WardSelectAll())
            {
                LoadObjectsFromReader(dr);
            }
        }

       public Wards(string searchText)
        {
            using (SqlDataReader dr = AppDAL.WardSearch(searchText))
            {
                LoadObjectsFromReader(dr);
            }
        }
   }
}
