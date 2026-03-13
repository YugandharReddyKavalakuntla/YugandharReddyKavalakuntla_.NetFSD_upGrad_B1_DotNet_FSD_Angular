// Assignment-6

using System;

namespace classassignment1{
    public class Biling{

        string PatientName;
        double ConsultationFee;

        double TestCharges;


        public Biling(string pname, double cfee, double Tcharges){
            this.PatientName = pname;
            this.ConsultationFee = cfee;
            this.TestCharges = Tcharges;
        }


        public void CalculateTotalBill(){
            double totalbill = ConsultationFee + TestCharges;

            Console.WriteLine("Patient Name : "+ PatientName);
            Console.WriteLine("Total Bill : "+ totalbill);
            Console.WriteLine("-------------------------------");
        }







    }
}