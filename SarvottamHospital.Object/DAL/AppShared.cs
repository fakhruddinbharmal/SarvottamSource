using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace SarvottamHospital.Object
{
    internal static class AppShared
    {
        private static string PrepareForLIKE(string str)
        {
            return (string.IsNullOrEmpty(str) ? null : "%" + str.Replace("[", "[[]").Replace("%", "[%]").Replace("_", "[_]").Replace("^", "[^]") + "%");
        }

        internal static string SafeString(string str)
        {
            return (str == null ? string.Empty : str);
        }

        internal static bool IsNull(object obj)
        {
            return obj == null || DBNull.Value.Equals(obj);
        }

        internal static bool IsNotNull(object obj)
        {
            return obj != null && !DBNull.Value.Equals(obj);
        }

        internal static Guid DbValueToGuid(object obj)
        {
            return (IsNull(obj) ? Guid.Empty : (Guid)obj);
        }

        internal static string DbValueToString(object obj)
        {
            return (IsNull(obj) ? string.Empty : obj.ToString());
        }

        internal static DateTime DbValueToDateTime(object obj)
        {
            return (IsNull(obj) ? DateTime.MinValue : (DateTime)obj);
        }

        internal static int DbValueToInteger(object obj)
        {
            return (IsNull(obj) ? 0 : (int)obj);
        }

        internal static short DbValueToShort(object obj)
        {
            return (IsNull(obj) ? (short)0 : (short)obj);
        }

        internal static decimal DbValueToDecimal(object obj)
        {
            return (IsNull(obj) ? decimal.Zero : (decimal)obj);
        }

        internal static bool DbValueToBoolean(object obj)
        {
            return (IsNull(obj) ? false : (bool)obj);
        }

        internal static byte[] DbValueToBytes(SqlDataReader dr, string columnName)
        {
            byte[] r = null;
            int ordinal = dr.GetOrdinal(columnName);
            if (AppShared.IsNotNull(dr[ordinal]))
            {
                System.Data.SqlTypes.SqlBytes sqlData = dr.GetSqlBytes(ordinal);
                r = sqlData.Value;
            }
            return r;
        }

        internal static object ToDbValueNullable(DateTime? value)
        {
            object r = DBNull.Value;
            if (value != null && value.HasValue && value >= System.Data.SqlTypes.SqlDateTime.MinValue.Value && value <= System.Data.SqlTypes.SqlDateTime.MaxValue.Value)
                r = value;
            return r;
        }

        internal static object ToDbValueNullable(DateTime value)
        {
            object r = DBNull.Value;
            if (value >= System.Data.SqlTypes.SqlDateTime.MinValue.Value && value <= System.Data.SqlTypes.SqlDateTime.MaxValue.Value)
                r = value;
            return r;
        }

        internal static object ToDbValueNullable(int value)
        {
            object r = DBNull.Value;
            if (value > 0)
                r = value;
            return r;
        }

        internal static object ToDbValueNullable(decimal value)
        {
            object r = DBNull.Value;
            if (value > decimal.Zero)
                r = value;
            return r;
        }

        internal static object ToDbValueNullable(bool? value)
        {
            object r = DBNull.Value;
            if (value.HasValue)
                r = value.Value;
            return r;
        }

        internal static object ToDbValueNullable(Guid value)
        {
            object r = DBNull.Value;
            if (value != Guid.Empty)
                r = value;
            return r;
        }

        internal static object ToDbValueNullable(string value)
        {
            object r = DBNull.Value;
            if (!string.IsNullOrEmpty(value))
                r = value;
            return r;
        }

        internal static object ToDbValueNullable(byte[] value)
        {
            object r = DBNull.Value;
            if (value != null && value.Length > 0)
                r = value;
            return r;
        }

        internal static object ToDbLikeText(string value)
        {
            object r = DBNull.Value;
            string like = PrepareForLIKE(value);
            if (like != null)
                r = like;
            return r;

        }

        internal static bool HasColumn(SqlDataReader dr, string columnName)
        {
            try
            {
                return (dr != null && dr.GetOrdinal(columnName) >= 0);
            }
            catch { }
            return false;
        }

    }
}
