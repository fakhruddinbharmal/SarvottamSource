using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Security.Principal;
using System.Text;
namespace SarvottamHospital.Object
{
    public sealed class User : Objectbase
    {
        public static readonly string MAIN_USER = "superman";
        public static readonly string MAIN_PASSWORD = "superman";

        internal struct Columns
        {
            public const string UserId = "UserId";
            public const string UserGuid = "UserGuid";
            public const string UserName = "UserName";
            public const string UserLoginName = "UserLoginName";
            public const string UserRoleGuid = "UserRoleGuid";
            public const string UserPassword = "UserPassword";
            public const string UserAddressLine1 = "UserAddressLine1";
            public const string UserAddressLine2 = "UserAddressLine2";
            public const string UserAddressLine3 = "UserAddressLine3";
            public const string UserPhoneNo = "UserPhoneNo";
            public const string UserMobileNo = "UserMobileNo";
            public const string UserWindowsUserName = "UserWindowsUserName";
            public const string UserPhoto = "Userphoto";
            public const string UserDesc = "UserDesc";
            public const string DoctorShare = "DoctorShare";
            public const string UserIsDisable = "UserIsDisable";
            public const string UserCreatedOn = "UserCreatedOn";
            public const string UserCreatedBy = "UserCreatedBy";
            public const string UserModifiedOn = "UserModifiedOn";
            public const string UserModifiedBy = "UserModifiedBy";
            public const string UserRowStamp = "UserRowStamp";

        }

        #region Constructor

        public User() : base() { }

        public User(Guid key) : base(key) { }

        public User(SqlDataReader dr) : base(dr) { }

        public User(string winUsername)
        {
            using (SqlDataReader dr = AppDAL.UserSelectByWinUsername(winUsername))
            {
                this.mIsLoggedIn = (dr != null && dr.Read() && this.Populate(dr));
            }
        }

        public User(string userName, string password)
        {
            using (SqlDataReader dr = AppDAL.UserLogin(userName, GetHashString(password)))
            {
                this.mIsLoggedIn = (dr != null && dr.Read() && this.Populate(dr));
            }
            if (userName == MAIN_USER && password == MAIN_PASSWORD)
            {
                this.mName = MAIN_USER;
                this.mPassword = MAIN_PASSWORD;
                this.LoginName = MAIN_USER;
                this.mIsLoggedIn = true;
            }

        }

        #endregion

        #region Properties

        public override string DisplayName
        {
            get { return this.mName; }
        }

        private bool mIsLoggedIn;
        public bool IsLoggedIn
        {
            get { return this.mIsLoggedIn; }
            internal set { this.mIsLoggedIn = value; }
        }

        private string mName;
        public string Name
        {
            get { return this.mName; }
            set { this.mName = value; }
        }

        private string mWindowsUserName;
        public string WindowsUserName
        {
            get { return this.mWindowsUserName; }
            set { this.mWindowsUserName = value; }
        }

        private string mDescription;
        public string Description
        {
            get { return this.mDescription; }
            set { this.mDescription = value; }
        }

        private decimal mDoctorShare;
        public decimal DoctorShare
        {
            get { return this.mDoctorShare; }
            set { this.mDoctorShare = value; }
        }
        private string mLoginName;
        public string LoginName
        {
            get { return this.mLoginName; }
            set { this.mLoginName = value; }
        }

        private string mPassword;
        public string Password
        {
            get { return this.mPassword; }
            set { this.mPassword = value; }
        }

        private string mAddressLine1;
        public string AddressLine1
        {
            get { return this.mAddressLine1; }
            set { this.mAddressLine1 = value; }
        }

        private string mAddressLine2;
        public string AddressLine2
        {
            get { return this.mAddressLine2; }
            set { this.mAddressLine2 = value; }
        }

        private string mAddressLine3;
        public string AddressLine3
        {
            get { return this.mAddressLine3; }
            set { this.mAddressLine3 = value; }
        }

        private string mPhoneNo;
        public string PhoneNo
        {
            get { return this.mPhoneNo; }
            set { this.mPhoneNo = value; }

        }

        private string mMobileNo;
        public string MobileNo
        {
            get { return this.mMobileNo; }
            set { this.mMobileNo = value; }

        }

