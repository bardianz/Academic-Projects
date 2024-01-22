using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Rent
    {
        Room r;
        Passenger p;

        public Room RentRoomProp { get { return r; } set { r = value; } }
        public Passenger RentPassengerProp { get { return p; } set { p = value; } }


        public Rent (Passenger p,Room r)
        {
            this.r = r;
            this.p = p;
        }
        public void RentRoom ()
        {
            Controller.save(this);
        }
    }
}
