using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPractice.Variables
{
    internal class ConstAndReadOnly
    {
        public const int VALUE = 10;
        // Value cannot be changes in compile time.
        // const is used to create a constant at compile time.


        public readonly int value1;
        // Can only assigned in runtime in constructor and connot be declared inside a function
        // Readonly is a constant defined at runtime.	
        ConstAndReadOnly(int value)
        {
            value1 = value;
        }
        public static void Main1()
        {
            Console.WriteLine(VALUE);
            ConstAndReadOnly p1 = new ConstAndReadOnly(11);
            Console.WriteLine(p1.value1);
            Console.ReadKey();
        }
    }
}
