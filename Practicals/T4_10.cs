using System;

namespace Practicals
{
    class MyException : Exception
    {
        public MyException(string str)
        {
            Console.WriteLine("User defined exception");
        }
    }
    class T4_10
    {
        public static void T4_10Main()
        {
            try
            {
                throw new MyException("my exception generated.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught here: " + e.Message);
            }
            Console.WriteLine("LAST STATEMENT");
        }
    }
}