using DotNetPractice.DesignPattern.CreationalDesignPatterns.FactoryMethod.AbstractFactory;
using DotNetPractice.DesignPattern.CreationalDesignPatterns.FactoryMethod.Implementation;
using DotNetPractice.DesignPattern.CreationalDesignPatterns.FactoryMethod.Interface;

namespace DotNetPractice.DesignPattern.CreationalDesignPatterns.FactoryMethod.FactoryImplementation
{
    public class CreditCardFactory : PaymentProcessorFactory
    {
        public override IPaymentProcessor CreateProcessor()
        {
            return new CreditCardProcessor();
        }
    }

    public class PaypalFactory : PaymentProcessorFactory
    {
        public override IPaymentProcessor CreateProcessor()
        {
            return new PaypalProcessor();
        }
    }

    public class CryptoFactory : PaymentProcessorFactory
    {
        public override IPaymentProcessor CreateProcessor()
        {
            return new CryptoProcessor();
        }
    }

}
