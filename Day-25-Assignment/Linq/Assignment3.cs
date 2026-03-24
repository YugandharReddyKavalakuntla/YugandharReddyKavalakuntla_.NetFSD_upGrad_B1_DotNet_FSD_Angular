using System;
using System.Collections.Generic;
using System.Text;

namespace Linq
{
    internal class Assignment3
    {
        public static void Main()
        {
            List<string> names = new List<string> { "Ravi", "Kiran", "Amit", "Raj", "Anil" };
            //start with 'A'
            var nameA = names.Where(n => n.StartsWith('A'));
            foreach (var name in nameA)
                Console.WriteLine(name);

            //sort alphabeticallyu
            var alpha = names.OrderBy(n => n);
            foreach (var name in alpha)
                Console.WriteLine(name);

            //Uppercase
            var upper = names.Select(n => n.ToUpper());

            foreach (var name in upper)
                Console.WriteLine(name);
            var length = names.Where(n => n.Length > 4);
            foreach (var name in length)
                Console.WriteLine(name);

        }
    }
}
