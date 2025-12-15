using DotNetPractice.DesignPattern.CreationalDesignPatterns.AbstractFactory.AbstractProducts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetPractice.DesignPattern.CreationalDesignPatterns.AbstractFactory.ConcreteProducts.Windows
{
    public class WindowsButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Rendering Windows style Button");
        }
    }
}
