using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    // It cannot be inherited 
    //public class test : Counter
    //{
    //}

    public class Counter
    {
        private Counter() { }

        public static int currentCount;

        public static int IncrementCount()
        {
            return ++currentCount;
        }
    }
    internal class PrivateConstructor
    {
        static void Main1()
        {
            // Private constructors are used to prevent creating instances of a class when there are no instance fields or methods,
            // such as the Math class, or when a method is called to obtain an instance of a class.
            // If all the methods in the class are static, consider making the complete class static.


            // If you uncomment the following statement, it will generate
            // an error because the constructor is inaccessible:
            // Counter aCounter = new Counter();   // Error
            Counter.currentCount = 100;
            Counter.IncrementCount();
            Console.WriteLine("New count: {0}", Counter.currentCount);

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

            //Counter aCounter = new Counter();   // Error

        }
    }
}
