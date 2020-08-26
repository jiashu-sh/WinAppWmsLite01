using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppWmsLite.ResponseModel
{
    public class ResponseResult<T>
    {
        public T ResultContent { set; get; }

        public int ReturnCode { set; get; }
        public string Message { set; get; }
    }
}
