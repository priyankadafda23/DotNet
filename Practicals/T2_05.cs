using System;

namespace Practicals
{
    internal class T2_05
    {
        public static void T2_5Main()
        {
            int[] arr = new int[5];
            int sum = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter Element {0}: ", i);
                string str = Console.ReadLine();
                arr[i] = Convert.ToInt32(str);
            }
            for (int i = 0; i < 5; i++)
            {
                sum = sum + arr[i];
            }
            Console.WriteLine("Sum of Elements : {0}", sum);
        }
    }
}