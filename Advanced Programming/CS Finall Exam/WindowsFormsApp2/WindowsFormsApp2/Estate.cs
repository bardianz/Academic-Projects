using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Estate
    {
        int postalCode;

        public int postalCodeProp { get { return postalCode; } set { postalCode = value; } }

        public Estate(int postalCode)
        {
            this.postalCode = postalCode;
        }
        public void Save()
        {
            Controller.save(this);
        }
    }
}
