using System;

namespace Practicals
{
    class T5_07
    {
        public static void T5_07Main()
        {
            int[] arr = { 50, 40, 60, 30, 15, 23, 55 };
            int[] even = new int[arr.Length];
            int[] odd = new int[arr.Length];
            int e = 0;
            int o = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    even[e] = arr[i];
                    e++;
                }
                else
                {
                    odd[o] = arr[i];
                    o++;
                }
            }
            Console.WriteLine("Even elements:");
            for (int i =0; i < e; i++)
            {
                Console.WriteLine(even[i]+" ");
            }
            Console.WriteLine("\nOdd elements");
            for (int i = 0; i < o; i++)
            {
                Console.WriteLine(odd[i] + " ");
            }
        }
    }
}