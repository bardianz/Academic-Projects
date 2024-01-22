using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class Controller:File
    {
        
        public static void Save(Customer c)
        {
            customerArr[ci] = c;
            ci++;
        }
        public static void Save(Vote v)
        {
            voteArr[vi] = v;
            vi++;
        }

        public static void Save(Book b)
        {
            bookArr[bi] = b;
            bi++;
        }

        public static void Save(Product p)
        {
            productArr[pi] = p;
            pi++;
        }

        public static int votei = 0;

        public static Book[] Search()
        {
            Book[] temp = new Book[100];
            votei = 0;

            for (int j = 0; j < vi; j++)
            {
                if (voteArr[votei].vProp>5)
                {
                    temp[votei] = bookArr[votei];
                    votei++;
                }
            }
            return temp;
        }
    }
}
