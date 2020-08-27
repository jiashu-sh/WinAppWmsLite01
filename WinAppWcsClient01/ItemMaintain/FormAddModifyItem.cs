using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinAppWmsLite.Entities;

namespace WinAppWmsLite.ItemMaintain
{
    public partial class FormAddModifyItem : Form
    {
        private static EntityItem CurrentItem;
        private static bool bIsModifyItem = false;
        private static int iLoadCustomerId = -1;
        private static string sLoadItemBarcode = "";
        private static bool bIsFromReceiving = false;

        PrintDocument printdoc = new PrintDocument();

        public FormAddModifyItem()
        {
            InitializeComponent();
        }

        public FormAddModifyItem(int iProductNo)
        {
            InitializeComponent();

            if (iProductNo == -1)
                return;

            InitLoadItem(iProductNo);
        }

        public FormAddModifyItem(string sItemBarcode, int iCustomerId)
        {
            sLoadItemBarcode = sItemBarcode;
            iLoadCustomerId = iCustomerId;
            bIsFromReceiving = true;

            InitializeComponent();
        }

        private void InitLoadItem(int iProductNo)
        {
            string sSql = @"SELECT i.product_no,i.item_no,b.item_barcode,i.item_desc,i.customer_id,c.customer_desc 
FROM im_item i join im_item_barcode b on i.product_no = b.product_no
join bc_customer c on c.customer_id = i.customer_id
where i.void=0";
            sSql += " and i.product_no = " + iProductNo.ToString();
            DataSet dsItems = Common.CommonDa.ExecuteQuery(sSql);
            if (dsItems != null)
            {
                if (dsItems.Tables[0].Rows.Count == 0)
                    return;

                bIsModifyItem = true;
                try
                {
                    tbItemBarcode.Text = dsItems.Tables[0].Rows[0]["item_barcode"].ToString().Trim();
                    tbProductNo.Text = dsItems.Tables[0].Rows[0]["product_no"].ToString().Trim();
                    tbItemNo.Text = dsItems.Tables[0].Rows[0]["item_no"].ToString().Trim();
                    tbItemDesc.Text = dsItems.Tables[0].Rows[0]["item_desc"].ToString().Trim();
                    iLoadCustomerId = int.Parse(dsItems.Tables[0].Rows[0]["customer_id"].ToString().Trim());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void FormAddModifyItem_Load(object sender, EventArgs e)
        {
            CurrentItem = new EntityItem();

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

                try
                {
                    if (iLoadCustomerId != -1)
                        cbCustomeId.SelectedValue = iLoadCustomerId;
                }
                catch
                { }
            }

            if (!bIsModifyItem) //新增时获取新id
            {
                int iProductNo = Common.CommonUtil.GenProductNo("im_item.product_no");
                if (iProductNo != -1)
                    tbProductNo.Text = iProductNo.ToString();
            }

            if (sLoadItemBarcode.Trim() != "")
            {
                tbItemBarcode.Text = sLoadItemBarcode;

                Entities.EntityItem entityItem = Common.CommonUtil.GetItem(sLoadItemBarcode.Trim(), int.Parse(cbCustomeId.SelectedValue.ToString()));
                if ((entityItem != null) && (entityItem.ProductNo != -1))
                {
                    MessageBox.Show("商品已经存在.");
                }
            }

            //20140924 获取打印机列表
            LoadAvilablePrinter();

            tbItemBarcode.Focus();
        }

        private void cbxIsGenSn_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxIsGenSn.Checked)
                tbSnNo.Text = Common.CommonUtil.GenSerailNo("im_item.sn_no").ToString();
        }


        /// <summary>
        /// 获取打印机列表
        /// </summary>
        private void LoadAvilablePrinter()
        {

            string sDefault = printdoc.PrinterSettings.PrinterName;//默认打印机名

            cbPrinter.Items.Clear();

            foreach (string sPrint in System.Drawing.Printing.PrinterSettings.InstalledPrinters)//获取所有打印机名称
            {
                cbPrinter.Items.Add(sPrint);

                /*
                 默认获取打印机名称前2位,如果是ep,就默认为epson 面单打印机，如果是gp,就默认为小票打印机
                 */
                if (sPrint.IndexOf("245") != -1)
                {
                    cbPrinter.SelectedIndex = cbPrinter.Items.IndexOf(sPrint);
                    break;
                }

                if (cbPrinter.Items.Count > 0)
                    cbPrinter.SelectedIndex = 0;
            }

        }


