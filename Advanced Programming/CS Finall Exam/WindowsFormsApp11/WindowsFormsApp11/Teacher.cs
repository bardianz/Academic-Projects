using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp11
{
    class Teacher:Member
    {
        string work;
        public string workProperty { get { return work; } set { work = value; } }

        public Teacher(string name, string work):base(name)
        {
            this.work = work;
        }
    }
}
