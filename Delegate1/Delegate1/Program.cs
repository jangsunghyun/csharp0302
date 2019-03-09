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
            //Delegate1 d = new Delegate1();
            //OnjSum myMethod = new OnjSum(d.Sum);
            //OnjSum myMethod = d.Sum;    //왼쪽에 델리게이트면 왼쪽에는 new 안써줘도 된다.  //2. 생성
            //Func tyep 15까지..
            //<기본파라메터, output 파라메터>   Func 는 값을 리턴하는  Action 은 값 리턴하지 않음.. 
            //Func<int,int,int> myMethod = Sum;

            Action <int, int> myMethod = Sum;
            myMethod(10, 30);

            Console.WriteLine("두수 합: {0}", myMethod(10, 30)); //3. 실행
        }

        static void Sum(int i, int j)
        {
            Console.WriteLine (i + j);
        }
    }
}
