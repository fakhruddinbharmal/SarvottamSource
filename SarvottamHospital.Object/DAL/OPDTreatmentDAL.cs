using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SarvottamHospital.Object
{
    internal static partial class AppDAL
    {
        public const string Treatment_Insert =   "Treatment_Insert";
        public const string Treatment_Update =   "Treatment_Update";
        public const string Treatment_Delete =   "Treatment_Delete";
        public const string Treatment_Select =   "Treatment_Select";
        public const string Treatment_SelectAll= "Treatment_SelectAll";
        public const string Treatment_Search =   "Treatment_Search";

        internal static bool OPDTreatmentInsert(Guid Treatmentguid, Guid ChiefComplainGuid, string TreatmentName, string Description, Guid createdByUser, out DateTime createdOn)
        {
            bool r = false;
            createdOn = DateTime.MinValue;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(Treatment_Insert))
            {
                OPDTreatmentParameters(cmd, Treatmentguid, ChiefComplainGuid, TreatmentName, Description, createdByUser);
                SqlParameter prmDate = AppDatabase.AddOutParameter(cmd, OPDTreatment.Columns.TreatmentModifiedOn, SqlDbType.DateTime);

                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);
                if (r)
                {
                    createdOn = AppShared.DbValueToDateTime(prmDate.Value);
                }
            }
            return r;
        }


        internal static bool OPDTreatmentUpdate(Guid Treatmentguid, Guid ChiefComplainGuid, string TreatmentName, string Description, Guid modifiedByUser, out DateTime modifiedOn)
        {
            bool r = false;
            modifiedOn = DateTime.MinValue;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(Treatment_Update))
            {
                OPDTreatmentParameters(cmd, Treatmentguid, ChiefComplainGuid, TreatmentName, Description, modifiedByUser);
                SqlParameter prmDate = AppDatabase.AddOutParameter(cmd, OPDTreatment.Columns.TreatmentModifiedOn, SqlDbType.DateTime);

                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);
                if (r)
                {
                    modifiedOn = AppShared.DbValueToDateTime(prmDate.Value);
                }
            }
            return r;
        }

        internal static bool OPDTreatmentDelete(Guid guid)
        {
            return Execute(Treatment_Delete, OPDTreatment.Columns.TreatmentGuid, guid);
        }
        internal static SqlDataReader OPDTreatmentSelect(Guid guid)
        {
            return GetReader(Treatment_Select, OPDTreatment.Columns.TreatmentGuid, guid);
        }
        internal static SqlDataReader OPDTreatmentSelectAll()
        {
            return GetReader(Treatment_SelectAll);
        }
        internal static SqlDataReader OPDTreatmentSearch(string SearchText)
        {
            return GetReader(Treatment_Search, "@SearchText", SqlDbType.NVarChar, AppShared.ToDbLikeText(SearchText));
        }
        private static void OPDTreatmentParameters(SqlCommand cmd, Guid TreatmentGuid, Guid ChiefComplainGuid, string TreatmentName, string TreatmentDescription,Guid modifiedBy)
        { 
            AppDatabase.AddInParameter(cmd, OPDTreatment.Columns.TreatmentGuid, SqlDbType.UniqueIdentifier, TreatmentGuid);
            AppDatabase.AddInParameter(cmd, OPDTreatment.Columns.ChiefComplainGuid, SqlDbType.UniqueIdentifier, ChiefComplainGuid);
            AppDatabase.AddInParameter(cmd, OPDTreatment.Columns.TreatmentName, SqlDbType.NVarChar, AppShared.SafeString(TreatmentName));
            AppDatabase.AddInParameter(cmd, OPDTreatment.Columns.TreatmentDescription, SqlDbType.NVarChar, AppShared.ToDbValueNullable(TreatmentDescription));
            AppDatabase.AddInParameter(cmd, OPDTreatment.Columns.TreatmentModifiedBy, SqlDbType.UniqueIdentifier, modifiedBy);            
        }
    }
}
