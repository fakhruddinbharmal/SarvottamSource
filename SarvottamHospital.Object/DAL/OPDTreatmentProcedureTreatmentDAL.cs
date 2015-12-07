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
        private const string OPDTreatmentProcedureTreatment_Insert      = "OPDTreatmentProcedureTreatment_Insert";
        private const string OPDTreatmentProcedureTreatment_Delete      = "OPDTreatmentProcedureTreatment_Delete";
        private const string OPDTreatmentProcedureTreatment_SelectAll = "OPDTreatmentProcedureTreatment_SelectAll";

        internal static bool OPDTreatmentProcedureTreatmentInsert(Guid ProcedureGuid, Guid PatientGuid, Guid TreatmentGuid)
        {
            bool r = false;
            using(SqlCommand cmd = AppDatabase.GetStoreProcCommand(OPDTreatmentProcedureTreatment_Insert))
            {
                OPDTreatmentProcedureTreatmentParameters(cmd, ProcedureGuid, PatientGuid, TreatmentGuid);
                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);
            }
            return r;
        }
        internal static SqlDataReader OPDTreatmentProcedureTreatmentDelete(Guid guid)
        {
            return GetReader(OPDTreatmentProcedureTreatment_Delete, OPDTreatmentProcedureTreatment.Columns.OPDTreatmentProcedureGuid, guid);
        }
        internal static SqlDataReader OPDTreatmentProcedureTreatmentSelectAll(Guid guid)
        {
            return GetReader(OPDTreatmentProcedureTreatment_SelectAll, OPDTreatmentProcedureTreatment.Columns.OPDTreatmentProcedureGuid, guid);
        }
        private static void OPDTreatmentProcedureTreatmentParameters(SqlCommand cmd, Guid ProcedureGuid, Guid PatientGuid, Guid TreatmentGuid)
        {
            AppDatabase.AddInParameter(cmd,OPDTreatmentProcedureTreatment.Columns.OPDTreatmentProcedureGuid,SqlDbType.UniqueIdentifier,ProcedureGuid);
            AppDatabase.AddInParameter(cmd,OPDTreatmentProcedureTreatment.Columns.OPDTreatmentProcedurePatientGuid,SqlDbType.UniqueIdentifier,PatientGuid);
            AppDatabase.AddInParameter(cmd,OPDTreatmentProcedureTreatment.Columns.OPDTreatmentProcedureTreatment, SqlDbType.UniqueIdentifier, TreatmentGuid);
        }

    }
}
