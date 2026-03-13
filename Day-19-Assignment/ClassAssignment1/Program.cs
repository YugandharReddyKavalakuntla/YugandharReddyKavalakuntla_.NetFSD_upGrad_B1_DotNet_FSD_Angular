using System;

namespace classassignment1{

    public class Program{


        public static void Main(string[] args){


            // Asignment 1
            Patient patient1 = new Patient(101,"Ramesh",24,"Stomach Pain");
            patient1.DisplayPatientDetails();

            // Assignment-2
            Doctor doctor1 = new Doctor(101,"Dr Madhusudan NC","Microsurgen",500);
            Doctor doctor2 = new Doctor(102, "Gayathri Bhindu", "Plastic Surgon", 800);

            //  Assignment-3
            Hospital hospital1 = new Hospital("Yugandhar");
            Hospital hospital2 = new Hospital("Vani");

            hospital1.display();
            hospital2.display();


            // Assignment-4
            Appoinment apoint1 = new Appoinment(1,"Yugandhar");
            Appoinment apoint2 = new Appoinment(2,"Santhu");
            Appoinment apoint3 = new Appoinment(3,"Nikitha");

            
            apoint1.print();
            apoint2.print();
            apoint3.print();

            //Asignment-5
            MedicalTest MedicalTest1 = new MedicalTest(1,"x-ray", 475);
            MedicalTest MedicalTest2 = new MedicalTest(2,"ECG", 200);

            //Assignment-6
            Biling Biling1 = new Biling("Yugandhar", 365, 865);
            Biling Biling2 = new Biling("vani", 365, 425);
            Biling1.CalculateTotalBill();
            Biling2.CalculateTotalBill();




            











        }
    }


}



