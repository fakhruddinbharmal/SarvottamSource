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
         private const string TreatmentProcedure_Delete="TreatmentProcedure_Delete";
         private const string TreatmentProcedure_Insert="TreatmentProcedure_Insert";
         private const string TreatmentProcedure_Select="TreatmentProcedure_Select"; 
         private const string TreatmentProcedure_SelectAll="TreatmentProcedure_SelectAll"; 
         private const string TreatmentProcedure_Update="TreatmentProcedure_Update";
         private const string TreatmentProcedure_Search = "TreatmentProcedure_Search";

         internal static bool TreatmentProcedureInsert(Guid OPDTreatmentProcedureGuid, Guid OPDTreatmentProcedurePatientGuid, DateTime OPDTreatmentDate, Guid createdByUser,
                                                      out DateTime createdOn)
         { 
             bool r = false;
            createdOn = DateTime.MinValue;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(TreatmentProcedure_Insert))
            {
                OPDTreatmentProcedureParameters(cmd, OPDTreatmentProcedureGuid, OPDTreatmentProcedurePatientGuid, OPDTreatmentDate, createdByUser);
                SqlParameter prmDate = AppDatabase.AddOutParameter(cmd, OPDTreatmentProcedure.Columns.OPDTreatmentModifiedOn, SqlDbType.DateTime);
                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);
                if (r)
                {
                    createdOn = AppShared.DbValueToDateTime(prmDate.Value);
                }
            }
            return r;
         }

         internal static bool TreatmentProcedureUpdate(Guid OPDTreatmentProcedureGuid, Guid OPDTreatmentProcedurePatientGuid, DateTime OPDTreatmentDate, Guid modifiedByUser,
                                                      out DateTime modifiedOn)
         { 
             bool r = false;
            modifiedOn = DateTime.MinValue;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(TreatmentProcedure_Update))
            {
                OPDTreatmentProcedureParameters(cmd, OPDTreatmentProcedureGuid, OPDTreatmentProcedurePatientGuid, OPDTreatmentDate, modifiedByUser);
                SqlParameter prmDate = AppDatabase.AddOutParameter(cmd, OPDTreatmentProcedure.Columns.OPDTreatmentModifiedOn, SqlDbType.DateTime);
                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);
                if (r)
                {
                    modifiedOn = AppShared.DbValueToDateTime(prmDate.Value);
                }            
            }
            return r;
         }

         internal static bool TreatmentProcedureDelete(Guid guid)
         {
             return Execute(TreatmentProcedure_Delete, OPDTreatmentProcedure.Columns.OPDTreatmentProcedureGuid, guid);
         }

         internal static SqlDataReader TreatmentProcedureSelect(Guid guid)
         {
             return GetReader(TreatmentProcedure_Select, OPDTreatmentProcedure.Columns.OPDTreatmentProcedureGuid, guid);
         }

         internal static SqlDataReader TreatmentProcedureSelectAll()
         {
             return GetReader(TreatmentProcedure_SelectAll);
         }
         internal static SqlDataReader TreatmentProcedureSearch(Guid PatientGuid)
         {
             return GetReader(TreatmentProcedure_Search, OPDTreatmentProcedure.Columns.OPDTreatmentProcedurePatientGuid, SqlDbType.UniqueIdentifier, PatientGuid);
         }

         private static void OPDTreatmentProcedureParameters(SqlCommand cmd, Guid OPDTreatmentProcedureGuid, Guid OPDTreatmentProcedurePatientGuid, DateTime OPDTreatmentDate,Guid ModifiedBy)
         { 
             AppDatabase.AddInParameter(cmd,OPDTreatmentProcedure.Columns.OPDTreatmentProcedureGuid,SqlDbType.UniqueIdentifier,OPDTreatmentProcedureGuid);
             AppDatabase.AddInParameter(cmd,OPDTreatmentProcedure.Columns.OPDTreatmentProcedurePatientGuid,SqlDbType.UniqueIdentifier,OPDTreatmentProcedurePatientGuid);
             AppDatabase.AddInParameter(cmd,OPDTreatmentProcedure.Columns.OPDTreatmentDate, SqlDbType.DateTime, OPDTreatmentDate);
             AppDatabase.AddInParameter(cmd, OPDTreatmentProcedure.Columns.OPDTreatmentModifiedBy, SqlDbType.UniqueIdentifier, ModifiedBy);
         }
    }
}
