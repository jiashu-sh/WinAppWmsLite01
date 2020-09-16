using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppWmsLite.WhOperate.FormOpSendingCore
{
    public class OpShippingCoreBase
    {
        private FormOpShipping Form { set; get; }

        public OpShippingCoreBase(FormOpShipping _form)
        {
            this.Form = _form;
        }


    }
}
