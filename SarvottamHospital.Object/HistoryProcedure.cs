using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace SarvottamHospital.Object
{
    public sealed class HistoryProcedure : Objectbase
    {
        internal struct Columns
        {
            public const string HistoryProcedureId              = "HistoryProcedureId";
            public const string HistoryProcedureGuid            = "HistoryProcedureGuid";
            public const string HistoryProcedurePatientGuid     = "HistoryProcedurePatientGuid";
            public const string HistoryGuid                     = "HistoryGuid";
            public const string ChiefComplainGuid               = "ChiefComplainGuid";
            public const string AssociateComplainGuid           = "AssociateComplainGuid";
            public const string ProblemSince                    = "ProblemSince";
            public const string AssociateComplainDuration       = "AssociateComplainDuration";
            public const string FamilyHistory                   = "FamilyHistory";
            public const string FamilyHistoryDuration           = "FamilyHistoryDuration";
            public const string Date                            = "Date";
            public const string HistoryProcedureCreatedBy       = "HistoryProcedureCreatedBy";
            public const string HistoryProcedureCreatedOn       = "HistoryProcedureCreatedOn";
            public const string HistoryProcedureModifiedBy      = "HistoryProcedureModifiedBy";
            public const string HistoryProcedureModifiedOn      = "HistoryProcedureModifiedOn";
            public const string AssociateComplain               = "AssociateComplain";
            public const string ChiefComplain                   = "ChiefComplain";
            public const string History                         = "History";
        }

        #region Constructor

        public HistoryProcedure() : base() { }

        public HistoryProcedure(Guid key) : base(key) { }

        public HistoryProcedure(SqlDataReader dr) : base(dr) { }

        #endregion 
    
        #region Properties 

        public override string DisplayName
        {
            get { return this.AssociateComplainDuration; }
        }

        private string mProblemSince;

        public string ProblemSince
        {
            get { return mProblemSince; }
            set { mProblemSince = value; }
        }
        private string mAssociateComplainDuration;

        public string AssociateComplainDuration
        {
            get { return mAssociateComplainDuration; }
            set { mAssociateComplainDuration = value; }
        }
        private string mFamilyHistory;

        public string FamilyHistory
        {
            get { return mFamilyHistory; }
            set { mFamilyHistory = value; }
        }
        private string mFamilyHistoryDuration;

        public string FamilyHistoryDuration
        {
            get { return mFamilyHistoryDuration; }
            set { mFamilyHistoryDuration = value; }
        }

        private Guid mPatientGuid;
        public Guid PatientGuid
        {
            get { return this.mPatientGuid; }
            set { this.mPatientGuid = value; }
        }


        // History

        private string mHistory;

        public string History
        {
            get { return mHistory; }
            set { mHistory = value; }
        }

        // Chief Complain 

        private string mChiefComplain;

        public string ChiefComplain
        {
            get { return mChiefComplain; }
            set { mChiefComplain = value; }
        }
        
        //Associate 

        private string mAssociateComplain;

        public string AssociateComplain
        {
            get { return mAssociateComplain; }
            set { mAssociateComplain = value; }
        }
        
       
        private DateTime mDate;

        public DateTime Date
        {
            get { return mDate; }
            set { mDate = value; }
        }

        private Guid mHistoryProcedureCreatedBy;

        public Guid HistoryProcedureCreatedBy
        {
            get { return mHistoryProcedureCreatedBy; }
            set { mHistoryProcedureCreatedBy = value; }
        }

        private Guid mHistoryProcedureModifiedBy;

        public Guid HistoryProcedureModifiedBy
        {
            get { return mHistoryProcedureModifiedBy; }
            set { mHistoryProcedureModifiedBy = value; }
        }
        
        //ChiefComplain

        OPDChiefComplains mOPDChiefComplains;
        public OPDChiefComplains OPDChiefComplains
        {
            get
            {
                if (this.mOPDChiefComplains == null)
                    this.mOPDChiefComplains = new OPDChiefComplains(this.ObjectGuid);
                return mOPDChiefComplains;
            }
            set { this.mOPDChiefComplains = value; }
        }

        //Associate Complain

        OPDAssociateComplains mOPDAssociateComplains;

        public OPDAssociateComplains OPDAssociateComplains
        {
            get
            {
                if (this.mOPDAssociateComplains == null)
                    this.mOPDAssociateComplains = new OPDAssociateComplains(this.ObjectGuid);
                return mOPDAssociateComplains;
            }
            set { this.mOPDAssociateComplains = value; }
        }

        //History
        OPDHistorys mOPDHistorys;

        public OPDHistorys OPDHistorys
        {
            get
            {
                if (this.mOPDHistorys == null)
                    this.mOPDHistorys = new OPDHistorys(this.ObjectGuid);
                return mOPDHistorys;
            }
            set { this.mOPDHistorys = value; }
        }

        #endregion

        #region overridden

        internal override bool CreateRecord()
        {
            return base.CreateRecord();
        }

        internal override bool Populate(SqlDataReader dr)
        {
            bool r = false;

            if (dr != null && AppShared.IsNotNull(dr[Columns.HistoryProcedurePatientGuid]))
            {
                this.mObjectGuid = AppShared.DbValueToGuid(dr[Columns.HistoryProcedureGuid]);
                this.mPatientGuid = AppShared.DbValueToGuid(dr[Columns.HistoryProcedurePatientGuid]);
                this.mProblemSince = AppShared.DbValueToString(dr[Columns.ProblemSince]);
                this.mDate = AppShared.DbValueToDateTime(dr[Columns.Date]);
                this.mFamilyHistory = AppShared.DbValueToString(dr[Columns.FamilyHistory]);
                this.mAssociateComplainDuration =AppShared.DbValueToString(dr[Columns.AssociateComplainDuration]);
                this.mFamilyHistoryDuration = AppShared.DbValueToString(dr[Columns.FamilyHistoryDuration]);
                if (AppShared.HasColumn(dr, "History"))
                {
                    this.mHistory = AppShared.DbValueToString(dr[Columns.History]);
                }
                if (AppShared.HasColumn(dr, "ChiefComplain"))
                {
                    this.mChiefComplain = AppShared.DbValueToString(dr[Columns.ChiefComplain]);
                }
                if (AppShared.HasColumn(dr, "AssociateComplain"))
                {
                    this.mAssociateComplain = AppShared.DbValueToString(dr[Columns.AssociateComplain.ToString()]);
                }
                this.Status = ObjectStatus.Opened;
                r = true;

            }
            return r;
        }

        protected override bool OpenRecord(Guid key)
        {
            bool r = false;
            using (SqlDataReader dr = AppDAL.HistoryProcedureSelect(key))
                r = dr != null && dr.Read() && this.Populate(dr);
            return r;
        }

        protected override bool InsertRecord()
        {
            Guid createdBy = AppContext.UserGuid;
            DateTime CreatedOn;

            bool r = AppDAL.HistoryProcedureInsert(this.mObjectGuid,this.mPatientGuid,this.ProblemSince,this.AssociateComplainDuration,
                                                       this.FamilyHistory,this.FamilyHistoryDuration,this.Date, createdBy, out CreatedOn);
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

            bool r = AppDAL.HistoryProcedureUpdate(this.mObjectGuid,this.mPatientGuid, this.ProblemSince, this.AssociateComplainDuration,
                                                       this.FamilyHistory, this.FamilyHistoryDuration, this.Date, modifiedBy, out modifiedOn);
            if (r)
            {
                this.mModifiedByUser = modifiedBy;
                this.mModifiedOn = modifiedOn;
            }
            return r;
        }

        protected override bool DeleteRecord()
        {
            return AppDAL.HistoryProcedureDelete(this.mObjectGuid);
        }

        protected override void Reset()
        {
            base.Reset();
            this.mObjectGuid = Guid.Empty;           
        }

        protected override bool UpdateChild()
        {
            bool r = true;
            if (this.mOPDChiefComplains != null)
            {
                using (SqlDataReader dr = AppDAL.OPDHistoryProcedureChiefComplainDelete(this.mObjectGuid))
                {

                }
            }

            if (this.mOPDChiefComplains != null)
            {
                foreach (OPDHistoryProcedureChiefComplain item in this.mOPDChiefComplains)
                {
                    item.HistoryProcedureGuid = this.mObjectGuid;
                    item.MarkToSave();
                    item.UpdateChanges();

                }
            }

            if (this.mOPDAssociateComplains != null)
            { 
                using (SqlDataReader dr = AppDAL.OPDHistoryProcedureAssociateComplainDelete(this.mObjectGuid))
                { 
                
                }
            }

            if (this.mOPDAssociateComplains != null)
            {
                foreach (OPDHistoryProcedureAssociateComplain item in this.mOPDAssociateComplains)
                {
                    item.HistoryProcedureGuid = this.mObjectGuid;
                    item.MarkToSave();
                    item.UpdateChanges();
                }
                
            }

            if (this.mOPDHistorys != null)
            { 
                using (SqlDataReader dr = AppDAL.OPDHistoryProcedureHistoryDelete(this.mObjectGuid))
                { 
                
                }
            
            }
            if (this.mOPDHistorys != null)
            {
                foreach (OPDHistoryProcedureHistory item in this.mOPDHistorys)
                {
                    item.HistoryProcedureGuid = this.mObjectGuid;
                    item.MarkToSave();
                    item.UpdateChanges();
                }
            
            }
            return r;
        }
        #endregion       
    }

     public sealed class HistoryProcedureCollection : ObjectCollection<HistoryProcedure>
        {
            #region HistoryProcedureCollection
            public HistoryProcedureCollection()
            {
                using (SqlDataReader dr = AppDAL.HistoryProcedureSelectAll())
                {
                    LoadObjectsFromReader(dr);
                }
            }
            #endregion

            #region HistoryProcedureCollection
            public HistoryProcedureCollection(Guid patientGuid)
            {
                using (SqlDataReader dr = AppDAL.HistoryProcedureSearch(patientGuid))
                {
                    LoadObjectsFromReader(dr);
                }
            }
            #endregion
        }

     public sealed class HistoryProcedureCollections : ObjectCollection<HistoryProcedure>
     {
         #region HistoryProcedureCollection
         public HistoryProcedureCollections(Guid historyProcedureGuid)
         {
             using (SqlDataReader dr = AppDAL.HistoryProcedureSearch(historyProcedureGuid))
             {
                 LoadObjectsFromReader(dr);
             }
         }
         #endregion
     }
}
