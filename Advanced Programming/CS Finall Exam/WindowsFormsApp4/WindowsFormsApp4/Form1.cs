using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer c1 = new Customer("ali");
            Customer c2 = new Customer("reza");
            Customer c3 = new Customer("hasan");

            Controller.Save(c1);
            Controller.Save(c2);
            Controller.Save(c3);

            Book book1 = new Book("java", "publisher 198", "author 43465");
            Controller.Save(book1);
            Book book2 = new Book("c#", "publisher 138", "author 8465");
            Controller.Save(book2);
            Book book3 = new Book("python", "publisher 138", "author 8465");
            Controller.Save(book3);

            Vote vote1 = new Vote(book1,c1, 10); // امتیاز 10
            Controller.Save(vote1);
            Vote vote2 = new Vote(book2, c2, 6); // امتیاز 6
            Controller.Save(vote2);
            Vote vote3 = new Vote(book3, c1, 2); // امتیاز 1
            Controller.Save(vote3);


            Book [] temp = Controller.Search();    // لیست کتاب هایی که بالای 5 امتیاز دارند

            for (int i = 0; i < Controller.votei; i++)
            {
                MessageBox.Show(temp[i].titleProp);
            }
        }
    }
}
