using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPractice.DotNetClasses
{
    public class AnonymousTypeVariable
    {
        public static void Main1()
        {
            var anonymous = new
            {
                firstName = "Dharmanshu",
                lastName = "Soni",
                address = new
                {
                    streetName = "Sojati Gate",
                    city = "Jodhpur"
                },
                projects = new[]
                {
                    new {projectName = "ECommerce", tech=".NET"},
                    new {projectName = "CRM", tech=".NET"},
                    new {projectName = "Website", tech=".NET"}
                }
            };

            Console.WriteLine(anonymous.firstName + ' ' +anonymous.lastName);
            Console.WriteLine(anonymous.address.streetName + ' ' + anonymous.address.city);
            foreach(var project in anonymous.projects)
            {
                Console.WriteLine(project.projectName + ' ' + project.tech);
            }

            Console.ReadLine();
        }
    }
}
