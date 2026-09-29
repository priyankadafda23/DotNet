using System;

namespace Practicals
{
    class T5_03
    {
        public static void T5_03Main()
        {
            Console.Write("Enter the size of an array: ");
            int n= Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter the Element {0}: ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The array in reverse order: ");
            for (int i=n-1; i>=0; i--)
            {
                Console.Write("{0} ", arr[i]);
            }
        }
    }
}