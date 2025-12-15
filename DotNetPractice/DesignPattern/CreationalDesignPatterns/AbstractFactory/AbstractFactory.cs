using DotNetPractice.DesignPattern.CreationalDesignPatterns.AbstractFactory.AbstractFactories;
using DotNetPractice.DesignPattern.CreationalDesignPatterns.AbstractFactory.ClientApplication;
using DotNetPractice.DesignPattern.CreationalDesignPatterns.AbstractFactory.ConcreteFactories.Linux;
using DotNetPractice.DesignPattern.CreationalDesignPatterns.AbstractFactory.ConcreteFactories.Mac;
using DotNetPractice.DesignPattern.CreationalDesignPatterns.AbstractFactory.ConcreteFactories.Windows;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetPractice.DesignPattern.CreationalDesignPatterns.AbstractFactory
{
    internal class AbstractFactory
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose platform: 1.Windows  2.Mac  3.Linux");
            int choice = int.Parse(Console.ReadLine());

            IUIFactory factory = choice switch
            {
                1 => new WindowsUIFactory(),
                2 => new MacUIFactory(),
                _ => new LinuxUIFactory()
            };

            Application app = new Application(factory);
            app.RenderUI();
        }
    }
}
