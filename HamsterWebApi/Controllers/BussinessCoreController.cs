using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HamsterCode;
using HamsterModel;
using HamsterModel.AttributeModel;
using HamsterModel.WebApiModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace HamsterWebApi.Controllers
{
    [Route("api/BussinessService")]
    [ApiController]
    public class BussinessCoreController : HamsterWebApiController
    {
        public BussinessCoreController(IOptions<ConnectionConfig> connectConfig) : base(connectConfig)
        { }

        /// <summary>
        /// 统一入口 (HelloWord 1)
        /// </summary>
        /// <param name="msgObj"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post([FromForm]BaseYiKuActiveMsg msgObj)
        {
            var requestId = Guid.NewGuid().ToString();
            var requestStr = Newtonsoft.Json.JsonConvert.SerializeObject(msgObj);
            WriteLogCore.SingleInstance.WriteApiLog(requestId, msgObj.msg_type, requestStr, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            HamsterCore core = new HamsterCore();
            var result = core.lst_myDelegate.First(x => (x.Method.GetCustomAttributes(false).First() as InterfaceSyncAttribute).MsgType == msgObj.msg_type)(msgObj.logistics_interface);
            WriteLogCore.SingleInstance.WriteApiLog(requestId, msgObj.msg_type, result, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            return Ok(result);
        }

        [HttpGet]
        [Route("CallBack")]
        public IActionResult CallBack()
        {
            var CallBackStr = HelloWordCore.Instance.HelloWordVoid("HelloWord!!");
            var result = Newtonsoft.Json.JsonConvert.SerializeObject(CallBackStr);
            //HttpResponseMessage response = new HttpResponseMessage
            //{
            //    RequestMessage = new StringContent(result, Encoding.GetEncoding("UTF-8"), "application/json")
            //};
            return Ok(result);
        }
    }
}