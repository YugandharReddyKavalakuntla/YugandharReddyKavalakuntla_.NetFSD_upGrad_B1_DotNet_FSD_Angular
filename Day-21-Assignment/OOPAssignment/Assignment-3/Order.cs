using System;


namespace Assignment3{

    public class Order{


        public int Orderid;

        public double OrderAmount;


        public Order(int oid, double oamount){
            Orderid = oid;
            OrderAmount = oamount;
        }



        public virtual void CalculateShippingCost(){
            Console.WriteLine($"Order ID : {Orderid}");
            Console.WriteLine("Shiping Charges : 50");
        }

    }





}