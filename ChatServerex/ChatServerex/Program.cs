using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text;

namespace ChatServerex
{
    public partial class Form1 : Form
    static Encoding encoding = Encoding.GetEncoding("euc-kr");
    static IPAddress ip = IPAddress.Parse("192.168.0.205");
    TcpListener listener = new TcpListener(ip, 5001);
    List<Socket> sockets = new List<Socket>();

    public Form1()
    {
        InitializeComponent();
    }

    public void SetText(string text)
    {
        if (this.txt_Chat.InvokeRequired)
        {
            this.Invoke((Action<string>)SetText, text);
        }
        else
        {
            this.txt_Chat.AppendText(text);
        }
    }

    private void Form1_FormClosed(object sender, FormClosedEventArgs e)
    {
        Application.Exit();
        listener.Stop();
    }

    private void cmd_Start_Click(object sender, EventArgs e)
    {
        if (lbl_Message.Tag.ToString() == "Stop")

    }
}
