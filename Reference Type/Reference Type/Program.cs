using System;

namespace Reference_Type
{

    class Rtype {
        public object value;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rtype a = new Rtype();
            Rtype b = new Rtype();

            a.value = 1;    b = a;  //a가 참조하는 것을 b도 참조한다. 
            Console.WriteLine(a.value); Console.WriteLine(b.value);

            b.value = 2;
            Console.WriteLine(a.value); Console.WriteLine(b.value);
        }
    }
}
