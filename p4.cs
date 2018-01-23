/*

Write a program to find the greatest of the three numbers entered through the keyboard
using conditional operators.

*/

using System;

namespace ConsoleApp1
{
    class p2
    {
        static void Main(string[] args)
        {
            float a, b, c;
            float[] arr = new float[3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Please write an input");
                arr[i] = float.Parse(Console.ReadLine());
            }

            a = arr[0];
            b = arr[1];       
            c = arr[2];
           
            if(a > b && a > c)
            {
                Console.WriteLine("The greatest number is: {0} ", a);
            } else if (b > a && b > c)
            {
                Console.WriteLine("The greatest number is: {0} ", b);
            } else if (c > a && c > b)
            {
                Console.WriteLine("The greatest number is: {0} ", c);
            } else
            {
                Console.WriteLine("All the numbers or two of them are equal");
            }

        }
    }
}
