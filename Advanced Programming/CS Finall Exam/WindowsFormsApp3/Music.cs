using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class Music:Product
    {
        string artist;

        public string artistProp { get { return artist; } set { artist = value; } }
        public Music (string title, string publisher, string artist):base (title, publisher)
        {
            this.artist = artist;
        }
    }
}
