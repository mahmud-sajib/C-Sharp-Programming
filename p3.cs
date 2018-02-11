/*

If a five-digit number is input through the keyboard, write a program to print a new number
by adding one to each of its digits. For example if the number that is input is 12391 then the
output should be displayed as 23402. (Hint: Use the modulus operator ‘%’)

*/

using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int value, dig1, dig2, dig3, dig4, dig5;
            Console.WriteLine("Please enter a 5 digit value: \n");
            value = Convert.ToInt32(Console.ReadLine());
           
            // separating digits
            dig1 = value % 10;
            value = value / 10;

            dig2 = value % 10;
            value = value / 10;

            dig3 = value % 10;
            value = value / 10;

            dig4 = value % 10;
            value = value / 10;

            dig5 = value % 10;
            value = value / 10;

            // adding 1 to each digit
            dig1 =  ((dig1 + 1) % 10);
            dig2 =  ((dig2 + 1) % 10);
            dig3 =  ((dig3 + 1) % 10);
            dig4 =  ((dig4 + 1) % 10);
            dig5 =  ((dig5 + 1) % 10);

            
            // printing the digits
             Console.WriteLine("{0} {1} {2} {3} {4} ", d5, d4, d3, d2, d1);
           
        }
    }
}
