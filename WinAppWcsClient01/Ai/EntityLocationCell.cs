using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppWmsLite.Ai
{
    class EntityLocationCell
    {
        public int X { get; set; }
        public int Y { get; set; }

        public bool IsWall { get; set; }

        public int G { get; set; } //G:起点移动到当前点的cost
        public int H { get; set; } //H:当前点到终点最短距离，用Manhattan距离

        public int F { get; set; } //F Cost:F=G+H

        public EntityLocationCell ParentCell { get; set; }

        public EntityLocationCell()
        {
            X = 0;
            Y = 0;
            IsWall = false;
            G = 0;
            H = 0;
            ParentCell = null;
        }
    }
}