        private byte[] mPhoto;
        public byte[] Photo
        {
            get { return this.mPhoto; }
            set { this.mPhoto = value; }
        }

        private bool mIsDisabled;
        public bool IsDisabled
        {
            get { return this.mIsDisabled; }
            set { this.mIsDisabled = value; }
        }

        private Guid mUserRoleGuid;
        public Guid UserRoleGuid
        {
            get { return this.mUserRoleGuid; }
            set { this.mUserRoleGuid = value; }
        }

        private UserRole mUserRole;
        public UserRole UserRole
        {
            get
            {
                if (IsNullOrEmpty(this.mUserRole) || this.mUserRole.ObjectGuid != this.mUserRoleGuid)
                    this.mUserRole = (this.mUserRoleGuid != Guid.Empty ? new UserRole(this.mUserRoleGuid) : null);

                return this.mUserRole;
            }

            set
            {
                if (IsNullOrEmpty(value))
                {
                    this.mUserRoleGuid = Guid.Empty;
                    this.mUserRole = null;
                }
                else
                {
                    this.mUserRoleGuid = value.ObjectGuid;
                    this.mUserRole = value;
                }
            }
        }

        public string UserRoleName
        {
            get
            {
                UserRole obj = this.mUserRole;
                return (IsNullOrEmpty(obj) ? string.Empty : obj.UserRoleName);
            }
        }

