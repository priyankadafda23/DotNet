using System;

namespace Practicals
{
    class OddEvenStr
    {
        public static void Oddevenstr()
        {
            int number;
            Console.WriteLine("Enter a number:");
            string str = Console.ReadLine();
            number = Convert.ToInt32(str);

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