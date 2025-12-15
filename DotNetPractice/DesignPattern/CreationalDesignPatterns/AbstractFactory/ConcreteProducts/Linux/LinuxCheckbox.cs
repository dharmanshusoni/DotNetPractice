using DotNetPractice.DesignPattern.CreationalDesignPatterns.AbstractFactory.AbstractProducts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetPractice.DesignPattern.CreationalDesignPatterns.AbstractFactory.ConcreteProducts.Linux
{
    public class LinuxCheckbox : ICheckbox
    {
        public void Render()
        {
            Console.WriteLine("Rendering Linux style Checkbox");
        }
    }
}
