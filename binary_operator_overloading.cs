using System;

namespace ConsoleApp1
{
    class Student
    {
        public int id;
        public double grade;

        public Student(int id, double grade)
        {
            this.id = id;
            this.grade = grade;
        }

        public void Display()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Grade: " + grade);
        }

        // creating a method for operator overloading
        public static Student operator +(Student ob1, Student ob2)
        {
            Student newStudent = new Student(ob1.id + ob2.id, ob1.grade + ob2.grade);
            return newStudent;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student ob1 = new Student(2,95);
            Student ob2 = new Student(5,80);

            // adding two objects to make operator overloading
            Student ob3 = ob1 + ob2;
            ob3.Display();
        }
    }
}
