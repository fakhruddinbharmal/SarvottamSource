using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SarvottamHospital.Object
{
    internal static partial class AppDAL
    {
        public const string ChiefComplain_Insert = "ChiefComplain_Insert";
        public const string ChiefComplain_Update = "ChiefComplain_Update";
        public const string ChiefComplain_Delete = "ChiefComplain_Delete";
        public const string ChiefComplain_Select = "ChiefComplain_Select";
        public const string ChiefComplain_SelectAll="ChiefComplain_SelectAll";
        public const string ChiefComplain_Search = "ChiefComplain_Search";

        internal static bool ChiefComplainInsert(Guid ChiefComplainGuid, string ChiefComplainName, string ChiefComplainDescription, Guid createdByUser, out DateTime createdOn)
        {
            bool r = false;
            //id = 0;
            createdOn = DateTime.MinValue;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(ChiefComplain_Insert))
            {
                ChiefComplainParameter(cmd, ChiefComplainGuid, ChiefComplainName, ChiefComplainDescription, createdByUser);
              //  SqlParameter prmId = AppDatabase.AddOutParameter(cmd, ChiefComplain.Columns.ChiefComplainId, SqlDbType.Int);
                SqlParameter prmDate = AppDatabase.AddOutParameter(cmd, ChiefComplain.Columns.ChiefComplainModifiedOn, SqlDbType.DateTime);

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

        internal static bool ChiefComplainUpdate(Guid ChiefComplainGuid, string ChiefComplainName, string ChiefComplainDescription, Guid modifiedByUser, out DateTime modifiedOn)
        {
            bool r = false;
            modifiedOn = DateTime.MinValue;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(ChiefComplain_Update))
            {
                ChiefComplainParameter(cmd, ChiefComplainGuid, ChiefComplainName, ChiefComplainDescription, modifiedByUser);
                SqlParameter prmDate = AppDatabase.AddOutParameter(cmd, ChiefComplain.Columns.ChiefComplainModifiedOn, SqlDbType.DateTime);

                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);
                if (r)
                {
                    modifiedOn = AppShared.DbValueToDateTime(prmDate.Value);
                }
            }
            return r;
        }
        internal static bool ChiefComplainDelete(Guid guid)
        {
            return Execute(ChiefComplain_Delete, ChiefComplain.Columns.ChiefComplainGuid, guid);
        }
        internal static SqlDataReader ChiefComplainSelect(Guid guid)
        {
            return GetReader(ChiefComplain_Select, ChiefComplain.Columns.ChiefComplainGuid, guid);
        }
        internal static SqlDataReader ChiefComplainSelectAll()
        {
            return GetReader(ChiefComplain_SelectAll);
        }
        internal static SqlDataReader ChiefComplainSearch(string SearchText)
        {
            return GetReader(ChiefComplain_Search, "@SearchText", SqlDbType.NVarChar, AppShared.ToDbLikeText(SearchText));
        }
        private static void ChiefComplainParameter(SqlCommand cmd, Guid ChiefComplainGuid, string ChiefComplainName, string ChiefComplainDescription, Guid modifiedBy)
        { 
            AppDatabase.AddInParameter(cmd, ChiefComplain.Columns.ChiefComplainGuid,SqlDbType.UniqueIdentifier,ChiefComplainGuid);
            AppDatabase.AddInParameter(cmd, ChiefComplain.Columns.ChiefComplainName,SqlDbType.NVarChar,AppShared.SafeString(ChiefComplainName));
            AppDatabase.AddInParameter(cmd, ChiefComplain.Columns.ChiefComplainDescription,SqlDbType.NVarChar,AppShared.ToDbValueNullable(ChiefComplainDescription));
            AppDatabase.AddInParameter(cmd, ChiefComplain.Columns.ChiefComplainModifiedBy, SqlDbType.UniqueIdentifier, modifiedBy);            
        }
    }
}
