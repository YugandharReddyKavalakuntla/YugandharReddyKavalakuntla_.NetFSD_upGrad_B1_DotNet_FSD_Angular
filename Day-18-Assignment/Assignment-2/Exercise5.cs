// Write a program in C# to find the total number of odd and even numbers accepted from the user.


using System;


namespace Assignment2
{

    public class Exercise5
    {
        public void CountOddEven()
        {
            Console.Write("How many numbers do you want to enter? ");
            int n = Convert.ToInt32(Console.ReadLine());

            int evenCount = 0;
            int oddCount = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Enter number " + i + ": ");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }

            Console.WriteLine("Total even numbers: " + evenCount);
            Console.WriteLine("Total odd numbers: " + oddCount);
        }


    }

   
    
}