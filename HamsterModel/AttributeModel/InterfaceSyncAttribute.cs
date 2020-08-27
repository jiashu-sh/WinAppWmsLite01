using System;
using System.Collections.Generic;
using System.Text;

namespace HamsterModel.AttributeModel
{
    public class InterfaceSyncAttribute : Attribute
    {
        public string MsgType { set; get; }
    }
}
