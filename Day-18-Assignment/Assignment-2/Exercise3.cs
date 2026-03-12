// Write a program in C# to accept two numbers as command line argument and display all
// the numbers between the given two numbers.


using System;


namespace Assignment2
{

    public class Exercise3
    {
        public void PrintNumbersBetween(int start, int end)
        {
            if (start > end)
            {
                Console.WriteLine("First number should be smaller than or equal to the second number.");
                return;
            }

            Console.WriteLine($"Numbers between {start} and {end}:");

            for (int i = start + 1; i < end; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine(); 
        }


        


    }

   
    
}