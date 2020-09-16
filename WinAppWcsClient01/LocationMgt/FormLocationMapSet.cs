using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinAppWmsLite.Ai;

namespace WinAppWmsLite.LocationMgt
{
    public partial class FormLocationMapSet : Form
    {
        public static bool _bLoadDbData = false;

        private bool bShowMap = false;
        private bool bShowGrid = true;
        //private bool bEnableConfiguration = false;

        private const int DEFAULT_GRID_SIZE = 40;

        private static int iParaX;
        private static int iParaY;

        //private static DataSet DS_STATISTICS = null;
        private static DataSet DS_WAREHOUSE_LAYOUT = null;//全局变量ds
        private static DataView dvlocation = null;

        private const string TABLE_LOC_LANE = "LOC_LANE";
        private const string TABLE_LOC_LOCATION = "LOC_LOCATION";
        private const string TABLE_LOC_STACKED_LOCATION = "LOC_STACKED_LOCATION";
        private const string TABLE_LOC_AREA = "LOC_AREA";
        private const string TABLE_LOC_STATISTICS = "LOC_STATISTICS";
        //private const string TABLE_LOC_HOLD = "TABLE_LOC_HOLD";
        //private const string TABLE_LOC_RF = "LOC_RF";

        

        private static string SEL_SHELF = ""; //选择的货架
        private static string SEL_LANE = ""; //选择的通道（拣选面）

        //路径算法：不可走区域
        private static List<EntityLocationCell> lstDisabledCells = new List<EntityLocationCell>();
        private static EntityLocationCell cStart = new EntityLocationCell();
        private static EntityLocationCell cEnd = new EntityLocationCell();
        private static List<EntityLocationCell> lstPathFind = new List<EntityLocationCell>();

        public FormLocationMapSet()
        {
            InitializeComponent();
        }

        private void FormLocationMapSet_Load(object sender, EventArgs e)
        {
            InitForm();
        }

