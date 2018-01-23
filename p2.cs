using System;

namespace ConsoleApp1
{
    class p2
    {
        static void Main(string[] args)
        {
            float d, x1, x2, y1, y2;
            float[] arr = new float[4];
            
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Please write an input");
                arr[i] = float.Parse(Console.ReadLine());
            }

            x1 = arr[0];
            x2 = arr[1];
            y1 = arr[2];
            y2 = arr[3];

            d = ( (x2 - x1)*(x2 - x1) ) + ( (y2 - y1)*(y2 - y1) );
            Console.WriteLine("The distance is:\n" + Math.Sqrt(d));

        }
    }
}
