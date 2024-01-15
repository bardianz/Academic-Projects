using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class Vote
    {
        Product p;
        Customer c;

        int v;

        public Product productProp { get { return p; } set { p = value; } }
        public Customer customerProp { get { return c; } set { c = value; } }
        public int vProp { get { return v; } set { v = value; } }

        public Vote (Product p , Customer c  , int v)
        {
            this.c = c;
            this.p = p;
            this.v = v;
        }

        public void VoteProduct()
        {
            Controller.Save(this);
        }
    }
}
