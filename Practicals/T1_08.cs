using System;

namespace Practicals
{
    internal class T1_08
    {
        public static void Lowertoupper()
        {
            string name;
            Console.Write("Enter name: ");
            name = Console.ReadLine();
            Console.WriteLine("Uppercase: " + name.ToUpper());
        }
    }
}