        private void tbItemBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbItemNo.Text = tbItemBarcode.Text.Trim();
                tbItemDesc.Focus();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string sBarcode = tbItemBarcode.Text.Trim();
            string sProductNo = tbProductNo.Text.Trim();
            string sItemNo = tbItemNo.Text.Trim();
            string sItemDesc = tbItemDesc.Text.Trim();
            string sSnNo = tbSnNo.Text.Trim();
            pntProductNo.Text = sProductNo;
            pntBarcode.Text = sBarcode;
            pntSnNo.Text = "SN : " + sSnNo;
            pntItemDesc.Text = tbItemDesc.Text;
            pntItemNo.Text = sItemNo;

            DataMatrix.net.DmtxImageEncoder dmtxEncoder = new DataMatrix.net.DmtxImageEncoder();
            Bitmap bmpDmtxCode = dmtxEncoder.EncodeImage(sProductNo);

            Common.Code128 code128 = new Common.Code128();
            Bitmap bmpProductNo = code128.GetCodeImage(sProductNo, Common.Code128.Encode.Code128C);
            Bitmap bmpSnNo = code128.GetCodeImage(sProductNo, Common.Code128.Encode.Code128C);
            if (cbxIsGenSn.Checked)
                bmpSnNo = code128.GetCodeImage(sSnNo, Common.Code128.Encode.Code128C);

            Regex r = new Regex(@"^\d+$");
            Common.Code128.Encode encode128 = Common.Code128.Encode.Code128A;

            Bitmap bmpBarcode;
            //if ((r.Match(sBarcode).Success) && (sBarcode.Length == 13))
            //{
            //    Common.Ean13 ean13 = new Common.Ean13();
            //    Graphics g = new .CreateGraphics();
            //    var a = panelContent.CreateGraphics();
            //    var rectangleObj = new Rectangle(20, 20, 200, 50);
            //    core.Paint_EAN13("211812100001", a, rectangleObj);
            //}
            //else
            {
                if (r.Match(sBarcode).Success)
                    if ((sBarcode.Length % 2) == 0)
                        encode128 = Common.Code128.Encode.Code128C;
                bmpBarcode = code128.GetCodeImage(sBarcode, encode128);
            }

            encode128 = Common.Code128.Encode.Code128A;
            if (r.Match(sItemNo).Success)
                if ((sItemNo.Length % 2) == 0)
                    encode128 = Common.Code128.Encode.Code128C;
            Bitmap bmpItemNo = code128.GetCodeImage(sItemNo.ToUpper(), encode128);

            //bmpProductNo = Common.BitmapScaleHelper.ScaleToSize(bmpProductNo,2); //缩放图片
            //bmpProductNo = Common.BitmapScaleHelper.ScaleToSize(bmpProductNo, bmpProductNo.Width * 2, bmpProductNo.Height);
            pbDmProductNo.Image = bmpDmtxCode;
            //pbProductNo.Image = bmpProductNo;

            pbBarcode.Image = bmpBarcode;

            //if (sItemNo != sBarcode)
            //    pbItemNo.Image = bmpItemNo;

            if (cbxIsGenSn.Checked)
                pbSnNo.Image = bmpSnNo;

            string sLog = "";
            sLog += bmpDmtxCode.Width + " x " + bmpDmtxCode.Height + "\r\n";
            sLog += bmpProductNo.Width + " x " + bmpProductNo.Height + "\r\n";
            sLog += bmpBarcode.Width + " x " + bmpBarcode.Height + "\r\n";
            sLog += bmpItemNo.Width + " x " + bmpItemNo.Height + "\r\n";
            sLog += bmpSnNo.Width + " x " + bmpSnNo.Height + "\r\n";

            tbLogs.Text = sLog;

