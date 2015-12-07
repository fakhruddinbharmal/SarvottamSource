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
        private const string Procedure_Insert = "Procedure_Insert";
        private const string Procedure_Update = "Procedure_Update";
        private const string Procedure_Delete = "Procedure_Delete";
        private const string Procedure_Select = "Procedure_Select";
        private const string Procedure_SelectAll = "Procedure_SelectAll";
        private const string Procedure_Search = "Procedure_Search";

        internal static bool ProcedureInsert(Guid guid, string name, string description, Guid createdByUser, out DateTime createdOn)
        {
            bool r = false;
            createdOn = DateTime.MinValue;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(Procedure_Insert))
            {
                ProcedureParameters(cmd, guid, name, description, createdByUser);
                SqlParameter prmModifiedOn = AppDatabase.AddOutParameter(cmd, Procedure.Columns.ProcedureModifiedOn, SqlDbType.DateTime);
                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);
                if (r)
                    createdOn = AppShared.DbValueToDateTime(prmModifiedOn.Value);
            }
            return r;
        }

        internal static bool ProcedureUpdate(Guid guid, string name, string description, Guid modifiedByUser, out DateTime modifiedOn)
        {
            bool r = false;
            modifiedOn = DateTime.MinValue;

            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(Procedure_Update))
            {
                ProcedureParameters(cmd, guid, name, description, modifiedByUser);
                SqlParameter prmDate = AppDatabase.AddOutParameter(cmd, Procedure.Columns.ProcedureModifiedOn, SqlDbType.DateTime);

                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);
                if (r)
                {
                    modifiedOn = AppShared.DbValueToDateTime(prmDate.Value);
                }
            }

            return r;
        }

        internal static bool ProcedureDelete(Guid guid)
        {
            return Execute(Procedure_Delete, Procedure.Columns.PrecedureGuid, guid);
        }

        internal static SqlDataReader ProcedureSelect(Guid guid)
        {
            return GetReader(Procedure_Select, Procedure.Columns.PrecedureGuid, guid);
        }

        internal static SqlDataReader ProcedureSelectAll()
        {
            return GetReader(Procedure_SelectAll);
        }

        internal static SqlDataReader ProcedureSearch(string searchText)
        {
            return GetReader(Procedure_Search, "@SearchText", SqlDbType.NVarChar, AppShared.ToDbLikeText(searchText));
        }

        private static void ProcedureParameters(SqlCommand cmd, Guid guid, string name, string description, Guid modifiedBy)
        {
            AppDatabase.AddInParameter(cmd, Procedure.Columns.PrecedureGuid, SqlDbType.UniqueIdentifier, guid);
            AppDatabase.AddInParameter(cmd, Procedure.Columns.ProcedureName, SqlDbType.NVarChar, AppShared.SafeString(name));
            AppDatabase.AddInParameter(cmd, Procedure.Columns.ProcedureDescription, SqlDbType.NVarChar, AppShared.SafeString(description));
            AppDatabase.AddInParameter(cmd, Procedure.Columns.ProcedureModifiedBy, SqlDbType.UniqueIdentifier, modifiedBy);
        }
    }
}
