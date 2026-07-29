using System;

namespace Practicals
{
    internal class T2_10
    {
        static int MatSearch(int[,] mat, int n, int m, int x)
        {
            int row = 0;
            int col = m - 1;
            while(row<n && col >= 0)
            {
                if (mat[row, col] == x)
                {
                    return 1;
                }
                else if (mat[row, col] == x)
                {
                    col--;
                }
                else
                {
                    row++;
                }
            }
            return 0;
        }
        public static void T2_10Main()
        {
            int[,] mat =
            {
                {3,30,38},
                {44,52,54},
                {57,60,65}
            };
            int result = MatSearch(mat, 3, 3, 50);
            Console.WriteLine(result);
        }
    }
}