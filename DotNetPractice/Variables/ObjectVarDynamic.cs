using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPractice.Variables
{
    internal class ObjectVarDynamic
    {
        // Object:
        // Each object in C# is derived from object type, either directly or indirectly.
        // It is compile time variable and require boxing and unboxing for conversion and it makes it slow.
        // You can change value type to reference type and vice versa.
        public void CheckObject()
        {
            object test = 10;
            //test = test + 10;    // Compile time error
            test = "hello";      // No error, Boxing happens here
        }

        //Var:
        //It is compile time variable and does not require boxing and unboxing.
        //Since Var is a compile time feature, all type checking is done at compile time only.
        //Once Var has been initialized, you can't change type stored in it.
        public void CheckVar()
        {
            var test = 10;         // after this line test has become of integer type
            test = test + 10;      // No error
            //test = "hello";        // Compile time error as test is an integer type
        }

        //Dynamic:
        //It is run time variable and not require boxing and unboxing.
        //You can assign and value to dynamic and also can change value type stored in same.
        //All errors on dynamic can be discovered at run time only.
        //We can also say that dynamic is a run time object which can hold any type of data.
        public void CheckDynamic()
        {
            dynamic test = 10;
            test = test + 10;     // No error
            test = "hello";       // No error, neither compile time nor run time
        }

        static void Main1(string[] args) { 
        }
    }
}
