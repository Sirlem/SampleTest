using System;

namespace SampleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("JOHN", "SMITH", 60);
            Student student2 = new Student("JOE", "SMITH" ,80);
            Student student3 = new Student("MARY", "DOE" ,77);
            Student student4 = new Student("LIZ", "DOE", 85);
            Student student5 = new Student("JOHN","DOE", 40);
            Console.WriteLine("NAME                MARKS               GRADE");
            Console.WriteLine("---------------------------------------------");

            Console.WriteLine($"{student1.firstname} {student1.lastname}          {student1.Grade} {student1.mark}");
            Console.WriteLine($"{student2.firstname} {student2.lastname}            {student2.mark}   {student2.Grade}");
            Console.WriteLine($"{student3.firstname} {student3.lastname}             {student3.mark}   {student3.Grade}");
            Console.WriteLine($"{student4.firstname} {student4.lastname}              {student4.mark}   {student4.Grade}");
            Console.WriteLine($"{student5.firstname} {student5.lastname}             {student5.mark}   {student5.Grade}");
            Console.ReadLine();

        }

    }
}
