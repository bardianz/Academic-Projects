using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    class Center
    {
        int x, y;
        public int xProperty { get { return x; } set { x = value; } }
        public int yProperty { get { return y; } set { y = value; } }

        public Center(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
