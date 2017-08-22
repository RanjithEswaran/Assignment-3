using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadNameWithoutSynch
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadDemo t = new ThreadDemo();
            Thread thread1 = new Thread(t.Run);
            thread1.Name = "Thread1";
            Thread thread2 = new Thread(t.Run);
            thread2.Name = "Thread2";
            Thread thread3 = new Thread(t.Run);
            thread3.Name = ("Thread3");

            thread1.Start(thread1.Name);
            thread2.Start(thread2.Name);
            thread3.Start(thread3.Name);

            Console.ReadLine();
        }
    }
    class ThreadDemo
    {
        public void Run(Object c)
        {
            lock (this)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("The thread Name : {0}", c);
                    Thread.Sleep(2000);
                }
            }
        }
    }
}
