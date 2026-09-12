using System;

namespace Practicals
{
    class T3_26
    {
        public static void T3_26Main()
        {
            Console.Write("Enter Customer Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("String Operations:");

            name = name.Trim();
            Console.WriteLine("After Trim: " + name);
            Console.WriteLine("Uppercase Name: " + name.ToUpper());
            Console.WriteLine("Lowercase Name: " + name.ToLower());

            string replacedName = name.Replace(' ', '_');
            Console.WriteLine("After Replacing: " + replacedName);

            string formattedName = name.Insert(0, "Ms. ");

            Console.WriteLine("After Insert: " + formattedName);
            Console.WriteLine("Length of Name: " + name.Length);
        }
    }
}
