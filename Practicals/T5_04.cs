using System;

namespace Practicals
{
    class T5_04
    {
        public static void T5_04Main()
        {
            int[] arr = { 50, 40, 60, 30 , 70 };
            int[] arr2 = new int[5];

            Array.Copy(arr, arr2, arr.Length);

            Console.Write("Elements of the original array:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);
            }

            Console.Write("\nElements of the copied array:");
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write("{0} ", arr2[i]);
            }
        }
    }
}