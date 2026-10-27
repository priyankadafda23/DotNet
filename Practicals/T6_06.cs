using System;

namespace Practicals
{
    class T6_06
    {
        public static void T6_06Main()
        {
            try
            {
                Console.Write("Enter first number:");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter second number:");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int result = num1 / num2;
                Console.WriteLine("Result: "+result);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Error: "+ e);
            }
        }
    }
}