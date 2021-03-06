﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ThreadTest3Lockex
{
    class Program
    {

        public string lockString = "Hello";
        //private object obj = new object();
        private static Mutex mutex = new Mutex();

        public void Print(string rank)
        {
            //lock (obj)
            //Monitor.Enter(obj);
            //{
            mutex.WaitOne();
                for (int i= 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        Thread.Sleep(100);
                        Console.Write(",");
                    }

                    Console.WriteLine("{0}(1)", rank, lockString);
                }
            //}
            //Monitor.Exit(obj);
            mutex.ReleaseMutex();
        }

        public void FirstWork() { Print("F"); }
        public void SecondWork() { Print("S"); }
    }

    class TestMain
    {
        [MTAThread]
        public static void Main()
        {
            Program t = new Program();
            Thread first = new Thread(new ThreadStart(t.FirstWork));
            Thread second = new Thread(new ThreadStart(t.SecondWork));

            first.Start();
            second.Start();
        }
    }
}
