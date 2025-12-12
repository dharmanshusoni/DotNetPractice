using DotNetPractice.DesignPattern.CreationalDesignPatterns.FactoryMethod.AbstractFactory;
using DotNetPractice.DesignPattern.CreationalDesignPatterns.FactoryMethod.FactoryImplementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetPractice.DesignPattern.CreationalDesignPatterns.FactoryMethod
{
    internal class FactoryMethod
    {
        static void Main(string[] args)
        {
            PaymentProcessorFactory factory;

            // e.g., choose payment method based on user choice
            Console.WriteLine("Choose payment: 1. CreditCard 2. PayPal 3. Crypto");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
                factory = new CreditCardFactory();
            else if (choice == 2)
                factory = new PaypalFactory();
            else
                factory = new CryptoFactory();

            factory.ExecutePayment(1500.00m);
        }
    }
}
