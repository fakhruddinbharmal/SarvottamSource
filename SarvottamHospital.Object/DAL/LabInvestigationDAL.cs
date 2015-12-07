using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SarvottamHospital.Object
{
    internal static partial class AppDAL
    {
        public const string LabInvestigation_Insert = "LabInvestigation_Insert";
        public const string LabInvestigation_Update = "LabInvestigation_Update";
        public const string LabInvestigation_Delete = "LabInvestigation_Delete";
        public const string LabInvestigation_Select = "LabInvestigation_Select";
        public const string LabInvestigation_SelectAll = "LabInvestigation_SelectAll";
        public const string LabInvestigation_Search = "LabInvestigation_Search";



        internal static bool LabInvestigationInsert(Guid LabInvestigationGuid, string LabInvestigationName, string LabInvestigationDescription, Guid createdByUser, out DateTime createdOn)
        {
            bool r = false;
            //id = 0;
            createdOn = DateTime.MinValue;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(LabInvestigation_Insert))
            {
                LabInvestigationParameter(cmd, LabInvestigationGuid, LabInvestigationName, LabInvestigationDescription, createdByUser);
                //  SqlParameter prmId = AppDatabase.AddOutParameter(cmd, LabInvestigation.Columns.LabInvestigationId, SqlDbType.Int);
                SqlParameter prmDate = AppDatabase.AddOutParameter(cmd, LabInvestigation.Columns.LabInvestigationModifiedOn, SqlDbType.DateTime);

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

        internal static bool LabInvestigationUpdate(Guid LabInvestigationGuid, string LabInvestigationName, string LabInvestigationDescription, Guid modifiedByUser, out DateTime modifiedOn)
        {
            bool r = false;
            modifiedOn = DateTime.MinValue;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(LabInvestigation_Update))
            {
                LabInvestigationParameter(cmd, LabInvestigationGuid, LabInvestigationName, LabInvestigationDescription, modifiedByUser);
                SqlParameter prmDate = AppDatabase.AddOutParameter(cmd, LabInvestigation.Columns.LabInvestigationModifiedOn, SqlDbType.DateTime);

                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);
                if (r)
                {
                    modifiedOn = AppShared.DbValueToDateTime(prmDate.Value);
                }
            }
            return r;
        }
        internal static bool LabInvestigationDelete(Guid guid)
        {
            return Execute(LabInvestigation_Delete, LabInvestigation.Columns.LabInvestigationGuid, guid);
        }
        internal static SqlDataReader LabInvestigationSelect(Guid guid)
        {
            return GetReader(LabInvestigation_Select, LabInvestigation.Columns.LabInvestigationGuid, guid);
        }
        internal static SqlDataReader LabInvestigationSelectAll()
        {
            return GetReader(LabInvestigation_SelectAll);
        }
        internal static SqlDataReader LabInvestigationSearch(string SearchText)
        {
            return GetReader(LabInvestigation_Search, "@SearchText", SqlDbType.NVarChar, AppShared.ToDbLikeText(SearchText));
        }
        private static void LabInvestigationParameter(SqlCommand cmd, Guid LabInvestigationGuid, string LabInvestigationName, string LabInvestigationDescription, Guid modifiedBy)
        {
            AppDatabase.AddInParameter(cmd, LabInvestigation.Columns.LabInvestigationGuid, SqlDbType.UniqueIdentifier, LabInvestigationGuid);
            AppDatabase.AddInParameter(cmd, LabInvestigation.Columns.LabInvestigationName, SqlDbType.NVarChar, AppShared.SafeString(LabInvestigationName));
            AppDatabase.AddInParameter(cmd, LabInvestigation.Columns.LabInvestigationDescription, SqlDbType.NVarChar, AppShared.ToDbValueNullable(LabInvestigationDescription));
            AppDatabase.AddInParameter(cmd, LabInvestigation.Columns.LabInvestigationModifiedBy, SqlDbType.UniqueIdentifier, modifiedBy);
        }
    }
}
