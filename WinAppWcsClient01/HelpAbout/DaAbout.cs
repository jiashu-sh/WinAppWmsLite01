using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace WinAppWmsLite.HelpAbout
{
    class DaAbout
    {
        internal static bool InsertInitWarehouse()
        {
            bool bInsert = false;

            int iInsert = -1;

            string connectionString = Common.CommonDa.GetDbConnection();

            SQLiteTransaction transaction = null;

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                transaction = conn.BeginTransaction();
                try
                {
                    iInsert = 0;
                    //string strSql2 = "update main.pis_db set void=1 where void=0 and person_id=@person_id and type_id=@type_id";
                    //SQLiteCommand cmd = new SQLiteCommand(strSql2, conn, transaction);
                    //cmd.Parameters.AddWithValue("@person_id", obj.PersonId);
                    //cmd.Parameters.AddWithValue("@type_id", obj.TypeId);
                    //iInsert = cmd.ExecuteNonQuery();

                    int warehouse_id = 100;
                    string warehouse_desc = "1号仓";
                    string remark_desc = "InsertInitWarehouse";

                    string strSql = "insert into main.loc_warehouse (warehouse_id,warehouse_desc,remark_desc,update_time) values (@warehouse_id,@warehouse_desc,@remark_desc,@update_time)";
                    SQLiteCommand cmd = new SQLiteCommand(strSql, conn, transaction);
                    cmd.Parameters.AddWithValue("@warehouse_id", warehouse_id);
                    cmd.Parameters.AddWithValue("@warehouse_desc", warehouse_desc);
                    cmd.Parameters.AddWithValue("@remark_desc", remark_desc);//remark_desc
                    cmd.Parameters.AddWithValue("@update_time", DateTime.Now);
                    iInsert += cmd.ExecuteNonQuery();

                    if (iInsert > 0)
                        bInsert = true;

                    transaction.Commit();
                }
                catch (System.Data.SQLite.SQLiteException ex)
                {
                    transaction.Rollback();
                    throw new Exception(ex.Message);
                }
                finally
                {
                    //cmd.Dispose();
                    conn.Close();
                }

            }

            return bInsert;
        }
    }
}
