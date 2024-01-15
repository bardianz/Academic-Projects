using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Controller:File
    {
        public static void save(customer c)
        {
            custumerArr[ci] = c;
            ci++;
        }
        public static void save(Estate e)
        {
            estateArr[ei] = e;
            ei++;
        }
        public static void save(Buy b)
        {
            BuyArr[bi] = b;
            bi++;
        }

        public static Estate[] search (customer c)
        {
            Estate[] temp = new Estate[100];
            
            for (int i =0; i<bi; i++)
            {
                if (BuyArr[i].BuyCustumerProp.custumerNameProp == c.custumerNameProp)
                {
                    temp[i] = BuyArr[i].BuyEstateProp;
                }
            }
            return temp;
        }
    }
}
