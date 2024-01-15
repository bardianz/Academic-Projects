using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class Basket
    {
        Customer c;
        Product p;
        public Customer basketCustomerProp { get { return c; } set { c = value; } }
        public Product basketProductProp { get { return p; } set { p = value; } }


        public Basket(Customer c, Product p)
        {
            this.c = c;
            this.p = p;
        }

        public void BuyProduct()
        {
            Controller.Save(this);
        }
    }
}
