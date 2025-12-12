using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetPractice.DesignPattern.CreationalDesignPatterns.FactoryMethod.Interface
{
    public interface IPaymentProcessor
    {
        void ProcessPayment(decimal amount);
    }
}
