using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please write an input: ");

            int a = Convert.ToInt32(Console.ReadLine());
            int count = 1;
            Console.WriteLine("Output is: ");
            for (int i = 1; i <= a; i++)
            {
                for(int j=1; j<=i; j++)
                {
                    Console.Write(count + "\t");
                    count++;
                }
                
                Console.WriteLine("");
            }
        }
    }
}
