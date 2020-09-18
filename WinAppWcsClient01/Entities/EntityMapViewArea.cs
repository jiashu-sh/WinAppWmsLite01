using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppWmsLite.Entities
{
    class EntityMapViewArea
    {
        public string AreaId { get; set; }

        public string AreaNo { get; set; }

        /**
         * device_px 位置x坐标
         */
        public int x { get; set; }
        /**
         * device_py 位置x坐标
         */
        public int y { get; set; }
    }
}
