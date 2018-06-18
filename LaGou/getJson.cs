using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace LaGou
{/// <summary>
/// 用于测试，没有什么用
/// </summary>
    class GetJson
    {
        public GetJson()
        {
            //FileStream fs = new FileStream(@"E:\getJson.txt", FileMode.Open);
            //StreamReader sr = new StreamReader(fs);
            //string getJson= sr.ReadToEnd();
            //Data_storage getjson = JsonConvert.DeserializeObject<Data_storage>(getJson);
            //Console.WriteLine(getjson.code);

            //method 2
            StreamReader sr = File.OpenText(@"E:\getJson.txt");
            string getJson = sr.ReadToEnd();
            JObject jo = JObject.Parse(getJson);
            string jo1 = (string)jo["content"]["positionResult"]["result"][2]["workYear"];
            Console.WriteLine(jo1);
        }
    }

}
