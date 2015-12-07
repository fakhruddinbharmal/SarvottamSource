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
        private const string OPDHistoryProcedureHistory_Insert = "OPDHistoryProcedureHistory_Insert";
        //private const string OPDHistoryProcedureHistory_Insert = "OPDHistoryProcedureHistory_Insert";
        private const string OPDHistoryProcedureHistory_Delete = "OPDHistoryProcedureHistory_Delete";
        private const string OPDHistoryProcedureHistory_SelectAll = "OPDHistoryProcedureHistory_SelectAll";

        internal static bool OPDHistoryProcedureHistoryInsert(Guid opdHistoryProcedureGuid, Guid PatientGuid, Guid HistoryGuid)
        {
            bool r = false;

            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(OPDHistoryProcedureHistory_Insert))
            {
                OPDHistoryProcedureHistoryParameters(cmd, opdHistoryProcedureGuid, PatientGuid, HistoryGuid);
                // SqlParameter prmModifiedOn = AppDatabase.AddOutParameter(cmd, OPDHistoryProcedureChiefComplain.Columns.OPDHistoryProcedureModifiedOn, SqlDbType.DateTime);
                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);
                //if (r)
                //    createdOn = AppShared.DbValueToDateTime(prmModifiedOn.Value);

            }
            return r;
        }
        internal static SqlDataReader OPDHistoryProcedureHistoryDelete(Guid guid)
        {
            return GetReader(OPDHistoryProcedureHistory_Delete, OPDHistoryProcedureHistory.Columns.OPDHistoryProcedureGuid, guid);
        }
        internal static SqlDataReader OPDHistoryProcedureHistorySelectAll(Guid guid)
        {
            return GetReader(OPDHistoryProcedureHistory_SelectAll, OPDHistoryProcedureHistory.Columns.OPDHistoryProcedureGuid, guid);
        }

        private static void OPDHistoryProcedureHistoryParameters(SqlCommand cmd, Guid opdHistoryProcedureGuid, Guid PatientGuid, Guid HistoryGuid)
        {
            AppDatabase.AddInParameter(cmd, OPDHistoryProcedureHistory.Columns.OPDHistoryProcedureGuid, SqlDbType.UniqueIdentifier, opdHistoryProcedureGuid);
            AppDatabase.AddInParameter(cmd, OPDHistoryProcedureHistory.Columns.OPDHistoryProcedurePatientGuid, SqlDbType.UniqueIdentifier, PatientGuid);
            AppDatabase.AddInParameter(cmd, OPDHistoryProcedureHistory.Columns.OPDHistoryProcedureHistory, SqlDbType.UniqueIdentifier, HistoryGuid);

        }
    }
}
