using System;
using System.Collections.Generic;
using System.Text;

namespace HamsterModel.WmsLite.WhMgt.FormStockQuery
{
    public class RefreshQueryModel
    {
        public int CustomerId { set; get; }

        public bool IsListAllItems { set; get; }

        public string ItemBarcode { set; get; }

        public string ItemDesc { set; get; }
    }
}
