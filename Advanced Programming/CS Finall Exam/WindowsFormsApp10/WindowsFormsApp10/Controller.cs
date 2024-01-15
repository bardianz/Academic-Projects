using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp10
{
    class Controller:File
    {
        public static void save(Author a)
        {
            authorArr[ai] = a;
            ai++;
        }
        public static void save(Book b)
        {
            bookArr[bi] = b;
            bi++;
        }
        public static int searchi = 0;
        public static Book[] Search (Author a)
        {
            Book[] temp = new Book[100];
            searchi = 0;

            for (int i = 0; i<bi;i++)
            {
                if (bookArr[i].authorProp.nameProp == a.nameProp)
                {
                    temp[searchi] = bookArr[i];
                    searchi++;
                }
            }

            return temp;
        }
    }
}
