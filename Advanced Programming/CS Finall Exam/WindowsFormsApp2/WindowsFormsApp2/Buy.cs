using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Buy
    {
        customer c;
        Estate e;

        public customer BuyCustumerProp { get { return c; } set { c = value; } }
        public Estate BuyEstateProp { get { return e; } set { e = value; } }

        public Buy (customer c, Estate e)
        {
            this.c = c;
            this.e = e;
        }

        public void BuyEstate()
        {
            Controller.save(this);
        }
    }
}
