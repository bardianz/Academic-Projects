﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp12
{
    class Rent
    {
        Member m;
        Source sour;
        Book b;

        public Member rentMemberProperty { get { return m; } set { m = value; } }
        public Source rentSourceProperty { get { return sour; } set { sour = value; } }
        public Book rentBookProperty { get { return b; } set { b = value; } }

        public void rentBook()
        {
            //Controller.Save(this);
        }


        public Rent(Member m, Source sour)
        {
            this.sour = sour;
            this.m = m;
        }
    }
}
