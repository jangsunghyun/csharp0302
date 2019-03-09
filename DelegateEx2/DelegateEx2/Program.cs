using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEx2
{
    class Program
    {
        public delegate int MyDelegate(int i, int j);

        public static void Main(string[] args)
        {
            TaskesADelegate(new MyDelegate(Add));
            TaskesADelegate(new MyDelegate(Minus));
            TaskesADelegate(new MyDelegate(Gop));
            TaskesADelegate(new MyDelegate(Nanugi));

        }

        public static void TaskesADelegate(MyDelegate SomeFunction)
        {
            Console.WriteLine(SomeFunction(1, 2));
        }

        public static int Add(int i, int j)
        {
            return i + j;
        }

        public static int Minus(int i, int j)
        {
            return i - j;
        }

        public static int Gop(int i, int j)
        {
            return i * j;
        }

        public static int Nanugi(int i, int j)
        {
            return i / j;
        }
    }
}
