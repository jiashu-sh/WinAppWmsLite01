using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppWmsLite.Entities
{
    class EntityLocShelf
    {
        public string ShelfNo { get; set; }

        public string ShelfDesc { get; set; }

        public string LaneNo { get; set; }

        public int ShelfIndex { get; set; }

        public int LayersSet { get; set; } //货架有几层

        public int LocsSet { get; set; } //每层几个货位

        public int StorageTypeId { get; set; }

        public int ShelfPri { get; set; }

        public string AbcClass { get; set; }

        public string RemarkDesc { get; set; }

        public int UserId { get; set; }

        public EntityLocShelf ()
        {
            ShelfNo = "";
            ShelfDesc = "";
            LaneNo = "";
            ShelfIndex = 0;
            LayersSet = 1;
            LocsSet = 1;
            StorageTypeId = -1;
            ShelfPri = 100;
            AbcClass = "C";
            RemarkDesc = "";
            UserId = -1;
        }

    }
}
