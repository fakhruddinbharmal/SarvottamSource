using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SarvottamHospital.Object
{
    internal static partial class AppDAL
    {
        public const string OPDInvestigation_Insert = "OPDInvestigation_Insert";
        public const string OPDInvestigation_Update = "OPDInvestigation_Update";
        public const string OPDInvestigation_Delete = "OPDInvestigation_Delete";
        public const string OPDInvestigation_Select = "OPDInvestigation_Select";
        public const string OPDInvestigation_SelectAll = "OPDInvestigation_SelectAll";
        public const string OPDInvestigation_Search = "OPDInvestigation_Search";



        internal static bool OPDInvestigationInsert(Guid OPDInvestigationGuid, Guid MainInvestigationGUID, Guid LabInvestigationGUID,string OPDRadiologyInvestigation, string OPDSpecialInvestigation, DateTime OPDInvestigationDate, Guid createdByUser, out DateTime createdOn)
        {
            bool r = false;
            //id = 0;
            createdOn = DateTime.MinValue;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(OPDInvestigation_Insert))
            {
                OPDInvestigationParameter(cmd, OPDInvestigationGuid, MainInvestigationGUID, LabInvestigationGUID, OPDRadiologyInvestigation, OPDSpecialInvestigation, OPDInvestigationDate, createdByUser);
                //  SqlParameter prmId = AppDatabase.AddOutParameter(cmd, OPDInvestigation.Columns.OPDInvestigationId, SqlDbType.Int);
                SqlParameter prmDate = AppDatabase.AddOutParameter(cmd,  OPDInvestigation.Columns.OPDInvestigationModifiedOn, SqlDbType.DateTime);

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

        internal static bool OPDInvestigationUpdate(Guid OPDInvestigationGuid, Guid MainInvestigationGUID, Guid LabInvestigationGUID, string OPDRadiologyInvestigation, string OPDSpecialInvestigation, DateTime OPDInvestigationDate, Guid modifiedByUser, out DateTime modifiedOn)
        {
            bool r = false;
            modifiedOn = DateTime.MinValue;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(OPDInvestigation_Update))
            {
                OPDInvestigationParameter(cmd, OPDInvestigationGuid, MainInvestigationGUID, LabInvestigationGUID, OPDRadiologyInvestigation, OPDSpecialInvestigation, OPDInvestigationDate, modifiedByUser);
                SqlParameter prmDate = AppDatabase.AddOutParameter(cmd, OPDInvestigation.Columns.OPDInvestigationModifiedOn, SqlDbType.DateTime);

                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);
                if (r)
                {
                    modifiedOn = AppShared.DbValueToDateTime(prmDate.Value);
                }
            }
            return r;
        }
        internal static bool OPDInvestigationDelete(Guid guid)
        {
            return Execute(OPDInvestigation_Delete, OPDInvestigation.Columns.OPDInvestigationGuid, guid);
        }
        internal static SqlDataReader OPDInvestigationSelect(Guid guid)
        {
            return GetReader(OPDInvestigation_Select, OPDInvestigation.Columns.OPDInvestigationGuid, guid);
        }
        internal static SqlDataReader OPDInvestigationSelectAll()
        {
            return GetReader(OPDInvestigation_SelectAll);
        }
        internal static SqlDataReader OPDInvestigationSearch(string SearchText)
        {
            return GetReader(OPDInvestigation_Search, "@SearchText", SqlDbType.NVarChar, AppShared.ToDbLikeText(SearchText));
        }
        private static void OPDInvestigationParameter(SqlCommand cmd,Guid OPDInvestigationGuid, Guid MainInvestigationGUID, Guid LabInvestigationGUID, string OPDRadiologyInvestigation, string OPDSpecialInvestigation, DateTime OPDInvestigationDate, Guid modifiedBy)
        {
            AppDatabase.AddInParameter(cmd, OPDInvestigation.Columns.OPDInvestigationGuid, SqlDbType.UniqueIdentifier, OPDInvestigationGuid);
            AppDatabase.AddInParameter(cmd, OPDInvestigation.Columns.MainInvestigationGUID, SqlDbType.UniqueIdentifier, MainInvestigationGUID);
            AppDatabase.AddInParameter(cmd, OPDInvestigation.Columns.LabInvestigationGUID, SqlDbType.UniqueIdentifier, LabInvestigationGUID);
            AppDatabase.AddInParameter(cmd, OPDInvestigation.Columns.OPDRadiologyInvestigation, SqlDbType.NVarChar, AppShared.ToDbValueNullable(OPDRadiologyInvestigation));
            AppDatabase.AddInParameter(cmd, OPDInvestigation.Columns.OPDSpecialInvestigation, SqlDbType.NVarChar, AppShared.ToDbValueNullable(OPDSpecialInvestigation));
            AppDatabase.AddInParameter(cmd, OPDInvestigation.Columns.OPDInvestigationDate, SqlDbType.DateTime, AppShared.ToDbValueNullable(OPDInvestigationDate));
            AppDatabase.AddInParameter(cmd, OPDInvestigation.Columns.OPDInvestigationModifiedBy, SqlDbType.UniqueIdentifier, modifiedBy);
        }
    }
}
