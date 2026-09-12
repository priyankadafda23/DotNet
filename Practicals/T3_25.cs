using System;

namespace Practicals
{
    class T3_25
    {
        public static void T3_25Main()
        {
            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            password = password.Trim(); // Remove leading and trailing spaces

            Console.WriteLine("Password Details:");
            Console.WriteLine("Password Length: " + password.Length);

            if (password.Length < 8)
            {
                Console.WriteLine("Password is too short. It should be at least 8 characters long.");
            }
            else
            {
                Console.WriteLine("Password Length is Valid.");

                if (password.Contains("@") ||
                   password.Contains("#") ||
                   password.Contains("$"))
                {
                    Console.WriteLine("Special Character : Available");
                }
                else
                {
                    Console.WriteLine("Special Character : Not Available");
                }
                Console.WriteLine("Uppercase Letters : " + password.ToUpper());
                Console.WriteLine("Lowercase Letters : " + password.ToLower());

                string modifiedPassword = password.Replace('@', '#');
                Console.WriteLine("Modified Password :" + modifiedPassword);

            }
        }
    }
}
