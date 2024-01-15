using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Food f1 = new Food("food 1");
            f1.Save();
            Customer c1 = new Customer("ali");
            Controller.Save(c1);
            Order o1 = new Order(f1, c1);
            o1.Vote(10);
            Controller.Save(o1);


            Food[] temp = Controller.search(c1);  
        }
    }
}
