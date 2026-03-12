// Write an algorithm for accepting a number and display the whether it is odd or even.
using System;

namespace Assignment
{

public class Excrcise4{

    public void evenORodd()
        {
            Console.WriteLine("Enter a Number : ");
           int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine(number + " is Even");
            }else
            {
                Console.WriteLine(number + " is Odd");
            }

        }
    

}
    
}

