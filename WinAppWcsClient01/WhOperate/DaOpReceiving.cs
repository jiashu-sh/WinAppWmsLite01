using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinAppWmsLite.Entities;

namespace WinAppWmsLite.WhOperate
{
    class DaOpReceiving
    {
        internal static bool ReceivingCommit(EntityOrder rcvOrder)
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
                    //string strSql2 = "update main.im_item set void=1 where void=0 and product_no=@product_no ";
                    //SQLiteCommand cmd = new SQLiteCommand(strSql2, conn, transaction);
                    //cmd.Parameters.AddWithValue("@product_no", paraItem.ProductNo);
                    //iInsert = cmd.ExecuteNonQuery();

                    //strSql2 = "update main.im_item_barcode set void=1 where void=0 and product_no=@product_no ";
                    //cmd = new SQLiteCommand(strSql2, conn, transaction);
                    //cmd.Parameters.AddWithValue("@product_no", paraItem.ProductNo);
                    //iInsert += cmd.ExecuteNonQuery();

                    string strSql = @"insert into wh_order_head (order_id,order_no,order_type_id,customer_id,void,update_uid,update_time) 
                                                         values (@order_id,@order_no,@order_type_id,@customer_id,0,@update_uid,datetime('now','localtime'))";
                    SQLiteCommand cmd = new SQLiteCommand(strSql, conn, transaction);
                    cmd.Parameters.AddWithValue("@order_id", rcvOrder.OrderId);
                    cmd.Parameters.AddWithValue("@order_no", rcvOrder.OrderNo);
                    cmd.Parameters.AddWithValue("@order_type_id", rcvOrder.OrderTypeId);
                    cmd.Parameters.AddWithValue("@customer_id", rcvOrder.CustomerId);
                    cmd.Parameters.AddWithValue("@update_uid", rcvOrder.UserId);
                    iInsert += cmd.ExecuteNonQuery();

                    foreach (EntityIoLogs iolog in rcvOrder.IoLogsList)
                    {
                        string strSql1 = @"insert into wh_io_logs (io_type_id,order_id,customer_id,product_no,qty,uom_id,lot_no,serial_no,cntr_id,void,update_uid,update_time) values 
                                            (@io_type_id,@order_id,@customer_id,@product_no,@qty,@uom_id,@lot_no,@serial_no,@cntr_id,0,@update_uid,datetime('now','localtime'))";
                        cmd = new SQLiteCommand(strSql1, conn, transaction);
                        cmd.Parameters.AddWithValue("@io_type_id", iolog.IoTypeId);
                        cmd.Parameters.AddWithValue("@order_id", iolog.OrderId);
                        cmd.Parameters.AddWithValue("@customer_id", rcvOrder.CustomerId);
                        cmd.Parameters.AddWithValue("@product_no", iolog.Item.ProductNo);//product_no
                        cmd.Parameters.AddWithValue("@qty", iolog.Qty);//qty
                        cmd.Parameters.AddWithValue("@uom_id", iolog.UomId);//uom_id
                        cmd.Parameters.AddWithValue("@lot_no", iolog.LotNo);//lot_no
                        cmd.Parameters.AddWithValue("@serial_no", iolog.SerialNo);//serial_no
                        cmd.Parameters.AddWithValue("@cntr_id", iolog.ContainerId);//cntr_id
                        cmd.Parameters.AddWithValue("@update_uid", rcvOrder.UserId);
                        iInsert += cmd.ExecuteNonQuery();
                    }

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
