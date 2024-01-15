using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp12
{
    class Controller:File
    {
        public static void Save(Member m)
        {
            memArr[membi] = m;
            membi++;
        }
        public static void Save(Source s)
        {
            sorcArr[sorci] = s;
            sorci++;
        }
        public static void Save(Rent r)
        {
            rentArr[renti] = r;
            renti++;
        }
        public static int searchi = 0;

        public static Book [] Search (Member m)
        {
            Book[] temp = new Book[100];

            for (int i=0;i<renti; i++)
            {
                if (rentArr[i].rentMemberProperty.nameProperty == m.nameProperty)
                {
                    temp[searchi] = rentArr[i].rentBookProperty;
                }
            }
            return temp;
        }
    }
}
