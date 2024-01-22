using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp9_2
{
    class Pasandaz : Account
    {
        int profit;
        public int profitProp { get { return profit; } set { profit = value; } }

        public Pasandaz(Person p, int balance, int profit) : base(balance, p)
        {
            this.profit = profit;
        }

    }
}
