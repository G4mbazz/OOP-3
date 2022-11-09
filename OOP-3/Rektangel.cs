using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_3
{
    internal class Rektangel : Geometri
    {
        private double Width;
        private double Height;
        public Rektangel()
        {
            Width = 2;
            Height = 7;
            
        }
        public override double Area()
        {
            area = Width * Height;
            return area;
        }

    }
}
