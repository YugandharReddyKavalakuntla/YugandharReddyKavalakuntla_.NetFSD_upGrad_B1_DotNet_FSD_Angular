// Assignment-8

using System;

namespace classassignment1{

    public class PatientRecord{

        int PatientId;
        string PatientName;
        byte PatientAge;
        string PatientDisease;
        static string HospitalName = "Bangalore Baptist Hosptail";


        public PatientRecord(int pid, string pname, byte page, string pdisease ){
            this.PatientId = pid;
            this.PatientName = pname;
            this.PatientAge =page;
            this.PatientDisease = pdisease;
        }

        public void DisplayPatientRecord(){
            Console.WriteLine($"Hospital : {PatientRecord.HospitalName}");
            Console.WriteLine();
            Console.WriteLine($"Patient Id : {PatientId}");
            Console.WriteLine($"Patient Name : {PatientName}");
            Console.WriteLine($"Patient Age : {PatientAge}");
            Console.WriteLine($"Disease : {PatientDisease}");
            Console.WriteLine();
            Console.WriteLine();







        }






    }






}