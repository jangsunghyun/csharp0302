﻿using System;
using System.Runtime.InteropServices;

class Test
{
    [DllImport("User32.dll")]
    public static extern int MessageBox(int h, string m, string c, int type);
    static void main()
    {
        MessageBox(0, "Hello!", "In C#", 0);
    }
}