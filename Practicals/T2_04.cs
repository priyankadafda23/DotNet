using System;

namespace Practicals
{
    internal class T2_04
    {
        public static void T2_4Main()
        {
            Console.WriteLine("Enter a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b:");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n---Arithmetic Operator:---");
            Console.WriteLine("Addition is: " + (a + b));
            Console.WriteLine("Subtraction is: " + (a - b));
            Console.WriteLine("Multiplication is: " + (a * b));
            Console.WriteLine("Division is: " + (a / b));

            Console.WriteLine("\n---Relational Operator:---");
            Console.WriteLine("a == b: " + (a == b));
            Console.WriteLine("a != b: " + (a != b));
            Console.WriteLine("a > b: " + (a > b));
            Console.WriteLine("a < b: " + (a < b));

            Console.WriteLine("\n---Logical Operator:---");
            Console.WriteLine("a > b && b > a: " + (a > b && b > a));
            Console.WriteLine("a > b || b > a: " + (a > b || b > a));
            Console.WriteLine("!(a == b): " + (!(a == b)));
        }
    }
}