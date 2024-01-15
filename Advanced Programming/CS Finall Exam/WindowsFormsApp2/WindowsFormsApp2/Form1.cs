using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            customer c1 = new customer("ali");
            customer c2 = new customer("reza");
            Controller.save(c1);
            Controller.save(c2);

            Field f1 = new Field(1234, "feature1");
            Field f2 = new Field(9512, "feature2");
            Controller.save(f1);
            Controller.save(f2);

            Buy b1 = new Buy(c1, f1);
            b1.BuyEstate();
            Buy b2 = new Buy(c2, f2);
            b2.BuyEstate();

            Estate[] p1 = Controller.search(c1);  // لیست زمین هایی که علی خریده
            Estate[] p2 = Controller.search(c2);  // لیست زمین هایی که رضا خریده
        }
    }
}
