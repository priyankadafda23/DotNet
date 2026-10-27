using System;
using System.Collections.Generic;

namespace Practicals
{
    class T6_10
    {
        public static void T6_10Main()
        {
            List<int> marks = new List<int>()
            {
                45, 67, 82, 35, 91, 55
            };
            Console.WriteLine("Marks greater than 50:");

            marks.FindAll(m => m > 50).ForEach(m => Console.WriteLine(m));
        }
    }
}