using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;
using System.Data;

namespace SarvottamHospital.Object
{
    internal static partial class AppDAL
    {

        private const string UserFieldPermission_Insert = "UserFieldPermission_Insert";
        private const string UserFieldPermission_Update = "UserFieldPermission_Update";
        private const string UserFieldPermission_Delete = "UserFieldPermission_Delete";
        private const string UserFieldPermission_Select = "UserFieldPermission_Select";
        private const string UserFieldPermission_SelectByUser = "UserFieldPermission_SelectByUser";
        private const string UserFieldPermission_SelectByField = "UserFieldPermission_SelectByField";
        private const string UserFieldPermission_SelectAll = "UserFieldPermission_SelectAll";
        private const string UserFieldPermission_SelectAllEntityByUser = "UserFieldPermission_SelectAllEntityByUser";


        internal static bool FieldPermissionInsert(Guid userRoleGuid, Guid fieldGuid, bool canView, Guid createdBy, out DateTime createdOn)
        {
            bool r = false;
            createdOn = DateTime.MinValue;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(UserFieldPermission_Insert))
            {
                FieldPermissionParameters(cmd, userRoleGuid, fieldGuid, canView, createdBy);
                SqlParameter prmModifiedOn = AppDatabase.AddOutParameter(cmd, "@FieldPermissionModifiedOn", SqlDbType.DateTime);
                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);
                if (r)
                    createdOn = AppShared.DbValueToDateTime(prmModifiedOn.Value);
            }
            return r;
        }

        internal static bool FieldPermissionUpdate(Guid userRoleGuid, Guid fieldGuid, bool canView, Guid modifiedBy, out DateTime modifiedOn)
        {
            bool r = false;
            modifiedOn = DateTime.MinValue;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(UserFieldPermission_Update))
            {
                FieldPermissionParameters(cmd, userRoleGuid, fieldGuid, canView, modifiedBy);
                SqlParameter prmModifiedOn = AppDatabase.AddOutParameter(cmd, "@FieldPermissionModifiedOn", SqlDbType.DateTime);
                AppDatabase db = OpenDatabase();
                r = (db != null && db.ExecuteCommand(cmd));
                if (r)
                    modifiedOn = AppShared.DbValueToDateTime(prmModifiedOn.Value);
            }
            return r;
        }

        internal static bool FieldPermissionDelete(Guid userRoleGuid, Guid fieldGuid)
        {
            bool r = false;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(UserFieldPermission_Delete))
            {
                AppDatabase.AddInParameter(cmd, "@UserRoleGuid", SqlDbType.UniqueIdentifier, userRoleGuid);
                AppDatabase.AddInParameter(cmd, "@FieldGuid", SqlDbType.UniqueIdentifier, fieldGuid);
                AppDatabase db = OpenDatabase();
                r = (db != null && db.ExecuteCommand(cmd));
            }
            return r;

        }

        internal static SqlDataReader FieldPermssionSelect(Guid userRoleGuid, Guid fieldGuid)
        {
            SqlDataReader dr = null;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(UserFieldPermission_Select))
            {
                AppDatabase.AddInParameter(cmd, "@RoleGuid", SqlDbType.UniqueIdentifier, userRoleGuid);
                AppDatabase.AddInParameter(cmd, "@FieldGuid", SqlDbType.UniqueIdentifier, fieldGuid);
                AppDatabase db = OpenDatabase();
                if (db != null)
                    dr = db.GetSqlDataReader(cmd);
            }
            return dr;
        }

        internal static SqlDataReader FieldPermissionSelectByUser(Guid userRoleGuid)
        {
            return GetReader(UserFieldPermission_SelectByUser, "@FieldPermissionUserRoleGuid", userRoleGuid);
        }

        internal static SqlDataReader FieldPermissionSelectByField(Guid fieldGuid)
        {
            return GetReader(UserFieldPermission_SelectByField, "@FieldGuid", fieldGuid);
        }

        internal static SqlDataReader FieldPermssionSelectAllEntityByUser(Guid userRoleGuid)
        {
            return GetReader(UserFieldPermission_SelectAllEntityByUser, "@UserRoleGuid", userRoleGuid);
        }

        internal static SqlDataReader FieldPermissionSelectAll()
        {
            return GetReader(UserFieldPermission_SelectAll);
        }

        private static void FieldPermissionParameters(SqlCommand cmd, Guid userRoleGuid, Guid fieldGuid, bool canView, Guid modifiedBy)
        {
            AppDatabase.AddInParameter(cmd, FieldPermission.Columns.PermissionUserRoleGuid, SqlDbType.UniqueIdentifier, userRoleGuid);
            AppDatabase.AddInParameter(cmd, FieldPermission.Columns.PermisionFieldGuid, SqlDbType.UniqueIdentifier, fieldGuid);
            AppDatabase.AddInParameter(cmd, FieldPermission.Columns.PermissionCanView, SqlDbType.Bit, canView);
            AppDatabase.AddInParameter(cmd, FieldPermission.Columns.PermissionModifiedBy, SqlDbType.UniqueIdentifier,modifiedBy);
        }

    }
}
