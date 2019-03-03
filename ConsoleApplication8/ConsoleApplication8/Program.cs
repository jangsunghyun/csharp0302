using System;

namespace ConsoleApplication8
{   //부모의 부모는 object
    class MyBaseClass : Object
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
        //base 생략되어 있다.
        public MyClass(): base()
        {
            //생성자의 첫번째 라인부터 부모생성자 불러온다. base 
            /////////////////////////////
            Console.WriteLine(">>> MyClass()");
        }
        // base(i)는 MyClass(int i)이거 실행되기 전에  base(i) 실행해 준다.. base class 부모 클래스
        //base(i) 부모 class
        public MyClass(int i) : base(i)
        {
            Console.WriteLine(">>> MyClass(int i)");
        }
        //: 없으면 base 먼저읽는다. 
        public MyClass(int i, int j) 
        {
            Console.WriteLine(">>> MyClass(int i, int j)");
        }
        public MyClass(int i, int j, int k): base(i)
        {
            Console.WriteLine(">>> MyClass(int i, int j, int k)");
        }
        public MyClass(int i, int j, int k, int l) : this(i, j)
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
            MyClass m4 = new MyClass(1, 2, 3);
            MyClass m5 = new MyClass(1, 2, 3,4);
        }
    }
}
