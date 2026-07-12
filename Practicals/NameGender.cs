using System;

namespace Practicals
{
    internal class NameGender
    {
        public static void Namegen()
        {
            Console.WriteLine("Enter name: ");
            string name=Console.ReadLine();

            Console.WriteLine("Enter Gender: ");
            char gen = Convert.ToChar(Console.ReadLine());

            if (gen == 'M' || gen == 'm')
            {
                Console.WriteLine("Hello Mr. " + name);
            }
            else if (gen == 'F' || gen == 'f')
            {
                Console.WriteLine("Hello Ms. " + name);
            }
            else
            {
                Console.WriteLine("Invalid gender input.");
            }
        }
    }
}