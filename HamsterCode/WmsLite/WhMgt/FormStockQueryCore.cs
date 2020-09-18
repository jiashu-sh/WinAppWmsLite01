using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using HamsterCode.DataBaseCommon;
using HamsterModel;
using HamsterModel.WmsLite.WhMgt.FormStockQuery;

namespace HamsterCode.WmsLite.WhMgt
{
    public class FormStockQueryCore
    {
        private FormStockQueryCore()
        {
            sqlLiteHelper = new SqlLiteHelper(ConnectionConfig.ConnectionConfigModel.SqlLiteConfig.ConnectionStr);
        }
        private SqlLiteHelper sqlLiteHelper;

        public List<RefreshQueryResultModel> RefreshQuery(string logistics_interface)
        {
            List<RefreshQueryResultModel> lst = new List<RefreshQueryResultModel>();
            RefreshQueryModel queryModel = Newtonsoft.Json.JsonConvert.DeserializeObject<RefreshQueryModel>(logistics_interface);

            string sSql = @"select i.product_no, i.customer_id,i.item_no, c.customer_desc, ifnull(s1.s1Qty,0) as s1Qty,ifnull(po.PoQty,0) as PoQty,ifnull(so.SoQty,0) as SoQty, 
(ifnull(s1.s1Qty,0) + ifnull(po.PoQty,0) - ifnull(so.SoQty,0)) as StockQty ,
i.item_desc
from 
im_item i left join bc_customer c on c.customer_id = i.customer_id 
left join 
(select log_date,product_no,SUM(qty) as s1Qty from wh_balance_stock where log_date=strftime('%Y-%m-%d',datetime('now','localtime')) group by product_no,log_date) s1 on i.product_no = s1.product_no 
left join
(
SELECT d.product_no,h.order_type_id, SUM(d.qty) as PoQty
FROM wh_order_head h  
JOIN wh_io_logs d ON h.order_id = d.order_id AND h.void=0 AND d.void=0 AND h.order_type_id = 1 
WHERE 
d.update_time >= strftime('%Y-%m-%d 00:00:00',datetime('now','localtime')) and d.update_time<= strftime('%Y-%m-%d 23:59:59',datetime('now','localtime'))
group by d.product_no,h.order_type_id
) po on po.product_no=i.product_no
left join
(
SELECT d.product_no,h.order_type_id, SUM(d.qty) as SoQty
FROM wh_order_head h  
JOIN wh_io_logs d ON h.order_id = d.order_id AND h.void=0 AND d.void=0 AND h.order_type_id = -1 
WHERE 
d.update_time >= strftime('%Y-%m-%d 00:00:00',datetime('now','localtime')) and d.update_time<= strftime('%Y-%m-%d 23:59:59',datetime('now','localtime'))
group by d.product_no,h.order_type_id
) so on so.product_no=i.product_no
where 
i.void = 0
 ";
            if (queryModel.CustomerId != -1)
                sSql += " and i.customer_id = 0  ";
            if (!queryModel.IsListAllItems)
                sSql += " and (ifnull(s1.s1Qty,0) + ifnull(po.PoQty,0) - ifnull(so.SoQty,0)) <> 0 ";
            if (queryModel.ItemBarcode != "")
                sSql += " and i.product_no in (select product_no from im_item_barcode where item_barcode like '%" + queryModel.ItemBarcode + "%') ";
            if (queryModel.ItemDesc != "")
                sSql += " and i.item_desc like '%" + queryModel.ItemDesc + "%' ";

           // DataSet dsItems = Common.CommonDa.ExecuteQuery(sSql);
            return lst;
        }
    }
}
