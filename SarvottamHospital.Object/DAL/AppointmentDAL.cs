using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;


namespace SarvottamHospital.Object
{
    internal static partial class AppDAL
    {
         public const string Appointment_Update ="Appointment_Update";
         public const string Appointment_Insert = "Appointment_Insert";
         public const string Appointment_Select = "Appointment_Select";
         public const string Appointment_SelectAll ="Appointment_SelectAll";
         public const string Appointment_Delete  = "Appointment_Delete";
         public const string Appointment_Search = "Appointment_Search";

        internal static bool AppointmentInsert(Guid PatientGuid, Guid AppointmentGuid, DateTime AppointmentDate, string AppointmentDescription, Guid createdByUser, 
                                                     out DateTime createdOn)
        {
            bool r = false;
            createdOn = DateTime.MinValue;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(Appointment_Insert))
            {
                AppointmentParameters(cmd, PatientGuid, AppointmentGuid, AppointmentDate, AppointmentDescription, createdByUser);
                SqlParameter prmDate = AppDatabase.AddOutParameter(cmd, Appointment.Columns.AppointmentModifiedOn, SqlDbType.DateTime);

                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);
                if (r)
                {
                    createdOn = AppShared.DbValueToDateTime(prmDate.Value);
                }
            }
            return r;

        }

        internal static bool AppointmentUpdate(Guid PatientGuid, Guid AppointmentGuid, DateTime AppointmentDate, string AppointmentDescription, Guid ModifiedByUser, out DateTime ModifiedOn)
        {
            bool r = false;
            ModifiedOn = DateTime.MinValue;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(Appointment_Update))
            {
                AppointmentParameters(cmd, PatientGuid, AppointmentGuid, AppointmentDate, AppointmentDescription, ModifiedByUser);
                SqlParameter prmDate = AppDatabase.AddOutParameter(cmd, Appointment.Columns.AppointmentModifiedOn, SqlDbType.DateTime);

                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);
                if (r)
                {
                    ModifiedOn = AppShared.DbValueToDateTime(prmDate.Value);
                }
            }
            return r;

        }

        internal static bool AppointmentDelete(Guid guid)
        {
            return Execute(Appointment_Delete, Appointment.Columns.AppointmentGuid, guid);
        }

        internal static SqlDataReader AppointmentSelect(Guid guid)
        {
            return GetReader(Appointment_Select, Appointment.Columns.AppointmentGuid, guid);
        }

        internal static SqlDataReader AppointmentSelectAll()
        {
            return GetReader(Appointment_SelectAll);
        }

        internal static SqlDataReader AppointmentSearch(Guid PatientGuid)
        {
            return GetReader(Appointment_Search, Appointment.Columns.PatientGuid,SqlDbType.UniqueIdentifier,PatientGuid);
        }

        private static void AppointmentParameters(SqlCommand cmd, Guid PatientGuid, Guid AppointmentGuid, DateTime AppointmentDate, string AppointmentDescription, Guid ModifiedBy)
         { 
             AppDatabase.AddInParameter(cmd,Appointment.Columns.AppointmentDate,SqlDbType.DateTime,AppointmentDate);
             AppDatabase.AddInParameter(cmd,Appointment.Columns.AppointmentGuid,SqlDbType.UniqueIdentifier,AppointmentGuid);
             AppDatabase.AddInParameter(cmd,Appointment.Columns.PatientGuid,SqlDbType.UniqueIdentifier,PatientGuid);
             AppDatabase.AddInParameter(cmd,Appointment.Columns.AppointmentDescription,SqlDbType.NVarChar,AppointmentDescription);
             AppDatabase.AddInParameter(cmd,Appointment.Columns.AppointmentModifiedBy,SqlDbType.UniqueIdentifier,ModifiedBy);
         }
    }

}
