using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppWmsLite.EntitiesRbt
{
    public class EntityRbtUnit
    {
        public string UnitId { get; set; }

        public bool MovingFlag { get; set; }

        public int LocX { get; set; }

        public int LocY { get; set; }

        public int Orient { get; set; }

        public string CommandGuid { get; set; }

        public int FinishedFlag { get; set; }

        public EntityRbtUnit()
        {
            UnitId = "";
            MovingFlag = false;
            LocX = 0;
            LocY = 0;
            Orient = 0;

            CommandGuid = "";
            FinishedFlag = 0; //未获取未开始执行为0（初始状态），完成为 10，已获取正在执行为 1，取消为-1 （初步这样想...）
        }

        public EntityRbtUnit(string sUnitId, int iInitVal = 0)
        {
            //iInitVal 要设置的话最好设为0,表示不需要移动（未设置指令）
            UnitId = sUnitId;
            MovingFlag = false;
            LocX = iInitVal;
            LocY = iInitVal;
            Orient = 0;

            CommandGuid = "";
            FinishedFlag = 0; //未获取未开始执行为0（初始状态），完成为 10，已获取正在执行为 1，取消为-1 （初步这样想...）
        }
    }
}
