//1. 임의의 수를 콤마로 구분해서 Console.ReadLine() 으로 입력 받은 후 델리게이트를
// 이용하여 사칙연산을 구하는 프로그램을 델리게이트 체인 및 델리게이트 멀티 캐스팅을
// 이용하여 구현하세요.  page 153
using System;

namespace Delegate_Lab1
{
    delegate void OnjDelegate(int a, int b);

    class Delegate_Lab1
    {
        static void Plus(int a, int b)
        {
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
        }
        static void Minus(int a, int b)
        {
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
        }
        void Multiplication(int a, int b)
        {
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
        }
        void Division(int a, int b)
        {
            Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("두수를 입력하세요.");
            Console.WriteLine("예 : 3,5");
            string str = Console.ReadLine();
            str.Trim();
            string[] strarr = str.Split(',');
            if (strarr.Length != 2)
            {
                Console.WriteLine("숫자2개를 콤마로 구분해서 입력하세요~");
                return;
            }            Delegate_Lab1 m = new Delegate_Lab1();            OnjDelegate CallBack = Delegate_Lab1.Plus;
            CallBack += Delegate_Lab1.Minus;
            CallBack += m.Multiplication;
            CallBack += m.Division;

            CallBack(Convert.ToInt32(strarr[0]), Convert.ToInt32(strarr[1]));
        }
    }
}
