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
        private const string OPDHistoryProcedureAssociateComplain_Insert = "OPDHistoryProcedureAssociateComplain_Insert";
        //private const string OPDHistoryProcedureAssociateComplain_Insert = "OPDHistoryProcedureAssociateComplain_Insert";
        private const string OPDHistoryProcedureAssociateComplain_Delete = "OPDHistoryProcedureAssociateComplain_Delete";
        private const string OPDHistoryProcedureAssociateComplain_SelectAll = "OPDHistoryProcedureAssociateComplain_SelectAll";

        internal static bool OPDHistoryProcedureAssociateComplainInsert(Guid opdHistoryProcedureGuid, Guid PatientGuid, Guid AssociateComplainGuid)
        {
            bool r = false;

            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(OPDHistoryProcedureAssociateComplain_Insert))
            {
                OPDHistoryProcedureAssociateComplainParameters(cmd, opdHistoryProcedureGuid, PatientGuid, AssociateComplainGuid);
                // SqlParameter prmModifiedOn = AppDatabase.AddOutParameter(cmd, OPDHistoryProcedureChiefComplain.Columns.OPDHistoryProcedureModifiedOn, SqlDbType.DateTime);
                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);
                //if (r)
                //    createdOn = AppShared.DbValueToDateTime(prmModifiedOn.Value);

            }
            return r;
        }
        internal static SqlDataReader OPDHistoryProcedureAssociateComplainDelete(Guid guid)
        {
            return GetReader(OPDHistoryProcedureAssociateComplain_Delete, OPDHistoryProcedureAssociateComplain.Columns.OPDHistoryProcedureGuid, guid);
        }
        internal static SqlDataReader OPDHistoryProcedureAssociateComplainSelectAll(Guid guid)
        {
            return GetReader(OPDHistoryProcedureAssociateComplain_SelectAll, OPDHistoryProcedureAssociateComplain.Columns.OPDHistoryProcedureGuid, guid);
        }

        private static void OPDHistoryProcedureAssociateComplainParameters(SqlCommand cmd, Guid opdHistoryProcedureGuid, Guid PatientGuid, Guid AssociateComplainGuid)
        {
            AppDatabase.AddInParameter(cmd, OPDHistoryProcedureAssociateComplain.Columns.OPDHistoryProcedureGuid, SqlDbType.UniqueIdentifier, opdHistoryProcedureGuid);
            AppDatabase.AddInParameter(cmd, OPDHistoryProcedureAssociateComplain.Columns.OPDHistoryProcedurePatientGuid, SqlDbType.UniqueIdentifier, PatientGuid);
            AppDatabase.AddInParameter(cmd, OPDHistoryProcedureAssociateComplain.Columns.OPDHistoryProcedureAssociateComplain, SqlDbType.UniqueIdentifier, AssociateComplainGuid);

        }
    }
}
