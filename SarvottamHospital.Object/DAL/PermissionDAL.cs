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

        private const string UserPermission_Insert = "UserPermission_Insert";
        private const string UserPermission_Update = "UserPermission_Update";
        private const string UserPermission_Delete = "UserPermission_Delete";
        private const string UserPermission_Select = "UserPermission_Select";
        private const string UserPermission_SelectByUser = "UserPermission_SelectByUser";
        private const string UserPermission_SelectByEntity = "UserPermission_SelectByEntity";
        private const string UserPermission_SelectAll = "UserPermission_SelectAll";
        private const string UserPermission_SelectAllEntityByUser = "UserPermission_SelectAllEntityByUser";


        internal static bool PermissionInsert(Guid userGuid, Guid entityGuid, bool canView, bool canCreate, bool canEdit, bool canDelete, bool canSpecial, Guid createdByUser, out DateTime createdOn)
        {
            bool r = false;
            createdOn = DateTime.MinValue;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(UserPermission_Insert))
            {
                PermissionParameters(cmd, userGuid, entityGuid, canView, canCreate, canEdit, canDelete, canSpecial, createdByUser);
                SqlParameter prmModifiedOn = AppDatabase.AddOutParameter(cmd, "@PermissionModifiedOn", SqlDbType.DateTime);
                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);
                if (r)
                    createdOn = AppShared.DbValueToDateTime(prmModifiedOn.Value);
            }
            return r;
        }

        internal static bool PermissionUpdate(Guid userGuid, Guid entityGuid, bool canView, bool canCreate, bool canEdit, bool canDelete, bool canSpecial, Guid modifiedByUser, out DateTime modifiedOn)
        {
            bool r = false;
            modifiedOn = DateTime.MinValue;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(UserPermission_Update))
            {
                PermissionParameters(cmd, userGuid, entityGuid, canView, canCreate, canEdit, canDelete, canSpecial, modifiedByUser);
                SqlParameter prmModifiedOn = AppDatabase.AddOutParameter(cmd, "PermissionModifiedOn", SqlDbType.DateTime);
                AppDatabase db = OpenDatabase();
                r = (db != null && db.ExecuteCommand(cmd));
                if (r)
                    modifiedOn = AppShared.DbValueToDateTime(prmModifiedOn.Value);
            }
            return r;
        }

        internal static bool PermissionDelete(Guid userGuid, Guid entityGuid)
        {
            bool r = false;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(UserPermission_Delete))
            {
                AppDatabase.AddInParameter(cmd, "@PermissionUserRoleGuid", SqlDbType.UniqueIdentifier, userGuid);
                AppDatabase.AddInParameter(cmd, "@PermissionEntityGuid", SqlDbType.UniqueIdentifier, entityGuid);
                AppDatabase db = OpenDatabase();
                r = (db != null && db.ExecuteCommand(cmd));
            }
            return r;

        }

        internal static SqlDataReader PermssionSelect(Guid userRoleGuid, Guid entityGuid)
        {
            SqlDataReader dr = null;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(UserPermission_Select))
            {
                AppDatabase.AddInParameter(cmd, "@RoleGuid", SqlDbType.UniqueIdentifier, userRoleGuid);
                AppDatabase.AddInParameter(cmd, "@EntityGuid", SqlDbType.UniqueIdentifier, entityGuid);
                AppDatabase db = OpenDatabase();
                if (db != null)
                    dr = db.GetSqlDataReader(cmd);
            }
            return dr;
        }

        internal static SqlDataReader PermissionSelect_ByUser(Guid userGuid)
        {
            return GetReader(UserPermission_SelectByUser, "@PermissionUserRoleGuid", userGuid);
        }

        internal static SqlDataReader PermissionSelect_ByEntity(Guid entityGuid)
        {
            return GetReader(UserPermission_SelectByEntity, "@PermissionEntityGuid", entityGuid);
        }

        internal static SqlDataReader PermssionSelect_AllEntityByUser(Guid userGuid)
        {
            return GetReader(UserPermission_SelectAllEntityByUser, "@UserGuid", userGuid);
        }

        internal static SqlDataReader PermissionSelectAll()
        {
            return GetReader(UserPermission_SelectAll);
        }

        private static void PermissionParameters(SqlCommand cmd, Guid userGuid, Guid entityGuid, bool canView, bool canCreate, bool canEdit, bool canDelete, bool canSpecial, Guid modifiedBy)
        {
            AppDatabase.AddInParameter(cmd, Permission.Columns.PermissionUserRoleGuid, SqlDbType.UniqueIdentifier, userGuid);
            AppDatabase.AddInParameter(cmd, Permission.Columns.PermissionEntityGuid, SqlDbType.UniqueIdentifier, entityGuid);
            AppDatabase.AddInParameter(cmd, Permission.Columns.PermissionCanView, SqlDbType.Bit, canView);
            AppDatabase.AddInParameter(cmd, Permission.Columns.PermissionCanCreate, SqlDbType.Bit, canCreate);
            AppDatabase.AddInParameter(cmd, Permission.Columns.PermissionCanEdit, SqlDbType.Bit, canEdit);
            AppDatabase.AddInParameter(cmd, Permission.Columns.PermissionCanDelete, SqlDbType.Bit, canDelete);
            AppDatabase.AddInParameter(cmd, Permission.Columns.PermissionCanSpecial, SqlDbType.Bit, canSpecial);
            AppDatabase.AddInParameter(cmd, Permission.Columns.PermissionModifiedBy, SqlDbType.UniqueIdentifier, modifiedBy);
        }

    }
}
