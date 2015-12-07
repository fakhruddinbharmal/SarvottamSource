using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SarvottamHospital.Object
{
    internal static partial class AppDAL
    {
        public const string AssociateComplain_Insert    = "AssociateComplain_Insert";
        public const string AssociateComplain_Update     ="AssociateComplain_Update";
        public const string AssociateComplain_Delete    = "AssociateComplain_Delete";
        public const string AssociateComplain_Select    = "AssociateComplain_Select";
        public const string AssociateComplain_SelectAll = "AssociateComplain_SelectAll";
        public const string AssociateComplain_Search    = "AssociateComplain_Search";



        internal static bool AssociateComplainInsert(Guid AssociateComplainGuid, string AssociateComplainName, string AssociateComplainDescription, Guid createdByUser, out DateTime createdOn)
        {
            bool r = false;
            //id = 0;
            createdOn = DateTime.MinValue;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(AssociateComplain_Insert))
            {
                AssociateComplainParameter(cmd, AssociateComplainGuid, AssociateComplainName, AssociateComplainDescription, createdByUser);
                //  SqlParameter prmId = AppDatabase.AddOutParameter(cmd, AssociateComplain.Columns.AssociateComplainId, SqlDbType.Int);
                SqlParameter prmDate = AppDatabase.AddOutParameter(cmd, AssociateComplain.Columns.AssociateComplainModifiedOn, SqlDbType.DateTime);

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

        internal static bool AssociateComplainUpdate(Guid AssociateComplainGuid, string AssociateComplainName, string AssociateComplainDescription, Guid modifiedByUser, out DateTime modifiedOn)
        {
            bool r = false;
            modifiedOn = DateTime.MinValue;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(AssociateComplain_Update))
            {
                AssociateComplainParameter(cmd, AssociateComplainGuid, AssociateComplainName, AssociateComplainDescription, modifiedByUser);
                SqlParameter prmDate = AppDatabase.AddOutParameter(cmd, AssociateComplain.Columns.AssociateComplainModifiedOn, SqlDbType.DateTime);

                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);
                if (r)
                {
                    modifiedOn = AppShared.DbValueToDateTime(prmDate.Value);
                }
            }
            return r;
        }
        internal static bool AssociateComplainDelete(Guid guid)
        {
            return Execute(AssociateComplain_Delete, AssociateComplain.Columns.AssociateComplainGuid, guid);
        }
        internal static SqlDataReader AssociateComplainSelect(Guid guid)
        {
            return GetReader(AssociateComplain_Select, AssociateComplain.Columns.AssociateComplainGuid, guid);
        }
        internal static SqlDataReader AssociateComplainSelectAll()
        {
            return GetReader(AssociateComplain_SelectAll);
        }
        internal static SqlDataReader AssociateComplainSearch(string SearchText)
        {
            return GetReader(AssociateComplain_Search, "@SearchText", SqlDbType.NVarChar, AppShared.ToDbLikeText(SearchText));
        }
        private static void AssociateComplainParameter(SqlCommand cmd, Guid AssociateComplainGuid, string AssociateComplainName, string AssociateComplainDescription, Guid modifiedBy)
        {
            AppDatabase.AddInParameter(cmd, AssociateComplain.Columns.AssociateComplainGuid, SqlDbType.UniqueIdentifier, AssociateComplainGuid);
            AppDatabase.AddInParameter(cmd, AssociateComplain.Columns.AssociateComplainName, SqlDbType.NVarChar, AppShared.SafeString(AssociateComplainName));
            AppDatabase.AddInParameter(cmd, AssociateComplain.Columns.AssociateComplainDescription, SqlDbType.NVarChar, AppShared.ToDbValueNullable(AssociateComplainDescription));
            AppDatabase.AddInParameter(cmd, AssociateComplain.Columns.AssociateComplainModifiedBy, SqlDbType.UniqueIdentifier, modifiedBy);
        }
    }
}
