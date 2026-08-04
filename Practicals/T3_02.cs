using System;

namespace Practicals
{
    class Clock
    {
        private int hour;
        private int min;
        private int sec;

        //empty/default constructor
        public Clock()
        {
            hour = 12;
            min = 0;
            sec = 0;
        }

        //paramterized constructor
        public Clock(int h, int m, int s)
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
            Console.Write($"{hour:d2}:{min:d2}:{sec:d2}");
        }

        //return hour
        public int gethour()
        {
            return hour;
        }

        //return minute
        public int getmin()
        {
            return min;
        }

        //return second
        public int getsec()
        {
            return sec;
        }
    }
    internal class T3_02
    {
        public static void T3_02Main()
        {
            Clock c1 = new Clock(); //creating object
            Console.WriteLine("Default Time:");
            c1.display(); //displaying values

            Clock c2 = new Clock(10,59,08);//creating object
            Console.WriteLine("Initial Time:");
            c2.display(); //displaying values

            Console.WriteLine("Increment time after 1 second:");
            c2.incrementSecond();
            c2.display(); //displaying values

            Console.WriteLine("Increment time after 2 seconds:");
            c2.incrementSecond();
            c2.display(); //displaying values

            //display individual values
            Console.WriteLine("Hour: " + c2.gethour());
            Console.WriteLine("Minute: " + c2.getmin());
            Console.WriteLine("Second: " + c2.getsec());
        }
    }
}