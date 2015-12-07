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
        private const string Room_Insert = "Room_Insert";
        private const string Room_Update = "Room_Update";
        private const string Room_Delete = "Room_Delete";
        private const string Room_Select = "Room_Select";
        private const string Room_SelectAll = "Room_SelectAll";
        private const string Room_Search = "Room_Search";

        internal static bool RoomInsert(Guid guid, string type, string description, Guid createdByUser, out DateTime createdOn)
        {
            bool r = false;
            createdOn = DateTime.MinValue;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(Room_Insert))
            {
                RoomParameters(cmd, guid, type, description, createdByUser);
                SqlParameter prmModifiedOn = AppDatabase.AddOutParameter(cmd, Room.Columns.RoomModifiedOn, SqlDbType.DateTime);
                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);
                if (r)
                    createdOn = AppShared.DbValueToDateTime(prmModifiedOn.Value);
            }
            return r;
        }

        internal static bool RoomUpdate(Guid guid, string type, string description, Guid modifiedByUser, out DateTime modifiedOn)
        {
            bool r = false;
            modifiedOn = DateTime.MinValue;

            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(Room_Update))
            {
                RoomParameters(cmd, guid, type, description, modifiedByUser);
                SqlParameter prmDate = AppDatabase.AddOutParameter(cmd, Room.Columns.RoomModifiedOn, SqlDbType.DateTime);

                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);
                if (r)
                {
                    modifiedOn = AppShared.DbValueToDateTime(prmDate.Value);
                }
            }

            return r;
        }

        internal static bool RoomDelete(Guid guid)
        {
            return Execute(Room_Delete, Room.Columns.RoomGuid, guid);
        }

        internal static SqlDataReader RoomSelect(Guid guid)
        {
            return GetReader(Room_Select, Room.Columns.RoomGuid, guid);
        }

        internal static SqlDataReader RoomSelectAll()
        {
            return GetReader(Room_SelectAll);
        }

        internal static SqlDataReader RoomSearch(string searchText)
        {
            return GetReader(Room_Search, "@SearchText", SqlDbType.NVarChar, AppShared.ToDbLikeText(searchText));
        }

        private static void RoomParameters(SqlCommand cmd, Guid guid, string type, string description, Guid modifiedBy)
        {
            AppDatabase.AddInParameter(cmd, Room.Columns.RoomGuid, SqlDbType.UniqueIdentifier, guid);
            AppDatabase.AddInParameter(cmd, Room.Columns.RoomType, SqlDbType.NVarChar, AppShared.SafeString(type));
            AppDatabase.AddInParameter(cmd, Room.Columns.RoomDescription, SqlDbType.NVarChar, AppShared.SafeString(description));
            AppDatabase.AddInParameter(cmd, Room.Columns.RoomModifiedBy, SqlDbType.UniqueIdentifier, modifiedBy);
        }
    }
}
