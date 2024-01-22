using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class Book : Product
    {
        string author;
        public string authorProp { get { return author; } set { author = value; } }

        public Book(string title, string publisher, string author) : base(title, publisher)
        {
            this.author = author;
        }

    }
}
