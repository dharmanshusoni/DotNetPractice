using DotNetPractice.DesignPattern.CreationalDesignPatterns.AbstractFactory.AbstractFactories;
using DotNetPractice.DesignPattern.CreationalDesignPatterns.AbstractFactory.AbstractProducts;
using DotNetPractice.DesignPattern.CreationalDesignPatterns.AbstractFactory.ConcreteProducts.Mac;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetPractice.DesignPattern.CreationalDesignPatterns.AbstractFactory.ConcreteFactories.Mac
{
    public class MacUIFactory : IUIFactory
    {
        public IButton CreateButton() => new MacButton();
        public ICheckbox CreateCheckbox() => new MacCheckbox();
    }

}
