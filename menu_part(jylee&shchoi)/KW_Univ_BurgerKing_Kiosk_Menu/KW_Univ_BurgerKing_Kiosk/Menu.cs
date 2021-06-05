using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace KW_Univ_BurgerKing_Kiosk
{
    public partial class Menu : Form
    {
        List<item> rec_menulist = new List<item>(); // 메뉴 리스트 여기에 너희가 만든 메뉴 추가해
        List<item> set_menulist = new List<item>();
        List<item> single_menulist = new List<item>();
        List<item> side_menulist = new List<item>();
        List<detail> detaillist = new List<detail>(); // 세부 사항 리스트 너희가 만든 세부사항 추가
        public static List<item> Boughtlist = new List<item>(); // 여기는 산 메뉴 추가하는 리스트

        int selected_menu;
        int ordernum = 555;
        public Menu()
        {
            InitializeComponent();
            rec_menulist.Add(new item("기네스 콰트로 치즈 와퍼 세트", 0, 10300, "SET"));
            rec_menulist.Add(new item("몬스터 X 세트", 3, 10700, "SET"));
            rec_menulist.Add(new item("콰트로 치즈 와퍼 세트", 6, 9600, "SET"));

            set_menulist.Add(new item("기네스 콰트로 치즈 와퍼 세트", 0, 10300, "SET"));
            set_menulist.Add(new item("기네스 와퍼 세트", 1, 10300, "SET"));
            set_menulist.Add(new item("기네스 머쉬룸 와퍼 세트", 2, 10700, "SET"));
            set_menulist.Add(new item("몬스터 X 세트", 3, 10700, "SET"));
            set_menulist.Add(new item("몬스터 와퍼 세트", 4, 10000, "SET"));
            set_menulist.Add(new item("콰트로 치즈 X 세트", 5, 10600, "SET"));
            set_menulist.Add(new item("콰트로 치즈 와퍼 세트", 6, 9600, "SET"));
            set_menulist.Add(new item("트러플 머쉬룸 X 세트", 7, 10100, "SET"));
            set_menulist.Add(new item("트러플 머쉬룸 와퍼 세트", 8, 9100, "SET"));
            set_menulist.Add(new item("통새우 스테이크 버거 세트", 9, 10700, "SET"));
            set_menulist.Add(new item("통새우 와퍼 세트", 10, 9700, "SET"));

            single_menulist.Add(new item("기네스 콰트로 치즈 와퍼", 0, 9300, "SINGLE"));
            single_menulist.Add(new item("기네스 와퍼", 1, 9300, "SINGLE"));
            single_menulist.Add(new item("기네스 머쉬룸 와퍼", 2, 9700, "SINGLE"));
            single_menulist.Add(new item("몬스터 X", 3, 9700, "SINGLE"));
            single_menulist.Add(new item("몬스터 와퍼", 4, 9000, "SINGLE"));
            single_menulist.Add(new item("콰트로 치즈 X", 5, 8600, "SINGLE"));
            single_menulist.Add(new item("콰트로 치즈 와퍼", 6, 7600, "SINGLE"));
            single_menulist.Add(new item("트러플 머쉬룸 X", 7, 8100, "SINGLE"));
            single_menulist.Add(new item("트러플 머쉬룸 와퍼", 8, 7100, "SINGLE"));
            single_menulist.Add(new item("통새우 스테이크 버거", 9, 8700, "SINGLE"));
            single_menulist.Add(new item("통새우 와퍼", 10,7700, "SINGLE"));

            side_menulist.Add(new item("바삭킹 4조각", 11, 3300, "SIDE"));
            side_menulist.Add(new item("21 치즈스틱", 12, 2200, "SIDE"));
            side_menulist.Add(new item("너겟킹 8조각", 13, 2600, "SIDE"));
            side_menulist.Add(new item("프렌치 프라이", 14, 2200, "SIDE"));
            side_menulist.Add(new item("어니언 링", 15, 2600, "SIDE"));
            side_menulist.Add(new item("코카콜라", 16, 2300, "SIDE"));
            side_menulist.Add(new item("스프라이트", 17, 2300, "SIDE"));
            side_menulist.Add(new item("미닛메이드 오렌지", 18, 3300, "SIDE"));
            side_menulist.Add(new item("아메리카노", 19, 2100, "SIDE"));

            listView1.View = View.LargeIcon;
            load_rec();
        }

        public void load_rec()
        {
            listView1.Clear();
            ListViewItem item;
            foreach (item i in rec_menulist)
            {
                item = listView1.Items.Add(i.name + "\n\\" + i.price);
                item.ImageIndex = i.quantity;
            }
            selected_menu = 0;
        }
        public void load_set()
        {
            listView1.Clear();
            ListViewItem item;
            foreach (item i in set_menulist)
            {
                item = listView1.Items.Add(i.name + "\n\\" + i.price);
                item.ImageIndex = i.quantity;
            }
            selected_menu = 1;
        }
        public void load_single()
        {
            listView1.Clear();
            ListViewItem item;
            foreach (item i in single_menulist)
            {
                item = listView1.Items.Add(i.name + "\n\\" + i.price);
                item.ImageIndex = i.quantity;
            }
            selected_menu = 2;
        }
        public void load_side()
        {
            listView1.Clear();
            ListViewItem item;
            foreach (item i in side_menulist)
            {
                item = listView1.Items.Add(i.name + "\n\\" + i.price);
                item.ImageIndex = i.quantity;
            }
            selected_menu = 3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            load_rec();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            load_set();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            load_single();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            load_side();
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection slist = listView1.SelectedItems;
            ListViewItem sitem = slist[0];
            item selected = new item("", 0, 0, "");
            switch (selected_menu)
            {
                case 0:
                    foreach (item i in rec_menulist)
                    {
                        if (i.quantity == sitem.ImageIndex)
                        {
                            selected = i;
                            break;
                        }
                    }
                    break;
                case 1:
                    foreach (item i in set_menulist)
                    {
                        if (i.quantity == sitem.ImageIndex)
                        {
                            selected = i;
                            break;
                        }
                    }
                    break;
                case 2:
                    foreach (item i in single_menulist)
                    {
                        if (i.quantity == sitem.ImageIndex)
                        {
                            selected = i;
                            break;
                        }
                    }
                    break;
                case 3:
                    foreach (item i in side_menulist)
                    {
                        if (i.quantity == sitem.ImageIndex)
                        {
                            selected = i;
                            break;
                        }
                    }
                    break;

            }
            listView1.SelectedItems.Clear();
            Menu_Select menu = new Menu_Select(selected);
            menu.ShowDialog();

            if (menu.cancel == false)
            {
                //Boughtlist.Add(menu.order);
                addMenu(menu.order);
            }

            if (Boughtlist.Count > 0)
            {
                cart_btn.Text = "장바구니(" + Boughtlist.Count + ")";
            }

           
        }

        public static void initorder() {
            Boughtlist.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            Payment payment = new Payment(ref Boughtlist,this);

            List<item> boughtlist = new List<item>();
            boughtlist = Boughtlist;

            int price_sum = 0;
            foreach (item i in Boughtlist) {
                price_sum += i.price * i.quantity;
            }
           
            payment.label2.Text = price_sum.ToString() + "원" ;
            payment.label4.Text = ordernum.ToString();
            
            DialogResult dialogResult = payment.ShowDialog();
            ordernum++;

            

        }

        private void cart_btn_Click(object sender, EventArgs e)
        {
            Cart cart = new Cart(ref Boughtlist);

            DialogResult dialogResult = cart.ShowDialog();
            cart_btn.Text = Boughtlist.Count > 0 ? "장바구니(" + Boughtlist.Count + ")" : "장바구니";
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        void addMenu(item o)
        {
            for(int i = 0; i < Boughtlist.Count; ++i)
            {
                if (Boughtlist[i].isEqual(o))
                {
                    ++Boughtlist[i].quantity;
                    return;
                }
            }

            Boughtlist.Add(o);
        }
    }
}
