using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace AutoBuildApp.Controllers
{
    public class MonitorPackageController
    {
        public static MonitorPackageController Instance = new MonitorPackageController();

        public static CookieContainer cookieContainer = new CookieContainer();

        public const string session_key = "ASP.NET_SessionId";
        public string Login()
        {
            var url = MonitorPackageUrl.Base_Url + MonitorPackageUrl.Login_Url;
            HttpWebRequest request = HttpWebRequest.CreateHttp(url);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.CookieContainer = cookieContainer;
            BuildCookie();

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("&{0}={1}", "username", "chenjianrui");
            stringBuilder.AppendFormat("&{0}={1}", "password", "Jian031018");
            stringBuilder.AppendFormat("&{0}={1}", "logintype", "0");
            stringBuilder.AppendFormat("&{0}={1}", "isremember", "true");

            byte[] buffer = Encoding.UTF8.GetBytes(stringBuilder.ToString().Trim('&'));
            Stream requestStream = request.GetRequestStream();
            requestStream.Write(buffer, 0, buffer.Length);
            requestStream.Close();
            WebResponse response = request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
            return reader.ReadToEnd();
        }

        public void GetMachinceTree()
        {
            var url = MonitorPackageUrl.Base_Url + MonitorPackageUrl.GetTree_Url;
            HttpWebRequest request = HttpWebRequest.CreateHttp(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.CookieContainer = cookieContainer;
            BuildCookie();

            WebResponse response = request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
            var result = reader.ReadToEnd();
        }

        public void GetESBComponentDetails()
        {
            var url = MonitorPackageUrl.Base_Url + MonitorPackageUrl.GetComponentsDetail_Url + "?farmName=PerformanceCloud&componentName=ESB.Components.PerformanceCloud.PerformanceCloud&regionEnglishName=PerformanceCloudNew&cloudAppName=PerformanceCloud&cluster=PerformanceCloud";
            HttpWebRequest request = HttpWebRequest.CreateHttp(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.CookieContainer = cookieContainer;
            BuildCookie();

            WebResponse response = request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
            var result = reader.ReadToEnd();
        }

        public void GetESBComponentDetailStatus()
        {
            var url = MonitorPackageUrl.Base_Url + MonitorPackageUrl.GetESBComponentDetailStatus_Url + "?farmName=PerformanceCloud&componentName=ESB.Components.PerformanceCloud.PerformanceCloud&regionEnglishName=PerformanceCloudNew&cloudAppName=PerformanceCloud&cluster=PerformanceCloud";
            HttpWebRequest request = HttpWebRequest.CreateHttp(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.CookieContainer = cookieContainer;
            BuildCookie();

            WebResponse response = request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
            var result = reader.ReadToEnd();
        }

        /// <summary>
        /// 构建cookie，用于维护状态
        /// </summary>
        private void BuildCookie()
        {
            var cookie = new Cookie("ASP.NET_SessionId", "0y23spf1rdzrqmvlzg0yz4c2");
            var usernameCookie = new Cookie("UserName", "chenjianrui");
            cookieContainer.Add(new Uri("http://dev.mstools.beisen.net"), cookie);
            cookieContainer.Add(new Uri("http://dev.mstools.beisen.net"), usernameCookie);
        }

        class MonitorPackageUrl
        {
            public const string Base_Url = "http://dev.mstools.beisen.net";

            public const string Login_Url = "/Account/Login";

            public const string GetTree_Url = "/Monitor/GetTree?ishotfixpage=true";

            public const string GetComponentsDetail_Url = "/Monitor/GetESBComponentDetails";

            public const string GetESBComponentDetailStatus_Url = "/Monitor/GetESBComponentDetailStatus";
        }

        class LoginFormModel
        {
            public string username { get; set; }
            public string password { get; set; }
            public int logintype { get; set; }
            public bool isremember { get; set; }
        }

    }
}
