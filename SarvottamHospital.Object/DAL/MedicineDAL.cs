using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SarvottamHospital.Object
{
    internal static partial class AppDAL
    {
        public const string Medicine_Insert         = "Medicine_Insert";
        public const string Medicine_Update         = "Medicine_Update";
        public const string Medicine_Delete         = "Medicine_Delete";
        public const string Medicine_Select         = "Medicine_Select";
        public const string Medicine_SelectAll      = "Medicine_SelectAll";
        public const string Medicine_Search         = "Medicine_Search";

        internal static bool MedicineInsert(Guid Medicineguid, Guid ChiefComplainGuid, string MedicineName, string Description, Guid createdByUser, out DateTime createdOn)
        {
            bool r = false;
            createdOn = DateTime.MinValue;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(Medicine_Insert))
            {
                MedicineParameters(cmd, Medicineguid, ChiefComplainGuid, MedicineName, Description, createdByUser);
                SqlParameter prmDate = AppDatabase.AddOutParameter(cmd, Medicine.Columns.MedicineModifiedOn, SqlDbType.DateTime);

                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);
                if (r)
                {
                    createdOn = AppShared.DbValueToDateTime(prmDate.Value);
                }
            }
            return r;
        }


        internal static bool MedicineUpdate(Guid Medicineguid, Guid ChiefComplainGuid, string MedicineName, string Description, Guid modifiedByUser, out DateTime modifiedOn)
        {
            bool r = false;
            modifiedOn = DateTime.MinValue;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(Medicine_Update))
            {
                MedicineParameters(cmd, Medicineguid, ChiefComplainGuid, MedicineName, Description, modifiedByUser);
                SqlParameter prmDate = AppDatabase.AddOutParameter(cmd, Medicine.Columns.MedicineModifiedOn, SqlDbType.DateTime);

                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);
                if (r)
                {
                    modifiedOn = AppShared.DbValueToDateTime(prmDate.Value);
                }
            }
            return r;
        }

        internal static bool MedicineDelete(Guid guid)
        {
            return Execute(Medicine_Delete, Medicine.Columns.MedicineGuid, guid);
        }
        internal static SqlDataReader MedicineSelect(Guid guid)
        {
            return GetReader(Medicine_Select, Medicine.Columns.MedicineGuid, guid);
        }
        internal static SqlDataReader MedicineSelectAll()
        {
            return GetReader(Medicine_SelectAll);
        }
        internal static SqlDataReader MedicineSearch(string SearchText)
        {
            return GetReader(Medicine_Search, "@SearchText", SqlDbType.NVarChar, AppShared.ToDbLikeText(SearchText));
        }
        private static void MedicineParameters(SqlCommand cmd, Guid MedicineGuid, Guid ChiefComplainGuid, string MedicineName, string MedicineDescription, Guid modifiedBy)
        {
            AppDatabase.AddInParameter(cmd, Medicine.Columns.MedicineGuid, SqlDbType.UniqueIdentifier, MedicineGuid);
            AppDatabase.AddInParameter(cmd, Medicine.Columns.ChiefComplainGuid, SqlDbType.UniqueIdentifier, ChiefComplainGuid);
            AppDatabase.AddInParameter(cmd, Medicine.Columns.MedicineName, SqlDbType.NVarChar, AppShared.SafeString(MedicineName));
            AppDatabase.AddInParameter(cmd, Medicine.Columns.MedicineDescription, SqlDbType.NVarChar, AppShared.ToDbValueNullable(MedicineDescription));
            AppDatabase.AddInParameter(cmd, Medicine.Columns.MedicineModifiedBy, SqlDbType.UniqueIdentifier, modifiedBy);
        }
    }
}
