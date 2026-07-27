using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicals
{
    internal class basics
    {
            public static void basicsMain() {
            Console.WriteLine("1. Reverse a string");
            //algorithm:
            //1. take input string from user
            //2. empty variable to store reversed string
            //3. loop through string from end to start
            //4. rev=rev+str[i]
            //5. print reversed string

            Console.Write("Enter a string to reverse:");
            string str = Console.ReadLine();

            string rev = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                rev += str[i];
            }
            Console.WriteLine("Reversed String:" + rev);



            Console.Write("\n2. Check palindrome");
            //algorithm:
            //1. take input string from user
            //2. reverse the string
            //3. check if str and rev is same or not.
            //4. if equal then print palindrome; otherwise print not palindrome.

            Console.Write("Enter a string to check Palindrome:");
            string str1 = Console.ReadLine();

            string rev1 = "";
            for (int i = str1.Length - 1; i >= 0; i--)
            {
                rev1 += str1[i];
            }
            if (str1 == rev1)
            {
                Console.WriteLine("The String is Palindrome");
            }
            else
            {
                Console.WriteLine("The String is not Palindrome.");
            }



            Console.Write("\n3. Count vowels and constants");
            Console.Write("\n4. Count uppercase.lowercase,digits and special characters");
            Console.Write("\n5. Find length without using length");
            Console.Write("\n6. Convert uppercase to lowercase(without built-in function)");
            Console.Write("\n7. Convert lowercase to uppercase");
            Console.Write("\n8. Remove spaces.");
            Console.Write("\n9. count number of words");

        }
    }
}
