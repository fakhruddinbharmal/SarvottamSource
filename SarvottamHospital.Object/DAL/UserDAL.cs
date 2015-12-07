using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web;

namespace SarvottamHospital.Object
{
    internal static partial class AppDAL
    {
        private const string User_Insert = "User_Insert";
        private const string User_Update = "User_Update";
        private const string User_Delete = "User_Delete";
        private const string User_Select = "User_Select";
        private const string User_SelectAll = "User_SelectAll";
        private const string User_Search = "User_Search";
        private const string User_Login = "User_Login";
        private const string User_ChangePassword = "User_ChangePassword";
        private const string User_CheckName = "User_CheckName";
        private const string User_SelectByRole = "User_SelectByRole";
        private const string User_WindowsUserNameUpdate = "User_WindowsUserNameUpdate";
        private const string User_SelectForAdmin = "User_SelectForAdmin";
        private const string User_SelectNonDisabled = "User_SelectNonDisabled";
        private const string User_SelectByWinUserName = "User_SelectByWinUserName";
        private const string User_Select_By_RoleName = "User_Select_By_RoleName";

        internal static bool UserInsert(Guid guid, string name, string loginName, Guid userRoleGuid, string password, string addressline1, string addressline2, string addressline3, string phoneNo, string mobileNo, byte[] photo, string desc, decimal doctorShare, bool isDisable, Guid createdByUser, out DateTime createdOn, out int userId)
        {
            bool r = false;
            userId = 0;
            createdOn = DateTime.MinValue;

            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(User_Insert))
            {
                UserParameters(cmd, guid, name, loginName, userRoleGuid, password, addressline1, addressline2, addressline3, phoneNo, mobileNo, photo, desc, doctorShare, isDisable, createdByUser);
                SqlParameter prmId = AppDatabase.AddOutParameter(cmd, User.Columns.UserId, SqlDbType.Int);
                SqlParameter prmDate = AppDatabase.AddOutParameter(cmd, User.Columns.UserModifiedOn, SqlDbType.DateTime);

                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);
                if (r)
                {
                    userId = AppShared.DbValueToInteger(prmId.Value);
                    createdOn = AppShared.DbValueToDateTime(prmDate.Value);
                }
            }

