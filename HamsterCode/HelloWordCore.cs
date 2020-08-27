using HamsterModel;
using HamsterModel.AttributeModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace HamsterCode
{
    public class HelloWordCore
    {
        private HelloWordCore()
        {
            //(HelloWord 3-1)拿配置文件
            sqlLiteConnectionStr = ConnectionConfig.ConnectionConfigModel.SqlLiteConfig.ConnectionStr;
        }
        private string sqlLiteConnectionStr;

        private static HelloWordCore _instance = new HelloWordCore();

        public static HelloWordCore Instance
        {
            get
            {
                return _instance;
            }
        }

        /// <summary>
        /// (HelloWord 3-2)后台方法 
        /// </summary>
        /// <param name="logistics_interface"></param>
        /// <returns></returns>
        [InterfaceSyncAttribute(MsgType = "HelloWordVoid")]
        public string HelloWordVoid(string logistics_interface)
        {
            var result = logistics_interface + "||" + sqlLiteConnectionStr;
            return result;
        }
    }
}
