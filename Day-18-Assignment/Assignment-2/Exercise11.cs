
// Write a program in C# to find the multiplication table of the given number till 20


using System;


namespace Assignment2
{

    public class Exercise11
    {
        public  void PrintTable()
        {
            int number;

            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(number + " x " + i + " = " + (number * i));
            }
        }
        
    }
}