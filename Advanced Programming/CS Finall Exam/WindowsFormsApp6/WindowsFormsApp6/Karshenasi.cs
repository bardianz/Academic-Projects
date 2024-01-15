using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    class Karshenasi:Student
    {
        string highschool;
        public string highschoolProperty { get { return highschool; } set { highschool = value; } }

        public Karshenasi(string name, string highschool) :base(name)
        {
            this.highschool = highschool;
        }
    }
}
