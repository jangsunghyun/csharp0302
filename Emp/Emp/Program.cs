using System;

//클래스는 변수와 매소드로 되어 있다. 
//클래스는 
class Emp 
{
    //private int _Empno;  //밖에서 접근하는 것을 막아서 캡슐화로 한다. private 는 _ 넣는것이 관례
    public int Empno
    {   //속성은 입출력 채널.. 통로..
        get; set;  //자동 구현 속성  

        //get
        //{    return _Empno;     }       //나오는 값

        //set {    this._Empno = value;      }  //들어오는 값
    } = 999; //속성에 기본값 줄수 있다.
    // 람다식..
    //public int Empno1 { get => _Empno; set => _Empno = value; }

    

    //public void SetEmpno(int Empno)  //쎄터
    //{
    //    this.Empno = Empno;
    //}

    //public int GetEmpno()   //게터
    //{
    //    return this.Empno;
    //}
}

class EmpTest
{
    static void Main() {
        Emp e = new Emp(); e.Empno =999;   // 등호 왼쪽에 쓰면 L value  set
        int i = e.Empno;  //등호 오른쪽에호출되면 R valuse  get
        Console.WriteLine(e.Empno);
    }
}

