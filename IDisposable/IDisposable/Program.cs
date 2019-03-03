using System;

class Garbage : IDisposable {

    private bool isDispose = false;
    private string name;

    public Garbage(string name) {
        this.name = name;
        Console.WriteLine("{0}객체 생성됨...", this.name);
    }

    //소멸자
    ~Garbage() {
        //sDispose 안되어 있으면 Dispose() 호출
        if (!isDispose) { Dispose(); }
    }

    public void Dispose() {
        //Dispose() 되었다. true 
        isDispose = true;

        Console.WriteLine("{0}객체 리소스 해제 OK...", name);

        //Dispose() 후 소멸자 안부르게
        GC.SuppressFinalize(this);
    }
}


class GagageTest1 {
    static void Main() {
        Garbage g1 = new Garbage("1번객체");
        Garbage g2 = new Garbage("2번객체");
        Garbage g3 = new Garbage("3번객체");
        Garbage g4 = new Garbage("4번객체");

        g1.Dispose();

        //g2 소멸자 안부르게
        GC.SuppressFinalize(g2);

        //나머지는 언제 소멸될지 모른다. 그러나 윈도우 10은 프로그램 끝나자마자 바로 소멸된다. 
    }
}