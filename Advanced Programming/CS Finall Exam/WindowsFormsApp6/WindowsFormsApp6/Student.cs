using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    class Student
    {
        string name;
        public string nameProperty { get { return name; } set { name = value; } }

        public Student (string name)
        {
            this.name = name;
        }
        public void Save()
        {
            Controller.Save(this);
        }
    }
}
