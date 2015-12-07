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
        private const string IPDTreatment_Insert = "IPDTreatment_Insert";
        private const string IPDTreatment_Update = "IPDTreatment_Update";
        private const string IPDTreatment_Delete = "IPDTreatment_Delete";
        private const string IPDTreatment_Select = "IPDTreatment_Select";
        private const string IPDTreatment_SelectAll = "IPDTreatment_SelectAll";
        private const string IPDTreatment_Search = "IPDTreatment_Search";

        internal static bool TreatmentInsert(Guid guid, string name, string description, Guid createdByUser, out DateTime createdOn)
        {
            bool r = false;
            createdOn = DateTime.MinValue;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(IPDTreatment_Insert))
            {
                TreatmentParameters(cmd, guid, name, description, createdByUser);
                SqlParameter prmModifiedOn = AppDatabase.AddOutParameter(cmd, IPDTreatment.Columns.TreatmentModifiedOn, SqlDbType.DateTime);
                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);
                if (r)
                    createdOn = AppShared.DbValueToDateTime(prmModifiedOn.Value);
            }
            return r;
        }

        internal static bool TreatmentUpdate(Guid guid, string name, string description, Guid modifiedByUser, out DateTime modifiedOn)
        {
            bool r = false;
            modifiedOn = DateTime.MinValue;

            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(IPDTreatment_Update))
            {
                TreatmentParameters(cmd, guid, name, description, modifiedByUser);
                SqlParameter prmDate = AppDatabase.AddOutParameter(cmd, IPDTreatment.Columns.TreatmentModifiedOn, SqlDbType.DateTime);

                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);
                if (r)
                {
                    modifiedOn = AppShared.DbValueToDateTime(prmDate.Value);
                }
            }

            return r;
        }

        internal static bool TreatmentDelete(Guid guid)
        {
            return Execute(IPDTreatment_Delete, IPDTreatment.Columns.TreatmentGuid, guid);
        }

        internal static SqlDataReader TreatmentSelect(Guid guid)
        {
            return GetReader(IPDTreatment_Select, IPDTreatment.Columns.TreatmentGuid, guid);
        }

        internal static SqlDataReader TreatmentSelectAll()
        {
            return GetReader(IPDTreatment_SelectAll);
        }

        internal static SqlDataReader TreatmentSearch(string searchText)
        {
            return GetReader(IPDTreatment_Search, "@SearchText", SqlDbType.NVarChar, AppShared.ToDbLikeText(searchText));
        }

        private static void TreatmentParameters(SqlCommand cmd, Guid guid, string name, string description, Guid modifiedBy)
        {
            AppDatabase.AddInParameter(cmd,  IPDTreatment.Columns.TreatmentGuid, SqlDbType.UniqueIdentifier, guid);
            AppDatabase.AddInParameter(cmd, IPDTreatment.Columns.TreatmentName, SqlDbType.NVarChar, AppShared.SafeString(name));
            AppDatabase.AddInParameter(cmd, IPDTreatment.Columns.TreatmentDescription, SqlDbType.NVarChar, AppShared.SafeString(description));
            AppDatabase.AddInParameter(cmd, IPDTreatment.Columns.TreatmentModifiedBy, SqlDbType.UniqueIdentifier, modifiedBy);
        }
    }
}
