using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegate_Lab4
{
    delegate void DisplayMessage(string message);
    static class TestCustomDelegate
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //(변수 타입 채워주세요 ) messageTarget;
            DisplayMessage messageTarget;
            if (Environment.GetCommandLineArgs().Length > 1)
                messageTarget = ShowWindowsMessage;
            else
                messageTarget = Console.WriteLine;
            messageTarget("Hello, World!");
        }

        //private static void ( //메소드 이름 채워주세요 ) (string message)
        private static void ShowWindowsMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}
