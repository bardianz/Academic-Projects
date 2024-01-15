using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class customer
    {
        string name;

        public string custumerNameProp { get { return name; } set { name = value; } }

        public customer (string name)
        {
            this.name = name;
        }
    }
}
