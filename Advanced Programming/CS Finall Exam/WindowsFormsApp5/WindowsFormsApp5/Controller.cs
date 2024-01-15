using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    class Controller : File
    {
        public static void Save(Customer c)
        {
            customerArr[ci] = c;
            ci++;
        }
        public static void Save(Food f)
        {
            foodArr[fi] = f;
            fi++;
        }
        public static void Save(Order o)
        {
            orderArr[oi] = o;
            oi++;
        }

        public static int searchi = 0;
        public static Food[] search(Customer c)
        {
            searchi = 0;
            Food[] temp = new Food[100];
            for (int i = 0; i < oi; i++)
            {
                if (orderArr[i].orderCustomerProperty.nameProperty == c.nameProperty)
                {
                    temp[searchi] = orderArr[i].orderFoodProperty;
                }
            }
            return temp;
        }
    }
}
