using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SarvottamHospital.Object
{
    internal static partial class AppDAL
    {
        public const string MainInvestigation_Insert = "MainInvestigation_Insert";
        public const string MainInvestigation_Update = "MainInvestigation_Update";
        public const string MainInvestigation_Delete = "MainInvestigation_Delete";
        public const string MainInvestigation_Select = "MainInvestigation_Select";
        public const string MainInvestigation_SelectAll = "MainInvestigation_SelectAll";
        public const string MainInvestigation_Search = "MainInvestigation_Search";



        internal static bool MainInvestigationInsert(Guid MainInvestigationGuid, string MainInvestigationName, string MainInvestigationDescription, Guid createdByUser, out DateTime createdOn)
        {
            bool r = false;
            //id = 0;
            createdOn = DateTime.MinValue;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(MainInvestigation_Insert))
            {
                MainInvestigationParameter(cmd, MainInvestigationGuid, MainInvestigationName, MainInvestigationDescription, createdByUser);
                //  SqlParameter prmId = AppDatabase.AddOutParameter(cmd, MainInvestigation.Columns.MainInvestigationId, SqlDbType.Int);
                SqlParameter prmDate = AppDatabase.AddOutParameter(cmd, MainInvestigation.Columns.MainInvestigationModifiedOn, SqlDbType.DateTime);

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

        internal static bool MainInvestigationUpdate(Guid MainInvestigationGuid, string MainInvestigationName, string MainInvestigationDescription, Guid modifiedByUser, out DateTime modifiedOn)
        {
            bool r = false;
            modifiedOn = DateTime.MinValue;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(MainInvestigation_Update))
            {
                MainInvestigationParameter(cmd, MainInvestigationGuid, MainInvestigationName, MainInvestigationDescription, modifiedByUser);
                SqlParameter prmDate = AppDatabase.AddOutParameter(cmd, MainInvestigation.Columns.MainInvestigationModifiedOn, SqlDbType.DateTime);

                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);
                if (r)
                {
                    modifiedOn = AppShared.DbValueToDateTime(prmDate.Value);
                }
            }
            return r;
        }
        internal static bool MainInvestigationDelete(Guid guid)
        {
            return Execute(MainInvestigation_Delete, MainInvestigation.Columns.MainInvestigationGuid, guid);
        }
        internal static SqlDataReader MainInvestigationSelect(Guid guid)
        {
            return GetReader(MainInvestigation_Select, MainInvestigation.Columns.MainInvestigationGuid, guid);
        }
        internal static SqlDataReader MainInvestigationSelectAll()
        {
            return GetReader(MainInvestigation_SelectAll);
        }
        internal static SqlDataReader MainInvestigationSearch(string SearchText)
        {
            return GetReader(MainInvestigation_Search, "@SearchText", SqlDbType.NVarChar, AppShared.ToDbLikeText(SearchText));
        }
        private static void MainInvestigationParameter(SqlCommand cmd, Guid MainInvestigationGuid, string MainInvestigationName, string MainInvestigationDescription, Guid modifiedBy)
        {
            AppDatabase.AddInParameter(cmd, MainInvestigation.Columns.MainInvestigationGuid, SqlDbType.UniqueIdentifier, MainInvestigationGuid);
            AppDatabase.AddInParameter(cmd, MainInvestigation.Columns.MainInvestigationName, SqlDbType.NVarChar, AppShared.SafeString(MainInvestigationName));
            AppDatabase.AddInParameter(cmd, MainInvestigation.Columns.MainInvestigationDescription, SqlDbType.NVarChar, AppShared.ToDbValueNullable(MainInvestigationDescription));
            AppDatabase.AddInParameter(cmd, MainInvestigation.Columns.MainInvestigationModifiedBy, SqlDbType.UniqueIdentifier, modifiedBy);
        }
    }
}
