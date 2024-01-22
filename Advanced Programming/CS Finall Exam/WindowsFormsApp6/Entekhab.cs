using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    class Entekhab
    {
        Plan p;
        Student s;

        public Plan planProperty { get { return p; } set { p = value; } }
        public Student studentProperty { get { return s; } set { s = value; } }

        public Entekhab (Plan p,Student s)
        {
            this.p = p;
            this.s = s;
        }

        public void Save()
        {

        }
    }
}
