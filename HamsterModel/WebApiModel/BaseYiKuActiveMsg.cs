using System;
using System.Collections.Generic;
using System.Text;

namespace HamsterModel.WebApiModel
{
    public class BaseYiKuActiveMsg
    {
        public string msg_id { set; get; }
        public string logistics_interface { get; set; }
        public string logistic_provider_id { get; set; }
        public string msg_type { get; set; }
        public string data_digest { get; set; }
        public string from_code { set; get; }
        public string to_code { get; set; }
        public string partner_code { set; get; }
    }
}
