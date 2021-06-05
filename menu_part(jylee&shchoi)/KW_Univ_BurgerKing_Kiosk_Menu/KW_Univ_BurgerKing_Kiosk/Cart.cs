using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KW_Univ_BurgerKing_Kiosk
{
    public partial class Cart : Form
    {
        Label[] name_lbl = new Label[30];
        Label[] detail_lbl = new Label[30];
        Label[] price_lbl = new Label[30];
        Button[] delete_btn = new Button[30];
        Button[] minusplus_btn = new Button[60];
        Label[] amount_lbl = new Label[30];
        Label[] divider = new Label[30];
        List<item> bList;

        public Cart(ref List<item> Boughtlist)
        {
            InitializeComponent();

            int cnt = Boughtlist.Count();
            bList = Boughtlist;

            setFormSize();


            for (int i = 0; i < cnt; ++i)
            {
                name_lbl[i] = new Label();
                detail_lbl[i] = new Label();
                price_lbl[i] = new Label();
                delete_btn[i] = new Button();
                minusplus_btn[i * 2] = new Button();
                minusplus_btn[i * 2 + 1] = new Button();
                amount_lbl[i] = new Label();
                divider[i] = new Label();


                name_lbl[i].Location = new Point(54, 88 + 150 * i);
                name_lbl[i].Text = Boughtlist[i].name;
                name_lbl[i].Font = new Font("굴림", 12);
                name_lbl[i].Size = new Size(250, 16);

                detail_lbl[i].Location = new Point(54, 123 + 150 * i);
                detail_lbl[i].Text = detailTxtMaker(Boughtlist[i].detaillist);
                detail_lbl[i].Size = new Size(400, 16);

                price_lbl[i].Location = new Point(300, 88 + 150 * i);
                price_lbl[i].Text = Boughtlist[i].price.ToString() + "원";
                price_lbl[i].Font = new Font("굴림", 12);
                price_lbl[i].AutoSize = false;
                price_lbl[i].TextAlign = ContentAlignment.MiddleRight;

                delete_btn[i].Location = new Point(54, 157 + 150 * i);
                delete_btn[i].Text = "삭제";
                delete_btn[i].Name = i.ToString();
                delete_btn[i].Click += new System.EventHandler(this.deleteBtn_Click);

                minusplus_btn[i * 2].Location = new Point(270, 157 + 150 * i);
                minusplus_btn[i * 2].Text = "-";
                minusplus_btn[i * 2].Name = (i * 2).ToString();
                minusplus_btn[i * 2].Size = new Size(39, 32);
                minusplus_btn[i * 2].Click += new System.EventHandler(this.mnu_minus_Click);

                minusplus_btn[i * 2 + 1].Location = new Point(370, 157 + 150 * i);
                minusplus_btn[i * 2 + 1].Text = "+";
                minusplus_btn[i * 2 + 1].Name = (i * 2 + 1).ToString();
                minusplus_btn[i * 2 + 1].Size = new Size(39, 32);
                minusplus_btn[i * 2 + 1].Click += new System.EventHandler(this.mnu_plus_Click);

                amount_lbl[i].Location = new Point(313, 162 + 150 * i);
                amount_lbl[i].Text = Boughtlist[i].quantity.ToString();
                amount_lbl[i].Font = new Font("굴림", 12);
                amount_lbl[i].TextAlign = ContentAlignment.MiddleCenter;
                amount_lbl[i].AutoSize = false;
                amount_lbl[i].Size = new Size(54, 24);


                divider[i].Location = new Point(11, 211 + 150 * i);
                divider[i].Size = new Size(457, 2);
                divider[i].BorderStyle = BorderStyle.Fixed3D;

                
                this.Controls.Add(name_lbl[i]);
                this.Controls.Add(detail_lbl[i]);
                this.Controls.Add(price_lbl[i]);
                this.Controls.Add(delete_btn[i]);
                this.Controls.Add(minusplus_btn[i * 2]);
                this.Controls.Add(minusplus_btn[i * 2 + 1]);
                this.Controls.Add(amount_lbl[i]);
                this.Controls.Add(divider[i]);
            }


            hapgye.Location = new Point(50, 91 + 150 * cnt);
            price_result.Location = new Point(252, 91 + 150 * cnt);

            price_result.Text = getSumPrice().ToString() + "원";
        }


        string detailTxtMaker(List<detail> details)
        {
            string t = "";
            if (details.Count == 0) return "없음";

            foreach (detail i in details)
                t += i.name + ", ";

            return t.Substring(0, t.Length - 2);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name);
            int cnt = bList.Count;

            for (int i = num; i < cnt - 1; ++i)
            {
                name_lbl[i].Text = name_lbl[i + 1].Text;
                price_lbl[i].Text = price_lbl[i + 1].Text;
                amount_lbl[i].Text = amount_lbl[i + 1].Text;
            }

            this.Controls.Remove(name_lbl[cnt - 1]);
            this.Controls.Remove(detail_lbl[cnt - 1]);
            this.Controls.Remove(price_lbl[cnt - 1]);
            this.Controls.Remove(delete_btn[cnt - 1]);
            this.Controls.Remove(minusplus_btn[(cnt - 1) * 2]);
            this.Controls.Remove(minusplus_btn[(cnt - 1) * 2 + 1]);
            this.Controls.Remove(amount_lbl[cnt - 1]);
            this.Controls.Remove(divider[cnt - 1]);
            bList.RemoveAt(num);

            setFormSize();

            hapgye.Location = new Point(50, 91 + 150 * bList.Count);
            price_result.Location = new Point(252, 91 + 150 * bList.Count);

            price_result.Text = getSumPrice().ToString() + "원";
        }

        private void mnu_plus_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name) / 2;

            ++bList[num].quantity;
            amount_lbl[num].Text = bList[num].quantity.ToString();

            price_result.Text = getSumPrice().ToString() + "원";
        }

        private void mnu_minus_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32((sender as Button).Name) / 2;

            if (bList[num].quantity > 1)
                --bList[num].quantity;
            amount_lbl[num].Text = bList[num].quantity.ToString();

            price_result.Text = getSumPrice().ToString() + "원";
        }

        int getSumPrice()
        {
            int s = 0;
            foreach (item i in bList)
                s += i.price * i.quantity;

            return s;
        }

        void setFormSize()
        {
            this.Height = 200 + 150 * bList.Count;
            if (this.Height > 650)
            {
                this.Height = 650;
                this.AutoScroll = true;
            }
        }
    }
}
