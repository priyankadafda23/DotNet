using System;

namespace Practicals
{
    class Ab
    {
        public int x;
        public int y;
    }

    class Ba : Ab
    {
        public int z;
    }

    class T4_07
    {
        public static void T4_07Main()
        {
            Ab sc = new Ab();
            sc.x = 110;
            sc.y = 150;
            Console.WriteLine("x = {0}, y = {1}", sc.x, sc.y);
        }
    }
}