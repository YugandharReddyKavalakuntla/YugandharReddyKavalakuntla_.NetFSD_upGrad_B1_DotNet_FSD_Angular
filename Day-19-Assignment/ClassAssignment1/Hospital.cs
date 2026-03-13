// Assignment-3

using System;

namespace classassignment1{

    public class Hospital{

        static string HospitalName = "Bangalore Baptist Hospatil";
        static string HospitalAddress = "Hebbal, Bangalore";
        string PatientName; 

        public Hospital(string pn){
            this.PatientName = pn;
        }


        public void display(){
            Console.WriteLine("Hospital Name :" + HospitalName);
            Console.WriteLine("Hospital Address :" + HospitalAddress);
            Console.WriteLine("Patient Name :" + PatientName);
            Console.WriteLine("-----------------------------------------");

        }






    }




}