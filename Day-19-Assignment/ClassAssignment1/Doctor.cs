// Assignment-2

using System;

namespace classassignment1{

    public class Doctor{

       int DoctorId;
        string DoctorName;

       string Specialization;

        double ConsultationFee;


        public Doctor(int did, string dname, string speciliz, double consult){
            this.DoctorId = did;
            this.DoctorName = dname;
            this.Specialization = speciliz;
            this.ConsultationFee = consult;

            Console.WriteLine($"Doctor ID : {DoctorId}");
            Console.WriteLine($"Doctor Name : {DoctorName}");
            Console.WriteLine($"Specilazation : {Specialization}");
            Console.WriteLine($"Consultation Fee  : {ConsultationFee}");

        }




    }


}