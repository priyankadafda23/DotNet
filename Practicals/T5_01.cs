using System;

namespace Practicals
{
    class T5_01
    {
        public static void T5_01Main()
        {
            int[] arr = { 50, 40, 60, 30 };
            for(int i = 0; i<arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            //printing individual elements of array
            Console.WriteLine("Last Element: " + arr[3]);
        }
    }
}