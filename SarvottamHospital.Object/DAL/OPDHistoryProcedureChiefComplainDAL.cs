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
         private const string OPDHistoryProcedureChiefComplain_Insert = "OPDHistoryProcedureChiefComplain_Insert";        
         private const string OPDHistoryProcedureChiefComplain_Delete ="OPDHistoryProcedureChiefComplain_Delete";
         private const string OPDHistoryProcedureChiefComplain_SelectAll = "OPDHistoryProcedureChiefComplain_SelectAll";

         internal static bool OPDHistoryProcedureChiefComplainInsert(Guid opdHistoryProcedureGuid, Guid PatientGuid, Guid ChiefComplainGuid)
         {
             bool r = false;

             using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(OPDHistoryProcedureChiefComplain_Insert))
             {
                 OPDHistoryProcedureChiefComplainParameters(cmd, opdHistoryProcedureGuid, PatientGuid, ChiefComplainGuid);
                // SqlParameter prmModifiedOn = AppDatabase.AddOutParameter(cmd, OPDHistoryProcedureChiefComplain.Columns.OPDHistoryProcedureModifiedOn, SqlDbType.DateTime);
                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);
                //if (r)
                //    createdOn = AppShared.DbValueToDateTime(prmModifiedOn.Value);
            
             }
             return r;
         }
         internal static SqlDataReader OPDHistoryProcedureChiefComplainDelete(Guid guid)
         {
             return GetReader(OPDHistoryProcedureChiefComplain_Delete, OPDHistoryProcedureChiefComplain.Columns.OPDHistoryProcedureGuid, guid);
         }
         internal static SqlDataReader OPDHistoryProcedureChiefComplainSelectAll(Guid guid)
         {
             return GetReader(OPDHistoryProcedureChiefComplain_SelectAll, OPDHistoryProcedureChiefComplain.Columns.OPDHistoryProcedureGuid, guid);
         }

         private static void OPDHistoryProcedureChiefComplainParameters(SqlCommand cmd, Guid opdHistoryProcedureGuid, Guid PatientGuid, Guid ChiefComplainGuid)
         {
             AppDatabase.AddInParameter(cmd, OPDHistoryProcedureChiefComplain.Columns.OPDHistoryProcedureGuid, SqlDbType.UniqueIdentifier, opdHistoryProcedureGuid);
             AppDatabase.AddInParameter(cmd, OPDHistoryProcedureChiefComplain.Columns.OPDHistoryProcedurePatientGuid, SqlDbType.UniqueIdentifier, PatientGuid);
             AppDatabase.AddInParameter(cmd, OPDHistoryProcedureChiefComplain.Columns.OPDHistoryProcedureChiefComplain, SqlDbType.UniqueIdentifier, ChiefComplainGuid);
         }
    }
}
