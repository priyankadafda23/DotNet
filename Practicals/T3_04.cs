using System;

namespace Practicals
{
    class Students4
    {
        public int id;
        public string name;

        //properties
        public int Id
        {
            //get value read
            get
            {
                return id;
            }
            //set value write
            set
            {
                id = value;
            }
        }

        public string Name
        {
            //get value read
            get
            {
                return name;
            }
            //set value write
            set
            {
                name = value;
            }
        }

        //empty constructor
        public Students4()
        {
            id = 0;
            name = "unknown";
        }

        //paramterized constructor
        public Students4(int i, string n)
        {
            id = i;
            name = n;
        }

        public void display()
        {
            Console.WriteLine("Id:" + id);
            Console.WriteLine("Name:" + name);
            Console.WriteLine("\n");
        }
    }

    internal class T3_04
    {
        public static void T3_04Main()
        {
            Console.WriteLine("Empty Constructor:");
            Students4 s1 = new Students4(); //creating object
            s1.display();

            Console.WriteLine("Parameterized Constructor:");
            //creating object
            Students4 s2 = new Students4(14, "Priyanka");
            Students4 s3 = new Students4(29, "Tisha");
            Students4 s4 = new Students4(11, "Bhoomi");
            Students4 s5 = new Students4(10, "Riya");
            //displaying values
            s2.display();
            s3.display();
            s4.display();
            s5.display();
        }
    }
}