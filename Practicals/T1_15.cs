using System;

namespace Practicals
{
    internal class T1_15
    {
        public static void Armstrongnum()
        {
            Console.Write("Enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());
            int original = num;
            int rem,arm = 0;
            while (num != 0)
            {
                rem = num % 10;
                arm = arm + (rem * rem * rem);
                num = num / 10;
            }
                if (original == arm)
                {
                    Console.WriteLine("This is Armstrong number.");
                }
                else
                {
                    Console.WriteLine("This is not Armstrong number.");
                }
        }
    }
}