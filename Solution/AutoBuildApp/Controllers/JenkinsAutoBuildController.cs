using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Web;

namespace AutoBuildApp
{
    public class JenkinsAutoBuildController
    {
        

        public static void BuildJenkinsJob()
        {
            var url = JenkinsUserModel.base_url + "/job/esb.Beisen.PerformanceCloud.ServiceImp/buildWithParameters/api/json?GIT_BRANCH=refs/heads/dev_sprint19";
            
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
            request.Method = "POST";
            request.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(Encoding.UTF8.GetBytes($"{JenkinsUserModel.username}:{JenkinsUserModel.token}")));
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        }




        static class JenkinsUserModel
        {
            public static string username = "chenjianrui";

            public static string token = "5cceeef8b34d0ef74da9cd8f75bc0d9e";

            public static string base_url = "http://jci.beisencorp.com";

            public static string build_url = "";
        }


    }
}
