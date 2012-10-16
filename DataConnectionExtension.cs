using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace LightDataAccess
{
    public static class DataConnectionExtension
    {
        public static int ExecuteNonQuery(this DbConnection conn, CommandType commandType, string commandText, CmdParams cmdParams)
        {
            return DBTools.ExecuteNonQuery(conn, commandType, commandText, cmdParams);
        }

        public static object ExecuteScalar(this DbConnection conn, CommandType commandType, string commandText, CmdParams cmdParams)
        {
            return DBTools.ExecuteScalar(conn, commandType, commandText, cmdParams);
        }

        public static T ExecuteScalar<T>(this DbConnection conn, CommandType commandType, string commandText, CmdParams cmdParams)
        {
            return DBTools.ExecuteScalar<T>(conn, commandType, commandText, cmdParams);
        }

        public static DbDataReader ExecuteReader(this DbConnection conn, CommandType commandType, string commandText, CmdParams cmdParams)
        {
            return DBTools.ExecuteReader(conn, commandType, commandText, cmdParams);
        }

        public static T ExecuteReader<T>(this DbConnection conn, CommandType commandType, string commandText, CmdParams cmdParams, Func<DbDataReader, T> func) where T : class
        {
            return DBTools.ExecuteReader<T>(conn, commandType, commandText, cmdParams, func);
        }

        public static T ExecuteReaderStruct<T>(this DbConnection conn, CommandType commandType, string commandText, CmdParams cmdParams, Func<DbDataReader, T> func) where T : struct
        {
            return DBTools.ExecuteReaderStruct<T>(conn, commandType, commandText, cmdParams, func);
        }

        public static IEnumerable<T> ExecuteReaderEnum<T>(this DbConnection conn, CommandType commandType, string commandText, CmdParams cmdParams, Func<DbDataReader, T> func)
        {
            return DBTools.ExecuteReaderEnum<T>(conn, commandType, commandText, cmdParams, func);
        }
    }
}
