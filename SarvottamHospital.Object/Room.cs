using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace SarvottamHospital.Object
{
    public sealed class Room : Objectbase
    {
        internal struct Columns
        {
            public const string RoomId = "RoomId";
            public const string RoomGuid = "RoomGuid";
            public const string RoomType = "RoomType";
            public const string RoomDescription = "RoomDescription";
            public const string RoomCreatedBy = "RoomCreatedBy";
            public const string RoomCreatedOn = "RoomCreatedOn";
            public const string RoomModifiedBy = "RoomModifiedBy";
            public const string RoomModifiedOn = "RoomModifiedOn";
        }

        #region Constructor

        public Room() : base() { }

        public Room(Guid key) : base(key) { }

        public Room(SqlDataReader dr) : base(dr) { }

        #endregion

        #region properties

        public override string DisplayName
        {
            get { return this.mType; }
        }

        private string mType;
        public string Type
        {
            get { return this.mType; }
            set { this.mType = value; }
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

            if (dr != null && AppShared.IsNotNull(dr[Columns.RoomGuid]))
            {
                this.mId = AppShared.DbValueToInteger(dr[Columns.RoomId]);
                this.mObjectGuid = AppShared.DbValueToGuid(dr[Columns.RoomGuid]);
                this.mType = AppShared.DbValueToString(dr[Columns.RoomType]);
                this.mDescription = AppShared.DbValueToString(dr[Columns.RoomDescription]);
                this.mCreatedByUser = AppShared.DbValueToGuid(dr[Columns.RoomCreatedBy]);
                this.mCreatedOn = AppShared.DbValueToDateTime(dr[Columns.RoomCreatedOn]);
                this.mModifiedByUser = AppShared.DbValueToGuid(dr[Columns.RoomModifiedBy]);
                this.mModifiedOn = AppShared.DbValueToDateTime(dr[Columns.RoomModifiedOn]);
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
            using (SqlDataReader dr = AppDAL.RoomSelect(key))
                r = dr != null && dr.Read() && this.Populate(dr);
            return r;

        }

        protected override bool InsertRecord()
        {
            Guid createdBy = AppContext.UserGuid;
            DateTime createdOn;

            bool r = AppDAL.RoomInsert(this.mObjectGuid, this.mType, this.mDescription, createdBy, out createdOn);
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
            bool r = AppDAL.RoomUpdate(this.mObjectGuid, this.mType, this.mDescription, modifiedBy, out modifiedOn);
            if (r)
            {
                this.mModifiedByUser = modifiedBy;
                this.mModifiedOn = modifiedOn;
            }
            return r;
        }

        protected override bool DeleteRecord()
        {
            return AppDAL.RoomDelete(this.mObjectGuid);
        }

        protected override void Reset()
        {
            base.Reset();
            this.mType = string.Empty;
            this.mDescription = string.Empty;
        }
        #endregion
    }

    public sealed class Rooms : ObjectCollection<Room>
    {
        public Rooms()
        {
            using (SqlDataReader dr = AppDAL.RoomSelectAll())
            {
                LoadObjectsFromReader(dr);
            }
        }

        public Rooms(string searchText)
        {
            using (SqlDataReader dr = AppDAL.RoomSearch(searchText))
            {
                LoadObjectsFromReader(dr);
            }
        }
    }
}
