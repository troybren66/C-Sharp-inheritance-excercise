using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Exercise
{
    class Rifle : Weapons
    {
        public override void Capacity()
        {
            base.Capacity();
            Console.WriteLine("Capacity: 30 rounds of 5.56");
        }
    }


}
