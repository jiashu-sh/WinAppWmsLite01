﻿using HamsterModel.AttributeModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace HamsterCode
{
    public class HelloWordCore
    {
        private HelloWordCore()
        {
            sqlLiteConnectionStr = new MySqlHelper(ConnectionConfig.ConnectionConfigModel.MySqlConfig.ConnectionStr);
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

        [InterfaceSyncAttribute(MsgType = "HelloWordVoid")]
        public string HelloWordVoid(string logistics_interface)
        {
            var result = logistics_interface;
            return result;
        }
    }
}
