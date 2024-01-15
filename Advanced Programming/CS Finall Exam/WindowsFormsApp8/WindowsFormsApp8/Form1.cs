using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
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
            PhoneBook.Save(p1);

            Person p2 = new Person("reza");
            PhoneBook.Save(p2);

            Person p3 = new Person("hasan");
            PhoneBook.Save(p3);

            Phone ph1 = new Phone(p1, "09116667777");
            PhoneBook.Save(ph1);

            Phone ph2 = new Phone(p2, "11");
            PhoneBook.Save(ph2);

            Phone ph3 = new Phone(p3, "09001234511");
            PhoneBook.Save(ph3);

            PhoneBook.Delete_Record(p3);

            Phone[] temp1 = PhoneBook.Search(p1);
            Person [] temp2 = PhoneBook.Search("11");

        }
    }
}
