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
        private const string IPDPatientTreatment_Insert = "IPDPatientTreatment_Insert";
        private const string IPDPatientTreatment_Update = "IPDPatientTreatment_Update";
        private const string IPDPatientTreatment_Delete = "IPDPatientTreatment_Delete";
        //private const string IPDTreatment_Select = "IPDTreatment_Select";
        private const string IPDPatientTreatment_SelectAll = "IPDPatientTreatment_SelectAll";
        //private const string IPDTreatment_Search = "IPDTreatment_Search";

        internal static bool IPDPatientTreatmentInsert(Guid guid, Guid patientGuid, Guid treatmentGuid, Guid createdByUser, out DateTime createdOn)
        {
            bool r = false;
            createdOn = DateTime.MinValue;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(IPDPatientTreatment_Insert))
            {
                IPDPatientTreatmentParameters(cmd, guid, patientGuid, treatmentGuid, createdByUser);
                SqlParameter prmModifiedOn = AppDatabase.AddOutParameter(cmd, IPDPatientTreatment.Columns.IPDPatientTreatmentModifiedOn, SqlDbType.DateTime);
                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);
                if (r)
                    createdOn = AppShared.DbValueToDateTime(prmModifiedOn.Value);
            }
            return r;
        }

        internal static bool IPDPatientTreatmentUpdate(Guid guid, Guid patientGuid, Guid treatmentGuid, Guid modifiedByUser, out DateTime modifiedOn)
        {
            bool r = false;
            modifiedOn = DateTime.MinValue;

            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(IPDPatientTreatment_Update))
            {
                IPDPatientTreatmentParameters(cmd, guid, patientGuid, treatmentGuid, modifiedByUser);
                SqlParameter prmDate = AppDatabase.AddOutParameter(cmd, IPDPatientTreatment.Columns.IPDPatientTreatmentModifiedOn, SqlDbType.DateTime);

                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);
                if (r)
                {
                    modifiedOn = AppShared.DbValueToDateTime(prmDate.Value);
                }
            }

            return r;
        }

        internal static SqlDataReader IPDPatientTreatmentDelete(Guid guid)
        {
            return GetReader(IPDPatientTreatment_Delete, IPDPatientTreatment.Columns.IPDPatientTreatmentPatientGuid, guid);
        }

        internal static SqlDataReader IPDPatientTreatmentSelectAll(Guid guid)
        {
            return GetReader(IPDPatientTreatment_SelectAll, IPDPatientTreatment.Columns.IPDPatientTreatmentPatientGuid, guid);
        }

        private static void IPDPatientTreatmentParameters(SqlCommand cmd, Guid guid, Guid patientGuid, Guid treatmentGuid, Guid modifiedBy)
        {
            //AppDatabase.AddInParameter(cmd, IPDPatientTreatment.Columns.IPDPatientTreatmentGuid, SqlDbType.UniqueIdentifier, guid);
            AppDatabase.AddInParameter(cmd, IPDPatientTreatment.Columns.IPDPatientTreatmentPatientGuid, SqlDbType.UniqueIdentifier, patientGuid);
            AppDatabase.AddInParameter(cmd, IPDPatientTreatment.Columns.IPDPatientTreatmentTreatmentGuid, SqlDbType.UniqueIdentifier, treatmentGuid);
            AppDatabase.AddInParameter(cmd, IPDPatientTreatment.Columns.IPDPatientTreatmentModifiedBy, SqlDbType.UniqueIdentifier, modifiedBy);
        }
    }
}
