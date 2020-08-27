using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppWmsLite.Entities
{
    class EntityIoLogs
    {
        public int IoTypeId { get; set; }

        public int OrderId { get; set; }

        public EntityItem Item { get; set; }
           

        public int UomId { get; set; }

        public string LotNo { get; set; }

        public string SerialNo { get; set; }

        public int Qty { get; set; }

        public string ContainerId { get; set; }

        public int UserId { get; set; }

        public int IndexNo { get; set; }//操作顺序

        public string ItemBarcode { get; set; }

        public string ItemDesc { get; set; }

        public EntityIoLogs()
        {
            IoTypeId = (int)Common.EnumIoTypes.In;
            OrderId = -1;
            UomId = -1;
            LotNo = "";
            SerialNo = "";
            Qty = 0;
            ContainerId = "";
            UserId = -1;

            IndexNo = -1;
            ItemBarcode = "";
            ItemDesc = "";
        }
    }
}
