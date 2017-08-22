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
            Thread thread1 = new Thread(ThreadDemo.Run);
            thread1.Name = "Thread1";
            Thread thread2 = new Thread(ThreadDemo.Run);
            thread2.Name = "Thread2";
            Thread thread3 = new Thread(ThreadDemo.Run);
            thread3.Name=("Thread3");
            thread1.Start(thread1.Name);
            thread2.Start(thread2.Name);
            thread3.Start(thread3.Name);
            Console.ReadLine();
        }
    }
    public class ThreadDemo
    { 
      public  static void Run(Object c)
        {
            for(int i=0;i<5;i++)
            {
                Console.WriteLine("The thread Name : {0}",c);
                Thread.Sleep(2000);
            }
        }
    }
}
