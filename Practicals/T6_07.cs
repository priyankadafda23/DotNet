using System;

namespace Practicals
{
    class T6_07
    {
        public static void T6_07Main()
        {
            try
            {
                Console.Write("Enter a number:");
                int num1 = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("Error: " + e);
            }
            finally
            {
                Console.WriteLine("\nFormat exception implemented.");
            }
        }
    }
}