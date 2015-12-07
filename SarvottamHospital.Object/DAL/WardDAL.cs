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
        private const string Ward_Insert = "Ward_Insert";
        private const string Ward_Update = "Ward_Update";
        private const string Ward_Delete = "Ward_Delete";
        private const string Ward_Select = "Ward_Select";
        private const string Ward_SelectAll = "Ward_SelectAll";
        private const string Ward_Search = "Ward_Search";

        internal static bool WardInsert(Guid guid, string name, string description, Guid createdByUser, out DateTime createdOn)
        {
            bool r = false;
            createdOn = DateTime.MinValue;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(Ward_Insert))
            {
                WardParameters(cmd, guid, name, description, createdByUser);
                SqlParameter prmModifiedOn = AppDatabase.AddOutParameter(cmd, Ward.Columns.WardModifiedOn, SqlDbType.DateTime);
                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);
                if (r)
                    createdOn = AppShared.DbValueToDateTime(prmModifiedOn.Value);
            }
            return r;
        }

        internal static bool WardUpdate(Guid guid, string name, string description, Guid modifiedByUser, out DateTime modifiedOn)
        {
            bool r = false;
            modifiedOn = DateTime.MinValue;

            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(Ward_Update))
            {
                WardParameters(cmd, guid, name, description, modifiedByUser);
                SqlParameter prmDate = AppDatabase.AddOutParameter(cmd, Ward.Columns.WardModifiedOn, SqlDbType.DateTime);

                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);
                if (r)
                {
                    modifiedOn = AppShared.DbValueToDateTime(prmDate.Value);
                }
            }

            return r;
        }

        internal static bool WardDelete(Guid guid)
        {
            return Execute(Ward_Delete, Ward.Columns.WardGuid, guid);
        }

        internal static SqlDataReader WardSelect(Guid guid)
        {
            return GetReader(Ward_Select, Ward.Columns.WardGuid, guid);
        }

        internal static SqlDataReader WardSelectAll()
        {
            return GetReader(Ward_SelectAll);
        }

        internal static SqlDataReader WardSearch(string searchText)
        {
            return GetReader(Ward_Search, "@SearchText", SqlDbType.NVarChar, AppShared.ToDbLikeText(searchText));
        }

        private static void WardParameters(SqlCommand cmd, Guid guid, string name,string description, Guid modifiedBy)
        {
            AppDatabase.AddInParameter(cmd, Ward.Columns.WardGuid, SqlDbType.UniqueIdentifier, guid);
            AppDatabase.AddInParameter(cmd, Ward.Columns.WardName, SqlDbType.NVarChar, AppShared.SafeString(name));
            AppDatabase.AddInParameter(cmd, Ward.Columns.WardDescription, SqlDbType.NVarChar, AppShared.SafeString(description));
            AppDatabase.AddInParameter(cmd, Ward.Columns.WardModifiedBy, SqlDbType.UniqueIdentifier, modifiedBy);
        }
    }
}
