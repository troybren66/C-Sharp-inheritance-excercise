using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Exercise
{
    class Rangers : SpecialOperations //derived class (child)
    {
        public override void Mission()
        {
            base.Mission();
            Console.WriteLine("Mission: Direct Action and support");
        }

        public override void Branch()
        {
            base.Branch();
            Console.WriteLine("Army Rangers");
        }
    }
}
