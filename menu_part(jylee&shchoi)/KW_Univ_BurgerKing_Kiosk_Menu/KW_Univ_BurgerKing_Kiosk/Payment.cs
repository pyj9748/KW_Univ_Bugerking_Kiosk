using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using System.Net;
using System.IO;
/// <summary>
/// 클라이언트 역할을 한다.
/// </summary>
namespace KW_Univ_BurgerKing_Kiosk
{
    public partial class Payment : Form
    {


        pay pa;
        int cnt = 0;


        Socket client;


        public Payment(List<item> list)
        {
            InitializeComponent();
           
            textBox1.AppendText("결제 방식을 선택하시고 결제 버튼을 누르세요\r\n");
             pa = new pay("현금", 100, list);

            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 7777);

             client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            client.Connect(ipep);

            //byte[] sendbuffer = Encoding.Default.GetBytes("");
           // byte[] recv_buf = new byte[1024];

           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var builder = new StringBuilder();
            if (cnt == 0)
            {
                textBox1.AppendText("주문 내역 :  \r\n");
                builder.Append("주문 내역 :  \r\n");
                foreach (item i in pa.boughtlist)
                {
                    textBox1.AppendText(i.name + "\r\n");
                    foreach (detail d in i.detaillist)
                    {
                        if (d.name == "매장 식사")
                        {
                            textBox1.AppendText("매장 식사 및 포장 : " + d.name + "\r\n");
                            builder.Append("매장 식사 및 포장 : " + d.name + "\r\n");
                        }
                        else if (d.name == "포장")
                        {
                            textBox1.AppendText("매장 식사 및 포장 : " + d.name + "\r\n");
                            builder.Append("매장 식사 및 포장 : " + d.name + "\r\n");
                        }
                        else
                        {
                            textBox1.AppendText("\t\t+" + d.name + "\r\n");
                            builder.Append("\t\t+" + d.name + "\r\n");
                        }
                    }
                }
                textBox1.AppendText("결제 금액 :  " + label2.Text + "\r\n");
                builder.Append("결제 금액 :  " + label2.Text + "\r\n");
                textBox1.AppendText("선택하신 결제 방법 : " + pa.payway + "\r\n");
                builder.Append("선택하신 결제 방법 : " + pa.payway + "\r\n");
                textBox1.AppendText("주문번호 : " + label4.Text + "\r\n");
                builder.Append("주문번호 : " + label4.Text + "\r\n");
                cnt = 1;


                client.Send(Encoding.Default.GetBytes(builder.ToString()));

                byte[] recv_buf = new byte[1024];
                client.Receive(recv_buf);
                textBox1.AppendText(Encoding.Default.GetString(recv_buf));
                client.Close();
            }
            else {
              
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            client.Close();
            this.Close();
        }

        private void Payment_Load(object sender, EventArgs e)
        {

        }

        private void cash_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            pa.payway = "현금";
        }

        private void credit_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            pa.payway = "신용 카드";
        }

        private void kakao_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            pa.payway = "카카오 페이";
        }

        private void Payment_FormClosed(object sender, FormClosedEventArgs e)
        {
            client.Close();
        }
    }
}
