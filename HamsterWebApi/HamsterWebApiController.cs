using HamsterModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HamsterWebApi
{
    public class HamsterWebApiController : ControllerBase
    {
        public HamsterWebApiController(IOptions<ConnectionConfig> connectConfig)
        {
            if (ConnectionConfig.ConnectionConfigModel == null)
            {
                ConnectionConfig.ConnectionConfigModel = connectConfig.Value;
            }
        }
    }
}
