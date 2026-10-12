using System;

namespace Practicals
{
    class T5_08
    {
        public static void T5_08Main()
        {
            int[] arr = new int[5];
            for(int i =0; i < arr.Length; i++)
            {
                Console.Write("Enter element " + i + ": ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            //without using function
            //for (int i = 4; i >= 0; i--)
            //{
            //    Console.Write(arr[i] + " ");
            //}

            //with using function
            Array.Sort(arr);
            Array.Reverse(arr);

            Console.WriteLine("Descending Order:");
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
        }
    }
}