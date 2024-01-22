using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp10
{
    class Book
    {
        string title;
        Author a;

        public string titleProp { get { return title; } set { title = value; } }
        public Author authorProp { get { return a; } set { title = a; } }

        public Book(string title, Author a)
        {
            this.a = a;
            this.title = title;
        }

        public void Save()
        {
            Controller.save(this);
        }
    }
}
