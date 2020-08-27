using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinAppWmsLite.Entities;

namespace WinAppWmsLite.WhMgt
{
    public partial class FormStockQuery : Form
    {
        public FormStockQuery()
        {
            InitializeComponent();
        }

        private void FormStockQuery_Load(object sender, EventArgs e)
        {
            gvListItemLocations.AutoGenerateColumns = false;
            gvListItems.AutoGenerateColumns = false;

            cbCustomeId.DisplayMember = "customer_desc";
            cbCustomeId.ValueMember = "customer_id";
            if (FormMain.DS_BC_CUSTOMER != null)
            {
                if (FormMain.DS_BC_CUSTOMER.Tables[0].Rows.Count > 1)
                {
                    DataTable dtCust = FormMain.DS_BC_CUSTOMER.Tables[0];
                    System.Data.DataRow dr = dtCust.NewRow();
                    dr["customer_id"] = -1; // CommonDefine.MSG_SELECT;
                    dr["customer_desc"] = "全部"; // CommonDefine.MSG_SELECT;
                    dtCust.Rows.Add(dr);
                    cbCustomeId.DataSource = dtCust;
                    cbCustomeId.SelectedValue = -1;
                }
                else
                    cbCustomeId.DataSource = FormMain.DS_BC_CUSTOMER.Tables[0];
                if (cbCustomeId.Items.Count > 0)
                    cbCustomeId.SelectedIndex = 0;

                tbItemBarcode.Focus();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            RefreshQuery();
        }

        private void RefreshQuery()
        {
            if ((tbItemBarcode.Text.Trim().IndexOf("'") != -1) ||
                (tbItemDesc.Text.Trim().IndexOf("'") != -1)
                )
            {
                return;
            }

            EntityParaItemQuery paraItemQuery = new EntityParaItemQuery();
            paraItemQuery.CustomerId = int.Parse(cbCustomeId.SelectedValue.ToString());
            paraItemQuery.ItemBarcode = tbItemBarcode.Text.Trim();
            paraItemQuery.ItemDesc = tbItemDesc.Text.Trim();
            paraItemQuery.IsListAllItems = cbListAllItem.Checked;

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
            if (paraItemQuery.CustomerId != -1)
                sSql += " and i.customer_id = 0  ";
            if (!paraItemQuery.IsListAllItems)
                sSql += " and (ifnull(s1.s1Qty,0) + ifnull(po.PoQty,0) - ifnull(so.SoQty,0)) <> 0 ";
            if (paraItemQuery.ItemBarcode != "")
                sSql += " and i.product_no in (select product_no from im_item_barcode where item_barcode like '%"+ paraItemQuery.ItemBarcode + "%') ";
            if (paraItemQuery.ItemDesc != "")
                sSql += " and i.item_desc like '%"+ paraItemQuery.ItemDesc + "%' ";

            gvListItems.DataSource = null;
            DataSet dsItems = Common.CommonDa.ExecuteQuery(sSql);
            if (dsItems == null)
                return;

            gvListItems.DataSource = dsItems.Tables[0];

        }
    }
}
