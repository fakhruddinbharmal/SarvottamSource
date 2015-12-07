using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace SarvottamHospital.Object
{
    public sealed class OPDInvestigationProcedure : Objectbase
    {
        internal struct Columns
        { 
            public const string OPDInvestigationProcedureId             ="OPDInvestigationProcedureId";
            public const string OPDInvestigationProcedureGuid           ="OPDInvestigationProcedureGuid";
            public const string OPDInvestigationProcedurePatientGuid = "OPDInvestigationProcedurePatientGuid";
            public const string MainInvestigationGuid                   ="MainInvestigationGuid";
            public const string LabInvestigationGuid                    ="LabInvestigationGuid";
            public const string RadiologyInvestigation                  ="RadiologyInvestigation";
            public const string SpecialInvestigation                    ="SpecialInvestigation";
            public const string OPDInvestigationProcedureDate           ="OPDInvestigationProcedureDate";
            public const string OPDInvestigationProcedureCreatedBy      ="OPDInvestigationProcedureCreatedBy";
            public const string OPDInvestigationProcedureCreatedOn      ="OPDInvestigationProcedureCreatedOn"; 
            public const string OPDInvestigationProcedureModifiedBy     ="OPDInvestigationProcedureModifiedBy";
            public const string OPDInvestigationProcedureModifiedOn     ="OPDInvestigationProcedureModifiedOn";
            public const string MainInvestigation                       ="MainInvestigation";
            public const string LabInvestigation                        = "LabInvestigation";
        }

         #region Constructor

        public OPDInvestigationProcedure() : base() { }

        public OPDInvestigationProcedure(Guid key) : base(key) { }

        public OPDInvestigationProcedure(SqlDataReader dr) : base(dr) { }

        #endregion 
    
         #region Properties

        public override string DisplayName
        {
            get { return this.SpecialInvestigation; }
        }

        private string mRadiologyInvestigation;

        public string RadiologyInvestigation
        {
            get { return mRadiologyInvestigation; }
            set { mRadiologyInvestigation = value; }
        }

        private string mSpecialInvestigation;

        public string SpecialInvestigation
        {
            get { return mSpecialInvestigation; }
            set { mSpecialInvestigation = value; }
        }

        private DateTime mOPDInvestigationProcedureDate;

        public DateTime OPDInvestigationProcedureDate
        {
            get { return mOPDInvestigationProcedureDate; }
            set { mOPDInvestigationProcedureDate = value; }
        }

        private Guid mPatientGuid;

        public Guid PatientGuid
        {
            get { return mPatientGuid; }
            set { mPatientGuid = value; }
        }        

        //Main InvestigationListing 

        private string mMainInvestigation;

        public string MainInvestigation
        {
            get { return mMainInvestigation; }
            set { mMainInvestigation = value; }
        }

        //Main Investigation

        OPDMainInvestigations mOPDMainInvestigations;

        public OPDMainInvestigations OPDMainInvestigations
        {
            get {
                if (this.mOPDMainInvestigations == null)
                    this.mOPDMainInvestigations = new OPDMainInvestigations(this.ObjectGuid);            
                 return mOPDMainInvestigations; 
                }
            set { this.mOPDMainInvestigations = value; }
        }

        //Lab Investigation Listing

        private string mLabInvestigation;

        public string LabInvestigation
        {
            get { return mLabInvestigation; }
            set { mLabInvestigation = value; }
        }

        //Lab Investigation
        OPDLabInvestigations mOPDLabInvestigations;

        public OPDLabInvestigations OPDLabInvestigations
        {
            get {
                if (this.mOPDLabInvestigations == null)
                    this.mOPDLabInvestigations = new OPDLabInvestigations(this.ObjectGuid);
                    return mOPDLabInvestigations; 
                 }
            set { this.mOPDLabInvestigations = value; }
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

            if (dr != null && AppShared.IsNotNull(dr[Columns.OPDInvestigationProcedureGuid]))
            {
                this.mObjectGuid = AppShared.DbValueToGuid(dr[Columns.OPDInvestigationProcedureGuid]);
                this.mPatientGuid = AppShared.DbValueToGuid(dr[Columns.OPDInvestigationProcedurePatientGuid]);
                this.mRadiologyInvestigation = AppShared.DbValueToString(dr[Columns.RadiologyInvestigation]);
                this.mSpecialInvestigation = AppShared.DbValueToString(dr[Columns.SpecialInvestigation]);
                this.mOPDInvestigationProcedureDate = AppShared.DbValueToDateTime(dr[Columns.OPDInvestigationProcedureDate]);

                if (AppShared.HasColumn(dr, "MainInvestigation"))
                {
                    this.mMainInvestigation = AppShared.DbValueToString(dr[Columns.MainInvestigation]);
                }

                if (AppShared.HasColumn(dr, "LabInvestigation"))
                {
                    this.mLabInvestigation = AppShared.DbValueToString(dr[Columns.LabInvestigation]);
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
            using(SqlDataReader dr = AppDAL.OPDInvestigationProcedureSelect(key))
                r = dr != null && dr.Read() && this.Populate(dr);
            return r;
        }

        protected override bool InsertRecord()
        {
            Guid createdBy = AppContext.UserGuid;
            DateTime CreatedOn;

            bool r = AppDAL.OPDInvestigationProcedureInsert(this.mObjectGuid, this.mPatientGuid, this.RadiologyInvestigation, this.SpecialInvestigation,
                                                            this.mOPDInvestigationProcedureDate, createdBy, out CreatedOn);
            if (r)
            {
                this.mCreatedByUser = createdBy;
                this.mCreatedOn = CreatedOn;
                this.mModifiedByUser = createdBy;
                this.mModifiedOn = CreatedOn;
            }
            return r;
        }
        protected override bool UpdateRecord()
        {
             Guid modifiedBy = AppContext.UserGuid;
            DateTime modifiedOn;

            bool r = AppDAL.OPDInvestigationProcedureUpdate(this.mObjectGuid, this.mPatientGuid, this.RadiologyInvestigation, this.SpecialInvestigation,
                                                            this.mOPDInvestigationProcedureDate, modifiedBy, out modifiedOn);
            if (r)
            {
                this.mModifiedByUser = modifiedBy;
                this.mModifiedOn = modifiedOn;
            }
            return r;
        }
        protected override bool DeleteRecord()
        {
            return AppDAL.OPDInvestigationProcedureDelete(this.mObjectGuid);
        }
        protected override void Reset()
        {
            base.Reset();
            this.mObjectGuid = Guid.Empty;
        }
        protected override bool UpdateChild()
        {
            bool r = true;
            if (this.mOPDMainInvestigations != null)
            {
                using (SqlDataReader dr = AppDAL.OPDInvestigationProcedureMainInvestigationDelete(this.mObjectGuid))
                {

                }

            }
            if (this.mOPDMainInvestigations != null)
            {
                foreach (OPDInvestigationProcedureMainInvestigation item in this.mOPDMainInvestigations)
                {
                    item.ProcedureGuid = this.mObjectGuid;
                    item.MarkToSave();
                    item.UpdateChanges();
                }
            }
            if (this.mOPDLabInvestigations != null)
            {
                using (SqlDataReader dr = AppDAL.OPDInvestigationProcedureLabInvestigationDelete(this.mObjectGuid))
                {
 
                }
            }
            if (this.mOPDLabInvestigations != null)
            {
                foreach (OPDInvestigationProcedureLabInvestigation item in this.mOPDLabInvestigations)
                {
                    item.ProcedureGuid = this.mObjectGuid;
                    item.MarkToSave();
                    item.UpdateChanges();
                }
            }
            return r;
        }
        #endregion
    }
    public sealed class OPDInvestigationProcedureCollection : ObjectCollection<OPDInvestigationProcedure>
    {
        #region OPDInvestigationProcedure
        public OPDInvestigationProcedureCollection()
        { 
            using (SqlDataReader dr = AppDAL.OPDInvestigationProcedureSelectAll())
            {
                LoadObjectsFromReader(dr);
            }
        }        
        #endregion

        #region OPDInvestigationProcedure
        public OPDInvestigationProcedureCollection(Guid patientGuid)
        {
            using (SqlDataReader dr = AppDAL.OPDInvestigationProcedureSearch(patientGuid))
            {
                LoadObjectsFromReader(dr);
            }
        }
        #endregion
    }
}
