// Write an algorithm for accepting the distance and speed values for a particular journey, calculate
// the time taken for the journey and display the same.
using System;

namespace Assignment
{
    
public class Excrcise7{

    public void CalculateTime()
        {
            Console.Write("Enter distance of the journey (km): ");
            double distance = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter speed (km/h): ");
            double speed = Convert.ToDouble(Console.ReadLine());

            if(speed <= 0)
            {
                Console.WriteLine("Speed must be greater than zero.");
                return;
            }

            double time = distance / speed;  

            Console.WriteLine("Time taken for the journey: " + time + " hours");
        }
    

}
}

