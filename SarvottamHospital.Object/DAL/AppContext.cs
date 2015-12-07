using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Principal;
using SarvottamHospital.Object;

namespace SarvottamHospital.Object
{
    public static class AppContext
    {
        private static readonly object _lock = new object();

        private static User mUser = GetSystemUser();
        private static string mLastLoginUsername = string.Empty;

        private static Dictionary<Guid, CacheObject<Permission>> mUserPermissions;
        private static Dictionary<Guid, CacheObject<FieldPermission>> mUserFieldPermissions;

        public static bool Login(string username, string password)
        {
            mUser = new User(username, password);
            return IsUserLoggedIn;
        }

        public static bool RememberMe()
        {
            User user = LoggedUser;
            if (!Objectbase.IsNullOrEmpty(user))
                return user.UpdateWindowsUserName(SystemUsername);
            else
                return false;
        }

        public static bool ForgotMe()
        {
            User user = LoggedUser;
            if (!Objectbase.IsNullOrEmpty(user))
                return user.UpdateWindowsUserName(null);
            else
                return false;
        }

        public static void Logout()
        {
            mLastLoginUsername = Username;
            mUser = null;
            mUserRoleEntities = null;
            mUserPermissions = null;
            mUserFieldPermissions = null;
        }

        private static bool ChangePassword(string oldPwd, string newPwd)
        {
            return (IsUserLoggedIn && mUser.ChangePassword(oldPwd, newPwd));
        }

        public static bool IsUserLoggedIn
        {
            get
            {
                return (!Objectbase.IsNullOrEmpty(mUser) && mUser.IsLoggedIn);
            }
        }

        public static string LastLoginUsername
        {
            get { return mLastLoginUsername; }
        }

        public static string SystemUsername
        {
            get
            {
                WindowsIdentity wi = WindowsIdentity.GetCurrent();
                return (wi != null ? wi.Name : string.Format(@"{0}\{1})", Environment.MachineName, Environment.UserName));
            }
        }

        public static User GetSystemUser()
        {
            User r = new User(SystemUsername);
            if (Objectbase.IsNullOrEmpty(r))
                r = null;
            return r;
        }

        public static bool IsAdministrator
        {
            get
            {
                if (!Objectbase.IsNullOrEmpty(mUser) && !IsMainUser)
                {
                    User oUser = mUser;
                    UserRole oUserRole = mUser.UserRole;
                    if (oUserRole.UserRoleLevel == 1)
                        return true;
                    else
                        return false;
                }
                return false;
            }
        }

        public static bool IsMainUser
        {
            get
            {
                bool r = false;
                if (mUser != null)
                {
                    if (mUser.LoginName == User.MAIN_USER && mUser.Password == User.MAIN_PASSWORD)
                        r = true;
                    else
                        r = false;
                }
                return r;
            }
        }

        public static bool IsOtherEmployee
        {
            get
            {
                if (!Objectbase.IsNullOrEmpty(mUser) && !IsMainUser)
                {
                    User oUser = mUser;
                    UserRole oUserRole = mUser.UserRole;
                    if (oUserRole.UserRoleLevel == 0)
                        return true;
                    else
                        return false;
                }
                return false;
            }
        }

        public static string Username
        {
            get { return IsUserLoggedIn ? mUser.LoginName : string.Empty; }
        }

        public static string Fullname
        {
            get { return IsUserLoggedIn ? mUser.Name : string.Empty; }
        }

        public static byte[] UserPhoto
        {
            get { return IsUserLoggedIn ? mUser.Photo : null; }
        }

        public static Guid UserGuid
        {
            get { return IsUserLoggedIn ? mUser.ObjectGuid : Guid.Empty; }
        }

        public static Guid UserRoleGuid
        {
            get { return IsUserLoggedIn ? mUser.UserRoleGuid : Guid.Empty; }
        }

        public static User LoggedUser
        {
            get { return IsUserLoggedIn ? mUser : null; }
        }

