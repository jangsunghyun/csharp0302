using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linqex3
{
    class Program
    {
        static bool isEvent(int num)
        {
            return num % 2 == 0;
        }

        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6 };
            //                                  new Func <int, boll>  생략가능  델리게이트
            //IEnumerable<int> q1 = numbers.Where(new Func<int,bool>(isEvent)).OrderByDescending               (n => n);
                        //                                          람다식
            IEnumerable<int> q1 = numbers.Where(new Func<int, bool>(n=>n%2==0)).OrderByDescending(n => n);

            foreach (int i in q1) Console.Write(i + " ");

            Console.WriteLine();

            int sum = numbers.Where(num => num % 2 == 0).Sum();
            Console.WriteLine("sum = " + sum);

            int max = numbers.Where(num => num % 2 == 0).Max();
            Console.WriteLine("max =" + max);



            double avg = numbers.Where(num => num % 2 == 0).Average();
            Console.WriteLine("avg = " + avg);

            var result = numbers.Aggregate((a,b) => a*b);
            Console.WriteLine("Aggregate =" + result);

            result = numbers.Aggregate(10,(a,b) => a+b);
            Console.WriteLine("Aggregation with seed " + result);

            result = numbers.Where(num => num % 2 == 0).Aggregate((a,b)=> a*b);
            Console.WriteLine("Aggregation.where =" + result);

            Console.WriteLine("\n------------------");


        }
    }
}
