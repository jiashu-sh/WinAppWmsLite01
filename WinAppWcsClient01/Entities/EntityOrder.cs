using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppWmsLite.Entities
{
    class EntityOrder
    {
        public int OrderId { get; set; }

        public string OrderNo { get; set; }

        public int OrderTypeId { get; set; }

        public int CustomerId { get; set; }

        public string RemarkDesc { get; set; }

        public int UserId { get; set; }

        public List<EntityIoLogs>  IoLogsList { get; set; }

        public EntityOrder()
        {
            OrderId = -1;
            OrderNo = "";
            OrderTypeId = -1;
            CustomerId = -1;
            RemarkDesc = "";
            UserId = -1;
        }
    }
}