            //打印产品标签
            if (DialogResult.Yes == MessageBox.Show("打印确认","是否确认打印产品标签?",MessageBoxButtons.YesNo,MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                PrintItemLabel();
        }

        private void PrintItemLabel()
        {            
            PrintItemBarcodeLabel();
        }


        private bool PrintItemBarcodeLabel()
        {
            bool bPrint = false;
            try
            {
                //设置文档名
                printdoc.DocumentName = tbProductNo.Text.Trim();//设置完后可在打印对话框及队列中显示（默认显示document）

                //打印开始前
                printdoc.BeginPrint += new PrintEventHandler(printDocument_BeginPrint);
                //打印输出（过程）
                printdoc.PrintPage += new PrintPageEventHandler(ExcutPrintLabel);
                //打印结束
                printdoc.EndPrint += new PrintEventHandler(printDocument_EndPrint);

                printdoc.PrinterSettings.PrinterName = cbPrinter.SelectedItem.ToString();

                /////打印时隐藏弹出 正在打印
                printdoc.PrintController = new StandardPrintController();
                if (!printdoc.PrinterSettings.IsValid)
                {
                    //找不到打印机则不打印，报错返回。
                    bPrint = false;
                }
                else
                {
                    printdoc.Print();          //打印
                    printdoc.Dispose();

                    printdoc = new PrintDocument();
                    bPrint = true;
                }

            }
            catch (Exception ex)
            {

                bPrint = false;
            }

            return bPrint;
        }

        private void printDocument_EndPrint(object sender, PrintEventArgs e)
        {
            //也可以把一些打印的参数放在此处设置
        }

        private void ExcutPrintLabel(object sender, PrintPageEventArgs e)
        {


            string sBarcode = tbItemBarcode.Text.Trim();
            string sProductNo = tbProductNo.Text.Trim();
            string sItemNo = tbItemNo.Text.Trim();
            string sItemDesc = tbItemDesc.Text.Trim();
            string sSnNo = tbSnNo.Text.Trim();

            //商品号ProductNo Dm二维码
            DataMatrix.net.DmtxImageEncoder dmtxEncoder = new DataMatrix.net.DmtxImageEncoder();
            Bitmap bmpDmtxCode = dmtxEncoder.EncodeImage(sProductNo);
            //商品号的条形码（不用打印条形码）
            Common.Code128 code128 = new Common.Code128();
            Bitmap bmpProductNo = code128.GetCodeImage(sProductNo, Common.Code128.Encode.Code128C);

            Regex r = new Regex(@"^\d+$");
            Common.Code128.Encode encode128 = Common.Code128.Encode.Code128A;

            //商品条码
            Bitmap bmpBarcode;
            if (r.Match(sBarcode).Success)
                if ((sBarcode.Length % 2) == 0)
                    encode128 = Common.Code128.Encode.Code128C;
            bmpBarcode = code128.GetCodeImage(sBarcode, encode128);

            //产品号（不用打印条码）
            encode128 = Common.Code128.Encode.Code128A;
            if (r.Match(sItemNo).Success)
                if ((sItemNo.Length % 2) == 0)
                    encode128 = Common.Code128.Encode.Code128C;
            Bitmap bmpItemNo = code128.GetCodeImage(sItemNo.ToUpper(), encode128);

            //sn号的条码
            Bitmap bmpSnNo = code128.GetCodeImage(sProductNo, Common.Code128.Encode.Code128C);
            if (cbxIsGenSn.Checked)
                bmpSnNo = code128.GetCodeImage(sSnNo, Common.Code128.Encode.Code128C);
            sSnNo = "SN : " + tbSnNo.Text.Trim(); //sn描述

            //位置偏移量
            const float PAGE_START_OFFSET_X = 2;
            const float PAGE_START_OFFSET_Y = 2;
            PointF pOffset = new PointF(PAGE_START_OFFSET_X, PAGE_START_OFFSET_Y);

            PointF pointBarcode = new PointF(pOffset.X + pbBarcode.Location.X, pOffset.Y + pbBarcode.Location.Y);
            PointF pointBarcodeDesc = new PointF(pOffset.X + pntBarcode.Location.X, pOffset.Y + pntBarcode.Location.Y);

            PointF pointItemNoDesc = new PointF(pOffset.X + pntItemNo.Location.X, pOffset.Y + pntItemNo.Location.Y);
            PointF pointItemDesc = new PointF(pOffset.X + pntItemDesc.Location.X, pOffset.Y + pntItemDesc.Location.Y);

            PointF pointDmtxCode = new PointF(pOffset.X + pbDmProductNo.Location.X, pOffset.Y + pbDmProductNo.Location.Y);
            PointF pointProductNoDesc = new PointF(pOffset.X + pntProductNo.Location.X, pOffset.Y + pntProductNo.Location.Y);

            PointF pointSnNoCode = new PointF(pOffset.X + pbSnNo.Location.X, pOffset.Y + pbSnNo.Location.Y);
            PointF pointSnNoDesc = new PointF(pOffset.X + pntSnNo.Location.X, pOffset.Y + pntSnNo.Location.Y);



            //return;


            //-----------打印货位文字----------
            Brush brushDefaultFont = new SolidBrush(Color.Black);

            Font ArialFontSmall = new Font("Arial Bold", 9);
            Font ArialFontSn = new Font("Arial", 6);
            Font ArialFontBig = new Font("Arial Bold", 9);
            Font ArialFontDesc = new Font("Arial,宋体", 9);

            Graphics g = e.Graphics;

            //-----------打印条码--------------
            g.DrawImage(bmpBarcode, pointBarcode.X, pointBarcode.Y, bmpBarcode.Width, pbBarcode.Height);
            g.DrawString(sBarcode, ArialFontSmall, brushDefaultFont, pointBarcodeDesc); //条码文字

            //ItemNo描述
            g.DrawString(sItemNo, ArialFontSn, brushDefaultFont, pointItemNoDesc); //文字
            //ItemDesc
            const int LINE_CHARS = 8;
            string sTemp = "";
            if (sItemDesc.Length > LINE_CHARS)
                sTemp = sItemDesc.Substring(0, LINE_CHARS);
            g.DrawString(sTemp, ArialFontDesc, brushDefaultFont, pointItemDesc); //条码文字
            if (sItemDesc.Length > LINE_CHARS)
            {
                string sTemp2 = sItemDesc.Substring(LINE_CHARS, (sItemDesc.Length - LINE_CHARS));

                if (sItemDesc.Length > LINE_CHARS * 2)
                {
                    string sTemp3 = sTemp2.Substring(LINE_CHARS, (sTemp2.Length - LINE_CHARS));
                    sTemp2 = sTemp2.Substring(0, LINE_CHARS);
                    pointItemDesc.Y = pointItemDesc.Y + 12;
                    g.DrawString(sTemp2, ArialFontDesc, brushDefaultFont, pointItemDesc); //条码文字
                    pointItemDesc.Y = pointItemDesc.Y + 12 ;
                    g.DrawString(sTemp3, ArialFontDesc, brushDefaultFont, pointItemDesc); //条码文字
                }
                else
                {
                    pointItemDesc.Y = pointItemDesc.Y + 12;
                    g.DrawString(sTemp2, ArialFontDesc, brushDefaultFont, pointItemDesc); //条码文字
                }
                
            }

            //datamatrix二维码
            g.DrawImage(bmpDmtxCode, pointDmtxCode.X, pointDmtxCode.Y, bmpDmtxCode.Width, bmpDmtxCode.Height);
            g.DrawString(sProductNo, ArialFontSmall, brushDefaultFont, pointProductNoDesc); //条码文字

            //---------------------------------


            if (cbxIsGenSn.Checked)
            {
                //-----------打印sn条码--------------
                g.DrawImage(bmpSnNo, pointSnNoCode.X, pointSnNoCode.Y, bmpSnNo.Width, pbSnNo.Height);
                g.DrawString(sSnNo, ArialFontSn, brushDefaultFont, pointSnNoDesc); //条码文字
            }


            //---------------------------------

        }

        private void printDocument_BeginPrint(object sender, PrintEventArgs e)
        {
            //打印结束后相关操作
        }

        private void btnCopyProductNo_Click(object sender, EventArgs e)
        {
            tbItemBarcode.Text = tbProductNo.Text;
        }

        private void btnInsertUpdateItem_Click(object sender, EventArgs e)
        {
            if ((tbItemBarcode.Text.Trim() == "") || (tbItemDesc.Text.Trim() == ""))
            {
                MessageBox.Show("输入内容不完整，请检查。");
                return;
            }

            CurrentItem.CustomerId = int.Parse(cbCustomeId.SelectedValue.ToString());
            CurrentItem.ProductNo = int.Parse(tbProductNo.Text);
            CurrentItem.ItemNo = tbItemNo.Text.Trim().ToUpper();
            if (CurrentItem.ItemNo == "")
                CurrentItem.ItemNo = tbItemBarcode.Text.Trim().ToUpper();
            CurrentItem.ItemDesc = tbItemDesc.Text.Trim();
            CurrentItem.UserId = FormMain.USER_ID;
            EntityItemBarcode ItemBarcode = new EntityItemBarcode();
            ItemBarcode.ProductNo = CurrentItem.ProductNo;
            ItemBarcode.CustomerId = CurrentItem.CustomerId;
            ItemBarcode.ItemBarcode = tbItemBarcode.Text.Trim().ToUpper();
            ItemBarcode.UserId = CurrentItem.UserId;
            List<EntityItemBarcode> ListItemBarcodes = new List<EntityItemBarcode>();
            ListItemBarcodes.Add(ItemBarcode);
            CurrentItem.ItemBarcodes = ListItemBarcodes;

            if (DaItemMaintain.InsertUpdateItem(CurrentItem))
            {
                MessageBox.Show("保存成功");
                if (bIsFromReceiving)
                    this.DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("保存失败");
        }

        
    }
}
