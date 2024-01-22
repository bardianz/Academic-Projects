using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp10
{
    class Edu:Book
    {
        string grade;
        public string gradeProp { get { return grade; } set { grade = value; } }

        public Edu (string title, Author a, string grade) : base(title,a)
        {
            this.grade = grade;
        }

    }
}
