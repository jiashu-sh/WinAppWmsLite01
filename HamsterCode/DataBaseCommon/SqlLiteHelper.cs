using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Text;

namespace HamsterCode.DataBaseCommon
{
    public sealed partial class SqlLiteHelper : IDbHelper
    {

        /// <summary>
        /// 数据库连接字符串
        /// </summary>
        public string ConnectionString { get; set; }
        public SqlLiteHelper(string ConnectionStr)
        {
            this.ConnectionString = ConnectionStr;
        }


        DataRow IDbHelper.ExecuteDataRow(string cmdText)
        {
            throw new NotImplementedException();
        }

        DataSet IDbHelper.ExecuteDataSet(string cmdText)
        {
            const string FUNC_NAME = "ExecuteQuerySQL";

            //FileCreater.SaveOperationLogFile("------------------------------------------------------------------");
            //FileCreater.SaveOperationLogFile(FUNC_NAME);

            string connStr = this.ConnectionString;

            DataSet ds = new DataSet();

            using (SQLiteConnection conn = new SQLiteConnection(connStr))
            {
                //conn.Open();
                using (SQLiteDataAdapter ap = new SQLiteDataAdapter(cmdText, conn))
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

        DataTable IDbHelper.ExecuteDataTable(string cmdText)
        {
            const string FUNC_NAME = "ExecuteQuerySQL";

            //FileCreater.SaveOperationLogFile("------------------------------------------------------------------");
            //FileCreater.SaveOperationLogFile(FUNC_NAME);

            string connStr = this.ConnectionString;

            DataSet ds = new DataSet();

            using (SQLiteConnection conn = new SQLiteConnection(connStr))
            {
                //conn.Open();
                using (SQLiteDataAdapter ap = new SQLiteDataAdapter(cmdText, conn))
                {

                    ap.Fill(ds);

                    if (ds.Tables.Count == 0)
                        return null;

                    if (ds.Tables[0].Rows.Count == 0)
                        return null;
                }
            }

            return ds.Tables[0];
        }

        int IDbHelper.ExecuteNonQuery(string cmdText)
        {
            const string FUNC_NAME = "ExecuteQuerySQL";

            //FileCreater.SaveOperationLogFile("------------------------------------------------------------------");
            //FileCreater.SaveOperationLogFile(FUNC_NAME);

            string connStr = this.ConnectionString;

            DataSet ds = new DataSet();

            using (SQLiteConnection conn = new SQLiteConnection(connStr))
            {
                SQLiteCommand cmd = new SQLiteCommand();
                if (conn.State != ConnectionState.Open) { conn.Open(); }
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                //cmd.CommandTimeout = CommandTimeOut;
                // 设置命令文本(存储过程名或SQL语句)
                cmd.CommandText = cmdText;
                int retval = cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open) { conn.Close(); }
                return retval;
            }
        }

        object IDbHelper.ExecuteScalar(string cmdText)
        {
            const string FUNC_NAME = "ExecuteQuerySQL";

            //FileCreater.SaveOperationLogFile("------------------------------------------------------------------");
            //FileCreater.SaveOperationLogFile(FUNC_NAME);

            string connStr = this.ConnectionString;

            DataSet ds = new DataSet();

            using (SQLiteConnection conn = new SQLiteConnection(connStr))
            {
                //conn.Open();
                using (SQLiteDataAdapter ap = new SQLiteDataAdapter(cmdText, conn))
                {

                    ap.Fill(ds);

                    if (ds.Tables.Count == 0)
                        return null;

                    if (ds.Tables[0].Rows.Count == 0)
                        return null;
                }
            }

            return ds.Tables[0];
        }

        string IDbHelper.GetConnectionString()
        {
            return this.ConnectionString;
        }
    }
}
