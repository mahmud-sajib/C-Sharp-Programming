using System;

namespace Program1b
{
    class Program
    {         
     
        static void Main(string[] args)
        {
            int a = 1;
            for (int j = 1; j <= 7 ; j++)
            {               
                for (int i = j; i <= 6; i++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(a);
                a = a * 10;
            }
        }
    }
}
