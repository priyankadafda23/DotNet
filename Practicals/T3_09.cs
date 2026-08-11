using System;

namespace Practicals
{
    class Clock9
    {
        private int hour;
        private int min;
        private int sec;

        //paramterized constructor
        public Clock9(int h, int m, int s)
        {
            hour = h;
            min = m;
            sec = s;
        }

        //increment time to next second
        public void incrementSecond()
        {
            sec++;
            if (sec == 60)
            {
                sec = 0;
                min++;
                if (min == 60)
                {
                    min = 0;
                    hour++;
                    if (hour == 24)
                    {
                        hour = 0;
                    }
                }
            }
        }

        //display time
        public void display()
        {
            Console.Write($"{hour:d2}:{min:d2}:{sec:d2}\n");
        }
    }
    internal class T3_09
    {
        public static void T3_09Main()
        {
            Clock9 c2 = new Clock9(10, 59, 08);//creating object
            Console.Write("Initial Time:");
            c2.display(); //displaying values

            Console.Write("Increment time after 1 second:");
            c2.incrementSecond();
            c2.display(); //displaying values


        }
    }
}