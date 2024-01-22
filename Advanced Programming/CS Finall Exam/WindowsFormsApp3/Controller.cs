using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class Controller:File
    {
        public static void Save(Product p)
        {
            productArr[pi] = p;
            pi++;
        }
        public static void Save(Customer c)
        {
            customerArr[ci] = c;
            ci++;
        }
        public static void Save(Basket b)
        {
            basketArr[bi] = b;
            bi++;
        }
        public static int searchi = 0;

        public static Customer[] Search(Product p)
        {
            Customer[] temp = new Customer[100];
            searchi = 0;

            for (int j = 0; j<bi; j++)
            {
                if (basketArr[j].basketProductProp.titleProp == p.titleProp)
                {
                    temp[searchi] = customerArr[j];
                    searchi++;
                }
            }
            return temp;
        }
    }
}
