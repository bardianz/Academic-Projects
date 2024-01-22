using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    class Eat:Food
    {
        double meat;
        public double sugarProperty { get { return meat; } set { meat = value; } }

        public Eat(string name, double meat) : base(name)
        {
            this.meat = meat;
        }
    }
}
