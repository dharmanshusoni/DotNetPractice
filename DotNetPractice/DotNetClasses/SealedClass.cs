using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPractice.DotNetClasses
{
    class a
    {

    }

    sealed class Sealedc : a
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }

    // Sealed classes are used to restrict the users from inheriting the class.
    
    //class Example : Sealedc // cannot derive from sealed type ‘Sealedc’
    //{
    //}

    internal class SealedClass
    {
        static void Main1(string[] args)
        {
            Sealedc slc = new Sealedc();
            int total = slc.Add(6, 4);

            Console.WriteLine("Total = " + total.ToString());
        }
    }
}
