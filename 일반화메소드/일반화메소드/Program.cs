﻿using System;
using System.Collections.Generic;
using System.Text;

namespace 일반화메소드
{
    class MainApp
    {
        static T[] GetArray<T>(int size, T val)
        {
            T[] array = new T[size];
            for (int i = 0; i < size; i++) {
                array[i] = val;
            }
            return array;
        }

        static void Main(string[] args)
        {
            string[] str_array = GetArray<string>(3, "오라클자바커뮤니티,오라클자바커뮤니티");
            foreach (string s in str_array) Console.WriteLine(s);

            int[] int_array = GetArray<int>(3, 999);
            foreach (int i in int_array) Console.WriteLine(i);
        }

    }

}
