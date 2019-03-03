using System;

class Emp
{
    public string Name { get; set; }
    //void 나 int 같이 returntype 이 없고 class 이름과 내부 이름이 같은거.. 
    //기본생성자, Default Constructor, 라고 칭한다. new 할때 로딩
    //internal Emp()
    //{
    //    Name = "홍길동";
    //}

    internal Emp(string Name = "홍길동")
    {
        this.Name = Name;
    }
}

class EmpTest
{
    static void Main() {
        // Emp() 파라메터 없이 생성되는것은 상단 internal class 로딩한다.
        Emp e = new Emp(); Console.WriteLine(e.Name);
    }
}