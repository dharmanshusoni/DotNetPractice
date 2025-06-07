using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{


    /// <summary>
    /// We can define class members as static using the static keyword.When we declare a member of a class as static,
    /// it means no matter how many objects of the class are created, there is only one copy of the static member.
      
    /// The keyword static implies that only one instance of the member exists for a class.
      
    /// Static variables are used for defining constants because their values can be
    /// retrieved by invoking the class without creating an instance of it.
      
    /// Used for sharing same data between functions
      
    ///     Sealed Class       |        Static Class
    /// --------------------------|-------------------------
    /// it can inherit From other | it cannot inherit From other
    /// classes but cannot be     | classes as well as cannot be
    /// inherited                 | inherited

    // Static class should have only static functions and variables
    /// </summary>
    class StaticVar
        {
            public static int num;

            public void count()
            {
                num++;
            }

            public int getNum()
            {
                return num;
            }
        }

        class StaticTester
        {
            static void Main1(string[] args)
            {
                StaticVar s1 = new StaticVar();
                StaticVar s2 = new StaticVar();
            
                s1.count();
                s1.count();
                s1.count();

                s2.count();
                s2.count();
                s2.count();

                Console.WriteLine("Variable num for s1: {0}", s1.getNum());
                Console.WriteLine("Variable num for s2: {0}", s2.getNum());
                Console.ReadKey();
            }
        }
    
}
