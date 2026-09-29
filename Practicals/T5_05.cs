using System;

namespace Practicals
{
    class T5_05
    {
        public static void T5_05Main()
        {
            int[] arr = { 50, 30, 10, 40, 50, 50, 40, 60, 30 };
            int duplicateCount = 0;

            for(int i=0; i<arr.Length; i++)
            {
                bool alreadyChecked = false;
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        alreadyChecked = true;
                        break;
                    }
                }
                if (alreadyChecked)
                    continue;

                int count = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }
                if (count > 1)
                {
                    Console.WriteLine("Element {0} is repeated {1} times.", arr[i], count);
                    duplicateCount++;
                }
            }
            Console.WriteLine("Number of duplicate elements: {0}", duplicateCount);
        }
    }
}