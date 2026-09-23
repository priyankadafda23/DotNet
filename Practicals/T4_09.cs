using System;

namespace Practicals {
    class T4_09
    {
        public static void T4_09Main()
        {
            try
            {
                int x = 0;
                int div = 100 / x;
                Console.WriteLine(div);
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Finally block executed.");
            }
        }
    }
}