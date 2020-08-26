using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppWmsLite.Common
{
    class CommonDa
    {
        public static string GetDbConnection()
        {
            string connection_string = "";
            try
            {
                //从Config配置文件中获取数据库连接字符串并返回OleDb连接
                //System.Data.OleDb.OleDbConnection oleconn = new System.Data.OleDb.OleDbConnection(SunnyWMSClient.Properties.Settings.Default.CodeMaintainConnectionString);

                if (CommonDa.GetDbType() == EnumDbTypes.PgSql)
                    connection_string = ConfigIO.GetConnectionString("postgresql_conn");
                else if (CommonDa.GetDbType() == EnumDbTypes.Sqlite)
                    connection_string = ConfigIO.GetConnectionString("sqlite_conn");                
            }
            catch (Exception ex)
            {
                throw ex;
                return "";
                //return null;
            }

            return connection_string;
        }

        internal static DataSet ExecuteQuery(string strsql)
        {
            if (CommonDa.GetDbType() == EnumDbTypes.Sqlite)
                return CommonDaSqlite.ExecuteQuery(strsql);
            else
                return Common.CommonDaPgsql.ExecuteQuery(strsql);
        }

        internal static EnumDbTypes GetDbType()
        {
            return EnumDbTypes.Sqlite;
        }
    }
}
