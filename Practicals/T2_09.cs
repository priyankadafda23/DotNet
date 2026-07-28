using System;

namespace Practicals
{
    internal class T2_09
    {
        public static void T2_09Main()
        {
            int[] arr = { 1, 2, 3, 2, 1, 4 };
            Console.WriteLine("Numbers occuring once:");
            for(int i=0; i < arr.Length; i++)
            {
                int count= 0;
                for (int j=0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }
                if (count == 1)
                {
                    Console.WriteLine(arr[i] + " ");
                }
            }
        }
    }
}