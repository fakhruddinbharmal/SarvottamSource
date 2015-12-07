using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;


namespace SarvottamHospital.Object
{
    internal static partial class AppDAL
    {
        public const string OPDInvestigationProcedure_Insert = "OPDInvestigationProcedure_Insert";
        public const string OPDInvestigationProcedure_Update = "OPDInvestigationProcedure_Update";
        public const string OPDInvestigationProcedure_Delete = "OPDInvestigationProcedure_Delete";
        public const string OPDInvestigationProcedure_Select = "OPDInvestigationProcedure_Select";
        public const string OPDInvestigationProcedure_SelectAll = "OPDInvestigationProcedure_SelectAll";
        public const string OPDInvestigationProcedure_Search = "OPDInvestigationProcedure_Search";

        internal static bool OPDInvestigationProcedureInsert(Guid OPDInvestigationProcedureGuid, Guid PatientGuid, string RadiologyInvestigation,
                                                                string SpecialInvestigation, DateTime OPDInvestigationProcedureDate, Guid createdByUser, out DateTime createdOn)
        { 
             bool r = false;
            createdOn = DateTime.MinValue;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(OPDInvestigationProcedure_Insert))
            {
                OPDInvestigationProcedureParameters(cmd, OPDInvestigationProcedureGuid, PatientGuid, RadiologyInvestigation, SpecialInvestigation,
                                                    OPDInvestigationProcedureDate, createdByUser);
                SqlParameter prmDate = AppDatabase.AddOutParameter(cmd, OPDInvestigationProcedure.Columns.OPDInvestigationProcedureModifiedOn, SqlDbType.DateTime);
                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);
                if (r)
                {
                    createdOn = AppShared.DbValueToDateTime(prmDate.Value);
                }
            }
            return r;
        }

        internal static bool OPDInvestigationProcedureUpdate(Guid OPDInvestigationProcedureGuid, Guid PatientGuid, string RadiologyInvestigation,
                                                                string SpecialInvestigation, DateTime OPDInvestigationProcedureDate, Guid modifiedByUser, out DateTime modifiedOn)
        { 
               bool r = false;
            modifiedOn = DateTime.MinValue;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(OPDInvestigationProcedure_Update))
            {
                OPDInvestigationProcedureParameters(cmd, OPDInvestigationProcedureGuid, PatientGuid, RadiologyInvestigation, SpecialInvestigation,
                                                    OPDInvestigationProcedureDate, modifiedByUser);
                SqlParameter prmDate = AppDatabase.AddOutParameter(cmd, OPDInvestigationProcedure.Columns.OPDInvestigationProcedureModifiedOn, SqlDbType.DateTime);
                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);
                if (r)
                {
                    modifiedOn = AppShared.DbValueToDateTime(prmDate.Value);
                }
            }
            return r;
        }

        internal static bool OPDInvestigationProcedureDelete(Guid guid)
        {
            return Execute(OPDInvestigationProcedure_Delete, OPDInvestigationProcedure.Columns.OPDInvestigationProcedureGuid, guid);
        }

        internal static SqlDataReader OPDInvestigationProcedureSelect(Guid guid)
        {
            return GetReader(OPDInvestigationProcedure_Select, OPDInvestigationProcedure.Columns.OPDInvestigationProcedureGuid, guid);
        }

        internal static SqlDataReader OPDInvestigationProcedureSelectAll()
        {
            return GetReader(OPDInvestigationProcedure_SelectAll);
        }

        internal static SqlDataReader OPDInvestigationProcedureSearch(Guid patientGuid)
        {
            return GetReader(OPDInvestigationProcedure_Search,OPDInvestigationProcedure.Columns.OPDInvestigationProcedurePatientGuid, SqlDbType.UniqueIdentifier, patientGuid);
        }

        private static void OPDInvestigationProcedureParameters(SqlCommand cmd, Guid OPDInvestigationProcedureGuid, Guid PatientGuid, string RadiologyInvestigation,
                                                                string SpecialInvestigation, DateTime OPDInvestigationProcedureDate, Guid ModifiedBy)
        { 
         AppDatabase.AddInParameter(cmd,OPDInvestigationProcedure.Columns.OPDInvestigationProcedureGuid,SqlDbType.UniqueIdentifier,OPDInvestigationProcedureGuid);
         AppDatabase.AddInParameter(cmd,OPDInvestigationProcedure.Columns.OPDInvestigationProcedurePatientGuid,SqlDbType.UniqueIdentifier,PatientGuid);
         AppDatabase.AddInParameter(cmd,OPDInvestigationProcedure.Columns.RadiologyInvestigation,SqlDbType.VarChar,RadiologyInvestigation);
         AppDatabase.AddInParameter(cmd,OPDInvestigationProcedure.Columns.SpecialInvestigation,SqlDbType.VarChar,SpecialInvestigation);
         AppDatabase.AddInParameter(cmd,OPDInvestigationProcedure.Columns.OPDInvestigationProcedureDate,SqlDbType.DateTime,OPDInvestigationProcedureDate);
         AppDatabase.AddInParameter(cmd,OPDInvestigationProcedure.Columns.OPDInvestigationProcedureModifiedBy,SqlDbType.UniqueIdentifier,ModifiedBy);            
        }
    }
}
