using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp9_2
{
    class jari : Account
    {
        int max;

        public jari(Person p, int balance, int max) : base(balance, p)
        {
            this.max = max;
        }
    }
}
