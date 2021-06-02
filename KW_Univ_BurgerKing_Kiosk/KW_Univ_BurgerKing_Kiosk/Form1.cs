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
    public partial class Form1 : Form
    {
        List<item> menulist = new List<item>(); // 메뉴 리스트 여기에 너희가 만든 메뉴 추가해
        List<detail> detaillist = new List<detail>(); // 세부 사항 리스트 너희가 만든 세부사항 추가
        List<item> Boughtlist = new List<item>(); // 여기는 산 메뉴 추가하는 리스트
        
        public Form1()
        {
            InitializeComponent();
        }
    }
}
