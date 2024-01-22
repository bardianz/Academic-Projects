using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Home : Estate
    {
        double area;

        public double areaProp { get { return area; } set { area = value; } }


        public Home (int postalCode, double area): base (postalCode)
        {
            this.area = area;
        }
    }
}
