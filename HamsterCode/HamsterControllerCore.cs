using System;
using System.Collections.Generic;
using System.Text;

namespace HamsterCode
{
    public delegate string HamsterCoreDelegate(string logistics_interface);
    public class HamsterCore
    {
        public List<HamsterCoreDelegate> lst_myDelegate { set; get; }

        public HamsterCore()
        {
            lst_myDelegate = new List<HamsterCoreDelegate>();
            //(HelloWord 2)将方法后台加入到委托 
            lst_myDelegate.Add(HelloWordCore.Instance.HelloWordVoid);
        }
    }
}
