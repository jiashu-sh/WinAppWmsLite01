using System;
using System.Collections.Generic;
using System.Text;

namespace HamsterCode
{
    public class WriteLogCore
    {
        public static WriteLogCore SingleInstance
        {
            get { return new WriteLogCore(); }
        }

        /// <summary>
        /// 记录日志
        /// </summary>
        /// <param name="requestId"></param>
        /// <param name="msg_type"></param>
        /// <param name="Content"></param>
        /// <param name="timeStr"></param>
        public void WriteApiLog(string requestId, string msg_type, string Content, string timeStr)
        {

        }
    }
}
