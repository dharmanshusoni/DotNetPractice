using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class BaseC
    {
        public class NestedC
        {
            public int x = 200;
            public int y;
        }

        public int GetX()
        {
            NestedC c = new NestedC();
            return c.x;
        }
    }

    public class DerivedC : BaseC
    {
        // Nested type hiding the base type members.
        new public class NestedC
        {
            public int x = 100;
            public int y;
            public int z;
        }
        public int GetX()
        {
            NestedC c = new NestedC();
            return c.x;
        }
        static void Main1()
        {
            // Creating an object from the overlapping class:
            NestedC c1 = new NestedC();

            // Creating an object from the hidden class:
            BaseC.NestedC c2 = new BaseC.NestedC();

            DerivedC c3 = new DerivedC();

            Console.WriteLine(c1.x); //100
            Console.WriteLine(c2.x); //200
            Console.WriteLine(c3.GetX()); //100
            Console.ReadKey();
        }
    }
    internal class InheritanceWithNewKeyword
    {
    }

    
}
