using System;

namespace Practicals
{
    internal class T2_11
    {
        public static void T2_11Main()
        {
            int n;
            Console.Write("Enter total number of elements: ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter element: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Enter element to search: ");
            int search = Convert.ToInt32(Console.ReadLine());

            int found = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == search)
                {
                    found = 1;
                    break;
                }
            }

            // Print result
            Console.WriteLine(found);
        }
    }
}