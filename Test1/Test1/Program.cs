using System;
namespace Test1
{
    class Tester
    {
        private int m = 88, n = 99;

        Tester(int m = 0, int n = 0)    //class 이름과 똑같이 Tester 를 이용 생성자..
        {
            this.m = m; this.n = n;
        }

        //선택적 매개 변수
        static int Sum(int i =0, int j =0)
        {
            return i + j;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Sum(1, 2));
            Console.WriteLine(Sum(j:7));
            Console.WriteLine(Sum());

            Tester t1 = new Tester();
            Console.WriteLine("m={0}, n={1}", t1.m, t1.n);

            Tester t2 = new Tester(1, 2);
            Console.WriteLine("m={0}, n={1}", t2.m, t2.n);
        }
    }
}


namespace Test
{
    class Tester
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Minus(1, 2));
            Console.WriteLine(Minus(1));
            Console.WriteLine(Minus(i:8, j:9));
            Console.WriteLine(Minus(j: 8, i: 9));
            Console.WriteLine(Minus());
        }

        static int Minus(int i = 0, int j = 0)
        {
            return i = j;
        }
    }
}
