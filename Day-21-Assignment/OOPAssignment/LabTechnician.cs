// Assignment-1


using System;

namespace OOPAssignment
{
    public class LabTechnician : Staff
    {
        public double EquipmentAllowance;

        public LabTechnician(int sid, string name, double bsalary, double allowance)
            : base(sid, name, bsalary)
        {
            EquipmentAllowance = allowance;
        }

        public override void CalculateSalary()
        {
            double total = BaseSalary + EquipmentAllowance;

            Console.WriteLine($"Lab Technician ID : {StaffId}");
            Console.WriteLine($"Lab Technician Name : {Name}");
            Console.WriteLine($"Lab Technician Salary : {total}");

            
        }
    }
}