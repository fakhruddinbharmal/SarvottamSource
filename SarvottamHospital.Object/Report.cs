using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace SarvottamHospital.Object
{
    public sealed class Report
    {
        internal struct Columns
        {
            public const string PatientGuid = "PatientGuid";
        }

        public static DataTable GetReport(Guid guid)
        {
            return AppDAL.PatientBillReport(guid);
        }
        public static DataTable GetAppointmentFor7Days()
        {
            return AppDAL.OPDAppointmentReport7Days();
        }
        public static DataTable GetAppointmentReport(DateTime d1, DateTime d2)
        {
            return AppDAL.OPDAppointmentReport(d1, d2);
        }
    }
}
