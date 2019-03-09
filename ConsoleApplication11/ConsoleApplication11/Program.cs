using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApplication11
{
    class EventPublisher
    {
        public delegate void MyEventHandler();
        public event MyEventHandler MyEvent;
        public void Do()
        {
            MyEvent?.Invoke();
        }
    }

    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            EventPublisher p = new EventPublisher();
            //구독자의 이벤트 처리 메소드를 등록
            //이벤트를 발생하면 호출될 메소드를 정의, 여기서는 doAction 메소드 호출
            //MyEvent 라는 이벤트에 이벤트핸들러인 델리게이트를 통해 메소드를 등록
            //MyEvent 라는 이벤트가 발생하면 델리게이트가 참조하는 메소드 doAction() 실행
            p.MyEvent += new EventPublisher.MyEventHandler(doAction);
            //테스트를 위해 do() 메소드를 호출하여 이벤트 발생
            //실제 윈폼등에서는 버튼등을 클릭하면 자동으로 이벤트가 발생하지만
            //콘솔 프로그램이라서 메소드를 호출하는 것이다.
            p.Do();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        static void doAction()
        {
            Console.WriteLine("MyEvent 라는 이벤트 발생...");
        }

    }
}
