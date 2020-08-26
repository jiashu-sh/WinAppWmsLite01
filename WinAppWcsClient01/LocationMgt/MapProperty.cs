using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppWmsLite.LocationMgt
{
    public class MapProperty
    {
        public const int LANE_FACE_TO_FACE_DISTANCE = 75;// 35;//面对面（带通道）货架间隔
        public const int LANE_BACK_TO_BACK_DISTANCE = 25;//15;//背靠背货架间隔

        public const int PALLET_WIDTH = 50;//25; //托盘位置尺寸
        public const int PALLET_HEIGHT = 50; //25;
        public const int PALLET_INSTOCK_WIDTH = 46; //21; //托盘填充尺寸
        public const int PALLET_INSTOCK_HEIGHT = 46; //21;
        public const int PALLET_FILL_SPACE = 1;//填充托盘颜色的位移量
        public const int PALLET_LANE_SPACE = 2;//托盘摆放间隔

        public const int CARTONFLOW_WIDTH = 35;//流利式货架尺寸
        public const int CARTONFLOW_HEIGHT = 80;
        public const int CARTONFLOW_INSTOCK_WIDTH = 31;
        public const int CARTONFLOW_INSTOCK_HEIGHT = 76;
        public const int CARTONFLOW_FILL_SPACE = 1;
        public const int CARTONFLOW_LANE_SPACE = 2;

        public const int RACK_WIDTH = 100; //43; //货架位置尺寸
        public const int RACK_HEIGHT = 25; //13;
        public const int RACK_INSTOCK_WIDTH = 97;// 40; //货架填充尺寸
        public const int RACK_INSTOCK_HEIGHT = 22;//10;
        public const int RACK_FILL_SPACE = 2;//填充货架颜色的位移量
        public const int RACK_LANE_SPACE = 0;//货架摆放间隔

        public const int MARK_LINE_LENGTH = 5;

        public const int TIER_BOX_HEIGHT = 0;

        public const int ORIGIN_X = 50; //绘图起始坐标x
        public const int ORIGIN_Y = 50;//20; //绘图起始坐标y
        public const int MOVE_STEP = 300; //每次移动的坐标偏移量

        
        public enum AreaTypes
        {
            Shelf = 1,
            Pallet = 2
        }

        public enum StorageTypes
        {
            Shelf4x3 = 12,
            Shelf4x4 = 16,
            Shelf4x6 = 18,
            Pallet = 1
        }

        /// <summary>
        /// 根据百分比设置颜色
        /// </summary>
        /// <param name="StackPercentage"></param>
        /// <returns></returns>
        public static Brush SetPercentageBrushColor(int StackPercentage)
        {
            Brush CartonBrush2 = new SolidBrush(Color.White);

            if (StackPercentage > 150) //大于150%
            {
                CartonBrush2 = new SolidBrush(Color.DarkOrchid);
            }
            else if (StackPercentage > 100) //大于 100%
            {
                CartonBrush2 = new SolidBrush(Color.DarkViolet);
            }
            else if (StackPercentage > 90)
            {
                CartonBrush2 = new SolidBrush(Color.Red);
            }
            else if (StackPercentage > 70)
            {
                CartonBrush2 = new SolidBrush(Color.OrangeRed);
            }
            else if (StackPercentage > 50)
            {
                CartonBrush2 = new SolidBrush(Color.Gold);
            }
            else if (StackPercentage > 30)
            {
                CartonBrush2 = new SolidBrush(Color.MediumAquamarine);
            }
            else
            {
                CartonBrush2 = new SolidBrush(Color.PaleGreen);
            }

            return CartonBrush2;
        }

        public static Brush SetStatisticsBrushColor(int SortIndex)
        {
            Brush CartonBrush2 = new SolidBrush(Color.FromArgb(255, SortIndex - 1, SortIndex - 1));

            return CartonBrush2;
        }

        public static Brush SetPickingPriColor(int PickingPri)
        {
            Brush CartonBrush2 = new SolidBrush(Color.White);

            if (PickingPri > 4000) //大于150%
            {
                CartonBrush2 = new SolidBrush(Color.DimGray);
            }
            else if (PickingPri > 1000) //大于 100%
            {
                CartonBrush2 = new SolidBrush(Color.DarkGray);
            }
            else if (PickingPri > 500)
            {
                CartonBrush2 = new SolidBrush(Color.LightGray);
            }
            else if (PickingPri > 200)
            {
                CartonBrush2 = new SolidBrush(Color.LightSteelBlue);
            }
            else if (PickingPri > 100)
            {
                CartonBrush2 = new SolidBrush(Color.LightYellow);
            }
            else if (PickingPri > 80)
            {
                CartonBrush2 = new SolidBrush(Color.Moccasin);
            }
            else if (PickingPri > 50)
            {
                CartonBrush2 = new SolidBrush(Color.Yellow);
            }
            else if (PickingPri > 20)
            {
                CartonBrush2 = new SolidBrush(Color.Gold);
            }
            else if (PickingPri > 10)
            {
                CartonBrush2 = new SolidBrush(Color.OrangeRed);
            }
            else
            {
                CartonBrush2 = new SolidBrush(Color.Red); //PaleGreen);
            }

            return CartonBrush2;
        }

        public static Brush SetAbcClassBrushColor(string AbcClass)
        {
            Brush CartonBrush2 = new SolidBrush(Color.White);

            if (AbcClass == "A")
            {
                CartonBrush2 = new SolidBrush(Color.Red);
            }
            else if (AbcClass == "B")
            {
                CartonBrush2 = new SolidBrush(Color.Orange);
            }
            else if (AbcClass == "C")
            {
                CartonBrush2 = new SolidBrush(Color.Moccasin);
            }
            else if (AbcClass == "D")
            {
                CartonBrush2 = new SolidBrush(Color.LightSkyBlue);
            }
            else
            {
                CartonBrush2 = new SolidBrush(Color.Gray);
            }

            return CartonBrush2;
        }
    }
}
