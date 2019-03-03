using System;

namespace 인터페이스
{
    //interface는 자동 public 이다. 인터페이스 메소드는 구현된 메소드는 들어갈수 없다. 
    interface Dog
    {
        string name { get; set; }
        //{가 없으면 추상메소드}
        void jitda();
    }

    class Pudle : Dog {
        public string name { get; set; }
        public void work() { Console.WriteLine(name + " 일한다."); }
        public void jitda() { Console.WriteLine(name + " 짖다~~~~."); }
    }

    class Jindo : Dog {
        public string name { get; set; }
        public void run() { Console.WriteLine(name + " 달린다.."); }
        public void jitda() { Console.WriteLine(name + " 짖다~~~~."); }

    }

    class Program
    {
        static void Main(string[] args)
        {   //같은 개가 짖는데 결과다 다르게나오는 부분을 재정이 부분때문에 이것을 "다형성"이라고 칭한다.
            Dog p = new Pudle(); p.name = "푸들이"; p.jitda(); ((Pudle)p).work();
            Dog j = new Jindo(); j.name = "진도이"; j.jitda(); ((Jindo)j).run();
        }
    }
}
