// Accept a number from the user and display whether the given number is an odd number or even number.


using System;


namespace Assignment2
{

    public class Exercise4
    {
         public void CheckOddOrEven()
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine(number + " is an even number.");
            }
            else
            {
                Console.WriteLine(number + " is an odd number.");
            }
        }


    }

   
    
}