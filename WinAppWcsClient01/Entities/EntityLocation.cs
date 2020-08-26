using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppWmsLite.Entities
{
    class EntityLocation
    {
        public string LocationNo { get; set; }

        public string ShelfNo { get; set; }

        public string AbcClass { get; set; }

        public string LocationDesc { get; set; }

        public string RemarkDesc { get; set; }

        public int UserId { get; set; }

        public EntityLocation()
        {
            LocationNo = "";
            ShelfNo = "";
            AbcClass = "C";
            LocationDesc = "";
            RemarkDesc = "";
            UserId = -1;
        }
    }
}
