using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPractice.DotNetClasses
{
    public class PrimaryConstructors
    {
        //a constructor is a special method called when a class object is created
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }

        public PrimaryConstructors(string firstName, string lastName, decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
        }

        static void Main1()
        {
            var employee = new PrimaryConstructors("John", "Doe", 50000);
            employee.print();
        }

        public void print()
        {
            Console.WriteLine($"Name : {FirstName} {LastName}");
            Console.WriteLine($"Salary : {Salary}");
            Console.ReadLine();
        }
    }

    // Primary Constructor
    //public class EmployeeRecords(string firstName, string lastName, decimal salary)
    //{
    //    public string FirstName { get; init; } = firstName;
    //    public string LastName { get; init; } = lastName;
    //    public decimal Salary { get; init; } = salary;

    //    static void Main()
    //    {
    //        var employee = new EmployeeRecords("John", "Doe", 50000);
    //        employee.print();
    //    }

    //    public void print()
    //    {
    //        Console.WriteLine($"Name : {FirstName} {LastName}");
    //        Console.WriteLine($"Salary : {Salary}");
    //        Console.ReadLine();
    //    }
    //}
}// 