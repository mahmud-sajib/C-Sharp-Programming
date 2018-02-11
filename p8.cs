using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 2;
            Console.WriteLine(a & b);
            Console.WriteLine(a | b);
            Console.WriteLine(a ^ b);
            Console.WriteLine(a >> b);
            Console.WriteLine(a << b);
            Console.WriteLine(~a);
        }
    }
}
