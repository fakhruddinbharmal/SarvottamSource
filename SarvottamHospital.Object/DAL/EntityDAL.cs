using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace SarvottamHospital.Object
{
    internal static partial class AppDAL
    {
        private const string Entity_Insert = "Entity_Insert";
        private const string Entity_Update = "Entity_Update";
        private const string Entity_Delete = "Entity_Delete";
        private const string Entity_Select = "Entity_Select";
        private const string Entity_SelectAll = "Entity_SelectAll";
        private const string Entity_Search = "Entity_Search";
        private const string EntityGroup_SelectAll = "EntityGroup_SelectAll";
        private const string Entity_SelectByUser = "Entity_SelectByUser";

        internal static bool EntityInsert(Guid guid, string name, string caption, string typeName, string listCaption, string listTypeName, byte[] iconSmall, byte[] iconLarge, string groupName, string desc, Guid createdByUser, out DateTime createdOn, out int id)
        {
            bool r = false;
            createdOn = DateTime.MinValue;
            id = 0;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(Entity_Insert))
            {
                EntityParameters(cmd, guid, name, caption, typeName, listCaption, listTypeName, iconSmall, iconLarge, groupName, desc, createdByUser);

                SqlParameter prmCreatedOn = AppDatabase.AddOutParameter(cmd, "@EntityModifiedOn", SqlDbType.DateTime);
                SqlParameter prmId = AppDatabase.AddOutParameter(cmd, "@EntityId", SqlDbType.Int);

                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);
                if (r)
                {
                    id = AppShared.DbValueToInteger(prmId.Value);
                    createdOn = AppShared.DbValueToDateTime(prmCreatedOn.Value);
                }
            }
            return r;
        }

        internal static bool EntityUpdate(Guid guid, string name, string caption, string typeName, string listCaption, string listTypeName, byte[] iconSmall, byte[] iconLarge, string groupName, string desc, Guid modifiedByUser, out DateTime modifiedOn)
        {
            bool r = false;
            modifiedOn = DateTime.MinValue;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(Entity_Update))
            {
                EntityParameters(cmd, guid, name, caption, typeName, listCaption, listTypeName, iconSmall, iconLarge, groupName, desc, modifiedByUser);

                SqlParameter prmModifiedOn = AppDatabase.AddOutParameter(cmd, "@EntityModifiedOn", SqlDbType.DateTime);

                AppDatabase db = OpenDatabase();
                if (db != null && db.ExecuteCommand(cmd))
                {
                    modifiedOn = AppShared.DbValueToDateTime(prmModifiedOn.Value);
                    r = true;
                }
            }
            return r;
        }

        private static void EntityParameters(SqlCommand cmd, Guid guid, string name, string caption, string typeName, string listCaption, string listTypeName, byte[] iconSmall, byte[] iconLarge, string groupName, string desc, Guid modifiedBy)
        {
            AppDatabase.AddInParameter(cmd, Entity.Columns.Guid, SqlDbType.UniqueIdentifier, guid);
            AppDatabase.AddInParameter(cmd, Entity.Columns.Name, SqlDbType.NVarChar, AppShared.SafeString(name));
            AppDatabase.AddInParameter(cmd, Entity.Columns.Desc, SqlDbType.NVarChar, AppShared.ToDbValueNullable(desc));
            AppDatabase.AddInParameter(cmd, Entity.Columns.GroupName, SqlDbType.NVarChar, AppShared.ToDbValueNullable(groupName));
            AppDatabase.AddInParameter(cmd, Entity.Columns.Caption, SqlDbType.NVarChar, AppShared.SafeString(caption));
            AppDatabase.AddInParameter(cmd, Entity.Columns.TypeName, SqlDbType.NVarChar, AppShared.SafeString(typeName));
            AppDatabase.AddInParameter(cmd, Entity.Columns.ListCaption, SqlDbType.NVarChar, AppShared.SafeString(listCaption));
            AppDatabase.AddInParameter(cmd, Entity.Columns.ListTypeName, SqlDbType.NVarChar, AppShared.SafeString(listTypeName));
            AppDatabase.AddInParameter(cmd, Entity.Columns.IconSmall, SqlDbType.VarBinary, AppShared.ToDbValueNullable(iconSmall));
            AppDatabase.AddInParameter(cmd, Entity.Columns.IconLarge, SqlDbType.VarBinary, AppShared.ToDbValueNullable(iconLarge));
            AppDatabase.AddInParameter(cmd, Entity.Columns.ModifiedBy, SqlDbType.UniqueIdentifier, modifiedBy);
        }

        internal static bool EntityDelete(Guid guid)
        {
            return Execute(Entity_Delete, "@EntityGuid", guid);
        }

        internal static SqlDataReader EntitySelect(Guid guid)
        {
            return GetReader(Entity_Select, "@EntityGuid", guid);
        }

        internal static SqlDataReader EntitySelectAll()
        {
            return GetReader(Entity_SelectAll);
        }

        internal static SqlDataReader EntitySearch(string searchText)
        {
            return GetReader(Entity_Search, "@SearchText", SqlDbType.NVarChar, AppShared.ToDbLikeText(searchText));
        }

        internal static SqlDataReader EntityGroupSelectAll()
        {
            return GetReader(EntityGroup_SelectAll);
        }

        internal static SqlDataReader EntityByUser(Guid userRoleGuid)
        {
            return GetReader(Entity_SelectByUser, "@UserRoleGuid", SqlDbType.UniqueIdentifier, userRoleGuid);
        }

    }
}
