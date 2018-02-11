/*

Robin’s basic salary is input through the keyboard. His dearness allowance is 40% of basic
salary, and house rent allowance is 20% of basic salary. Write a program to calculate his
gross salary.

*/
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double gross_salary, b, a1, a2;

            Console.WriteLine("Plz input basic salary");

            b = float.Parse(Console.ReadLine());

            a1 = (b * 0.4);
            a2 = (b * 0.2);

            gross_salary = a1 + a2 + b;

            Console.WriteLine(gross_salary);
        }
    }
}
