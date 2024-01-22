using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp9_2
{
    class Account
    {
        int balance;
        Person p;

        public int balanceProp { get { return balance; } set { balance = value; } }
        public Person accountPersonProp { get { return p; } set { p = value; } }

        public Account(int balance, Person p)
        {
            this.p = p;
            this.balance = balance;
        }

        public void Save()
        {
            Controller.Save(this);
        }
    }
}
