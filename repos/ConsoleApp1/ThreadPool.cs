using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleApp1
{
    class ThreadPool
    {

        static Mutex mutex = new Mutex();
          

        public static void CallToChildThread()
        {
            Console.WriteLine("Child thread starts");
        }

        public static void ExeThread()
        {
            Thread th = Thread.CurrentThread;
            th.Name = "MainThread";
            Console.WriteLine("This is {0}", th.Name);
           
            Thread subThread = new Thread(delegate ()
            {
                Console.WriteLine("sub thread is starting");
            });
            subThread.Start();

            Console.ReadKey();
        }


        public static void Play()
        {
            Thread[] thread = new Thread[3];
            for (int i = 0; i < 3; i++)
            {
                thread[i] = new Thread(ThreadMethod1);
                thread[i].Name = i.ToString();
            }
            for (int i = 0; i < 3; i++)
            {
                thread[i].Start();
            }
            Console.ReadKey();
        }

        public static void ThreadMethod1(object val)
        {
            mutex.WaitOne();　　　　//获取锁
            for (int i = 0; i < 500; i++)
            {
                Console.Write(Thread.CurrentThread.Name);
            }
            mutex.ReleaseMutex();  //释放锁
        }


    }
}
