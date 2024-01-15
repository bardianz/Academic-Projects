using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
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

            Music m1 = new Music("music 1", "publisher 165", "artist1");
            m1.save(); // Controller.Save(m1);
            Book b1 = new Book("java", "publisher 198", "author 46465");
            b1.save(); // Controller.Save(b1);


            Basket buy1 = new Basket(c1, b1);
            Controller.Save(buy1);
            Basket buy2 = new Basket(c2, m1);
            Controller.Save(buy2);
            Basket buy3 = new Basket(c3, b1);
            Controller.Save(buy3);


            Customer[] temp = Controller.Search(b1);       // لیست مشتری هایی که کتاب جاوا خریده اند

            for (int i = 0; i < Controller.searchi; i++)
            {
                    MessageBox.Show(temp[i].nameProp);
            }
        }
    }
}
