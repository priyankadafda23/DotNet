using System;

namespace Practicals
{
    //static keyword shared by all the objects, it belongs to class
    class Students
    {
        static int count = 0;
        public Students()
        {
            count++;
        }

        //static method
        public static void DisplayCount()
        {
            Console.WriteLine("Total number of Students: " + count);
        }
    }

    class T3_19
    {
        public static void T3_19Main()
        {
            Students s1 = new Students();
            Students s2 = new Students();
            Students s3 = new Students();
            Students s4 = new Students();

            Students.DisplayCount();
        }
    }
}