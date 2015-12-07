using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SarvottamHospital.Object
{
    public abstract class Objectbase
    {

        #region Constructor

        /// <summary>Create new object if pass true otherwise empty object.</summary>
        public Objectbase()
        {
            this.Reset();
            this.CreateRecord();
        }

        public Objectbase(bool isNew)
        {
            if (isNew)
                this.CreateRecord();
            else
                this.Reset();
        }

        /// <summary>Open an object by key from database.</summary>
        public Objectbase(Guid key)
        {
            this.OpenRecord(key);
        }

        /// <summary>Open an object by reader.</summary>
        internal Objectbase(SqlDataReader dr)
        {
            this.Populate(dr);
        }

        #endregion

        #region Properties

        protected int mId;
        public int Id
        {
            get { return this.mId; }
        }

        protected Guid mObjectGuid;
        public Guid ObjectGuid
        {
            get { return this.mObjectGuid; }
        }


        protected Guid mObjectPatientGuid;
        public Guid ObjectPatientGuid
        {
            get { return this.mObjectPatientGuid; }
        }


        public abstract string DisplayName { get; }

        //protected string mCreatedBy;
        //public string CreatedBy
        //{
        //    get { return this.mCreatedBy; }
        //}

        protected DateTime mCreatedOn;
        public DateTime CreatedOn
        {
            get { return this.mCreatedOn; }
        }

        //protected string mModifiedBy;
        //public string ModifiedBy
        //{
        //    get { return this.mModifiedBy; }
        //}

        protected DateTime mModifiedOn;
        public DateTime ModifiedOn
        {
            get { return this.mModifiedOn; }
        }

        protected Guid mCreatedByUser;
        public Guid CreatedByUser
        {
            get {
                return this.mCreatedByUser;
            }
        }

        protected Guid mModifiedByUser;
        public Guid ModifiedByUser {
            get {
                return this.mModifiedByUser;
            }
        }

        private User mCreatedBy;
        public User CreatdBy
        {
            get
            {
                if (IsNullOrEmpty(this.mCreatedBy) || this.mCreatedBy.ObjectGuid != this.mCreatedByUser)
                    this.mCreatedBy = (this.mCreatedByUser != Guid.Empty ? new User(this.mCreatedByUser) : null);

                return this.mCreatedBy;
            }

            set
            {
                if (IsNullOrEmpty(value))
                {
                    this.mCreatedByUser = Guid.Empty;
                    this.mCreatedBy = null;
                }
                else
                {
                    this.mCreatedByUser = value.ObjectGuid;
                    this.mCreatedBy = value;
                }
            }
        }

        public string CreatedByName
        {
            get
            {
                User obj = this.CreatdBy;
                return (IsNullOrEmpty(obj) ? string.Empty : obj.LoginName);
            }
        }

        private User mModifiedBy;
        public User ModifiedBy
        {
            get
            {
                if (IsNullOrEmpty(this.mModifiedBy) || this.mModifiedBy.ObjectGuid != this.mModifiedByUser)
                    this.mModifiedBy = (this.mModifiedByUser != Guid.Empty ? new User(this.mModifiedByUser) : null);

                return this.mModifiedBy;
            }

            set
            {
                if (IsNullOrEmpty(value))
                {
                    this.mModifiedByUser = Guid.Empty;
                    this.mModifiedBy = null;
                }
                else
                {
                    this.mModifiedByUser = value.ObjectGuid;
                    this.mModifiedBy = value;
                }
            }
        }

        public string ModifiedByName
        {
            get
            {
                User obj = this.ModifiedBy;
                return (IsNullOrEmpty(obj) ? string.Empty : obj.LoginName);
            }
        }

        public bool IsOpen
        {
            get { return this.mStatus == ObjectStatus.Opened; }
        }

        public bool IsNew
        {
            get { return this.mStatus == ObjectStatus.NewOne; }
        }

        public bool IsUsable
        {
            get { return this.mStatus != ObjectStatus.None; }
        }

        public bool IsViewable
        {
            get { return (this.IsNew ? this.mAction == ObjectAction.Save : this.mAction != ObjectAction.Delete); }
        }

        public bool IsDeleteable
        {
            get { return (this.IsNew && this.mAction == ObjectAction.Save) || (this.IsOpen && this.mAction != ObjectAction.Delete); }
        }

        private ObjectStatus mStatus;
        internal ObjectStatus Status
        {
            get { return this.mStatus; }
            set { this.mStatus = value; }
        }

        private ObjectAction mAction;

        public Permission GetPermission()
        {
            return AppContext.GetPermission(this.GetType().GUID);
        }

        public bool UserCanView
        {
            get
            {
                if (AppContext.IsAdministrator)
                {
                    return true;
                }
                else
                {
                    Permission p = this.GetPermission();
                    return (!IsNullOrEmpty(p) && p.CanView);
                }
            }
        }

        public bool UserCanCreate
        {
            get
            {
                if (AppContext.IsAdministrator)
                {
                    return true;
                }
                else
                {
                    Permission p = this.GetPermission();
                    return (!IsNullOrEmpty(p) && p.CanCreate);
                }
            }
        }

        public bool UserCanEdit
        {
            get
            {
                if (AppContext.IsAdministrator)
                {
                    return true;
                }
                else
                {
                    Permission p = this.GetPermission();
                    return (!IsNullOrEmpty(p) && p.CanEdit);
                }
            }
        }

        public bool UserCanDelete
        {
            get
            {
                if (AppContext.IsAdministrator)
                {
                    return true;
                }
                else
                {
                    Permission p = this.GetPermission();
                    return (!IsNullOrEmpty(p) && p.CanDelete);
                }
            }
        }

        public bool UserCanSpecial
        {
            get
            {
                if (AppContext.IsAdministrator)
                {
                    return true;
                }
                else
                {
                    Permission p = this.GetPermission();
                    return (!IsNullOrEmpty(p) && p.CanSpecial);
                }
            }
        }


        #endregion

        #region Methods

        public override string ToString()
        {
            return this.mObjectGuid.ToString();
        }

        public override bool Equals(object obj)
        {
            if (object.ReferenceEquals(this, obj))
                return true;
            else
            {
                Objectbase that = obj as Objectbase;
                return (that != null && this.mObjectGuid == that.mObjectGuid);
            }

        }

        public override int GetHashCode()
        {
            return this.mObjectGuid.GetHashCode();
        }

        public static bool IsNullOrEmpty(Objectbase obj)
        {
            return obj == null || (!obj.IsUsable);
        }

        public bool MarkToSave()
        {
            bool r = this.IsUsable;
            if (r)
                this.mAction = ObjectAction.Save;
            return r;
        }

        public bool MarkToDelete()
        {
            bool r = this.IsUsable;
            if (r)
                this.mAction = ObjectAction.Delete;
            return r;
        }

        public bool UpdateChanges()
        {
            bool r = false;

            if (this.IsUsable)
            {
                if (this.mAction == ObjectAction.Save || this.mAction == ObjectAction.Delete)
                {
                    bool hasTransaction = (AppDAL.HasTransaction ? false : AppDAL.BiginTransaction());

                    switch (this.mAction)
                    {
                        case ObjectAction.Save:
                            r = (this.IsNew ? this.InsertRecord() : this.UpdateRecord()) && this.UpdateChild();
                            if (r)
                                this.mStatus = ObjectStatus.Opened;
                            break;
                        case ObjectAction.Delete:
                            r = (this.IsOpen ? this.UpdateChild() && this.DeleteRecord() : true);
                            if (r)
                                this.Reset();
                            break;
                        default:
                            r = true;
                            break;
                    }

                    if (hasTransaction)
                    {
                        if (r)
                            AppDAL.OKTransaction();
                        else
                            AppDAL.CancelTransaction();
                    }

                }
                else
                    r = true;
            }

            return r;
        }

        public bool RefershData()
        {
            return this.IsOpen && this.OpenRecord(this.mObjectGuid);
        }

        #endregion

        #region Abstract or Virtual

        internal virtual bool CreateRecord()
        {
            this.mId = 0;
            this.mObjectGuid = Guid.NewGuid();

            this.mStatus = ObjectStatus.NewOne;
            return true;
        }

        internal abstract bool Populate(SqlDataReader dr);

        protected abstract bool OpenRecord(Guid key);

        protected abstract bool InsertRecord();

        protected abstract bool UpdateRecord();

        protected abstract bool DeleteRecord();

        protected virtual bool UpdateChild() { return true; }

        protected virtual void Reset()
        {
            this.mId = 0;
            this.mObjectGuid = Guid.Empty;
            this.mObjectPatientGuid = Guid.Empty;
            //this.mCreatedBy = string.Empty;
            this.mCreatedByUser = Guid.Empty;
            this.mCreatedOn = DateTime.MinValue;
           // this.mModifiedBy = string.Empty;
            this.mModifiedByUser = Guid.Empty;
            this.mModifiedOn = DateTime.MinValue;
            this.mStatus = ObjectStatus.None;
            this.mAction = ObjectAction.None;
        }

        #endregion

        #region Static

        public static string GetName(Objectbase obj)
        {
            return (IsNullOrEmpty(obj) ? string.Empty : obj.DisplayName);
        }

        #endregion

    }


    public class ObjectCollection<T> : System.Collections.ObjectModel.Collection<T> where T : Objectbase
    {
        protected void LoadObjectsFromReader(SqlDataReader dr)
        {
            if (dr != null)
            {
                while (dr.Read())
                {
                    //T obj = Activator.CreateInstance<T>();
                    T obj = Activator.CreateInstance(typeof(T), new object[] { dr }) as T;
                    if (!Objectbase.IsNullOrEmpty(obj))
                        this.Add(obj);
                }
            }
        }
    }
}
