using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    class Shape
    {
        Center c;
        public Center centerProperty { get { return c; } set { c = value; } }

        public Shape(Center c)
        {
            this.c = c;
        }

        public void Save()
        {
            Controller.Save(this);
        }

    }
}
