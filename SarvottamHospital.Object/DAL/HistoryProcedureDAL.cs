using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace SarvottamHospital.Object
{
    internal static partial class AppDAL
    {
        public const string HistoryProcedure_Insert     = "HistoryProcedure_Insert";
        public const string HistoryProcedure_Update     = "HistoryProcedure_Update";
        public const string HistoryProcedure_Delete     = "HistoryProcedure_Delete";
        public const string HistoryProcedure_Select     = "HistoryProcedure_Select";
        public const string HistoryProcedure_SelectAll  = "HistoryProcedure_SelectAll";
        public const string HistoryProcedure_Search     = "HistoryProcedure_Search";

        internal static bool HistoryProcedureInsert(Guid HistoryProcedureGuid, Guid PatientGuid, string ProblemSince,
                                                     string AssociateComplainDuration, string FamilyHistory, string FamilyHistoryDuration, DateTime Date, Guid createdByUser, 
                                                     out DateTime createdOn)
        { 
            bool r = false;
            createdOn = DateTime.MinValue;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(HistoryProcedure_Insert))
            {
                HistoryProcedureParameter(cmd, HistoryProcedureGuid,PatientGuid, ProblemSince, AssociateComplainDuration, 
                                          FamilyHistory, FamilyHistoryDuration, Date, createdByUser);
                SqlParameter prmDate = AppDatabase.AddOutParameter(cmd, HistoryProcedure.Columns.HistoryProcedureModifiedOn, SqlDbType.DateTime);

                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);
                if (r)
                {
                    createdOn = AppShared.DbValueToDateTime(prmDate.Value);
                }
            }
            return r;
        }

        internal static bool HistoryProcedureUpdate(Guid HistoryProcedureGuid, Guid PatientGuid, string ProblemSince,
                                                     string AssociateComplainDuration, string FamilyHistory, string FamilyHistoryDuration, DateTime Date, Guid modifiedByUser,
                                                     out DateTime modifiedOn)
        {

            bool r = false;
            modifiedOn = DateTime.MinValue;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(HistoryProcedure_Update))
            {
                HistoryProcedureParameter(cmd, HistoryProcedureGuid,PatientGuid, ProblemSince, AssociateComplainDuration,
                                          FamilyHistory, FamilyHistoryDuration, Date, modifiedByUser);
                SqlParameter prmDate = AppDatabase.AddOutParameter(cmd, HistoryProcedure.Columns.HistoryProcedureModifiedOn, SqlDbType.DateTime);

                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);
                if (r)
                {
                    modifiedOn = AppShared.DbValueToDateTime(prmDate.Value);
                }
            }
            return r;
        }
        internal static bool HistoryProcedureDelete(Guid guid)
        {
            return Execute(HistoryProcedure_Delete, HistoryProcedure.Columns.HistoryProcedureGuid, guid);
        }
        internal static SqlDataReader HistoryProcedureSelect(Guid guid)
        {
            return GetReader(HistoryProcedure_Select, HistoryProcedure.Columns.HistoryProcedureGuid, guid);
        }
        internal static SqlDataReader HistoryProcedureSelectAll()
        {
            return GetReader(HistoryProcedure_SelectAll);
        }
        internal static SqlDataReader HistoryProcedureSearch(Guid patientGuid)
        {
            return GetReader(HistoryProcedure_Search, HistoryProcedure.Columns.HistoryProcedurePatientGuid, SqlDbType.UniqueIdentifier, patientGuid);
        }

        private static void HistoryProcedureParameter(SqlCommand cmd, Guid HistoryProcedureGuid, Guid PatientGuid, string ProblemSince,
                                                        string AssociateComplainDuration, string FamilyHistory, string FamilyHistoryDuration, DateTime Date, Guid ModifiedBy)
        { 
            AppDatabase.AddInParameter(cmd, HistoryProcedure.Columns.HistoryProcedureGuid,SqlDbType.UniqueIdentifier,HistoryProcedureGuid);
            AppDatabase.AddInParameter(cmd, HistoryProcedure.Columns.HistoryProcedurePatientGuid, SqlDbType.UniqueIdentifier, PatientGuid);
            AppDatabase.AddInParameter(cmd, HistoryProcedure.Columns.ProblemSince,SqlDbType.NVarChar,ProblemSince);
            AppDatabase.AddInParameter(cmd, HistoryProcedure.Columns.AssociateComplainDuration,SqlDbType.NVarChar,AssociateComplainDuration);
            AppDatabase.AddInParameter(cmd, HistoryProcedure.Columns.FamilyHistory,SqlDbType.NVarChar,FamilyHistory);
            AppDatabase.AddInParameter(cmd, HistoryProcedure.Columns.FamilyHistoryDuration,SqlDbType.NVarChar,FamilyHistoryDuration);
            AppDatabase.AddInParameter(cmd, HistoryProcedure.Columns.Date,SqlDbType.DateTime,Date);
            AppDatabase.AddInParameter(cmd, HistoryProcedure.Columns.HistoryProcedureModifiedBy,SqlDbType.UniqueIdentifier,ModifiedBy);

        }

    }
}
