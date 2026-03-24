using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Linq
{
    internal class Assignment4
    {
        public record Employee(int Id, string Name, string Department, double Salary);
        public static void Main()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(4456,"Shivas","Programmer",75000),
                new Employee(1111, "gayi", "IT", 100000),
                new Employee(2222, "yogi", "dataScientist", 25000),
                new Employee(3333, "harsh", "CA", 2900000),

            };
            var dep = employees.Where(n => n.Department == "IT");

            foreach (var n in dep)
                Console.WriteLine(n);

            //highest salry
            var high = employees.OrderByDescending(n => n.Salary).FirstOrDefault();
            Console.WriteLine(high);
        }
    }
}
