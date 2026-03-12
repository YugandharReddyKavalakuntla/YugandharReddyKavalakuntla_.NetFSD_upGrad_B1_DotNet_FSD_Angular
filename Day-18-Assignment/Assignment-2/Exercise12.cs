// Write a program to print the numbers divisible by 7 between 200 and 300.



using System;


namespace Assignment2
{

    public class Exercise12
    {

        public  void PrintDivisibleBy7()
        {
            Console.WriteLine("Numbers divisible by 7 between 200 and 300:");

            for (int i = 200; i <= 300; i++)
            {
                if (i % 7 == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
        
        
    }
}