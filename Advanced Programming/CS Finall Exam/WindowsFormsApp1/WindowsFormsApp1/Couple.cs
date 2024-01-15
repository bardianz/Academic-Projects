using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Couple:Passenger
    {
        int chidNumber;

        public int chidNumberProp { get { return chidNumber; } set { chidNumber = value; } }

        public Couple (string name, int chidNumber):base(name)
        {
            this.chidNumber = chidNumber;
        }

    }
}
