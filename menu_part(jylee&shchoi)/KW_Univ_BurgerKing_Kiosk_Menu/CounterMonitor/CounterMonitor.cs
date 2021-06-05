using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// 서버 역할을 한다.
/// </summary>
namespace CounterMonitor
{
    public partial class CounterMonitor : Form
    {

        int PORT;


        Socket server;
        Socket client;

        public CounterMonitor()
        {
            InitializeComponent();


            PORT = 7777;



        }

        private void CounterMonitor_FormClosed(object sender, FormClosedEventArgs e)
        {
            client.Close();
            server.Close();
        }

        private void CounterMonitor_Load(object sender, EventArgs e)
        {


        }

        public void run()
        {
            while (true)
            {
                IPEndPoint ipep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 7777);

                server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                server.Bind(ipep);
                server.Listen(20);
                textBox1.AppendText("키오스크 주문을 기다리는 중." + "\r\n");

                client = server.Accept();

                //IPEndPoint ip = (IPEndPoint)client.RemoteEndPoint;
                byte[] sendbuffer = new byte[1024];

                byte[] recv_buf = new byte[1024];
                int i = 20;


                if (client.Receive(recv_buf) == null)
                {
                    continue; 
                }
                textBox1.AppendText(Encoding.Default.GetString(recv_buf));


                sendbuffer = Encoding.Default.GetBytes("조금만 기다려주세요 - " + DateTime.Now.ToString("HH:mm:ss"));
                client.Send(sendbuffer, sendbuffer.Length, SocketFlags.None);
                textBox1.AppendText("\r\n");




                client.Close();
                server.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            (new Thread(new ThreadStart(run))).Start();
        }
    }
}
