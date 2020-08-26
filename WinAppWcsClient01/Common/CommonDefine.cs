using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppWmsLite.Common
{
    public class CommonDefine
    {
        public enum RequestTypes : int //TypeId
        {
            Heartbeat = 1,
            Stop = 0,
            //20200117 jiashu 不需要底层目标，只需要停机或者设置移动目标的高层指令
            //GoForward = 2, 
            //GoBackword = 3,
            //Turning = 4,
            SetDestination = 5
        }

        public enum Orientation : int //Orientation
        {
            _Unknown = 0, //Unknow
            E = 1,              //East
            S = 2,              //South
            W = 3,              //West
            N = 4              //North
        }
    }
}
