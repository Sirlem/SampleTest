using System;
using System.Collections.Generic;
using System.Text;

namespace SampleTest
{
    public class Student
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public int mark { get; set; }
        public string grade;

        public Student(string StudentFirstname, string StudentLastname, int StudentMarks)
        {
            firstname = StudentFirstname;
            lastname = StudentLastname;
            mark = StudentMarks;
         
        }
        public int MARKS
        {
            get
            {
                return mark;
            }
            set
            {
                mark = value;

                {
                    if (value > 0)
                    {
                        if (value <= 100)
                        {
                            mark = value;
                        }
                    }
                }
                    }
                }
        public string Grade
        {
         get
            { 
                string Grade = string.Empty;

                if (mark >= 70)
                {
                    Console.WriteLine("A");
                }
                else if (mark >= 60)
                {
                    Console.WriteLine("B");
                }
                else if (mark >= 50)
                {
                    Console.WriteLine("C");
                }
                else
                {
                    Console.WriteLine("D");
                }
                return Grade;
            }
        }
    }
 }
       
        


