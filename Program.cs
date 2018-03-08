// pass by value & pass by reference example

using System;

namespace ConsoleApp2
{
    
    class Program
    {
        static void passByValue(int value)
        {
            value += 5;
            Console.WriteLine("value inside the function " + value);
        }

        static void passByRef(ref int value)
        {
            value += 5;
            Console.WriteLine("value inside the function " + value);
        }

        static void Main(string[] args)
        {
            int value = 10;
            // pass by value
            Console.WriteLine("value before calling " + value);
            passByValue(value);
            Console.WriteLine("value after calling " + value);

            // pass by reference
            Console.WriteLine("value before calling " + value);
            passByRef(ref value);
            Console.WriteLine("value after calling " + value);
        }
    }
}
