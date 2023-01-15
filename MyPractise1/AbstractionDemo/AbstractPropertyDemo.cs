/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPractise1.AbstractionDemo
{
    abstract class Person
    {
        // uint means it only takes positive value
        public abstract uint Id { get; set; }

        public abstract string Name { get; set; }
    }
    class Student : Person
    {
        uint studentId;
        string studentName;

        public override uint Id
        {
            set
            {
                if (value == 0)
                {
                    Console.WriteLine("Id cannot be Zero ");
                }
                else
                {
                    this.studentId = value;
                }
               
            }
            get
            {
                return this.studentId;
            }
        }
        public override string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Name cannot be null or empty");
                }
                else
                {
                    this.studentName = value;
                }
            }
            get
            {
                return this.studentName;
            }
        }
    }
    class AbstractPropertyDemo
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Id = 10;
            s.Name = "Rahul";
            Console.WriteLine(s.Id);
            Console.WriteLine(s.Name);
            Console.ReadLine();
        }
    }
}
*/