using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Exercise
{
    class Weapons //Parent
    {
        public string type = "";
        public string make = "";

        public virtual void Capacity()
        {
            Console.WriteLine("");
        }

    }
}
