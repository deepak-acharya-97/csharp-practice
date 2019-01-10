using System;
using DeepakExtensionMethods;
using System.Collections.Generic;

namespace play_with_struct
{
    struct Student 
    {
        public string RollNumber;
        public string Name;

        public Student(string RollNumber, string Name)
        {
            Console.WriteLine("I'm called only with new keyword");
            this.RollNumber=RollNumber;
            this.Name=Name;
        }
        // public string OfficialEmailId;
        // public string Address;
        // public float[] SGPAs;
        // public int[] Credits;
        // public float CGPA;

        // public void CalculateCGPA()
        // {
        //     float numerator=this.SGPAs.Sum();
        //     int denomenator=this.Credits.Sum();

        //     this.CGPA=numerator/denomenator;
        // }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students=new Student[10];
            Student s;
            s.RollNumber="1";
            s.Name="Deepak Acharya";
            Student s1= new Student("14IT210", "Deepak Acharya");
            students[0]=s;
        }
    }
}
