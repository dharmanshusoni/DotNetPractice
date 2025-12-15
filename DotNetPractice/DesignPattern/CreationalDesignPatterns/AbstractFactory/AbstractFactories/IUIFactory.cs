using DotNetPractice.DesignPattern.CreationalDesignPatterns.AbstractFactory.AbstractProducts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetPractice.DesignPattern.CreationalDesignPatterns.AbstractFactory.AbstractFactories
{
    public interface IUIFactory
    {
        IButton CreateButton();
        ICheckbox CreateCheckbox();
    }
}
