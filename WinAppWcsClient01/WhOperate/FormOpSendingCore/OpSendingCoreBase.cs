using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppWmsLite.WhOperate.FormOpSendingCore
{
    public class OpSendingCoreBase
    {
        private FormOpSending Form { set; get; }

        public OpSendingCoreBase(FormOpSending _form)
        {
            this.Form = _form;
        }


    }
}
