using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppWmsLite.Common
{
    class CommonDaSqlite
    {
        public static string GetSqliteConnection()
        {
            try
            {
                //从Config配置文件中获取数据库连接字符串并返回OleDb连接
                //System.Data.OleDb.OleDbConnection oleconn = new System.Data.OleDb.OleDbConnection(SunnyWMSClient.Properties.Settings.Default.CodeMaintainConnectionString);
                string pg_connection_string = ConfigIO.GetConnectionString("sqlite_conn");

                return pg_connection_string;
            }
            catch (Exception ex)
            {
                throw ex;
                return "";
                //return null;
            }
        }

        public static DataSet ExecuteQuery(string strsql)
        {
            const string FUNC_NAME = "ExecuteQuerySQL";

            //FileCreater.SaveOperationLogFile("------------------------------------------------------------------");
            //FileCreater.SaveOperationLogFile(FUNC_NAME);

            string connStr = GetSqliteConnection();

            DataSet ds = new DataSet();

            using (SQLiteConnection conn = new SQLiteConnection(connStr))
            {
                //conn.Open();
                using (SQLiteDataAdapter ap = new SQLiteDataAdapter(strsql, conn))
                {

                    ap.Fill(ds);

                    if (ds.Tables.Count == 0)
                        return null;

                    if (ds.Tables[0].Rows.Count == 0)
                        return null;
                }
            }

            return ds;

        }
    }
}
