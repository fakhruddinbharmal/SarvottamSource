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
        private const string OPDPrescriptionProcedureMedicine_Insert    = "OPDPrescriptionProcedureMedicine_Insert";
        private const string OPDPrescriptionProcedureMedicine_Delete    = "OPDPrescriptionProcedureMedicine_Delete";
        private const string OPDPrescriptionProcedureMedicine_SelectAll = "OPDPrescriptionProcedureMedicine_SelectAll";

        internal static bool OPDPrescriptionProcedureMedicineInsert(Guid opdPrescriptionProcedureGuid, Guid PatientGuid, Guid MedicineGuid)
        {
            bool r = false;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(OPDPrescriptionProcedureMedicine_Insert))
            {
                OPDPrescriptionProcedureMedicineParameters(cmd, opdPrescriptionProcedureGuid, PatientGuid, MedicineGuid);
                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);
            }
            return r;
        }
        internal static SqlDataReader OPDPrescriptionProcedureMedicineDelete(Guid guid)
        {
            return GetReader(OPDPrescriptionProcedureMedicine_Delete, OPDPrescriptionProcedureMedicine.Columns.OPDPrescriptionProcedureGuid, guid);
        }
        internal static SqlDataReader OPDPrescriptionProcedureMedicineSelectAll(Guid guid)
        {
            return GetReader(OPDPrescriptionProcedureMedicine_SelectAll, OPDPrescriptionProcedureMedicine.Columns.OPDPrescriptionProcedureGuid, guid);
        }
        private static void OPDPrescriptionProcedureMedicineParameters(SqlCommand cmd, Guid opdPrescriptionProcedureGuid, Guid PatientGuid, Guid MedicineGuid)
        { 
            AppDatabase.AddInParameter(cmd,OPDPrescriptionProcedureMedicine.Columns.OPDPrescriptionProcedureGuid,SqlDbType.UniqueIdentifier,opdPrescriptionProcedureGuid);
            AppDatabase.AddInParameter(cmd,OPDPrescriptionProcedureMedicine.Columns.OPDPrescriptionProcedurePatientGuid,SqlDbType.UniqueIdentifier,PatientGuid);
            AppDatabase.AddInParameter(cmd, OPDPrescriptionProcedureMedicine.Columns.OPDPrescriptionProcedureMedicineGuid, SqlDbType.UniqueIdentifier, MedicineGuid);
        }
    }
}
