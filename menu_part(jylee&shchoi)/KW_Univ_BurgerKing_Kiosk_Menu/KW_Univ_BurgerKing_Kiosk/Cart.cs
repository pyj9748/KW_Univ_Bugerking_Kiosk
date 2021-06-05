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
        public Cart(ref List<item> Boughtlist)
        {
            InitializeComponent();

            int cnt = Boughtlist.Count();

            this.Height = 200 + 150 * cnt;


            Label[] name_label = new Label[30];
            Label[] detail_label = new Label[30];
            Label[] price_label = new Label[30];
            Button[] delete_btn = new Button[30];
            Button[] minusplus_btn = new Button[60];
            Label[] amount_label = new Label[30];
            Label[] divider = new Label[30];


            for (int i = 0; i < cnt; ++i)
            {
                name_label[i] = new Label();
                detail_label[i] = new Label();
                price_label[i] = new Label();
                delete_btn[i] = new Button();
                minusplus_btn[i * 2] = new Button();
                minusplus_btn[i * 2 + 1] = new Button();
                amount_label[i] = new Label();
                divider[i] = new Label();


                name_label[i].Location = new Point(54, 88 + 150 * i);
                name_label[i].Text = Boughtlist[i].name;
                name_label[i].Font = new Font("굴림", 12);
                name_label[i].Size = new Size(250, 16);

                detail_label[i].Location = new Point(54, 123 + 150 * i);
                detail_label[i].Text = detailTxtMaker(Boughtlist[i].detaillist);
                detail_label[i].Size = new Size(400, 16);

                price_label[i].Location = new Point(300, 88 + 150 * i);
                price_label[i].Text = Boughtlist[i].price.ToString() + "원";
                price_label[i].Font = new Font("굴림", 12);
                price_label[i].AutoSize = false;
                price_label[i].TextAlign = ContentAlignment.MiddleRight;

                delete_btn[i].Location = new Point(54, 157 + 150 * i);
                delete_btn[i].Text = "삭제";

                minusplus_btn[i * 2].Location = new Point(270, 157 + 150 * i);
                minusplus_btn[i * 2].Text = "-";
                minusplus_btn[i * 2].Size = new Size(39, 32);
                minusplus_btn[i * 2 + 1].Location = new Point(370, 157 + 150 * i);
                minusplus_btn[i * 2 + 1].Text = "+";
                minusplus_btn[i * 2 + 1].Size = new Size(39, 32);

                amount_label[i].Location = new Point(313, 162 + 150 * i);
                amount_label[i].Text = Boughtlist[i].quantity.ToString();
                amount_label[i].Font = new Font("굴림", 12);
                amount_label[i].TextAlign = ContentAlignment.MiddleCenter;
                amount_label[i].AutoSize = false;
                amount_label[i].Size = new Size(54, 24);


                divider[i].Location = new Point(11, 211 + 150 * i);
                divider[i].Size = new Size(457, 2);
                divider[i].BorderStyle = BorderStyle.Fixed3D;


                this.Controls.Add(name_label[i]);
                this.Controls.Add(detail_label[i]);
                this.Controls.Add(price_label[i]);
                this.Controls.Add(delete_btn[i]);
                this.Controls.Add(minusplus_btn[i * 2]);
                this.Controls.Add(minusplus_btn[i * 2 + 1]);
                this.Controls.Add(amount_label[i]);
                this.Controls.Add(divider[i]);


                //Boughtlist.RemoveAt(i);

                //delete_btn[i].Click += (sender, e) => {  };
                //minusplus_btn[i * 2].Click += (sender, e) => {  };
                //minusplus_btn[i * 2 + 1].Click += (sender, e) => {  };

            }


            hapgye.Location = new Point(50, 91 + 150 * cnt);
            price_result.Location = new Point(252, 91 + 150 * cnt);

            int sum = 0;
            foreach (item i in Boughtlist)
                sum += i.price;

            price_result.Text = sum.ToString() + "원";
        }

        string detailTxtMaker(List<detail> details)
        {
            return "샘플 세부사항";
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

        }

    }
}
