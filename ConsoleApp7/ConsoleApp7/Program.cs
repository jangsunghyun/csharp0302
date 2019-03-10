using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsFilter
{
    class OnjMessageFilter : IMessageFilter
    {
        public bool PreFilterMessage(ref Message m)
        {
            //마우스 클릭시 필터링 시킴
            if (m.Msg == 0x201)
            {
                Console.WriteLine("마우스 클릭 필터링됨...");
                //필터에서 처리했으니 응용프로그램에서 처리안해도된다는 의미                 
                //Form에 걸려 있는 Click 이벤트 동작안함.즉 윈도우가 종료되지않는다                 
                //이 부분을 false로 바꾼 후 실행해 보라 
                return true;
            }
            return false;
        }
    }

    class Program : Form
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.AddMessageFilter(new OnjMessageFilter());
            Program p = new Program();
            p.Click += new EventHandler(p.Form_Click);
            Application.Run(new Form1());
        }

        void Form_Click(object sender, EventArgs e)
        {
            Console.WriteLine("마우스 클릭 이벤트 발생...");
            Application.Exit();
        }
    }
}
