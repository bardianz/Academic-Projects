using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp12
{
    class Mag : Source
    {
        int num;
        public int numProperty { get { return num; } set { num = value; } }

        public Mag(string name, int num) : base(name)
        {
            this.num = num;
        }
    }
}
