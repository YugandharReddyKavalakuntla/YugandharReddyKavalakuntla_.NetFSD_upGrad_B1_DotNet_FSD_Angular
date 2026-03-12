// A shopkeeper sells three products whose retail prices are as follows: Product 1, 22.5;
// product 2, 44.50; and product 3, 9.98. Write an application that reads a series of pairs of
// numbers as follows:
// a)product number
// b)quantity sold
// and calculate the total price.

using System;

namespace Assignment2
{
    public class Exercise7
    {

        public  void CalculateTotalPrice()
        {
            int productNumber;
            int quantity;
            double totalPrice = 0;

            while (true)
            {
                Console.Write("Enter product number (1-3) or 0 to exit: ");
                productNumber = Convert.ToInt32(Console.ReadLine());

                if (productNumber == 0)
                    break;

                Console.Write("Enter quantity sold: ");
                quantity = Convert.ToInt32(Console.ReadLine());

                switch (productNumber)
                {
                    case 1:
                        totalPrice += quantity * 22.5;
                        break;

                    case 2:
                        totalPrice += quantity * 44.50;
                        break;

                    case 3:
                        totalPrice += quantity * 9.98;
                        break;

                    default:
                        Console.WriteLine("Invalid product number");
                        break;
                }
            }

            Console.WriteLine("Total Retail Value: " + totalPrice);
        }
    }
}