using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace SarvottamHospital.Object
{
    internal static partial class AppDAL
    {
        public const string OPDPrescription_Insert = "OPDPrescription_Insert";
        public const string OPDPrescription_Update = "OPDPrescription_Update";
        public const string OPDPrescription_Delete = "OPDPrescription_Delete";
        public const string OPDPrescription_Select = "OPDPrescription_Select";
        public const string OPDPrescription_SelectAll = "OPDPrescription_SelectAll";
        public const string OPDPrescription_Search = "OPDPrescription_Search";


        internal static bool OPDPrescriptionInsert(Guid OPDPrescriptionProcedureGuid, Guid PatientGuid, string Doseage, string Timings,
                                                       DateTime OPDPrescriptionDate, Guid createdByUser, out DateTime createdOn)
        {
            bool r = false;
            createdOn = DateTime.MinValue;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(OPDPrescription_Insert))
            {
                OPDPrescriptionParameters(cmd, OPDPrescriptionProcedureGuid, PatientGuid, Doseage, Timings, OPDPrescriptionDate, createdByUser);
                SqlParameter prmDate = AppDatabase.AddOutParameter(cmd, OPDPrescription.Columns.OPDPrescriptionModifiedOn, SqlDbType.DateTime);

                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);
                if (r)
                {
                    createdOn = AppShared.DbValueToDateTime(prmDate.Value);
                }
            }
            return r;
        }
        internal static bool OPDPrescriptionUpdate(Guid OPDPrescriptionProcedureGuid, Guid PatientGuid, string Doseage, string Timings,
                                                       DateTime OPDPrescriptionDate, Guid modifiedByUser, out DateTime modifiedOn)
        {
            bool r = false;
            modifiedOn = DateTime.MinValue;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(OPDPrescription_Update))
            {
                OPDPrescriptionParameters(cmd, OPDPrescriptionProcedureGuid, PatientGuid, Doseage, Timings, OPDPrescriptionDate, modifiedByUser);
                SqlParameter prmDate = AppDatabase.AddOutParameter(cmd, OPDPrescription.Columns.OPDPrescriptionModifiedOn, SqlDbType.DateTime);

                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);
                if (r)
                {
                    modifiedOn = AppShared.DbValueToDateTime(prmDate.Value);
                }
            }
            return r;
        }

        internal static bool OPDPrescriptionDelete(Guid guid)
        {
            return Execute(OPDPrescription_Delete, OPDPrescription.Columns.OPDPrescriptionProcedureGuid, guid);
        }
        internal static SqlDataReader OPDPrescriptionSelect(Guid guid)
        {
            return GetReader(OPDPrescription_Select, OPDPrescription.Columns.OPDPrescriptionProcedureGuid, guid);
        }
        internal static SqlDataReader OPDPrescriptionSelectAll()
        {
            return GetReader(OPDPrescription_SelectAll);
        }
        internal static SqlDataReader OPDPrescriptionSearch(Guid PatientGuid)
        {
            return GetReader(OPDPrescription_Search, OPDPrescription.Columns.OPDPrescriptionPatientGuid, SqlDbType.UniqueIdentifier, PatientGuid);
        }
        private static void OPDPrescriptionParameters(SqlCommand cmd, Guid OPDPrescriptionProcedureGuid, Guid PatientGuid, string Doseage, string Timings,
                                                       DateTime OPDPrescriptionDate, Guid ModifiedBy)
        {
            AppDatabase.AddInParameter(cmd, OPDPrescription.Columns.OPDPrescriptionProcedureGuid, SqlDbType.UniqueIdentifier, OPDPrescriptionProcedureGuid);
            AppDatabase.AddInParameter(cmd, OPDPrescription.Columns.OPDPrescriptionPatientGuid, SqlDbType.UniqueIdentifier, PatientGuid);
            AppDatabase.AddInParameter(cmd, OPDPrescription.Columns.Doseage, SqlDbType.VarChar, Doseage);
            AppDatabase.AddInParameter(cmd, OPDPrescription.Columns.Timings, SqlDbType.VarChar, Timings);
            AppDatabase.AddInParameter(cmd, OPDPrescription.Columns.OPDPrescriptionDate, SqlDbType.DateTime, OPDPrescriptionDate);
            AppDatabase.AddInParameter(cmd, OPDPrescription.Columns.OPDPrescriptionModifiedBy, SqlDbType.UniqueIdentifier, ModifiedBy);
        }

    }
}
