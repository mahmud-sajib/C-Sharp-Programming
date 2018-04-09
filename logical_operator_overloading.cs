using System;

namespace ConsoleApp2
{
    class Student
    {
        public double grade;

        public Student(double grade)
        {
            this.grade = grade;
        }

        public void Display()
        {
            Console.WriteLine("Grade: " + grade);
        }

        // creating a method for logical operator overloading
        public static bool operator &(Student ob1, Student ob2)
        {

            bool result = ((ob1.grade == 0) && (ob2.grade == 0));
            return result; // returns false coz the above condition is incorrect

        }

        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student ob1 = new Student(10);
            Student ob2 = new Student(20);

            // comparing two objects to make relational operator overloading
            Console.WriteLine(ob1 & ob2);
           


        }
    }
}
