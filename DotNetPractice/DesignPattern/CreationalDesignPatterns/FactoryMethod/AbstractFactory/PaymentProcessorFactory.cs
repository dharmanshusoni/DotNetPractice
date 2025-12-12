using DotNetPractice.DesignPattern.CreationalDesignPatterns.FactoryMethod.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetPractice.DesignPattern.CreationalDesignPatterns.FactoryMethod.AbstractFactory
{
    public abstract class PaymentProcessorFactory
    {
        // Factory Method
        public abstract IPaymentProcessor CreateProcessor();

        // Business Logic using created product
        public void ExecutePayment(decimal amount)
        {
            IPaymentProcessor processor = CreateProcessor();
            processor.ProcessPayment(amount);  // client code unaware of concrete class
        }
    }

}
