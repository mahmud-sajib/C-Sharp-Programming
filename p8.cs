using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 2; 
            Console.WriteLine(a & b); // boolean AND operation 
            Console.WriteLine(a | b); // boolean OR operation
            Console.WriteLine(a ^ b); // boolean XOR operation (if a,b both similar result 0 otherwise 1 )
            Console.WriteLine(~a); // boolean NOT operation
        }
    }
}
