using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine(Sum(1, 2));
        //    Console.WriteLine(Sum(1,2,3));
        //    Console.WriteLine(Sum(new int[] { 1,2,3,4,5}));
        //}

        //static int Sum(params int[] iArr) {
        //    int s = 0;
        //    foreach (int num in iArr)
        //        s += num;
        //    return s;
        //}

        static void Main(string[] args)
        {
            Console.WriteLine(Sum(j:1, i:2));    //명령된 인수  j:
            Console.WriteLine(Sum(1))
        }

        static int Sum(int i=0, int j=0)  //값 안주면 0으로받아라. 선택적 인수
        {
            return i + j;
        }
    }
}
