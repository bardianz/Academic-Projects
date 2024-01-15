using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp9_2
{
    class Person
    {
        string name;

        public string nameProp { get { return name; } set { name = value; } }

        public Person(string name)
        {
            this.name = name;
        }
    }
}
