using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SarvottamHospital.Object
{
    internal static partial class AppDAL
    {
        public const string History_Insert = "History_Insert";
        public const string History_Update = "History_Update";
        public const string History_Delete = "History_Delete";
        public const string History_Select = "History_Select";
        public const string History_SelectAll = "History_SelectAll";
        public const string History_Search = "History_Search";



        internal static bool HistoryInsert(Guid HistoryGuid, string HistoryName, string HistoryDescription, Guid createdByUser, out DateTime createdOn)
        {
            bool r = false;
            //id = 0;
            createdOn = DateTime.MinValue;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(History_Insert))
            {
                HistoryParameter(cmd, HistoryGuid, HistoryName, HistoryDescription, createdByUser);
                //  SqlParameter prmId = AppDatabase.AddOutParameter(cmd, History.Columns.HistoryId, SqlDbType.Int);
                SqlParameter prmDate = AppDatabase.AddOutParameter(cmd, History.Columns.HistoryModifiedOn, SqlDbType.DateTime);

                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);
                if (r)
                {
                    //id = AppShared.DbValueToInteger(prmId.Value);
                    createdOn = AppShared.DbValueToDateTime(prmDate.Value);
                }
            }
            return r;
        }

        internal static bool HistoryUpdate(Guid HistoryGuid, string HistoryName, string HistoryDescription, Guid modifiedByUser, out DateTime modifiedOn)
        {
            bool r = false;
            modifiedOn = DateTime.MinValue;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(History_Update))
            {
                HistoryParameter(cmd, HistoryGuid, HistoryName, HistoryDescription, modifiedByUser);
                SqlParameter prmDate = AppDatabase.AddOutParameter(cmd, History.Columns.HistoryModifiedOn, SqlDbType.DateTime);

                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);
                if (r)
                {
                    modifiedOn = AppShared.DbValueToDateTime(prmDate.Value);
                }
            }
            return r;
        }
        internal static bool HistoryDelete(Guid guid)
        {
            return Execute(History_Delete, History.Columns.HistoryGuid, guid);
        }
        internal static SqlDataReader HistorySelect(Guid guid)
        {
            return GetReader(History_Select, History.Columns.HistoryGuid, guid);
        }
        internal static SqlDataReader HistorySelectAll()
        {
            return GetReader(History_SelectAll);
        }
        internal static SqlDataReader HistorySearch(string SearchText)
        {
            return GetReader(History_Search, "@SearchText", SqlDbType.NVarChar, AppShared.ToDbLikeText(SearchText));
        }
        private static void HistoryParameter(SqlCommand cmd, Guid HistoryGuid, string HistoryName, string HistoryDescription, Guid modifiedBy)
        {
            AppDatabase.AddInParameter(cmd, History.Columns.HistoryGuid, SqlDbType.UniqueIdentifier, HistoryGuid);
            AppDatabase.AddInParameter(cmd, History.Columns.HistoryName, SqlDbType.NVarChar, AppShared.SafeString(HistoryName));
            AppDatabase.AddInParameter(cmd, History.Columns.HistoryDescription, SqlDbType.NVarChar, AppShared.ToDbValueNullable(HistoryDescription));
            AppDatabase.AddInParameter(cmd, History.Columns.HistoryModifiedBy, SqlDbType.UniqueIdentifier, modifiedBy);
        }
    }
}
