using System;

namespace Practicals
{
    class T5_06
    {
        public static void T5_06Main()
        {
            int[] arr = { 50, 40, 60, 30 };
            int max = arr[0];
            int min = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("Maximum element: {0}", max);
            Console.WriteLine("Minimum element: {0}", min);
        }
    }
}