using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SarvottamHospital.Object
{
    internal static partial class AppDAL
    {
        public const string IPDPatient_Bill = "IPDPatient_Bill";

        public const string OPDAppointment_Report = "OPDAppointment_Report";

        public const string OPDAppointment_Report7Days = "OPDAppointment_Report7Days"; 

        internal static DataTable PatientBillReport(Guid guid)
        {
            return GetDataTable(IPDPatient_Bill, Report.Columns.PatientGuid, guid);
        }
        internal static DataTable OPDAppointmentReport7Days()
        {
            return GetDataTable(OPDAppointment_Report7Days);
        }
        internal static DataTable OPDAppointmentReport(DateTime DateFrom, DateTime DateTo)
        { 
             DataTable r = null;
             using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(OPDAppointment_Report))
             {
                AppDatabase.AddInParameter(cmd, "@DateFrom", SqlDbType.DateTime, AppShared.ToDbValueNullable(DateFrom));
                AppDatabase.AddInParameter(cmd, "@DateTo", SqlDbType.DateTime, AppShared.ToDbValueNullable(DateTo));
                AppDatabase db = OpenDatabase();
                if (db != null)
                    r = db.GetDataTable(cmd);            
             }
             return r;
        }
    }
}
