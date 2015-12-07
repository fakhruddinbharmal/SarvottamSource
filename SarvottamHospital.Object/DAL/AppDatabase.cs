using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace SarvottamHospital.Object
{
    internal sealed class AppDatabase : IDisposable
    {
        private SqlConnection mSqlCon;
        private SqlTransaction mSqlTran;
        private string mConStr;


        /// <summary>Create new database object with give connection information.</summary>
        internal AppDatabase(string connectionString)
        {
            this.mConStr = connectionString;
            ConnectToDatabase();
        }

        internal void CloseDatabase()
        {
            if (IsConnected)
            {
                this.CancelTransaction();
                this.mSqlCon.Close();
                this.mSqlCon.Dispose();
            }
        }

        /// <summary>This function will connection to database and return true on success otherwise false.</summary>
        internal bool ConnectToDatabase()
        {
            bool bolReturn = false;
            try
            {
                this.CloseDatabase();

                this.mSqlCon = new SqlConnection(mConStr);
                this.mSqlCon.Disposed += new EventHandler(OnConnectionDispose);
                this.mSqlCon.Open();
                bolReturn = this.IsConnected;

            }
            catch (Exception)
            {
                bolReturn = false;
            }

            return bolReturn;

        }

        private void OnConnectionDispose(object sender, EventArgs e)
        {
            this.mSqlTran = null;
            this.mSqlCon = null;
        }

        /// <summary>This will give connection string of current database.</summary>
        internal string ConnectionString
        {
            get { return mConStr; }
        }

        /// <summary>This will determine whether database is connected or not?</summary>
        internal bool IsConnected
        {
            get { return mSqlCon != null && (mSqlCon.State & ConnectionState.Open) == ConnectionState.Open; }
        }

        /// <summary>This will determine whether transaction is active on database or not?</summary>
        internal bool HasTransaction
        {
            get { return mSqlTran != null; }
        }

        /// <summary>This function will activate a transaction on database.</summary>
        internal bool BiginTransaction()
        {
            if (!this.HasTransaction)
                mSqlTran = mSqlCon.BeginTransaction();

            return this.HasTransaction;
        }

        /// <summary>This function will Comit active transaction on database.</summary>
        internal bool OKTransaction()
        {
            bool bolRetrun = false;
            if (this.HasTransaction)
            {
                this.mSqlTran.Commit();
                this.mSqlTran.Dispose();
                this.mSqlTran = null;
                bolRetrun = true;
            }
            return bolRetrun;
        }

        /// <summary>This function will rollback active transaction on database.</summary>
        internal bool CancelTransaction()
        {
            bool bolRetrun = false;
            if (this.HasTransaction)
            {
                this.mSqlTran.Rollback();
                this.mSqlTran.Dispose();
                this.mSqlTran = null;
                bolRetrun = true;
            }
            return bolRetrun;
        }

        /// <summary>This function add input parameter to the given command, and return newly added parameter.</summary>
        internal static SqlParameter AddInParameter(SqlCommand cmdSql, string strName, SqlDbType sqlType, object value)
        {
            SqlParameter prmReturn = null;
            try
            {
                prmReturn = new SqlParameter(strName, sqlType);
                prmReturn.Direction = ParameterDirection.Input;
                prmReturn.Value = value;
                cmdSql.Parameters.Add(prmReturn);
            }
            catch (Exception)
            {
                prmReturn = null;
            }
            return prmReturn;
        }

        /// <summary>This function add output parameter to the given command, and return newly added parameter.</summary>
        internal static SqlParameter AddOutParameter(SqlCommand cmdSql, string strName, SqlDbType sqlType)
        {
            return AddOutParameter(cmdSql, strName, sqlType, -1);
        }

        /// <summary>This function add output parameter to the given command, and return newly added parameter.</summary>
        internal static SqlParameter AddOutParameter(SqlCommand cmdSql, string strName, SqlDbType sqlType, int size)
        {
            SqlParameter prmReturn = null;
            try
            {
                prmReturn = new SqlParameter(strName, sqlType, size);
                prmReturn.Direction = ParameterDirection.Output;
                cmdSql.Parameters.Add(prmReturn);
            }
            catch (Exception)
            {
                prmReturn = null;
            }
            return prmReturn;
        }

        /// <summary>This function return store procedure command.</summary>
        internal static SqlCommand GetStoreProcCommand(string procName)
        {
            SqlCommand cmdReturn = null;
            cmdReturn = new SqlCommand(procName);
            cmdReturn.CommandType = CommandType.StoredProcedure;
            return cmdReturn;
        }

        /// <summary>This function return T-SQL command.</summary>
        internal static SqlCommand GetSqlTextCommand(string sqlText)
        {
            SqlCommand cmdReturn = null;
            cmdReturn = new SqlCommand(sqlText);
            cmdReturn.CommandType = CommandType.Text;
            return cmdReturn;
        }

        /// <summary>This function execute given command on database and return true on success otherwise false.</summary>
        internal bool ExecuteCommand(SqlCommand cmd)
        {
            bool bolReturn = false;
            try
            {
                if (cmd != null)
                {
                    SetConnectionTrans(cmd);
                    cmd.ExecuteNonQuery();
                    bolReturn = true;
                }
            }
            catch (SqlException se)
            {
                bolReturn = false;
                    throw se;
            }
            catch (Exception e)
            {
                bolReturn = false;
                throw e;
            }
            return bolReturn;
        }

        /// <summary>This function execute command on database and return single value of result.</summary>
        internal object ExecuteForObject(SqlCommand cmd)
        {
            object bolObject = null;
            try
            {
                if (cmd != null)
                {
                    SetConnectionTrans(cmd);
                    bolObject = cmd.ExecuteScalar();
                }
            }
            catch (SqlException se)
            {
                bolObject = null;
                throw se;
            }
            catch (Exception e)
            {
                bolObject = null;
                throw e;
            }
            return bolObject;
        }

        /// <summary>This function execute select command on database and return result as DataSet.</summary>
        internal DataSet GetDataSet(SqlCommand cmd)
        {
            DataSet dsReturn = null;
            SqlDataAdapter daSql = null;
            try
            {
                if (cmd != null)
                {
                    SetConnectionTrans(cmd);
                    daSql = new SqlDataAdapter(cmd);
                    dsReturn = new DataSet();
                    daSql.Fill(dsReturn);

                }
            }
            catch (SqlException se)
            {
                if (dsReturn != null)
                    dsReturn.Dispose();
                dsReturn = null;
                throw se;
            }
            catch (Exception e)
            {
                if (dsReturn != null)
                    dsReturn.Dispose();
                dsReturn = null;
                throw e;
            }
            finally
            {
                if (daSql != null)
                    daSql.Dispose();
            }
            return dsReturn;
        }

        /// <summary>This function execute select command on database and return result as DataTable.</summary>
        internal DataTable GetDataTable(SqlCommand cmd)
        {
            DataTable dtReturn = null;
            SqlDataAdapter daSql = null;
            try
            {
                if (cmd != null)
                {
                    SetConnectionTrans(cmd);
                    daSql = new SqlDataAdapter(cmd);
                    dtReturn = new DataTable();
                    daSql.Fill(dtReturn);
                }
            }
            catch (SqlException se)
            {
                if (dtReturn != null)
                    dtReturn.Dispose();
                dtReturn = null;
                throw se;
            }
            catch (Exception e)
            {
                if (dtReturn != null)
                    dtReturn.Dispose();
                dtReturn = null;
                throw e;
            }
            finally
            {
                if (daSql != null)
                    daSql.Dispose();
            }
            return dtReturn;
        }

        /// <summary>This function execute select command on database and return result as DataTableReader.</summary>
        internal DataTableReader GetDataTableReader(SqlCommand cmd)
        {
            DataTableReader dtrReturn = null;
            DataTable dt = GetDataTable(cmd);
            if (dt != null)
            {
                dtrReturn = dt.CreateDataReader();
                dt.Dispose();
            }
            return dtrReturn;
        }

        /// <summary>This function execute select command on database and return result as SqlDataReader.</summary>
        internal SqlDataReader GetSqlDataReader(SqlCommand cmd)
        {
            SqlDataReader drReturn = null;
            if (cmd != null)
            {
                SetConnectionTrans(cmd);
                drReturn = cmd.ExecuteReader();
            }
            return drReturn;
        }

        private void SetConnectionTrans(SqlCommand cmd)
        {
            cmd.Connection = mSqlCon;

            if (this.HasTransaction)
                cmd.Transaction = mSqlTran;
        }

        /// <summary>This member overrides Object.Finalize.</summary>
        ~AppDatabase()
        {
            this.Dispose(false);
        }

        /// <summary>Releases all resources used by this object.</summary>
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>Custom Dispose method to clean up unmanaged resources.</summary>
        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (null != this.mSqlCon)
                {
                    this.CancelTransaction();
                    this.mSqlCon.Dispose();
                }
            }
        }

    }//end of class
}
