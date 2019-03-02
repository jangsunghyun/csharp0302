using System;

namespace TypeCastExample1
{
    class TypeCastExample1
    {
        public static void Main()
        {
            short a = 10;
            int b = a;
            int c = 50000;

            try
            {
                short d = checked((short)c);    //오버플로우 checked 
                Console.WriteLine("Short : {0}", d);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine(e.StackTrace);
            }

        }
    }
}
