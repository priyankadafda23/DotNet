using System;

namespace Practicals
{
    internal class T1_10
    {
        public static void MobileNum()
        {
            Console.Write("Enter Mobile Number:");
            string num = Console.ReadLine();
            if (num.Length >= 5)
            {
                string res = num.Substring(0, num.Length - 5) +"XXXXX";
                Console.WriteLine(res);
            }
        }
    }
}