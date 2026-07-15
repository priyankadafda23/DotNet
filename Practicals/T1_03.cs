using System;

namespace Practicals
{
    internal class T1_03
    {
        public static void OddEven()
        {
            int number;
            Console.WriteLine("Enter a number:");
            number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Number is Even.");
            }
            else
            {
                Console.WriteLine("Number is Odd.");
            }
        }
    }
}