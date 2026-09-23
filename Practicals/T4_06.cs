using System;

namespace Practicals
{
    abstract class Test
    {
        protected int a;
        public abstract void A();
    }

    class Example1 : Test
    {
        public override void A()
        {
            Console.WriteLine("Example1.A");
            a++;
        }
    }

    class Example2 : Test
    {
        public override void A()
        {
            Console.WriteLine("Example2.A");
            a--;
        }
    }

    class T4_06
    {
        public static void T4_06Main()
        {
            // Reference Example1 through Test type.
            Test test1 = new Example1();
            test1.A();
            // Reference Example2 through Test type.
            Test test2 = new Example2();
            test2.A();
        }
    }
}