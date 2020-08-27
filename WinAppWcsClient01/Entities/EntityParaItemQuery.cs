using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppWmsLite.Entities
{
    class EntityParaItemQuery
    {
        public int ProductNo { get; set; }

        public string ItemBarcode { get; set; }

        public string ItemDesc { get; set; }

        public int CustomerId { get; set; }

        public bool IsListAllItems { get; set; }

        public EntityParaItemQuery()
        {
            ProductNo = -1;
            ItemBarcode = "";
            ItemDesc = "";
            CustomerId = -1;
            IsListAllItems = false;
        }
    }
}
