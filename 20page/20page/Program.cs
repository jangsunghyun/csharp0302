using System;

namespace _20page
{
    class Bitoper
    {
        static void Main(string[] args)
        {
            int i = 10;  int j = 20;    int a;
            a = i & j; i = i >> 3; j = i << 3;
            Console.WriteLine("a={0}, j={2}", a, i, j);
            Console.ReadLine();
        }
    }



    class LogicalAnd
    {
        static void main()
        {
            Console.WriteLine("정상적인 AND:");
            if (Method1() & Method2()) //& 연산자는 한개가 거짓이여도 다른 한개를 체크한다.
                Console.WriteLine("Both methods returned true.");
            else
            {
                Console.WriteLine("둘중 하나의 메소드는 false");

                Console.WriteLine("\n Short-circuit ADN:");
                if (Method1() && Method2())  // && 연산자는 한개가 거짓이면 다른 한개 체크 안함..
                    Console.WriteLine("Both methods returned ture");
                else
                    Console.WriteLine("둘중 ㅏ나의 메소드는 false");
            }
            Console.WriteLine("0x{0:x}", 0xf8 & 0x3f);
        }
        static bool Method1()
        {
            Console.WriteLine("메소드1...");
            return false;
        }

        static bool Method2()
        {
            Console.WriteLine("메소드2...");
            return true;
        }
    }

}
