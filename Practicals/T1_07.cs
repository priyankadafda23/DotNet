using System;

namespace Practicals
{
    internal class T1_07
    {
        public static void Table()
        {
            int num1, res, i;

            Console.Write("Enter a number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            i = 1;
            while (i <= 10)
            {
                res = num1 * i;
                Console.WriteLine("{0} x {1} = {2}", num1, i, res);

                i++;
            }
            Console.ReadLine();
        }
    }
}