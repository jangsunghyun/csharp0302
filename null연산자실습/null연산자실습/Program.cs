using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace null연산자실습 //22page
{
    class Program
    {
        static void Main()
        {
            //Nullable Type, a 가 NULL 을 허용한다는 의미   원칙상 int는 null를 받아 들이지 않는다.
            int? a = null;
            //int b = a.Value;     // a.Value 값 자체가 null 이므로 int? b 도 오류 
            //Console.WriteLine("Value of b is {0}", b); 


            int b;
            if (a.HasValue) b = a.Value;
            else b = 0;
            Console.WriteLine("Value of b is{0}", b);

            int c = a ?? 0; //?? 은 null결합 연산자
            Console.WriteLine("Value of c is {0}", c);
            Console.ReadLine();
        }
    }
}
