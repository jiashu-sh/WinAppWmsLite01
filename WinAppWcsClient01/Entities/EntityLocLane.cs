using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppWmsLite.Entities
{
    class EntityLocLane
    {
        public string LaneNo { get; set; }

        public string LaneDesc { get; set; }

        public string AreaNo { get; set; }

        public int LanePri { get; set; }
        
        public int LayersSet { get; set; }

        public int XPoint { get; set; }

        public int YPoint { get; set; }

        public string LaneDirection { get; set; }

        public string LaneOrder { get; set; }

        public int UserId { get; set; }

        public EntityLocLane()
        {
            LaneNo = "";
            LaneDesc = "";
            AreaNo = "";
            LanePri = 100;
            LayersSet = 1;
            XPoint = 0;
            YPoint = 0;
            LaneDirection = "N";
            LaneOrder = "MIN";
            UserId = -1;
        }
    }
}
