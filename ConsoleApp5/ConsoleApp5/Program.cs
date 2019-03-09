using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate1
{
    public class Delegate1
    {//                             이미 파라메터 델리게이터 c#에서 15개 만들어 뒀다.  Func.. 15개 만들어둠.. 
     //델리게이터가 값을 리턴하면 Func  값을 리턴하지 않으면..Acc
     //        private delegate int OnjSum(int i, int j); //1.선언  데이터 타입만 정의 

        static void Main(string[] args)
        {
            //Action <> 파라메터 없으므로 <> 빼준다.
            Action myHello = new Action(SayHelloKr);
            SayHello(myHello);
            myHello = SayHelloEn;
            SayHello(myHello);
        }

        static void SayHello(Action hello)
        {
            hello();
        }

        static void SayHelloKr()
        {
            Console.WriteLine("안녕...");
        }
        static void SayHelloEn()
        {
            Console.WriteLine("Hello....");
        }
    }
}
