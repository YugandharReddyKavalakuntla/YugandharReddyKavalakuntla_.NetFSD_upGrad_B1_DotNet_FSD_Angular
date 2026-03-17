using System;

namespace interfaceAssignment{

    public class Sale : SalesBase, ISale
    {
        public override double GetMonthlySales(double dailySales)
    {
        return dailySales * 30; // 30 days
    }

    public double YearlySales(double monthlySales)
    {
        return monthlySales * 12;
    }






    }







}