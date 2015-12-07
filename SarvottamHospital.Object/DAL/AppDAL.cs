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
        private static object _lock = new object();
        [ThreadStatic]
        private static AppDatabase mDatabase;

        internal static string DatabaseConnectionString
        {
            get
            {
                string strReturn = string.Empty;
                ConnectionStringSettings csObj = ConfigurationManager.ConnectionStrings["AppDBConnection"];
                if (csObj != null)
                    strReturn = csObj.ConnectionString;
                return strReturn;
            }
        }

        private static AppDatabase OpenDatabase()
        {
            lock (_lock)
            {
                if (null == mDatabase)
                {
                    mDatabase = new AppDatabase(DatabaseConnectionString);
                }
                else if (!mDatabase.IsConnected || mDatabase.ConnectionString != DatabaseConnectionString)
                {
                    mDatabase.Dispose();
                    mDatabase = new AppDatabase(DatabaseConnectionString);
                }
            }
            return mDatabase;
        }

        private static AppDatabase OpenOtherDatabase(string connectionString)
        {
            AppDatabase mDbReturn = new AppDatabase(connectionString);
            return mDbReturn;
        }

        internal static bool HasTransaction
        {
            get
            {
                AppDatabase db = OpenDatabase();
                return db != null && db.HasTransaction;
            }
        }

        internal static bool BiginTransaction()
        {
            AppDatabase db = OpenDatabase();
            return db != null && db.BiginTransaction();
        }

        internal static bool OKTransaction()
        {
            AppDatabase db = OpenDatabase();
            return db != null && db.OKTransaction();
        }

        internal static bool CancelTransaction()
        {
            AppDatabase db = OpenDatabase();
            return db != null && db.CancelTransaction();
        }

        private static bool Execute(string storeProcName, string paramName, SqlDbType paramType, object paramValue)
        {
            bool r = false;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(storeProcName))
            {
                AppDatabase.AddInParameter(cmd, paramName, paramType, paramValue);
                AppDatabase db = OpenDatabase();
                r = (db != null && db.ExecuteCommand(cmd));
            }
            return r;
        }

        private static bool Execute(string storeProcName, string paramName, Guid value)
        {
            return Execute(storeProcName, paramName, SqlDbType.UniqueIdentifier, (object)value);
        }

        private static SqlDataReader GetReader(string storeProcName, string paramName, SqlDbType paramType, object paramValue)
        {
            SqlDataReader r = null;

            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(storeProcName))
            {
                AppDatabase.AddInParameter(cmd, paramName, paramType, paramValue);
                AppDatabase db = OpenDatabase();
                if (db != null)
                    r = db.GetSqlDataReader(cmd);
            }

            return r;
        }

        private static SqlDataReader GetReader(string storeProcName, string paramName, Guid value)
        {
            return GetReader(storeProcName, paramName, SqlDbType.UniqueIdentifier, value);
        }

        private static SqlDataReader GetReader(string storeProcName)
        {
            SqlDataReader r = null;

            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(storeProcName))
            {
                AppDatabase db = OpenDatabase();
                if (db != null)
                    r = db.GetSqlDataReader(cmd);
            }

            return r;
        }

        private static DataTable GetDataTable(string storeProcName, string paramName, Guid value)
        {
            var r = GetReader(storeProcName, paramName, SqlDbType.UniqueIdentifier, value);
            var t = new DataTable();

            if (r != null)
            {
                t.Load(r);
            }
            return t;
        }

        private static DataTable GetDataTable(string storeProcName, string paramName, Guid value, string paramName1, DateTime val, string paramName2, DateTime val2)
        {
            var r = GetReader(storeProcName, paramName, SqlDbType.UniqueIdentifier, value);
            //var df = GetReader(storeProcName, paramName1, SqlDbType.DateTime, val);
            //var dt = GetReader(storeProcName, paramName2, SqlDbType.DateTime, val2);
            var t = new DataTable();

            if (r != null)
            {
                t.Load(r);
            }
            return t;
        }





        //**********
        private static DataTable GetDataTable(string StoreProcName)
        {

            var r = GetReader(StoreProcName);
            var t = new DataTable();

            if (r != null)
            {
                t.Load(r);
            }

            return t;
        }

    }
}
