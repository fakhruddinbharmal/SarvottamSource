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
        private const string OPDInvestigationProcedureMainInvestigation_Insert       = "OPDInvestigationProcedureMainInvestigation_Insert";      
        private const string OPDInvestigationProcedureMainInvestigation_Delete       = "OPDInvestigationProcedureMainInvestigation_Delete";   
        private const string OPDInvestigationProcedureMainInvestigation_SelectAll    = "OPDInvestigationProcedureMainInvestigation_SelectAll";

        internal static bool OPDInvestigationProcedureMainInvestigationInsert(Guid OPDInvestigationProcedureGuid, Guid PatientGuid, Guid OPDInvestigationProcedureMainInvestigationGuid)
        {
            bool r = false;

            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(OPDInvestigationProcedureMainInvestigation_Insert))
            {
                OPDMainInvestigationParameters(cmd, OPDInvestigationProcedureGuid, PatientGuid, OPDInvestigationProcedureMainInvestigationGuid);
                // SqlParameter prmModifiedOn = AppDatabase.AddOutParameter(cmd, OPDHistoryProcedureChiefComplain.Columns.OPDHistoryProcedureModifiedOn, SqlDbType.DateTime);
                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);
                //if (r)
                //    createdOn = AppShared.DbValueToDateTime(prmModifiedOn.Value);
            }
            return r;
        }

        internal static SqlDataReader OPDInvestigationProcedureMainInvestigationDelete(Guid guid)
        {
            return GetReader(OPDInvestigationProcedureMainInvestigation_Delete, OPDInvestigationProcedureMainInvestigation.Columns.OPDInvestigationProcedureGuid, guid);
        }

        internal static SqlDataReader OPDInvestigationProcedureMainInvestigationSelectAll(Guid guid)
        {
            return GetReader(OPDInvestigationProcedureMainInvestigation_SelectAll, OPDInvestigationProcedureMainInvestigation.Columns.OPDInvestigationProcedureGuid, guid);
        }

        private static void OPDMainInvestigationParameters(SqlCommand cmd, Guid OPDInvestigationProcedureGuid, Guid PatientGuid, Guid OPDInvestigationProcedureMainInvestigationGuid)
        {
            AppDatabase.AddInParameter(cmd, OPDInvestigationProcedureMainInvestigation.Columns.OPDInvestigationProcedureGuid, SqlDbType.UniqueIdentifier, OPDInvestigationProcedureGuid);
            AppDatabase.AddInParameter(cmd, OPDInvestigationProcedureMainInvestigation.Columns.OPDInvestigationProcedurePatientGuid, SqlDbType.UniqueIdentifier, PatientGuid);
            AppDatabase.AddInParameter(cmd, OPDInvestigationProcedureMainInvestigation.Columns.OPDInvestigationProcedureMainInvestigationGuid, SqlDbType.UniqueIdentifier, OPDInvestigationProcedureMainInvestigationGuid);
        }
    }
}
