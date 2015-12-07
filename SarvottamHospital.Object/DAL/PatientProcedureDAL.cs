using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;


namespace SarvottamHospital.Object
{
    internal static partial class AppDAL
    {
        public const string PatientProcedure_Insert = "PatientProcedure_Insert";
        public const string PatientProcedure_Update = "PatientProcedure_Update";
        public const string PatientProcedure_Delete = "PatientProcedure_Delete";
        public const string PatientProcedure_Select = "PatientProcedure_Select";
        public const string PatientProcedure_SelectAll = "PatientProcedure_SelectAll";
        public const string PatientProcedure_Search = "PatientProcedure_Search";

        internal static bool PatientProcedureInsert(Guid patientProcedureGuid, Guid patientGuid, Guid procedureGuid, DateTime patientProcedureDate, decimal amount, string notes, Guid createdBy, out DateTime createdOn)
        {
            bool r = false;
            createdOn = DateTime.MinValue;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(PatientProcedure_Insert))
            {
                PatientProcedureParameter(cmd, patientProcedureGuid, patientGuid, procedureGuid,  patientProcedureDate, amount, notes, createdBy);
                SqlParameter prmDate = AppDatabase.AddOutParameter(cmd, PatientProcedure.Columns.PatientProcedureModifiedOn, SqlDbType.DateTime);
                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);
                if (r)
                {
                    createdOn = AppShared.DbValueToDateTime(prmDate.Value);
                }
            }
            return r;
        }

        internal static bool PatientProcedureUpdate(Guid patientProcedureGuid, Guid patientGuid, Guid procedureGuid, DateTime patientProcedureDate, decimal amount, string notes, Guid modifiedBy, out DateTime modifiedOn)
        {
            bool r = false;
            modifiedOn = DateTime.MinValue;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(PatientProcedure_Update))
            {
                PatientProcedureParameter(cmd, patientProcedureGuid, patientGuid, procedureGuid, patientProcedureDate, amount, notes, modifiedBy);
                SqlParameter prmDate = AppDatabase.AddOutParameter(cmd, PatientProcedure.Columns.PatientProcedureModifiedOn, SqlDbType.DateTime);
                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);
                if (r)
                {
                    modifiedOn = AppShared.DbValueToDateTime(prmDate.Value);
                }
            }
            return r;
        }

        internal static bool PatientProcedureDelete(Guid guid)
        {
            return Execute(PatientProcedure_Delete, PatientProcedure.Columns.PatientProcedureGuid, guid);
        }

        internal static SqlDataReader PatientProcedureSelect(Guid guid)
        {
            return GetReader(PatientProcedure_Select, PatientProcedure.Columns.PatientProcedureGuid, guid);
        }

        //internal static SqlDataReader PatientProcedureSelectAll(Guid patientGuid)
        //{
        //    return GetReader(PatientProcedure_SelectAll, PatientProcedure.Columns.PatientGuid, patientGuid);
        //}

        internal static SqlDataReader PatientProcedureSearch(Guid patientGuid)
        {
            return GetReader(PatientProcedure_Search, PatientProcedure.Columns.PatietProcedurePatientGuid, SqlDbType.UniqueIdentifier, patientGuid);
        }

        private static void PatientProcedureParameter(SqlCommand cmd, Guid patientProcedureGuid, Guid patientGuid, Guid procedureGuid, DateTime patientProcedureDate, decimal amount, string notes, Guid modifiedBy)
        {
            AppDatabase.AddInParameter(cmd, PatientProcedure.Columns.PatientProcedureGuid, SqlDbType.UniqueIdentifier, patientProcedureGuid);
            AppDatabase.AddInParameter(cmd, PatientProcedure.Columns.PatietProcedurePatientGuid, SqlDbType.UniqueIdentifier, patientGuid);
            AppDatabase.AddInParameter(cmd, PatientProcedure.Columns.PatientProcedureProcedureGuid, SqlDbType.UniqueIdentifier, procedureGuid);
            AppDatabase.AddInParameter(cmd, PatientProcedure.Columns.PatientProcedureDate, SqlDbType.DateTime, AppShared.ToDbValueNullable(patientProcedureDate));
            AppDatabase.AddInParameter(cmd, PatientProcedure.Columns.PatientProcedureAmount, SqlDbType.Decimal, AppShared.ToDbValueNullable(amount));
            AppDatabase.AddInParameter(cmd, PatientProcedure.Columns.PatientProcedureNotes, SqlDbType.NVarChar, AppShared.ToDbValueNullable(notes));
            AppDatabase.AddInParameter(cmd, PatientProcedure.Columns.PatientProcedureModifiedBy, SqlDbType.UniqueIdentifier, modifiedBy);
        }
    }
}
