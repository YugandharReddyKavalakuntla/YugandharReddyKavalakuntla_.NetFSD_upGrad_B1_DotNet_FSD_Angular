// Write an algorithm for accepting two numbers, divide the first number by second and display
// their quotient.


using System;

namespace Assignment

{
public class Excrcise1{

    public void Artham(int a, int b)
    {
        if(b == 0)
        {
            Console.WriteLine("Error: Cannot divide by zero.");
        }
        else
        {
            double div = a/b;
            Console.WriteLine("Quotient " + div);
        }
    }


}

}