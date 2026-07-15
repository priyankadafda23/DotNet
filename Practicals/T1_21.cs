using System;

namespace Practicals
{
    internal class T1_21
    {
        public static void T1_21Main()
        {
            Console.Write("Enter terms:");
            int terms = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter input number:");
            int number = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            int current = 0;
            Console.WriteLine("The series is:");
            for (int i = 1; i <= terms; i++)
            {
                current = current * 10 + number;
                Console.Write(current);
                sum += current;

                if (i < terms)
                {
                    Console.Write(" + ");
                }
            }

            Console.WriteLine("\n\nSum is " + sum);
        }
    }
}