using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Center c1 = new Center(10, 10);
            Controller.Save(c1);

            Shape s1 = new Shape(c1);
            s1.Save();

            Shape[] temp =Controller.Search(c1);

        }
    }
}
