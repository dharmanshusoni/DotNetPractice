using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPractice.Variables
{
    internal class RefOut
    {
        // It is not compulsory to initialize a parameter or argument before it is passed to an out.
        public static void UpdateByOut(out int G)
        {
            //=>ERROR  G++;  Need to assign in passes method
            G = 0;
            G++;
        }

        // The parameter or argument must be declared and initialized first before it is passed to ref.
        public static void UpdateByRef(ref int G)
        {
            G++; // Do not need to assign in passes method
        }



        public static void Main1()
        {
            
            UpdateByOut(out int c);
            Console.WriteLine("Update By Out : {0}", c);

            int b = 0;
            UpdateByRef(ref b);
            //=>ERROR  UpdateByRef(ref int b) shows Error Because it needs to declare and initialize first

            Console.WriteLine("Update By Ref : {0}", b);

            Console.ReadKey();
        }
    }
}
