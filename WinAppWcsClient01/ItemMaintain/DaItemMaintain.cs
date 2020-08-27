using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinAppWmsLite.Entities;

namespace WinAppWmsLite.ItemMaintain
{
    class DaItemMaintain
    {
        internal static bool InsertUpdateItem(EntityItem paraItem)
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
                    string strSql2 = "update main.im_item set void=1 where void=0 and product_no=@product_no ";
                    SQLiteCommand cmd = new SQLiteCommand(strSql2, conn, transaction);
                    cmd.Parameters.AddWithValue("@product_no", paraItem.ProductNo);
                    iInsert = cmd.ExecuteNonQuery();

                    strSql2 = "update main.im_item_barcode set void=1 where void=0 and product_no=@product_no ";
                    cmd = new SQLiteCommand(strSql2, conn, transaction);
                    cmd.Parameters.AddWithValue("@product_no", paraItem.ProductNo);
                    iInsert += cmd.ExecuteNonQuery();

                    string strSql = "insert into main.im_item (product_no,item_no,item_desc,customer_id,update_uid,update_time) values (@product_no,@item_no,@item_desc,@customer_id,@update_uid,datetime('now','localtime'))";
                    cmd = new SQLiteCommand(strSql, conn, transaction);
                    cmd.Parameters.AddWithValue("@product_no", paraItem.ProductNo);
                    cmd.Parameters.AddWithValue("@item_no", paraItem.ItemNo);
                    cmd.Parameters.AddWithValue("@item_desc", paraItem.ItemDesc);
                    cmd.Parameters.AddWithValue("@customer_id", paraItem.CustomerId);
                    cmd.Parameters.AddWithValue("@update_uid", paraItem.UserId);
                    iInsert += cmd.ExecuteNonQuery();

                    foreach(EntityItemBarcode ibc in paraItem.ItemBarcodes)
                    {
                        string strSql1 = "insert into main.im_item_barcode (product_no,item_barcode,customer_id,update_uid,update_time) values (@product_no,@item_barcode,@customer_id,@update_uid,datetime('now','localtime'))";
                        cmd = new SQLiteCommand(strSql1, conn, transaction);
                        cmd.Parameters.AddWithValue("@product_no", ibc.ProductNo);
                        cmd.Parameters.AddWithValue("@item_barcode", ibc.ItemBarcode);
                        cmd.Parameters.AddWithValue("@customer_id", ibc.CustomerId);
                        cmd.Parameters.AddWithValue("@update_uid", ibc.UserId);
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
