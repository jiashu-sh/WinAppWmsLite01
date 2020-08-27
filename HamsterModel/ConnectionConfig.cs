using System;
using System.Collections.Generic;
using System.Text;

namespace HamsterModel
{
    public class ConnectionConfig
    {
        public static ConnectionConfig ConnectionConfigModel;
        public ConnectDetailSettings PostgreSqlConfig { get; set; }

        public ConnectDetailSettings MySqlConfig { get; set; }

        public ConnectDetailSettings MsSqlConfig { get; set; }

        public ConnectDetailSettings SqlLiteConfig { get; set; }
    }

    public class ConnectDetailSettings
    {
        /// <summary>
        /// 连接字符串
        /// </summary>
        public string ConnectionStr { set; get; }
        /// <summary>
        /// 批量操作每批次记录数
        /// </summary>
        public int BatchSize { set; get; }

        /// <summary>
        /// 超时时间
        /// </summary>
        public int CommandTimeOut { set; get; }
    }
}
