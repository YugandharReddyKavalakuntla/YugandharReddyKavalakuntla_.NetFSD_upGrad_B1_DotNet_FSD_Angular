using System;


namespace interfaceAssignment{

    public abstract class SalesBase  {

        protected double DailySales = 400;

        public double GetDailySales(){
            return DailySales;
        }

        public abstract double GetMonthlySales(double dailySales);
        
        







    }



}