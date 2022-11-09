using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_3
{
    internal class Cirkel : Geometri
    {
        private double Radius;

        public Cirkel()
        {
            Radius = 5;
        }

        public override double Area()
        {
            area = Radius * Radius * 3.141;
            return area;
        }
    }
}
