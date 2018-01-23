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

            // storing digits into array
            int[] arr = new int[5] { dig1, dig2, dig3, dig4, dig5 } ;

            // printing the digits
            for(int i=4; i >= 0; i--)
            {
                Console.Write(arr[i]);
            }
            Console.ReadLine();
        }
    }
}
