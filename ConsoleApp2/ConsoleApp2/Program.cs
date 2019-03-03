using System;
namespace ConsoleApplication2
{
    class Program
    {
        static void Swap(out int a, out int b)
        {
            int tmp = a; a = b; b = tmp;
        }

        static void Main(string[] args)
        {
            //int a = 10;
            //int b = 20;

            Console.WriteLine("a={0}, b={1}", a, b);

            //ref 원복 주소값을 넘긴다. 
            //ref는 기본 변수값에 초기화 값이 들어가 있어야 한다.
            //Swap(ref a, ref b);

            //out은 변수 선언만 되어 있어야 한다. out도 주소를 넘긴다.
            //out은 초기화 하면 안됨
            int a, b;
            Swap (out a, out b)

            Console.WriteLine("a={0}, b={1}", a, b);
        }
    }
}