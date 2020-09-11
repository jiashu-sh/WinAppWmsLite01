using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinAppWmsLite.ItemMaintain;

namespace WinAppWmsLite.WhOperate
{
    public partial class FormOpReceiving : Form
    {
        private static Entities.EntityOrder RcvOrder;
        private static List<Entities.EntityIoLogs> EntityIoLogsList;
        private static Entities.EntityItem ScanItem;

        public FormOpReceiving()
        {
            InitializeComponent();
        }

        private void FormOpReceiving_Load(object sender, EventArgs e)
        {
            gvListIoLogs.AutoGenerateColumns = false;
            gvListItem.AutoGenerateColumns = false;

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

                tbBarcode.Focus();
            }

            cbUomId.DisplayMember = "code_desc";
            cbUomId.ValueMember = "code_id";
            if ((FormMain.DS_BC_UOM != null) && (FormMain.DS_BC_UOM.Tables[0].Rows.Count > 0))
            {
                cbUomId.DataSource = FormMain.DS_BC_UOM.Tables[0];
                if (cbUomId.Items.Count > 0)
                    cbUomId.SelectedIndex = 0;
            }

            InitOrderEntity();
            //if (!bIsModifyItem) //新增时获取新id
        }

        private void InitOrderEntity()
        {
            int iOrderNo = Common.CommonUtil.GenOrderNo("wh_order_head.order_id", 1);
            if (iOrderNo != -1)
                tbPoNo.Text = iOrderNo.ToString();

            RcvOrder = new Entities.EntityOrder();
            RcvOrder.OrderId = iOrderNo;
            RcvOrder.OrderNo = iOrderNo.ToString();
            RcvOrder.OrderTypeId = 1;
            RcvOrder.UserId = FormMain.USER_ID;

            EntityIoLogsList = new List<Entities.EntityIoLogs>();
        }

        private void cbInputSnLot_CheckedChanged(object sender, EventArgs e)
        {
            pnlLotSn.Visible = cbInputSnLot.Checked;
        }

        private void btnInsertReceivingItem_Click(object sender, EventArgs e)
        {
            InsertReceivingItemList();
        }

        private void InsertReceivingItemList()
        {
            
            if (tbContainerNo.Text.Trim() == "")
            {
                return;
            }
            if ((ScanItem == null) || (ScanItem.ProductNo == -1))
            {
                return;
            }
            if (tbQty.Text.Trim() == "")
            {
                return;
            }
            Regex r = new Regex(@"^\d+$");
            if (!(r.Match(tbQty.Text.Trim()).Success))
            {
                return;
            }

            int iQty = int.Parse(tbQty.Text.Trim());
            int iIndexNo = EntityIoLogsList.Count + 1;

            Entities.EntityIoLogs ioLogs = new Entities.EntityIoLogs();
            ioLogs.Item = ScanItem;
            ioLogs.IoTypeId = (int)Common.EnumIoTypes.In;
            ioLogs.OrderId = RcvOrder.OrderId;
            ioLogs.UomId = int.Parse(cbUomId.SelectedValue.ToString());
            ioLogs.ContainerId = tbContainerNo.Text.Trim();
            ioLogs.Qty = iQty;
            if (cbInputSnLot.Checked)
            {
                if (rbLot.Checked)
                    ioLogs.LotNo = tbLotSn.Text.Trim();
                else if (rbSn.Checked)
                    ioLogs.SerialNo = tbLotSn.Text.Trim();
            }
            ioLogs.IndexNo = iIndexNo;
            ioLogs.ItemBarcode = ScanItem.ItemBarcodes[0].ItemBarcode;
            ioLogs.ItemDesc = ScanItem.ItemDesc;

            EntityIoLogsList.Add(ioLogs);

            RefreshIoLogsList();

            RefreshInput();
        }

        private void RefreshInput()
        {
            tbBarcode.Text = "";
            tbProductNo.Text = "";
            tbLotSn.Text = "";
            tbQty.Text = "";
            cbInputSnLot.Checked = false;
            lbItemDesc.ForeColor = Color.Green;

            ScanItem = null;
        }

        private void RefreshIoLogsList()
        {
            gvListIoLogs.DataSource = null;
            gvListIoLogs.DataSource = EntityIoLogsList;
        }

        private void tbBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GetItem();
            }
        }

        private void GetItem()
        {
            string sBarcode = tbBarcode.Text.Trim();
            if (sBarcode == "")
                return;

            Entities.EntityItem entityItem = Common.CommonUtil.GetItem(sBarcode,int.Parse(cbCustomeId.SelectedValue.ToString()));

            if ((entityItem != null) && (entityItem.ProductNo != -1))
            {
                tbProductNo.Text = entityItem.ProductNo.ToString();
                lbItemDesc.Text = entityItem.ItemDesc;

                ScanItem = entityItem;

                if (tbQty.Text.Trim() == "")
                {
                    tbQty.Text = "1";
                    tbContainerNo.Focus();
                }
                else
                {
                    Regex r = new Regex(@"^\d+$");
                    if (!(r.Match(tbQty.Text.Trim()).Success))
                    {
                        tbQty.Text = "1";
                        tbContainerNo.Focus();
                        return;
                    }

                    int iQty = int.Parse(tbQty.Text.Trim());
                    //今后再添加扫描同条码累计功能
                }
            }
            else
            {
                lbItemDesc.Text = "商品不存在(未维护基本信息).";
                lbItemDesc.ForeColor = Color.Red;
            }
                //MessageBox.Show("商品不存在(未维护基本信息).");
        }

        private void btnClearInput_Click(object sender, EventArgs e)
        {
            RefreshInput();
        }

        private void btnCreateNewItem_Click(object sender, EventArgs e)
        {
            int iCustomerId = int.Parse(cbCustomeId.SelectedValue.ToString());
            string sItemBarcode = tbBarcode.Text.Trim();
            FormAddModifyItem formAddModifyItem = new FormAddModifyItem(sItemBarcode,iCustomerId);
            DialogResult dlgResult = formAddModifyItem.ShowDialog(this);
            if (dlgResult == DialogResult.OK)
                GetItem();
        }

        private void btnSaveCommit_Click(object sender, EventArgs e)
        {
            ReceivingSaveCommit();
        }

        private void ReceivingSaveCommit()
        {
            if ((RcvOrder == null) || (RcvOrder.OrderId == -1))
            {
                MessageBox.Show("参数 RcvOrder 错误,无法继续.");
                return;
            }
            if ((EntityIoLogsList == null) || (EntityIoLogsList.Count == 0))
            {
                MessageBox.Show("参数 EntityIoLogsList 错误,无法继续.");
                return;
            }

            RcvOrder.CustomerId = int.Parse(cbCustomeId.SelectedValue.ToString());
            RcvOrder.IoLogsList = EntityIoLogsList;

            if (DaOpReceiving.ReceivingCommit(RcvOrder))
                MessageBox.Show("保存完成.");
            else
                MessageBox.Show("保存失败.");
        }
    }
}
