/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPractise1.OopsStudy
{
    class Person
    {
        public string firstName;
        public string lastName;
        public int age;
        public long phoneNumber;

        public abstract void PrintDetails();
    }
    class Student : Person
    {
        public int rollNo;
        public int fees;

        public override void PrintDetails()
        {
            string name = this.firstName + " " + this.lastName;
            Console.WriteLine("Student name is :{0}", name);
            Console.WriteLine("Student age is :{0}", this.age);
            Console.WriteLine("Student phoneNumber is : {0}", this.phoneNumber);
            Console.WriteLine("Student roll no is : {0}", this.rollNo);
            Console.WriteLine("Student fees is :{0}", this.fees);
        }

    }
    class Teacher : Person
    {
        public string qualification;
        public int salary;

        public override void PrintDetails()
        {
            string name = this.firstName + " " + this.lastName;
            Console.WriteLine("Teacher name is :{0}", name);
            Console.WriteLine("Teacher age is :{0}", this.age);
            Console.WriteLine("Teacher phoneNumber is : {0}", this.phoneNumber);
            Console.WriteLine("Teacher qualification is :{0}", this.qualification);
            Console.WriteLine("Teacher salary  is : {0}", this.salary);

        }
    }
    class ACAndAM
    {
        static void Main(string[] args)
        {
            Student Rahul = new Student();
            Rahul.firstName = "Rahul";
            Rahul.lastName = "Kale";
            Rahul.age = 24;
            Rahul.phoneNumber = 90008004000;
            Rahul.fees = 30000;
            Rahul.rollNo = 10;
            Rahul.PrintDetails();

            Console.WriteLine("................................");

            Teacher t = new Teacher();
            t.firstName = "Shital";
            t.lastName = "Chaudhari";
            t.phoneNumber = 9093893889;
            t.salary = 500000;
            t.qualification = "M.E";
            t.PrintDetails();

            Console.ReadLine();

        }
    }
}
*/