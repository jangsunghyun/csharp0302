//아래 예제는 int형 스택, string형 스택을 각각 구현했다.
//이를 일반화 시켜 Generic으로 Stack 클래스를 구현하고 메인을 적절히 수정하여 테스트 하세요.

using System;
using System.Collections;
using System.Collections.Generic;
namespace ConsoleApplication6
{  

    class Stack<T>
    {
        int top = 0;
        T[] ar = new T[10];

        public void Push(T obj)
        {
            ar[top] = obj;
            top++;
        }
        public  T Pop()
        {
            top--;
            return ar[top];
        }
    }

    class StackTest
    {

        static void Main()
        {
            Stack s1 = new Stack();
            s1.Push(1);
            s1.Push(2);
            s1.Push(3);
            Console.WriteLine(s1.Pop());
            Console.WriteLine(s1.Pop());
            Console.WriteLine(s1.Pop());

            Stack s2 = new Stack();
            s2.Push("KOREA");
            s2.Push("대한민국");
            s2.Push("서울");
            Console.WriteLine(s2.Pop());
            Console.WriteLine(s2.Pop());
            Console.WriteLine(s2.Pop());
        }

    }
}