using System;
using System.Collections.Generic;

namespace Assignment1
{
    public class Student
    {
        public int Id;
        public string Name;
        public float Marks;

    //     public static void Main(string[] args)
    //     {
    //         Dictionary<int, Student> s1 = new Dictionary<int, Student>();


    //         s1.Add(1, new Student{Id=1, Name="Ram", Marks=88f});
    //         s1.Add(2, new Student { Id = 2, Name = "Sita", Marks = 90 });
    //         s1.Add(3, new Student { Id = 3, Name = "Arjun", Marks = 78 });
    //         s1.Add(4, new Student { Id = 4, Name = "Meena", Marks = 88 });
    //         s1.Add(5, new Student { Id = 5, Name = "Kiran", Marks = 92 });

    //         foreach(KeyValuePair<int,Student> pair in s1){
    //             Console.WriteLine($"{pair.Value.Id} - {pair.Value.Name} - {pair.Value.Marks}");
    //         }

    //         Console.WriteLine();


    //         Console.WriteLine("Enter Student ID");
    //         int sid = Convert.ToInt32(Console.ReadLine());

    //         foreach(KeyValuePair<int,Student> pair in s1){
    //             if(sid == pair.Value.Id){
    //                 Console.WriteLine($"Student Id {pair.Value.Id} Student Name {pair.Value.Name} Student Marks {pair.Value.Marks} ");
    //             }else{
    //                 Console.WriteLine("Invalid ID");
    //             }
    //         }


    //         if(s1.ContainsKey(3)){
    //                 Console.WriteLine("Student Exists ");

    //         }else{
    //                 Console.WriteLine("Student Not Exists ");

    //         }


    //         Console.WriteLine("Updating Student Details");
    //         if(s1.ContainsKey(3)){
    //             s1[3].Marks = 99;
    //             Console.WriteLine($"Updated Marks {s1[3].Marks}");
    //         }


    //         Console.WriteLine("\nRemoving student with Id 4:");
    //         if (s1.ContainsKey(4))
    //         {
    //             s1.Remove(4);
    //             Console.WriteLine("Student removed");
    //         }


        




    //     }
    }
}