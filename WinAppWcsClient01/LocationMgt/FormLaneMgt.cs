using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppWmsLite.LocationMgt
{
    public partial class FormLaneMgt : Form
    {
        private const int DEFAULT_GRID_SIZE = 50;
        private const int DEFAULT_STEP_GRID_SIZE = 10;

        private static string AreaNo;
        private static int ParaX;
        private static int ParaY;

        private static List<Entities.EntityLocation> ListLocations = new List<Entities.EntityLocation>();
        private static List<Entities.EntityLocShelf> ListLocShelfs = new List<Entities.EntityLocShelf>();
        private static List<Entities.EntityLocLane> ListLocLanes = new List<Entities.EntityLocLane>();

        public FormLaneMgt()
        {
            InitializeComponent();
        }

        public FormLaneMgt(string sAreaNo, int iParaX, int iParaY)
        {
            InitializeComponent();
            
            AreaNo = sAreaNo;
            ParaX = iParaX - iParaX % DEFAULT_STEP_GRID_SIZE;
            ParaY = iParaY - iParaY % DEFAULT_STEP_GRID_SIZE;

            lbXVal.Text = (iParaX - iParaX % DEFAULT_STEP_GRID_SIZE).ToString();
            lbYVal.Text = (iParaY - iParaY % DEFAULT_STEP_GRID_SIZE).ToString();

            lbTipAreaNo.Text = sAreaNo;
            tbAreaNo.Text = sAreaNo;
        }

        private void FormLaneMgt_Load(object sender, EventArgs e)
        {
            InitForm();
        }

        private void InitForm()
        {
            if (!FormLocationMapSet._bLoadDbData)
                return ;

            string strsql = "select storage_type_id,storage_type_desc from loc_storage_type where void=0 ";
            DataSet dsStorageTpye = Common.CommonDa.ExecuteQuery(strsql);
            cbStorageType.DisplayMember = "storage_type_desc";
            cbStorageType.ValueMember = "storage_type_id";
            if (dsStorageTpye != null)
            {
                cbStorageType.Items.Clear();
                cbStorageType.DataSource = dsStorageTpye.Tables[0];
                if (dsStorageTpye.Tables[0].Rows.Count > 0)
                    cbStorageType.SelectedIndex = 0;
            }

            if (cbLaneDirection.Items.Count > 0)
                cbLaneDirection.SelectedIndex = 0;

            if (cbLaneOrder.Items.Count > 0)
                cbLaneOrder.SelectedIndex = 0;

            if (cbOddEven.Items.Count > 0)
                cbOddEven.SelectedIndex = 0;
        }

        private void lstbStorageType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGenLocationNo_Click(object sender, EventArgs e)
        {
            lbToInsertLocCount.Text = "";

            int iLaneNoStart = 0;
            int iLaneNoEnd = 0;
            int iShelfNoStart = 0;
            int iShelfNoEnd = 0;
            int iTiersCount = 0;
            int iLocationsCount = 0;
            try
            {
                iLaneNoStart = int.Parse(tbLaneNoStart.Text.Trim());
                iLaneNoEnd = int.Parse(tbLaneNoEnd.Text.Trim());
                iShelfNoStart = int.Parse(tbShelfNoStart.Text.Trim());
                iShelfNoEnd = int.Parse(tbShelfNoEnd.Text.Trim());
                iTiersCount = int.Parse(tbGenTierCount.Text.Trim());
                iLocationsCount = int.Parse(tbGenLocCount.Text.Trim());
            }
            catch
            {
                MessageBox.Show("数据格式错误,必须数字数字.");
                return;
            }
            string sAreaNo = tbAreaNo.Text.Trim();

            int iStorageType = -1;
            try
            {
                iStorageType = int.Parse(cbStorageType.SelectedValue.ToString());
            }
            catch { }

            if (iLaneNoStart > iLaneNoEnd)
            {
                MessageBox.Show("起始通道号必须大于终止通道号.");
                return;
            }
            if (iShelfNoStart > iShelfNoEnd)
            {
                MessageBox.Show("起始货位号必须大于终止通道号.");
                return;
            }

            if ((iLocationsCount >= 7) )
            {
                MessageBox.Show("货位列数必须大于0并且小于7.");
                return;
            }

            GenLocations(sAreaNo, iStorageType, iLaneNoStart, iLaneNoEnd, iShelfNoStart, iShelfNoEnd, iTiersCount, iLocationsCount);
        }

        private void GenLocations(string sAreaNo, int iStorageType, int iLaneNoStart, int iLaneNoEnd, int iShelfNoStart, int iShelfNoEnd, int iTiersCount, int iLocationsCount)
        {
            lstboxLocationNos.Items.Clear();
            lstboxShelfNos.Items.Clear();
            lstboxLaneNos.Items.Clear();

            if (ListLocations != null)
                ListLocations.Clear();
            if (ListLocShelfs != null)
                ListLocShelfs.Clear();
            if (ListLocLanes != null)
                ListLocLanes.Clear();

            string ExistLocs = "";
            string LocationNo = "";
            int iExistLocCount = 0;
            int iNewLocCount = 0;

            int iCurrentX = ParaX ;
            int iCurrentY = ParaY ;

            for (int iLane = iLaneNoStart; iLane <= iLaneNoEnd; iLane++)
            {
                string sLaneNo = "";

                //当用户一次性增加一个区时
                if (cbOddEven.SelectedIndex == 0)
                {
                    if (iLane > iLaneNoStart) //正常情况：从第二个通道开始，到最后一个通道，有奇数面
                    {
                        sLaneNo = AreaNo + iLane.ToString("D2") + "-" + "1";
                        if (!CheckLaneNoExist(sLaneNo))
                        {
                            //ListLocLanes.Add
                            lstboxLaneNos.Items.Add(sLaneNo);
                            //加入List
                            Entities.EntityLocLane eLocLane = new Entities.EntityLocLane();
                            eLocLane.AreaNo = AreaNo;
                            eLocLane.LaneNo = "";
                            eLocLane.LaneDesc = "";
                            eLocLane.LayersSet = iTiersCount;
                            eLocLane.LaneDirection = cbLaneDirection.Text.Trim();
                            eLocLane.LaneOrder = cbLaneOrder.Text.Trim();
                            eLocLane.XPoint = iCurrentX;
                            eLocLane.YPoint = iCurrentY;
                            eLocLane.LanePri = iLane;
                            eLocLane.UserId = FormMain.USER_ID;
                            eLocLane.LaneNo = sLaneNo;
                            eLocLane.LaneDesc = AreaNo + iLane.ToString("D2");
                            if ((eLocLane.LaneDirection == "E") || (eLocLane.LaneDirection == "W"))
                                eLocLane.XPoint = iCurrentX + (iLane - 1) * (MapProperty.LANE_BACK_TO_BACK_DISTANCE + MapProperty.LANE_FACE_TO_FACE_DISTANCE) + MapProperty.LANE_FACE_TO_FACE_DISTANCE;
                            else if ((eLocLane.LaneDirection == "N") || (eLocLane.LaneDirection == "S"))
                                eLocLane.YPoint = iCurrentY + (iLane - 1) * (MapProperty.LANE_BACK_TO_BACK_DISTANCE + MapProperty.LANE_FACE_TO_FACE_DISTANCE) + MapProperty.LANE_FACE_TO_FACE_DISTANCE;
                            ListLocLanes.Add(eLocLane);
                        }
                            
                    }
                    if (iLane < iLaneNoEnd) //正常情况：从第一个通道开始，到倒数第二个通道，有偶数面
                    {
                        sLaneNo = AreaNo + iLane.ToString("D2") + "-" + "0";
                        if (!CheckLaneNoExist(sLaneNo))
                        {
                            lstboxLaneNos.Items.Add(sLaneNo);
                            //加入List
                            Entities.EntityLocLane eLocLane = new Entities.EntityLocLane();
                            eLocLane.AreaNo = AreaNo;
                            eLocLane.LaneNo = "";
                            eLocLane.LaneDesc = "";
                            eLocLane.LayersSet = iTiersCount;
                            eLocLane.LaneDirection = cbLaneDirection.Text.Trim();
                            eLocLane.LaneOrder = cbLaneOrder.Text.Trim();
                            eLocLane.XPoint = iCurrentX;
                            eLocLane.YPoint = iCurrentY;
                            eLocLane.LanePri = iLane;
                            eLocLane.UserId = FormMain.USER_ID;
                            eLocLane.LaneNo = sLaneNo;
                            eLocLane.LaneDesc = AreaNo + iLane.ToString("D2");
                            if ((eLocLane.LaneDirection == "E") || (eLocLane.LaneDirection == "W"))
                                eLocLane.XPoint = iCurrentX + (iLane - 1) * (MapProperty.LANE_BACK_TO_BACK_DISTANCE + MapProperty.LANE_FACE_TO_FACE_DISTANCE) + MapProperty.LANE_BACK_TO_BACK_DISTANCE;
                            else if ((eLocLane.LaneDirection == "N") || (eLocLane.LaneDirection == "S"))
                                eLocLane.YPoint = iCurrentY + (iLane - 1) * (MapProperty.LANE_BACK_TO_BACK_DISTANCE + MapProperty.LANE_FACE_TO_FACE_DISTANCE) + MapProperty.LANE_BACK_TO_BACK_DISTANCE;
                            ListLocLanes.Add(eLocLane);
                        }
                    }
                }
                //当用户指定生成双面或者单面时 (这种情况最好就是只做一个特殊通风，否则会有问题)
                if (cbOddEven.SelectedIndex >= 1)
                {
                    if (iLane == 1) //第一个通道是偶数面，大于1的都是奇数面
                        sLaneNo = AreaNo + iLane.ToString("D2") + "-" + "0";
                    else
                        sLaneNo = AreaNo + iLane.ToString("D2") + "-" + "1";
                    if (!CheckLaneNoExist(sLaneNo))
                    {
                        lstboxLaneNos.Items.Add(sLaneNo);
                        //加入List
                        Entities.EntityLocLane eLocLane = new Entities.EntityLocLane();
                        eLocLane.AreaNo = AreaNo;
                        eLocLane.LaneNo = "";
                        eLocLane.LaneDesc = "";
                        eLocLane.LayersSet = iTiersCount;
                        eLocLane.LaneDirection = cbLaneDirection.Text.Trim();
                        eLocLane.LaneOrder = cbLaneOrder.Text.Trim();
                        eLocLane.XPoint = iCurrentX;
                        eLocLane.YPoint = iCurrentY;
                        eLocLane.LanePri = iLane;
                        eLocLane.UserId = FormMain.USER_ID;
                        eLocLane.LaneNo = sLaneNo;
                        eLocLane.LaneDesc = AreaNo + iLane.ToString("D2");
                        ListLocLanes.Add(eLocLane);
                    }
                }                
                //------------------------------

                for (int iShelf = iShelfNoStart; iShelf <= iShelfNoEnd; iShelf++)
                {
                    //当用户指定生成双面或者单面时
                    if (cbOddEven.SelectedIndex == 1)
                    {
                        if ((iShelf % 2) == 0) //设置为只生成奇数通道时，若货架号为偶数不生成直接退出
                            continue;
                    }
                    else if (cbOddEven.SelectedIndex == 2)
                    {
                        if ((iShelf % 2) == 1) //设置为只生成偶数通道时，若货架号为奇数不生成直接退出
                            continue;
                    }
                    //------------------------------

                    //当用户一次性增加一个区时
                    if (cbOddEven.SelectedIndex == 0)
                    {
                        if (iLane == iLaneNoStart)
                        {
                            if ((iShelf % 2) == 1) //第一个通道，只有偶数货架
                                continue;
                        }
                        else if (iLane == iLaneNoEnd)
                        {
                            if ((iShelf % 2) == 0) //最后一个通道，只有奇数货架
                                continue;
                        }
                    }
                    
                    //生成货架和库位信息
                    string sShelfNo = AreaNo + iLane.ToString("D2") + "-" + iShelf.ToString("D2");
                    //
                    Entities.EntityLocShelf eLocShelf = new Entities.EntityLocShelf();
                    eLocShelf.ShelfNo = sShelfNo;
                    eLocShelf.ShelfDesc = sShelfNo;
                    eLocShelf.LaneNo = AreaNo + iLane.ToString("D2") + "-" + (iShelf % 2).ToString();
                    eLocShelf.LayersSet = iTiersCount;
                    eLocShelf.LocsSet = iLocationsCount;                    
                    eLocShelf.StorageTypeId = int.Parse(cbStorageType.SelectedValue.ToString());
                    eLocShelf.ShelfIndex = iShelf;
                    eLocShelf.ShelfPri = iShelf;
                    eLocShelf.UserId = FormMain.USER_ID;

                    if (!CheckShelfNoExist(sShelfNo))
                    {
                        lstboxShelfNos.Items.Add(sShelfNo);
                        ListLocShelfs.Add(eLocShelf);
                    }

                    for (int iTier = 1; iTier <= iTiersCount; iTier++)
                    {
                        for (int iLoc = 1; iLoc <= iLocationsCount; iLoc++)
                        {
                            string sTierLoc = iTier.ToString() + "-" + iLoc.ToString();
                            #region 生成托盘号的规则-注释
                            /*
                            if ((cbPalletNewRule.Checked) && (cbLocType.Text.Trim().IndexOf("PALLET") == 0))
                            {
                                if (iLoc > 4)
                                {
                                    MessageBox.Show("一个托盘上最多允许被划分为4个货位.");
                                    return;
                                }
                                switch (iLoc)
                                {
                                    case 1:
                                        sTierLoc = iTier.ToString() + "-" + "A";
                                        break;
                                    case 2:
                                        sTierLoc = iTier.ToString() + "-" + "B";
                                        break;
                                    case 3:
                                        sTierLoc = iTier.ToString() + "-" + "C";
                                        break;
                                    case 4:
                                        sTierLoc = iTier.ToString() + "-" + "D";
                                        break;
                                    default:
                                        sTierLoc = iTier.ToString() + "-" + "X";
                                        break;
                                }

                            }
                            */
                            #endregion
                            LocationNo = AreaNo + iLane.ToString("D2") + "-" + iShelf.ToString("D2") + "-" + sTierLoc;
                            //
                            Entities.EntityLocation eLocation = new Entities.EntityLocation();
                            eLocation.LocationNo = LocationNo;
                            eLocation.LocationDesc = LocationNo;
                            eLocation.ShelfNo = sShelfNo;

                            if (LocationNo != "")
                            {
                                if (!CheckLocationNoExist(LocationNo))
                                {
                                    lstboxLocationNos.Items.Add(LocationNo);
                                    //
                                    ListLocations.Add(eLocation);
                                    iNewLocCount++;
                                }
                                else
                                {
                                    iExistLocCount++;
                                    ExistLocs += LocationNo + ",";
                                }
                            }
                        }
                    }
                }
            }

            lbToInsertLocCount.Text = iNewLocCount.ToString();

            if (iExistLocCount > 0)
                MessageBox.Show(iExistLocCount.ToString() + " 个库位已存在, 可生成库位 " + iNewLocCount.ToString() + " 个.");
            if (ExistLocs.Trim() != "")
                lbMessage.Text = ExistLocs + "库位已经存在";
        }

        private bool CheckShelfNoExist(string sShelfNo)
        {
            if (!FormLocationMapSet._bLoadDbData)
                return false;

            string strsql = "select shelf_no from loc_shelf where shelf_no = '" + sShelfNo + "' ";
            DataSet dscode = Common.CommonDa.ExecuteQuery(strsql);

            if (dscode != null)
            {
                return true;
            }
            else
                return false;
        }

        private bool CheckLaneNoExist(string sLaneNo)
        {
            if (!FormLocationMapSet._bLoadDbData)
                return false;

            string strsql = "select lane_no from loc_lane where lane_no = '" + sLaneNo + "' ";
            DataSet dscode = Common.CommonDa.ExecuteQuery(strsql);

            if (dscode != null)
            {
                return true;
            }
            else
                return false;
        }

        private bool CheckLocationNoExist(string sLocationNo)
        {
            if (!FormLocationMapSet._bLoadDbData)
                return false;

            string strsql = "select location_no from loc_location where location_no = '" + sLocationNo + "' ";
            DataSet dscode = Common.CommonDa.ExecuteQuery(strsql);

            if (dscode != null)
            {
                return true;
            }
            else
                return false;
        }

        private void cbStorageType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int iStorageType = -1;
            try
            {
                iStorageType = int.Parse(cbStorageType.SelectedValue.ToString());
            }
            catch
            { }

            switch (iStorageType)
            {
                case 12:
                    tbGenLocCount.Text = "3";
                    tbGenTierCount.Text = "4";
                    break;
                case 24:
                    tbGenLocCount.Text = "6";
                    tbGenTierCount.Text = "4";
                    break;
                case 16:
                    tbGenLocCount.Text = "4";
                    tbGenTierCount.Text = "4";
                    break;                
                default:
                    tbGenLocCount.Text = "1";
                    tbGenTierCount.Text = "1";
                    break;
            }
        }

        private void cbGenRule_CheckedChanged(object sender, EventArgs e)
        {
            cbOddEven.Enabled = cbGenRule.Checked;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (lstboxLocationNos.Items.Count == 0)
                return;

            List<string> LocationsList = new List<string>();
            for (int i = 0; i < lstboxLocationNos.Items.Count; i++)
            {
                LocationsList.Add(lstboxLocationNos.Items[i].ToString());
            }

            int TiersCount = 0;
            int LocationsCount = 0;
            try
            {
                TiersCount = int.Parse(tbGenTierCount.Text.Trim());
                LocationsCount = int.Parse(tbGenLocCount.Text.Trim());
            }
            catch
            {
                MessageBox.Show("数据格式错误,必须数字数字.");
                return;
            }
            string sAreaNo = AreaNo;
            string sLaneDirection = cbLaneDirection.Text.Trim();
            string sLaneOrder = cbLaneOrder.Text.Trim();

            int iStorageType = -1;
            try
            {
                iStorageType = int.Parse(cbStorageType.SelectedValue.ToString());
            }
            catch { }

            int iDefaultPri = 100;
            int iParaX = ParaX;
            int iParaY = ParaY;

            int iUid = FormMain.USER_ID;

            if ((ListLocations == null) || (ListLocations.Count == 0))
            {
                MessageBox.Show("无货位信息，无法继续");
                return;
            }
            //if (ListLocShelfs != null)
            //    ListLocShelfs.Clear();
            //if (ListLocLanes != null)
            //    ListLocLanes.Clear();

            List<int> ListInsertLocationsResult = DaLocationMgt.InsertLocations(ListLocLanes, ListLocShelfs, ListLocations);
            if (ListInsertLocationsResult == null)
            {
                MessageBox.Show("货位创建失败.");
                return;
            }

            int iInsertLocationsResult = ListInsertLocationsResult[2];
            int iInsertLocShelfsResult = ListInsertLocationsResult[1];
            int iInsertLocLanesResult = ListInsertLocationsResult[0];

            if (iInsertLocationsResult > 0)// (WarehouseManagementSystem.WarehouseMgt.DALocationView.CreateLocations(LocationsList, WarehouseNo, AreaNo, TiersCount, LocationsCount, DefaultPickingPri, LocationTypeNo, UserId))
            {
                MessageBox.Show("货位创建成功. \n\r 货位: " + iInsertLocationsResult.ToString() + " , 货架: "+ iInsertLocShelfsResult.ToString() + " , 通道: " + iInsertLocLanesResult.ToString());
            }
            else
            {
                MessageBox.Show("货位创建失败.");
            }
        }
    }
}
