using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp11
{
    class Student:Member
    {
        string reshte;
        public string reshteProperty { get { return reshte; } set { reshte = value; } }

        public Student(string name, string reshte) : base(name)
        {
            this.reshte = reshte;
        }
    }
}
