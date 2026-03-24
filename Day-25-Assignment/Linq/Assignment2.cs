using System;
using System.Collections.Generic;
using System.Text;

namespace Linq
{
    internal class Assignment2
    {
        public static void Main()
        {
            List<int> numbers = new List<int> { 5, 10, 15, 20, 25, 30 };
            var evenNum = numbers.Where(n => n % 2 == 0);
            foreach(var n in evenNum)
                  Console.WriteLine("evenNumbers: " + n);


            //numbers greater than 15
            var greater = numbers.Where(n => n > 15);
            Console.WriteLine("Numbers greater than 15 are: ");
            foreach (var n in greater)
                Console.WriteLine(n);

            //square of each number
            var square = from n in numbers
                         select n * n;
            Console.WriteLine("Squares are: ");
            foreach (var n in square)
                Console.WriteLine(n);
            //count of n divisible by 5
            var count = numbers.Where(n => n % 5 == 0).Count();
            Console.WriteLine(count);

        }

    }
}
