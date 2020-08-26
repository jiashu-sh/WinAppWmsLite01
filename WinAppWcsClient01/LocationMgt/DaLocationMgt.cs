using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinAppWmsLite.Entities;

namespace WinAppWmsLite.LocationMgt
{
    class DaLocationMgt
    {
        public const string TABLE_LOC_LANE = "LOC_LANE";
        public const string TABLE_LOC_LOCATION = "LOC_LOCATION";
        public const string TABLE_LOC_STACKED_LOCATION = "LOC_STACKED_LOCATION";
        public const string TABLE_LOC_AREA = "LOC_AREA";
        //public const string TABLE_LOC_HOLD = "TABLE_LOC_HOLD";
        //public const string TABLE_LOC_RF = "LOC_RF";
        public const string TABLE_LOC_STATISTICS = "LOC_STATISTICS";

        internal static List<int> InsertLocations(List<EntityLocLane> listLocLanes, List<EntityLocShelf> listLocShelfs, List<EntityLocation> listLocations)
        {
            if (Common.CommonDa.GetDbType() == Common.EnumDbTypes.Sqlite)
                return InsertLocationsSqlite(listLocLanes, listLocShelfs, listLocations); 
            else
                return InsertLocationsPg(listLocLanes, listLocShelfs, listLocations);         
        }

