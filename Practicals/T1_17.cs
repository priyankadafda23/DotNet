using System;

namespace Practicals
{
    internal class T1_17
    {
        public static void PyramidNum()
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}