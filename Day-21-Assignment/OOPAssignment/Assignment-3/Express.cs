using System;


namespace Assignment3{

    public class ExpressOrder : Order{


        public ExpressOrder(int oid, double oamount) : base(oid, oamount){
            
        }



        public override void CalculateShippingCost()
        {
             Console.WriteLine($"Order Id : {Orderid}");
            Console.WriteLine("Express Delevery Charges : 100");

        }



        





    }





}