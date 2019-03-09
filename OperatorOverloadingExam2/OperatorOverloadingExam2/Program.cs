using System;

namespace OperatorOverloadingExam2
{

        public class Adder1
        {
            public int val;
            public static Adder3 operator +(Adder1 a1, Adder2 a2)
            {
                Adder3 a3 = new Adder3();
                a3.Val = a1.Val + a2.Val;
                return a3;
            }

            public int Val
            {
                get;
                set;
            }
        }

        public class Adder2
        {
            public int Val
            {
                get;
                set;
            }
        }
        public class Adder3 
        {
            public int Val
            {
                get;
                set;
            }
        }


    class Program
    {
        static void Main(string[] args)
        {
            Adder1 a1 = new Adder1(); a1.val = 1;
            Adder2 a2 = new Adder2(); a2.Val = 2;
            Adder3 a3 = a1 + a2;
            Console.WriteLine(a3.Val);
        }
    }
}
