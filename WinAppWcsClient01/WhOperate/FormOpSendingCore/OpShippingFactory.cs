using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppWmsLite.WhOperate.FormOpSendingCore
{
    public class OpShippingFactory
    {
        private OpShippingCoreBase OpShippingFormCore { set; get; }

        public OpShippingCoreBase GetOpShippingCoreBase(string orderNo, FormOpShipping form)
        {
            return new OpShippingCoreBase(form);
        }
    }
}
