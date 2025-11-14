using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPractice.TypeClass
{
    // Abstract class: is a restricted class that cannot be used to create objects(to access it, it must be inherited from another class).
    // Abstract method: can only be used in an abstract class, and it does not have a body.The body is provided by the derived class (inherited from).

    abstract class AreaClass1
    {
        abstract public int Area();

        public void add() { }

        public virtual int Calculation() { return 0; }
    }
    abstract class AreaClass2
    {
        abstract public int Area();
    }
    class Square : AreaClass1
    {
        int side = 0;

        public Square(int n)
        {
            side = n;
        }

        public override int Area()
        {
            return side * side;
        }

        public override int Calculation()
        {
            return side * side;
        }
    }

    internal class AbstractExample
    {
        public static void Main1()
        {
            Square s = new Square(6);
            Console.WriteLine("Area  = " + s.Area());
            Console.ReadKey();
        }
    }
}
