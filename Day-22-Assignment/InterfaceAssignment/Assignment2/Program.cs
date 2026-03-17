using System;

namespace interfaceAssignment{
    
class Program
{
    static void Main()
    {
        Sale obj = new Sale();

        double daily = obj.GetDailySales();
        double monthly = obj.GetMonthlySales(daily);
        double yearly = obj.YearlySales(monthly);

        Console.WriteLine("Daily sales: Rs." + daily);
        Console.WriteLine("Monthly sales: Rs." + monthly);
        Console.WriteLine("Annual sales: Rs." + yearly);
    }
}


}
