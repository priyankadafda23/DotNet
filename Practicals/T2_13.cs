using System;

namespace Practicals
{
    internal class T2_13
    {
        public static void T2_13Main()
        {
            Console.Write("Enter Amount:");
            int amount=Convert.ToInt32(Console.ReadLine());

            int[] notes = { 2000, 500, 200, 100, 50, 20, 10, 5, 2, 1};

            foreach(int note in notes)
            {
                int count = amount / note;
                Console.WriteLine($"Notes of Rs. {note} = {count}");
                amount = amount % note;
            }
        }
    }
}