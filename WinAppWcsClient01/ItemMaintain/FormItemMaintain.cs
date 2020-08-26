using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppWmsLite.ItemMaintain
{
    public partial class FormItemMaintain : Form
    {
        public FormItemMaintain()
        {
            InitializeComponent();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            FormAddModifyItem formAddModifyItem = new FormAddModifyItem();
            DialogResult dlgResult = formAddModifyItem.ShowDialog(this);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ListItems();
        }

        private void ListItems()
        {
            string sSql = @"SELECT i.product_no,i.item_no,b.item_barcode,i.item_desc,c.customer_desc 
FROM im_item i join im_item_barcode b on i.product_no = b.product_no
join bc_customer c on c.customer_id = i.customer_id
where i.void=0";
            DataSet dsItems = Common.CommonDa.ExecuteQuery(sSql);
            if (dsItems != null)
            {
                try
                {
                    gvListItem.DataSource = dsItems.Tables[0];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void gvListItem_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                string sProductNo = gvListItem.Rows[e.RowIndex].Cells["col_product_no"].Value.ToString();
                int iProductNo = -1;
                try
                {
                    iProductNo = int.Parse(sProductNo);
                }
                catch
                {
                    return;
                }
                if (iProductNo == -1)
                    return;
                //string OrderNum_S = gvList.Rows[e.RowIndex].Cells["OrderNo"].Value.ToString();
                FormAddModifyItem formAddModifyItem = new FormAddModifyItem(iProductNo);
                DialogResult dlgResult = formAddModifyItem.ShowDialog(this);
                //formAddModifyItem.StartPosition = FormStartPosition.CenterScreen;
                //formAddModifyItem.WindowState = FormWindowState.Normal;
                //formAddModifyItem.ShowDialog();
                //if (formModifySoHeaderInfo.DialogResult == DialogResult.OK)
                //{
                //    return;
                //}
            }
        }
    }
}
