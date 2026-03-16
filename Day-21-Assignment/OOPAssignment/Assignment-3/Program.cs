using System;

namespace Assignment3{


    public class Program{

        public static void Main(string[] args){



            List<Order> orders = new List<Order>();

            orders.Add(new StandardOrder(101, 200));
            orders.Add(new ExpressOrder(102, 699));
            orders.Add(new InternationalOrder(103,4999));


            foreach(Order ord in orders){
                ord.CalculateShippingCost();
                Console.WriteLine();
            }



            

        }



    }



}