        private void InitForm()
        {
            _bLoadDbData = cbShowShelfMap.Checked;

            //查数据
            if (_bLoadDbData)
            {
                string strsql = "select * from loc_area where void=0";
                DataSet dsArea = Common.CommonDa.ExecuteQuery(strsql);
                cbAreaNo.DisplayMember = "area_desc";
                cbAreaNo.ValueMember = "area_no";
                if (dsArea != null)
                {
                    cbAreaNo.Items.Clear();
                    cbAreaNo.DataSource = dsArea.Tables[0];
                    if (dsArea.Tables[0].Rows.Count > 0)
                        cbAreaNo.SelectedIndex = 0;
                }

                strsql = "select * from loc_area_group where void=0";
                DataSet dsAreaGroup = Common.CommonDa.ExecuteQuery(strsql);
                cbAreaGroupNo.DisplayMember = "area_group_desc";
                cbAreaGroupNo.ValueMember = "area_group_id";
                if (dsAreaGroup != null)
                {
                    cbAreaGroupNo.Items.Clear();
                    cbAreaGroupNo.DataSource = dsAreaGroup.Tables[0];
                    if (dsAreaGroup.Tables[0].Rows.Count > 0)
                        cbAreaGroupNo.SelectedIndex = 0;
                }
            }

            cbShowGrid.Checked = bShowGrid;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private static void DrawLock(Graphics objGraph, int PointX, int PointY)
        {
            Pen LockPen = new Pen(Color.Black);
            Brush LockBrush = Brushes.Black;
            objGraph.DrawEllipse(LockPen, PointX, PointY, 6, 6); //画个小圆标记，表示原点
            objGraph.FillRectangle(
                                LockBrush,
                                PointX - 1,
                                PointY + 4,
                                5 + 4,
                                5 + 2);
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {
            Graphics objGraph = e.Graphics;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            // 背景默认为黑色，用白色清除之
            objGraph.Clear(Color.White);

            if (bShowMap) //显示背景图
            {
                string MapPath = Application.StartupPath.ToString() + "\\maps\\map01.PNG";
                if (System.IO.File.Exists(MapPath))
                {
                    Image imgMap = Image.FromFile(MapPath);
                    objGraph.DrawImage(imgMap, 0, 0);
                }
            }

            //绘制网格底图
            if (bShowGrid) //显示网格
            {
                #region 绘制网格底图
                Pen GridLinePen = new Pen(Color.Lavender); //位置画笔
                GridLinePen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash; //网格设置为虚线

                //System.Drawing.Font font = new System.Drawing.Font("Arial Black", 9); // 绘制文本字体
                System.Drawing.Font locNoFont = new System.Drawing.Font("Arial Black", 7); // 绘制文本字体
                Brush locNoTextBrush = Brushes.DodgerBlue;
                Brush locNoTextBrushDodgerBlue = Brushes.DodgerBlue;
                Brush locNoTextBrushNavy = Brushes.Navy;

                int GridSize = DEFAULT_GRID_SIZE;
                int DrawTimes = pnlMain.Width / GridSize;
                for (int j = 0; j <= (pnlMain.Height / GridSize); j++)
                {
                    int FontX = 5;
                    int FontY = j * GridSize + GridSize / 2 - ((j / 10).ToString().Length + 1) * 10;//(j/10).ToString().Length : 取出位数，10就是1位，100就是2位

                    if ((j % 5) == 0)
                        locNoTextBrush = locNoTextBrushNavy;
                    else
                        locNoTextBrush = locNoTextBrushDodgerBlue;

                    if (j > 0)
                        objGraph.DrawString(j.ToString(), locNoFont, locNoTextBrush, (FontX), (FontY));
                }
                for (int i = 0; i < DrawTimes; i++)
                {
                    Point sPoint = new Point(GridSize, 0);
                    Point ePoint = new Point(GridSize, pnlMain.Height);
                    sPoint.X += i * GridSize;
                    ePoint.X += i * GridSize;
                    objGraph.DrawLine(GridLinePen, sPoint, ePoint);
                }
                DrawTimes = pnlMain.Height / GridSize;
                for (int j = 0; j <= (pnlMain.Width / GridSize); j++)
                {
                    int FontX = j * GridSize + GridSize / 2 - ((j / 10).ToString().Length + 1) * 10;//(j/10).ToString().Length : 取出位数，10就是1位，100就是2位
                    int FontY = 5;

                    if ((j % 5) == 0)
                        locNoTextBrush = locNoTextBrushNavy;
                    else
                        locNoTextBrush = locNoTextBrushDodgerBlue;

                    if (j > 0)
                        objGraph.DrawString(j.ToString(), locNoFont, locNoTextBrush, (FontX), (FontY));
                }
                for (int i = 0; i < DrawTimes; i++)
                {
                    Point sPoint = new Point(0, GridSize);
                    Point ePoint = new Point(pnlMain.Width, GridSize);
                    sPoint.Y += i * GridSize;
                    ePoint.Y += i * GridSize;
                    objGraph.DrawLine(GridLinePen, sPoint, ePoint);
                }

                //20200113 jiashu 设置不可走位置，画上x
                foreach (EntityLocationCell cDisabled in lstDisabledCells)
                {
                    Point p1 = new Point(GridSize * (cDisabled.X), GridSize * (cDisabled.Y));
                    Point p2 = new Point(GridSize * (cDisabled.X + 1), GridSize * (cDisabled.Y));
                    Point p3 = new Point(GridSize * (cDisabled.X + 1), GridSize * (cDisabled.Y + 1));
                    Point p4 = new Point(GridSize * (cDisabled.X), GridSize * (cDisabled.Y + 1));
                    objGraph.DrawLine(GridLinePen, p1, p3);
                    objGraph.DrawLine(GridLinePen, p2, p4);
                }

                //画出路径
                if ((null != lstPathFind) && (lstPathFind.Count > 0))
                {
                    bool bIsDemo = true;
                    bIsDemo = cbViewMotion.Checked;
                    Brush PathBrush = Brushes.LightGoldenrodYellow;
                    if (!bIsDemo)
                    {
                        foreach (EntityLocationCell cPath in lstPathFind)
                        {
                            objGraph.FillRectangle(
                                    PathBrush,
                                    cPath.X * GridSize + 1,
                                    cPath.Y * GridSize + 1,
                                    GridSize - 2,
                                    GridSize - 2);
                        }
                    }
                    else
                    {
                        for(int i= lstPathFind.Count;i>0;i--)
                        {
                            EntityLocationCell cPath = lstPathFind[i - 1];
                            objGraph.FillRectangle(
                                    PathBrush,
                                    cPath.X * GridSize + 1,
                                    cPath.Y * GridSize + 1,
                                    GridSize - 2,
                                    GridSize - 2);
                            System.Threading.Thread.Sleep(100);
                        }
                    }
                }
                #endregion

                //定义起点终点的半径
                const int iRadiusStart = DEFAULT_GRID_SIZE * 24 / 100;
                const int iRadiusEnd = DEFAULT_GRID_SIZE * 3 / 10;
                //画起点终点
                Brush EndBrush = Brushes.LightSkyBlue;// Brushes.Lavender;
                Pen StartPen = new Pen(Brushes.DeepSkyBlue);// Brushes.Lavender;
                Rectangle rectStart = new Rectangle((cStart.X * GridSize + GridSize / 2 - iRadiusStart), (cStart.Y * GridSize + GridSize / 2 - iRadiusStart), iRadiusStart * 2, iRadiusStart * 2); //标识圆的大小
                objGraph.FillEllipse(EndBrush, rectStart);
                Rectangle rectEnd = new Rectangle((cEnd.X * GridSize + GridSize / 2- iRadiusEnd), (cEnd.Y * GridSize + GridSize / 2- iRadiusEnd), iRadiusEnd*2,iRadiusEnd*2); //标识圆的大小
                objGraph.DrawEllipse(StartPen, rectEnd);
                
                
            }

            if (!cbShowShelfMap.Checked)
                return;
            //DS_WAREHOUSE_LAYOUT = null;//不画货架了

            //判断若全局变量ds==null则直接退出不必绘图
            if (DS_WAREHOUSE_LAYOUT == null)
                return;

            //创建用户交互DV，用户点击时可以依此判断选择的哪个货架
            DataSet DSLocation = null;
            DSLocation = BizLocationView.initEmptyWarehouseGraphicsDS();
            //const string DS_WH_GRAPHICS = "DSNAME_WH_GRAPHICS";
            const string DT_WH_GRAPHICS = "DT_WH_GRAPHICS";
            //----------------------------------------------------
            // 创建绘图用画笔和画刷
            Pen pen = new Pen(Color.Maroon); // 画笔
            Pen tierpen = new Pen(Color.NavajoWhite); // 画笔
            Pen LocationPen = new Pen(Color.SlateGray); //位置画笔
            Brush fillBrush = new SolidBrush(Color.Yellow);    // 填充色
            Brush CartonBrush = new SolidBrush(Color.Orange);
            Brush TierBrush = new SolidBrush(Color.LawnGreen);
            Brush textBrush = Brushes.Black;                        // 文本颜色
            Brush LaneTextBrush = Brushes.DarkOliveGreen;                        // 文本颜色
            System.Drawing.Font font = new System.Drawing.Font("Arial Black", 9); // 绘制文本字体
            System.Drawing.Font SmallFont = new System.Drawing.Font("Arial", 6); // 绘制文本字体
            System.Drawing.Font lanefont = new System.Drawing.Font("Arial", 7); // 绘制文本字体
            System.Drawing.Font locationfont = new System.Drawing.Font("Arial", 7); // 绘制文本字体
            System.Drawing.Font locationlanefont = new System.Drawing.Font("Arial Black", 7); // 绘制文本字体

            System.Drawing.Font DeviceFont = new System.Drawing.Font("Arial Black", 8); // 绘制文本字体
            Brush DeviceTextBrush = Brushes.DarkGreen;                        // Device文本颜色
            Brush DeviceTextTrackingBrush = Brushes.OrangeRed;                        // Device文本颜色
            System.Drawing.Font DeviceTrackingFont = new System.Drawing.Font("Arial Black", 8, FontStyle.Underline);
            const int DEVICE_FONT_OFFSET = 10;

            //DrawLock(objGraph,800,800); //画一个锁


            foreach (DataRow dr_lane in DS_WAREHOUSE_LAYOUT.Tables[TABLE_LOC_LANE].Rows) //通道循环
            {
                string LaneNo = dr_lane["lane_no"].ToString().Trim(); //取得通道面
                //string AreaLocationTypeId = dr_lane["area_type_id"].ToString().Trim(); //取得区类型，是托盘(PALLET)=2 还是货架(P-CARTON)=1
                //string AreaLocationType = "";
                //string sWarehouseId = dr_lane["warehouse_id"].ToString().Trim();

                string LaneDescription = dr_lane["lane_desc"].ToString().Trim();
                //简化货架号显示，去掉"-0" / "-1"
                if (LaneDescription.IndexOf('-') != -1)
                    LaneDescription = LaneDescription.Substring(0, (LaneDescription.IndexOf('-')));

                string LaneDirection = dr_lane["lane_direction"].ToString().Trim();
                string LaneOrder = dr_lane["lane_order"].ToString().Trim();


                //if (AreaLocationType == "PALLET")
                //{
                //    font_diff_x = 0;
                //    font_diff_y = 0;
                //}
                int Lane_Start_X = MapProperty.ORIGIN_X + int.Parse(dr_lane["area_origin_xpoint"].ToString()) + int.Parse(dr_lane["x_point"].ToString());
                int Lane_Start_Y = MapProperty.ORIGIN_Y + int.Parse(dr_lane["area_origin_ypoint"].ToString()) + int.Parse(dr_lane["y_point"].ToString());
                objGraph.DrawEllipse(LocationPen, Lane_Start_X, Lane_Start_Y, 2, 2); //画个小圆标记，表示原点

                int LaneFontOffestX = 0;
                int LaneFontOffeseY = 0;
                switch (LaneDirection)
                {
                    case "E":
                        LaneFontOffestX = -2;
                        LaneFontOffeseY = -15;
                        break;
                    case "S":
                        LaneFontOffestX = -10 * (LaneDescription.Length);
                        LaneFontOffeseY = 0;
                        break;
                    case "W":
                        LaneFontOffestX = -6;
                        LaneFontOffeseY = -15;
                        break;
                    case "N":
                        LaneFontOffestX = -10 * (LaneDescription.Length);
                        LaneFontOffeseY = 0;
                        break;
                    default:
                        break;
                }
                objGraph.DrawString(LaneDescription.ToString(), locationlanefont, LaneTextBrush, (Lane_Start_X + LaneFontOffestX), (Lane_Start_Y + LaneFontOffeseY));

                int LaneDiff = 0; //重置每个通道面的货架绘图偏移增量
                foreach (DataRow dr in DS_WAREHOUSE_LAYOUT.Tables[TABLE_LOC_LOCATION].Rows) //货架循环
                {
                    if (LaneNo != (dr["lane_no"].ToString().Trim())) //不是这个通道则退出
                        continue;

                    string ShelfNo = dr["shelf_no"].ToString().ToUpper().Trim(); //货架/托盘号

                    string ShelfIndex = dr["shelf_index"].ToString().ToUpper().Trim(); //货架/托盘号
                    string ShelfNoPnt = dr["shelf_desc"].ToString().ToUpper().Trim(); // (int.Parse(ShelfIndex)).ToString("D2");
                    //简化货架号，去掉通道号
                    //仓库的货位编码10位
                    ShelfNoPnt = ShelfNoPnt.Substring((ShelfNoPnt.Length - 2), 2); //只截取最后2位


                    #region 检查货架/托盘上是否有库存并设置Brush
                    int StackPercentage = 0; //默认货架/托盘库存使用率 = 0
                    bool bHasStock = false;  //默认货架/托盘上没有东西
                    Brush CartonBrush2 = new SolidBrush(Color.White);


                    int PickingPRI = 1000;
                    if (cbViewPickingPRI.Checked) //用户要查看拣货优先级
                    {
                        string PRI = dr["shelf_pri"].ToString().Trim();
                        try
                        {
                            PickingPRI = int.Parse(PRI);
                        }
                        catch { }
                        CartonBrush2 = MapProperty.SetPickingPriColor(PickingPRI);
                    }
                    else if (cbViewABCClass.Checked)//用户要查看ABC分类
                    {
                        string ABCClass = dr["abc_class"].ToString().Trim();
                        if (ABCClass == "")
                            ABCClass = "D";
                        CartonBrush2 = MapProperty.SetAbcClassBrushColor(ABCClass);
                    }
                    else if ((cbRunStatistics.Checked) && (DS_WAREHOUSE_LAYOUT.Tables.Contains(TABLE_LOC_STATISTICS)))
                    {
                        //查找是否有分析结果
                        foreach (DataRow dr_inv in DS_WAREHOUSE_LAYOUT.Tables[TABLE_LOC_STATISTICS].Rows)
                        {
                            if (dr_inv["shelf_no"].ToString().Trim() == ShelfNo)
                            {
                                int SortIndex = int.Parse(dr_inv["sort_index"].ToString().Trim());
                                bHasStock = true;
                                CartonBrush2 = MapProperty.SetStatisticsBrushColor(SortIndex);
                                break;
                            }
                        }
                    }
                    else
                    {
                        //查找是否有库存
                        foreach (DataRow dr_inv in DS_WAREHOUSE_LAYOUT.Tables[TABLE_LOC_STACKED_LOCATION].Rows)
                        {
                            if (dr_inv["shelf_no"].ToString().Trim() == ShelfNo)
                            {
                                StackPercentage = int.Parse(dr_inv["used_percentage"].ToString().Trim());
                                bHasStock = true;
                                CartonBrush2 = MapProperty.SetPercentageBrushColor(StackPercentage);
                                break;
                            }
                        }
                    }
                    #endregion

                    string sStorageType = dr["storage_type_id"].ToString().ToUpper().Trim(); //存储类型：是货架还是托盘
                    MapProperty.StorageTypes eStorageType = (MapProperty.StorageTypes)(int.Parse(sStorageType));
                    if ((eStorageType == MapProperty.StorageTypes.Shelf4x3) || (eStorageType == MapProperty.StorageTypes.Shelf4x6)) //货架
                    {
                        int Start_X = MapProperty.ORIGIN_X + int.Parse(dr["area_origin_xpoint"].ToString()) + int.Parse(dr["x_point"].ToString());
                        int Start_Y = MapProperty.ORIGIN_Y + int.Parse(dr["area_origin_ypoint"].ToString()) + int.Parse(dr["y_point"].ToString());

                        #region 画下一个货架，增加偏移量
                        //画下一个货架，增加偏移量
                        switch (LaneDirection)
                        {
                            case "E":
                                //加上一个通道面的累计偏移量
                                Start_Y = Start_Y + LaneDiff;
                                //y轴方向
                                LaneDiff = LaneDiff + MapProperty.RACK_WIDTH + MapProperty.RACK_LANE_SPACE;
                                break;
                            case "S":
                                //加上一个通道面的累计偏移量
                                Start_X = Start_X + LaneDiff;
                                //x轴方向
                                LaneDiff = LaneDiff + MapProperty.RACK_WIDTH + MapProperty.RACK_LANE_SPACE;
                                break;
                            case "W":
                                //加上一个通道面的累计偏移量
                                Start_Y = Start_Y + LaneDiff;
                                //y轴方向
                                LaneDiff = LaneDiff + MapProperty.RACK_WIDTH + MapProperty.RACK_LANE_SPACE;
                                break;
                            case "N":
                                //加上一个通道面的累计偏移量
                                Start_X = Start_X + LaneDiff;
                                //x轴方向
                                LaneDiff = LaneDiff + MapProperty.RACK_WIDTH + MapProperty.RACK_LANE_SPACE;
                                break;
                            default:
                                break;
                        }
                        #endregion

                        #region 绘图画货架货位(空)
                        int Space_X = MapProperty.RACK_FILL_SPACE;
                        int Space_Y = MapProperty.RACK_FILL_SPACE;
                        int Rack_X = MapProperty.RACK_INSTOCK_WIDTH;
                        int Rack_Y = MapProperty.RACK_INSTOCK_HEIGHT;

                        Point[] points1 = new Point[5];
                        if ((LaneDirection == "E") || (LaneDirection == "W"))
                        {
                            points1[0] = new Point(Start_X, Start_Y);
                            points1[1] = new Point(Start_X + MapProperty.RACK_HEIGHT, Start_Y);
                            points1[2] = new Point(Start_X + MapProperty.RACK_HEIGHT, Start_Y + MapProperty.RACK_WIDTH);
                            points1[3] = new Point(Start_X, Start_Y + MapProperty.RACK_WIDTH);
                            points1[4] = points1[0];

                            Rack_X = MapProperty.RACK_INSTOCK_HEIGHT;
                            Rack_Y = MapProperty.RACK_INSTOCK_WIDTH;
                        }
                        else if ((LaneDirection == "N") || (LaneDirection == "S"))
                        {
                            points1[0] = new Point(Start_X, Start_Y);
                            points1[1] = new Point(Start_X + MapProperty.RACK_WIDTH, Start_Y);
                            points1[2] = new Point(Start_X + MapProperty.RACK_WIDTH, Start_Y + MapProperty.RACK_HEIGHT);
                            points1[3] = new Point(Start_X, Start_Y + MapProperty.RACK_HEIGHT);
                            points1[4] = points1[0];

                            Rack_X = MapProperty.RACK_INSTOCK_WIDTH;
                            Rack_Y = MapProperty.RACK_INSTOCK_HEIGHT;
                        }

                        objGraph.DrawLines(LocationPen, points1);
                        #endregion

                        #region 画货架号
                        int ShelfFontOffestX = 0;
                        int ShelfFontOffeseY = 0;
                        int ShelfLockOffsetX = 0;//锁定图标偏移
                        int ShelfLockOffsetY = 0;
                        switch (LaneDirection)
                        {
                            case "E":
                                ShelfFontOffestX = MapProperty.RACK_HEIGHT - 1;
                                ShelfFontOffeseY = 2;
                                ShelfLockOffsetX = MapProperty.RACK_HEIGHT;
                                ShelfLockOffsetY = MapProperty.RACK_WIDTH - 10;
                                break;
                            case "S":
                                ShelfFontOffestX = 2;
                                ShelfFontOffeseY = MapProperty.RACK_HEIGHT;
                                ShelfLockOffsetX = MapProperty.RACK_WIDTH - 10;
                                ShelfLockOffsetY = MapProperty.RACK_HEIGHT;
                                break;
                            case "W":
                                ShelfFontOffestX = -7 * (ShelfNoPnt.Length) + 1;
                                ShelfFontOffeseY = 2;
                                ShelfLockOffsetX = -7 * (ShelfNoPnt.Length);
                                ShelfLockOffsetY = MapProperty.RACK_WIDTH - 10;
                                break;
                            case "N":
                                ShelfFontOffestX = 2;
                                ShelfFontOffeseY = -10;
                                ShelfLockOffsetX = MapProperty.RACK_WIDTH - 10;
                                ShelfLockOffsetY = -10;
                                break;
                            default:
                                break;
                        }
                        objGraph.DrawString(ShelfNoPnt, locationfont, LaneTextBrush, (Start_X + ShelfFontOffestX), (Start_Y + ShelfFontOffeseY));

                        //不需要画锁
                        //if (int.Parse(dr["IsHold"].ToString()) == 1)
                        //    DrawLock(objGraph, (Start_X + ShelfLockOffsetX), (Start_Y + ShelfLockOffsetY)); //画一个锁

                        #endregion

                        #region 开始写入位置DataSet表
                        //------------开始写入位置DataSet表--------------
                        System.Data.DataRow addRow;
                        addRow = DSLocation.Tables[DT_WH_GRAPHICS].NewRow();

                        addRow["AreaNo"] = dr_lane["area_no"].ToString().Trim();
                        addRow["LaneNo"] = LaneNo;
                        addRow["ShelfNo"] = ShelfNo;
                        addRow["StorageType"] = (int)eStorageType;
                        addRow["LaneDirection"] = dr["lane_direction"].ToString();
                        addRow["LaneOrder"] = dr["lane_order"].ToString();
                        addRow["LocationCount"] = int.Parse(dr["shelf_loc_count"].ToString());
                        addRow["Layer"] = int.Parse(dr["layers_set"].ToString());
                        addRow["IsHold"] = 0;// int.Parse(dr["IsHold"].ToString()); 不需要锁定
                        addRow["LanePointX"] = dr["x_point"].ToString();
                        addRow["LanePointY"] = dr["y_point"].ToString();
                        addRow["XPointS"] = points1[0].X + 1;
                        addRow["YPointS"] = points1[0].Y + 1;
                        addRow["XPointE"] = points1[2].X - 1;
                        addRow["YPointE"] = points1[2].Y - 1;

                        DSLocation.Tables[DT_WH_GRAPHICS].Rows.Add(addRow);
                        DSLocation.Tables[DT_WH_GRAPHICS].AcceptChanges();

                        //-----------------------------------------------
                        #endregion

                        #region 用户选中了一个对象画出框线
                        //如果用户选中了一个对象，则画出框线
                        if (SEL_SHELF == ShelfNo)
                        {
                            Rectangle rSel = new Rectangle(points1[0].X + 1, points1[0].Y + 1, (points1[2].X - points1[0].X - 2), (points1[2].Y - points1[0].Y - 2));
                            objGraph.DrawRectangle(LocationPen, rSel);
                        }
                        //-----------------------------------------------
                        #endregion

                        #region 若有库存，则涂色表示
                        if ((bHasStock) ||
                            (cbViewPickingPRI.Checked) //用户要查看拣货优先级
                             || (cbViewABCClass.Checked)//用户要查看ABC分类
                            )
                        {
                            objGraph.FillRectangle(
                                CartonBrush2,
                                Start_X + Space_X,
                                Start_Y + Space_Y,
                                Rack_X,
                                Rack_Y);

                            //objGraph.DrawRectangle(pen, Start_X + Space_X + LOCATION_SPACE, Start_Y + Space_Y, Rack_X, Rack_Y); //货架不必画外框
                        }

                        #endregion


                    }
                    //else if ((StorageType == "PALLET") || (StorageType != "P4U"))//托盘
                    else if ((eStorageType == MapProperty.StorageTypes.Pallet))//托盘
                    {
                        int Start_X = MapProperty.ORIGIN_X + int.Parse(dr["area_origin_xpoint"].ToString()) + int.Parse(dr["x_point"].ToString());
                        int Start_Y = MapProperty.ORIGIN_Y + int.Parse(dr["area_origin_ypoint"].ToString()) + int.Parse(dr["y_point"].ToString());

                        #region 画下一个托盘，增加偏移量
                        //画下一个货架，增加偏移量
                        switch (LaneDirection)
                        {
                            case "E":
                                //加上一个通道面的累计偏移量
                                Start_Y = Start_Y + LaneDiff;
                                //y轴方向
                                LaneDiff = LaneDiff + MapProperty.PALLET_WIDTH + MapProperty.PALLET_LANE_SPACE;
                                break;
                            case "S":
                                //加上一个通道面的累计偏移量
                                Start_X = Start_X + LaneDiff;
                                //x轴方向
                                LaneDiff = LaneDiff + MapProperty.PALLET_WIDTH + MapProperty.PALLET_LANE_SPACE;
                                break;
                            case "W":
                                //加上一个通道面的累计偏移量
                                Start_Y = Start_Y + LaneDiff;
                                //y轴方向
                                LaneDiff = LaneDiff + MapProperty.PALLET_WIDTH + MapProperty.PALLET_LANE_SPACE;
                                break;
                            case "N":
                                //加上一个通道面的累计偏移量
                                Start_X = Start_X + LaneDiff;
                                //x轴方向
                                LaneDiff = LaneDiff + MapProperty.PALLET_WIDTH + MapProperty.PALLET_LANE_SPACE;
                                break;
                            default:
                                break;
                        }
                        #endregion

                        #region 开始绘图-托盘位
                        int Space_X = MapProperty.PALLET_FILL_SPACE;
                        int Space_Y = MapProperty.PALLET_FILL_SPACE;
                        int Pallet_X = MapProperty.PALLET_INSTOCK_WIDTH;
                        int Pallet_Y = MapProperty.PALLET_INSTOCK_HEIGHT;

                        Point[] points1 = new Point[3];
                        points1[0] = new Point(Start_X + MapProperty.TIER_BOX_HEIGHT, Start_Y + MapProperty.MARK_LINE_LENGTH);
                        points1[1] = new Point(Start_X + MapProperty.TIER_BOX_HEIGHT, Start_Y);
                        points1[2] = new Point(Start_X + MapProperty.TIER_BOX_HEIGHT + MapProperty.MARK_LINE_LENGTH, Start_Y);

                        Point[] points2 = new Point[3];
                        points2[0] = new Point(Start_X + MapProperty.PALLET_WIDTH - MapProperty.MARK_LINE_LENGTH, Start_Y);
                        points2[1] = new Point(Start_X + MapProperty.PALLET_WIDTH, Start_Y);
                        points2[2] = new Point(Start_X + MapProperty.PALLET_WIDTH, Start_Y + MapProperty.MARK_LINE_LENGTH);

                        Point[] points3 = new Point[3];
                        points3[0] = new Point(Start_X + MapProperty.TIER_BOX_HEIGHT, Start_Y + MapProperty.PALLET_HEIGHT - MapProperty.MARK_LINE_LENGTH);
                        points3[1] = new Point(Start_X + MapProperty.TIER_BOX_HEIGHT, Start_Y + MapProperty.PALLET_HEIGHT);
                        points3[2] = new Point(Start_X + MapProperty.MARK_LINE_LENGTH + MapProperty.TIER_BOX_HEIGHT, Start_Y + MapProperty.PALLET_HEIGHT);

                        Point[] points4 = new Point[3];
                        points4[0] = new Point(Start_X + MapProperty.PALLET_WIDTH - MapProperty.MARK_LINE_LENGTH, Start_Y + MapProperty.PALLET_HEIGHT);
                        points4[1] = new Point(Start_X + MapProperty.PALLET_WIDTH, Start_Y + MapProperty.PALLET_HEIGHT);
                        points4[2] = new Point(Start_X + MapProperty.PALLET_WIDTH, Start_Y + MapProperty.PALLET_HEIGHT - MapProperty.MARK_LINE_LENGTH);

                        objGraph.DrawLines(LocationPen, points1);
                        objGraph.DrawLines(LocationPen, points2);
                        objGraph.DrawLines(LocationPen, points3);
                        objGraph.DrawLines(LocationPen, points4);
                        #endregion

                        #region 画托盘号
                        int ShelfFontOffestX = 0;
                        int ShelfFontOffeseY = 0;
                        int ShelfLockOffsetX = 0;
                        int ShelfLockOffsetY = 0;
                        switch (LaneDirection)
                        {
                            case "E":
                                ShelfFontOffestX = MapProperty.PALLET_WIDTH;
                                ShelfFontOffeseY = 1;
                                ShelfLockOffsetX = MapProperty.PALLET_WIDTH;
                                ShelfLockOffsetY = MapProperty.PALLET_HEIGHT - 8;
                                break;
                            case "S":
                                ShelfFontOffestX = 1;
                                ShelfFontOffeseY = MapProperty.PALLET_HEIGHT;
                                ShelfLockOffsetX = MapProperty.PALLET_WIDTH - 6;
                                ShelfLockOffsetY = MapProperty.PALLET_HEIGHT;
                                break;
                            case "W":
                                ShelfFontOffestX = -7 * (ShelfNoPnt.Length);
                                ShelfFontOffeseY = 1;
                                ShelfLockOffsetX = -7 * (ShelfNoPnt.Length);
                                ShelfLockOffsetY = MapProperty.PALLET_HEIGHT - 8;
                                break;
                            case "N":
                                ShelfFontOffestX = 1;
                                ShelfFontOffeseY = -12;
                                ShelfLockOffsetX = MapProperty.PALLET_WIDTH - 6;
                                ShelfLockOffsetY = -12;
                                break;
                            default:
                                break;
                        }
                        objGraph.DrawString(ShelfNoPnt, locationfont, LaneTextBrush, (Start_X + ShelfFontOffestX), (Start_Y + ShelfFontOffeseY));

                        //if (int.Parse(dr["IsHold"].ToString()) == 1)
                        //    DrawLock(objGraph, (Start_X + ShelfLockOffsetX), (Start_Y + ShelfLockOffsetY)); //画一个锁

                        #endregion

                        #region 开始写入位置DataSet表
                        //------------开始写入位置DataSet表--------------
                        System.Data.DataRow addRow;
                        addRow = DSLocation.Tables[DT_WH_GRAPHICS].NewRow();

                        addRow["AreaNo"] = dr_lane["area_no"].ToString().Trim();
                        addRow["LaneNo"] = LaneNo;
                        addRow["ShelfNo"] = ShelfNo;
                        addRow["StorageType"] = (int)eStorageType;
                        addRow["LaneDirection"] = dr["lane_direction"].ToString();
                        addRow["LaneOrder"] = dr["lane_order"].ToString();
                        addRow["LocationCount"] = int.Parse(dr["shelf_loc_count"].ToString());
                        addRow["Layer"] = int.Parse(dr["layers_set"].ToString());
                        addRow["IsHold"] = 0;// int.Parse(dr["IsHold"].ToString());
                        addRow["LanePointX"] = dr["x_point"].ToString();
                        addRow["LanePointY"] = dr["y_point"].ToString();
                        addRow["XPointS"] = points1[1].X;
                        addRow["YPointS"] = points1[1].Y;
                        addRow["XPointE"] = points4[1].X;
                        addRow["YPointE"] = points4[1].Y;

                        DSLocation.Tables[DT_WH_GRAPHICS].Rows.Add(addRow);
                        DSLocation.Tables[DT_WH_GRAPHICS].AcceptChanges();

                        //-----------------------------------------------
                        #endregion

                        #region 如果用户选中了一个对象，则画出框线
                        //如果用户选中了一个对象，则画出框线
                        if (SEL_SHELF == ShelfNo)
                        {
                            Rectangle rSel = new Rectangle(points1[1].X + 1, points1[1].Y + 1, (points4[1].X - points1[1].X - 2), (points4[1].Y - points1[1].Y - 2));
                            objGraph.DrawRectangle(LocationPen, rSel);
                        }
                        //-----------------------------------------------
                        #endregion

                        #region 若有库存，则涂色表示
                        //判断是否有库存，有则填充颜色
                        if ((bHasStock) ||
                            (cbViewPickingPRI.Checked) //用户要查看拣货优先级
                             || (cbViewABCClass.Checked)//用户要查看ABC分类
                            )
                        {
                            objGraph.FillRectangle(
                                CartonBrush2,
                                Start_X + Space_X + MapProperty.PALLET_FILL_SPACE,
                                Start_Y + Space_Y + MapProperty.PALLET_FILL_SPACE,
                                Pallet_X,
                                Pallet_Y);
                            objGraph.DrawRectangle(
                                pen,
                                Start_X + Space_X + MapProperty.PALLET_FILL_SPACE,
                                Start_Y + Space_Y + MapProperty.PALLET_FILL_SPACE,
                                Pallet_X,
                                Pallet_Y);
                        }
                        #endregion



                    }
                    #region 不画流利式货架
                    /*
                     * 不画流利式货架
                    else if (StorageType == "CARTONFLOW")
                    {
                        int Start_X = MapProperty.ORIGIN_X + int.Parse(dr["AreaOriginXpoint"].ToString()) + int.Parse(dr["Xpoint"].ToString());
                        int Start_Y = MapProperty.ORIGIN_Y + int.Parse(dr["AreaOriginYpoint"].ToString()) + int.Parse(dr["Ypoint"].ToString());

                        #region 画下一个流利式货架，增加偏移量
                        //画下一个货架，增加偏移量
                        switch (LaneDirection)
                        {
                            case "E":
                                //加上一个通道面的累计偏移量
                                Start_Y = Start_Y + LaneDiff;
                                //y轴方向
                                LaneDiff = LaneDiff + MapProperty.CARTONFLOW_WIDTH + MapProperty.CARTONFLOW_LANE_SPACE;
                                break;
                            case "S":
                                //加上一个通道面的累计偏移量
                                Start_X = Start_X + LaneDiff;
                                //x轴方向
                                LaneDiff = LaneDiff + MapProperty.CARTONFLOW_WIDTH + MapProperty.CARTONFLOW_LANE_SPACE;
                                break;
                            case "W":
                                //加上一个通道面的累计偏移量
                                Start_Y = Start_Y + LaneDiff;
                                //y轴方向
                                LaneDiff = LaneDiff + MapProperty.CARTONFLOW_WIDTH + MapProperty.CARTONFLOW_LANE_SPACE;
                                break;
                            case "N":
                                //加上一个通道面的累计偏移量
                                Start_X = Start_X + LaneDiff;
                                //x轴方向
                                LaneDiff = LaneDiff + MapProperty.CARTONFLOW_WIDTH + MapProperty.CARTONFLOW_LANE_SPACE;
                                break;
                            default:
                                break;
                        }
                        #endregion

                        #region 开始绘图-流利式货架
                        int Space_X = MapProperty.CARTONFLOW_FILL_SPACE;
                        int Space_Y = MapProperty.CARTONFLOW_FILL_SPACE;
                        int Pallet_X = MapProperty.CARTONFLOW_INSTOCK_WIDTH;
                        int Pallet_Y = MapProperty.CARTONFLOW_INSTOCK_HEIGHT;

                        Point[] points1 = new Point[3];
                        points1[0] = new Point(Start_X + MapProperty.TIER_BOX_HEIGHT, Start_Y + MapProperty.MARK_LINE_LENGTH);
                        points1[1] = new Point(Start_X + MapProperty.TIER_BOX_HEIGHT, Start_Y);
                        points1[2] = new Point(Start_X + MapProperty.TIER_BOX_HEIGHT + MapProperty.MARK_LINE_LENGTH, Start_Y);

                        Point[] points2 = new Point[3];
                        points2[0] = new Point(Start_X + MapProperty.CARTONFLOW_WIDTH - MapProperty.MARK_LINE_LENGTH, Start_Y);
                        points2[1] = new Point(Start_X + MapProperty.CARTONFLOW_WIDTH, Start_Y);
                        points2[2] = new Point(Start_X + MapProperty.CARTONFLOW_WIDTH, Start_Y + MapProperty.MARK_LINE_LENGTH);

                        Point[] points3 = new Point[3];
                        points3[0] = new Point(Start_X + MapProperty.TIER_BOX_HEIGHT, Start_Y + MapProperty.CARTONFLOW_HEIGHT - MapProperty.MARK_LINE_LENGTH);
                        points3[1] = new Point(Start_X + MapProperty.TIER_BOX_HEIGHT, Start_Y + MapProperty.CARTONFLOW_HEIGHT);
                        points3[2] = new Point(Start_X + MapProperty.MARK_LINE_LENGTH + MapProperty.TIER_BOX_HEIGHT, Start_Y + MapProperty.CARTONFLOW_HEIGHT);

                        Point[] points4 = new Point[3];
                        points4[0] = new Point(Start_X + MapProperty.CARTONFLOW_WIDTH - MapProperty.MARK_LINE_LENGTH, Start_Y + MapProperty.CARTONFLOW_HEIGHT);
                        points4[1] = new Point(Start_X + MapProperty.CARTONFLOW_WIDTH, Start_Y + MapProperty.CARTONFLOW_HEIGHT);
                        points4[2] = new Point(Start_X + MapProperty.CARTONFLOW_WIDTH, Start_Y + MapProperty.CARTONFLOW_HEIGHT - MapProperty.MARK_LINE_LENGTH);

                        objGraph.DrawLines(LocationPen, points1);
                        objGraph.DrawLines(LocationPen, points2);
                        objGraph.DrawLines(LocationPen, points3);
                        objGraph.DrawLines(LocationPen, points4);
                        #endregion

                        #region 画流利式货架号
                        int ShelfFontOffestX = 0;
                        int ShelfFontOffeseY = 0;
                        int ShelfLockOffsetX = 0;
                        int ShelfLockOffsetY = 0;
                        switch (LaneDirection)
                        {
                            case "E":
                                ShelfFontOffestX = MapProperty.CARTONFLOW_WIDTH;
                                ShelfFontOffeseY = 1;
                                ShelfLockOffsetX = MapProperty.CARTONFLOW_WIDTH;
                                ShelfLockOffsetY = MapProperty.CARTONFLOW_HEIGHT - 8;
                                break;
                            case "S":
                                ShelfFontOffestX = 1;
                                ShelfFontOffeseY = MapProperty.CARTONFLOW_HEIGHT;
                                ShelfLockOffsetX = MapProperty.CARTONFLOW_WIDTH - 6;
                                ShelfLockOffsetY = MapProperty.CARTONFLOW_HEIGHT;
                                break;
                            case "W":
                                ShelfFontOffestX = -7 * (ShelfNoPnt.Length);
                                ShelfFontOffeseY = 1;
                                ShelfLockOffsetX = -7 * (ShelfNoPnt.Length);
                                ShelfLockOffsetY = MapProperty.CARTONFLOW_HEIGHT - 8;
                                break;
                            case "N":
                                ShelfFontOffestX = 1;
                                ShelfFontOffeseY = -12;
                                ShelfLockOffsetX = MapProperty.CARTONFLOW_WIDTH - 6;
                                ShelfLockOffsetY = -12;
                                break;
                            default:
                                break;
                        }
                        objGraph.DrawString(ShelfNoPnt, locationfont, LaneTextBrush, (Start_X + ShelfFontOffestX), (Start_Y + ShelfFontOffeseY));

                        if (int.Parse(dr["IsHold"].ToString()) == 1)
                            DrawLock(objGraph, (Start_X + ShelfLockOffsetX), (Start_Y + ShelfLockOffsetY)); //画一个锁

                        #endregion

                        #region 开始写入位置DataSet表
                        //------------开始写入位置DataSet表--------------
                        System.Data.DataRow addRow;
                        addRow = DSLocation.Tables[DT_WH_GRAPHICS].NewRow();

                        addRow["WarehouseNo"] = dr_lane["WarehouseNo"].ToString().Trim();
                        addRow["AreaNo"] = dr_lane["AreaNo"].ToString().Trim();
                        addRow["LaneNo"] = LaneNo;
                        addRow["ShelfNo"] = ShelfNo;
                        addRow["StorageType"] = dr["StorageType"].ToString();
                        addRow["LaneDirection"] = dr["LaneDirection"].ToString();
                        addRow["LaneOrder"] = dr["LaneOrder"].ToString();
                        addRow["LocationCount"] = int.Parse(dr["LocationCount"].ToString());
                        addRow["Layer"] = int.Parse(dr["Layer"].ToString());
                        addRow["IsHold"] = int.Parse(dr["IsHold"].ToString());
                        addRow["LanePointX"] = dr["Xpoint"].ToString();
                        addRow["LanePointY"] = dr["Ypoint"].ToString();
                        addRow["XPointS"] = points1[1].X;
                        addRow["YPointS"] = points1[1].Y;
                        addRow["XPointE"] = points4[1].X;
                        addRow["YPointE"] = points4[1].Y;

                        DSLocation.Tables[DT_WH_GRAPHICS].Rows.Add(addRow);
                        DSLocation.Tables[DT_WH_GRAPHICS].AcceptChanges();

                        //-----------------------------------------------
                        #endregion

                        #region 如果用户选中了一个对象，则画出框线
                        //如果用户选中了一个对象，则画出框线
                        if (SEL_SHELF == ShelfNo)
                        {
                            Rectangle rSel = new Rectangle(points1[1].X + 1, points1[1].Y + 1, (points4[1].X - points1[1].X - 2), (points4[1].Y - points1[1].Y - 2));
                            objGraph.DrawRectangle(LocationPen, rSel);
                        }
                        //-----------------------------------------------
                        #endregion

                        #region 若有库存，则涂色表示
                        //判断是否有库存，有则填充颜色
                        if ((bHasStock) ||
                            (cbViewPickingPRI.Checked) //用户要查看拣货优先级
                             || (cbViewABCClass.Checked)//用户要查看ABC分类
                            )
                        {
                            objGraph.FillRectangle(
                                CartonBrush2,
                                Start_X + Space_X + MapProperty.CARTONFLOW_FILL_SPACE,
                                Start_Y + Space_Y + MapProperty.CARTONFLOW_FILL_SPACE,
                                Pallet_X,
                                Pallet_Y);
                            objGraph.DrawRectangle(
                                pen,
                                Start_X + Space_X + MapProperty.CARTONFLOW_FILL_SPACE,
                                Start_Y + Space_Y + MapProperty.CARTONFLOW_FILL_SPACE,
                                Pallet_X,
                                Pallet_Y);
                        }
                        #endregion


                    }
                    */
                    #endregion

                }//end of 货架循环 foreach (DataRow dr in DS_WAREHOUSE_LAYOUT.Tables[TABLE_LOC_LOCATION].Rows)

            }//end of 通道循环 foreach (DataRow dr_lane in DS_WAREHOUSE_LAYOUT.Tables[TABLE_LOC_LANE].Rows)

            dvlocation = DSLocation.Tables[DT_WH_GRAPHICS].DefaultView;
        }

        private void pnlMain_MouseDown(object sender, MouseEventArgs e)
        {
            //获得控件位置
            iParaX = e.X;
            iParaY = e.Y;

            if (e.Button == MouseButtons.Right)
            {
                ctxmsMapRight.Show(MousePosition.X, MousePosition.Y);
            }
            else
            {
                int iWinPositionX = this.Location.X;
                int iWinPositionY = this.Location.Y;

                lbXVal.Text = e.X.ToString(); // (MousePosition.X- iWinPositionX).ToString();
                lbYVal.Text = e.Y.ToString(); // (MousePosition.Y- iWinPositionY).ToString(); 

                //grid坐标编号
                int iGridLocationX = e.X / DEFAULT_GRID_SIZE;
                int iGridLocationY = e.Y / DEFAULT_GRID_SIZE;
                lbGridXVal.Text = iGridLocationX.ToString();
                lbGridYVal.Text = iGridLocationY.ToString();
            }
        }

        private void tsmiAddLane_Click(object sender, EventArgs e)
        {
            string sAreaNo = cbAreaNo.SelectedValue.ToString();
            FormLaneMgt formLaneMgt = new FormLaneMgt(sAreaNo,iParaX, iParaY);
            //FormLaneMgt formLaneMgt = new FormLaneMgt();
            DialogResult dlgResult = formLaneMgt.ShowDialog(this);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshMap(); //刷新地图            
        }

        private void RefreshMap()
        {
            int iAreaGroupNo = -1;
            try
            {
                iAreaGroupNo = int.Parse(cbAreaGroupNo.SelectedValue.ToString());
            }
            catch { }

            int iCustomerId = -1;
            string sLocationNo = "";
            string sItemNo = "";
            bool bIsRunStatistics = false;
            int iStatisticsTypeNo = -1;
            DateTime dStatStartDate = DateTime.Now;
            DateTime dStatEndDate = DateTime.Now;


            RefreshDrawMap(iCustomerId, iAreaGroupNo, sLocationNo, sItemNo, bIsRunStatistics, iStatisticsTypeNo, dStatStartDate, dStatEndDate);
        }

        private void RefreshDrawMap(int iCustomerId, int iAreaGroupNo, string sLocationNo, string sItemNo, bool bIsRunStatistics, int iStatisticsTypeNo, DateTime dStatStartDate, DateTime dStatEndDate)
        {
            if (_bLoadDbData)
            {
                DataSet ds = DaLocationMgt.GetLocationLayoutDs(iCustomerId, iAreaGroupNo, sLocationNo, sItemNo, bIsRunStatistics, iStatisticsTypeNo, dStatStartDate, dStatEndDate);
                if (ds == null)
                    return;

                DS_WAREHOUSE_LAYOUT = ds;
            }

            pnlMain.Refresh();
        }


        private void cbShowGrid_CheckedChanged(object sender, EventArgs e)
        {
            bShowGrid = cbShowGrid.Checked;
        }

        private void tsmiSetRoadDisable_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("x:" + iParaX.ToString() + " , y:" + iParaY.ToString());
            //grid坐标编号
            int iGridLocationX = iParaX / DEFAULT_GRID_SIZE;
            int iGridLocationY = iParaY / DEFAULT_GRID_SIZE;
            //lbGridXVal.Text = iGridLocationX.ToString();
            //lbGridYVal.Text = iGridLocationY.ToString();

            EntityLocationCell cTemp = new EntityLocationCell();
            cTemp.X = iGridLocationX;
            cTemp.Y = iGridLocationY;
            lstDisabledCells.Add(cTemp);

            //MessageBox.Show("(gx:" + iGridLocationX + " , gy:" + iGridLocationY + ")"+ " 已经添加到不可行走区域.");

            RefreshMap(); //刷新地图
        }

        private void tsmiSetStartPosition_Click(object sender, EventArgs e)
        {
            int iGridLocationX = iParaX / DEFAULT_GRID_SIZE;
            int iGridLocationY = iParaY / DEFAULT_GRID_SIZE;

            cStart.X = iGridLocationX;
            cStart.Y = iGridLocationY;

            RefreshMap(); //刷新地图
        }

        private void tsmiSetEndPosition_Click(object sender, EventArgs e)
        {
            int iGridLocationX = iParaX / DEFAULT_GRID_SIZE;
            int iGridLocationY = iParaY / DEFAULT_GRID_SIZE;

            cEnd.X = iGridLocationX;
            cEnd.Y = iGridLocationY;

            RefreshMap(); //刷新地图
        }

        private void tsmiStartWayfinding_Click(object sender, EventArgs e)
        {
            if ((cStart.X != cEnd.X) || (cStart.Y != cEnd.Y))
            {
                //开始计时
                Stopwatch sw = new Stopwatch();
                sw.Start(); //开始

                lstPathFind = WayfindingAStar.FindPath(cStart, cEnd, lstDisabledCells,true);

                //停止计时
                sw.Stop();
                TimeSpan ts = sw.Elapsed;

                lbElapsedTime.Text = ts.TotalMilliseconds.ToString();
                if (null != lstPathFind)
                    RefreshMap(); //刷新地图
            }
        }

        private void tsmiSendCommand_Click(object sender, EventArgs e)
        {
            if (SendRbtCommand())
            {
                MessageBox.Show("发送成功");
            }
            else
            {
                MessageBox.Show("任务发送失败");
            }
        }

        private bool SendRbtCommand()
        {
            bool bSendRbtCommand = false;

            if ((cEnd.X == 0) && (cEnd.Y == 0))
            {
                //目标在0，0点，没有设置正确，无法发送
                return false;
            }

            

            ResponseModel.ResponseResult<ResponseModel.EntityReturnError> respAckObj = new ResponseModel.ResponseResult<ResponseModel.EntityReturnError>();
            //获取Mac地址
            string sMacAddr = lbSelectedUnitMacAddress.Text;
            EntitiesRbt.EntityRbtUnit paraRbtUnits = new EntitiesRbt.EntityRbtUnit(sMacAddr);
            paraRbtUnits.CommandGuid = Guid.NewGuid().ToString();
            paraRbtUnits.LocX = cEnd.X;
            paraRbtUnits.LocY = cEnd.Y;
            paraRbtUnits.MovingFlag = true;
            ResponseModel.EntityReturnError erDefault = new ResponseModel.EntityReturnError();
            //设置返回的默认值
            respAckObj.ResultContent = erDefault;
            respAckObj.Message = erDefault.ErrorMessage;
            respAckObj.ReturnCode = erDefault.ErrorCode;

            //开始组装参数
            RequestModel.MsgObj paraHeartbeat = new RequestModel.MsgObj();
            paraHeartbeat.MsgType = "set_destination";
            paraHeartbeat.TypeId = (int)(Common.CommonDefine.RequestTypes.SetDestination);
            paraHeartbeat.MsgContent = paraRbtUnits;
            paraHeartbeat.MacAddr = sMacAddr;
            string sParaSetDestination = Newtonsoft.Json.JsonConvert.SerializeObject(paraHeartbeat);

            //
            string sResponse = "";
            using (var client = new System.Net.Http.HttpClient())
            {
                HttpComm.HttpClientUtil httpClientUtil = new HttpComm.HttpClientUtil(client);

                sResponse = httpClientUtil.GetHttpReturn(sParaSetDestination);
                if (sResponse.Trim() == "")
                {
                    //return respAckObj;
                    //返回值为空
                    return false;
                }
                if (sResponse.IndexOf("error:") == 0)
                {
                    respAckObj.Message = sResponse;
                    //return respAckObj;
                    //返回带error的东西
                    return false;
                }
            }

            try
            {
                respAckObj = Newtonsoft.Json.JsonConvert.DeserializeObject<ResponseModel.ResponseResult<ResponseModel.EntityReturnError>>(sResponse);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            if (respAckObj.ReturnCode == 0) //错误码 返回0 表示成功
                bSendRbtCommand = true;
            else
                bSendRbtCommand = false;
            //return respAckObj;

            return bSendRbtCommand;
        }
    }
}
