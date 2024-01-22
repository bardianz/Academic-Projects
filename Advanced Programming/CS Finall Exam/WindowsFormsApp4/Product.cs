using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class Product
    {
        string title;
        string publisher;

        public string titleProp { get { return title; } set { title = value; } }
        public string nampublisherProp { get { return publisher; } set { publisher = value; } }

        public Product(string title, string publisher)
        {
            this.title = title;
            this.publisher = publisher;
        }

        public void save()
        {
            Controller.Save(this);
        }
    }
}
