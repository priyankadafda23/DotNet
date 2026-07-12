using System;

namespace Practicals
{
    internal class Uppercase
    {
        public static void Lowertoupper()
        {
            string name;
            Console.WriteLine("Enter name:");
            name = Console.ReadLine();
            Console.WriteLine("Uppercase:" + name.ToUpper());
        }
    }
}
