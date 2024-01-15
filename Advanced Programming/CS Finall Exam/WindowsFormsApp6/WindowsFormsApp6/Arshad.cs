using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    class Arshad:Student
    {
        string reshte;
        public string reshteProperty { get { return reshte; } set { reshte = value; } }

        public Arshad(string name, string reshte) : base(name)
        {
            this.reshte = reshte;
        }
    }
}
