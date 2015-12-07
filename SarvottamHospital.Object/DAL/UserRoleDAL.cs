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
        private const string UserRole_Insert = "UserRole_Insert";
        private const string UserRole_Update = "UserRole_Update";
        private const string UserRole_Delete = "UserRole_Delete";
        private const string UserRole_Select = "UserRole_Select";

        private const string UserRole_SelectAll = "UserRole_SelectAll";
        private const string UserRole_Search = "UserRole_Search";
        private const string UserRole_CheckRoleIdAvailability = "UserRole_CheckRoleIdAvailability";

        internal static bool UserRoleInsert(Guid guid, string userRoleName, int userRoleLevel, string userRoleDesc, Guid createdByUser, out DateTime createdOn, out int userRoleId)
        {
            bool r = false;
            createdOn = DateTime.MinValue;
            userRoleId = 0;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(UserRole_Insert))
            {
                UserRoleParameters(cmd, guid, userRoleName, userRoleLevel, userRoleDesc, createdByUser);
                SqlParameter prmId = AppDatabase.AddOutParameter(cmd, UserRole.Columns.UserRoleId, SqlDbType.Int);
                SqlParameter prmDate = AppDatabase.AddOutParameter(cmd, UserRole.Columns.UserRoleModifiedOn, SqlDbType.DateTime);

                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);
                if (r)
                {
                    userRoleId = AppShared.DbValueToInteger(prmId.Value);
                    createdOn = AppShared.DbValueToDateTime(prmDate.Value);
                }
            }

            return r;
        }

        internal static bool UserRoleUpdate(Guid guid, string userRoleName, int userRoleLevel, string userRoleDesc, Guid modifiedByUser, out DateTime modifiedOn)
        {
            bool r = false;
            modifiedOn = DateTime.MinValue;

            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(UserRole_Update))
            {
                UserRoleParameters(cmd, guid, userRoleName, userRoleLevel, userRoleDesc, modifiedByUser);
                SqlParameter prmDate = AppDatabase.AddOutParameter(cmd, UserRole.Columns.UserRoleModifiedOn, SqlDbType.DateTime);

                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);
                if (r)
                {
                    modifiedOn = AppShared.DbValueToDateTime(prmDate.Value);
                }
            }

            return r;
        }

        private static void UserRoleParameters(SqlCommand cmd, Guid guid, string userRoleName, int userRoleLevel, string userRoleDesc, Guid modifiedBy)
        {
            AppDatabase.AddInParameter(cmd, UserRole.Columns.UserRoleGuid, SqlDbType.UniqueIdentifier, guid);
            AppDatabase.AddInParameter(cmd, UserRole.Columns.UserRoleName, SqlDbType.NVarChar, userRoleName);
            AppDatabase.AddInParameter(cmd, UserRole.Columns.UserRoleLevel, SqlDbType.Int, userRoleLevel);
            AppDatabase.AddInParameter(cmd, UserRole.Columns.UserRoleDesc, SqlDbType.NVarChar, userRoleDesc);
            AppDatabase.AddInParameter(cmd, UserRole.Columns.UserRoleModifiedBy, SqlDbType.UniqueIdentifier, modifiedBy);
        }

        internal static bool UserRoleDelete(Guid guid)
        {
            return Execute(UserRole_Delete, UserRole.Columns.UserRoleGuid, guid);
        }

        internal static SqlDataReader UserRoleSelect(Guid guid)
        {
            return GetReader(UserRole_Select, UserRole.Columns.UserRoleGuid, guid);
        }

        internal static SqlDataReader UserRoleSelectAll()
        {
            return GetReader(UserRole_SelectAll);
        }

        internal static SqlDataReader UserRoleSearch(string searchText)
        {
            return GetReader(UserRole_Search, "@SearchText", SqlDbType.NVarChar, AppShared.ToDbLikeText(searchText));
        }



    }
}
