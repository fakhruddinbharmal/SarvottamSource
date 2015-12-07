using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace SarvottamHospital.Object
{
    public sealed class Appointment : Objectbase
    {
        internal struct Columns
        {
            public const string AppointmentGuid         =		"AppointmentGuid"; 	
            public const string AppointmentDate			=       "AppointmentDate";			    
            public const string AppointmentDescription	=       "AppointmentDescription";	
            public const string PatientGuid				=       "PatientGuid";			
            public const string AppointmentCreatedBy	=       "AppointmentCreatedBy";	
            public const string AppointmentCreatedOn	=       "AppointmentCreatedOn";	
            public const string AppointmentModifiedBy	=       "AppointmentModifiedBy";
            public const string AppointmentModifiedOn   =       "AppointmentModifiedOn";
        }

        #region Appointment

        public Appointment() : base() { }

        public Appointment(Guid key) : base(key) { }

        public Appointment(SqlDataReader dr) : base(dr) { }

        #endregion

        #region Properties

        public override string DisplayName
        {
            get { return this.AppointmentDescription; }
        }

        private DateTime mAppointmentDate;

        public DateTime AppointmentDate
        {
            get { return mAppointmentDate; }
            set { mAppointmentDate = value; }
        }

        private string mAppointmentDescription;

        public string AppointmentDescription
        {
            get { return mAppointmentDescription; }
            set { mAppointmentDescription = value; }
        }

        private Guid mPatientGuid;

        public Guid PatientGuid
        {
            get { return mPatientGuid; }
            set { mPatientGuid = value; }
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
            if (dr != null && AppShared.IsNotNull(dr[Columns.PatientGuid]))
            {
                this.mObjectGuid = AppShared.DbValueToGuid(dr[Columns.AppointmentGuid]);
                this.mPatientGuid = AppShared.DbValueToGuid(dr[Columns.PatientGuid]);
                this.mAppointmentDate = AppShared.DbValueToDateTime(dr[Columns.AppointmentDate]);
                this.mAppointmentDescription = AppShared.DbValueToString(dr[Columns.AppointmentDescription]);
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
            using (SqlDataReader dr = AppDAL.AppointmentSelect(key))
                r = dr != null && dr.Read() && this.Populate(dr);
            return r;
        }

        protected override bool InsertRecord()
        {
            Guid createdBy = AppContext.UserGuid;
            DateTime CreatedOn;

            bool r = AppDAL.AppointmentInsert(this.mPatientGuid, this.mObjectGuid, this.AppointmentDate, this.AppointmentDescription, createdBy, out CreatedOn);
            if (r)
            {
                this.mCreatedByUser = createdBy;
                this.mCreatedOn = CreatedOn;
                this.mModifiedByUser = createdBy;
                this.mModifiedOn = CreatedOn;
            }
            return r;
        }

        protected override bool DeleteRecord()
        {
            return AppDAL.AppointmentDelete(this.mObjectGuid);
        }

        protected override bool UpdateRecord()
        {
            Guid modifiedBy = AppContext.UserGuid;
            DateTime modifiedOn;

            bool r = AppDAL.AppointmentUpdate(this.mPatientGuid, this.mObjectGuid, this.AppointmentDate, this.AppointmentDescription, modifiedBy, out modifiedOn);
            if (r)
            {
                this.mModifiedByUser = modifiedBy;
                this.mModifiedOn = modifiedOn;
            }
            return r;
        }

        protected override void Reset()
        {
            base.Reset();
            this.mObjectGuid = Guid.Empty;
        }

        #endregion
    }

    public sealed class AppointmentCollection : ObjectCollection<Appointment>
    {
        #region AppointmentCollection
        public AppointmentCollection()
        {
            using (SqlDataReader dr = AppDAL.AppointmentSelectAll())
            {
                LoadObjectsFromReader(dr);
            }
        }
        #endregion

        #region AppointmentCollection
        public AppointmentCollection(Guid PatientGuid)
        {
            using (SqlDataReader dr = AppDAL.AppointmentSearch(PatientGuid))
            {
                LoadObjectsFromReader(dr);
            }
        }
        #endregion
    }
}