        private static List<int> InsertLocationsSqlite(List<EntityLocLane> listLocLanes, List<EntityLocShelf> listLocShelfs, List<EntityLocation> listLocations)
        {
            List<int> ListInsertLocationsResult = new List<int>();
            int iInsertLocationsResult = 0;
            int iInsertLocShelfsResult = 0;
            int iInsertLocLanesResult = 0;

            if ((listLocations == null) || (listLocations.Count == 0))
            {
                return null;
            }
            //if (ListLocShelfs != null)
            //    ListLocShelfs.Clear();
            //if (ListLocLanes != null)
            //    ListLocLanes.Clear();
            string sqlPg = "";
            string ConnectionString = Common.CommonDa.GetDbConnection();
            if (ConnectionString == "")
                return null;
            SQLiteTransaction transaction = null;

            using (SQLiteConnection conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                transaction = conn.BeginTransaction();
                try
                {
                    SQLiteCommand cmd = new SQLiteCommand("", conn, transaction);

                    //开始插入通道数据
                    if ((listLocLanes != null) && (listLocLanes.Count > 0))
                    {
                        foreach (Entities.EntityLocLane lane in listLocLanes)
                        {
                            sqlPg = "insert into loc_lane (lane_no,lane_desc,area_no,lane_pri,layers_set,x_point,y_point,lane_direction,lane_order,update_uid,update_time) values "
                                + "(@lane_no,@lane_desc,@area_no,@lane_pri,@layers_set,@x_point,@y_point,@lane_direction,@lane_order,@update_uid,datetime('now'))";
                            cmd.CommandText = sqlPg;
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@lane_no", lane.LaneNo);
                            cmd.Parameters.AddWithValue("@lane_desc", lane.LaneDesc);
                            cmd.Parameters.AddWithValue("@area_no", lane.AreaNo);
                            cmd.Parameters.AddWithValue("@lane_pri", lane.LanePri);
                            cmd.Parameters.AddWithValue("@layers_set", lane.LayersSet);
                            cmd.Parameters.AddWithValue("@x_point", lane.XPoint);
                            cmd.Parameters.AddWithValue("@y_point", lane.YPoint);
                            cmd.Parameters.AddWithValue("@lane_direction", lane.LaneDirection);
                            cmd.Parameters.AddWithValue("@lane_order", lane.LaneOrder);
                            cmd.Parameters.AddWithValue("@update_uid", lane.UserId);
                            iInsertLocLanesResult = cmd.ExecuteNonQuery();
                        }
                    }
                    //开始插入货架数据
                    if ((listLocShelfs != null) && (listLocShelfs.Count > 0))
                    {
                        foreach (Entities.EntityLocShelf shelf in listLocShelfs)
                        {
                            sqlPg = "insert into loc_shelf (shelf_no,lane_no,shelf_index,shelf_desc,layers_set,locs_set,storage_type_id,shelf_pri,abc_class,update_uid,update_time) values "
                                + "(@shelf_no,@lane_no,@shelf_index,@shelf_desc,@layers_set,@locs_set,@storage_type_id,@shelf_pri,@abc_class,@update_uid,datetime('now'))";
                            cmd.CommandText = sqlPg;
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@shelf_no", shelf.ShelfNo);
                            cmd.Parameters.AddWithValue("@lane_no", shelf.LaneNo);
                            cmd.Parameters.AddWithValue("@shelf_index", shelf.ShelfIndex);
                            cmd.Parameters.AddWithValue("@shelf_desc", shelf.ShelfDesc);
                            cmd.Parameters.AddWithValue("@layers_set", shelf.LayersSet);
                            cmd.Parameters.AddWithValue("@locs_set", shelf.LocsSet);
                            cmd.Parameters.AddWithValue("@storage_type_id", shelf.StorageTypeId);
                            cmd.Parameters.AddWithValue("@shelf_pri", shelf.ShelfPri);
                            cmd.Parameters.AddWithValue("@abc_class", shelf.AbcClass);
                            cmd.Parameters.AddWithValue("@update_uid", shelf.UserId);
                            iInsertLocShelfsResult = cmd.ExecuteNonQuery();
                        }
                    }
                    //开始插入货位数据
                    if ((listLocations != null) && (listLocations.Count > 0))
                    {
                        foreach (Entities.EntityLocation loc in listLocations)
                        {
                            sqlPg = "insert into loc_location (location_no,shelf_no,abc_class,location_desc,remark_desc,update_uid,update_time) values "
                                + "(@location_no,@shelf_no,@abc_class,@location_desc,@remark_desc,@update_uid,datetime('now'))";
                            cmd.CommandText = sqlPg;
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@location_no", loc.LocationNo);
                            cmd.Parameters.AddWithValue("@shelf_no", loc.ShelfNo);
                            cmd.Parameters.AddWithValue("@abc_class", loc.AbcClass);
                            cmd.Parameters.AddWithValue("@location_desc", loc.LocationDesc);
                            cmd.Parameters.AddWithValue("@remark_desc", loc.RemarkDesc);
                            cmd.Parameters.AddWithValue("@update_uid", loc.UserId);
                            iInsertLocationsResult = cmd.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();
                }
                catch (NpgsqlException ex)
                {
                    transaction.Rollback();
                    throw new Exception(ex.Message);
                    //Console.WriteLine(ex.ToString());
                    //return null;
                }
                finally
                {
                    conn.Close();
                }

            }

            ListInsertLocationsResult.Add(iInsertLocLanesResult);
            ListInsertLocationsResult.Add(iInsertLocShelfsResult);
            ListInsertLocationsResult.Add(iInsertLocationsResult);

            return ListInsertLocationsResult;
        }

        private static List<int> InsertLocationsPg(List<EntityLocLane> listLocLanes, List<EntityLocShelf> listLocShelfs, List<EntityLocation> listLocations)
        {
            List<int> ListInsertLocationsResult = new List<int>();
            int iInsertLocationsResult = 0;
            int iInsertLocShelfsResult = 0;
            int iInsertLocLanesResult = 0;

            if ((listLocations == null) || (listLocations.Count == 0))
            {
                return null;
            }
            //if (ListLocShelfs != null)
            //    ListLocShelfs.Clear();
            //if (ListLocLanes != null)
            //    ListLocLanes.Clear();
            string sqlPg = "";
            string ConnectionString = Common.CommonDa.GetDbConnection();
            if (ConnectionString == "")
                return null;
            using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionString))
            {
                using (NpgsqlCommand command = new NpgsqlCommand(sqlPg, connection))
                {
                    try
                    {
                        connection.Open();

                        //开始插入通道数据
                        if ((listLocLanes != null) && (listLocLanes.Count > 0))
                        {
                            foreach (Entities.EntityLocLane lane in listLocLanes)
                            {
                                sqlPg = "insert into loc_lane (lane_no,lane_desc,area_no,lane_pri,layers_set,x_point,y_point,lane_direction,lane_order,update_uid,update_time) values "
                                    + "(@lane_no,@lane_desc,@area_no,@lane_pri,@layers_set,@x_point,@y_point,@lane_direction,@lane_order,@update_uid,now())";
                                command.CommandText = sqlPg;
                                command.Parameters.Clear();
                                command.Parameters.AddWithValue("@lane_no", lane.LaneNo);
                                command.Parameters.AddWithValue("@lane_desc", lane.LaneDesc);
                                command.Parameters.AddWithValue("@area_no", lane.AreaNo);
                                command.Parameters.AddWithValue("@lane_pri", lane.LanePri);
                                command.Parameters.AddWithValue("@layers_set", lane.LayersSet);
                                command.Parameters.AddWithValue("@x_point", lane.XPoint);
                                command.Parameters.AddWithValue("@y_point", lane.YPoint);
                                command.Parameters.AddWithValue("@lane_direction", lane.LaneDirection);
                                command.Parameters.AddWithValue("@lane_order", lane.LaneOrder);
                                command.Parameters.AddWithValue("@update_uid", lane.UserId);
                                iInsertLocLanesResult = command.ExecuteNonQuery();
                            }
                        }
                        //开始插入货架数据
                        if ((listLocShelfs != null) && (listLocShelfs.Count > 0))
                        {
                            foreach (Entities.EntityLocShelf shelf in listLocShelfs)
                            {
                                sqlPg = "insert into loc_shelf (shelf_no,lane_no,shelf_index,shelf_desc,layers_set,locs_set,storage_type_id,shelf_pri,abc_class,update_uid,update_time) values "
                                    + "(@shelf_no,@lane_no,@shelf_index,@shelf_desc,@layers_set,@locs_set,@storage_type_id,@shelf_pri,@abc_class,@update_uid,now())";
                                command.CommandText = sqlPg;
                                command.Parameters.Clear();
                                command.Parameters.AddWithValue("@shelf_no", shelf.ShelfNo);
                                command.Parameters.AddWithValue("@lane_no", shelf.LaneNo);
                                command.Parameters.AddWithValue("@shelf_index", shelf.ShelfIndex);
                                command.Parameters.AddWithValue("@shelf_desc", shelf.ShelfDesc);
                                command.Parameters.AddWithValue("@layers_set", shelf.LayersSet);
                                command.Parameters.AddWithValue("@locs_set", shelf.LocsSet);
                                command.Parameters.AddWithValue("@storage_type_id", shelf.StorageTypeId);
                                command.Parameters.AddWithValue("@shelf_pri", shelf.ShelfPri);
                                command.Parameters.AddWithValue("@abc_class", shelf.AbcClass);
                                command.Parameters.AddWithValue("@update_uid", shelf.UserId);
                                iInsertLocShelfsResult = command.ExecuteNonQuery();
                            }
                        }
                        //开始插入货位数据
                        if ((listLocations != null) && (listLocations.Count > 0))
                        {
                            foreach (Entities.EntityLocation loc in listLocations)
                            {
                                sqlPg = "insert into loc_location (location_no,shelf_no,abc_class,location_desc,remark_desc,update_uid,update_time) values "
                                    + "(@location_no,@shelf_no,@abc_class,@location_desc,@remark_desc,@update_uid,now())";
                                command.CommandText = sqlPg;
                                command.Parameters.Clear();
                                command.Parameters.AddWithValue("@location_no", loc.LocationNo);
                                command.Parameters.AddWithValue("@shelf_no", loc.ShelfNo);
                                command.Parameters.AddWithValue("@abc_class", loc.AbcClass);
                                command.Parameters.AddWithValue("@location_desc", loc.LocationDesc);
                                command.Parameters.AddWithValue("@remark_desc", loc.RemarkDesc);
                                command.Parameters.AddWithValue("@update_uid", loc.UserId);
                                iInsertLocationsResult = command.ExecuteNonQuery();
                            }
                        }
                    }
                    catch (NpgsqlException ex)
                    {
                        //throw new Exception(exception.Message);
                        Console.WriteLine(ex.ToString());
                        return null;
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }

            ListInsertLocationsResult.Add(iInsertLocLanesResult);
            ListInsertLocationsResult.Add(iInsertLocShelfsResult);
            ListInsertLocationsResult.Add(iInsertLocationsResult);

            return ListInsertLocationsResult;
        }

        internal static DataSet GetLocationLayoutDs(int iCustomerId, int iAreaGroupNo, string sLocationNo, string sItemNo, bool bIsRunStatistics, int iStatisticsTypeNo, DateTime dStatStartDate, DateTime dStatEndDate)
        {
            if (Common.CommonDa.GetDbType() == Common.EnumDbTypes.Sqlite)
                return GetGetLocationLayoutDsSqlite(iCustomerId, iAreaGroupNo, sLocationNo, sItemNo, bIsRunStatistics, iStatisticsTypeNo, dStatStartDate, dStatEndDate);
            else
                return GetGetLocationLayoutDsPg(iCustomerId, iAreaGroupNo, sLocationNo, sItemNo, bIsRunStatistics, iStatisticsTypeNo, dStatStartDate, dStatEndDate);   
        }

        private static DataSet GetGetLocationLayoutDsSqlite(int iCustomerId, int iAreaGroupNo, string sLocationNo, string sItemNo, bool bIsRunStatistics, int iStatisticsTypeNo, DateTime dStatStartDate, DateTime dStatEndDate)
        {
            string sqlquery = "";

            const string DS_WH_GRAPHICS = "DSNAME_WH_GRAPHICS";

            DataSet ds = new DataSet(DS_WH_GRAPHICS);

            string ConnectionString = Common.CommonDa.GetDbConnection();

            if (ConnectionString == "")
                return null;

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                using (SQLiteCommand sqlcommand = new SQLiteCommand(connection))
                {
                    try
                    {
                        SQLiteDataAdapter da = new SQLiteDataAdapter();

                        connection.Open();
                        da.SelectCommand = sqlcommand;

                        //--绘图信息-所有区
                        sqlquery = "select area_no,area_type_id,area_desc,warehouse_id from loc_area where void = 0 and area_group_id = " + iAreaGroupNo.ToString() + " order by area_no";
                        sqlcommand.CommandText = sqlquery;
                        ds.Tables.Add(TABLE_LOC_AREA);
                        da.Fill(ds.Tables[TABLE_LOC_AREA]);

                        //--绘图信息-所有通道
                        sqlquery = @" select ll.*,la.x_point as area_origin_xpoint,la.y_point as area_origin_ypoint,la.area_type_id  from loc_lane ll join loc_area la on ll.area_no = la.area_no 
                        where ll.void=0 and la.void=0 and la.area_group_id = ";
                        sqlquery += iAreaGroupNo.ToString();
                        sqlquery += " order by ll.area_no,ll.lane_no ";
                        sqlcommand.CommandText = sqlquery;
                        da.SelectCommand = sqlcommand;
                        ds.Tables.Add(TABLE_LOC_LANE);
                        da.Fill(ds.Tables[TABLE_LOC_LANE]);

                        //--绘图信息-所有库位（货架托盘）包括通道
                        sqlquery = @"select ls.*, ll.x_point,ll.y_point,ll.lane_direction,ll.lane_order,la.x_point as area_origin_xpoint,la.y_point as area_origin_ypoint,la.area_type_id
                        ,(case when ll.lane_order = 'MIN' then ls.shelf_index else (1000-ls.shelf_index) end ) as draw_index ,ls.layers_set * ls.locs_set as shelf_loc_count  
                        from loc_shelf ls 
                        join loc_lane ll on ls.lane_no = ll.lane_no 
                        join loc_area la on ll.area_no = la.area_no 
                        where ls.void=0 and ll.void=0 and la.void=0 and la.area_group_id = ";
                        sqlquery += iAreaGroupNo.ToString();
                        sqlquery += " order by ll.lane_no, draw_index, ls.shelf_no   ";
                        sqlcommand.CommandText = sqlquery;
                        da.SelectCommand = sqlcommand;
                        ds.Tables.Add(TABLE_LOC_LOCATION);
                        da.Fill(ds.Tables[TABLE_LOC_LOCATION]);


                        //按条件查询有货库位
                        string sql_add_cust = ""; // " AND ITEM.CustomerNo <> '测试客户' AND ITEM.CustomerNo <> '北京怡酷' ";
                        if (iCustomerId != -1)
                            sql_add_cust = " AND i.customer_id = " + iCustomerId.ToString() + " ";

                        string sql_add_loc = " ";
                        if (sLocationNo.Trim() != "")
                            sql_add_loc = " AND s.location_no = '" + sLocationNo.Trim() + "' ";

                        //string wh_01_pallet_add = " ( S.ShelfNo = LOC.ShelfNo AND S.StorageType <> 'PALLET') OR (S.StorageType = 'PALLET' AND SUBSTRING(S.ShelfNo,1,4) = SUBSTRING(LOC.LocationNo,1,4) AND SUBSTRING(S.ShelfNo,5,2) = SUBSTRING(LOC.LocationNo,7,2))";
                        //if (WarehouseNo != "01")
                        //    wh_01_pallet_add = " S.ShelfNo = LOC.ShelfNo ";
                        string wh_01_pallet_add = " ls.shelf_no = loc.shelf_no ";

                        /*
                        sqlquery = " SELECT ShelfNo,Count(*) AS LocUsedCount,ShelfLocCount,(Count(*) * 100)/ShelfLocCount AS UsedPercentage,Layer,LocationCount FROM   " +
                   " (  " +
                   " SELECT INV.ItemNo,SUM(INV.Qty) AS Qty,INV.LocationNo,A.AreaNo,S.ShelfNo,S.StorageType,S.Layer,S.LocationCount,S.Layer*S.LocationCount AS ShelfLocCount,  " +
                   " ITEM.ItemVolumeClass,ITEM.ItemABC,ISNULL(ITEM.ItemGrossVolume,0) AS ItemGrossVolume,ITEM.ItemDescription,ITEM.CustomerNo    " +
                   " FROM WH_Inventory INV  JOIN LOC_Location LOC ON LOC.LocationNo=INV.LocationNo " +
                   " JOIN LOC_Shelf S ON " + wh_01_pallet_add +
                   " JOIN LOC_Area A ON A.AreaNo = S.AreaNo AND A.AreaGroupNo = '" + AreaGroupNo + "'   " +
                   " JOIN IM_Item ITEM ON ITEM.ItemNo = INV.ItemNo " +
                   sql_add_item +
                   sql_add_cust +
                   " WHERE  " +
                   " INV.LocationNo <> 'RCVTEMP' AND INV.QTY > 0   " + sql_add_loc +
                   " GROUP BY  " +
                   " INV.ItemNo,INV.LocationNo,A.AreaNo,S.ShelfNo ,S.StorageType,S.Layer,S.LocationCount, " +
                   " ITEM.ItemVolumeClass,ITEM.ItemABC,ITEM.ItemGrossVolume,ITEM.ItemDescription,ITEM.CustomerNo  " +
                   " ) INV_SHELF " +
                   " GROUP BY ShelfNo,Layer,LocationCount,ShelfLocCount " +
                   " ORDER BY ShelfNo ";
                   */
                        sqlquery = "select 'A02-06' as shelf_no,3 AS loc_used_count,12 as shelf_loc_count,(3 * 100) / 12 AS used_percentage,4 as layer,12 as location_count ";
                        sqlcommand.CommandText = sqlquery;
                        da.SelectCommand = sqlcommand;
                        ds.Tables.Add(TABLE_LOC_STACKED_LOCATION);
                        da.Fill(ds.Tables[TABLE_LOC_STACKED_LOCATION]);

                        //查rf设备位置
                        //sqlquery = " SELECT DISTINCT WarehouseNo,LocationNoLast,LocationNoTracking,DeviceNo FROM BC_Device ";
                        //sqlcommand.CommandText = sqlquery;
                        //da.SelectCommand = sqlcommand;
                        //ds.Tables.Add(TABLE_LOC_RF);
                        //da.Fill(ds.Tables[TABLE_LOC_RF]);

                        if (bIsRunStatistics)
                        {
                            #region 不需要分析报表着色，以后添加
                            /*
                            if (iStatisticsTypeNo == 0)
                            {
                                //--绘图信息-出库ABC分析报表
                                sqlquery = " SELECT TOP 255 Row_Number() over (order by Sum(OD.Qty) DESC) as SORT_INDEX,LOC.ShelfNo,Sum(OD.Qty) AS COUNT_INFO " +
                                " FROM   " +
                                " WH_OrderHead OH JOIN WH_OrderDetail OD ON OH.OrderID=OD.OrderID AND OH.Void=0 AND OH.OrderStatus='SP_FIN'  " +
                                " JOIN IM_Item ITEM ON ITEM.ItemNo = OD.ItemNo  " +
                                " JOIN WH_Inventory INV ON INV.ItemNo = OD.ItemNo AND INV.QTY > 0 " +
                                " JOIN LOC_Location LOC ON LOC.LocationNo = INV.LocationNo  " +
                                " WHERE ";
                                if (CustomerNo.Trim() != "")
                                    sqlquery = sqlquery + " OH.CustomerNo = '" + CustomerNo.Trim() + "' AND ";
                                sqlquery = sqlquery + " OH.OrderCreateDateTime >= CONVERT(DATETIME,'" + StartDate.ToString("yyyy-MM-dd HH:mm:ss") + "') AND OH.OrderCreateDateTime <= CONVERT(DATETIME,'" + EndDate.ToString("yyyy-MM-dd HH:mm:ss") + "') " +
                                " GROUP BY LOC.ShelfNo  " +
                                " ORDER BY COUNT_INFO DESC ";
                            }
                            else if (iStatisticsTypeNo == 1)
                            {
                                sqlquery = "SELECT TOP 255 Row_Number() over (order by COUNT(RFD.LocationNo) DESC) as SORT_INDEX, " +
                                    " LOC.ShelfNo, RF.OrderTypeNo,COUNT(RFD.LocationNo) AS COUNT_INFO  " +
                                    " FROM WH_RF_OrderDetail RFD  " +
                                    " JOIN WH_RF_Order RF ON RF.RFOID = RFD.RFOID AND RF.OrderTypeNo = 'P-PICKING'  " +
                                    " JOIN LOC_Location LOC ON LOC.LocationNo = RFD.LocationNo  " +
                                    " WHERE RF.UpdateDateTime >= '" + StartDate.ToString("yyyy-MM-dd HH:mm:ss") + "' AND RF.UpdateDateTime <= '" + EndDate.ToString("yyyy-MM-dd HH:mm:ss") + "' " +
                                    " GROUP BY RF.OrderTypeNo,LOC.ShelfNo  " +
                                    " ORDER BY COUNT_INFO DESC";
                            }
                            else if (iStatisticsTypeNo == 2)
                            {
                                sqlquery = "SELECT TOP 255 Row_Number() over (order by COUNT(RFD.LocationNoTo) DESC) as SORT_INDEX, " +
                                    " LOC.ShelfNo, RF.OrderTypeNo,COUNT(RFD.LocationNoTo) AS COUNT_INFO ,RFD.LocationNoTo " +
                                    " FROM WH_RF_OrderDetail RFD  " +
                                    " JOIN WH_RF_Order RF ON RF.RFOID = RFD.RFOID AND ( RF.OrderTypeNo = 'A-BLIND' OR RF.OrderTypeNo = 'T-BLIND' ) " +
                                    " JOIN LOC_Location LOC ON LOC.LocationNo = RFD.LocationNoTo  " +
                                    " WHERE RF.UpdateDateTime >= '" + StartDate.ToString("yyyy-MM-dd HH:mm:ss") + "' AND RF.UpdateDateTime <= '" + EndDate.ToString("yyyy-MM-dd HH:mm:ss") + "' " +
                                    " GROUP BY RF.OrderTypeNo,LOC.ShelfNo ,RFD.LocationNoTo " +
                                    " ORDER BY COUNT_INFO DESC ";
                            }
                            else if (iStatisticsTypeNo == 3)
                            {
                                //--绘图信息-未发货分析报表
                                sqlquery = " SELECT TOP 255 Row_Number() over (order by Sum(OD.Qty) DESC) as SORT_INDEX,LOC.ShelfNo,Sum(OD.Qty) AS COUNT_INFO " +
                                " FROM   " +
                                " WH_OrderHead OH JOIN WH_OrderDetail OD ON OH.OrderID=OD.OrderID AND OH.Void=0 AND OH.OrderStatus='SP_NEW'  " +
                                " JOIN IM_Item ITEM ON ITEM.ItemNo = OD.ItemNo  " +
                                " JOIN WH_Inventory INV ON INV.ItemNo = OD.ItemNo AND INV.QTY > 0 " +
                                " JOIN LOC_Location LOC ON LOC.LocationNo = INV.LocationNo  " +
                                " WHERE ";
                                if (iCustomerId != -1)
                                    sqlquery = sqlquery + " OH.CustomerNo = '" + CustomerNo.Trim() + "' AND ";
                                sqlquery = sqlquery + " OH.OrderCreateDateTime >= CONVERT(DATETIME,'" + StartDate.ToString("yyyy-MM-dd HH:mm:ss") + "') AND OH.OrderCreateDateTime <= CONVERT(DATETIME,'" + EndDate.ToString("yyyy-MM-dd HH:mm:ss") + "') " +
                                " GROUP BY LOC.ShelfNo  " +
                                " ORDER BY COUNT_INFO DESC ";
                            }
                            sqlcommand.CommandText = sqlquery;
                            da.SelectCommand = sqlcommand;
                            ds.Tables.Add(TABLE_LOC_STATISTICS);
                            da.Fill(ds.Tables[TABLE_LOC_STATISTICS]);
                            */
                            #endregion
                        }

                    }
                    catch (NpgsqlException exception)
                    {
                        ds = null;
                        throw new Exception(exception.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }

            return ds;
        }

        private static DataSet GetGetLocationLayoutDsPg(int iCustomerId, int iAreaGroupNo, string sLocationNo, string sItemNo, bool bIsRunStatistics, int iStatisticsTypeNo, DateTime dStatStartDate, DateTime dStatEndDate)
        {
            string sqlquery = "";

            const string DS_WH_GRAPHICS = "DSNAME_WH_GRAPHICS";

            DataSet ds = new DataSet(DS_WH_GRAPHICS);

            string ConnectionString = Common.CommonDa.GetDbConnection();

            if (ConnectionString == "")
                return null;

            using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionString))
            {
                using (NpgsqlCommand sqlcommand = new NpgsqlCommand(sqlquery, connection))
                {
                    try
                    {
                        NpgsqlDataAdapter da = new NpgsqlDataAdapter();

                        connection.Open();
                        da.SelectCommand = sqlcommand;

                        //--绘图信息-所有区
                        sqlquery = "select area_no,area_type_id,area_desc,warehouse_id from loc_area where void = 0 and area_group_id = " + iAreaGroupNo.ToString() + " order by area_no";
                        sqlcommand.CommandText = sqlquery;
                        ds.Tables.Add(TABLE_LOC_AREA);
                        da.Fill(ds.Tables[TABLE_LOC_AREA]);

                        //--绘图信息-所有通道
                        sqlquery = @" select ll.*,la.x_point as area_origin_xpoint,la.y_point as area_origin_ypoint,la.area_type_id  from loc_lane ll join loc_area la on ll.area_no = la.area_no 
                        where ll.void=0 and la.void=0 and la.area_group_id = ";
                        sqlquery += iAreaGroupNo.ToString();
                        sqlquery += " order by ll.area_no,ll.lane_no ";
                        sqlcommand.CommandText = sqlquery;
                        da.SelectCommand = sqlcommand;
                        ds.Tables.Add(TABLE_LOC_LANE);
                        da.Fill(ds.Tables[TABLE_LOC_LANE]);

                        //--绘图信息-所有库位（货架托盘）包括通道
                        sqlquery = @"select ls.*, ll.x_point,ll.y_point,ll.lane_direction,ll.lane_order,la.x_point as area_origin_xpoint,la.y_point as area_origin_ypoint,la.area_type_id
                        ,(case when ll.lane_order = 'MIN' then ls.shelf_index else (1000-ls.shelf_index) end ) as draw_index ,ls.layers_set * ls.locs_set as shelf_loc_count  
                        from loc_shelf ls 
                        join loc_lane ll on ls.lane_no = ll.lane_no 
                        join loc_area la on ll.area_no = la.area_no 
                        where ls.void=0 and ll.void=0 and la.void=0 and la.area_group_id = ";
                        sqlquery += iAreaGroupNo.ToString();
                        sqlquery += " order by ll.lane_no, draw_index, ls.shelf_no   ";
                        sqlcommand.CommandText = sqlquery;
                        da.SelectCommand = sqlcommand;
                        ds.Tables.Add(TABLE_LOC_LOCATION);
                        da.Fill(ds.Tables[TABLE_LOC_LOCATION]);


                        //按条件查询有货库位
                        string sql_add_cust = ""; // " AND ITEM.CustomerNo <> '测试客户' AND ITEM.CustomerNo <> '北京怡酷' ";
                        if (iCustomerId != -1)
                            sql_add_cust = " AND i.customer_id = " + iCustomerId.ToString() + " ";

                        string sql_add_loc = " ";
                        if (sLocationNo.Trim() != "")
                            sql_add_loc = " AND s.location_no = '" + sLocationNo.Trim() + "' ";

                        //string wh_01_pallet_add = " ( S.ShelfNo = LOC.ShelfNo AND S.StorageType <> 'PALLET') OR (S.StorageType = 'PALLET' AND SUBSTRING(S.ShelfNo,1,4) = SUBSTRING(LOC.LocationNo,1,4) AND SUBSTRING(S.ShelfNo,5,2) = SUBSTRING(LOC.LocationNo,7,2))";
                        //if (WarehouseNo != "01")
                        //    wh_01_pallet_add = " S.ShelfNo = LOC.ShelfNo ";
                        string wh_01_pallet_add = " ls.shelf_no = loc.shelf_no ";

                        /*
                        sqlquery = " SELECT ShelfNo,Count(*) AS LocUsedCount,ShelfLocCount,(Count(*) * 100)/ShelfLocCount AS UsedPercentage,Layer,LocationCount FROM   " +
                   " (  " +
                   " SELECT INV.ItemNo,SUM(INV.Qty) AS Qty,INV.LocationNo,A.AreaNo,S.ShelfNo,S.StorageType,S.Layer,S.LocationCount,S.Layer*S.LocationCount AS ShelfLocCount,  " +
                   " ITEM.ItemVolumeClass,ITEM.ItemABC,ISNULL(ITEM.ItemGrossVolume,0) AS ItemGrossVolume,ITEM.ItemDescription,ITEM.CustomerNo    " +
                   " FROM WH_Inventory INV  JOIN LOC_Location LOC ON LOC.LocationNo=INV.LocationNo " +
                   " JOIN LOC_Shelf S ON " + wh_01_pallet_add +
                   " JOIN LOC_Area A ON A.AreaNo = S.AreaNo AND A.AreaGroupNo = '" + AreaGroupNo + "'   " +
                   " JOIN IM_Item ITEM ON ITEM.ItemNo = INV.ItemNo " +
                   sql_add_item +
                   sql_add_cust +
                   " WHERE  " +
                   " INV.LocationNo <> 'RCVTEMP' AND INV.QTY > 0   " + sql_add_loc +
                   " GROUP BY  " +
                   " INV.ItemNo,INV.LocationNo,A.AreaNo,S.ShelfNo ,S.StorageType,S.Layer,S.LocationCount, " +
                   " ITEM.ItemVolumeClass,ITEM.ItemABC,ITEM.ItemGrossVolume,ITEM.ItemDescription,ITEM.CustomerNo  " +
                   " ) INV_SHELF " +
                   " GROUP BY ShelfNo,Layer,LocationCount,ShelfLocCount " +
                   " ORDER BY ShelfNo ";
                   */
                        sqlquery = "select 'A02-06' as shelf_no,3 AS loc_used_count,12 as shelf_loc_count,(3 * 100) / 12 AS used_percentage,4 as layer,12 as location_count ";
                        sqlcommand.CommandText = sqlquery;
                        da.SelectCommand = sqlcommand;
                        ds.Tables.Add(TABLE_LOC_STACKED_LOCATION);
                        da.Fill(ds.Tables[TABLE_LOC_STACKED_LOCATION]);

                        //查rf设备位置
                        //sqlquery = " SELECT DISTINCT WarehouseNo,LocationNoLast,LocationNoTracking,DeviceNo FROM BC_Device ";
                        //sqlcommand.CommandText = sqlquery;
                        //da.SelectCommand = sqlcommand;
                        //ds.Tables.Add(TABLE_LOC_RF);
                        //da.Fill(ds.Tables[TABLE_LOC_RF]);

                        if (bIsRunStatistics)
                        {
                            #region 不需要分析报表着色，以后添加
                            /*
                            if (iStatisticsTypeNo == 0)
                            {
                                //--绘图信息-出库ABC分析报表
                                sqlquery = " SELECT TOP 255 Row_Number() over (order by Sum(OD.Qty) DESC) as SORT_INDEX,LOC.ShelfNo,Sum(OD.Qty) AS COUNT_INFO " +
                                " FROM   " +
                                " WH_OrderHead OH JOIN WH_OrderDetail OD ON OH.OrderID=OD.OrderID AND OH.Void=0 AND OH.OrderStatus='SP_FIN'  " +
                                " JOIN IM_Item ITEM ON ITEM.ItemNo = OD.ItemNo  " +
                                " JOIN WH_Inventory INV ON INV.ItemNo = OD.ItemNo AND INV.QTY > 0 " +
                                " JOIN LOC_Location LOC ON LOC.LocationNo = INV.LocationNo  " +
                                " WHERE ";
                                if (CustomerNo.Trim() != "")
                                    sqlquery = sqlquery + " OH.CustomerNo = '" + CustomerNo.Trim() + "' AND ";
                                sqlquery = sqlquery + " OH.OrderCreateDateTime >= CONVERT(DATETIME,'" + StartDate.ToString("yyyy-MM-dd HH:mm:ss") + "') AND OH.OrderCreateDateTime <= CONVERT(DATETIME,'" + EndDate.ToString("yyyy-MM-dd HH:mm:ss") + "') " +
                                " GROUP BY LOC.ShelfNo  " +
                                " ORDER BY COUNT_INFO DESC ";
                            }
                            else if (iStatisticsTypeNo == 1)
                            {
                                sqlquery = "SELECT TOP 255 Row_Number() over (order by COUNT(RFD.LocationNo) DESC) as SORT_INDEX, " +
                                    " LOC.ShelfNo, RF.OrderTypeNo,COUNT(RFD.LocationNo) AS COUNT_INFO  " +
                                    " FROM WH_RF_OrderDetail RFD  " +
                                    " JOIN WH_RF_Order RF ON RF.RFOID = RFD.RFOID AND RF.OrderTypeNo = 'P-PICKING'  " +
                                    " JOIN LOC_Location LOC ON LOC.LocationNo = RFD.LocationNo  " +
                                    " WHERE RF.UpdateDateTime >= '" + StartDate.ToString("yyyy-MM-dd HH:mm:ss") + "' AND RF.UpdateDateTime <= '" + EndDate.ToString("yyyy-MM-dd HH:mm:ss") + "' " +
                                    " GROUP BY RF.OrderTypeNo,LOC.ShelfNo  " +
                                    " ORDER BY COUNT_INFO DESC";
                            }
                            else if (iStatisticsTypeNo == 2)
                            {
                                sqlquery = "SELECT TOP 255 Row_Number() over (order by COUNT(RFD.LocationNoTo) DESC) as SORT_INDEX, " +
                                    " LOC.ShelfNo, RF.OrderTypeNo,COUNT(RFD.LocationNoTo) AS COUNT_INFO ,RFD.LocationNoTo " +
                                    " FROM WH_RF_OrderDetail RFD  " +
                                    " JOIN WH_RF_Order RF ON RF.RFOID = RFD.RFOID AND ( RF.OrderTypeNo = 'A-BLIND' OR RF.OrderTypeNo = 'T-BLIND' ) " +
                                    " JOIN LOC_Location LOC ON LOC.LocationNo = RFD.LocationNoTo  " +
                                    " WHERE RF.UpdateDateTime >= '" + StartDate.ToString("yyyy-MM-dd HH:mm:ss") + "' AND RF.UpdateDateTime <= '" + EndDate.ToString("yyyy-MM-dd HH:mm:ss") + "' " +
                                    " GROUP BY RF.OrderTypeNo,LOC.ShelfNo ,RFD.LocationNoTo " +
                                    " ORDER BY COUNT_INFO DESC ";
                            }
                            else if (iStatisticsTypeNo == 3)
                            {
                                //--绘图信息-未发货分析报表
                                sqlquery = " SELECT TOP 255 Row_Number() over (order by Sum(OD.Qty) DESC) as SORT_INDEX,LOC.ShelfNo,Sum(OD.Qty) AS COUNT_INFO " +
                                " FROM   " +
                                " WH_OrderHead OH JOIN WH_OrderDetail OD ON OH.OrderID=OD.OrderID AND OH.Void=0 AND OH.OrderStatus='SP_NEW'  " +
                                " JOIN IM_Item ITEM ON ITEM.ItemNo = OD.ItemNo  " +
                                " JOIN WH_Inventory INV ON INV.ItemNo = OD.ItemNo AND INV.QTY > 0 " +
                                " JOIN LOC_Location LOC ON LOC.LocationNo = INV.LocationNo  " +
                                " WHERE ";
                                if (iCustomerId != -1)
                                    sqlquery = sqlquery + " OH.CustomerNo = '" + CustomerNo.Trim() + "' AND ";
                                sqlquery = sqlquery + " OH.OrderCreateDateTime >= CONVERT(DATETIME,'" + StartDate.ToString("yyyy-MM-dd HH:mm:ss") + "') AND OH.OrderCreateDateTime <= CONVERT(DATETIME,'" + EndDate.ToString("yyyy-MM-dd HH:mm:ss") + "') " +
                                " GROUP BY LOC.ShelfNo  " +
                                " ORDER BY COUNT_INFO DESC ";
                            }
                            sqlcommand.CommandText = sqlquery;
                            da.SelectCommand = sqlcommand;
                            ds.Tables.Add(TABLE_LOC_STATISTICS);
                            da.Fill(ds.Tables[TABLE_LOC_STATISTICS]);
                            */
                            #endregion
                        }

                    }
                    catch (NpgsqlException exception)
                    {
                        ds = null;
                        throw new Exception(exception.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }

            return ds;
        }
    }
}
