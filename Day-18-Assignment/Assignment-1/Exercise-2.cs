// Write an algorithm for accepting distance in kilometers, 
// convert it into meters and display the result.

using System;

namespace Assignment
{
    
public class Excrcise2{


    public void kmToMtr(double a)
        {
            if(a > 0)
            {
             double meters = a * 1000;
             Console.WriteLine(a + "Kilomerts " + "=" + meters +" Meters");
            }
            else
            {
                Console.WriteLine("Enter More Than Zero KM");
            }
        }
    

}
}