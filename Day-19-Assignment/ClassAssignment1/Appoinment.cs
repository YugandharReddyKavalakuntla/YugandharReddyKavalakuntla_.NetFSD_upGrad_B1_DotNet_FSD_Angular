// Assignment-4

using System;

namespace classassignment1{

    public class Appoinment{

        int AppointmentId;
        string PatientName;
        string DoctorName;
        DateTime AppointmentDate;

        
        public Appoinment(int aid, string pn){
            this.AppointmentId = aid;
            this.PatientName = pn;
            this.DoctorName = "Dr Amrith Nath";
            this.AppointmentDate = DateTime.Today;
        }


        public void print(){
            Console.WriteLine($"Appointment Id: {AppointmentId}");
        Console.WriteLine($"Patient Name: {PatientName}");
        Console.WriteLine($"Doctor Name: {DoctorName}");
        Console.WriteLine($"Appointment Date: {AppointmentDate.ToShortDateString()}");
        Console.WriteLine("--------------------");
        }





    }


}