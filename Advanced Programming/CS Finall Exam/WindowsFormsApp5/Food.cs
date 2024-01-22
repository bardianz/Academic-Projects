using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    class Food
    {
        string name;
        public string nameProperty { get { return name; } set { name = value; } }

        public Food(string name)
        {
            this.name = name;
        }
        public void Save ()
        {
            Controller.Save(this);
        }
    }
}
