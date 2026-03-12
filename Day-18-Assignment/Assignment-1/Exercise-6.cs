// Write an algorithm for calculating the area of rectangle and square separately.
using System;

namespace Assignment
{

public class Excrcise6{

    public void Rectangle()
        {
            Console.WriteLine("Enter Length of the Rectangle");
            double leng = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Enter Berdth of the Rectangle");
            double bedt = Convert.ToDouble(Console.ReadLine());

            double area = leng*bedt;

            Console.WriteLine("Area of Rectangle : " + area);


        }

        public void Square()
        {
            Console.WriteLine("Enter size of the Square");
            double size = Convert.ToDouble(Console.ReadLine());

            double area = size * size;

            Console.WriteLine("Area of Square : " + area);
            
        }
    

}
    
}

