using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Member m1 = new Member("ali");
            Controller.Save(m1);
            Source s1 = new Source(" name ");
            Controller.Save(s1);
            Rent r1 = new Rent(m1, s1);
            r1.rentBook();

            Member[] temp = Controller.Search(r1);
        }
    }
}
