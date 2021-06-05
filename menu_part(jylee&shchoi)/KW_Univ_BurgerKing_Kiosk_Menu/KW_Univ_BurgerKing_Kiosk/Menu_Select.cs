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
    public partial class Menu_Select : Form
    {
        public bool cancel = true;

        public item order;

        public Menu_Select(item i)
        {
            InitializeComponent();
            order = new item(i.name, 1, i.price, i.type);
            pictureBox1.Image = imageList1.Images[i.quantity];
            label2.Text = order.name;
            price_sum();
            if (order.type != "SET")
            {
                comboBox1.Enabled = false;
                comboBox1.Text = "";
            }
            else
            {
                comboBox1.SelectedIndex = 0;
            }
            if (order.type == "SIDE")
            {
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
                checkBox5.Enabled = false;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cancel = false;
            order.quantity = 1;
            if (checkBox1.Checked)
            {
                order.price += 300;
                order.detaillist.Add(new detail("치즈 1장 추가", 1, 300));
            }
            if (checkBox2.Checked)
            {
                order.price += 600;
                order.detaillist.Add(new detail("치즈 2장 추가", 1, 600));
            }
            if (checkBox3.Checked)
            {
                order.price += 300;
                order.detaillist.Add(new detail("피클 추가", 1, 300));
            }
            if (checkBox4.Checked)
            {
                order.price += 500;
                order.detaillist.Add(new detail("토마토 추가", 1, 500));
            }
            if (checkBox5.Checked)
            {
                order.price += 800;
                order.detaillist.Add(new detail("베이컨 추가", 1, 800));
            }
            if (comboBox1.Enabled == true)
                order.detaillist.Add(new detail(comboBox1.Text, 1, 0));
            if (radioButton1.Checked)
            {
                order.detaillist.Add(new detail("매장 식사", 1, 0));
                order.take_out = false;
            }
            else
            {
                order.detaillist.Add(new detail("포장", 1, 0));
                order.take_out = true;

            }
            this.Close();
        }
        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            price_sum();
        }
        public void price_sum()
        {
            int price = order.price;
            if (checkBox1.Checked)
            {
                price += 300;
            }
            if (checkBox2.Checked)
            {
                price += 600;
            }
            if (checkBox3.Checked)
            {
                price += 300;
            }
            if (checkBox4.Checked)
            {
                price += 500;
            }
            if (checkBox5.Checked)
            {
                price += 800;
            }
            if (price % 1000 == 0)
                label3.Text = price / 1000 + ",000\\";
            else
                label3.Text = price / 1000 + "," + price % 1000 + "\\";

        }
    }
}
