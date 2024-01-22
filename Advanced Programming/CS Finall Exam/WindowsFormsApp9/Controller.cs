using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp9_2
{
    class Controller:File
    {
        public static void Save(Person p)
        {
            personArr[pi] = p;
            pi++;
        }
        public static void Save(Account a)
        {
            accountArr[ai] = a;
            ai++;
        }

        public static int searchi = 0;

        public static Account[] Search(Person p)
        {
            Account[] temp = new Account[100];
            searchi = 0;
            for (int i = 0; i < ai; i++)
            {
                if (accountArr[i].accountPersonProp.nameProp == p.nameProp)
                {
                    temp[searchi] = accountArr[i];
                }
            }

            return temp;
        }
    }
}
