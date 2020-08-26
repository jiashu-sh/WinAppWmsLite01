using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppWmsLite.ResponseModel
{
    public class EntityReturnError
    {
        public string ErrorMessage { get; set; } //ErrorMessage

        public int ErrorCode { get; set; } //ErrorCode

        public EntityReturnError()
        {
            ErrorCode = 1001;
            ErrorMessage = "未定义的错误";
        }

        public EntityReturnError(int iErrorId)
        {
            if (0 == iErrorId)
            {
                ErrorCode = 0;
                ErrorMessage = "成功完成";
            }
            if (1 == iErrorId)
            {
                ErrorCode = 1;
                ErrorMessage = "ack";
            }
        }
    }
}
