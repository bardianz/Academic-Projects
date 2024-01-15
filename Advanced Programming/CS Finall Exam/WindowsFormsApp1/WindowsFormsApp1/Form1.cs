using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAli_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            Passenger p1 = new Passenger("ali");
            Passenger p2 = new Passenger("reza");

            p1.save();
            p2.save();

            Room r1 = new Room(101);
            Room r2 = new Room(102);
            Room r3 = new Room(103);
            Room r4 = new Room(104);

            Controller.save(r1);
            Controller.save(r2);
            Controller.save(r3);
            Controller.save(r4);
            

            Rent rent1 = new Rent(p1, r1);
            rent1.RentRoom();

            Rent rent2 = new Rent(p2, r4);
            rent2.RentRoom();

            Rent rent3 = new Rent(p1, r3);
            rent3.RentRoom();

            Room[] p = Controller.search(p1);

            for (int i=0; i<Controller.renti; i++)
            {
                if (p[i] != null)
                {
                   listBox1.Items.Add(p[i].roomIDProp.ToString());
                   //MessageBox.Show(p[i].roomIDProp.ToString());
                } 
            }         
        }

        

        private void btnReza_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            Passenger p1 = new Passenger("ali");
            Passenger p2 = new Passenger("reza");

            p1.save();
            p2.save();

            Room r1 = new Room(101);
            Room r2 = new Room(102);
            Room r3 = new Room(103);
            Room r4 = new Room(104);

            Controller.save(r1);
            Controller.save(r2);
            Controller.save(r3);
            Controller.save(r4);


            Rent rent1 = new Rent(p1, r1);
            rent1.RentRoom();

            Rent rent2 = new Rent(p2, r4);
            rent2.RentRoom();

            Rent rent3 = new Rent(p1, r3);
            rent3.RentRoom();

            Room[] p = Controller.search(p2);

            for (int i = 0; i < Controller.renti; i++)
            {
                if (p[i] != null)
                {
                    listBox1.Items.Add(p[i].roomIDProp.ToString());
                }
            }
        }
    }
}
