using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c;
            Console.WriteLine("please input the salary: \n");
            a = float.Parse(Console.ReadLine());
            b = (a*40) / 100;
            a = a - b;
            c = (a * 20) / 100;
            a = a - c;
            Console.WriteLine("Robin's Gross salary is: " + a);
        }
    }
}
