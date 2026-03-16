using System;


namespace Assignment3{

    public class StandardOrder : Order{

        public StandardOrder(int sid, double oamount) : base(sid, oamount){

        }


        public override void CalculateShippingCost()
        {
            Console.WriteLine($"Order Id : {Orderid}");
            Console.WriteLine("Standard Delevery Charges : 50");



        }



        

        





    }





}