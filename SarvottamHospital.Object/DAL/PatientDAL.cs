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
        private const string Patient_Insert = "Patient_Insert";
        private const string Patient_Update = "Patient_Update";
        private const string Patient_Delete = "Patient_Delete";
        private const string Patient_Select = "Patient_Select";
        //private const string Patient_SelectAll = "Patient_SelectAll";
        private const string Patient_Search = "Patient_Search";

        internal static bool PatientInsert(Guid guid, string firstName, string middleName, string lastName, int gender, int age, string address, string city,
            string contactNo, string notes, Guid wardGuid, Guid roomGuid, DateTime admittedDate, string admittedtime, string operation, DateTime followUpDate, decimal amount, bool isIpd,
            Guid referenceDoctorGuid, decimal referenceDoctorShare, bool isDischarge, DateTime dischargeDate, int invoiceNo, DateTime invoiceDate, Guid createdByUser, out DateTime createdOn)
        {
            bool r = false;
            createdOn = DateTime.MinValue;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(Patient_Insert))
            {
                PatientParameters(cmd, guid, firstName, middleName, lastName, gender, age, address, city, contactNo, notes, wardGuid, roomGuid, admittedDate, admittedtime,
                    operation, followUpDate, amount, isIpd, referenceDoctorGuid, referenceDoctorShare, isDischarge, dischargeDate, invoiceNo, invoiceDate, createdByUser);
                SqlParameter prmModifiedOn = AppDatabase.AddOutParameter(cmd, Patient.Columns.PatientModifiedOn, SqlDbType.DateTime);
                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);
                if (r)
                    createdOn = AppShared.DbValueToDateTime(prmModifiedOn.Value);
            }
            return r;
        }

        internal static bool PatientUpdate(Guid guid, string firstName, string middleName, string lastName, int gender, int age, string address, string city,
            string contactNo, string notes, Guid wardGuid, Guid roomGuid, DateTime admittedDate, string admittedtime, string operation, DateTime followUpDate, decimal amount, bool isIpd,
            Guid referenceDoctorGuid, decimal referenceDoctorShare, bool isDischarge, DateTime dischargeDate, int invoiceNo, DateTime invoiceDate, Guid modifiedByUser, out DateTime modifiedOn)
        {
            bool r = false;
            modifiedOn = DateTime.MinValue;

            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(Patient_Update))
            {
                PatientParameters(cmd, guid, firstName, middleName, lastName, gender, age, address, city, contactNo, notes, wardGuid, roomGuid, admittedDate, admittedtime,
                    operation, followUpDate, amount, isIpd, referenceDoctorGuid, referenceDoctorShare, isDischarge, dischargeDate, invoiceNo, invoiceDate, modifiedByUser);
                SqlParameter prmDate = AppDatabase.AddOutParameter(cmd, Patient.Columns.PatientModifiedOn, SqlDbType.DateTime);

                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);
                if (r)
                {
                    modifiedOn = AppShared.DbValueToDateTime(prmDate.Value);
                }
            }

            return r;
        }

        internal static bool PatientDelete(Guid guid)
        {
            return Execute(Patient_Delete, Patient.Columns.PatientGuid, guid);
        }

        internal static SqlDataReader PatientSelect(Guid guid)
        {
            return GetReader(Patient_Select, Patient.Columns.PatientGuid, guid);
        }

        //internal static SqlDataReader PatientSelectAll()
        //{
        //    return GetReader(Patient_SelectAll);
        //}

        internal static SqlDataReader PatientSearch(string searchText, bool IsIpd,int isDischarge,DateTime dateFrom,DateTime dateTo)
        {
            SqlDataReader r = null;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(Patient_Search))
            {
                AppDatabase.AddInParameter(cmd, "@SearchText", SqlDbType.NVarChar, AppShared.ToDbLikeText(searchText));
                AppDatabase.AddInParameter(cmd, "@IsIpd", SqlDbType.Bit, IsIpd);
                AppDatabase.AddInParameter(cmd, "@IsDischarge", SqlDbType.Int, isDischarge);
                AppDatabase.AddInParameter(cmd, "@DateFrom", SqlDbType.DateTime, AppShared.ToDbValueNullable(dateFrom));
                AppDatabase.AddInParameter(cmd, "@DateTo", SqlDbType.DateTime, AppShared.ToDbValueNullable(dateTo));
                AppDatabase db = OpenDatabase();
                if (db != null)
                    r = db.GetSqlDataReader(cmd);
            }
            return r;
            // return GetReader(Patient_Search, "@SearchText", SqlDbType.NVarChar, AppShared.ToDbLikeText(searchText));
        }

        private static void PatientParameters(SqlCommand cmd, Guid guid, string firstName, string middleName, string lastName, int gender, int age, string address, string city,
            string contactNo, string notes, Guid wardGuid, Guid roomGuid, DateTime admittedDate, string admittedtime, string operation, DateTime followUpDate, decimal amount, bool isIpd,
            Guid referenceDoctorGuid, decimal referenceDoctorShare, bool isDischarge, DateTime dischargeDate,int invoiceNo, DateTime invoiceDate, Guid modifiedBy)
        {
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientGuid, SqlDbType.UniqueIdentifier, guid);
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientFirstName, SqlDbType.NVarChar, AppShared.SafeString(firstName));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientMiddleName, SqlDbType.NVarChar, AppShared.ToDbValueNullable(middleName));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientLastName, SqlDbType.NVarChar, AppShared.ToDbValueNullable(lastName));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientGender, SqlDbType.Int, gender);
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientAge, SqlDbType.Int, AppShared.ToDbValueNullable(age));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientAddress, SqlDbType.NVarChar, AppShared.ToDbValueNullable(address));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientCity, SqlDbType.NVarChar, AppShared.ToDbValueNullable(city));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientContactNo, SqlDbType.NVarChar, AppShared.ToDbValueNullable(contactNo));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientNotes, SqlDbType.NVarChar, AppShared.ToDbValueNullable(notes));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientWardGuid, SqlDbType.UniqueIdentifier, AppShared.ToDbValueNullable(wardGuid));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientRoomGuid, SqlDbType.UniqueIdentifier, AppShared.ToDbValueNullable(roomGuid));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientAdmittedDate, SqlDbType.DateTime, AppShared.ToDbValueNullable(admittedDate));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientAdmittedTime, SqlDbType.NVarChar, AppShared.ToDbValueNullable(admittedtime));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientOperation, SqlDbType.NVarChar, AppShared.ToDbValueNullable(operation));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientFollowUpDate, SqlDbType.DateTime, AppShared.ToDbValueNullable(followUpDate));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientAmountReceived, SqlDbType.Decimal, AppShared.ToDbValueNullable(amount));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientIsIPD, SqlDbType.Bit, isIpd);
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientReferenceDoctorGuid, SqlDbType.UniqueIdentifier, AppShared.ToDbValueNullable(referenceDoctorGuid));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientReferenceDoctorShare, SqlDbType.Decimal, AppShared.ToDbValueNullable(referenceDoctorShare));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientIsDischarge, SqlDbType.Bit, isDischarge);
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatiendDischargeDate, SqlDbType.DateTime, AppShared.ToDbValueNullable(dischargeDate));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientInvoiceNo, SqlDbType.Int, AppShared.ToDbValueNullable(invoiceNo));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientInvoiceDate, SqlDbType.DateTime, AppShared.ToDbValueNullable(invoiceDate));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientModifiedBy, SqlDbType.UniqueIdentifier, modifiedBy);
        }
    }
}
