using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WinAppWmsLite.HttpComm
{
    class HttpClientUtil
    {
        private readonly HttpClient _httpClient;

        private const string DefaultUri = @"http://192.168.3.250/WebAppRbtSrv01/api/values/";
        public HttpClientUtil(HttpClient httpClient)
        {
            this._httpClient = httpClient;
            this._httpClient.BaseAddress = new Uri(DefaultUri);
            this._httpClient.Timeout = TimeSpan.FromSeconds(30);
        }

        public async Task<string> GetHeartbeatReturn(string paraHeartbeat)
        {
            var data = await this._httpClient.GetAsync(paraHeartbeat);
            var result = await data.Content.ReadAsStringAsync();

            return result;
        }

        internal string GetHttpReturn(string sParaHeartbeat)
        {
            string sGetHttpReturn = "";
            try
            {
                string sUrl = DefaultUri + sParaHeartbeat;
                HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(sUrl);
                req.Method = "GET";
                req.ContentType = "application/x-www-form-urlencoded";
                req.Timeout = 3000;//单位毫秒

                WebResponse wr = req.GetResponse();
                Stream rs = wr.GetResponseStream();
                Encoding encode = System.Text.Encoding.GetEncoding("utf-8");
                StreamReader rsp = new StreamReader(rs, encode);
                string rsp_cnt = rsp.ReadToEnd();
                rsp.Close();

                sGetHttpReturn = rsp_cnt;
                //JObject json = (JObject)JsonConvert.DeserializeObject(rsp_cnt);                
            }
            catch (Exception ex)
            {
                sGetHttpReturn = "error:" + ex.Message;
                //MessageBox.Show("错误信息:\r\n" + ex.Message, "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return sGetHttpReturn;
        }

    }
}
