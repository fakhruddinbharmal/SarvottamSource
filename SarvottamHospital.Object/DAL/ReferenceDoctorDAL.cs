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
        private const string ReferenceDoctor_Insert = "ReferenceDoctor_Insert";
        private const string ReferenceDoctor_Update = "ReferenceDoctor_Update";
        private const string ReferenceDoctor_Delete = "ReferenceDoctor_Delete";
        private const string ReferenceDoctor_Select = "ReferenceDoctor_Select";
        private const string ReferenceDoctor_SelectAll = "ReferenceDoctor_SelectAll";
        private const string ReferenceDoctor_Search = "ReferenceDoctor_Search";

        internal static bool ReferenceDoctorInsert(Guid guid, string name, string description, decimal share, Guid createdByUser, out DateTime createdOn)
        {
            bool r = false;
            createdOn = DateTime.MinValue;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(ReferenceDoctor_Insert))
            {
                ReferenceDoctorParameters(cmd, guid, name, description,share, createdByUser);
                SqlParameter prmModifiedOn = AppDatabase.AddOutParameter(cmd, ReferenceDoctor.Columns.ReferenceDoctorModifiedOn, SqlDbType.DateTime);
                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);
                if (r)
                    createdOn = AppShared.DbValueToDateTime(prmModifiedOn.Value);
            }
            return r;
        }

        internal static bool ReferenceDoctorUpdate(Guid guid, string name, string description, decimal share, Guid modifiedByUser, out DateTime modifiedOn)
        {
            bool r = false;
            modifiedOn = DateTime.MinValue;

            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(ReferenceDoctor_Update))
            {
                ReferenceDoctorParameters(cmd, guid, name, description,share, modifiedByUser);
                SqlParameter prmDate = AppDatabase.AddOutParameter(cmd, ReferenceDoctor.Columns.ReferenceDoctorModifiedOn, SqlDbType.DateTime);

                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);
                if (r)
                {
                    modifiedOn = AppShared.DbValueToDateTime(prmDate.Value);
                }
            }

            return r;
        }

        internal static bool ReferenceDoctorDelete(Guid guid)
        {
            return Execute(ReferenceDoctor_Delete, ReferenceDoctor.Columns.ReferenceDoctorGuid, guid);
        }

        internal static SqlDataReader ReferenceDoctorSelect(Guid guid)
        {
            return GetReader(ReferenceDoctor_Select, ReferenceDoctor.Columns.ReferenceDoctorGuid, guid);
        }

        internal static SqlDataReader ReferenceDoctorSelectAll()
        {
            return GetReader(ReferenceDoctor_SelectAll);
        }

        internal static SqlDataReader ReferenceDoctorSearch(string searchText)
        {
            return GetReader(ReferenceDoctor_Search, "@SearchText", SqlDbType.NVarChar, AppShared.ToDbLikeText(searchText));
        }

        private static void ReferenceDoctorParameters(SqlCommand cmd, Guid guid, string name, string description, decimal share, Guid modifiedBy)
        {
            AppDatabase.AddInParameter(cmd, ReferenceDoctor.Columns.ReferenceDoctorGuid, SqlDbType.UniqueIdentifier, guid);
            AppDatabase.AddInParameter(cmd, ReferenceDoctor.Columns.ReferenceDoctorName, SqlDbType.NVarChar, AppShared.SafeString(name));
            AppDatabase.AddInParameter(cmd, ReferenceDoctor.Columns.ReferenceDoctorDescription, SqlDbType.NVarChar, AppShared.SafeString(description));
            AppDatabase.AddInParameter(cmd, ReferenceDoctor.Columns.ReferenceDoctorShare, SqlDbType.Float, AppShared.ToDbValueNullable(share));
            AppDatabase.AddInParameter(cmd, ReferenceDoctor.Columns.ReferenceDoctorModifiedBy, SqlDbType.UniqueIdentifier, modifiedBy);
        }
    }
}
