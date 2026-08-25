using System;

namespace Practicals
{
    //base class
    class Shape
    {
        private double area;

        //virtual keyword used in parent's class method
        public virtual void CalculateArea()
        {
            Console.WriteLine("Area of shape...");
        }
    }
    //derived class
    class Circle : Shape
    {
        public override void CalculateArea()
        {
            double radius = 5;
            double area = Math.PI * radius * radius;
            Console.WriteLine("Area of Circle: " + area);
        }
    }

    class Rectangle : Shape
    {
        public override void CalculateArea()
        {
            double length = 10;
            double width = 20;
            double area = length * width;
            Console.WriteLine("Area of Rectangle: " + area);
        }
    }

    class Triangle : Shape
    {
        public override void CalculateArea()
        {
            double b = 5;
            double h = 10;
            double area = 0.5 * b * h;
            Console.WriteLine("Area of Triangle: " + area);
        }
    }
    class T3_17
    {
        public static void T3_17Main()
        {
            //Shape s;

            Shape c = new Circle();
            c.CalculateArea();

            Shape r = new Rectangle();
            r.CalculateArea();

            Shape t = new Triangle();
            t.CalculateArea();
        }
    }
}