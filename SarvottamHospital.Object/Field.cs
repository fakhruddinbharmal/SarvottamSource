using System;
using System.Collections.Generic;

using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SarvottamHospital.Object
{
    public sealed class Field : Objectbase
    {
        internal struct Columns
        {
            public const string Id = "FieldId";
            public const string Guid = "FieldGuid";
            public const string Name = "FieldName";
        }

        #region Constructor

        public Field() : base() { }

        public Field(Guid key) : base(key) { }

        public Field(SqlDataReader dr) : base(dr) { }

        #endregion

        #region Property

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

        #endregion

        #region Overiden

        internal override bool CreateRecord()
        {
            return base.CreateRecord();
        }

        internal override bool Populate(System.Data.SqlClient.SqlDataReader dr)
        {
            bool r = false;

            if (dr != null && AppShared.IsNotNull(dr[Columns.Id]))
            {
                this.mId = AppShared.DbValueToInteger(dr[Columns.Id]);
                this.mObjectGuid = AppShared.DbValueToGuid(dr[Columns.Guid]);
                this.mName = AppShared.DbValueToString(dr[Columns.Name]);
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
            using (SqlDataReader dr = AppDAL.FieldSelect(key))
                r = dr != null && dr.Read() && this.Populate(dr);
            return r;
        }

        protected override bool InsertRecord()
        {
            int newid;
            Guid createdBy = AppContext.UserGuid;
            bool r = AppDAL.FieldInsert(this.mObjectGuid, this.mName, out newid);
            if (r)
            {
                this.mId = newid;
                this.mModifiedByUser = createdBy;
            }
            return r;
        }

        protected override bool UpdateRecord()
        {
            Guid modifiedBy = AppContext.UserGuid;
            DateTime modifiedOn;
            bool r = AppDAL.FieldUpdate(this.mObjectGuid, this.mName);
            if (r)
            {
                this.mModifiedByUser = modifiedBy;
            }
            return r;
        }

        protected override bool DeleteRecord()
        {
            return AppDAL.EntityDelete(this.mObjectGuid);
        }

        protected override void Reset()
        {
            base.Reset();
            this.Name = string.Empty;
        }
        #endregion
    }

    public sealed class FieldCollection : ObjectCollection<Field>
    {
        public FieldCollection()
        {
            using (SqlDataReader dr = AppDAL.FieldSelectAll())
            {
                LoadObjectsFromReader(dr);
            }
        }

        public FieldCollection(Guid userRoleGuid)
        {
            using (SqlDataReader dr = AppDAL.FieldPermissionSelectByUser(userRoleGuid))
            {
                LoadObjectsFromReader(dr);
            }
        }

    }
}
