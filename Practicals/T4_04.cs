using System;

namespace Practicals
{
    class StaticVar
    {
        public static int num;

        // Corrected from 'counting()' to match the method call 's.count()'
        public void count()
        {
            num++;
        }
        public static int getNum()
        {
            return num;
        }
    }

    class T4_04
    {
        public static void T4_04Main()
        {
            StaticVar s = new StaticVar();
            s.count();
            s.count();
            s.count();

            Console.WriteLine("Variable num: {0}", StaticVar.getNum());
        }
    }
}
