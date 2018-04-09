using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int res =1;
            Console.WriteLine("Plz input a number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Output");
            for (int i = 1; i <= a; i++)
            {
                res = res*i;
            }
            Console.WriteLine("Final result:" + res);
        }
    }
}