            return r;
        }

        internal static bool UserUpdate(Guid guid, string name, string loginName, Guid userRoleGuid, string password, string addressline1, string addressline2, string addressline3, string phoneNo, string mobileNo, byte[] photo, string desc, decimal doctorShare, bool isDisable, Guid modifiedByUser, out DateTime modifiedOn)
        {
            bool r = false;
            modifiedOn = DateTime.MinValue;

            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(User_Update))
            {
                UserParameters(cmd, guid, name, loginName, userRoleGuid, password, addressline1, addressline2, addressline3, phoneNo, mobileNo, photo, desc, doctorShare, isDisable, modifiedByUser);
                SqlParameter prmDate = AppDatabase.AddOutParameter(cmd, User.Columns.UserModifiedOn, SqlDbType.DateTime);

                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);
                if (r)
                {
                    modifiedOn = AppShared.DbValueToDateTime(prmDate.Value);
                }
            }

            return r;
        }

        private static void UserParameters(SqlCommand cmd, Guid guid, string name, string loginName, Guid userRoleGuid, string password, string addressline1, string addressline2, string addressline3, string phoneNo, string mobileNo, byte[] photo, string desc, decimal doctorShare, bool isDisable, Guid modifiedBy)
        {
            AppDatabase.AddInParameter(cmd, User.Columns.UserGuid, SqlDbType.UniqueIdentifier, guid);
            AppDatabase.AddInParameter(cmd, User.Columns.UserName, SqlDbType.NVarChar, AppShared.SafeString(name));
            AppDatabase.AddInParameter(cmd, User.Columns.UserLoginName, SqlDbType.NVarChar, AppShared.SafeString(loginName));
            AppDatabase.AddInParameter(cmd, User.Columns.UserRoleGuid, SqlDbType.UniqueIdentifier, userRoleGuid);
            AppDatabase.AddInParameter(cmd, User.Columns.UserPassword, SqlDbType.NVarChar, AppShared.SafeString(password));
            AppDatabase.AddInParameter(cmd, User.Columns.UserAddressLine1, SqlDbType.NVarChar, AppShared.ToDbValueNullable(addressline1));
            AppDatabase.AddInParameter(cmd, User.Columns.UserAddressLine2, SqlDbType.NVarChar, AppShared.ToDbValueNullable(addressline2));
            AppDatabase.AddInParameter(cmd, User.Columns.UserAddressLine3, SqlDbType.NVarChar, AppShared.ToDbValueNullable(addressline3));
            AppDatabase.AddInParameter(cmd, User.Columns.UserPhoneNo, SqlDbType.NVarChar, AppShared.ToDbValueNullable(phoneNo));
            AppDatabase.AddInParameter(cmd, User.Columns.UserMobileNo, SqlDbType.NVarChar, AppShared.ToDbValueNullable(mobileNo));
            AppDatabase.AddInParameter(cmd, User.Columns.UserPhoto, SqlDbType.VarBinary, AppShared.ToDbValueNullable(photo));
            AppDatabase.AddInParameter(cmd, User.Columns.UserDesc, SqlDbType.NVarChar, AppShared.ToDbValueNullable(desc));
            AppDatabase.AddInParameter(cmd, User.Columns.DoctorShare, SqlDbType.Decimal, AppShared.ToDbValueNullable(doctorShare));
            AppDatabase.AddInParameter(cmd, User.Columns.UserIsDisable, SqlDbType.Bit, isDisable);
            AppDatabase.AddInParameter(cmd, User.Columns.UserModifiedBy, SqlDbType.NVarChar, modifiedBy);
        }

        internal static bool UserDelete(Guid guid)
        {
            return Execute(User_Delete, User.Columns.UserGuid, guid);
        }

        internal static SqlDataReader UserSelectForAdmin(Guid ownGuid)
        {
            SqlDataReader r = null;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(User_SelectForAdmin))
            {
                AppDatabase.AddInParameter(cmd, User.Columns.UserGuid, SqlDbType.UniqueIdentifier, ownGuid);
                AppDatabase db = OpenDatabase();
                if (db != null)
                    r = db.GetSqlDataReader(cmd);
            }
            return r;
        }

        internal static bool UserUpdateWindowsUserName(Guid userGuid, string windowsUser)
        {
            bool r = false;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(User_WindowsUserNameUpdate))
            {
                AppDatabase.AddInParameter(cmd, User.Columns.UserGuid, SqlDbType.UniqueIdentifier, userGuid);
                AppDatabase.AddInParameter(cmd, User.Columns.UserWindowsUserName, SqlDbType.NVarChar, AppShared.ToDbValueNullable(windowsUser));
                AppDatabase db = AppDAL.OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);
            }
            return r;
        }

        internal static SqlDataReader UserLogin(string userName, string password)
        {
            SqlDataReader r = null;

            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(User_Login))
            {
                AppDatabase.AddInParameter(cmd, User.Columns.UserLoginName, SqlDbType.NVarChar, AppShared.SafeString(userName));
                AppDatabase.AddInParameter(cmd, User.Columns.UserPassword, SqlDbType.NVarChar, AppShared.SafeString(password));
                AppDatabase db = OpenDatabase();
                if (db != null)
                    r = db.GetSqlDataReader(cmd);
            }

            return r;
        }

        internal static SqlDataReader UserSelect(Guid guid)
        {
            return GetReader(User_Select, User.Columns.UserGuid, guid);
        }

        internal static SqlDataReader UserSelectByWinUsername(string winUsername)
        {
            return GetReader(User_SelectByWinUserName, User.Columns.UserWindowsUserName, SqlDbType.NVarChar, winUsername);
        }

        internal static SqlDataReader UserSelectNonDisable(bool isDisable)
        {
            SqlDataReader r = null;

            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(User_SelectNonDisabled))
            {
                AppDatabase.AddInParameter(cmd, User.Columns.UserIsDisable, SqlDbType.Bit, isDisable);
                AppDatabase db = OpenDatabase();
                if (db != null)
                    r = db.GetSqlDataReader(cmd);
            }

            return r;
        }

        internal static SqlDataReader UserSelectAll()
        {
            return GetReader(User_SelectAll);
        }

        internal static SqlDataReader UserSearch(string searchText)
        {
            return GetReader(User_Search, "@SearchText", SqlDbType.NVarChar, AppShared.ToDbLikeText(searchText));
        }

        internal static bool ChangePassword(Guid userGuid, string oldPassword, string newPassword)
        {
            bool r = false;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(User_ChangePassword))
            {
                AppDatabase.AddInParameter(cmd, "@UserGuid", SqlDbType.UniqueIdentifier, userGuid);
                AppDatabase.AddInParameter(cmd, "@UserOldPassword", SqlDbType.NVarChar, oldPassword);
                AppDatabase.AddInParameter(cmd, "@UserNewPassword", SqlDbType.NVarChar, newPassword);
                SqlParameter prmSucess = AppDatabase.AddOutParameter(cmd, "@IsSuccess", SqlDbType.Bit);

                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd) && AppShared.DbValueToBoolean(prmSucess.Value);

            }
            return r;
        }

        internal static bool CheckUsernameAvailibity(string userName, Guid excludeGuid)
        {
            bool r = false;
            if (userName != string.Empty)
            {
                using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(User_CheckName))
                {
                    AppDatabase.AddInParameter(cmd, "@Username", SqlDbType.NVarChar, userName);
                    AppDatabase.AddInParameter(cmd, "@ExcludeGuid", SqlDbType.UniqueIdentifier, AppShared.ToDbValueNullable(excludeGuid));
                    SqlParameter prmAvailable = AppDatabase.AddOutParameter(cmd, "@IsAvailable", SqlDbType.Bit);

                    AppDatabase db = OpenDatabase();
                    if (db != null && db.ExecuteCommand(cmd))
                        r = AppShared.DbValueToBoolean(prmAvailable.Value);
                }
            }
            return r;
        }

        internal static SqlDataReader UserSelectByRoleLevel(Guid userGuid)
        {
            SqlDataReader r = null;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(User_SelectByRole))
            {
                AppDatabase.AddInParameter(cmd, User.Columns.UserGuid, SqlDbType.UniqueIdentifier, userGuid);

                AppDatabase db = OpenDatabase();
                if (db != null)
                    r = db.GetSqlDataReader(cmd);
            }
            return r;
        }

        internal static SqlDataReader UserSelectByRoleName(string roleName, string text)
        {
            return GetReader(User_Select_By_RoleName, "@RoleName", SqlDbType.NVarChar, roleName);
        }

    }
}
