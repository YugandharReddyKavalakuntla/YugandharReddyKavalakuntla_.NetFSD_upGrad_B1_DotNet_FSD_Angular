// Write an algorithm for accepting five numbers and display the sum and average of the numbers.



using System;

namespace Assignment
{

public class Excrcise3{

    public void avg()
        {
            double total = 0;
            double num;

            for(int i=1; i<=5; i++)
            {
               num =  Convert.ToDouble(Console.ReadLine());
               total += num;

            }

            double avg = total/5;

            Console.WriteLine("Sum " + total);

            Console.WriteLine("Average " + avg);


        }
    

}
    
}

