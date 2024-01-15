using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Room
    {
        int roomID;

        public int roomIDProp { get { return roomID; } set { roomID = value; } }

        public Room (int roomID)
        {
            this.roomID = roomID;
        }
    }
}
