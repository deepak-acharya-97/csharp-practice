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
            Console.WriteLine("I'm called only with new keyword with rollnumber and name passed as arguments");
            this.RollNumber = RollNumber;
            this.Name = Name;
        }

        public override string ToString()
        {
            return $"***\nName : {this.Name}\nRoll Number: {this.RollNumber}\n***";
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
            Student[] students = new Student[10];
            Student s;
            s.RollNumber = "1";
            s.Name = "Deepak Acharya"; // commenting this will be error as all properties must be initialised before using it (line 42)
            Student s1 = new Student("14IT210", "Deepak Acharya");
            Student s2 = new Student(); //Although explicitly can't define default constructor we can pass no args with new keyword.
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            students[0] = s2;

            //Output

            // $ dotnet run
            // I'm called only with new keyword with rollnumber and name passed as arguments
            // * **
            // Name : Deepak Acharya
            // Roll Number: 14IT210
            // ***
            // ***
            // Name :
            // Roll Number:
            // ***


        }
    }
}
