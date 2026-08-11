using System;

namespace Practicals
{
    class Line
    {
        private double length;   // Length of a line
        public Line()
        {
            Console.WriteLine("Object creating value of length = 10");
            length = 10;
        }
        public void setLength(double len)
        {
            length = len;
        }
        public double getLength()
        {
            return length;
        }
    }
    class T3_06
    {
        public static void T3_06Main()
        {
            Line line = new Line();
            Console.WriteLine("Length of line : {0}", line.getLength());
            line.setLength(6);
            Console.WriteLine("Length of line : {0}", line.getLength());
        }
    }
}