using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadCurrentTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(MyThread);
            t.Start();
            Console.ReadLine();
        }
        public static void MyThread()
        {
            for(int i=0;i<10;i++)
            {
                Console.WriteLine(" Current Time : {0}", DateTime.Now);
                Thread.Sleep(2000);
            }
        }
    }
}
