// Assignment-1

using System;

namespace classassignment1{

    public class Patient{
        int PatientId;
        string PatientName;
        byte Age;
        string Disease;

        public Patient(int pid, string pname, byte age, string disease){
            this.PatientId = pid;
            this.PatientName = pname;
            this.Age = age;
            this.Disease = disease;
        }

        public void DisplayPatientDetails(){
            Console.WriteLine($"Patient Id : {PatientId}");
            Console.WriteLine($"Patient Name : {PatientName}");
            Console.WriteLine($"Patient Age : {Age}");
            Console.WriteLine($"Patient Disease : {Disease}");

        }

    }
}