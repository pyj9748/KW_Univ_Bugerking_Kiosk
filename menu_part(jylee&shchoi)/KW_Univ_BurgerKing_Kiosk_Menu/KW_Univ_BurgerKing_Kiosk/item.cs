using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace KW_Univ_BurgerKing_Kiosk
{
    public class item
    {
        public string name; //이름
        public int quantity; // 수량
        public int price; // 가격
        public string type; // 세트메뉴 , 단품 , 사이드메뉴, 음료  이런 값.
        public List<detail> detaillist = new List<detail>(); // 세부사항 있으면 리스트에 추가.
        public bool take_out;

        public item(string name, int quantity, int price , string type)
        {
            this.name = name;
            this.quantity = quantity;
            this.price = price;
            this.type = type;
        }
    }
}
