using System;
using System.Collections.Generic;
using System.Linq;

namespace Practicals
{
    class Student6
    {
        public int id { get; set; }
        public string name { get; set; }
        public string course { get; set; }
        public int marks { get; set; }

    }
    class T6_12
    {
        public static void T6_12Main()
        {
            List<Student6> students = new List<Student6>
            {
                new Student6
                {
                    id = 1, name = "Priyanka",course = "BTech", marks = 85
                },
                new Student6
                {
                    id = 2, name = "Tisha",course = "BTech", marks = 88
                },
                new Student6
                {
                    id = 3, name = "Rahul",course = "BTech", marks = 75
                },
                new Student6
                {
                    id = 4, name = "Neha",course = "BTech", marks = 60
                }
            };
            var result = from s in students 
                         where s.marks > 70 
                         orderby s.marks 
                         select s;

            Console.WriteLine("Students having marks greater than 70:");

            foreach(Student6 s in result)
            {
                Console.WriteLine(s.id +" " + s.name + " " + s.course + " " + s.marks);
            }
        }
    }
}