using System;

namespace Practicals
{
    internal class T1_05
    {
        public static void Factorial()
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            int fact = 1;

            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            Console.WriteLine($"Factorial of {n} is {fact}");
        }
    }
}
