using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Exercise
{
    class Handgun : Weapons
    {
        public override void Capacity()
        {
            base.Capacity();
            Console.WriteLine("Capacity: 16 rounds of 9mm");
        }
    }
}
