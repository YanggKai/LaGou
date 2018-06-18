using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace LaGou
{
    /// <summary>
    /// 用于下载指定连接中的数据
    /// </summary>
    public class GetUrl
    {
        public static string GetData(string url)
        {
            string sr = null;
            try
            {
                HttpWebRequest request = HttpWebRequest.CreateHttp(url);
                //WebProxy proxy = new WebProxy();
                //proxy.Address = new Uri(setIp);
                //request.Proxy = proxy;
                request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/66.0.3359.139 Safari/537.36";
                request.Referer = "https://www.lagou.com/jobs/list_%20.net?labelWords=&fromSearch=true&suginput=";
                request.KeepAlive = true; 
                request.Method = "POST";
               // request.Timeout = 3000;

                Thread.Sleep(10000);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream getData = response.GetResponseStream();

                 sr = new StreamReader(getData).ReadToEnd();
            }
            catch
            {
                Console.WriteLine("没有网络");
            }
            
            return sr;
        }
    }
}
