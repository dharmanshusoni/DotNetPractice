using DotNetPractice.DesignPattern.CreationalDesignPatterns.AbstractFactory.AbstractFactories;
using DotNetPractice.DesignPattern.CreationalDesignPatterns.AbstractFactory.AbstractProducts;
using DotNetPractice.DesignPattern.CreationalDesignPatterns.AbstractFactory.ConcreteProducts.Linux;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetPractice.DesignPattern.CreationalDesignPatterns.AbstractFactory.ConcreteFactories.Linux
{
    public class LinuxUIFactory : IUIFactory
    {
        public IButton CreateButton() => new LinuxButton();
        public ICheckbox CreateCheckbox() => new LinuxCheckbox();
    }

}
