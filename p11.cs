﻿using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter two sides of a rectangle: ");
            double a, b;
            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());

            Console.WriteLine("Height {0,10: :0#.##} m", a);
            Console.WriteLine("Width  {0,10: :0#.##} m", b);
            Console.WriteLine("Area   {0,10: :##.##} m", a*b);
        }
    }
}
