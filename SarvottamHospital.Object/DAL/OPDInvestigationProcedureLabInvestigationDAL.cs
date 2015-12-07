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
        private const string OPDInvestigationProcedureLabInvestigation_Insert       = "OPDInvestigationProcedureLabInvestigation_Insert";
        private const string OPDInvestigationProcedureLabInvestigation_Delete       = "OPDInvestigationProcedureLabInvestigation_Delete";
        private const string OPDInvestigationProcedureLabInvestigation_SelectAll    = "OPDInvestigationProcedureLabInvestigation_SelectAll";

        internal static bool OPDInvestigationProcedureLabInvestigationInsert(Guid OPDInvestigationProcedureGuid, Guid PatientGuid, Guid OPDInvestigationProcedureLabInvestigationGuid)
        {
            bool r = false;

            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(OPDInvestigationProcedureLabInvestigation_Insert))
            {
                OPDLabInvestigationParameters(cmd, OPDInvestigationProcedureGuid, PatientGuid, OPDInvestigationProcedureLabInvestigationGuid);
                // SqlParameter prmModifiedOn = AppDatabase.AddOutParameter(cmd, OPDHistoryProcedureChiefComplain.Columns.OPDHistoryProcedureModifiedOn, SqlDbType.DateTime);
                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);
                //if (r)
                //    createdOn = AppShared.DbValueToDateTime(prmModifiedOn.Value);
            }
            return r;
        }
        internal static SqlDataReader OPDInvestigationProcedureLabInvestigationDelete(Guid guid)
        {
            return GetReader(OPDInvestigationProcedureLabInvestigation_Delete, OPDInvestigationProcedureLabInvestigation.Columns.OPDInvestigationProcedureGuid, guid);
        }
        internal static SqlDataReader OPDInvestigationProcedureLabInvestigationSelectAll(Guid guid)
        {
            return GetReader(OPDInvestigationProcedureLabInvestigation_SelectAll, OPDInvestigationProcedureLabInvestigation.Columns.OPDInvestigationProcedureGuid, guid);
        }
        private static void OPDLabInvestigationParameters(SqlCommand cmd, Guid OPDInvestigationProcedureGuid, Guid PatientGuid, Guid OPDInvestigationProcedureLabInvestigationGuid)
        {
            AppDatabase.AddInParameter(cmd, OPDInvestigationProcedureLabInvestigation.Columns.OPDInvestigationProcedureGuid, SqlDbType.UniqueIdentifier, OPDInvestigationProcedureGuid);
            AppDatabase.AddInParameter(cmd, OPDInvestigationProcedureLabInvestigation.Columns.OPDInvestigationProcedurePatientGuid, SqlDbType.UniqueIdentifier, PatientGuid);
            AppDatabase.AddInParameter(cmd, OPDInvestigationProcedureLabInvestigation.Columns.OPDInvestigationProcedureLabInvestigationGuid, SqlDbType.UniqueIdentifier, OPDInvestigationProcedureLabInvestigationGuid);
        }
    }
}
