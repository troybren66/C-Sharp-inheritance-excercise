using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Exercise
{
    class SEALs : SpecialOperations //derived class (child)
    {
        
        public override void Mission()
        {
            base.Mission();
            Console.WriteLine("Mission: Direct Action from Sea, Air, or Land");
        }

        public override void Branch()
        {
            base.Branch();
            Console.WriteLine("Navy SEALS");
        }
    }
}
