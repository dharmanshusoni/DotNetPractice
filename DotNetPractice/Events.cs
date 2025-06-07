using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Events
    {
        public delegate void delegateOddNumber();
        public event delegateOddNumber eventOddNumber;

        public void add()
        {
            int number1 = 100;
            int number2 = 200;
            var result = number1 + number2;
            Console.WriteLine(result);
            if (result%2 == 0 && eventOddNumber != null)
            {
                eventOddNumber();
            }
        }
    }
    public class RunEvents
    {
        public static void Main1(string[] args)
        {
            Events events = new Events();
            events.eventOddNumber += new Events.delegateOddNumber(EventMessage);
            events.add();
            Console.ReadLine();
        }

        public static void EventMessage()
        {
            Console.WriteLine("Event Triggered");
        }
    }
}