        public static EntityCollection mUserRoleEntities;
        public static EntityCollection UserRoleEntities
        {
            get
            {
                if (IsUserLoggedIn && mUserRoleEntities == null)
                {
                    lock (_lock)
                    {
                        mUserRoleEntities = new EntityCollection(UserRoleGuid);
                    }
                }
                return mUserRoleEntities;
            }
        }

        public static FieldCollection mUserRoleFields;
        public static FieldCollection UserRoleFields
        {
            get
            {
                if (IsUserLoggedIn && mUserRoleFields == null)
                {
                    lock (_lock)
                    {
                        mUserRoleFields = new FieldCollection(UserRoleGuid);
                    }
                }
                return mUserRoleFields;
            }
        }

        internal static Permission GetPermission(Guid entityGuid)
        {
            Permission r = null;
            if (mUserPermissions == null)
            {
                lock (_lock)
                {
                    if (mUserPermissions == null)
                        mUserPermissions = new Dictionary<Guid, CacheObject<Permission>>();
                }
            }

            if (mUserPermissions != null)
            {
                if (mUserPermissions.ContainsKey(entityGuid))
                {
                    r = mUserPermissions[entityGuid].Item;
                }
                else
                {
                    r = new Permission(UserRoleGuid, entityGuid);
                    if (!Objectbase.IsNullOrEmpty(r))
                    {
                        mUserPermissions.Add(entityGuid, new CacheObject<Permission>(r));
                    }
                }

            }

            return r;
        }

        internal static FieldPermission GetFieldPermission(Guid fieldGuid)
        {
            FieldPermission r = null;
            if (mUserFieldPermissions == null)
            {
                lock (_lock)
                {
                    if (mUserFieldPermissions == null)
                        mUserFieldPermissions = new Dictionary<Guid, CacheObject<FieldPermission>>();
                }
            }

            if (mUserFieldPermissions != null)
            {
                if (mUserFieldPermissions.ContainsKey(fieldGuid))
                {
                    r = mUserFieldPermissions[fieldGuid].Item;
                }
                else
                {
                    r = new FieldPermission(UserRoleGuid, fieldGuid);
                    if (!Objectbase.IsNullOrEmpty(r))
                    {
                        mUserFieldPermissions.Add(fieldGuid, new CacheObject<FieldPermission>(r));
                    }
                }

            }

            return r;
        }

        public static bool CanView(Guid entityGuid)
        {
            if (IsAdministrator)
                return true;
            else
            {
                Permission p = GetPermission(entityGuid);
                return (Objectbase.IsNullOrEmpty(p) ? false : p.CanView);
            }
        }

        public static bool CanCreate(Guid entityGuid)
        {
            if (IsAdministrator)
                return true;
            else
            {
                Permission p = GetPermission(entityGuid);
                return (Objectbase.IsNullOrEmpty(p) ? false : p.CanCreate);
            }
        }

        public static bool CanEdit(Guid entityGuid)
        {
            if (IsAdministrator)
                return true;
            else
            {
                Permission p = GetPermission(entityGuid);
                return (Objectbase.IsNullOrEmpty(p) ? false : p.CanEdit);
            }
        }

        public static bool CanDelete(Guid entityGuid)
        {
            if (IsAdministrator)
                return true;
            else
            {
                Permission p = GetPermission(entityGuid);
                return (Objectbase.IsNullOrEmpty(p) ? false : p.CanDelete);
            }
        }

        public static bool CanSpecial(Guid entityGuid)
        {
            if (IsAdministrator)
                return true;
            else
            {
                Permission p = GetPermission(entityGuid);
                return (Objectbase.IsNullOrEmpty(p) ? false : p.CanSpecial);
            }
        }

        public static bool CanFieldView(Guid fieldGuid)
        {
            if (IsAdministrator)
                return true;
            else
            {
                FieldPermission p = GetFieldPermission(fieldGuid);
                return (Objectbase.IsNullOrEmpty(p) ? false : p.CanView);
            }
        }

    }

}
