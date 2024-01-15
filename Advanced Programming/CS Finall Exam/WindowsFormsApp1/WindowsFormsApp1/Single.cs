using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Single : Passenger
    {
        int age;

        public int ageProp { get { return age; } set { age = value; } }
        public Single (string name, int age): base(name)
        {
            this.age = age;
        }
    }
}
