using System;

namespace Practicals
{
    internal class T1_13
    {
        public static void Fibonacciseries()
        {
            int n1 = 0,n2 = 1, n3;
            Console.Write(n1 + " " + n2 + " ");

            for (int i = 2; i <= 10; i++)
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
        }
    }
}