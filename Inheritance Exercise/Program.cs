using System;

namespace Inheritance_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Two leading special operations forces in the US are:");
            SEALs S = new SEALs();
            S.Branch();
            S.Mission();
            Rangers R = new Rangers();
            R.Branch();
            R.Mission();

            Console.WriteLine("Both use:");
            Rifle m = new Rifle();
            m.type = "M4";
            m.make = "Colt";
            Console.WriteLine(m.make + " " + m.type);
            m.Capacity();
            Console.WriteLine("and");
            Handgun h = new Handgun();
            h.type = "M9";
            h.make = "Beretta";
            Console.WriteLine(h.make + " " + h.type);
            h.Capacity();


        }
    }
}
