using System;

namespace Practicals
{
    class T6_09
    {
        public static void T6_09Main()
        {
            Console.Write("Enter first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Func<int, int, int> add = (x, y) => x + y;
            Func<int, int, int> mul = (x, y) => x * y;
            Func<int, int, int> max = (x, y) => x > y? x : y;

            Console.WriteLine("\nAddition: " + add(num1,num2));
            Console.WriteLine("Multiplication: " + mul(num1, num2));
            Console.WriteLine("Maximum Value: " + max(num1, num2));
        }
    }
}