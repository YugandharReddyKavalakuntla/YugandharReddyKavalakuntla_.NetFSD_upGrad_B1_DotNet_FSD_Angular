using System;

namespace OOPAssignment
{
    public class Program
    {
        public static void Main(string[] args)
        {

            // Assignment-1
            Doctor d1 = new Doctor(101, "Dr Madhusudhan NC", 250000, 100000);
            d1.CalculateSalary();

            Nurse n1 = new Nurse(101, "Devid Brother", 45000, 10000);
            n1.CalculateSalary();

            LabTechnician L1 = new LabTechnician(101, " Naima", 25000, 8000);
            L1.CalculateSalary();

            Console.WriteLine("---------------------------------------");
            Console.WriteLine();

            


        
        }
    }
}