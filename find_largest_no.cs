using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());
            if (a > b)
            {
                if (a > c)
                {
                    if (a > d)
                    {
                        Console.WriteLine("Largest number is " + a);
                    }
                    else
                    {
                        Console.WriteLine("Largest value is " + d);
                    }
                }
                else
                {
                    if (c > d)
                    {
                        Console.WriteLine("Largest value is " + c);
                    }
                    else
                    {
                        Console.WriteLine("Largest value is " + d);
                    }

                }
            }
            else
            {
                if (b > c)
                {
                    if (b > d)
                    {
                        Console.WriteLine("Largest value is " + b);
                    }
                    else
                    {
                        Console.WriteLine("Largest value is " + d);
                    }
                }
                else
                {
                    if (c > d)
                    {
                        Console.WriteLine("Largest value is " + c);
                    }
                    else
                    {
                        Console.WriteLine("Largest value is " + d);
                    }
                }
            }
        }
    }
}
