﻿using System;

namespace 연산자실습
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(+3);
            Console.WriteLine(3 + 3);
            Console.WriteLine(3 + .3);
            Console.WriteLine("3" + "3");
            Console.WriteLine(3.0 + "3");

            Console.WriteLine(!true);

            byte x = 10;
            Console.WriteLine(~x);

            Console.WriteLine(unchecked((short)50000));
        }

    }
}
