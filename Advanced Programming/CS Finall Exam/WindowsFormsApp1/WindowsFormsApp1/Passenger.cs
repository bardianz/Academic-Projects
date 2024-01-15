using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Passenger
    {
        string name;

        public string PassengernNameProp { get { return name; } set { name = value; } }

        public Passenger (string name)
        {
            this.name = name;
        }

        public void save()
        {
            Controller.save(this);
        }
    }
}
