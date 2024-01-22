using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    class Customer
    {
        string name;
        public string nameProperty { get { return name; } set { name = value; } }

        public Customer (string name)
        {
            this.name = name;
        }
    }
}
