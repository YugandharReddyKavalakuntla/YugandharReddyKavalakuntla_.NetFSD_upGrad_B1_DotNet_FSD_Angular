
// Write a program in C# to find the smallest of five numbers accepted from the user.


using System;


namespace Assignment2
{

    public class Exercise14
    {
        
        public  void FindSmallest()
        {
            int[] numbers = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            int smallest = numbers[0];

            for (int i = 1; i < 5; i++)
            {
                if (numbers[i] < smallest)
                {
                    smallest = numbers[i];
                }
            }

            Console.WriteLine("The smallest number is: " + smallest);
        }
    }
}