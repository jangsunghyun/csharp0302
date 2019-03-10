using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadTest2
{
    public class test
    {
        public bool sleep = false;

        //차단기가 내려간 상태
        static AutoResetEvent autoEvent = new AutoResetEvent(false);

        public void FirstWork()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("F{0}", i);

                if(i == 5 )
                {
                    sleep = true;
                    Console.WriteLine("");
                    Console.WriteLine("first 쉽...");
                    //Thread.CurrentThread.Suspend(); 
                    autoEvent.WaitOne(); //잠시대기 상태
                }
            }

        }

        static void Main(string[] args)
        {
            test t = new test();
            Thread first = new Thread(new ThreadStart(t.FirstWork));
            first.Start();
            while (t.sleep == false) { }

            Console.WriteLine("first를 깨웁니다... 2초후 깨어납니다.");
            Thread.Sleep(2000);
            //first.Resume();  //Suspend 를 깨워주는 명령어 Resume
            autoEvent.Set();
        }
    }
}
