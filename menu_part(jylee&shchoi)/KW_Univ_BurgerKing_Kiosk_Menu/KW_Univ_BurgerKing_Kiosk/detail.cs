using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KW_Univ_BurgerKing_Kiosk
{
    public class detail
    {
        public string name; // ex) 치즈주가 +300 원
        public int price = 0;
        public int quantity = 0;
        public detail(string name, int quantity, int price)
        {
            this.name = name;
            this.quantity = quantity;
            this.price = price;
        }

    }
}
