// Assignment-1


using System;

namespace OOPAssignment
{
    public class Staff
    {
        public int StaffId;
        public string Name;
        public double BaseSalary;

        public Staff(int sid, string name, double bsalary)
        {
            StaffId = sid;
            Name = name;
            BaseSalary = bsalary;
        }

        public virtual void CalculateSalary()
        {
            Console.WriteLine("Salary");
        }
    }
}