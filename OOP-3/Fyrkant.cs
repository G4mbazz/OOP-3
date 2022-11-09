using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_3
{
    internal class Fyrkant : Geometri
    {
        private double Side;
        public Fyrkant()
        {
            Side = 4;
        }
        public override double Area()
        {
            area = Side * Side;
            return area;
        }
    }
}
