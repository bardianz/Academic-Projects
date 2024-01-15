using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person p1 = new Person("ali");
            Controller.Save(p1);

            Account acc1 = new Account(1000, p1);
            acc1.Save();

            Account[] listOfAccount = Controller.Search(p1);   // لیست حساب های علی
        }
    }
}
