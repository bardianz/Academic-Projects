using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    class Drink:Food
    {
        double sugar;
        public double sugarProperty { get { return sugar; } set { sugar = value; } }

        public Drink (string name, double sugar):base (name)
        {
            this.sugar = sugar;
        }
    }
}
