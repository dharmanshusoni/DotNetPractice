using DotNetPractice.DesignPattern.CreationalDesignPatterns.AbstractFactory.AbstractProducts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetPractice.DesignPattern.CreationalDesignPatterns.AbstractFactory.ConcreteProducts.Mac
{
    public class MacCheckbox : ICheckbox
    {
        public void Render()
        {
            Console.WriteLine("Rendering Mac style Checkbox");
        }
    }
}
