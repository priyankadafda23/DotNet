using System;
using System.Collections.Generic;
using System.Linq;

namespace Practicals
{
    class T6_11
    {
        public static void T6_11Main()
        {
            List<int> numbers = new List<int>()
            {
                25, 10, 8, 17, 4, 30, 15, 12
            };

            var evenNumbers= from n in numbers 
                             where n%2==0 
                             orderby n 
                             select n;
            Console.WriteLine("Even Numbers: ");

            foreach(int n in evenNumbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}