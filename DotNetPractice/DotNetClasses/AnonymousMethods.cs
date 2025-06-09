using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPractice.DotNetClasses
{
    public delegate void PrintMessage(string msg);
    internal class AnonymousMethods
    {
        public static void InvokeMehthod()
        {
            PrintMessage printMessage = delegate (string msg)
            {
                Console.WriteLine("Message " + msg);
            };
            printMessage("Hey its me");
        }
    }
    public class RunAnonymousMethods
    {
        public static void Main1(string[] args)
        {
            AnonymousMethods.InvokeMehthod();
            Console.ReadLine();
        }
    }
}
