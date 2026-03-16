// Assignment-1


using System;


namespace OOPAssignment{

    public class Nurse : Staff{

        public double NightShiftAllowance;

        public Nurse(int sid, string Nname, double nsalary , double Nalllowance ) : base (sid, Nname, nsalary){
            NightShiftAllowance = Nalllowance;
        }


        public override void CalculateSalary()
        {
             double total = BaseSalary + NightShiftAllowance;

            Console.WriteLine($"Nurse ID : {StaffId}");
            Console.WriteLine($"Nurse Name : {Name}");
            Console.WriteLine($"Nurse Salary : {total}");
        }



    }





}