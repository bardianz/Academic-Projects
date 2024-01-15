using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Author a1 = new Author("ali");
            Controller.save(a1);

            Book b1 = new Book("book1", a1);
            b1.Save();

            Controller.Search(a1); //  لیست کتاب های نوشته شده توسط علی
        }
    }
}
