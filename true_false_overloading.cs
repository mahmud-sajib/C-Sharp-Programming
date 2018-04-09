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

        // creating a method for true false operator overloading

        public static bool operator true(Student ob1)
        {
            if (ob1.grade != 0)
                return true;
            else
                return false;
        }

        public static bool operator false(Student ob1)
        {
            if (ob1.grade == 0)
                return true;
            else
                return false;
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            Student ob1 = new Student(20);

            // comparing to make true false operator overloading
            if (ob1)
            {
                Console.WriteLine("Non Zero result");
            }
            else
            {
                Console.WriteLine("Results Zero");
            }



        }
    }
}
