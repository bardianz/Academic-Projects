using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8
{
    class PhoneBook:File
    {
        public static Phone[] record = new Phone[100];
        public static void Save(Person p)
        {
            personArr[persI] = p;
            persI++;
        }
        public static void Save(Phone ph)
        {
            phoneArr[phnI] = ph;
            phnI++;
        }

        public static void Delete_Record(Person p)
        {
            for (int i = 0; i < phnI; i++)
            {
                if (phoneArr[i].phonePersonProp.nameProp == p.nameProp)
                {
                    phoneArr[i] = null;
                    phnI--;
                }
            }
        }

        public static int searchNameI = 0;
        public static Phone[] Search (Person p)
        {
            Phone[] temp = new Phone[100];

            searchNameI = 0;

            for (int i=0; i<phnI;i++)
            {
                if (phoneArr[i].phonePersonProp.nameProp == p.nameProp)
                {
                    temp[searchNameI] = phoneArr[i];
                }
            }

            return temp;
        }

        public static int searchNum = 0;

        public static Person[] Search(string num)
        {
            Person[] temp = new Person[100];

            searchNum = 0;

            for (int i = 0; i < phnI; i++)
            {
                if (phoneArr[i].phoneNumberProp == num)
                {
                    temp[searchNum] = phoneArr[i].phonePersonProp;
                }
            }

            return temp;
        }


    }
}
