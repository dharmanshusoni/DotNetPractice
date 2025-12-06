using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetPractice.TypeClass.Generics
{
    // Generic Class Definition
    public class Box<T>
    {
        // T is a placeholder for the actual data type
        public T Content { get; set; }

        public void DisplayType()
        {
            Console.WriteLine($"Content type is: {typeof(T).Name}");
        }
    }
    internal class GenericClass
    {
        public static void Main1(string[] args)
        {
            // Usage (Client Code)
            var intBox = new Box<int>();      // T is int
            intBox.Content = 42;
            Console.WriteLine($"Int Box Content: {intBox.Content}");

            var stringBox = new Box<string>(); // T is string
            stringBox.Content = "Hello";
            Console.WriteLine($"String Box Content: {stringBox.Content}");

            Console.ReadKey();
        }
    }
}