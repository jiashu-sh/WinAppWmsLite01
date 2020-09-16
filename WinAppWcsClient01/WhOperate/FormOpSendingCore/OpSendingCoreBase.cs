using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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



        public void txtOperator_KeyDown(object sender, KeyEventArgs e)
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
                //获取当前库存


            }
        }

        public void btnSaveCommit_Click(object sender, EventArgs e)
        {
            
        }
    }
}
