// Assignment-5

using System;

namespace classassignment1{

    public class MedicalTest{

        int TestId;
        string TestName;
        double TestCost;

        public MedicalTest(int tid, string tname, double tcost){
            this.TestId = tid;
            this.TestName = tname;
            this.TestCost = tcost;

            Console.WriteLine($"Test ID : {TestId}");
            Console.WriteLine($"Test Name : {TestName}");
            Console.WriteLine($"Test Cost : {TestCost}");
            Console.WriteLine("---------------------------");


        }






    }





}