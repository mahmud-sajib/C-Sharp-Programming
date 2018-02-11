using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a value");
            int length = int.Parse(Console.ReadLine());

            int a = 0;
            int b = 1;
            int c;
            Console.Write(a + " ");
            Console.Write(b + " ");

            for(int i = 1; i <= length - 2; i++)
            {
                c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
            }          
        }
    }
}
