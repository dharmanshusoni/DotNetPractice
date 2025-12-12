using DotNetPractice.DesignPattern.CreationalDesignPatterns.FactoryMethod.Interface;

namespace DotNetPractice.DesignPattern.CreationalDesignPatterns.FactoryMethod.Implementation
{
    public class CreditCardProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing Credit Card payment of ₹{amount}");
        }
    }

    public class PaypalProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing PayPal payment of ₹{amount}");
        }
    }

    public class CryptoProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing Cryptocurrency payment of ₹{amount}");
        }
    }

}
