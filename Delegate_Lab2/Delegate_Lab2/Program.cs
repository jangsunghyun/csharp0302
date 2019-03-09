﻿//2. 괄호를 채우세요.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Lab2
{
    public delegate void Callback();

    class Program
    {
        static void Main(string[] args)
        {
            MyClass my = new MyClass();
            //Direct call
            my.MyMethod1();
            my.MyMethod2();
            Console.WriteLine("------------");
            // Call via a delegate
            // MyClass의 GetCallback(Callback callBack) 메소드를 호출하여
            // MyMethod1, MyMethod2가 호출 되도록 코드를 완성하세요

            //(채워주세요) 

            Callback call = (Callback)Delegate.Combine(

                new Callback(my.MyMethod1),

                new Callback(my.MyMethod2));

            //(채워주세요) 
            //Callback cb1 = new Callback(my.MyMethod1); 
            //Callback cb2 = new Callback(my.MyMethod2); 

            call();



        }
    }
    public class MyClass
    {
        public MyClass() { }
        public void GetCallback(Callback callBack)
        {
            callBack();
        }
        public void MyMethod1()
        {
            Console.WriteLine("My Method 1");
        }
        public void MyMethod2()
        {
            Console.WriteLine("My Method 2");
        }
    }

}
