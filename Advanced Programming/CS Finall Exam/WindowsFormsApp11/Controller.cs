using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp11
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
        public static Member[] Search(Rent r)
        {
            Member[] temp = new Member[100];
            searchi = 0;
            for (int i=0; i < renti; i++)
            {
                if (r.rentSourceProperty.nameProperty == rentArr[i].rentSourceProperty.nameProperty)
                {
                    temp[searchi] = rentArr[i].rentMemberProperty;
                }
            }
            return temp;
        }

    }
}
