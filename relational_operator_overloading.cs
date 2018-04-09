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

        // creating a method for relational operator overloading
        public static bool operator <(Student ob1, Student ob2)
        {
            if (ob1.grade < ob2.grade)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator >(Student ob1, Student ob2)
        {
            if (ob1.grade > ob2.grade)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student ob1 = new Student(95);
            Student ob2 = new Student(80);

            // comparing two objects to make relational operator overloading

            if (ob1 > ob2)
            {
                Console.WriteLine("StudentOne has more grade than StudentTwo");
            }
            else
            {
                Console.WriteLine("StudentOne has lesser grade than StudentTwo");
            }

        }
    }
}
