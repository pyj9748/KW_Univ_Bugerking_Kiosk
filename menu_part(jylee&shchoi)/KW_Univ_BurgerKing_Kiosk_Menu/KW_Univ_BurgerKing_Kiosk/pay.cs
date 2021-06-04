using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KW_Univ_BurgerKing_Kiosk
{
    public  class pay
    {

        public string payway ="";
        public int paymoney;
        public List<item> boughtlist = new List<item>();

        public pay(string payway, int paymoney, List<item> boughtlist) {

            this.payway = payway;
            this.paymoney = paymoney;
            this.boughtlist = boughtlist;
        }
    }
}
