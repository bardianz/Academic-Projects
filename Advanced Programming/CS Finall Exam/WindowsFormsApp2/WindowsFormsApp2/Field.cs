using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Field : Estate
    {
        string feautres;
        public string feautresProp { get { return feautres; } set { feautres = value; } }

        public Field (int postalcode ,string feauters ): base (postalcode)
        {
            this.feautres = feautres;
        }
    }
}
