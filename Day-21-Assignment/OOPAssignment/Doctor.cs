// Assignment-1


using System;

namespace OOPAssignment
{
    public class Doctor : Staff
    {
        public double ConsultationFee;

        public Doctor(int sid, string name, double bsalary, double cfee)
            : base(sid, name, bsalary)
        {
            ConsultationFee = cfee;
        }

        public override void CalculateSalary()
        {
            Console.WriteLine($"Doctor ID : {StaffId}");
            Console.WriteLine($"Doctor Name : {Name}");
            Console.WriteLine($"Doctor Salary : {BaseSalary + ConsultationFee}");
        }
    }
}