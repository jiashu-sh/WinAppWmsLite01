using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppWmsLite.Common
{
    public static class WMSClientCommon
    {
        /// <summary>
        /// 非字符串类型返回0
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static int ConvertToInt(string str)
        {
            int result = 0;
            if (int.TryParse(str, out result))
            {
                return result;
            }
            else { return 0; }
        }

        public static bool IsNumber(this string str)
        {
            int result = 0;
            if (int.TryParse(str, out result))
            {
                return true;
            }
            else { return false; }
        }

        public static bool IsDecimal(this string str)
        {
            decimal result = 0;
            if (decimal.TryParse(str, out result))
            {
                return true;
            }
            else { return false; }
        }

        public static int DataColumnToInt(this object str)
        {
            if (Convert.IsDBNull(str)) { return 0; }
            return Convert.ToInt32(str);
        }

        public static decimal DataColumnToDecimal(this object str)
        {
            if (Convert.IsDBNull(str)) { return 0; }
            return Convert.ToDecimal(str);
        }


        public static string DataColumnToString(this object str)
        {
            if (Convert.IsDBNull(str)) { return ""; }
            return (str ?? "").ToString();
        }

        public static DateTime? DataColumnToDateTime(this object str)
        {
            if (Convert.IsDBNull(str)) { return null; }
            return Convert.ToDateTime(str);
        }
    }
}
