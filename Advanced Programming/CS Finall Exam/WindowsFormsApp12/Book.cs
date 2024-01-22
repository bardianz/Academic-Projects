using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp12
{
    class Book:Source
    {
        string author;
        public string authorProperty { get { return author; } set { author = value; } }

        public Book (string name, string author): base(name)
        {
            this.author = author;
        }
    }
}
