using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppWmsLite.Entities
{
    class EntityItem
    {
        public int ProductNo { get; set; }

        public string ItemNo { get; set; }

        public string ItemDesc { get; set; }

        public int CustomerId { get; set; }

        public string RemarkDesc { get; set; }

        public int UserId { get; set; }

        public List<EntityItemBarcode> ItemBarcodes { get; set; }

        public EntityItem()
        {
            ProductNo = -1;
            ItemNo = "";
            ItemDesc = "";
            CustomerId = -1;
            RemarkDesc = "";
            UserId = -1;
        }
    }
}
