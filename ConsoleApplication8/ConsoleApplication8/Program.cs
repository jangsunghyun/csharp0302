﻿using System;

namespace ConsoleApplication8
{
    class MyBaseClass
    {
        public MyBaseClass()
        {
            Console.WriteLine(">>> MyBaseClasee()");
        }
        public MyBaseClass(int i)
        {
            Console.WriteLine(">>> MyBaseClasee(int i)");
        }

    }

    class MyClass : MyBaseClass
    {
        public MyClass()
        {
            /////////////////////////////
            Console.WriteLine(">>> MyClass()");
        }
        public MyClass(int i) : base(i)
        {
            Console.WriteLine(">>> MyClass(int i)");
        }
        public MyClass(int i, int j) 
        {
            Console.WriteLine(">>> MyClass(int i, int j)");
        }
        public MyClass(int i, int j, int k): base(i)
        {
            Console.WriteLine(">>> MyClass(int i, int j, int k)");
        }
        public MyClass(int i, int j, int k, int l) : base(i)
        {
            Console.WriteLine(">>> MyClass(int i, int j, int k, int l)");
        }

    }

    class Test
    {
        static void Main()
        {
            MyClass m1 = new MyClass();
            MyClass m2 = new MyClass(1);
            MyClass m3 = new MyClass(1,2);
            MyClass m4 = new MyClass(1, 2,3);
            MyClass m5 = new MyClass(1, 2, 3,4);
        }
    }
}
