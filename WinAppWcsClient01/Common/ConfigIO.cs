using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppWmsLite.Common
{
    class ConfigIO
    {
        public static string GetConnectionString(string ConnectionName)
        {
            string connectionString = @"Data Source=" + Application.StartupPath + "\\" + ConfigurationManager.ConnectionStrings[ConnectionName].ConnectionString.ToString();

            if (CommonDa.GetDbType() == EnumDbTypes.PgSql)
                connectionString = ConfigurationManager.ConnectionStrings[ConnectionName].ConnectionString.ToString();

            return connectionString;
        }

        public static string GetAppConfig(string appConfigKey)
        {
            foreach (string key in ConfigurationManager.AppSettings)
            {
                if (key == appConfigKey)
                {
                    return ConfigurationManager.AppSettings[appConfigKey].ToString();
                }
            }
            return null;
        }
    }
}
