using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppWmsLite.Ai
{
    class WayfindingAStar
    {
        //Point p = new System.Drawing.Point();
        public static List<EntityLocationCell> FindPath(EntityLocationCell pStartLocation, EntityLocationCell pEndLocation, List<EntityLocationCell> lstDisableCells,bool bIncludeStartPoint = false)
        {
            List<EntityLocationCell> lstPathReturn = new List<EntityLocationCell>();

            bool bIsOutputDebug = false;

            int iShowFindNum = 1;

            //开启列表
            List<EntityLocationCell> OpenList = new List<EntityLocationCell>();
            //关闭列表
            List<EntityLocationCell> CloseList = new List<EntityLocationCell>();

            //起点
            EntityLocationCell pStart = pStartLocation;
            //终点
            EntityLocationCell pEnd = pEndLocation;
            System.Diagnostics.Debug.WriteLine("寻路开始,start({0},{1}),end({2},{3})...", pStart.X, pStart.Y, pEnd.X, pEnd.Y);

            //将起点作为待处理的点放入开启列表，
            OpenList.Add(pStart);

            //如果开启列表没有待处理点表示寻路失败，此路不通
            while (OpenList.Count > 0)
            {
                //遍历开启列表，找到消费最小的点作为检查点
                EntityLocationCell pCurrentCell = OpenList[0];
                for (int i = 0; i < OpenList.Count; i++)
                {

                    if (OpenList[i].F < pCurrentCell.F && OpenList[i].H < pCurrentCell.H)
                    {
                        pCurrentCell = OpenList[i];
                        break;
                    }
                }
                if (bIsOutputDebug)
                    System.Diagnostics.Debug.WriteLine("当前检查点：(" + pCurrentCell.X + "," + pCurrentCell.Y + ") 编号：" + iShowFindNum + "  open列表节点数量：" + OpenList.Count);

                //if (iShowFindNum == 438)
                //{
                //    Console.WriteLine(iShowFindNum.ToString());
                //}

                //显示在界面，和A*算法无关
                //pCurrentCell.obj.transform.Find("Num").GetComponent<Text>().text = showFindNum.ToString();
                iShowFindNum++;

                //从开启列表中删除检查点，把它加入到一个“关闭列表”，列表中保存所有不需要再次检查的方格。
                OpenList.Remove(pCurrentCell);
                CloseList.Add(pCurrentCell);

                //检查是否找到终点
                if ((pCurrentCell.X == pEnd.X) && (pCurrentCell.Y == pEnd.Y))
                {
                    Console.WriteLine("寻路结束");

                    lstPathReturn.Add(pCurrentCell); //加入终点

                    EntityLocationCell cRecall = new EntityLocationCell();
                    cRecall = pCurrentCell.ParentCell;

                    while (!((cRecall.X == pStart.X) && (cRecall.Y == pStart.Y)))
                    {
                        EntityLocationCell cRecallAdd = new EntityLocationCell();
                        //cRecallAdd.X = cRecall.X;
                        //cRecallAdd.Y = cRecall.Y;
                        cRecallAdd = cRecall;
                        lstPathReturn.Add(cRecallAdd);

                        EntityLocationCell cRecallTemp = new EntityLocationCell();
                        cRecallTemp = cRecall.ParentCell;

                        cRecall = cRecallTemp;
                    }
                    //根据参数bIncludeStartPoint判断是否要加入起点在返回值list中
                    if (bIncludeStartPoint)
                        lstPathReturn.Add(pStart); //加入起点

                    string sMessage = "";
                    for (int i = lstPathReturn.Count; i > 0; i--)
                    {
                        if (i > 1)
                            sMessage += "(" + lstPathReturn[i - 1].X + "," + lstPathReturn[i - 1].Y + ") ->";
                        else
                            sMessage += "(" + lstPathReturn[i - 1].X + "," + lstPathReturn[i - 1].Y + ")";
                    }
                    System.Diagnostics.Debug.WriteLine(sMessage);

                    System.Diagnostics.Debug.WriteLine("FindNum:" + iShowFindNum.ToString() + ",OpenList:" + OpenList.Count + ",CloseList:" + CloseList.Count);

                    return lstPathReturn;
                }
                //if (pCurrentCell == pEnd)
                //{
                //    Console.WriteLine("寻路结束!");
                //    //grid.CreatePath(pCurrentCell);
                //    return;
                //}

                //根据检查点来找到周围可行走的点
                //1.如果是墙或者在关闭列表中则跳过
                //2.如果点不在开启列表中则添加
                //3.如果点在开启列表中且当前的总花费比之前的总花费小，则更新该点信息
                List<EntityLocationCell> listAroundCells = GetAllAroundCells(pCurrentCell, lstDisableCells);
                foreach (EntityLocationCell cell in listAroundCells)
                {

                    if (cell.IsWall || CloseList.Contains(cell))
                        continue;

                    int iAroundCellCostG = pCurrentCell.G + GetDistanceCost(cell, pCurrentCell);

                    if (iAroundCellCostG < cell.G || !OpenList.Contains(cell))
                    {
                        cell.G = iAroundCellCostG;
                        cell.H = GetDistanceCost(cell, pEnd);
                        cell.F = cell.G + cell.H;
                        cell.ParentCell = pCurrentCell;
                        if (bIsOutputDebug)
                            System.Diagnostics.Debug.WriteLine("cell:(" + cell.X + "," + cell.Y + ")  parent:(" + pCurrentCell.X + "," + pCurrentCell.Y + ")  " + cell.F);
                        //if (!OpenList.Contains(cell)) //这个Contains必须完全相同，G值F值等会造成反复加入
                        bool bContain = false;
                        foreach(EntityLocationCell co in OpenList)
                        {
                            if ((co.X == cell.X) && (co.Y == cell.Y))
                            {
                                bContain = true;
                                break;
                            }
                        }
                        if (!bContain)
                        {
                            OpenList.Add(cell);
                        }

                        //显示在界面，和A*算法无关
                        //cell.obj.transform.Find("Cost").GetComponent<Text>().text = cell.fCost.ToString();
                    }
                }

            }

            System.Diagnostics.Debug.WriteLine("寻路失败!");
            return null;
        }

        private static int GetDistanceCost(EntityLocationCell cStart, EntityLocationCell cEnd)
        {
            int iDistanceCost = 999;
            int iDistanceX = Math.Abs(cStart.X - cEnd.X);
            int iDistanceY = Math.Abs(cStart.Y - cEnd.Y);
            iDistanceCost = iDistanceX + iDistanceY;

            return iDistanceCost;
        }

        private static List<EntityLocationCell> GetAllAroundCells(EntityLocationCell pCurrentCell, List<EntityLocationCell> lstDisableCells)
        {
            List<EntityLocationCell> lstAroundCells = new List<EntityLocationCell>();

            EntityLocationCell cUpCell = new EntityLocationCell();
            cUpCell.X = pCurrentCell.X;
            cUpCell.Y = pCurrentCell.Y - 1;
            if ((cUpCell.X > 0) && (cUpCell.Y > 0))
                lstAroundCells.Add(cUpCell);

            EntityLocationCell cDownCell = new EntityLocationCell();
            cDownCell.X = pCurrentCell.X;
            cDownCell.Y = pCurrentCell.Y + 1;
            if ((cDownCell.X > 0) && (cDownCell.Y > 0))
                lstAroundCells.Add(cDownCell);

            EntityLocationCell cLeftCell = new EntityLocationCell();
            cLeftCell.X = pCurrentCell.X - 1;
            cLeftCell.Y = pCurrentCell.Y;
            if ((cLeftCell.X > 0) && (cLeftCell.Y > 0))
                lstAroundCells.Add(cLeftCell);

            EntityLocationCell cRifhtCell = new EntityLocationCell();
            cRifhtCell.X = pCurrentCell.X + 1;
            cRifhtCell.Y = pCurrentCell.Y;
            if ((cRifhtCell.X > 0) && (cRifhtCell.Y > 0))
                lstAroundCells.Add(cRifhtCell);

            for (int i = 0; i < lstAroundCells.Count; i++)
            {
                if (IsInLocationList(lstAroundCells[i], lstDisableCells))
                    lstAroundCells[i].IsWall = true;
            }

            return lstAroundCells;
        }

        /// <summary>
        /// 检查一个Cell是不是在禁止到达的List中
        /// </summary>
        /// <param name="cCurrentCell"></param>
        /// <param name="lstDisableCells"></param>
        /// <returns></returns>
        private static bool IsInLocationList(EntityLocationCell cCurrentCell, List<EntityLocationCell> lstDisableCells)
        {
            bool bIsInLocationList = false;
            if (lstDisableCells == null)
                return false;
            if (lstDisableCells.Count == 0)
                return false;

            foreach (EntityLocationCell cell in lstDisableCells)
            {
                if ((cell.X == cCurrentCell.X) && (cell.Y == cCurrentCell.Y))
                {
                    bIsInLocationList = true;
                    break;
                }
            }

            return bIsInLocationList;
        }
    }
}
