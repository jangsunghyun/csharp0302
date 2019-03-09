﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Ex2
{
    class Program
    {
        static bool MyWhere(int n) { return n % 2 == 1; }

        static void Main(string[] args)
        {
            int[] scores = { 30, 54, 64, 54, 99, 11 };

            //int oddScoreSum = scores.Where(MyWhere).Sum();
            //int oddScoreSum = scores.Where(new Func<int,bool>(n => n % 2 ==1)).Sum();
            //int oddScoreSum = scores.Where(new Func<int,bool>(MyWhere)).Sum();
            int oddScoreSum = scores.Where(n => n % 2 == 1).Sum();
            Console.WriteLine("{0} 홀수의합", oddScoreSum);

            int oddCount = scores.Where(n => n % 2 == 1).Count();
            Console.WriteLine("{0} 홀수의개수", oddScoreSum);

            int Count = scores.Where(n => n >50).Count();
            Console.WriteLine("{0} 50보다큰수의개수", Count);

            int Max = scores.Max();
            Console.WriteLine("{0} 배열의 최대값", Max);

            int Min = scores.Min();
            Console.WriteLine("{0} 배열의 최소값", Min);


        }
    }
}
