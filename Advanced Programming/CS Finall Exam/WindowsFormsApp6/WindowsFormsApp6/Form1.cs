using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student s1 = new Student("ali");
            s1.Save();
            Plan p1 = new Plan("math", "6002", "teacher1");
            Controller.Save(p1);
            Entekhab e1 = new Entekhab(p1, s1);
            Controller.Save(e1);


            Student[] temp = Controller.Search(p1);
        }
    }
}
