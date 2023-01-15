/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPractise1.CollectionStudy
{
    class Student
    {
        public int id;
        public string name;

        public Student(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
    class CustomListDemo
    {
        static void Main(string[] args)
        {
            List<Student> li = new List<Student>();
            li.Add(new Student(101, "Amit"));
            li.Add(new Student(102, "Rahul"));
            li.Add(new Student(103, "Jitesh"));

            foreach (Student s in li)
            {
                Console.WriteLine(s.id + " " + s.name);
            }
            Console.ReadLine();
        }
    }
}
*/