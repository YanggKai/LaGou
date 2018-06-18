using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace LaGou
{
    class FileStreamTest
    {
        public FileStreamTest()
        {
            string getSw = null;
            FileStream fs = new FileStream(@"E:\Test.txt", FileMode.Open);
            StreamWriter sw = new StreamWriter(fs);
            for (int i = 0; i < 10; i++)
            {
                getSw = i.ToString();
               
            }
            sw.Write(getSw);
            sw.Dispose();

        }
    }
}
