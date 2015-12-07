using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SarvottamHospital.Object
{
    internal static partial class AppDAL
    {
        private const string Field_Insert = "Field_Insert";
        private const string Field_Update = "Field_Update";
        private const string Field_Delete = "Field_Delete";
        private const string Field_Select = "Field_Select";
        private const string Field_SelectAll = "Field_SelectAll";

        internal static bool FieldInsert(Guid guid, string name, out int id)
        {
            bool r = false;
            id = 0;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(Field_Insert))
            {
                FieldParameters(cmd, guid, name);

                SqlParameter prmId = AppDatabase.AddOutParameter(cmd, "@FieldId", SqlDbType.Int);

                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);
                if (r)
                {
                    id = AppShared.DbValueToInteger(prmId.Value);
                }
            }
            return r;
        }

        internal static bool FieldUpdate(Guid guid, string name)
        {
            bool r = false;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(Field_Update))
            {
                FieldParameters(cmd, guid, name);
                AppDatabase db = OpenDatabase();
                if (db != null && db.ExecuteCommand(cmd))
                {
                    r = true;
                }
            }
            return r;
        }

        internal static bool FieldDelete(Guid guid)
        {
            return Execute(Field_Delete, "@FieldGuid", guid);
        }

        internal static SqlDataReader FieldSelect(Guid guid)
        {
            return GetReader(Field_Select, "@FieldGuid", guid);
        }

        internal static SqlDataReader FieldSelectAll()
        {
            return GetReader(Field_SelectAll);
        }

        private static void FieldParameters(SqlCommand cmd, Guid guid, string name)
        {
            AppDatabase.AddInParameter(cmd, Field.Columns.Guid, SqlDbType.UniqueIdentifier, guid);
            AppDatabase.AddInParameter(cmd, Field.Columns.Name, SqlDbType.NVarChar, AppShared.SafeString(name));
        }
    }
}
