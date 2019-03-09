﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegateex4
{
    delegate void OnjDelegate(int a, int b);

    class MainApp
    {
        static void Plus(int a, int b)
        {
            Console.WriteLine("{0} + {1} = {2}", a, b, a +b);        
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
            MainApp m = new MainApp();
            //OnjDelegate CallBack = (OnjDelegate)Delegate.Combine(
            //    new OnjDelegate(MainApp.Plus),
            //    new OnjDelegate(MainApp.Minus),
            //    new OnjDelegate(m.Multiplication),
            //    new OnjDelegate(m.Division));
            OnjDelegate CallBack = new OnjDelegate(MainApp.Plus);
            CallBack += new OnjDelegate(MainApp.Minus);
            CallBack += new OnjDelegate(m.Multiplication);
            CallBack += new OnjDelegate(m.Division);
            CallBack(4, 3);
        }
    }
}
