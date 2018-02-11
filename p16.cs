using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           for(int i =100; i <= 500; i++)
            {
                if(i%7==0 && i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
