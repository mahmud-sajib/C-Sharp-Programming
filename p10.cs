using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please write your marks");
            int number = int.Parse(Console.ReadLine());
            number = number / 10;

            Console.WriteLine("Your grade is:");
            
            switch (number)
            {
                case 10:
                case 9:
                    Console.WriteLine("A");
                    break;
                case 8:
                    Console.WriteLine("B");
                    break;
                case 7:
                    Console.WriteLine("c");
                    break;
                case 6:
                    Console.WriteLine("D");
                    break;
                case 5:
                case 4:
                case 3:
                case 2:
                case 1:
                    Console.WriteLine("F");
                    break;
                default:
                    Console.WriteLine("Input is wrong");
                    break;

            }
        }
    }
}
