using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp12
{
    class Source
    {
        string name;
        public string nameProperty { get { return name; } set { name = value; } }

        public Source(string name)
        {
            this.name = name;
        }
    }
}
