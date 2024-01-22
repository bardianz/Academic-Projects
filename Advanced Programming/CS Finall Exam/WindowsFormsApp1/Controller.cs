using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Controller:File
    {
        public static void save(Passenger p)
        {
            PassengerArr[passengi] = p;
            passengi++;
        }
        public static void save(Room r)
        {
            RoomArr[roomi] = r;
            roomi++;
        }
        public  static void save(Rent rnt)
        {
            RentArr[renti] = rnt;
            renti++;
        }

        public static Room[] search(Passenger p)
        {
            Room[] roomArrTemp = new Room[100];
            for (int i=0; i<renti;i++)
            {
                if (RentArr[i].RentPassengerProp.PassengernNameProp == p.PassengernNameProp)
                {
                    roomArrTemp[i] = RentArr[i].RentRoomProp;
                    i++;
                }
            }
            return roomArrTemp;
        }
    }
}
