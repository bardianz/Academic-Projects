using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8
{
    class Phone
    {
        string number;
        Person p;

        public string phoneNumberProp { get { return number; } set { number = value; } }
        public Person phonePersonProp { get { return p; } set { p = value; } }

        public Phone(Person p,string number)
        {
            this.p = p;
            this.number = number;
        }
    }
}
