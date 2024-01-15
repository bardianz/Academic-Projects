using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp10
{
    class Author
    {
        string name;
        public string nameProp { get { return name; } set { name = value; } }

        public Author (string name)
        {
            this.name = name;
        }
    }
}
