using System;

namespace Practicals
{
    internal class T1_20
    {
        public static void PyramidIncrease()
        {
            int rows = 4;
            int num = 1;

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(num + " ");
                    num++;
                }
                Console.WriteLine();
            }
        }
    }
}