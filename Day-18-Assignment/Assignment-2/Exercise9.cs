
// Write a program in C# to find the factorial of the given number


using System;


namespace Assignment2
{

    public class Exercise9
    {
        public  void FindFactorial()
        {
            int number;
            long factorial = 1;

            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                factorial = factorial * i;
            }

            Console.WriteLine("Factorial of " + number + " is: " + factorial);
        }
        
        
    }
}