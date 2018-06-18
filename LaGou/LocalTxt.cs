using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace LaGou
{
    /// <summary>
    /// 使用正则表达式，但是出现问题，已弃用这个方法
    /// </summary>
    class LocalTxt
    {
        public static  string InvokeReader()
        {
            FileStream fs = new FileStream(@"E:\Source.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string getData = sr.ReadToEnd();
            return getData;
        }
        public static void UseRegex()
        {
            string Jpattern = "'companyShortName':'(.*?)'|'education':'(.*?)'|'workYear':'(.*?)'|'city':'(.*?)'|'salary':'(.*?)'|'positionName':'([^\\s]+)','companySize':'(.*?)'".Replace("'", "\"");
            var match = Regex.Matches(InvokeReader().ToString(), Jpattern);
            foreach (Match m in match)
            {
                for (int t = 1; t < 8; t++)
                {
                    if (!string.IsNullOrEmpty(m.Groups[t].Value))
                    {
                        Console.Write(m.Groups[t].Value + ",");
                        while (t == 7)
                        {
                            Console.WriteLine();
                            break;
                        }
                    }
                }
            }
        }
    }

}
