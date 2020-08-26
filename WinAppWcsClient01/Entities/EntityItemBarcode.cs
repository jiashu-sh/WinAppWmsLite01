using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppWmsLite.Entities
{
    class EntityItemBarcode
    {
        public int ProductNo { get; set; }
        
        public int CustomerId { get; set; }

        public string ItemBarcode { get; set; }

        public string RemarkDesc { get; set; }

        public int UserId { get; set; }

        public EntityItemBarcode()
        {
            ProductNo = -1;            
            CustomerId = -1;
            ItemBarcode = "";
            RemarkDesc = "";
            UserId = -1;
        }
    }
}
