using Example_3_Week_4;
using System;

namespace Example_2_Week_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Amenda", 21, "South African");

            student.DisplayBasicInfo();
            student.DisplayStudentInfo();

            Console.WriteLine($"Student Name: {student.Name}"); // public allowed

            //Console.WriteLine(student.Age);  Not allowed (private)
            //Console.WriteLine(student.Nationality);

            Console.ReadLine();
        }
    }
}