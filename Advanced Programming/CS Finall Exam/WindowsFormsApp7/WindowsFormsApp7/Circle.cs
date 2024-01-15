using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    class Circle:Shape
    {
        int r;
        public int rProperty { get { return r; } set { r = value; } }

        public Circle(Center c, int r) : base(c)
        {
            this.r = r;
        }
    }
}
