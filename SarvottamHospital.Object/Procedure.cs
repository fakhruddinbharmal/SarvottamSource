using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Security.Principal;

namespace SarvottamHospital.Object
{
    public sealed class Procedure : Objectbase
    {
        internal struct Columns
        {
            public const string ProcedureId = "ProcedureId";
            public const string PrecedureGuid = "PrecedureGuid";
            public const string ProcedureName = "ProcedureName";
            public const string ProcedureDescription = "ProcedureDescription";
            public const string ProcedureCreatedBy = "ProcedureCreatedBy";
            public const string ProcedureCreatedOn = "ProcedureCreatedOn";
            public const string ProcedureModifiedBy = "ProcedureModifiedBy";
            public const string ProcedureModifiedOn = "ProcedureModifiedOn";
        }

        #region Constructor

        public Procedure() : base() { }

        public Procedure(Guid key) : base(key) { }

        public Procedure(SqlDataReader dr) : base(dr) { }

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

            if (dr != null && AppShared.IsNotNull(dr[Columns.PrecedureGuid]))
            {
                this.mId = AppShared.DbValueToInteger(dr[Columns.ProcedureId]);
                this.mObjectGuid = AppShared.DbValueToGuid(dr[Columns.PrecedureGuid]);
                this.mName = AppShared.DbValueToString(dr[Columns.ProcedureName]);
                this.mDescription = AppShared.DbValueToString(dr[Columns.ProcedureDescription]);
                this.mCreatedByUser = AppShared.DbValueToGuid(dr[Columns.ProcedureCreatedBy]);
                this.mCreatedOn = AppShared.DbValueToDateTime(dr[Columns.ProcedureCreatedOn]);
                this.mModifiedByUser = AppShared.DbValueToGuid(dr[Columns.ProcedureModifiedBy]);
                this.mModifiedOn = AppShared.DbValueToDateTime(dr[Columns.ProcedureModifiedOn]);
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
            using (SqlDataReader dr = AppDAL.ProcedureSelect(key))
                r = dr != null && dr.Read() && this.Populate(dr);
            return r;

        }

        protected override bool InsertRecord()
        {
            Guid createdBy = AppContext.UserGuid;
            DateTime createdOn;

            bool r = AppDAL.ProcedureInsert(this.mObjectGuid, this.mName, this.mDescription, createdBy, out createdOn);
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
            bool r = AppDAL.ProcedureUpdate(this.mObjectGuid, this.mName, this.mDescription, modifiedBy, out modifiedOn);
            if (r)
            {
                this.mModifiedByUser = modifiedBy;
                this.mModifiedOn = modifiedOn;
            }
            return r;
        }

        protected override bool DeleteRecord()
        {
            return AppDAL.ProcedureDelete(this.mObjectGuid);
        }

        protected override void Reset()
        {
            base.Reset();
            this.mName = string.Empty;
            this.mDescription = string.Empty;
        }
        #endregion
    }

    public sealed class Procedures : ObjectCollection<Procedure>
    {
        public Procedures()
        {
            using (SqlDataReader dr = AppDAL.ProcedureSelectAll())
            {
                LoadObjectsFromReader(dr);
            }
        }

        public Procedures(string searchText)
        {
            using (SqlDataReader dr = AppDAL.ProcedureSearch(searchText))
            {
                LoadObjectsFromReader(dr);
            }
        }
    }
}
