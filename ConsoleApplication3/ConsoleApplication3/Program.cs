﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApplication3
{
    class Program
    {
        static int mysum = 0;
        static void Sum(object n)
        {
            int sum = 0;
            int[] number = (int[])n;
            for (int i = number[0]; i <= number[1]; i++)
            {
                sum += i;
            }
            mysum += sum;
        }
            
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ParameterizedThreadStart(Sum));
            Thread t2 = new Thread(new ParameterizedThreadStart(Sum));
            Thread t3 = new Thread(new ParameterizedThreadStart(Sum));
            Thread t4 = new Thread(new ParameterizedThreadStart(Sum));
            Thread t5 = new Thread(new ParameterizedThreadStart(Sum));

            t1.Start(new int[] {1,10}); t2.Start(new int[] { 11, 20 });
            t3.Start(new int[] { 21, 30 }); t4.Start(new int[] { 31, 40 }); t5.Start(new int[] { 41, 50 });
            t1.Join(); t2.Join(); t3.Join(); t4.Join(); t5.Join(); //join 독립 메소드..   


            //Thread t1 = new Thread(new ThreadStart(() => Sum(new int[] { 1, 10 })));
            //Thread t2 = new Thread(new ThreadStart(() => Sum(new int[]{11, 20 })));
            //Thread t3 = new Thread(new ThreadStart(() => Sum(new int[] { 21, 30 })));
            //Thread t4 = new Thread(new ThreadStart(() => Sum(new int[] { 31, 40 })));
            //Thread t5 = new Thread(new ThreadStart(() => Sum(new int[] { 41, 50 })));

            //t1.Start(); t2.Start(); t3.Start(); t4.Start(); t5.Start();
            //t1.Join(); t2.Join(); t3.Join(); t4.Join(); t5.Join(); //join 독립 메소드..   
            //join 은 각 계산이 끝날때까지 기다렸다가 sum합을 구한다. 

            Console.WriteLine("1부터 50까지의 합은 {0}::",mysum);

        }
    }
}
