using System;

namespace Practicals
{
    internal class T2_3
    {
        public static void T2_3Main()
        {
            char firstName = 'J';
            char lastName = 'D';

            Console.WriteLine("Name: " + firstName + " " + lastName);

            Console.WriteLine("Please enter a new first name:");
            firstName = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("New name: " + firstName + " " + lastName);
        }
    }
}