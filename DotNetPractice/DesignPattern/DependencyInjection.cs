using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPractice.DesignPattern
{
    public interface IService
    {
        void Serve();
    }
    public class Service1 : IService
    {
        public void Serve()
        {
            Console.WriteLine("Service1 Called");
        }
    }
    public class Service2 : IService
    {
        public void Serve()
        {
            Console.WriteLine("Service2 Called");
        }
    }
    public class Client
    {
        private IService _service;
        public Client(IService service)
        {
            _service = service;
        }
        public void ServeMethod()
        {
            _service.Serve();
        }
    }

    internal class DependencyInjection
    {
        static void Main1(string[] args)
        {
            //creating object
            Service1 s1 = new Service1();
            //passing dependency
            Client c1 = new Client(s1);
            //TO DO:
            c1.ServeMethod();

            Service2 s2 = new Service2();
            //passing dependency
            c1 = new Client(s2);
            //TO DO:
            c1.ServeMethod();
        }
    }
}
