using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace SarvottamHospital.Object
{
    public sealed class     OPDTreatmentProcedure : Objectbase
    {
        internal struct Columns
        {
            public const string OPDTreatmentProcedureId             = "OPDTreatmentProcedureId";
            public const string OPDTreatmentProcedureGuid            = "OPDTreatmentProcedureGuid";
            public const string OPDTreatmentProcedurePatientGuid    = "OPDTreatmentProcedurePatientGuid";
            public const string OPDTreatmentDate                    = "OPDTreatmentDate";
            public const string OPDTreatmentCreatedBy               = "OPDTreatmentCreatedBy";
            public const string OPDTreatmentCreatedOn               = "OPDTreatmentCreatedOn";
            public const string OPDTreatmentModifiedBy              = "OPDTreatmentModifiedBy";
            public const string OPDTreatmentModifiedOn              = "OPDTreatmentModifiedOn";
            public const string Treatment                           = "Treatment";
        }

        #region Constructor

        public OPDTreatmentProcedure() : base() { }

        public OPDTreatmentProcedure(Guid Key) : base(Key) { }

        public OPDTreatmentProcedure(SqlDataReader dr) : base(dr) { }

        #endregion

        #region Properties

        public override string DisplayName
        {
            get { return string.Empty; }
        }

        private DateTime mOPDTreatmentDate;

        public DateTime OPDTreatmentDate
        {
            get { return mOPDTreatmentDate; }
            set { mOPDTreatmentDate = value; }
        }
      
        private Guid mPatientGuid;

        public Guid PatientGuid
        {
            get { return this.mPatientGuid; }
            set { this.mPatientGuid = value; }
        }
        

        //Treatment For Listing

        private string mTreatment;

        public string Treatment
        {
            get { return mTreatment; }
            set { mTreatment = value; }
        }

        // Treatment 

        OPDTreatments mOPDTreatments;

        public OPDTreatments OPDTreatments
        {
            get {
                if (this.mOPDTreatments == null)
                    this.mOPDTreatments = new OPDTreatments(this.ObjectGuid);
                return mOPDTreatments; 
                }
            set { this.mOPDTreatments = value; }
        }
        
        #endregion

        #region Overridden

        internal override bool CreateRecord()
        {
            return base.CreateRecord();
        }

        internal override bool Populate(SqlDataReader dr)
        {
            bool r = false;
            if (dr != null && AppShared.IsNotNull(dr[Columns.OPDTreatmentProcedureGuid]))
            {
                this.mObjectGuid = AppShared.DbValueToGuid(dr[Columns.OPDTreatmentProcedureGuid]);
                this.mPatientGuid = AppShared.DbValueToGuid(dr[Columns.OPDTreatmentProcedurePatientGuid]);
                this.mOPDTreatmentDate = AppShared.DbValueToDateTime(dr[Columns.OPDTreatmentDate]);

                if (AppShared.HasColumn(dr, "Treatment"))
                {
                    this.mTreatment = AppShared.DbValueToString(dr[Columns.Treatment]);
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
            using(SqlDataReader dr = AppDAL.TreatmentProcedureSelect(key))
                r = dr != null && dr.Read() && this.Populate(dr);
            return r;
        }

        protected override bool InsertRecord()
        {
            Guid createdBy = AppContext.UserGuid;
            DateTime CreatedOn;
            bool r = AppDAL.TreatmentProcedureInsert(this.mObjectGuid, this.mPatientGuid, this.mOPDTreatmentDate, createdBy, out CreatedOn);
            if (r)
            {
                this.mCreatedByUser=createdBy;
                this.mCreatedOn = CreatedOn;
                this.mModifiedByUser=createdBy;
                this.mModifiedOn = CreatedOn;
            }
            return r;
        }

        protected override bool UpdateRecord()
        {
            Guid modifiedBy = AppContext.UserGuid;
            DateTime modifiedOn;
            bool r = AppDAL.TreatmentProcedureUpdate(this.mObjectGuid, this.mPatientGuid, this.mOPDTreatmentDate, modifiedBy, out modifiedOn);
            if (r)
            {
                this.mModifiedByUser = modifiedBy;
                this.mModifiedOn = modifiedOn;
            }
            return r;
        }

        protected override bool DeleteRecord()
        {
            return AppDAL.TreatmentProcedureDelete(this.mObjectGuid);
        }

        protected override void Reset()
        {
            base.Reset();
            this.mObjectGuid = Guid.Empty;
        }

        protected override bool UpdateChild()
        {
            bool r = true;
            if (this.mOPDTreatments != null)
            {
                using (SqlDataReader dr = AppDAL.OPDTreatmentProcedureTreatmentDelete(this.mObjectGuid))
                { 
                    
                }
            }
            if (this.mOPDTreatments != null)
            {
                foreach (OPDTreatmentProcedureTreatment item in this.mOPDTreatments)
                {
                    item.TreatmentProcedureGuid = this.mObjectGuid;
                    item.MarkToSave();
                    item.UpdateChanges();
                }
            }
            return r;
        }

        #endregion
    }
    public sealed class OPDTreatmentProcedureCollection : ObjectCollection<OPDTreatmentProcedure>
    {
        #region OPDTreatmentProcedureCollection

        public OPDTreatmentProcedureCollection()
        {
            using (SqlDataReader dr = AppDAL.TreatmentProcedureSelectAll())
            {
                LoadObjectsFromReader(dr);
            }
        }
        #endregion

        #region OPDTreatmentProcedureCollection

        public OPDTreatmentProcedureCollection(Guid PatientGuid)
        {
            using (SqlDataReader dr = AppDAL.TreatmentProcedureSearch(PatientGuid))
            {
                LoadObjectsFromReader(dr);
            }
        }
        #endregion
    }
}
