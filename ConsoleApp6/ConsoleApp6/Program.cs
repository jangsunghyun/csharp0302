﻿using System;

namespace ConsoleApplication1
{
    //이벤트 발생시 넘길 데이터 (System.EventArgs에서 파생)
    class EventPublisherArgs : System.EventArgs
    {
        public string myEventData;
        public EventPublisherArgs(string myEventData)
        {
            this.myEventData = myEventData;
        }
    }

    //이벤트 게시자 클래스
    class EventPublisher
    {
        //이벤트 처리를 위한 델리게이트 정의
        //public delegate void MyEventHandler(object sender, EventPublisherArgs e);
        public event EventHandler MyEvent;    //이벤트 정의

        public void Do()
        {
            //이벤트 가입자가 있는지 확인
            if (MyEvent != null)
            {
                EventPublisherArgs args = new EventPublisherArgs("데이터");
                MyEvent(this, args);    //이벤트 발생
            }
        }
    }

    //구독자 클랙스
    class Subscriber
    {
        static void Main(string[] args)
        {
            EventPublisher p = new EventPublisher();
            //p.MyEvent += new EventPublisher.MyEventHandler(doAction);
            //p.MyEvent += (sender, e) =>
            //{
            //    Console.WriteLine("Myevent 라는 이벤트 발생");
            //};
            p.MyEvent += new EventHandler(doAction);

            p.Do();
        }

        //MyEvent 이벤트가 발생하면 호출되는 메서드
        //EventPublisherArgs 가 발생시 넘어오는 데이터이다.
        static void doAction(object sender, EventArgs e)
        {
            Console.WriteLine("MyEvent 라는 이벤트 발생...");
            Console.WriteLine("이벤트 매개변수 : " + ((EventPublisherArgs)e).myEventData);
        }
    }

}