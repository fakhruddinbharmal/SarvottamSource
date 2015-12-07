using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SarvottamHospital.Object
{
    internal static partial class AppDAL
    {
        public const string InvestigationProcedure_Insert = "InvestigationProcedure_Insert";
        public const string InvestigationProcedure_Update = "InvestigationProcedure_Update";
        public const string InvestigationProcedure_Delete = "InvestigationProcedure_Delete";
        public const string InvestigationProcedure_Select = "InvestigationProcedure_Select";
        public const string InvestigationProcedure_SelectAll = "InvestigationProcedure_SelectAll";
        public const string InvestigationProcedure_Search = "InvestigationProcedure_Search";



        internal static bool InvestigationProcedureInsert(Guid InvestigationProcedureGuid, Guid MainInvestigationGUID, Guid LabInvestigationGUID, string RadiologyInvestigation, string SpecialInvestigation, DateTime InvestigationProcedureDate, Guid createdByUser, out DateTime createdOn)
        {
            bool r = false;
            //id = 0;
            createdOn = DateTime.MinValue;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(InvestigationProcedure_Insert))
            {
                InvestigationProcedureParameter(cmd, InvestigationProcedureGuid, MainInvestigationGUID, LabInvestigationGUID, RadiologyInvestigation, SpecialInvestigation, InvestigationProcedureDate, createdByUser);
                //  SqlParameter prmId = AppDatabase.AddOutParameter(cmd, InvestigationProcedure.Columns.InvestigationProcedureId, SqlDbType.Int);
                SqlParameter prmDate = AppDatabase.AddOutParameter(cmd, InvestigationProcedure.Columns.InvestigationProcedureModifiedOn, SqlDbType.DateTime);

                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);
                if (r)
                {
                    //id = AppShared.DbValueToInteger(prmId.Value);
                    createdOn = AppShared.DbValueToDateTime(prmDate.Value);
                }
            }
            return r;
        }

        internal static bool InvestigationProcedureUpdate(Guid InvestigationProcedureGuid, Guid MainInvestigationGUID, Guid LabInvestigationGUID, string RadiologyInvestigation, string SpecialInvestigation, DateTime InvestigationProcedureDate, Guid modifiedByUser, out DateTime modifiedOn)
        {
            bool r = false;
            modifiedOn = DateTime.MinValue;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(InvestigationProcedure_Update))
            {
                InvestigationProcedureParameter(cmd, InvestigationProcedureGuid, MainInvestigationGUID, LabInvestigationGUID, RadiologyInvestigation, SpecialInvestigation, InvestigationProcedureDate, modifiedByUser);
                SqlParameter prmDate = AppDatabase.AddOutParameter(cmd, InvestigationProcedure.Columns.InvestigationProcedureModifiedOn, SqlDbType.DateTime);

                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);
                if (r)
                {
                    modifiedOn = AppShared.DbValueToDateTime(prmDate.Value);
                }
            }
            return r;
        }
        internal static bool InvestigationProcedureDelete(Guid guid)
        {
            return Execute(InvestigationProcedure_Delete, InvestigationProcedure.Columns.InvestigationProcedureGuid, guid);
        }
        internal static SqlDataReader InvestigationProcedureSelect(Guid guid)
        {
            return GetReader(InvestigationProcedure_Select, InvestigationProcedure.Columns.InvestigationProcedureGuid, guid);
        }
        internal static SqlDataReader InvestigationProcedureSelectAll()
        {
            return GetReader(InvestigationProcedure_SelectAll);
        }
        internal static SqlDataReader InvestigationProcedureSearch(string SearchText)
        {
            return GetReader(InvestigationProcedure_Search, "@SearchText", SqlDbType.NVarChar, AppShared.ToDbLikeText(SearchText));
        }
        private static void InvestigationProcedureParameter(SqlCommand cmd, Guid InvestigationProcedureGuid, Guid MainInvestigationGUID, Guid LabInvestigationGUID, string RadiologyInvestigation, string SpecialInvestigation, DateTime InvestigationProcedureDate, Guid modifiedBy)
        {
            AppDatabase.AddInParameter(cmd, InvestigationProcedure.Columns.InvestigationProcedureGuid, SqlDbType.UniqueIdentifier, InvestigationProcedureGuid);
            AppDatabase.AddInParameter(cmd, InvestigationProcedure.Columns.MainInvestigationGUID, SqlDbType.UniqueIdentifier, MainInvestigationGUID);
            AppDatabase.AddInParameter(cmd, InvestigationProcedure.Columns.LabInvestigationGUID, SqlDbType.UniqueIdentifier, LabInvestigationGUID);
            AppDatabase.AddInParameter(cmd, InvestigationProcedure.Columns.InvestigationProcedureRadiologyInvestigation, SqlDbType.NVarChar, AppShared.SafeString(RadiologyInvestigation));
            AppDatabase.AddInParameter(cmd, InvestigationProcedure.Columns.InvestigationProcedureSpecialInvestigation, SqlDbType.NVarChar, AppShared.SafeString(SpecialInvestigation));
            AppDatabase.AddInParameter(cmd, InvestigationProcedure.Columns.InvestigationProcedureDate, SqlDbType.DateTime, InvestigationProcedureDate);
            AppDatabase.AddInParameter(cmd, InvestigationProcedure.Columns.InvestigationProcedureModifiedBy, SqlDbType.UniqueIdentifier, modifiedBy);
        }
    }
}
