﻿using System;

namespace ConsoleApp4
{
    class p5
    {
        static void Main(string[] args)
        {
            //string a = "Excelent";
            //string b = "Poor";

            // health condition
            Console.WriteLine("Write health condition? Excellent or Poor: \n");           
            string hc = Console.ReadLine();
            Console.WriteLine("Health condition: {0} ",hc);
            string e = "Excellent";
            string p = "Poor";
           
            // age
            Console.WriteLine("Write age : \n");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Age: {0} ",age);

            // living place
            Console.WriteLine("Write living place? City or Village: \n");
            string lp = Console.ReadLine();
            Console.WriteLine("Living place: {0} ", lp);
            string c = "City";
            string v = "Village";

            // gender

            Console.WriteLine("Write gender? Male or Female: \n");
            string fg = Console.ReadLine();
            Console.WriteLine("Gender: {0} ", fg);
            string m = "Male";
            string f = "Female";


            if (hc == e && (age>=25 && age<=35) && lp==c && fg==m)
            {
                Console.WriteLine("Premium is 4 tk and maximum insured amount is 2 lakhs");
            } else if(hc == e && (age >= 25 && age <= 35) && lp == c && fg == f)
            {
                Console.WriteLine("Premium is 3 tk and maximum insured amount is 1 lakhs");
            } else if(hc == p && (age >= 25 && age <= 35) && lp == v && fg == m)
            {
                Console.WriteLine("Premium is 6 tk and maximum insured amount is 1000");
            } else
            {
                Console.WriteLine("The person is not insured.");
            }
           
            
        }
    }
}
