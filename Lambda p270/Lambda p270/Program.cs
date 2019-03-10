using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lambda_p270
{
    class Program : Form {
        static void Main(string[] args) {
            Program form = new Program();
            form.Click += new EventHandler(
                (sender, eventArgs) =>
                {
                    Console.WriteLine("폼클릭 이벤트...");
                    Application.Exit();// Application.Run을 종료
                });
            Console.WriteLine("윈도우 시작...");
            Application.Run(form);
            Console.WriteLine("윈도우 종료...");
        }
    }
}
