using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp10
{
    class Social:Book
    {
        string category;

        public string categoryProp { get { return category; } set { category = value; } }

        public Social (string title, Author a, string category):base(title,a)
        {
            this.category = category;
        }

    }
}
