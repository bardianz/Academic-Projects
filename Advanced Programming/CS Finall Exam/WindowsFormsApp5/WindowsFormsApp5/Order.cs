using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    class Order
    {
        Food f;
        Customer c;
        int vote;
        public int orderVoteProperty { get { return v; } set { v = value; } }

        public Food orderFoodProperty { get { return f; } set { f = value; } }
        public Customer orderCustomerProperty { get { return c; } set { c = value; } }

        public void Vote (int vote)
        {
            this.vote = vote;
        }
        public Order(Food f, Customer c)
        {
            this.f = f;
            this.c = c;
        }


    }
}
