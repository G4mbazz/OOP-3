using System;

namespace OOP_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Geometri sqr = new Fyrkant();
            Console.WriteLine("Area Fyrkant: " + sqr.Area());
            Geometri rek = new Rektangel();
            Console.WriteLine("Area Rektangel: " + rek.Area());
            Geometri cir = new Cirkel();
            Console.WriteLine("Area Cirkel: " + cir.Area());
        }
    }
}
