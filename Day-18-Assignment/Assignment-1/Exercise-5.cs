// Write an algorithm for accepting two numbers and display the highest number among two.

using System;

namespace Assignment
{
    

public class Excrcise5{


    public void highestNumber()
        {
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());


            if(num1 > num2)
            {
                Console.WriteLine(num1+" is Highest Number ");
            }
            else if(num2 > num1)
            {
                 Console.WriteLine(num2+" is Highest Number ");
            }
            else
            {
                Console.WriteLine("Both numbers are equal. ");
            }
            
        }
    

}


}

