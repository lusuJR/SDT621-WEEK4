using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Text;

namespace Example_3_Week_4
{
    class Student : Human
    {
        public Student(string name, int age, string nationality): base(name, age, nationality)
        {
        }

        public void DisplayStudentInfo()
        {
            Console.WriteLine($"Nationality: {Nationality}"); // allowed (protected)
            Console.WriteLine($"Country: {Country}");         // allowed (internal)

            // Console.WriteLine(Age);  Not allowed (private)
        }
    }
}
