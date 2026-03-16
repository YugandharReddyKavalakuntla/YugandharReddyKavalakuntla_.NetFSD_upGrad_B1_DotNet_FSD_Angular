using System;


namespace Assignment3{

    public class InternationalOrder : Order{


        public InternationalOrder(int oid, double oamount) : base(oid, oamount){
            
        }



        public override void CalculateShippingCost()
        {
             Console.WriteLine($"Order Id : {Orderid}");
            Console.WriteLine("Express Delevery Charges : 500");

        }

        

        





    }





}