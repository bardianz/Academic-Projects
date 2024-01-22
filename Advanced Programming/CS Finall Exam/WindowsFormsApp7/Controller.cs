using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    class Controller : File
    {
        public static void Save(Shape s)
        {
            shapeArr[si] = s;
            si++;
        }

        public static void Save(Center c)
        {
            centerArr[centi] = c;
            centi++;
        }

        public static void Save(Regtengale r)
        {
            regArr[ri] = r;
            ri++;
        }
        public static void Save(Circle c)
        {
            circleArr[ci] = c;
            ci++;
        }

        public static int searchi = 0;
        public static Shape[] Search (Center c)
        {
            Shape[] temp = new Shape[100];

            searchi = 0;

            for (int i = 0;i<si; i++)
            {
                if (shapeArr[i].centerProperty == c)
                {
                    {
                        temp[searchi] = shapeArr[i];
                        searchi++;
                    }
                }
            }
            return temp;
        }
    }
}
