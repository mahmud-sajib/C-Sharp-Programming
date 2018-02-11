using System;

namespace ConsoleApp1
{
    class A
    {
        public A(string a)
        {
            Console.WriteLine("Hello" + a);
        }
    }
    class B
    {
        static void Main(string[] args)
        {
            A obj1 = new A(@" 'str' ");
        }
    }
}
