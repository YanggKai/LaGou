using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace LaGou
{

    public class RegexMethod
    {
        /// <summary>
        /// 使用获取json中的数据，然后挖数据
        /// </summary>
        /// <param name="keyWord"></param>
        public  void GetID(object keyWord)
        {
            FileStream fs = new FileStream(@"E:\Project\DateOfCrawler\" + keyWord+".txt", FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs);

            bool isOver = false;//用于判断是否结束
            saveData s = new saveData();
            for (int i = 30; ; i++)
            {
                //string[] ProxyIp = new string[] { "http://115.46.96.87:8123", "http://113.128.26.149:22096", "218.73.129.163	49799", "125.78.6.69	37342",
                //"123.163.162.171:808","115.215.49.130	33329"};
                string getJson = "https://www.lagou.com/jobs/positionAjax.json?px=default&needAddtionalResult=false&pn=" + i + "&kd=" + keyWord;

                ////正常输出
                string json = GetUrl.GetData(getJson);


                for (int j = 0; j < 15; j++)
                {

                    try
                    {
                        JObject jsonData = JObject.Parse(json);
                        s.CompanyShortName = (string)jsonData["content"]["positionResult"]["result"][j]["companyShortName"];
                        s.Education = (string)jsonData["content"]["positionResult"]["result"][j]["education"];
                        s.WorkYear = (string)jsonData["content"]["positionResult"]["result"][j]["workYear"];
                        s.Salary = (string)jsonData["content"]["positionResult"]["result"][j]["salary"];
                        s.PositionName = (string)jsonData["content"]["positionResult"]["result"][j]["positionName"];
                        s.City = (string)jsonData["content"]["positionResult"]["result"][j]["city"];
                        s.CompanySize = (string)jsonData["content"]["positionResult"]["result"][j]["companySize"];
                    }


                    catch(NullReferenceException)
                    {
                        continue;
                    }
                    catch(JsonReaderException)
                    {
                        continue;
                    }
                    catch (ArgumentOutOfRangeException)//越界异常
                    {
                        isOver = true;
                        continue;

                    }

                    //console into 
                    Console.Write(s.City + "," + s.CompanyShortName + "," + s.Education + "," +
                        s.WorkYear + "," + s.Salary + "," + s.PositionName + "," + s.CompanySize);

                    //write into dotnet.txt
                    sw.Write("1,"+keyWord + "," + s.City + "," + s.CompanyShortName + "," + s.Education + "," +
                        s.WorkYear + "," + s.Salary + "," + s.PositionName + "," + s.CompanySize + "\r\n");
                    Console.WriteLine();
                }
                if (isOver)
                {
                    sw.Dispose();
                    Console.WriteLine("抓取完成");
                    break;
                }

            }

        }
    }
}

