using System;


namespace Assignment1{
    
class Program
{
    static void Main()
    {
        try
        {
            BankAccount acc = new BankAccount(101, "John", 1000);

            acc.TransactionType = 'd';
            acc.TransactionAmount = 600;

            acc.PerformTransaction();  
            acc.Display();
        }
        catch (CheckBalanceException ex)
        {
            Console.WriteLine("Exception: " + ex.Message);
        }
    }
}
}