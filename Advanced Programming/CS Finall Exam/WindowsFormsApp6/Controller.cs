using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    class Controller:File
    {
        public static void Save(Student s)
        {
            stuArr[si] = s;
            si++;
        }
        public static void Save(Plan p)
        {
            planArr[pi] = p;
            pi++;
        }
        public static void Save(Entekhab e)
        {
            entekhabArr[ei] = e;
            ei++;
        }
        public static int searchi = 0;
        public static Student[] Search(Plan p)
        {
            Student[] temp = new Student[100];
            searchi = 0;
            for (int i = 0; i< pi; i++)
            {
                if (entekhabArr[i].planProperty.lessonProperty == p.lessonProperty)
                {
                    temp[searchi] = stuArr[i];
                }
            }
            return temp;
        }
    }
}
