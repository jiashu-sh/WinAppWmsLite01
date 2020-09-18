using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinAppWmsLite.Common;

namespace WinAppWmsLite.WhOperate.FormOpSendingCore
{
    public class OpShippingCoreBase
    {
        private FormOpShipping Form { set; get; }

        public OpShippingCoreBase(FormOpShipping _form)
        {
            this.Form = _form;
        }

        public string OrderNo { set; get; }



        public virtual void txtOperator_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var sBarcode = "";
                var sCustomerId = "";
                //and i.customer_id = b.customer_id 
                //查询出productno
                string sSql = $@"SELECT i.product_no,i.item_no,b.item_barcode,i.item_desc,i.customer_id,c.customer_desc 
                                FROM im_item i join im_item_barcode b on i.product_no = b.product_no 
                                join bc_customer c on c.customer_id = i.customer_id
                                where i.void=0 
                                 and b.item_barcode = '{sBarcode}' and b.customer_id = {sCustomerId.ToString()}
                                    order by i.product_no,b.item_barcode ";
                //判断是否有此商品
                DataSet exitsProductDS = Common.CommonDa.ExecuteQuery(sSql);
                if (exitsProductDS != null && exitsProductDS.Tables.Count > 0 && exitsProductDS.Tables[0].Rows.Count > 0)
                {//有此商品
                    var stockQty = 0;//现有库存
                    var productNo = exitsProductDS.Tables[0].Rows[0]["product_no"];
                    //拿到基础库存
                    string getbaseStock = $"select qty from V_balance_stock where product_no={productNo}";
                    DataSet baseStockDs = Common.CommonDa.ExecuteQuery(sSql);
                    if (baseStockDs != null && baseStockDs.Tables.Count > 0 && baseStockDs.Tables[0].Rows.Count > 0)
                    {
                        stockQty = baseStockDs.Tables[0].Rows[0]["qty"].DataColumnToInt();
                    }
                    //wh_io_logs 拉取库存流水
                    string getIoLogsDs = $"select sum(qty) qty from wh_io_logs where product_no={productNo}";
                    DataSet io_LogsDS = Common.CommonDa.ExecuteQuery(getIoLogsDs);
                    if (io_LogsDS != null && io_LogsDS.Tables.Count > 0 && io_LogsDS.Tables[0].Rows.Count > 0)
                    {
                        stockQty += io_LogsDS.Tables[0].Rows[0]["qty"].DataColumnToInt();
                    }
                    if (stockQty == 0)
                    {
                        MessageBox.Show("该商品库存为0");
                    }
                }
              

            }
        }

        public virtual void btnSaveCommit_Click(object sender, EventArgs e)
        {
            //直接添加head 表和 库存日志
        }
    }
}
