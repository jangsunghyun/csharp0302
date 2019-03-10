using System;
using System.Threading;

namespace ThreadTest1
{
    class Program
    {
        public void firstWork()
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(1000);
                Console.Write("F{0} ", i);
            }
        }

        public void SecondWork()
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(1000);
                Console.Write("S{0} ", i);
            }
        }

        [MTAThread]
        public static void Main()
        {
            Program t = new Program();  //클래스 이름으로.. 

            Thread first = new Thread(t.firstWork);
            //                          new ThreadStart 삭제 가능
            Thread second = new Thread(new ThreadStart(t.SecondWork));  //델리게이트

            first.Priority = ThreadPriority.Lowest;
            second.Priority = ThreadPriority.Highest;

            first.Start();      second.Start();
        }
    }
}
