using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    class Regtengale:Shape
    {
        int h,w;
        public int hProperty { get { return h; } set { h = value; } }
        public int wProperty { get { return w; } set { w = value; } }

        public Regtengale(Center c, int h , int w) :base(c)
        {
            this.h = h;
            this.w = w;
        }
    }
}
