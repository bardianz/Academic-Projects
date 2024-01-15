using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Book b1 = new Book("book 1", "author 1");
            Controller.Save(b1);
            Member m1 = new Member("memb 1");
            Controller.Save(m1);
            Rent r1 = new Rent(m1, b1);
            Controller.Save(r1);

            Book[] temp = Controller.Search(m1);

        }
    }
}
