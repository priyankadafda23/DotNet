using System;

namespace Practicals
{
    internal class T1_09
    {
        public static void ToggleCase()
        {
            Console.Write("Enter a String: ");
            string str = Console.ReadLine();
            string toggledStr = "";

            foreach (char c in str)
            {
                if (char.IsUpper(c))
                {
                    toggledStr += char.ToLower(c);
                }
                else if (char.IsLower(c))
                {
                    toggledStr += char.ToUpper(c);
                }
                else
                {
                    toggledStr += c;
                }
            }
            Console.WriteLine("Toggled String: " + toggledStr);
        }
    }
}