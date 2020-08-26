using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppWmsLite.Common
{
    class CommonDaPgsql
    {
        public static string GetPgConnection()
        {
            try
            {
                //从Config配置文件中获取数据库连接字符串并返回OleDb连接
                //System.Data.OleDb.OleDbConnection oleconn = new System.Data.OleDb.OleDbConnection(SunnyWMSClient.Properties.Settings.Default.CodeMaintainConnectionString);
                string pg_connection_string = ConfigIO.GetConnectionString("postgresql_conn");

                return pg_connection_string;
            }
            catch (Exception ex)
            {
                throw ex;
                return "";
                //return null;
            }
        }

        public static DataSet ExecuteQuery(string sql)
        {
            DataSet ds = new DataSet();

            string ConnectionString = GetPgConnection();

            if (ConnectionString == "")
                return null;

            using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionString))
            {
                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    try
                    {
                        command.CommandText = sql;
                        NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
                        DataSet dataset = new DataSet();
                        adapter.Fill(dataset);

                        if ((dataset == null) || (dataset.Tables[0].Rows.Count == 0))
                            return null;

                        return dataset;
                    }
                    catch (NpgsqlException exception)
                    {
                        throw new Exception(exception.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }

        }
    }
}
