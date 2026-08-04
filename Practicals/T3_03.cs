using System;

namespace Practicals
{
    class Students3
    {
        public int id;
        public string name;

        //properties
        public int Id
        {
            //get value read
            get {
                return id;
            }
            //set value write
            set{
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
        public Students3(){
            id=0;
            name="unknown";
        }

        //paramterized constructor
        public Students3(int i, string n)
        {
            id = i;
            name = n;
        }

        public void display()
        {
            Console.WriteLine("Id:" + id);
            Console.WriteLine("Name:" + name);
        }
    }

    internal class T3_03
    {
        public static void T3_03Main()
        {
            Console.WriteLine("Empty Constructor:");
            Students3 s1 = new Students3(); //creating object
            s1.display();

            Console.WriteLine("Parameterized Constructor:");
            Students3 s3 = new Students3(14,"Priyanka"); //creating object
            s3.display();
        }
    }
}