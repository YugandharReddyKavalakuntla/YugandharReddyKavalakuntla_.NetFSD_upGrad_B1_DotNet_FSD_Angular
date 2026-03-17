
using System;

namespace Assignment1{

    class CheckBalanceException : Exception
{
    public CheckBalanceException(string message) : base(message)
    {
    }
}

    public class BankAccount{

        public int AccountNumber{get; set;}
        public string Name{get; set; }

        public static double Balance{get; set;}

        public char TransactionType { get; set; } 
        public double TransactionAmount { get; set; }


    public BankAccount(int accNo, string name, double initialBalance)
    {
        AccountNumber = accNo;
        Name = name;
        Balance = initialBalance;
    }

    
    public void PerformTransaction()
    {
        if (TransactionType == 'c') 
        {
            Balance += TransactionAmount;
            Console.WriteLine("Amount Credited Successfully.");
        }
        else if (TransactionType == 'd') 
        {
            if (Balance - TransactionAmount < 500)
            {
                throw new CheckBalanceException("Minimum balance of 500 must be maintained!");
            }
            Balance -= TransactionAmount;
            Console.WriteLine("Amount Debited Successfully.");
        }
        else
        {
            Console.WriteLine("Invalid Transaction Type!");
        }
    }

    public void Display()
    {
        Console.WriteLine($"Account Number: {AccountNumber}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Balance: {Balance}");
    }
}


        







    }

