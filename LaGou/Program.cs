using System;
using System.Threading;

namespace LaGou
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestNewJson tnj = new TestNewJson();
            //  GetJson gj = new GetJson();
            RegexMethod rm = new RegexMethod();
            Thread t1 = new Thread(new ParameterizedThreadStart(rm.GetID));
            //Thread t2 = new Thread(new ParameterizedThreadStart(rm.GetID));
            //Thread t3 = new Thread(new ParameterizedThreadStart(rm.GetID));
            //Thread t4 = new Thread(new ParameterizedThreadStart(rm.GetID));
            //Thread t5 = new Thread(new ParameterizedThreadStart(rm.GetID));
            //Thread t6 = new Thread(new ParameterizedThreadStart(rm.GetID));

            //t1.Start("python");
            //t2.Start("java");
            //t3.Start(".net");
            t1.Start("java");
            //t5.Start("html5");
            //t6.Start("语音识别");
            //ForeachTest f = new ForeachTest();
            Console.ReadKey();
        }
        
    }

}
