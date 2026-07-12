using System;

namespace Practicals
{
    internal class Factorial
    {
        public static void Factorialf()
        {
            int n, fact = 1;
            Console.WriteLine("Enter Factorial Number:");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 0; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial of " + n + " is: " + fact);
            Console.ReadLine();
        }
    }
}