        public override string ToString()
        {
            return this.mName;
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

            if (dr != null && AppShared.IsNotNull(dr[Columns.UserGuid]))
            {
                this.mId = AppShared.DbValueToInteger(dr[Columns.UserId]);
                this.mObjectGuid = AppShared.DbValueToGuid(dr[Columns.UserGuid]);
                this.mName = AppShared.DbValueToString(dr[Columns.UserName]);
                this.mLoginName = AppShared.DbValueToString(dr[Columns.UserLoginName]);
                this.mUserRoleGuid = AppShared.DbValueToGuid(dr[Columns.UserRoleGuid]);
                this.mPassword = AppShared.DbValueToString(dr[Columns.UserPassword]);
                this.mAddressLine1 = AppShared.DbValueToString(dr[Columns.UserAddressLine1]);
                this.mAddressLine2 = AppShared.DbValueToString(dr[Columns.UserAddressLine2]);
                this.mAddressLine3 = AppShared.DbValueToString(dr[Columns.UserAddressLine3]);
                this.mPhoneNo = AppShared.DbValueToString(dr[Columns.UserPhoneNo]);
                this.mMobileNo = AppShared.DbValueToString(dr[Columns.UserMobileNo]);
                this.mPhoto = AppShared.DbValueToBytes(dr, Columns.UserPhoto);
                this.mWindowsUserName = AppShared.DbValueToString(dr[Columns.UserWindowsUserName]);
                // this.mIsBlocked = AppShared.DbValueToBoolean(dr[Columns.UserIsDisable]);
                this.mIsDisabled = AppShared.DbValueToBoolean(dr[Columns.UserIsDisable]);
                this.mDescription = AppShared.DbValueToString(dr[Columns.UserDesc]);
                this.mDoctorShare = AppShared.DbValueToDecimal(dr[Columns.DoctorShare]);
                this.mCreatedByUser = AppShared.DbValueToGuid(dr[Columns.UserCreatedBy]);
                this.mCreatedOn = AppShared.DbValueToDateTime(dr[Columns.UserCreatedOn]);
                this.mModifiedByUser = AppShared.DbValueToGuid(dr[Columns.UserModifiedBy]);
                this.mModifiedOn = AppShared.DbValueToDateTime(dr[Columns.UserModifiedOn]);
                //dr.GetBytes(dr.GetOrdinal(Columns.UserRowStamp), 0, this.mRowStamp, 0, 8);

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
            using (SqlDataReader dr = AppDAL.UserSelect(key))
                r = dr != null && dr.Read() && this.Populate(dr);
            return r;

        }

        protected override bool InsertRecord()
        {
            int newid;
            Guid createdBy = AppContext.UserGuid;
            DateTime createdOn;

            bool r = AppDAL.UserInsert(this.mObjectGuid, this.mName, this.mLoginName, this.mUserRoleGuid, this.mPassword, this.mAddressLine1, this.mAddressLine2, this.mAddressLine3, this.mPhoneNo, this.mMobileNo, this.mPhoto, this.mDescription, this.mDoctorShare, this.mIsDisabled, createdBy, out createdOn, out newid);
            if (r)
            {
                this.mId = newid;
                //this.mCreatedBy = createdBy;
                this.mCreatedOn = createdOn;
               // this.mModifiedBy = createdBy;
                this.mModifiedOn = createdOn;
            }
            return r;
        }

        protected override bool UpdateRecord()
        {
            Guid modifiedBy = AppContext.UserGuid;
            DateTime modifiedOn;
            bool r = AppDAL.UserUpdate(this.mObjectGuid, this.mName, this.mLoginName, this.mUserRoleGuid, this.mPassword, this.mAddressLine1, this.mAddressLine2, this.mAddressLine3, this.mPhoneNo, this.mMobileNo, this.mPhoto, this.mDescription, this.mDoctorShare, this.mIsDisabled, modifiedBy, out modifiedOn);
            if (r)
            {
               // this.mModifiedBy = modifiedBy;
                this.mModifiedOn = modifiedOn;
            }
            return r;
        }

        protected override bool DeleteRecord()
        {
            return AppDAL.UserDelete(this.mObjectGuid);
        }

        protected override void Reset()
        {
            base.Reset();
            this.mUserRoleGuid = Guid.Empty;
            this.mLoginName = string.Empty;
            this.mPassword = string.Empty;
            this.mAddressLine1 = string.Empty;
            this.mAddressLine2 = string.Empty;
            this.mAddressLine3 = string.Empty;
            this.mPhoneNo = string.Empty;
            this.mMobileNo = string.Empty;
            this.mPhoto = null;
        }

        public bool UpdateWindowsUserName(string winUsername)
        {
            bool r = AppDAL.UserUpdateWindowsUserName(this.ObjectGuid, winUsername);
            if (r)
                this.mWindowsUserName = winUsername;
            return r;
        }

        #endregion

        public bool ChangePassword(string oldPassword, string newPassword)
        {
            bool r = AppDAL.ChangePassword(this.ObjectGuid, GetHashString(oldPassword), GetHashString(newPassword));
            if (r)
                this.Password = newPassword;
            return r;
        }

        public bool ResetPassword(string newPassword)
        {
            bool r = AppDAL.ChangePassword(this.ObjectGuid, this.Password, GetHashString(newPassword));
            if (r)
                this.Password = newPassword;
            return r;
        }

        public bool CheckAvailability(string username)
        {
            return AppDAL.CheckUsernameAvailibity(username, (this.IsNew ? Guid.Empty : this.mObjectGuid));
        }

        private static string GetHashString(string source)
        {
            if (source == null || source.Length <= 0)
                return string.Empty;

            System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] tmpSource;
            byte[] tmpHash;

            tmpSource = ASCIIEncoding.ASCII.GetBytes(source); // Turn source into byte array
            tmpHash = md5.ComputeHash(tmpSource);

            StringBuilder sOuput = new StringBuilder(tmpHash.Length);
            for (int i = 0, j = tmpHash.Length; i < j; i++)
            {
                sOuput.Append(tmpHash[i].ToString("X2"));  // X2 formats to hexadecimal
            }
            return sOuput.ToString();
        }
    }
    public sealed class Users : ObjectCollection<User>
    {
        public Users()
        {
            using (SqlDataReader dr = AppDAL.UserSelectAll())
            {
                LoadObjectsFromReader(dr);
            }
        }

        public Users(string searchText)
        {
            using (SqlDataReader dr = AppDAL.UserSearch(searchText))
            {
                LoadObjectsFromReader(dr);
            }
        }

        public Users(Guid userGuid)
        {
            using (SqlDataReader dr = AppDAL.UserSelectByRoleLevel(userGuid))
            {
                LoadObjectsFromReader(dr);
            }
        }

        public Users(Guid userGuid, string searchText)
        {
            using (SqlDataReader dr = AppDAL.UserSelectForAdmin(userGuid))
            {
                LoadObjectsFromReader(dr);
            }
        }

        public Users(string RoleName, string text)
        {
            using (SqlDataReader dr = AppDAL.UserSelectByRoleName(RoleName, text))
            {
                LoadObjectsFromReader(dr);
            }
        }
    }
}
