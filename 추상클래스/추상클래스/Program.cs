using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 추상클래스
{
    // abstract 추상클래스 아무 클래스 앞에 abstract 
    public abstract class Dog
    {
        public string Name { get; set; }
        public abstract void jitda(); // abstract 추상 메소드는 {} 없다. 
    }

    public class Pudle : Dog {
        //abstract 추상클래스 상속받아서 override로 재정이 해서 쓰라 
        //abstract 추상 클래스는 New 해서 사용 할수 없다. 
        public override void jitda()
        {                        
            Console.WriteLine(Name + "푸들푸들~");                        
        }
        public void Work()
        {
            Console.WriteLine(Name + "가 일한다.");
        }
    }


    public class Jindo : Dog
    {
        public override void jitda()
        {
            Console.WriteLine(Name + "진도진도~");
        }
        public void Run()
        {
            Console.WriteLine(Name + "가 달린다.");
        }
    }

    class DogManager
    {
        static void Main()
        {
            Dog p = new Pudle();    p.Name = "푸들이"; p.jitda();  ((Pudle)p).Work();
            Dog j = new Jindo();    j.Name = "진도이"; j.jitda(); ((Jindo)j).Run();
        }
    }
}
